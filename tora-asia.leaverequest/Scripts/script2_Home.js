function LRHomeViewModel(parent) {
	var self = this;

	ko.contentDialog.show();
	this.datawithpaging = ko.observable(new LRGlobalFunc.datawithpaging({ pageSize: 10 }));
	beforid = "idhomepage";
	/*this.showPaging = ko.observable(true);
    this.pageSize = ko.observable(5);
	this.leavedatas = ko.observableArray([]);
	this.pagingObj = ko.observable();
	//this.leavedatas
	//this.leavedata = ko.computed(function() {
    //    //var first = self.pageNumber() * self.nbPerPage;
    //    return self.leavedatas.slice(0, 5);
    //});
    this.totalItems = ko.computed(function() {
          return self.leavedatas().length;
    }, this);

    this.pageIndex = ko.observable(0),
    this.gotoPage = function(data) {
        self.pageIndex(data);
    },
    this.maxPageIndex = ko.computed(function() {
      // var m =Math.ceil(self.rows().length / self.pageSize());
      // console.log(m);
       return Math.ceil(self.leavedatas().length / self.pageSize());
   }, this);
    this.leavedata = ko.computed(function() {
        //console.log(self.rows());
        var curpage =self.pageIndex();
        var size = self.pageSize();
        var start = (curpage===0?curpage:curpage-1) * size;
        return self.leavedatas().slice(start, start + size);
    }, self);
    this.ishasdata = ko.computed(function() {
          return self.leavedatas().length > 0;
    }, this);
    */

	/*this.bindStatus = function (data) {
		var ls = data[LRListManagement.Lists.LeaveRequestItem.Fields.LeaveStatus.Internal];
		//var cls = data["CancelLeaveStatus"];
		var cssdath = "";
		var csslscolor = "color-yellow";
		var cssclscolor = "color-yellow";
		if (ls === "Approved") {
			csslscolor = "color-green";
		}
		else if (ls === "Rejected") {
			csslscolor = "color-red";

		}
		else if ( ls.indexOf("Cancelled") >= 0){
			csslscolor = "color-black";
		}
		return "<span class='" + cssdath + " " + csslscolor + "'>" + ls + "</span>";
		//if (cls === "Rejected" || cls === "Cancelled") {
		//	cssclscolor = "color-red";
		//}
		//if (cls === "Cancelled") {
		//	cssdath = "txt-dash";
		//}
		//var arrls = [];
		//arrls.push("<span class='" + cssdath + " " + csslscolor + "'>" + ls + "</span>");
		//if (cls !== null && cls !== "Rejected") {
		//	arrls.push("<span class='" + cssclscolor + "'>" + cls + "</span>");

		//}
		//return arrls.join(" ");
	}
	this.bindDate = function (data) {
        var sd = data[LRListManagement.Lists.LeaveRequestItem.Fields.StartDate.Internal];
        var ed = data[LRListManagement.Lists.LeaveRequestItem.Fields.EndDate.Internal];
        var tday = data[LRListManagement.Lists.LeaveRequestItem.Fields.LeaveDayTotal.Internal];
        var inttday = parseInt(tday, 10);
        if (inttday > 1) {
            return sd + " - " + ed;
        }
        return sd;
    }*/
	this.goToApproveForm = function (data) {
		//console.log(data.LeaveId());
		//parent.selectTemplate("idwating");
		//parent.selectModel (new LRApproveViewModel(parent,data.LeaveId(),data.Id,self.ishrForm()));
		//parent.selectTemplate("idapproveform");
		parent.GoToApproveViewModel(parent, data, data.ID, "idhomepage", true, false);
	}

	this.leavedays = ko.observableArray([]);
	this.leavedaysfilter = ko.computed(function () {
		//console.log(self.rows());
		//self.leavedatas()    
		return self.leavedays();
	}, self);

	/*this.afterLeaveRemianSuccess = function(leavedataarr,condtionarr,callback){
		var myleaveremainarr = [];
			ko.utils.arrayForEach(LRServices.Variables.OfficerQuota, function (quo_item) {
				var myremain = ko.utils.arrayFilter(condtionarr(), function (cdata) {
					return cdata[LRListManagement.Lists.LeaveRequestCondition.Fields.LeaveCode.Internal] ===
						quo_item.code
				});
				if (myremain.length > 0) {
					var inpro_leave = 0;
					var filter_leave =  ko.utils.arrayFilter(leavedataarr(), function(c_item) {
						return c_item[LRListManagement.Lists.LeaveRequestItem.Fields.LeaveType.Internal] 
								== quo_item.code && c_item[LRListManagement.Lists.LeaveRequestItem.Fields.LeaveStatus.Internal] 
								== LRServices.Variables.LeaveStatus.InProgress;
					});
					ko.utils.arrayForEach(filter_leave, function (f_item) {
						inpro_leave += parseInt(f_item[LRListManagement.Lists.LeaveRequestItem.Fields.LeaveDayTotal.Internal],10);	
					});
					var remailobj = {};
					var maxday = parseInt(quo_item.max, 10);
					var approveday = parseInt(quo_item.total, 10);
					//var approveday = 
					remailobj.Title = myremain[0][LRListManagement.Lists.LeaveRequestCondition.Fields.Title.Internal];
					remailobj.MaxLeaveValue = maxday;
					remailobj.MyUseDay = {};
					remailobj.MyUseDay.approve = maxday - approveday;
					remailobj.MyUseDay.inprogress = inpro_leave;

					myleaveremainarr.push(remailobj);
				}
		});
		self.leavedays(myleaveremainarr);
		callback();
	}
	this.loadLeaveRemian = function (callback) {
		var countfunction = 2;
		var currentfunction = 0;
		var leavedataarr = ko.observableArray();
		var condtionarr = ko.observableArray();
		LRServices.GetLeaveItemsCurrentYear(LRServices.Variables.CurrentQuotaYear).then(function (leaveitem_data) {
			leavedataarr(leaveitem_data);
			currentfunction = currentfunction + 1;
			if(currentfunction === countfunction){
				self.afterLeaveRemianSuccess(leavedataarr,condtionarr,callback);
			}
		});
		LRServices.GetLeaveRequestConditionData().then(function (condition_data) {
			condtionarr(condition_data);
			currentfunction = currentfunction + 1;
			if(currentfunction === countfunction){
				self.afterLeaveRemianSuccess(leavedataarr,condtionarr,callback);
			}
		}, LRServices.errorshowaler);
	}*/
	//LRServices.LoadLeaveRemian(LRServices.LoadLeaveRemian );
	this.calulateDay = function (data) {
		//console.log(data);
		var maxd = parseFloat(data.MaxLeaveValue.toString(), 10);
		var inprod = parseFloat(data.MyUseDay.inprogress.toString(), 10);
		var appd = parseFloat(data.MyUseDay.approve.toString(), 10);
		return maxd - inprod - appd;
	}
	this.loadAllLeaveData = function (callback) {
		var allquery = [];
		var allquerystr = "";
		allquery.push(String.format(ko.defaultquery, "Eq", "Requester", "Lookup", _spPageContextInfo.userId, "LookupId='TRUE'", ""));

		if (allquery.length > 0) {
			allquerystr = "<Where>" + ko.MergeCAMLConditions(allquery, ko.MergeType.And) + "</Where>";
		}
		LRServices.GetLeaveItems(self.datawithpaging().rows,allquerystr).then(function () {
		}, LRServices.errorshowaler);

		callback();
		//ToraAsiaLeaveRequestInfo.Services.GetAllMyLeaveRequest(self.datawithpaging().rows,allquerystr ).then(function(){
		//OK
		//callback();
		//});   		    
	}
	this.countloading = ko.observable(0);
	//console.log(gcurrentPageIndex);
	this.loadAllLeaveData(function () {
		//console.log(self.leavedatas());
		//console.log(self.leavedata());
		var oldcount = self.countloading();
		var newcount = oldcount + 1;
		self.countloading(newcount);
		//self.datawithpaging().pageIndex(gcurrentPageIndex);
		if (newcount === 2) {
			ko.contentDialog.hide();
		}
	});
	LRServices.LoadLeaveRemian(function (myleavearr) {
		//console.log(self.leavedays());
		self.leavedays(myleavearr);
		var oldcount = self.countloading();
		var newcount = oldcount + 1;
		self.countloading(newcount);
		if (newcount === 2) {
			ko.contentDialog.hide();
		}

	});
	/*this.loadLeaveRemian(function () {
		//console.log(self.leavedays());
		var oldcount = self.countloading();
		var newcount = oldcount + 1;
		self.countloading(newcount);
		if (newcount === 2) {
			ko.contentDialog.hide();
		}

	});*/

}
