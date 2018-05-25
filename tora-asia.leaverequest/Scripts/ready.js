function LeaveRequestViewModel() {
    var self = this;
    this.isBeginSetupSuccess = ko.observable(ToraAsiaLeaveRequestInfo.Services.isAppReady());
    this.isFoundEndCircle = ko.observable(ToraAsiaLeaveRequestInfo.Services.GetIsSetEndCircle());
    this.isFoundOfficer = ko.observable(ToraAsiaLeaveRequestInfo.Services.isFoundOfficer());
    this.isSiteAdmin = ko.observable(ToraAsiaLeaveRequestInfo.Services.isSiteAdmin());
    this.isAdmin = ko.observable(ToraAsiaLeaveRequestInfo.Services.isAdmin());
    this.isHr = ko.observable(ToraAsiaLeaveRequestInfo.Services.isHr());
    this.isManager = ko.observable(ToraAsiaLeaveRequestInfo.Services.isManager());

    var seletetmp = "idbiginingwating";
    var tmpobj = new LRBeginSettingViewModel(self);

    if (self.isBeginSetupSuccess()) {
        if (!self.isFoundEndCircle()) {
            seletetmp = "idsetting";
            tmpobj = new LRSettingViewModel(self);

        } else {
            if (!self.isFoundOfficer()) {
                seletetmp = "idnotpermission";
                tmpobj = null;
            }
            else {
                seletetmp = "idhomepage";
                tmpobj = new LRHomeViewModel(self);

            }
        }
    }
    else {
        if (!self.isSiteAdmin()) {
            seletetmp = "idnotpermission";
            tmpobj = null;
        }
    }
    /*
    if(!self.isBeginSetupSuccess()){
    	seletetmp  = "idnotpermission";
    	tmpobj  = null;
    }
    else if(self.isBeginSetupSuccess()&&!self.isFoundEndCircle()){
    	seletetmp  = "idsetting";
    	tmpobj  = new LRSettingViewModel(self);
    }
    else if(self.isBeginSetupSuccess()&&self.isFoundEndCircle() && !self.isFoundOfficer()){
    	seletetmp  = "idnotpermission";
    	tmpobj  = null;
    }
    else if(self.isBeginSetupSuccess()&&self.isFoundEndCircle()&&self.isFoundOfficer()){
    	seletetmp  = "idhomepage";
    	tmpobj  = new LRHomeViewModel();
    }*/
    //console.log(seletetmp );
    this.selectTemplate = ko.observable(seletetmp);
    this.selectModel = ko.observable(tmpobj);
    this.userdisplayName = ko.observable(_spPageContextInfo.userDisplayName);

    this.settingPermisson = ko.computed(function () {
        //var first = self.pageNumber() * self.nbPerPage;
        return self.isBeginSetupSuccess() && (self.isAdmin() || self.isSiteAdmin());
    });

    this.navPermissonLevel0 = ko.computed(function () {
        //var first = self.pageNumber() * self.nbPerPage;
        return self.isBeginSetupSuccess() && self.isFoundEndCircle() && self.isFoundOfficer();
    });
    this.navPermissonLevel1 = ko.computed(function () {
        //var first = self.pageNumber() * self.nbPerPage;
        return self.isBeginSetupSuccess() && self.isFoundEndCircle() && self.isFoundOfficer() &&
        	(self.isAdmin() || self.isHr() || self.isManager());
    });
    this.navPermissonHR = ko.computed(function () {
        //var first = self.pageNumber() * self.nbPerPage;
        return self.isBeginSetupSuccess() && self.isFoundEndCircle() && self.isFoundOfficer() && self.isHr()
    });

    this.notPermisson = ko.computed(function () {
        //var first = self.pageNumber() * self.nbPerPage;
        return !self.isSiteAdmin() && !self.isFoundOfficer();
    });

    this.NavLinkArr = ko.observableArray([
    	{ title: "หน้าหลัก", template: "idhomepage", icon: "glyphicon-home", isvisible: self.navPermissonLevel0 },
    	{ title: "วันลาของฉัน", template: "idmyleaveremain", icon: "glyphicon-time", isvisible: self.navPermissonLevel0 },
    	{ title: "ประวัติการลา", template: "idmyhistory", icon: "glyphicon-list-alt", isvisible: self.navPermissonLevel0 },
    	//{title:"ยกเลิกการลา",template:"idcancel",icon:"glyphicon-ban-circle",isvisible:self.navPermissonLevel0 },
    	{ title: "อนุมัติการลา", template: "idapprove", icon: "glyphicon-check", isvisible: self.navPermissonLevel1 },
    	//{title:"รับทราบอนุมัติการลา",template:"idhrapprove",icon:"glyphicon glyphicon-flag",isvisible:self.navPermissonHR},
    	{ title: "ข้อมูลการลาของพนักงาน", template: "idofficerinfo", icon: "glyphicon-user", isvisible: self.navPermissonLevel1 },
    	{ title: "ไม่มีสิทธิ์ใช้งาน", template: "idnotpermission", icon: "glyphicon-remove-circle", isvisible: self.notPermisson },
    	{ title: "ตั้งค่า", template: "idsetting", icon: "glyphicon-cog", isvisible: self.settingPermisson },
    	{ title: "ตั้งค่าเริ่มต้น (site collection admin)", template: "idbiginingwating", icon: "glyphicon-asterisk", isvisible: self.isSiteAdmin },
    ]);
    //this.checkNull = function(value){
    //	return (typeof value !== "undefined")?value():"";
    //}

    this.navLinkClick = function (gototemplate) {
        if (self.selectTemplate() !== gototemplate) {
            self.selectTemplate("idwating");
            if (beforid !== gototemplate) {
                beforehistory = [];
                gcurrentPageIndex = 0;
            }
            switch (gototemplate) {
                case "idnewleaveform":
                    self.selectModel(new LRNewViewModel(self));
                    break;
                case "idhomepage":
                    self.selectModel(new LRHomeViewModel(self));
                    break;
                case "idmyhistory":
                    self.selectModel(new LRHistoryViewModel(self));
                    break;
                case "idapprove":
                    self.selectModel(new LRTasksViewModel(self));
                    break;
                case "idhrapprove":
                    self.selectModel(new LRTasksViewModel(self, true));
                    break;
                case "idofficerinfo":
                    self.selectModel(new LRHistoryViewModel(self, true));
                    break;
                case "idsetting":
                    self.selectModel(new LRSettingViewModel(self));
                    break;
                case "idbiginingwating":
                    self.selectModel(new LRBeginSettingViewModel(self));
                    break;
                case "idmyleaveremain":
                    self.selectModel(new LRMyLeaveRemailViewModel(self));
                    break;
                    //case "idcancel":
                    //	self.selectModel (new LRCancelViewModel());
                    //	break
                case "idnotpermission":
                    self.selectModel(null);
                    break
            }
            self.selectTemplate(gototemplate);
        }
    }
    this.checkLinkActive = function (idoftempage) {
        return self.selectTemplate() === idoftempage;
    }
    this.GoToApproveViewModel = function (parent, data, itemid, backto, isviewonly, isshowdate, ishrform) {
        parent.selectTemplate("idwating");
        parent.selectModel(new LRApproveViewModel(parent, itemid, data.Id, backto, isviewonly, isshowdate, ishrform));
        parent.selectTemplate("idapproveform");
    }
    var sphost = getParameterByName("SPHostUrl");
    var spapp = getParameterByName("SPAppWebUrl");
    var sptask = getParameterByName("TaskUrl");
    var spcaseview = getParameterByName("CaseView");
    var sptaskid = null;;
    var spitemid = getParameterByName("CurItemId");
    if (sptask !== null) {
        sptaskid = getParameterByName("ID", sptask);

    }
    // window.location.href
    //set current URl
    try {
        //ToraAsiaLeaveRequestInfo.Services.CurrentUrl =window.location.href.split("?")[0]+"?SPHostUrl="+sphost+"&SPAppWebUrl="+spapp ;
        ToraAsiaLeaveRequestInfo.Services.CurrentUrl = window.location.href.split("?")[0];
        ToraAsiaLeaveRequestInfo.Services.CurrentHostUrl = sphost;
        ToraAsiaLeaveRequestInfo.Services.CurrentAppUrl = spapp;

        //console.log(ToraAsiaLeaveRequestInfo.Services.CurrentUrl);
    }
    catch (ex) { }
    //console.log(sphost);
    //console.log(spapp);
    //console.log(sptask );
    //console.log(spitemid );
    //console.log(sptaskid );
    //approver
    if (self.navPermissonLevel1() && sptask !== null) {
        //self.GoToApproveViewModel(self,spitemid ,{Id:sptaskid });
        var isviewonly = true;
        if (self.isManager() && !self.isHr()) {
            isviewonly = false;
        }

        self.GoToApproveViewModel(self, { Id: sptaskid }, spitemid, "idapprove", isviewonly, self.isManager(), false);


    }
        //viewer
    else if (self.navPermissonLevel0() && spitemid !== null) {
        //self.GoToApproveViewModel(parent,{Id:0 },spitemid ,"idhomepage",true  ,false,false);
        var ishrform = (spcaseview === "2");

        self.GoToApproveViewModel(self, { Id: 0 }, spitemid, (!ishrform ? "idhomepage" : "idofficerinfo"), true, false, ishrform);
    }

}


$(function () {

    ko.waitingDialog.show("Loading...");


    SharePointClient.Configurations.IsApp = true;
    SharePointClient.Configurations.IsCrossDomainRequest = true;
    ToraAsiaLeaveRequestInfo.Services.IsCrossDomain = true;
    SharePointClient.Services.JSOM.Initialize(function () {
        ToraAsiaLeaveRequestInfo.Services.GetListInfomation(false, function () {
            ko.waitingDialog.hide();
            //url.split("?")[0]
            ko.applyBindings(new LeaveRequestViewModel(), $("#LeaveRequestContent")[0]);
        });
        //testGetTaskAssosiateWF();
        /*ToraAsiaLeaveRequestInfo.Services.deleteCancelRequestTask(23).then(function(e){
			console.log(e);
		},function(e){
			console.log(e);
		})*/
        //findFeatureId();
    });

});
