function moreThenOne(type) {
	type = type || false;
	var self = this;
	this.todate = ko.observable().extend({ required: type });

	this.errors = ko.validation.group(self);
	//return this.value ;
}
function ohterLeavetype(type) {
	type = type || false;
	var self = this;
	this.othertype = ko.observable().extend({ required: type });

	this.errors = ko.validation.group(self);
	//return this.value ;
}

function LRNewViewModel(parent) {
	//ko.contentDialog.show();
	var self = this;
	this.listrequestformtitle = LRListManagement.Lists.LeaveRequestItem.Title;
	this.listleavetypetitle = LRListManagement.Lists.LeaveRequestCondition.Title;
	this.dateformate = ko.dateformat.normal;
	this.title = ko.observable(_spPageContextInfo.userDisplayName).extend({ required: true });
	this.leavetype = ko.observable().extend({ required: true });
	this.leavetypearr = ko.observableArray();
	this.otherleavetype = ko.observable();

	this.mymanager = ko.observable(LRServices.GetOfficerManager());
	this.mymanagerName = ko.observable();
	if (this.mymanager() != null) { 
	    //console.log(this.mymanager().get_lookupValue());
	    this.mymanagerName(this.mymanager().get_lookupValue());
	}

	this.leavedatetypearr = ko.observableArray(LRServices.Variables.LeaveTime);
	this.fromdate = ko.observable().extend({ required: true });
	this.fromdatetype = ko.observable("3");
	//this.todate = ko.observable(new dynamicExtend(true));
	//console.log(this.todate());
	//this.todatetype = ko.observable("เต็มวัน");

	this.morebool = ko.observable(false);
	this.moretemplate = ko.observable("idwating");
	this.moreModel = ko.observable(new moreThenOne(false));
	this.workingdday = ["Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"];

	this.caludateDiffDays = function(isonlyone,startdate,enddate){
		isonlyone = isonlyone || false;
		var holiday = [];
		var workingdday = self.workingdday.slice();
		var calday = 0;
		if (typeof self.leavetype() !== "undefined") {
			var myremain = ko.utils.arrayFilter(self.leavetypearr(), function (cdata) {
				return cdata.code === self.leavetype()[0] && cdata.rights.CountHoliday !== "true"
			});
			if (myremain.length > -1) {
				var curworkdayarr = [];
				ko.utils.arrayForEach(LRServices.Variables.WorkingDays, function (day) {
					var curworkdata = LRServices.Variables.Workdaymapping["$" + day];
					if (typeof curworkdata !== "undefined") {
						curworkdayarr.push(curworkdata);
					}
				});
				workingdday = curworkdayarr;
				holiday = LRServices.Variables.HoliDays.slice();
			}
			if (self.leavetype().length > 0) {
				if (isonlyone && typeof startdate !== "undefined" && self.fromdate() !== null) {
					//case 1 day
					calday = moment().weekdayCalc({
						rangeStart: startdate.format(self.dateformate),
						rangeEnd: startdate.format(self.dateformate),
						weekdays: workingdday,
						exclusions: holiday
					})

					if (self.fromdatetype() !== "3") {
						calday -= 0.5;
					}
				}
				else if (typeof startdate !== "undefined" && startdate !== null &&
					typeof enddate !== "undefined" && enddate !== null) {
					calday = moment().weekdayCalc({
						rangeStart: startdate.format(self.dateformate),
						rangeEnd: enddate.format(self.dateformate),
						weekdays: workingdday,
						exclusions: holiday
					})
				}
			}
		}
		return calday;
	}
	this.totalday = ko.computed(function () {
		//var first = self.pageNumber() * self.nbPerPage;
		//console.log(self.leavetypearr());
		/*var holiday = [];
		var workingdday = self.workingdday.slice();
		var calday = 0;
		if (typeof self.leavetype() !== "undefined") {
			var myremain = ko.utils.arrayFilter(self.leavetypearr(), function (cdata) {
				return cdata.code === self.leavetype()[0] && cdata.rights.CountHoliday !== "true"
			});
			if (myremain.length > -1) {
				var curworkdayarr = [];
				ko.utils.arrayForEach(LRServices.Variables.WorkingDays, function (day) {
					var curworkdata = LRServices.Variables.Workdaymapping["$" + day];
					if (typeof curworkdata !== "undefined") {
						curworkdayarr.push(curworkdata);
					}
				});
				workingdday = curworkdayarr;
				holiday = LRServices.Variables.HoliDays.slice();
			}
			if (self.leavetype().length > 0) {
				if (!self.morebool() && typeof self.fromdate() !== "undefined" && self.fromdate() !== null) {
					//case 1 day
					calday = moment().weekdayCalc({
						rangeStart: self.fromdate().format(self.dateformate),
						rangeEnd: self.fromdate().format(self.dateformate),
						weekdays: workingdday,
						exclusions: holiday
					})

					if (self.fromdatetype() !== "3") {
						calday -= 0.5;
					}
				}
				else if (typeof self.fromdate() !== "undefined" && self.fromdate() !== null &&
					typeof self.moreModel().todate() !== "undefined" && self.moreModel().todate() !== null) {
					calday = moment().weekdayCalc({
						rangeStart: self.fromdate().format(self.dateformate),
						rangeEnd: self.moreModel().todate().format(self.dateformate),
						weekdays: workingdday,
						exclusions: holiday
					})
				}
			}
		}
		return calday;*/
		return self.caludateDiffDays(!self.morebool(),self.fromdate(),self.moreModel().todate());
	}).extend({ min: 0.5 });
	this.leavedays = ko.observableArray([]);
	/*this.loadAllLeaveDay = function (callback) {
		ToraAsiaLeaveRequestInfo.Services.GetLeaveRemain(self.leavedays,_spPageContextInfo.userId).then(function(){
				//OK
				callback();

		});
	}
*/
	//this.phonenumber = ko.observable().extend({ required: true, number: true });
	this.reason = ko.observable().extend({ required: true });
	this.requester = ko.observable(SP.FieldUserValue.fromUser(_spPageContextInfo.userLoginName));

	this.othertyptemplate = ko.observable("idwating");
	this.othertypModel = ko.observable(new ohterLeavetype(false));
	this.isotherType = ko.computed(function () {
		//var first = self.pageNumber() * self.nbPerPage;
		//console.log(self.leavetype());
		var isother = false;
		if (typeof self.leavetype() !== "undefined") {
			isother = (self.leavetype()[0] === "อื่นๆ");
		}
		if (isother) {
			//self.moretemplate("idwating");
			self.othertyptemplate("idotherLeaveType");
		}
		else {
			self.othertyptemplate("idwating");
		}
		self.othertypModel(new ohterLeavetype(isother));

		return isother;
	}, self);
	this.moreclick = function () {
		var oldmore = self.morebool();
		if (!oldmore) {
			//self.moretemplate("idwating");
			self.fromdatetype("3");
			self.moretemplate("idmorethenone");
		}
		else {
			self.moretemplate("idwating");
		}
		self.moreModel(new moreThenOne(!oldmore));
		self.morebool(!oldmore);


	}

	this.SaveSubmit = function (parent) {
		//var officehr = ToraAsiaLeaveRequestInfo.Services.GetOfficerHR();
		//console.log(officehr );
		//console.log(self.leavedays());
		LRGlobalFunc.swalalrt({
			title: gswalText().newleave.confirmsave,
			//text: "To save data!",
			type: 'warning',
			showCancelButton: true,
		}, function () {
			self.saveToDB();
		});
		//swal({
		//    title: "Are you sure?",
		//    text: "To save data!",
		//    type: 'warning',
		//    showCancelButton: true,
		//}).then(function (willDelete) {
		//    if (willDelete) {
		//        self.saveToDB();
		//    }
		//});
		//swal({
		//  title: "Are you sure?",
		//  text: "To save data!",
		//  icon: "warning",
		//  buttons: true,
		//  dangerMode: true,
		//})
		//.then((willDelete) => {
		//  if (willDelete) {
		//   // swal("Poof! Your imaginary file has been deleted!", {
		//    //  icon: "success",
		//   // });
		//    self.saveToDB();
		//  } else {
		//    //swal("Your imaginary file is safe!");
		//  }
		//});
		//var r = confirm("Are you sure to Save Data?");

		//swal("Good job!", "You clicked the button!", "success");

		//if(r){
		//console.log(self.errors().length);
		//console.log(self.moreModel().errors().length);
		// }

	}
	this.IsLeavedateInCircle = function () {
	    var fromdate = true;
	    var enddate = true;

	    var range = moment().range(LRServices.Variables.StartCircleYear,LRServices.Variables.EndCircleYear);

	    fromdate = range.contains(self.fromdate());
	    if (self.morebool()) {
	        enddate = range.contains(self.moreModel().todate());
	    }

	    return fromdate && enddate;
	}
	this.saveToDB = function () {
		//console.log(self.errors());
		//console.log(self.moreModel().errors());
		//console.log(self.othertypModel().errors());
		if (self.errors().length == 0 && self.moreModel().errors().length == 0 & self.othertypModel().errors().length == 0) {
			
			var checktodate = null;
	        if (self.morebool()) {
	            checktodate = self.moreModel().todate().format(ko.dateformat.camlquery);
			}
			var r = true;
			//LRServices.CheckLeaveDayUsed(self.fromdate().format(ko.dateformat.camlquery), checktodate).then(function (r) {
				if (r) {
					var ltype = self.leavetype()[0].trim();
					var isincircle = self.IsLeavedateInCircle();
					if (!isincircle) {
								//alert("ลากิจ ต้องเลือกวันที่ลา มากกว่า วันนี้");
						LRGlobalFunc.swalalrt({
							title: gswalText().newleave.cantacrossyear,
							type: 'error'
						});
						return;
					}

					var diff = //self.caludateDiffDays(false,self.fromdate(),moment());
					//console.log(diff);
					/* moment().weekdayCalc({  
										  rangeStart: self.fromdate().format(self.dateformate),  
										  rangeEnd: moment().format(self.dateformate),  
										  weekdays: self.workingdday.slice()  ,
										  exclusions:[]
										})*/
						//console.log(diff );
		
						moment(self.fromdate().format(ko.dateformat.tolistnoTime)).diff(moment(moment().format(ko.dateformat.tolistnoTime)), 'days');
					console.log(diff);

					var findleavecon = ko.utils.arrayFilter(self.leavetypearr(), function (item) {
						//suminprogress += parseInt(item.NumberOfDay,10);
						return item["code"] === ltype;
					});
					//console.log(findleavecon);
					//console.log(self.leavedays());
					if(findleavecon.length > 0){

						//check condition day
						var ltcondate = findleavecon[0]["conditiondate"];
						console.log(ltcondate);
						try{
							if(typeof ltcondate != "undefined"){
								var ltcondatearr = ltcondate.split(",");
								var alertmsgarr = [];
								var passsomecondition = false;	
									
									ko.utils.arrayForEach(ltcondatearr, function (ltcd) {
										var intltcd = parseInt(ltcd,10);
										var diffchk = diff;
										/*if(intltcd < 0){
											diffchk *= -1;
										}*/
										//console.log(intltcd);
										//console.log(diffchk);
										var alertmsg= "";
										if(intltcd === 0 && diffchk == 0 && diffchk < intltcd){
											alertmsg = gswalText().newleave.alertcantyesterday;
											passsomecondition = true;
											//console.log("pass_0");
										}
										else if(intltcd > 0 && diffchk > 0 && diffchk < intltcd){
											alertmsg =  String.format(gswalText().newleave.alertgreater, ltype,intltcd);
											passsomecondition = true;
											//console.log("pass_1");
										}
										else if(intltcd < 0 && diffchk < 0 && diffchk < intltcd){
											alertmsg =  String.format(gswalText().newleave.alertlower, ltype,intltcd);
											passsomecondition = true;
											//console.log("pass_2");
										}
										if(alertmsg.length > 0){
											alertmsgarr.push(alertmsg);
										}
										//if(passsomecondition){
										//	break;
										//}
									});
								//console.log(alertmsgarr);
								if(alertmsgarr.length == 1 && passsomecondition){
									var alertmsgstring = alertmsgarr.join(gswalText().newleave.or);
									LRGlobalFunc.swalalrt({
										title: alertmsgstring,
										type: 'error'
									});
									return;
								}
							}
							//else{
							//	if(diff < 0){
							//		LRGlobalFunc.swalalrt({
							//			title: gswalText().newleave.alertcantyesterday,
							//			type: 'error'
							//		});
							//		return;
							//	}
							//}
						}catch(cd){
							console.log(cd);
						}	
					}
					else{
						LRGlobalFunc.swalalrt({
							title: gswalText().newleave.leavenotfound,
							type: 'error'
						});
						return;
					}
					var findleavecremain = ko.utils.arrayFilter(self.leavedays(), function (item) {
						//suminprogress += parseInt(item.NumberOfDay,10);
						return item["code"] === ltype;
					});
					if(findleavecremain.length > 0){
											//check leave remain
						try{
							var totald = self.totalday();
							var leaveuse = findleavecremain[0];
							var maxd = parseInt(leaveuse.MaxLeaveValue.toString(), 10);
							var inprod = parseInt(leaveuse.MyUseDay.inprogress.toString(), 10);
							var appd = parseInt(leaveuse.MyUseDay.approve.toString(), 10);
							var diffuser =  maxd - inprod - appd;
							var sumleaveuse = diffuser - totald;
							if(sumleaveuse < 0){
								LRGlobalFunc.swalalrt({
									title: String.format(gswalText().newleave.maxleave, diffuser),
									type: 'error'
								});
								return;
							}
						}catch(cdu){
							console.log(cdu);
							return;
						}	
					}
					else{
						LRGlobalFunc.swalalrt({
							title: gswalText().newleave.leaveremainnotfound,
							type: 'error'
						});
						return;
					}
					//return;
					//var notcountarr = ["ลากิจ", "ลาพักร้อน", "ลาบวช", "ลาคลอด"];
					/*if (diff < 0 && LRServices.Variables.CountHolidayDays.indexOf(ltype) > -1) {
						//alert("ลากิจ ต้องเลือกวันที่ลา มากกว่า วันนี้");
						ToraAsiaLeaveRequestInfo.Services.swalalrt({
							title: gswalText().newleave.alertcantyesterday,
							type: 'error'
						});
						//swal({
						//    title: "ไม่สามารถเลือกวันลาย้อนหลังได้",
						//    text: "To save data!",
						//    type: 'error'
						//});
						//swal("ไม่สามารถเลือกวันลาย้อนหลังได้", {
						//  icon: "error",
						//});
						return;
					}
					
					var findday = ko.utils.arrayFilter(self.leavedays(), function (item) {
						//suminprogress += parseInt(item.NumberOfDay,10);
						return item.Title === ltype;
					});
					//console.log(findday );
					if (findday.length > 0) {
						var findday0 = findday[0]
						//var cal
						var canleaveday = findday0.MaxLeaveValue -
							findday0.MyUseDay.inprogress -
							findday0.MyUseDay.approve;
		
						if (canleaveday - self.totalday() < 0) {
							//alert("จำนวนวันลาเกิน สามารถลาได้สูงสุด " +canleaveday + " วัน");
							//swal("จำนวนวันลาเกิน สามารถลาได้สูงสุด " +canleaveday + " วัน", {
							//  icon: "error",
							//});
							ToraAsiaLeaveRequestInfo.Services.swalalrt({
								title: String.format(gswalText().newleave.maxleave, canleaveday),
								type: 'error'
							});
							return;
						}
					}
					//console.log(findday );
		
		
		*/
					var mymanager = LRServices.GetOfficerManager();
					if (mymanager === null) {
						LRGlobalFunc.swalalrt({
							title: gswalText().newleave.managernotfound,
							type: 'error'
						});
		
						return;
					}

					//#### สร้าง JSON #####//
					var jsondic = {};
					ko.utils.arrayForEach(self.leavetypearr(), function (item) {
						//suminprogress += parseInt(item.NumberOfDay,10);
						jsondic[item["code"]] = item["title"] ;
						
					});
					$.extend( jsondic, gleavedic.EmailText );
					console.log(jsondic);
					//return ;
					//console.log(officehr );
					//LRServices.GetRunningAndUpdate(LRServices.Variables.CurrentQuotaYear).then(function(runno){
					//	console.log(runno);
						var addfieldata = [
							{
								Title: LRListManagement.Lists.LeaveRequestItem.Fields.Title.Internal,
								Value: self.title()
							},
							{
								Title: LRListManagement.Lists.LeaveRequestItem.Fields.LeaveType.Internal,
								Value: ltype
							},
							{
								Title: LRListManagement.Lists.LeaveRequestItem.Fields.StartDate.Internal,
								Value: self.fromdate().format(ko.dateformat.tolistnoTime)
							},
							{
								Title: LRListManagement.Lists.LeaveRequestItem.Fields.LeaveTime.Internal,
								Value: self.fromdatetype()
							},
							{
								Title: LRListManagement.Lists.LeaveRequestItem.Fields.LeaveDayTotal.Internal,
								Value: self.totalday()
							},
							{
								Title: LRListManagement.Lists.LeaveRequestItem.Fields.LeaveReason.Internal,
								Value: self.reason()
							},
							{
								Title: LRListManagement.Lists.LeaveRequestItem.Fields.LeaveYear.Internal,
								Value: LRServices.Variables.CurrentQuotaYear
							},
							{
								Title: LRListManagement.Lists.LeaveRequestItem.Fields.RequestType.Internal,
								Value: "1"
							},
							{
								Title: LRListManagement.Lists.LeaveRequestItem.Fields.Requester.Internal,
								Value: self.requester()
							},
							{
								Title: LRListManagement.Lists.LeaveRequestItem.Fields.OfficerApprover.Internal,
								Value: mymanager
							},
							{
								Title: LRListManagement.Lists.LeaveRequestItem.Fields.LeaveDictionary.Internal,
								Value: JSON.stringify(jsondic)
							},
							{
								Title: LRListManagement.Lists.LeaveRequestItem.Fields.CurrentUrl.Internal,
								Value: LRServices.Variables.CurrentUrl
							},
							{
								Title: LRListManagement.Lists.LeaveRequestItem.Fields.CurrentHostUrl.Internal,
								Value: LRServices.Variables.CurrentHostUrl
							},
							{
								Title: LRListManagement.Lists.LeaveRequestItem.Fields.CurrentAppUrl.Internal,
								Value: LRServices.Variables.CurrentAppUrl
							},
			
						];
						if (self.morebool()) {
							addfieldata.push({
								Title: LRListManagement.Lists.LeaveRequestItem.Fields.EndDate.Internal,
								Value: self.moreModel().todate().format(ko.dateformat.tolistnoTime)
							});
						}
						if (LRServices.Variables.OfficerHR.length > 0) {
							addfieldata.push({
								Title: LRListManagement.Lists.LeaveRequestItem.Fields.OfficerHr.Internal,
								Value: LRServices.Variables.OfficerHR
							});
			
						}
						var optioninside = {
							listTitle: self.listrequestformtitle,
							data: addfieldata,
							itemid: 0
						}
						ko.contentDialog.show();
						LRGlobalFunc.SaveDatatoList(optioninside).then(function (id) {
							LRGlobalFunc.swalalrt({
								title: gswalText().newleave.savesuccess,
								type: 'success'
							}, null, function () {
								ko.contentDialog.hide();
								parent.navLinkClick("idhomepage");
							});
						},LRServices.errorshowaler);
					//});
					
				}
	            else {
					LRGlobalFunc.swalalrt({
						title: gswalText().newleave.leavealreadyexist,
						type: 'error'
					});
	            }
			//});
			
		} else {
			//alert('Please check your submission.');
			LRGlobalFunc.swalalrt({
				title: gswalText().newleave.checksubmitsion,
				type: 'error'
			},null,function(){
				self.errors.showAllMessages();
				self.moreModel().errors.showAllMessages();
				self.othertypModel().errors.showAllMessages();
			});
		}

	}

	this.loadLeaveChoice = function (callback) {
		//LRServices.GetLeaveRequestConditionData().then(function (condition_data) {
			var myleavechoice = [];
			//console.log(LRServices.Variables.OfficerQuota);
			var lofficerquota  = $.extend(true, [], LRServices.Variables.OfficerQuota); 
			//$.extend( true, lofficerquota, LRServices.Variables.OfficerQuota );
			
			ko.utils.arrayForEach(lofficerquota, function (quo_item) {
				var myremain = ko.utils.arrayFilter(LRServices.Variables.LeaveConditions, function (cdata) {
					return cdata[LRListManagement.Lists.LeaveRequestCondition.Fields.LeaveCode.Internal] ===
						quo_item.code
				});
				if (myremain.length > 0) {
					quo_item.title = myremain[0][LRListManagement.Lists.LeaveRequestCondition.Fields.Title.Internal];
					try {
						quo_item.rights = JSON.parse(myremain[0][LRListManagement.Lists.LeaveRequestCondition.Fields.ConditionEmployeeRights.Internal]);
						quo_item.conditiondate = myremain[0][LRListManagement.Lists.LeaveRequestCondition.Fields.ConditionDate.Internal];
					} catch (e) { }
					myleavechoice.push(quo_item);
				}
			});
			self.leavetypearr(myleavechoice);
			//console.log(LRServices.Variables.OfficerQuota);
			//console.log(myleavechoice);
		//}, LRServices.errorshowaler);
		//LRServices.GetLeaveRequestConditionData().then(function(d){
		//	console.log(d);
		//});
		/*var options = {
		listTitle:self.listleavetypetitle ,
			fileData :[
				{field:"Id",type:"Default",typefield:"ID"},
				{field:"Title"}
			],
			queryText:"<View><Query><OrderBy><FieldRef Name='SortIndex'/></OrderBy></Query></View>"
		}
		ko.queryData(options ,function(data){
			self.leavetypearr(data);
		});*/
		//if(ToraAsiaLeaveRequestInfo.Services.OfficerInfo.length > 0){
		//			var objquata = JSON.parse(ToraAsiaLeaveRequestInfo.Services.OfficerInfo[0].OfficerQuata);
		//			self.leavetypearr(objquata);
		//console.log(self.leavetypearr());
		//}

	}
	this.loadLeaveChoice();
	/*this.loadAllLeaveDay(function () {
		ko.contentDialog.hide();
	});*/
	ko.contentDialog.show();
	LRServices.LoadLeaveRemian(function (myleavearr) {
		self.leavedays(myleavearr);
		ko.contentDialog.hide();
	});
	//console.log(LRServices.Variables.OfficerInfo);
	this.errors = ko.validation.group(self, { deep: true, live: true });
}
