function WorkingDaysCheck(name, checked)
{
  var self = this;
  
  self.Name = ko.observable(name || "Unnamed");
  self.IsChecked = ko.observable(checked || false);
}
function LRSettingViewModel(parent){
	var self = this;
	//console.log(parent.parent.selectLang());
	this.listoptions = LRListManagement.Lists.LeaveRequestConfiguration.Title;
	this.dateformate = "DD MMMM";
	this.oldcircledate = ko.observable(LRServices.Variables.EndCircleDate);
	this.circledate = ko.observable(LRServices.Variables.EndCircleDate);
	this.circleEnable = ko.observable(false);
	this.NavLinkArr = ko.observableArray([
    	{ title: gleavedic().setting.addform, url: LRListManagement.Lists.LeaveRequestCondition.Url, icon: "fa-list-alt" },
    	{ title: gleavedic().setting.adduser, url: LRListManagement.Lists.LeaveRequestOfficer.Url, icon: "fa-user" },
    	{ title: gleavedic().setting.leavehdd, url: LRListManagement.Lists.LeaveRequestItem.Url, icon: "fa-hdd" },
		{ title: gleavedic().setting.holiday, url: LRListManagement.Lists.LeaveRequestHoliday.Url, icon: "fa-calendar-alt" },
		{ title: gleavedic().setting.quota, url: LRListManagement.Lists.LeaveRequestQuota.Url, icon: "fa-calendar-alt" },
    ]);
    
   
    this.workingEnable = ko.observable(false);
    this.allday= ko.observableArray(LRServices.Variables.AllDays);
	
	var workingDays =	LRServices.Variables.WorkingDays ;
    this.oldworkingDays = ko.observableArray(workingDays.slice()); 
    this.workingDays= ko.observableArray(workingDays.slice()); 
	
	//this.language =	ko.observable(LRServices.Variables.SelectLanguage);
	//this.oldlanguage = ko.observable(LRServices.Variables.SelectLanguage); 
	//this.langEnable = ko.observable(false);

	this.ruunningformat = ko.observable();
	this.oldruunningformat = ko.observable();
	if(typeof LRServices.Variables.RunningFormat === "object"){
		if(typeof LRServices.Variables.RunningFormat["format"] !== "undefined"){
			var fdata = LRServices.Variables.RunningFormat["format"];
			this.ruunningformat(fdata);
			this.oldruunningformat(fdata);
		}
	}
	this.ruunningEnable = ko.observable(false);

    this.errorshowaler = function(err_msg){
		LRGlobalFunc.swalalrt({
            title: err_msg,
            type: 'error'
        }, null, function () {
            ko.contentDialog.hide();
        });

	}
	this.ConfirmAndSave = function(confirm_text,config_value,config_id,data_value,callback){
		LRGlobalFunc.swalalrt({
			title: confirm_text,
            type: 'warning',
            showCancelButton: true,
        }, function () {
            ko.contentDialog.show();
            var cirid = config_id;
            var addfieldata = [
               {
                  Title: LRListManagement.Lists.LeaveRequestConfiguration.Fields.Details.Internal,
                  Value: data_value               
               }
            ];
            if (cirid === 0) {
                addfieldata.push({
                    Title: LRListManagement.Lists.LeaveRequestConfiguration.Fields.Title.Internal,
                    Value: config_value
                })
            }
            var optioninside = {
                listTitle: self.listoptions,
                data: addfieldata,
                itemid: cirid
            }
			LRGlobalFunc.SaveDatatoList(optioninside).then(function(id){
					if(callback){
						callback(id);
					}
            },self.errorshowaler);
        });
	}
	  
    this.enableEdit = function(){ self.circleEnable(true);}
    this.saveNewDate = function () {
    	self.ConfirmAndSave(gswalText().setting.confirmsave,
    			LRServices.Variables.RequestConfiguration.EndCircleDate,
    			parseInt(LRServices.Variables.EndCircleID.toString(), 10),
    			(self.circledate() !== null ? self.circledate().format(ko.dateformat.endcircletoList) : null),
    			function(id){
    					LRServices.Variables.EndCircleID = id;
		                LRServices.Variables.IsSetEndCircle = true;
	                	LRServices.Variables.EndCircleDate = self.circledate();
    					LRGlobalFunc.swalalrt({
		                        title: gswalText().setting.savesuccess,
		                        type: 'success'
		                    }, null, function () {
		                        ko.contentDialog.hide();
		                        self.oldcircledate(self.circledate());
		                        self.circleEnable(false);
		                        parent.isFoundEndCircle(LRServices.GetIsSetEndCircle());
		                    });    			
		         });
    }
    this.disableEdit = function(){ 
    	self.circledate(self.oldcircledate());
    	self.circleEnable(false);
    }
	
	/*this.enableLangEdit = function(){ self.langEnable(true);}
    this.saveNewLangDate = function () {
    	self.ConfirmAndSave(gswalText().setting.confirmsave,
    			LRServices.Variables.RequestConfiguration.Language,
    			parseInt(LRServices.Variables.SelectLanguageID.toString(), 10),
    			self.language(),
    			function(id){
    					LRServices.Variables.SelectLanguageID = id;
	                	LRServices.Variables.SelectLanguage = self.language();
    					LRGlobalFunc.swalalrt({
		                        title: gswalText().setting.savesuccess,
		                        type: 'success'
		                    }, null, function () {
		                        ko.contentDialog.hide();
		                        self.oldlanguage(self.language());
								self.langEnable(false);
								parent.parent.changelanuageClick(self.language());
		                       // parent.isFoundEndCircle(LRServices.GetIsSetEndCircle());
		                    });    			
		         });
    }
    this.disableLangEdit = function(){ 
    	self.language(self.oldlanguage());
    	self.langEnable(false);
    }
*/
    this.workingCheckEvent = function(){ return true;}
    this.enableWorkingEdit = function(){ self.workingEnable(true);}
    this.saveNewWorkingDate = function () {
    	self.ConfirmAndSave(gswalText().setting.confirmsave,
    			LRServices.Variables.RequestConfiguration.WorkingDays,
    			parseInt(LRServices.Variables.WorkingDaysID.toString(), 10),
    			self.workingDays().join(','),
    			function(id){
	    			LRServices.Variables.WorkingDaysID = id;
	                LRServices.Variables.WorkingDays = self.workingDays().slice();
	                LRGlobalFunc.swalalrt({
	                    title: gswalText().setting.savesuccess,
	                    type: 'success'
	                }, null, function () {
	                    ko.contentDialog.hide();
	                    self.oldworkingDays(self.workingDays().slice());
	                    self.workingEnable(false);
	                });    			
       });
    }
    this.disableWorkingEdit = function(){ 
    	self.workingDays(self.oldworkingDays().slice());
    	self.workingEnable(false);
	}

	/*this.enableRunning = function(){ self.ruunningEnable(true);}
    this.saveRunning = function () {
		console.log( self.ruunningformat());
		var genformat = {};
		if(typeof LRServices.Variables.RunningFormat === "object"){
			$.extend(genformat,LRServices.Variables.RunningFormat);
			
		}
		genformat["format"] = self.ruunningformat();
		console.log(genformat);
    	self.ConfirmAndSave(gswalText().setting.confirmsave,
    			LRServices.Variables.RequestConfiguration.RunningNo,
    			parseInt(LRServices.Variables.RunningFormatID.toString(), 10),
    			JSON.stringify(genformat),
    			function(id){
    					LRServices.Variables.RunningFormatID = id;
						LRServices.Variables.RunningFormat = $.extend({},genformat);
						console.log(LRServices.Variables.RunningFormat);
    					LRGlobalFunc.swalalrt({
		                        title: gswalText().setting.savesuccess,
		                        type: 'success'
		                    }, null, function () {
		                        ko.contentDialog.hide();
		                        self.oldruunningformat(self.ruunningformat());
		                        self.ruunningEnable(false);
		                        //parent.isFoundEndCircle(LRServices.GetIsSetEndCircle());
		                    });    			
		         });
    }
    this.disableRunning = function(){ 
    	self.ruunningformat(self.oldruunningformat());
    	self.ruunningEnable(false);
    }
*/

    this.genQuota = function(){
			LRGlobalFunc.swalalrt({
						title: gswalText().setting.inputquota,
						input: 'text',
						inputAttributes: {
						autocapitalize: 'off'
						},
						showCancelButton: true,
						//confirmButtonText: 'OK',
						//showLoaderOnConfirm: true
	                }, null, function (r) {
						//console.log(r);
						if(typeof r !== "undefined"){
							var year = parseInt(r,10);
							if(isNaN(year)){
								year = null;
							}
							//console.log(year);
							ko.contentDialog.show();
							LRServices.GenOfficersQuota(year).then(function(){
								//console.log("OK");
								LRGlobalFunc.swalalrt({
									title: gswalText().setting.quotasuccess,
									type: 'success'
								}, null, function () {
									ko.contentDialog.hide();
								});
								
							});
						}
						
	                    //ko.contentDialog.hide();
	                    //self.oldworkingDays(self.workingDays().slice());
	                    //self.workingEnable(false);
	                });   
		
		//alert("OK gen");
		//LRServices.SetOfficerQuota().then(function(){
		//	alert("555");
		//});
	}
   /* this.worktypeEnable = ko.observable(false);
	this.worktypearr=["ปัดเศษทิ้ง","คำนวณตามสัดส่วน"];
	this.oldworktype = ko.observable();
	this.worktype = ko.observable();
	
	//this.worktypeEventEdit = function(){ return true;}
    this.enableWorktype = function(){ self.worktypeEnable(true);}
    
    this.saveNewWorktype = function () {
        ToraAsiaLeaveRequestInfo.Services.swalalrt({
            title: gswalText().setting.confirmsave,
            //text: "To save data!",
            type: 'warning',
            showCancelButton: true,
        }, function () {
            ko.contentDialog.show();
            var cirid = parseInt(ToraAsiaLeaveRequestInfo.Services.WorkTypeID.toString(), 10);
            var addfieldata = [
                            {
                                Title: "Details",
                                Value: self.worktype()
                            }
            ];
            if (cirid === 0) {
                addfieldata.push({
                    Title: "Title",
                    Value: "WorkType"
                })
            }
            var optioninside = {
                listTitle: self.listoptions,
                data: addfieldata,
                itemid: cirid
            }

            // parent.navLinkClick("idapprove");
            ko.SaveDatatoList(optioninside, function (id) {
                //self.courseID (id);
                //self.saveImagefilesVideo(self.title(),id);
                ToraAsiaLeaveRequestInfo.Services.WorkTypeID = id;
                ToraAsiaLeaveRequestInfo.Services.WorkType = self.worktype();
                ToraAsiaLeaveRequestInfo.Services.swalalrt({
                    title: gswalText().setting.savesuccess,
                    type: 'success'
                }, null, function () {
                    ko.contentDialog.hide();
                    self.oldworktype(self.worktype());
                    self.worktypeEnable(false);
                });
            });
        });
    	//swal({
		//  title:"Are you sure to Save Date?",
		// // text: "To create Lists!",
		//  icon: "warning",
		//  buttons: true,
		//  dangerMode: true,
		//})
		//.then((willDelete) => {
		//  if (willDelete) {
		//   // swal("Poof! Your imaginary file has been deleted!", {
		//    //  icon: "success",
		//   // });
		//   		ko.contentDialog.show();
		//			var cirid = parseInt(ToraAsiaLeaveRequestInfo.Services.WorkTypeID.toString(),10);
    	//			var addfieldata = [
		//							{
		//								Title:"Details",
		//								Value: self.worktype()
		//							}								
		//						];
		//			if(cirid === 0 ){
		//				addfieldata.push({
		//								Title:"Title",
		//								Value: "WorkType"
		//							})
		//			}
		//			var optioninside = {
		//			            listTitle:self.listoptions,
		//			            data :addfieldata,
		//						itemid :cirid 
		//		    }
			   
		//   			// parent.navLinkClick("idapprove");
		//		    ko.SaveDatatoList(optioninside ,function(id){   
		//		    		//self.courseID (id);
		//	            	//self.saveImagefilesVideo(self.title(),id);
		//	            	ToraAsiaLeaveRequestInfo.Services.WorkTypeID= id;
		//	            	ToraAsiaLeaveRequestInfo.Services.WorkType=  self.worktype();
		//	            	swal("Save Success", {
		//						      icon: "success",
		//						    }).then(() => {
		//								ko.contentDialog.hide();
		//			            	    self.oldworktype(self.worktype());
		//			            		self.worktypeEnable(false);
		//			            		//console.log(ToraAsiaLeaveRequestInfo.Services.GetIsSetEndCircle());
		//			            		//parent.isFoundEndCircle (ToraAsiaLeaveRequestInfo.Services.GetIsSetEndCircle());
			
		//			        });	
		//			});

		//  } 		
		// });
    }
    this.disableWorktype = function(){ 
    	//console.log(self.workingDaysChecked());
    	//console.log(self.oldworkingDays().join(','));
    	//console.log(self.workingDays().join(','));
    	self.worktype(self.oldworktype());
    	self.worktypeEnable(false);
    }*/

}
