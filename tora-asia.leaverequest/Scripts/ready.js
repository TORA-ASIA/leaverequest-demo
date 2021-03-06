﻿function LeaveRequestViewModel() {
    var self = this;
    //this.parent  = parent;
    this.isBeginSetupSuccess = ko.observable(LRServices.isAppReady());
    this.isFoundEndCircle = ko.observable(LRServices.GetIsSetEndCircle());
    this.isFoundOfficer = ko.observable(LRServices.isFoundOfficer());
    this.isSiteAdmin = ko.observable(LRServices.isSiteAdmin());
    //this.isAdmin = ko.observable(LRServices.isAdmin());
    this.isHr = ko.observable(LRServices.isHr());
    this.isManager = ko.observable(LRServices.isManager());

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

    this.selectTemplate = ko.observable(seletetmp);
    this.selectModel = ko.observable(tmpobj);
    this.userdisplayName = ko.observable(_spPageContextInfo.userDisplayName);

    this.settingPermisson = ko.computed(function () {
        //var first = self.pageNumber() * self.nbPerPage;
        return self.isBeginSetupSuccess() && (self.isSiteAdmin() || self.isHr());
    });

    this.navPermissonLevel0 = ko.computed(function () {
        //var first = self.pageNumber() * self.nbPerPage;
        return self.isBeginSetupSuccess() && self.isFoundEndCircle() && self.isFoundOfficer();
    });
    this.navPermissonLevel1 = ko.computed(function () {
        //var first = self.pageNumber() * self.nbPerPage;
        return self.isBeginSetupSuccess() && self.isFoundEndCircle() && self.isFoundOfficer() &&
        	(self.isHr() || self.isManager());
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
    	{ title: gleavedic().leftmenu.home, template: "idhomepage", icon: "fa-home", isvisible: self.navPermissonLevel0 },
    	//{ title: gleavedic().leftmenu.myleave, template: "idmyleaveremain", icon: "fa-clock", isvisible: self.navPermissonLevel0 },
    	{ title: gleavedic().leftmenu.myleavehis, template: "idmyhistory", icon: "fa-list-alt", isvisible: self.navPermissonLevel0 },
    	//{title:"ยกเลิกการลา",template:"idcancel",icon:"glyphicon-ban-circle",isvisible:self.navPermissonLevel0 },
    	{ title: gleavedic().leftmenu.approve, template: "idapprove", icon: "fa-calendar-check", isvisible: self.navPermissonLevel1 },
    	//{title:"รับทราบอนุมัติการลา",template:"idhrapprove",icon:"glyphicon glyphicon-flag",isvisible:self.navPermissonHR},
    	{ title: gleavedic().leftmenu.leavehis, template: "idofficerinfo", icon: "fa-users", isvisible: self.navPermissonLevel1 },
    	{ title: gleavedic().leftmenu.nopermis, template: "idnotpermission", icon: "fa-ban", isvisible: self.notPermisson },
    	{ title: gleavedic().leftmenu.setting, template: "idsetting", icon: "fa-cogs", isvisible: self.settingPermisson },
    	{ title: gleavedic().leftmenu.beginsetting, template: "idbiginingwating", icon: "fa-tasks", isvisible: self.isSiteAdmin },
    ]);
    //this.checkNull = function(value){
    //	return (typeof value !== "undefined")?value():"";
    //}
    this.navLinkClick = function (gototemplate) {
        if (self.selectTemplate() !== gototemplate) {
            self.selectTemplate("idwating");
            ko.contentDialog.hide();
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
        //console.log(data.ID);
        //console.log(itemid);
        parent.selectTemplate("idwating");
        parent.selectModel(new LRApproveViewModel(parent, itemid, data.ID, backto, isviewonly, isshowdate, ishrform));
        parent.selectTemplate("idapproveform");
    }
    var sphost = LRGlobalFunc.getParameterByName("SPHostUrl");
    var spapp = LRGlobalFunc.getParameterByName("SPAppWebUrl");
    var sptask = LRGlobalFunc.getParameterByName("TaskUrl");
    var spcaseview = LRGlobalFunc.getParameterByName("CaseView");
    var sptaskid = null;;
    var spitemid = LRGlobalFunc.getParameterByName("CurItemId");
    if (sptask !== null) {
        sptaskid = LRGlobalFunc.getParameterByName("ID", sptask);

    }
    // window.location.href
    //set current URl
    try {
        //ToraAsiaLeaveRequestInfo.Services.CurrentUrl =window.location.href.split("?")[0]+"?SPHostUrl="+sphost+"&SPAppWebUrl="+spapp ;
        LRServices.Variables.CurrentUrl = window.location.href.split("?")[0];
        LRServices.Variables.CurrentHostUrl = sphost;
        LRServices.Variables.CurrentAppUrl = spapp;

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
/*
$.getScript( "./../Style Library/UI/leaverequestV2/script/dic_th.js", function( data, textStatus, jqxhr ) {
	  $.extend(gswalText , dic_swal_lang_th);
	  $.extend(gleavedic(), dic_lang_th);
	   SharePointClient.Services.JSOM.Initialize(function () {
        LRServices.Initial().then(function (r) {
            ko.waitingDialog.hide();
            console.log(r);
            ko.applyBindings(new LeaveRequestViewModel(), $("#LeaveRequestContent")[0]);
        }, function (er) {
            ko.waitingDialog.hide();
            console.log(er);
            //ko.applyBindings(new LeaveRequestViewModel(), $("#LeaveRequestContent")[0]);
        });
    });
    //SharePointClient.Configurations.IsApp = true;
    //SharePointClient.Configurations.IsCrossDomainRequest = true;
    //ToraAsiaLeaveRequestInfo.Services.IsCrossDomain = true;
    //SharePointClient.Services.JSOM.Initialize(function () {
    //    ToraAsiaLeaveRequestInfo.Services.GetListInfomation(false, function () {
    //        ko.waitingDialog.hide();
    //        //url.split("?")[0]
    //        ko.applyBindings(new LeaveRequestViewModel(), $("#LeaveRequestContent")[0]);
    //    });
    //    //testGetTaskAssosiateWF();
    //    ToraAsiaLeaveRequestInfo.Services.deleteCancelRequestTask(23).then(function(e){
	//		console.log(e);
	//	},function(e){
	//		console.log(e);
	//	})
    //    //findFeatureId();
    //});
    $(".sidebar .sidebar-menu li a").on("click", function () {
        var t = $(this);
        t.parent().hasClass("open") ? t.parent().children(".dropdown-menu").slideUp(200, function () {
            t.parent().removeClass("open")
        }
        ) : (t.parent().parent().children("li.open").children(".dropdown-menu").slideUp(200), t.parent().parent().children("li.open").children("a").removeClass("open"), t.parent().parent().children("li.open").removeClass("open"), t.parent().children(".dropdown-menu").slideDown(200, function () {
            t.parent().addClass("open")
        }
        ))
    }
            );
    $(".sidebar-toggle").on("click", function (t) {
        $(".app").toggleClass("is-collapsed"), t.preventDefault()
    }
    );
    if (lg == true || xl == true) {
        //alert("mobile first");
        $(".app").toggleClass("is-collapsed")
    }

});
*/

/*function selectedLanguage(){
    var self = this;
    //self.languages = ko.observable(new LeaveRequestViewModel());
    //currentlang = LRServices.Variables.SelectLanguage;
    this.selectLang = ko.observable(currentlang);
    if(currentlang === "th"){
        gswalText(dic_swal_lang_th); 
        gleavedic(dic_lang_th);
    }
    else if (currentlang === "en"){
        gswalText(dic_swal_lang_en); 
        gleavedic(dic_lang_en);     
    }
    self.selectedLanguage = ko.observable();
    this.selectLangTemplate = "idmainbody";
    this.selectLangModel = ko.observable(new LeaveRequestViewModel(self))
    
    this.changelanuageClick = function(lang){
        //console.log(lang);
        if(currentlang !== lang){
            currentlang  = lang;
            self.selectLang(lang);
            if(lang === "th"){
                gswalText(dic_swal_lang_th); 
                gleavedic(dic_lang_th);
            }
            else if (lang === "en"){
                gswalText(dic_swal_lang_en); 
                gleavedic(dic_lang_en);     
            }
            LRServices.Variables.AllDays= [
                    { title: gleavedic().alldays.$0, value: "0" },
                    { title: gleavedic().alldays.$1, value: "1" },
                    { title: gleavedic().alldays.$2, value: "2" },
                    { title: gleavedic().alldays.$3, value: "3" },
                    { title: gleavedic().alldays.$4, value: "4" },
                    { title: gleavedic().alldays.$5, value: "5" },
                    { title: gleavedic().alldays.$6, value: "6" }
                ],//[0,1,2,3,4,5,6],
            LRServices.Variables.LeaveTime = [
                    { title: gleavedic().leavetime.$1, value: "1" },
                    { title: gleavedic().leavetime.$2, value: "2" },
                    { title: gleavedic().leavetime.$3, value: "3" }
                ];
            self.selectLangModel(new LeaveRequestViewModel(self));
            
        }
        return true;
    }
    //this.bindLanguage = function(lang){
    //    return self.selectLang() === lang;
    //}
}*/
$(function () {

    ko.waitingDialog.show("Loading...");

    //SharePointClient.Configurations.IsApp = true;
    //SharePointClient.Configurations.IsCrossDomainRequest = true;
    //LRGlobalFunc.IsCrossDomain = true;
    
   // SharePointClient.Services.JSOM.Initialize(function () {
  //      LRServices.Initial().then(function (r) {
   //         ko.waitingDialog.hide();
   //        ko.applyBindings(new selectedLanguage(), $("#LeaveRequestContent")[0]);
   //     }, function (er) {
   //         ko.waitingDialog.hide();
   //         console.log(er);
   //         ko.applyBindings(new selectedLanguage(), $("#LeaveRequestContent")[0]);
            //ko.applyBindings(new LeaveRequestViewModel(), $("#LeaveRequestContent")[0]);
   //     });
   // });
    SharePointClient.Configurations.IsApp = true;
    SharePointClient.Configurations.IsCrossDomainRequest = true;
    LRGlobalFunc.IsCrossDomain = true;
    SharePointClient.Services.JSOM.Initialize(function () {
        LRServices.Initial().then(function (r) {
            ko.waitingDialog.hide();
            ko.applyBindings(new LeaveRequestViewModel(), $("#LeaveRequestContent")[0]);
        },function(er){
            ko.waitingDialog.hide();
            console.log(er);
            ko.applyBindings(new LeaveRequestViewModel(), $("#LeaveRequestContent")[0]);
        });
        //testGetTaskAssosiateWF();
        //ToraAsiaLeaveRequestInfo.Services.deleteCancelRequestTask(23).then(function(e){
		//	console.log(e);
		//},function(e){
		//	console.log(e);
		//})
       //findFeatureId();
    });
    $(".sidebar .sidebar-menu li a").on("click", function () {
        var t = $(this);
        t.parent().hasClass("open") ? t.parent().children(".dropdown-menu").slideUp(200, function () {
            t.parent().removeClass("open")
        }
        ) : (t.parent().parent().children("li.open").children(".dropdown-menu").slideUp(200), t.parent().parent().children("li.open").children("a").removeClass("open"), t.parent().parent().children("li.open").removeClass("open"), t.parent().children(".dropdown-menu").slideDown(200, function () {
            t.parent().addClass("open")
        }
        ))
    }
            );
    $(".sidebar-toggle").on("click", function (t) {
        $(".app").toggleClass("is-collapsed"), t.preventDefault()
    }
    );
    if (lg == true || xl == true) {
        //alert("mobile first");
        $(".app").toggleClass("is-collapsed")
    }
});
