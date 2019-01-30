var LRGlobalFunc = LRGlobalFunc || {};
    
var beforehistory = [];
var beforid = "";
var gcurrentPageIndex = 0;

var currentlang = "th";

var gswalText = ko.observable({});
gswalText(dic_swal_lang_th);
//$.extend(gswalText , dic_swal_lang_th);

var gleavedic = ko.observable({});
gleavedic(dic_lang_th);
//$.extend(gleavedic, dic_lang_th);

(function () {
    "use strict";
    LRGlobalFunc.AddNameSpace = function (namespace) {
        ///<summary>
        /// Define New Namespance or class into the root namespace.
        ///</summary>
        /// <param name="namespace" type="String">Name of the new namespace.</param>
        /// <returns type="Object">Parent namespace</returns>
        var nsparts = namespace.split("."), parent = LRGlobalFunc, i = 0, partname;

        // we want to be able to include or exclude the root namespace so we strip
        // it if it's in the namespace
        if (nsparts[0] === "LRGlobalFunc") {
            nsparts = nsparts.slice(1);
        }

        // loop through the parts and create a nested namespace if necessary
        for (i = 0; i < nsparts.length; i++) {
            partname = nsparts[i];
            // check if the current parent already has the namespace declared
            // if it isn't, then create it
            if (!parent[partname]) {
                parent[partname] = {};
            }
            // get a reference to the deepest element in the hierarchy so far
            parent = parent[partname];
        }
        // the parent is now constructed with empty namespaces and can be used.
        // we return the outermost namespace
        return parent;
    };

    LRGlobalFunc.getParameterByName = function(name, url) {
	    if (!url) url = window.location.href;
	    name = name.replace(/[\[\]]/g, "\\$&");
	    var regex = new RegExp("[?&]" + name + "(=([^&#]*)|&|#|$)"),
	        results = regex.exec(url);
	    if (!results) return null;
	    if (!results[2]) return '';
	    return decodeURIComponent(results[2].replace(/\+/g, " "));
	};

    LRGlobalFunc.datawithpaging = function(options){
		options = options || {};
		var self =this;
		this.showPaging = ko.observable(typeof options.showPaging !== 'undefined'?options.showPaging : true);
	    this.pageSize = ko.observable(typeof options.pageSize !== 'undefined'?options.pageSize : 15);
		this.rows = ko.observableArray([]);
		this.pagingObj = ko.observable();
		//this.leavedatas
		//this.leavedata = ko.computed(function() {
	    //    //var first = self.pageNumber() * self.nbPerPage;
	    //    return self.leavedatas.slice(0, 5);
	    //});
	    this.totalItems = ko.computed(function() {
	          return self.rows ().length;
	    }, this);
	
	    this.pageIndex = ko.observable(0),
	    this.gotoPage = function(data) {
	        self.pageIndex(data);
	        LRGlobalFunc.gcurrentPageIndex = data;
	    },
	    this.maxPageIndex = ko.computed(function() {
	      // var m =Math.ceil(self.rows().length / self.pageSize());
	      // console.log(m);
	       return Math.ceil(self.rows().length / self.pageSize());
	   }, this);
	    this.datas = ko.computed(function() {
	        //console.log(self.rows());
	        var curpage =self.pageIndex();
	        var size = self.pageSize();
	        var start = (curpage===0?curpage:curpage-1) * size;
	        return self.rows().slice(start, start + size);
	    }, self);
	    this.ishasdata = ko.computed(function() {
	          return self.rows().length > 0;
	    }, this);
	
	};
    
    
    LRGlobalFunc.IsCrossDomain = false;
    LRGlobalFunc.WorkflowsCanUseAppPermissions = 'ec918931-c874-4033-bd09-4f36b2e31fef';
    
    LRGlobalFunc.SaveDatatoList=function(options){
		//options.ctxUrl = options.ctxUrl || _spPageContextInfo.webAbsoluteUrl;
		var deferred = $.Deferred();
			var data = options.data || [];
			options.itemid = options.itemid || 0;
			if (options.listTitle) {
			                //Get SP clientContext
			                SharePointClient.Configurations.IsCrossDomainRequest = LRGlobalFunc.IsCrossDomain;
			                //SharePointClient.Configurations.SPUrl = utility.GetHostUrl();
			                var hostcontext = new SharePointClient.Services.JSOM.Context();
			                //get current context
			                var ctx = hostcontext.GetClientContext();
			                //get current web  
			                var web = hostcontext.GetWeb();
	
			                //SharePointClient.Configurations.IsCrossDomainRequest = false;
			                //var ctx = new SP.ClientContext(options.ctxUrl);
			                var oList = web.get_lists().getByTitle(options.listTitle);
	                        
							var itemCreateInfo = new SP.ListItemCreationInformation();
						    var oListItem  = null;
						    if(options.itemid === 0){
						   		 oListItem   = oList.addItem(itemCreateInfo);
						    }
						    else{
						    	oListItem  = oList.getItemById(options.itemid);
	
						    }
						    
						  	for(var i=0;i<data.length;i++){
						  		oListItem.set_item(data[i].Title,data[i].Value);
						  	}			        
						    oListItem.update();
						
						    ctx.load(oListItem);					
			    			ctx.executeQueryAsync(function() {
			    				//console.log("success"+oListItem.get_item("ID"));
			    				deferred.resolve(parseInt(oListItem.get_item("ID"),10),oListItem);							
			    			}, function (sender, args) {
							//return deferred.reject('Failed to find workflow assosiate list. Error:' + args.get_message());
								deferred.reject('Failed to add/update item. Error:' + args.get_message());
						   });
		}
		else
		{
			deferred.reject('Failed to find List Title.');

		}
		
		return deferred.promise();
	};

    LRGlobalFunc.queryDataJSOM = function (valueAccessor, props, callback) {
        props.listtitle = props.listtitle || "";	
        if(props.listtitle.length === 0){
            if(callback){
                callback();
            }

        } 		    
        props.query = props.query || "";
        props.view = props.view || "";
        props.orderby =  props.orderby || "<FieldRef Name='Created' Ascending='false'/>";
        props.rowlimit =  props.rowlimit || 100;
        props.options =  props.options || {};
				
				
        //if(typeof valueAccessor() === "undefined"){
        //	valueAccessor(new ToraAsiaSarabun.Services.datawithpaging())
        //}
        SharePointClient.Configurations.IsCrossDomainRequest = LRGlobalFunc.IsCrossDomain;
        var listServices = new SharePointClient.Services.JSOM.ListServices();
				
        //Get SP clientContext
        var context = new SharePointClient.Services.JSOM.Context();				
        //Create Caml object
        var camlConstant = SharePointClient.Constants.CAML_CONSTANT;
        var camlQuery = new SharePointClient.CamlExtension.JSOM.CamlQuery();
				        
        camlQuery
        .ViewAttribute(props.view)
        .Query(props.query)
        .QueryThrottleMode(camlConstant.CAML_QUERY_THROTTLE_MODE.OVERRIDE)
        .OrderByMe(props.orderby)
        .RowLimit(props.rowlimit);
        //.FolderServerRelativeUrl(self.selectdFolder());

        listServices.GetListItemsBatchByListName(context, 
                props.listtitle, camlQuery.BuildQuery()).Execute(function (result) {
				        		
                    var alldata = 	ko.getdataFromEnum({
                        ItemEnum:result,
                        filedDisplay:props.options.fileData,
                        format :props.options.format			        	
                    },props.options);	

                    var olddata = valueAccessor();
                    var newdata = olddata.concat(alldata);
                    valueAccessor(newdata);

				               
                    var nextpost = result.get_listItemCollectionPosition();
                    if(nextpost ==null){
                        if(callback){
                            callback();
                        }

                    }
                }); 
	
    };
    LRGlobalFunc.swalalrt = function (opt,funcok,funcother) {
    	    swal(opt)
                .then(function (r) {
    	        if (r.value) {
    	            if (typeof funcok !== "undefined" && typeof funcok === "function" && funcok !== null) {
    	                funcok(r.value);
    	            }
				}
				//console.log(r.value);
    	        if (typeof funcother !== "undefined" && typeof funcother === "function" && funcother !== null) {
    	            funcother(r.value);
    	        }
    	    });
    };

    
})();
