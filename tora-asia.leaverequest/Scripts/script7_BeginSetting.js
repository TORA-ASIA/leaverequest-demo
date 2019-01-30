function LRBeginSettingViewModel(parent){
	var self = this;
	this.obtionListName = LRListManagement.Lists.LeaveRequestConfiguration.Title;
	this.isAllcreate = ko.observable(LRServices.IsAllListCreated());
	this.isFeatureActivate = ko.observable(LRServices.GetIsFeatureActivate());
	this.isfoundWorkflow = ko.observable(LRServices.GetIsFoundWorkflow ());
	this.isWorkflowMap = ko.observable(LRServices.GetIsWorkflowMapping());
	
	
	this.createStep = ko.computed(function() {
        //var first = self.pageNumber() * self.nbPerPage;
        //return true;
        return !self.isAllcreate();
    });
    this.featureStep = ko.computed(function() {
        //var first = self.pageNumber() * self.nbPerPage;
        //return true;
        return self.isAllcreate() && !self.isFeatureActivate();
    });

    this.foundworkflowStep = ko.computed(function() {
        //var first = self.pageNumber() * self.nbPerPage;
        //return true;
        return self.isAllcreate()&&self.isFeatureActivate();
    });

    this.mapWorkflowStep = ko.computed(function() {
        //var first = self.pageNumber() * self.nbPerPage;
        //return true;
        return self.isAllcreate()&&self.isFeatureActivate()&& self.isfoundWorkflow ()  && !self.isWorkflowMap();
    });
	this.deleteStep = ko.computed(function() {
        //var first = self.pageNumber() * self.nbPerPage;
        //return true;
        return self.isAllcreate()&&self.isFeatureActivate() && self.isfoundWorkflow () && self.isWorkflowMap();
    });
    this.currentStep = ko.computed(function() {
    	var curstep = 1;
    	if(self.isAllcreate()&&self.isFeatureActivate()&&self.isfoundWorkflow ()&&self.isWorkflowMap()){
    		curstep = 5;
    	}
    	else if(self.isAllcreate ()&&self.isFeatureActivate()&&self.isfoundWorkflow ()){
    		curstep =4;
		}
		else if(self.isAllcreate ()&&self.isFeatureActivate()){
    		curstep =3;
		}
		else if(self.isAllcreate ()){
    		curstep =2;
		}
    	return curstep ;
    });
    this.CreateListClick = function () {
        LRGlobalFunc.swalalrt({
            title: gswalText().admin.createlist,
            //text: "To save data!",
            type: 'warning',
            showCancelButton: true,
        }, function () {
            ko.contentDialog.show();
            LRListManagement.Services.GetListInformation(true).then(function () {
	            LRGlobalFunc.swalalrt({
                    title: gswalText().admin.createlistsuccess,
                    type: 'success'
                }, null, function () {
                    ko.contentDialog.hide();
                    self.isAllcreate(LRServices.IsAllListCreated());
                    parent.isBeginSetupSuccess(LRServices.isAppReady());
                });

	        }, function (errmsg) {
	        	ko.contentDialog.hide();
	            console.log(errmsg);
	        });
        });
	}
	
	this.SaveLeaveRequestConfiguration = function(config_value,config_id,success_alert_msg){
			 var setfieldata = [
                    {
                       Title: LRListManagement.Lists.LeaveRequestConfiguration.Fields.Title.Internal,
                       Value: config_value ,
                    },
                    {
                       Title: LRListManagement.Lists.LeaveRequestConfiguration.Fields.Details.Internal,
                       Value: "true"
                    }
                ];
                var optioninside = {
                    listTitle: self.obtionListName,
                    data: setfieldata,
                    itemid: config_id
                }
                // parent.navLinkClick("idapprove");
                LRGlobalFunc.SaveDatatoList(optioninside).then(function(id){
                	LRGlobalFunc.swalalrt({
                        title: success_alert_msg,
                        type: 'success'
                    }, null, function () {
                        ko.contentDialog.hide();
                        switch(config_value){
                        	case LRServices.Variables.RequestConfiguration.FeatureActivated:
                        		LRServices.Variables.ActivateFeatureID = id;
		                        LRServices.Variables.IsFeatureActivate = true;
		                        self.isFeatureActivate(LRServices.GetIsFeatureActivate());
                        	break;
                        	case LRServices.Variables.RequestConfiguration.FoundWorkflow:
                        		LRServices.Variables.FoundWorkflowID  = id;
		                        LRServices.Variables.IsFoundWorkflow = true;
		                        self.isfoundWorkflow(LRServices.GetIsFoundWorkflow());
                        	break;
                        	case LRServices.Variables.RequestConfiguration.WorkflowMaping:
                        		LRServices.Variables.WorkflowMapingID = id;
		                        LRServices.Variables.IsWorkflowMaping = true;
		                        self.isWorkflowMap(LRServices.GetIsWorkflowMapping());
                        	break;

                        }; 
                        parent.isBeginSetupSuccess(LRServices.isAppReady());
                    });
                },self.errorshowaler);
	}
	this.errorshowaler = function(err_msg){
		LRGlobalFunc.swalalrt({
            title: err_msg,
            type: 'error'
        }, null, function () {
            ko.contentDialog.hide();
        });

	}
	
    this.ActivateFeatureClick = function () {
        LRGlobalFunc.swalalrt({
            title: gswalText().admin.activatefeature,
            //text: "To save data!",
            type: 'warning',
            showCancelButton: true,
        }, function () {
            ko.contentDialog.show();
            LRServices.ActivateFeature(LRGlobalFunc.WorkflowsCanUseAppPermissions).then(function () {
                //UpdateSetupID
                self.SaveLeaveRequestConfiguration(LRServices.Variables.RequestConfiguration.FeatureActivated,
	                	LRServices.Variables.ActivateFeatureID,
	                	gswalText().admin.activatefeaturesuccess
                	);
                },self.errorshowaler);
        });
	}

    this.CloneWorkflowClick = function () {

        LRGlobalFunc.swalalrt({
            title: gswalText().admin.clonewf,
            //text: "To save data!",
            type: 'warning',
            showCancelButton: true,
        }, function () {
            ko.contentDialog.show();
            LRServices.CloneWorkflow().then(function () {
            	self.SaveLeaveRequestConfiguration(LRServices.Variables.RequestConfiguration.FoundWorkflow,
	                	LRServices.Variables.FoundWorkflowID,
	                	gswalText().admin.clonewfsuccess
                	);
            },self.errorshowaler);
        });
	}

    this.MappingWorkflowClick = function () {
        LRGlobalFunc.swalalrt({
            title: gswalText().admin.mapwf,
            //text: "To save data!",
            type: 'warning',
            showCancelButton: true,
        }, function () {
            ko.contentDialog.show();
            LRServices.AddWorkflowdefinitiontoList().then(function () {
            	self.SaveLeaveRequestConfiguration(LRServices.Variables.RequestConfiguration.WorkflowMaping,
	                	LRServices.Variables.WorkflowMapingID,
	                	gswalText().admin.mapwfsuccess
                	);
            },self.errorshowaler);
        });
	}
    this.DeleteListClick = function () {
        LRGlobalFunc.swalalrt({
            title: gswalText().admin.deletelist,
            //text: "To save data!",
            type: 'warning',
            showCancelButton: true,
        }, function () {
            ko.contentDialog.show();
            ToraAsiaLeaveRequestInfo.Services.deleteAllList().then(function (m) {
                LRGlobalFunc.swalalrt({
                    title: m,
                    type: 'success'
                }, null, function () {
                    ko.contentDialog.hide();
                    window.location.href = window.location.href;
                });
            },
                function (merr) {
                    LRGlobalFunc.swalalrt({
                        title: merr,
                        type: 'error'
                    }, null, function () {
                        ko.contentDialog.hide();
                    });
                });
           
        });
	}



}
