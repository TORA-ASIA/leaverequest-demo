var LRServices = LRServices || {};
(function () {
	"use strict";

	LRServices.Variables = {
		AllDays: [
			{ title: gleavedic().alldays.$0, value: "0" },
			{ title: gleavedic().alldays.$1, value: "1" },
			{ title: gleavedic().alldays.$2, value: "2" },
			{ title: gleavedic().alldays.$3, value: "3" },
			{ title: gleavedic().alldays.$4, value: "4" },
			{ title: gleavedic().alldays.$5, value: "5" },
			{ title: gleavedic().alldays.$6, value: "6" }
		],//[0,1,2,3,4,5,6],
		LeaveTime: [
			{ title: gleavedic().leavetime.$1, value: "1" },
			{ title: gleavedic().leavetime.$2, value: "2" },
			{ title: gleavedic().leavetime.$3, value: "3" }
		],
		Workdaymapping: {
			$0: "Sunday",
			$1: "Monday",
			$2: "Tuesday",
			$3: "Wednesday",
			$4: "Thursday",
			$5: "Friday",
			$6: "Saturday"
		},
		CurrentQuotaYear: 0,
		OfficerInfo: null,
		OfficerQuota: null,
		OfficerQuotaID:0,
		OfficerHR: [],
		IsSetEndCircle: false,
		ActivateFeatureID: 0,
		IsFeatureActivate: false,
		WorkFlowDefName: "LeaveReqeustWFV1",//"WF Not Use",//"LeaveReqeustWF",
		WorkFlowName: "APP Leave Request",//"WF Not Use",//"APP Leave Request",//"Leave Request",//for subscription
		WorkflowDefId: null,
		WorkflowSubscriptionId: null,
		FoundWorkflowID: 0,
		IsFoundWorkflow: false,
		IsAdminFoundWorkflow: false,
		WorkflowMapingID: 0,
		IsWorkflowMaping: false,
		IsAdminWorkflowMaping: false,
		//IsSetLanguage: false,
		EndCircleDate: null,
		StartCircleYear: null,
		EndCircleYear: null,
		SelectLanguage: null,
		EndCircleID: 0,
		WorkingDaysID: 0,
		WorkingDays: [],
		RunningFormatID:0,
		SelectLanguageID:0,
		RunningFormat:"",
		HoliDays: [],
		LeaveConditions: [],
		RequestConfiguration: {
			FeatureActivated: "Feature Activated",
			FoundWorkflow: "Found Workflow in Site",
			WorkflowMaping: "Map Workflow to List",
			EndCircleDate: "Set End Circle Date",
			WorkingDays: "Office Work Days",
			Language: "Default Language",
			RunningNo: "Running Number",
		},
		LeaveStatus:{
			Approved: "Approved",
			InProgress: "In Progress"
		},
		//CountHolidayDays:["LR1"],
		CurrentUrl: "",
		CurrentHostUrl: "",
		CurrentAppUrl: "",
	};
	LRServices.Initial = function () {
		var deferred = $.Deferred();

		var deferred_error = function (err_msg) {
			return deferred.reject(err_msg);
		};

		var max_firstload = 5;
		var current_firstload = 0;
		var deferred_success = function () {
			current_firstload++;
			if (current_firstload === max_firstload) {
				return deferred.resolve("First Load Success.");
			}
		};

		new LRListManagement.Services.GetListInformation(false).then(function () {

			new LRServices.SetGlobalConfiguration().then(function () {
				new LRServices.GetCurrentOfficerInfo().then(function (data) {
					if (data.length > 0) {
						LRServices.Variables.OfficerInfo = data[0];
					}
					if (LRServices.Variables.OfficerInfo !== null && LRServices.Variables.EndCircleDate !== null) {
						new LRServices.SetOfficerQuota(LRServices.Variables.OfficerInfo).then(function () {
							deferred_success();
						}, deferred_error);
					}
					else{
						deferred_success();
					}
				}, deferred_error);
			}, deferred_error);

			new LRServices.CheckAdminWorflow().then(function () {
				deferred_success();
			}, deferred_error);

			new LRServices.CheckAdminworkflowMapping().then(function () {
				deferred_success();
			}, deferred_error);

			//ตำแหน่ง HR 
			new LRServices.GetCurrentOfficerByRole("HR").then(function (hr_data) {
				if (hr_data.length > 0) {
					var hrcoll = [];
					ko.utils.arrayForEach(hr_data, function (ouser) {
						hrcoll.push(ouser[LRListManagement.Lists.LeaveRequestOfficer.Fields.Officer.Internal]);
					});
					LRServices.Variables.OfficerHR = hrcoll;
				}
				deferred_success();
			}, deferred_error);

			//Leave Condition
			new LRServices.GetLeaveRequestConditionData().then(function (condition_data) {
				LRServices.Variables.LeaveConditions = condition_data;
				deferred_success();
			});
			//return deferred.resolve("Success");
		}, deferred_error);

		return deferred.promise();
	};
	LRServices.errorshowaler = function (err_msg) {
		LRGlobalFunc.swalalrt({
			title: err_msg,
			type: 'error'
		}, null, function () {
			ko.contentDialog.hide();
		});

	};
	LRServices.GetDayByOperation = function(cond,obj){
		var operator = cond["operator"];
		var operand = cond["operands"];
		//console.log(operator);
		//console.log(operand);
		var o0 = operand[0];
		var o1 = operand[1];
		var o2 = operand[2];
		//console.log(o0);
		//console.log(o1);
		//console.log(o2);
		
		switch(operator){
			case "?":
				var istrue = LRServices.GetDayByOperation(o0,obj);
				if(istrue){
					return o1;
				}
				else{
					if(typeof o2 === "object"){
						return LRServices.GetDayByOperation(o2,obj);
					}
					else{
						return o2;
					}
				}
				//return LRServices.GetDayByOperation(cond,checkvariable);
				break;
			case "&&":
				var andresult = true;
				ko.utils.arrayForEach(operand, function (and_item) {
					andresult = andresult && LRServices.GetDayByOperation(and_item,obj);
				});
				//console.log(andresult);
				return andresult;
			case "||":
				var orresult = false;
				ko.utils.arrayForEach(operand, function (or_item) {
					orresult = orresult || LRServices.GetDayByOperation(or_item,obj);
				});
				return orresult;
			case ">":
				var gt = LRServices.GetDayByOperation(o0,obj);
				//console.log(gt);
				return gt[0] > gt[1];
			case "<":
				var lt = LRServices.GetDayByOperation(o0,obj);
				//console.log(lt);
				return lt[0] < lt[1];
			case ">=":
				var geq = LRServices.GetDayByOperation(o0,obj);
				//console.log(geq);
				return geq[0] >= geq[1];
			case "Integer()":
				return [parseInt(obj[o0],10),parseInt(o1,10)];
		}
		return null;
	}
	LRServices.GenerateOfficerQuota = function (objdata,officer,userid,userquotaid) {
		var deferred = $.Deferred();

		var self = this;
		self.leavedataarr = ko.observableArray();
		self.condtionarr = ko.observableArray();
		self.l4count = ko.observable(0);
		self.l4year = ko.observable(0);
 
		var officergender = 
			((officer[LRListManagement.Lists.LeaveRequestOfficer.Fields.Gender.Internal]).toLowerCase() === "male"? 2 : 3);
		//console.log(objdata);
		self.afterLoadSuccess = function(){
			//console.log(self.leavedataarr());
			//console.log(self.condtionarr());
			var quotaarr = [];
			ko.utils.arrayForEach(self.condtionarr(), function (con_item) {
				//console.log(con_item);
				var d_code = con_item[LRListManagement.Lists.LeaveRequestCondition.Fields.LeaveCode.Internal];
				
				var d_show = con_item[LRListManagement.Lists.LeaveRequestCondition.Fields.ShowHide.Internal];
				var d_rights = con_item[LRListManagement.Lists.LeaveRequestCondition.Fields.ConditionEmployeeRights.Internal];
				//var d_date = con_item[LRListManagement.Lists.LeaveRequestCondition.Fields.ConditionDate.Internal];
				try {

					var d_gender = parseInt(con_item[LRListManagement.Lists.LeaveRequestCondition.Fields.ConditionGender.Internal],10);
					if(officergender === d_gender || d_gender === 1){
						//var d_rights_json = JSON.parse(d_rights);
						//console.log(d_rights_json);
						//loop count approve day
						if((d_code === "L4" && self.l4year() === objdata["year"])
								|| (d_code === "L4" && self.l4count() === 0)
								|| (d_code !== "L4")){

							var totals_leave = 0;
							var filter_leave =  ko.utils.arrayFilter(self.leavedataarr(), function(c_item) {
								return c_item[LRListManagement.Lists.LeaveRequestItem.Fields.LeaveType.Internal] 
										== d_code && c_item[LRListManagement.Lists.LeaveRequestItem.Fields.LeaveStatus.Internal] 
										== "Approved";
							});
							ko.utils.arrayForEach(filter_leave, function (f_item) {
								totals_leave += parseFloat(f_item[LRListManagement.Lists.LeaveRequestItem.Fields.LeaveDayTotal.Internal],10);	
							});
							//console.log(totals_leave);
							var maxquota = parseFloat(d_rights);
							//if(typeof d_rights_json.Condition === "object"){
							//	maxquota = LRServices.GetDayByOperation(d_rights_json.Condition,objdata);
							//}

							/*var json_opration = {
								"operator": "?", //if
								"operands" : [
									{
										"operator": "&&",
										"operands": [
											{
												"operator": "<",
												"operands": [{
													"operator": "Integer()",
													"operands": [
														"totalwork", //fieldname
														"365" //value
													]
												}]
											},
											{
												"operator": ">",
												"operands": [{
													"operator": "Integer()",
													"operands": [
														"totalwork", //fieldname
														"150" //value
													]
												}]
											}
										]
									},
									"5",//value
									{
										"operator": "?", //else if
										"operands": [
											{
												"operator": ">=",
												"operands": [{
													"operator": "Integer()",
													"operands": [
														"totalwork", //fieldname
														"365" //value
													]
												}]
											},
											"10",
											"7" //else
										]
									}  
								]
							};
							console.log(json_opration);
							var result = LRServices.GetDayByOperation(json_opration,objdata);*/
							//json_opration.operator = "?"
							//json_opration.operands = [];
							//Calualte Quota Without condition
							//console.log(json_opration);
							//console.log(maxquota);
							var curquota = {};
							curquota.code = d_code;
							curquota.max = maxquota;
							curquota.total = maxquota - totals_leave;
							quotaarr.push(curquota);
						}
					}
				} catch (e) {
					console.log(e);
				}

			});
			//console.log(quotaarr );
			//deferred.resolve();	
			//Save Quota
			
			if (quotaarr.length === 0) {
				return deferred.resolve();
			}
			else {
				var setfieldata = [
					{
						Title: LRListManagement.Lists.LeaveRequestQuota.Fields.Quota.Internal,
						Value: JSON.stringify(quotaarr)
					}
				];
				if(userquotaid === 0){
					setfieldata.push({
						Title: LRListManagement.Lists.LeaveRequestQuota.Fields.Title.Internal,
						Value: "User_" + userid + "_" + objdata["year"],
					});
					setfieldata.push({
						Title: LRListManagement.Lists.LeaveRequestQuota.Fields.Officer.Internal,
						Value: officer[LRListManagement.Lists.LeaveRequestOfficer.Fields.Officer.Internal],
					});
					setfieldata.push({
						Title: LRListManagement.Lists.LeaveRequestQuota.Fields.QuotaYear.Internal,
						Value: objdata["year"],
					});
				}
				var optioninside = {
					listTitle: LRListManagement.Lists.LeaveRequestQuota.Title,
					data: setfieldata,
					itemid: userquotaid
				}
				LRGlobalFunc.SaveDatatoList(optioninside).then(function (id) {
					return deferred.resolve();
				}, function (ermsg) {
					return deferred.reject(ermsg);
				});
			}

		}
		self.countfunction = 3;
		self.currentfunction = 0;

		new LRServices.GetLeaveItemsCurrentYear(objdata["year"],userid).then(function (leaveitem_data) {
			self.leavedataarr(leaveitem_data);
			self.currentfunction = self.currentfunction + 1;
			if(self.currentfunction === self.countfunction){
				self.afterLoadSuccess();
			}
		});//l4count
		new LRServices.GetLeaveItemsByLeaveType('L4',userid).then(function (leavetypeitem_data) {
			if(leavetypeitem_data.length > 0){
				self.l4year(leavetypeitem_data[0][LRListManagement.Lists.LeaveRequestItem.Fields.LeaveYear.Internal]);
			}
			self.l4count(leavetypeitem_data.length);
			self.currentfunction = self.currentfunction + 1;
			if(self.currentfunction === self.countfunction){
				self.afterLoadSuccess();
			}
		});
		new LRServices.GetLeaveRequestConditionData().then(function (condition_data) {
			self.condtionarr(condition_data);
			self.currentfunction = self.currentfunction + 1;
			if(self.currentfunction === self.countfunction){
				self.afterLoadSuccess();
			}
		});
		return deferred.promise();
	}
	LRServices.SetOfficerQuota = function (offinfo,isupdate,year) {
		var deferred = $.Deferred();
		offinfo = offinfo || null;
		var uid = (offinfo !== null? offinfo[LRListManagement.Lists.LeaveRequestOfficer.Fields.Officer.Internal+"ID"] : 0)
		isupdate = isupdate ||false;
		year = year || null;
		var circlestr = LRServices.Variables.EndCircleDate.format("DD/MM/YYYY");

		if(year !== null){
			var endcirclenew = moment(circlestr.toString(), "DD/MM/YYYY");
			endcirclenew = endcirclenew.years(year);
			circlestr = endcirclenew.format("DD/MM/YYYY");
		}


		var endC = moment(circlestr.toString(), "DD/MM/YYYY");
		var beginC = moment(circlestr.toString(), "DD/MM/YYYY");

		//ตรวจสอบปีของโควต้า
		var curdatestr = moment().format("DD/MM/YYYY");
		if(year !== null){
			curdatestr = moment([year]).format("DD/MM/YYYY");
		}
		var diffday = moment(curdatestr, "DD/MM/YYYY").diff(endC, 'd');
		if (diffday <= 0) {
			beginC.add({ days: 1, years: -1 });
		}
		else {
			endC.add({ years: 1 });
			beginC.add({ days: 1 });
		}
		var focusyear = beginC.year();
		if(uid === _spPageContextInfo.userId && year === null){
			LRServices.Variables.CurrentQuotaYear = focusyear;
		}
		//console.log(LRServices.Variables.CurrentQuotaYear);
		//console.log(beginC.format("DD/MM/YYYY"));
		//console.log(endC.format("DD/MM/YYYY"));
		//console.log(offinfo);
		var diffworkday = 0;
		if(offinfo !== null){
			diffworkday = Math.abs(
				moment(offinfo[LRListManagement.Lists.LeaveRequestOfficer.Fields.StartWorking.Internal], ko.dateformat.normal ).diff(beginC, 'd')
			);
		}
		var opyearwork = {
			"year": focusyear,
			"totalwork" : diffworkday
		}
		//console.log(opyearwork);
		new LRServices.GetOfficerQuotaByYear(focusyear,uid).then(function (d_quota) {
			var userquotaid = 0;
			if (d_quota.length > 0 ) {
				try {
					if(!isupdate && uid === _spPageContextInfo.userId){
						var d_quota_json = JSON.parse(d_quota[0][LRListManagement.Lists.LeaveRequestQuota.Fields.Quota.Internal]);
						LRServices.Variables.OfficerQuota = d_quota_json;
						LRServices.Variables.OfficerQuotaID = d_quota[0][LRListManagement.Lists.LeaveRequestQuota.Fields.ID.Internal];
						//console.log(LRServices.Variables.OfficerQuota);
						return deferred.resolve();
					}
					userquotaid =  d_quota[0][LRListManagement.Lists.LeaveRequestQuota.Fields.ID.Internal];
					
				} catch (ex) {
					console.log(ex);
					return deferred.resolve();
				}
			}
			if(isupdate || userquotaid === 0 || year !== null){
				new LRServices.GenerateOfficerQuota(opyearwork,offinfo,uid,userquotaid).then(function(){
					new LRServices.GetOfficerQuotaByYear(focusyear,uid).then(function (d_quota2) {
						if (d_quota2.length > 0 && !isupdate) {
							try {
								if(uid === _spPageContextInfo.userId){
									var d_quota_json2 = JSON.parse(d_quota2[0][LRListManagement.Lists.LeaveRequestQuota.Fields.Quota.Internal]);
									LRServices.Variables.OfficerQuota = d_quota_json2;
									LRServices.Variables.OfficerQuotaID = d_quota2[0][LRListManagement.Lists.LeaveRequestQuota.Fields.ID.Internal];
								}
							} catch (ex) {
								console.log(ex);
							}
							console.log(LRServices.Variables.OfficerQuota);							
						}
						return deferred.resolve();
					});
				}, function (ermsg) {
					return deferred.reject(ermsg);
				});
			}
		});
		return deferred.promise();
	};
	//อัพเดทโควต้า ตอน Approve
	LRServices.UpdateOfficerQuota = function (quotaarr,quotaid) {
		var deferred = $.Deferred();

		if (quotaid === 0) {
			return deferred.reject("Quota ID not found.");
		}
		else if(typeof quotaarr === "undefined"){
			return deferred.reject("Quota is undefined");
		}
		else {
			var setfieldata = [
				{
					Title: LRListManagement.Lists.LeaveRequestQuota.Fields.Quota.Internal,
					Value: JSON.stringify(quotaarr)
				}
			];
			var optioninside = {
				listTitle: LRListManagement.Lists.LeaveRequestQuota.Title,
				data: setfieldata,
				itemid: quotaid
			}
			LRGlobalFunc.SaveDatatoList(optioninside).then(function (id) {
				return deferred.resolve();
			}, function (ermsg) {
				return deferred.reject(ermsg);
			});
		}
		return deferred.promise();
	};
	LRServices.GetLeaveItemsCurrentYear = function(currentyear,userid){
		var deferred = $.Deferred();
		var leavedataarr = ko.observableArray();
		var allquery = [];
		var allquerystr = "";
		
		allquery.push(String.format(ko.defaultquery, "Eq", LRListManagement.Lists.LeaveRequestItem.Fields.Requester.Internal, "Lookup", userid, "LookupId='TRUE'", ""));
		allquery.push(String.format(ko.defaultquery, "Eq", LRListManagement.Lists.LeaveRequestItem.Fields.LeaveYear.Internal, "Number", currentyear, "", ""));
		allquery.push(String.format(ko.defaultquery, "Eq", LRListManagement.Lists.LeaveRequestItem.Fields.RequestType.Internal, "Text", "1", "", ""));

		if (allquery.length > 0) {
			allquerystr = "<Where>" + ko.MergeCAMLConditions(allquery, ko.MergeType.And) + "</Where>";
		}

		new LRServices.GetLeaveItems(leavedataarr ,allquerystr).then(function () {
			return deferred.resolve(leavedataarr());
		}, LRServices.errorshowaler);
		return deferred.promise();
	}
	LRServices.GetLeaveItemsByLeaveType = function(code,userid){
		var deferred = $.Deferred();
		var leavedataarr = ko.observableArray();
		var allquery = [];
		var allquerystr = "";
		
		allquery.push(String.format(ko.defaultquery, "Eq", LRListManagement.Lists.LeaveRequestItem.Fields.Requester.Internal, "Lookup", userid, "LookupId='TRUE'", ""));
		allquery.push(String.format(ko.defaultquery, "Eq", LRListManagement.Lists.LeaveRequestItem.Fields.LeaveType.Internal, "Text", code, "", ""));
		allquery.push(String.format(ko.defaultquery, "Eq", LRListManagement.Lists.LeaveRequestItem.Fields.RequestType.Internal, "Text", "1", "", ""));

		if (allquery.length > 0) {
			allquerystr = "<Where>" + ko.MergeCAMLConditions(allquery, ko.MergeType.And) + "</Where>";
		}

		new LRServices.GetLeaveItems(leavedataarr ,allquerystr).then(function () {
			return deferred.resolve(leavedataarr());
		}, LRServices.errorshowaler);
		return deferred.promise();
	}
	LRServices.GetLeaveItems = function (leaveitemarr, querystring) {
		var deferred = $.Deferred();

		var props = {};
		props.listtitle = LRListManagement.Lists.LeaveRequestItem.Title;
		props.options = {
			fileData: [
				{ field: LRListManagement.Lists.LeaveRequestItem.Fields.ID.Internal },
				{ field: LRListManagement.Lists.LeaveRequestItem.Fields.Title.Internal },
				{
					field: LRListManagement.Lists.LeaveRequestItem.Fields.StartDate.Internal,
					type: "Date", format: ko.dateformat.normal
				},
				{
					field: LRListManagement.Lists.LeaveRequestItem.Fields.EndDate.Internal,
					type: "Date", format: ko.dateformat.normal
				},
				{
					field: LRListManagement.Lists.LeaveRequestItem.Fields.Requester.Internal,
					type: "LookupText", typefield: LRListManagement.Lists.LeaveRequestItem.Fields.Requester.Internal
				},
				{ field: LRListManagement.Lists.LeaveRequestItem.Fields.LeaveDayTotal.Internal },
				{ field: LRListManagement.Lists.LeaveRequestItem.Fields.LeaveStatus.Internal },
				{ field: LRListManagement.Lists.LeaveRequestItem.Fields.LeaveType.Internal },
				{ field: LRListManagement.Lists.LeaveRequestItem.Fields.LeaveYear.Internal },

			],
			format: ko.dateformat.nomal
		}
		if (querystring.length > 0 && querystring !== "") {
			props.query = querystring;
		}

		LRGlobalFunc.queryDataJSOM(leaveitemarr, props, function () {
			return deferred.resolve();
		});
		return deferred.promise();
	};
	LRServices.GetRunningAndUpdate = function (year) {
		var deferred = $.Deferred();
		var allquery = [];
		var allquerystr = "";
		
		allquery.push(String.format(ko.defaultquery, "Eq", LRListManagement.Lists.LeaveRequestConfiguration.Fields.Title.Internal , "Text",
		LRServices.Variables.RequestConfiguration.RunningNo, "", ""));
		var props = {};
		if (allquery.length > 0) {
			allquerystr = "<Where>" + ko.MergeCAMLConditions(allquery, ko.MergeType.And) + "</Where>";
		}
		props.query = allquerystr;
		new LRServices.GetConfigurationData(props).then(function (data_conf) {
			console.log(data_conf);
			if(data_conf != null && data_conf.length > 0){
				var curdata = data_conf[0][LRListManagement.Lists.LeaveRequestConfiguration.Fields.Details.Internal ];
				try {
					var d_runing = JSON.parse(curdata);
					var run_year = d_runing["year"];
					var run_no = d_runing["number"];
					var run_format =  d_runing["format"];
					if(typeof run_format !== "undefined"){

						if(typeof run_no === "undefined" || run_year !== year){
							run_no = 1;
							run_year = year;
						}
						else{
							var c_run_no = parseInt(run_no,10);
							run_no = c_run_no+1;
						}
						var runingno = run_format.replace("{R}",run_no);
						d_runing["number"]  = 	run_no;
						d_runing["year"] = run_year;
						//Update running and year
						if(LRServices.Variables.RunningFormatID > 0){
						var cirid = parseInt(LRServices.Variables.RunningFormatID.toString(), 10);
						var addfieldata = [
						{
							Title: LRListManagement.Lists.LeaveRequestConfiguration.Fields.Details.Internal,
							Value: JSON.stringify(d_runing)               
						}
						];
						var optioninside = {
							listTitle: LRListManagement.Lists.LeaveRequestConfiguration.Title,
							data: addfieldata,
							itemid: cirid
						}
						LRGlobalFunc.SaveDatatoList(optioninside).then(function(id){
							console.log(d_runing);
							LRServices.Variables.RunningFormat  = d_runing;
							return deferred.resolve(runingno);
						},function(){
							return deferred.resolve(null);
						});
					}
					else{
						return deferred.resolve(null);
					}
						
						
					}
					//console.log(d_runing);
				}
				catch(e){
					// New Data
					return deferred.resolve(null);
				}
			}else{
				/*var temjson = {
					format: "R-{0}"
				}
				var currentno = 0;
				var curyear = year;
				if(typeof temjson.number !== "undefined" && typeof temjson.year !== "undefined"){

				}
				currentno++;
				var runingno = String.format(temjson.format,currentno);*/
				return deferred.resolve(null);
			}

		});
		return deferred.promise();
	};
	LRServices.CheckLeaveDayUsed = function (datefrom,dateto) {
		var deferred = $.Deferred();

		var allmyrequest = ko.observableArray([]);
		var allquery = [];
		var allquerydate = [];
		var allquerystr = "";
		

			allquery.push(String.format(ko.defaultquery, "Eq", LRListManagement.Lists.LeaveRequestItem.Fields.Requester.Internal, "Lookup", LRServices.GetUserId(), "LookupId='TRUE'", ""));

		var querystatus = [];
			querystatus.push(String.format(ko.defaultquery, "Eq", LRListManagement.Lists.LeaveRequestItem.Fields.LeaveStatus.Internal, "Text", LRServices.Variables.LeaveStatus.InProgress, "", ""));
			querystatus.push(String.format(ko.defaultquery, "Eq", LRListManagement.Lists.LeaveRequestItem.Fields.LeaveStatus.Internal, "Text", LRServices.Variables.LeaveStatus.Approved, "", ""));
			
			allquery.push(ko.MergeCAMLConditions(querystatus, ko.MergeType.Or));
		var queryFtoF = [];
		queryFtoF.push(String.format(ko.defaultquery, "Geq", LRListManagement.Lists.LeaveRequestItem.Fields.StartDate.Internal, "DateTime", datefrom, "IncludeTimeValue='False'", ""));
		queryFtoF.push(String.format(ko.defaultquery, "Leq", LRListManagement.Lists.LeaveRequestItem.Fields.StartDate.Internal, "DateTime", datefrom, "IncludeTimeValue='False'", ""));

			allquerydate.push(ko.MergeCAMLConditions(queryFtoF, ko.MergeType.And));
		if (dateto !== null) {
			var queryFtoE = [];
			queryFtoE.push(String.format(ko.defaultquery, "Geq", LRListManagement.Lists.LeaveRequestItem.Fields.StartDate.Internal, "DateTime", datefrom, "IncludeTimeValue='False'", ""));
			queryFtoE.push(String.format(ko.defaultquery, "Leq", LRListManagement.Lists.LeaveRequestItem.Fields.EndDate.Internal, "DateTime", dateto, "IncludeTimeValue='False'", ""));
			allquerydate.push(ko.MergeCAMLConditions(queryFtoE, ko.MergeType.And));
		}
		allquery.push(ko.MergeCAMLConditions(allquerydate, ko.MergeType.Or));

		if (allquery.length > 0) {
			allquerystr = "<Where>" + ko.MergeCAMLConditions(allquery, ko.MergeType.And) + "</Where>";
		}
		new LRServices.GetLeaveItems(allmyrequest ,allquerystr).then(function () {
			return deferred.resolve(allmyrequest().length === 0);
		}, LRServices.errorshowaler);

		return deferred.promise();

	};
	LRServices.LoadLeaveRemian = function (callback) {
		var countfunction = 2;
		var currentfunction = 0;
		var leavedataarr = ko.observableArray();
		var condtionarr = ko.observableArray();
		var self = this;
		this.afterLeaveRemianSuccess = function(leavedataarr,condtionarr){
			var myleaveremainarr = [];
			if(LRServices.Variables.OfficerQuota !== null){
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
								inpro_leave += parseFloat(f_item[LRListManagement.Lists.LeaveRequestItem.Fields.LeaveDayTotal.Internal],10);	
							});
							var remailobj = {};
							var maxday = parseFloat(quo_item.max, 10);
							var approveday = parseFloat(quo_item.total, 10);
							//var approveday = 
							remailobj.Title = myremain[0][LRListManagement.Lists.LeaveRequestCondition.Fields.Title.Internal];
							remailobj.code = quo_item.code;
							remailobj.MaxLeaveValue = maxday;
							remailobj.MyUseDay = {};
							remailobj.MyUseDay.approve = maxday - approveday;
							remailobj.MyUseDay.inprogress = inpro_leave;
		
							myleaveremainarr.push(remailobj);
						}
				});
			}
			callback(myleaveremainarr);
		}
		new LRServices.GetLeaveItemsCurrentYear(LRServices.Variables.CurrentQuotaYear,_spPageContextInfo.userId).then(function (leaveitem_data) {
			leavedataarr(leaveitem_data);
			currentfunction = currentfunction + 1;
			if(currentfunction === countfunction){
				self.afterLeaveRemianSuccess(leavedataarr,condtionarr);
			}
		});
		new LRServices.GetLeaveRequestConditionData().then(function (condition_data) {
			condtionarr(condition_data);
			currentfunction = currentfunction + 1;
			if(currentfunction === countfunction){
				self.afterLeaveRemianSuccess(leavedataarr,condtionarr);
			}
		}, LRServices.errorshowaler);
	};
	LRServices.GetOfficerQuotaByYear = function (year,userid) {
		var deferred = $.Deferred();

		var leavedataarr = ko.observableArray([])
		var props = {};
		props.listtitle = LRListManagement.Lists.LeaveRequestQuota.Title;
		props.options = {
			fileData: [
				{ field: LRListManagement.Lists.LeaveRequestQuota.Fields.ID.Internal },
				{ field: LRListManagement.Lists.LeaveRequestQuota.Fields.Title.Internal },
				{ field: LRListManagement.Lists.LeaveRequestQuota.Fields.Officer.Internal },
				{ field: LRListManagement.Lists.LeaveRequestQuota.Fields.QuotaYear.Internal },
				{ field: LRListManagement.Lists.LeaveRequestQuota.Fields.Quota.Internal }
			],
			format: ko.dateformat.nomal
		}
		var allquery = [];
		allquery.push(String.format(ko.defaultquery, "Eq", LRListManagement.Lists.LeaveRequestQuota.Fields.Officer.Internal, "Lookup", userid, "LookupId='TRUE'", ""));
		allquery.push(String.format(ko.defaultquery, "Eq", LRListManagement.Lists.LeaveRequestQuota.Fields.QuotaYear.Internal, "Number", year, "", ""));
		if (allquery.length > 0) {
			props.query = "<Where>" + ko.MergeCAMLConditions(allquery, ko.MergeType.And) + "</Where>";
		}

		LRGlobalFunc.queryDataJSOM(leavedataarr, props, function () {
			return deferred.resolve(leavedataarr());
		});
		return deferred.promise();
	};
	LRServices.GetLeaveRequestConditionData = function () {
		var deferred = $.Deferred();

		var leavedataarr = ko.observableArray([])
		var props = {};
		props.listtitle = LRListManagement.Lists.LeaveRequestCondition.Title;
		props.options = {
			fileData: [
				{ field: LRListManagement.Lists.LeaveRequestCondition.Fields.ID.Internal },
				{ field: LRListManagement.Lists.LeaveRequestCondition.Fields.Title.Internal },
				{ field: LRListManagement.Lists.LeaveRequestCondition.Fields.LeaveCode.Internal },
				{ field: LRListManagement.Lists.LeaveRequestCondition.Fields.ConditionGender.Internal },
				{ field: LRListManagement.Lists.LeaveRequestCondition.Fields.ConditionEmployeeRights.Internal },
				//{ field: LRListManagement.Lists.LeaveRequestCondition.Fields.ConditionDate.Internal },
				{ field: LRListManagement.Lists.LeaveRequestCondition.Fields.ShowHide.Internal },

			],
			format: ko.dateformat.nomal
		}
		LRGlobalFunc.queryDataJSOM(leavedataarr, props, function () {
			return deferred.resolve(leavedataarr());
		});
		return deferred.promise();
	};
	LRServices.GenOfficersQuota = function (year) {
		var deferred = $.Deferred();
		new LRServices.GetCurrentOfficers().then(function(officers){
			ko.utils.arrayForEach(officers, function (officer) {
				new LRServices.SetOfficerQuota(officer,true,year).then(function(){
					return deferred.resolve();
				});
			});
		});

		return deferred.promise();
	};
	LRServices.GetCurrentOfficerByRole = function (role) {
		var deferred = $.Deferred();
		var leavedataarr = ko.observableArray([])
		var props = {};
		props.listtitle = LRListManagement.Lists.LeaveRequestOfficer.Title;
		props.options = {
			fileData: [
				{ field: LRListManagement.Lists.LeaveRequestOfficer.Fields.ID.Internal },
				{ field: LRListManagement.Lists.LeaveRequestOfficer.Fields.Title.Internal },
				{ field: LRListManagement.Lists.LeaveRequestOfficer.Fields.Officer.Internal },
				{ field: LRListManagement.Lists.LeaveRequestOfficer.Fields.Officer.Internal+"ID",type:"LookupId",typefield:LRListManagement.Lists.LeaveRequestOfficer.Fields.Officer.Internal },
				{ field: LRListManagement.Lists.LeaveRequestOfficer.Fields.Gender.Internal },
				{ field: LRListManagement.Lists.LeaveRequestOfficer.Fields.Position.Internal },
				{ field: LRListManagement.Lists.LeaveRequestOfficer.Fields.Department.Internal },
				{ field: LRListManagement.Lists.LeaveRequestOfficer.Fields.Role.Internal },
				{ field: LRListManagement.Lists.LeaveRequestOfficer.Fields.Approver.Internal },
				{ field: LRListManagement.Lists.LeaveRequestOfficer.Fields.StartWorking.Internal, type: "Date", format: ko.dateformat.normal },

			],
			format: ko.dateformat.nomal
		}
		var allquery = [];
		allquery.push(String.format(ko.defaultquery, "Eq", LRListManagement.Lists.LeaveRequestOfficer.Fields.Role.Internal, "Text", role, "", ""));
		if (allquery.length > 0) {
			props.query = "<Where>" + ko.MergeCAMLConditions(allquery, ko.MergeType.And) + "</Where>";
		}

		LRGlobalFunc.queryDataJSOM(leavedataarr, props, function () {
			return deferred.resolve(leavedataarr());
		});
		return deferred.promise();
	};
	LRServices.GetCurrentOfficers = function () {
		var deferred = $.Deferred();

		var leavedataarr = ko.observableArray([])
		var props = {};
		props.listtitle = LRListManagement.Lists.LeaveRequestOfficer.Title;
		props.options = {
			fileData: [
				{ field: LRListManagement.Lists.LeaveRequestOfficer.Fields.ID.Internal },
				{ field: LRListManagement.Lists.LeaveRequestOfficer.Fields.Title.Internal },
				{ field: LRListManagement.Lists.LeaveRequestOfficer.Fields.Officer.Internal },
				{ field: LRListManagement.Lists.LeaveRequestOfficer.Fields.Officer.Internal+"ID",type:"LookupId",typefield:LRListManagement.Lists.LeaveRequestOfficer.Fields.Officer.Internal },
				{ field: LRListManagement.Lists.LeaveRequestOfficer.Fields.Gender.Internal },
				{ field: LRListManagement.Lists.LeaveRequestOfficer.Fields.Position.Internal },
				{ field: LRListManagement.Lists.LeaveRequestOfficer.Fields.Department.Internal },
				{ field: LRListManagement.Lists.LeaveRequestOfficer.Fields.Role.Internal },
				{ field: LRListManagement.Lists.LeaveRequestOfficer.Fields.Approver.Internal },
				{ field: LRListManagement.Lists.LeaveRequestOfficer.Fields.StartWorking.Internal, type: "Date", format: ko.dateformat.normal },

			],
			format: ko.dateformat.nomal
		}
		var allquery = [];
		//allquery.push(String.format(ko.defaultquery, "Eq", LRListManagement.Lists.LeaveRequestOfficer.Fields.Officer.Internal, "Lookup", _spPageContextInfo.userId, "LookupId='TRUE'", ""));
		if (allquery.length > 0) {
			props.query = "<Where>" + ko.MergeCAMLConditions(allquery, ko.MergeType.And) + "</Where>";
		}

		LRGlobalFunc.queryDataJSOM(leavedataarr, props, function () {
			return deferred.resolve(leavedataarr());
		});
		return deferred.promise();
	};
	LRServices.GetCurrentOfficerInfo = function () {
		var deferred = $.Deferred();

		var leavedataarr = ko.observableArray([])
		var props = {};
		props.listtitle = LRListManagement.Lists.LeaveRequestOfficer.Title;
		props.options = {
			fileData: [
				{ field: LRListManagement.Lists.LeaveRequestOfficer.Fields.ID.Internal },
				{ field: LRListManagement.Lists.LeaveRequestOfficer.Fields.Title.Internal },
				{ field: LRListManagement.Lists.LeaveRequestOfficer.Fields.Officer.Internal },
				{ field: LRListManagement.Lists.LeaveRequestOfficer.Fields.Officer.Internal+"ID",type:"LookupId",typefield:LRListManagement.Lists.LeaveRequestOfficer.Fields.Officer.Internal },
				{ field: LRListManagement.Lists.LeaveRequestOfficer.Fields.Gender.Internal },
				{ field: LRListManagement.Lists.LeaveRequestOfficer.Fields.Position.Internal },
				{ field: LRListManagement.Lists.LeaveRequestOfficer.Fields.Department.Internal },
				{ field: LRListManagement.Lists.LeaveRequestOfficer.Fields.Role.Internal },
				{ field: LRListManagement.Lists.LeaveRequestOfficer.Fields.Approver.Internal },
				{ field: LRListManagement.Lists.LeaveRequestOfficer.Fields.StartWorking.Internal, type: "Date", format: ko.dateformat.normal },

			],
			format: ko.dateformat.nomal
		}
		var allquery = [];
		allquery.push(String.format(ko.defaultquery, "Eq", LRListManagement.Lists.LeaveRequestOfficer.Fields.Officer.Internal, "Lookup", _spPageContextInfo.userId, "LookupId='TRUE'", ""));
		if (allquery.length > 0) {
			props.query = "<Where>" + ko.MergeCAMLConditions(allquery, ko.MergeType.And) + "</Where>";
		}

		LRGlobalFunc.queryDataJSOM(leavedataarr, props, function () {
			return deferred.resolve(leavedataarr());
		});
		return deferred.promise();
	};
	LRServices.GetConfigurationData = function (opt) {
		opt = opt || {};
		var deferred = $.Deferred();

		var configdataarr = ko.observableArray([])
		var props = {};
		props.listtitle = LRListManagement.Lists.LeaveRequestConfiguration.Title;
		props.options = {
			fileData: [
				{ field: LRListManagement.Lists.LeaveRequestConfiguration.Fields.ID.Internal },
				{ field: LRListManagement.Lists.LeaveRequestConfiguration.Fields.Title.Internal },
				{ field: LRListManagement.Lists.LeaveRequestConfiguration.Fields.Details.Internal }
			],
			format: ko.dateformat.nomal
		}
		$.extend( props, opt);
		LRGlobalFunc.queryDataJSOM(configdataarr, props, function () {
			return deferred.resolve(configdataarr());
		});
		return deferred.promise();
	};
	LRServices.GetTaskByRequestId = function (itemid) {
		var deferred = $.Deferred();

		var configdataarr = ko.observableArray([])
		var props = {};
		props.listtitle = LRListManagement.Lists.LeaveRequestWorkflowTask.Title;
		props.options = {
			fileData: [
				{ field: LRListManagement.Lists.LeaveRequestWorkflowTask.Fields.ID.Internal },
				{ field: LRListManagement.Lists.LeaveRequestWorkflowTask.Fields.Title.Internal }
			],
			format: ko.dateformat.nomal
		}
		var allquery = [];
		var deltaskid = [];
		//var queryBegin = [];
		allquery.push(String.format(ko.defaultquery, "Neq", LRListManagement.Lists.LeaveRequestWorkflowTask.Fields.Status.Internal, "Choice", "Completed", "", ""));
		allquery.push(String.format(ko.defaultquery, "Contains", LRListManagement.Lists.LeaveRequestWorkflowTask.Fields.RelatedItems.Internal, "Text", "[{\"ItemId\":" + itemid, "", ""));
		if (allquery.length > 0) {
			props.query = "<Where>" + ko.MergeCAMLConditions(allquery, ko.MergeType.And) + "</Where>";
		}
		LRGlobalFunc.queryDataJSOM(configdataarr, props, function () {
			return deferred.resolve(configdataarr().length > 0);
		});
		return deferred.promise();
	};
	LRServices.SetGlobalConfiguration = function () {
		var deferred = $.Deferred();
		LRServices.GetConfigurationData().then(function (data_conf) {
			if (data_conf != null) {
				ko.utils.arrayForEach(data_conf, function (ddata) {
					var dataid = ddata[LRListManagement.Lists.LeaveRequestConfiguration.Fields.ID.Internal];
					var datatitle = ddata[LRListManagement.Lists.LeaveRequestConfiguration.Fields.Title.Internal];
					var datadetail = ddata[LRListManagement.Lists.LeaveRequestConfiguration.Fields.Details.Internal];

					switch (datatitle) {
						case LRServices.Variables.RequestConfiguration.EndCircleDate:
							if (datadetail !== null) {
								LRServices.Variables.IsSetEndCircle = true;
								LRServices.Variables.EndCircleDate = moment(datadetail, ko.dateformat.endcircletoList);
								var circlestr = LRServices.Variables.EndCircleDate.format("DD/MM/YYYY");
								var endC = moment(circlestr.toString(), "DD/MM/YYYY");
								var beginC = moment(circlestr.toString(), "DD/MM/YYYY");
								
								//ตรวจสอบปีของโควต้า
								var curdatestr = moment().format("DD/MM/YYYY")
								var diffday = moment(curdatestr, "DD/MM/YYYY").diff(endC, 'd');
								if (diffday <= 0) {
									beginC.add({ days: 1, years: -1 });
								}
								else {
									endC.add({ years: 1 });
									beginC.add({ days: 1 });
								}
								LRServices.Variables.StartCircleYear = moment(beginC.format("DD/MM/YYYY"), "DD/MM/YYYY");
								LRServices.Variables.EndCircleYear = moment(endC.format("DD/MM/YYYY"), "DD/MM/YYYY");
							}
							LRServices.Variables.EndCircleID = dataid;
							break;
						case LRServices.Variables.RequestConfiguration.RunningNo:
							if (ddata.Details !== null && ddata.Details !== "") {
								try{
									var jsonparsedetail = JSON.parse(ddata.Details);
									LRServices.Variables.RunningFormat = jsonparsedetail;
								}catch(e){
									LRServices.Variables.RunningFormat = ddata.Details;
								}
								//LRServices.Variables.RunningFormat = ddata.Details.split(',');
							}
							LRServices.Variables.RunningFormatID = dataid;
							break;	
						case LRServices.Variables.RequestConfiguration.FoundWorkflow:
							if (datadetail === "true") {
								LRServices.Variables.IsFoundWorkflow = true;
							}
							LRServices.Variables.FoundWorkflowID = dataid;
							break;
						case LRServices.Variables.RequestConfiguration.WorkflowMaping:
							if (datadetail === "true") {
								LRServices.Variables.IsWorkflowMaping = true;
							}
							LRServices.Variables.WorkflowMapingID = dataid;
							break;
						case LRServices.Variables.RequestConfiguration.FeatureActivated:
							if (datadetail === "true") {
								LRServices.Variables.IsFeatureActivate = true;
							}
							LRServices.Variables.ActivateFeatureID = dataid;
							break;
						case LRServices.Variables.RequestConfiguration.Language:
							if (ddata.Details !== null && ddata.Details !== "") {
								LRServices.Variables.SelectLanguage = ddata.Details ;
								currentlang = ddata.Details ;
							}
							LRServices.Variables.SelectLanguageID = dataid;
							break;				
						case LRServices.Variables.RequestConfiguration.WorkingDays:
							if (ddata.Details !== null && ddata.Details !== "") {
								LRServices.Variables.WorkingDays = ddata.Details.split(',');
							}
							LRServices.Variables.WorkingDaysID = dataid;
							break;
					}
				});
			}
			return deferred.resolve();
		});

		return deferred.promise();
	};
	LRServices.ActivateFeature = function (featureGuid) {
		var deferred = $.Deferred();
		//Get SP clientContext
		SharePointClient.Configurations.IsCrossDomainRequest = LRGlobalFunc.IsCrossDomain;
		//SharePointClient.Configurations.SPUrl = utility.GetHostUrl();
		var hostcontext = new SharePointClient.Services.JSOM.Context();
		//get current context
		var hostCtx = hostcontext.GetClientContext();
		//get current web  
		var hostWeb = hostcontext.GetWeb();

		var guid = new SP.Guid('{' + featureGuid + '}');
		var featDefinition = hostWeb.get_features().add(guid, true, SP.FeatureDefinitionScope.farm);
		hostCtx.executeQueryAsync(function () {
			LRServices.Variables.IsFeatureActivate = true;
			return deferred.resolve();
		}, function (sender, args) {
			//return deferred.reject('Failed to find workflow assosiate list. Error:' + args.get_message());
			return deferred.reject('Failed to activate feature. Error:' + args.get_message());
		});


		return deferred.promise();
	};
	LRServices.CheckAdminWorflow = function () {
		var deferred = $.Deferred();
		//Get SP clientContext
		SharePointClient.Configurations.IsCrossDomainRequest = LRGlobalFunc.IsCrossDomain;
		//SharePointClient.Configurations.SPUrl = utility.GetHostUrl();
		var hostcontext = new SharePointClient.Services.JSOM.Context();
		//get current context
		var hostCtx = hostcontext.GetClientContext();
		//get current web  
		var hostWeb = hostcontext.GetWeb();

		LRServices.CheckFoundWorflow(hostCtx, hostWeb).then(function (wdef) {
			if(wdef !== null) {
				LRServices.Variables.IsAdminFoundWorkflow = true;				
				LRServices.Variables.WorkflowDefId = wdef.get_id().toString();
			}
			return deferred.resolve();
		}, function (mgs2) {
			return deferred.reject(mgs2);
		});
		return deferred.promise();
	};
	LRServices.CheckFoundWorflow = function (context, currentWEB) {
		// Create a new Deferred object
		var deferred = $.Deferred();

		context.load(currentWEB);
		// Workflow Services API entry point - WorkflowServiceManager object
		var servicesManager = SP.WorkflowServices.WorkflowServicesManager.newObject(context, currentWEB);
		context.load(servicesManager);

		var workflowDefinitions = servicesManager.getWorkflowDeploymentService().enumerateDefinitions(false);
		context.load(workflowDefinitions);


		context.executeQueryAsync(function () {
			//alert("Sharepoint custom list is created Successfully..")
			// enumerateDefinition returns ClientCollection object
			var definitionsEnum = workflowDefinitions.getEnumerator();
			// Going through the definitions
			while (definitionsEnum.moveNext()) {

				var def = definitionsEnum.get_current();

				// Displaying information about this definition - DisplayName and Id
				if (def.get_displayName() === LRServices.Variables.WorkFlowDefName) {
					return deferred.resolve(def);
				}
			}

			return deferred.resolve(null);
		}, function (sender, args) {
			//console.log('Failed to create list. Error:' + args.get_message());
			return deferred.reject('Failed to find workflow. Error:' + args.get_message());
		});

		// Return the Deferred's Promise object
		return deferred.promise();
	};
	LRServices.SaveWorkflowDefinition = function (ctx, web, myDefinition, hostDefinition) {
		// Create a new Deferred object
		var deferred = $.Deferred();
		// we have to repeat the procedure of getting WorkflowServicesManager object because
		// it should be retrieved for each web separately
		ctx.load(web);
		var servicesManager = SP.WorkflowServices.WorkflowServicesManager.newObject(ctx, web);
		ctx.load(servicesManager);
		// Save and publish the definition
		//myDefinition.set_displayName(myDefinition.get_displayName());
		console.log('App Definition info :' + myDefinition.get_id() + ":" + myDefinition.get_displayName());
		var workflow = new SP.WorkflowServices.WorkflowDefinition(ctx);
		workflow.set_displayName(myDefinition.get_displayName());
		workflow.set_xaml(myDefinition.get_xaml());
		ko.utils.objectForEach(myDefinition.get_properties(), function (key, value) {
			if (key !== "Definition.Id") {
				workflow.setProperty(key, value);
			}
		});
		if (hostDefinition !== null) {
			console.log('Host Definition info :' + hostDefinition.get_id() + ":" + hostDefinition.get_displayName());
			workflow.set_id(hostDefinition.get_id());
		}
		servicesManager.getWorkflowDeploymentService().saveDefinition(workflow);
		//servicesManager.getWorkflowDeploymentService().publishDefinition(myDefinition.get_id());
		ctx.load(workflow);
		ctx.executeQueryAsync(function (sender, args) {
			console.log('Definition saved to site ' + workflow.get_id() + web.get_url());
			servicesManager.getWorkflowDeploymentService().publishDefinition(workflow.get_id());
			ctx.executeQueryAsync(function (sender2, arg2) {
				console.log("publish success");
				return deferred.resolve(workflow);
			}, function (sender2, args2) {
				return deferred.reject('Failed to publish workflow. Error:' + args2.get_message());
			});
		}, function (sender, args) {
			return deferred.reject('Failed to save workflow. Error:' + args.get_message());
		});
		// Return the Deferred's Promise object
		return deferred.promise();

	};
	LRServices.CloneWorkflow = function () {
		var deferred = $.Deferred();
		//Get SP clientContext
		SharePointClient.Configurations.IsCrossDomainRequest = LRGlobalFunc.IsCrossDomain;
		//SharePointClient.Configurations.SPUrl = utility.GetHostUrl();
		var hostcontext = new SharePointClient.Services.JSOM.Context();
		//get current context
		var hostCtx = hostcontext.GetClientContext();
		//get current web  
		var hostWeb = hostcontext.GetWeb();

		SharePointClient.Configurations.IsCrossDomainRequest = false;
		var appcontext = new SharePointClient.Services.JSOM.Context();
		//var appCtx = new SP.AppContextSite(hostcontext, utility.GetHostUrl());
		var appCtx = appcontext.GetClientContext();

		var appWeb = appcontext.GetWeb();

		LRServices.CheckFoundWorflow(hostCtx, hostWeb).then(function (hostdef) {
			LRServices.CheckFoundWorflow(appCtx, appWeb).then(function (defin) {
				if (defin !== null) {
					//var defid = defin.get_id();
					LRServices.SaveWorkflowDefinition(hostCtx, hostWeb, defin, hostdef).then(function (wdef) {

						LRServices.Variables.IsAdminFoundWorkflow = true;
						LRServices.Variables.WorkflowDefId = wdef.get_id().toString();

						return deferred.resolve();
					}, function (mgs2) {
						return deferred.reject(mgs2);
					});
				}
				else {
					return deferred.reject("Workflow not found");
				}
			}, function (msg) {
				return deferred.reject(msg);
			});
		}, function (mgshost) {
			return deferred.reject(mgshost);
		});

		return deferred.promise();
	};
	LRServices.CheckAdminworkflowMapping = function () {
		var deferred = $.Deferred();
		//Get SP clientContext
		SharePointClient.Configurations.IsCrossDomainRequest = LRGlobalFunc.IsCrossDomain;
		//SharePointClient.Configurations.SPUrl = utility.GetHostUrl();
		var hostcontext = new SharePointClient.Services.JSOM.Context();
		//get current context
		var hostCtx = hostcontext.GetClientContext();
		//get current web  
		var hostWeb = hostcontext.GetWeb();

		LRServices.CheckworkflowMapping(hostCtx, hostWeb).then(function (wdef) {
			LRServices.Variables.IsAdminWorkflowMaping = true;
			LRServices.Variables.WorkflowSubscriptionId = wdef.get_id().toString();
			return deferred.resolve();
		}, function (mgs2) {
			return deferred.reject(mgs2);
		});
		return deferred.promise();
	};

	LRServices.CheckworkflowMapping = function (context, currentWEB) {
		var deferred = $.Deferred();

		var wfServicesManager = new SP.WorkflowServices.WorkflowServicesManager(context, currentWEB);
		var workflowSubscriptionService = wfServicesManager.getWorkflowSubscriptionService();
		var workflowAssociations = workflowSubscriptionService.enumerateSubscriptionsByList(
			LRListManagement.Lists.LeaveRequestItem.ID
		);

		context.load(workflowAssociations);
		context.executeQueryAsync(function () {
			//alert("Sharepoint custom list is created Successfully..")
			var association = workflowAssociations.getEnumerator();
			while (association.moveNext()) {
				var curin = association.get_current();
				if (curin.get_name() === LRServices.Variables.WorkFlowName) {
					return deferred.resolve(curin);
				}
			}
			return deferred.reject("workflow assosiate list not found");
		}, function (sender, args) {
			return deferred.reject('Failed to find workflow assosiate list. Error:' + args.get_message());
		});
		// Return the Deferred's Promise object
		return deferred.promise();
	};
	LRServices.WorkflowAssociationToList = function (ctx, web, workflowDefinitionId) {

		var listGuid = LRListManagement.Lists.LeaveRequestItem.ID;
		// Create a new Deferred object
		var deferred = $.Deferred();


		ctx.load(web);
		// Get WorkflowServicesManager object for the specified web
		var servicesManager = SP.WorkflowServices.WorkflowServicesManager.newObject(ctx, web);
		ctx.load(servicesManager);
		// Creating the subscription
		var sub = new SP.WorkflowServices.WorkflowSubscription(ctx);
		sub.set_name(LRServices.Variables.WorkFlowName);
		sub.set_enabled(true);
		sub.set_definitionId(workflowDefinitionId);
		sub.set_statusFieldName(LRServices.Variables.WorkFlowName);
		sub.set_eventSourceId(listGuid);
		sub.set_eventTypes(["WorkflowStart", "ItemAdded"]);//, "ItemUpdated"

		// These 3 are MANDATORY! Otherwise the workflow will fail to complete
		sub.setProperty("TaskListId", LRListManagement.Lists.LeaveRequestWorkflowTask.ID);
		sub.setProperty("HistoryListId", LRListManagement.Lists.LeaveRequestWorkflowHistory.ID);
		sub.setProperty("FormData", "");

		// Associate the workflow with the list
		servicesManager.getWorkflowSubscriptionService().publishSubscriptionForList(sub, listGuid);

		ctx.executeQueryAsync(function (sender, args) {
			console.log('Workflow association has been created successfully. Web: ' + web.get_url());
			return deferred.resolve();

		}, function (sender, args) {
			//console.log('Failed to create list. Error:' + args.get_message());
			return deferred.reject('Failed to add workflow subscription to list. Error:' + args.get_message());
		});

		// Return the Deferred's Promise object
		return deferred.promise();

	};
	LRServices.AddWorkflowdefinitiontoList = function () {
		var deferred = $.Deferred();
		//Get SP clientContext
		SharePointClient.Configurations.IsCrossDomainRequest = LRGlobalFunc.IsCrossDomain;
		//SharePointClient.Configurations.SPUrl = utility.GetHostUrl();
		var hostcontext = new SharePointClient.Services.JSOM.Context();
		//get current context
		var hostCtx = hostcontext.GetClientContext();
		//get current web  
		var hostWeb = hostcontext.GetWeb();

		LRServices.CheckFoundWorflow(hostCtx, hostWeb).then(function (defin) {
			if (defin !== null) {
				var defid = defin.get_id();
				LRServices.WorkflowAssociationToList(hostCtx, hostWeb, defid).then(function () {
					LRServices.Variables.IsAdminWorkflowMaping = true;
					return deferred.resolve();
				},
					function (mgs3) {
						return deferred.reject(mgs3);
					});
			}
			else {
				return deferred.reject("Workflow not found");
			}
		}, function (msg) {
			return deferred.reject(msg);
		});

		return deferred.promise();
	};
	LRServices.IsAllListCreated = function () {
		var isallcrate = true;
		//console.log(ToraAsiaLeaveRequestInfo.ListManagement);	
		ko.utils.objectForEach(LRListManagement.Lists, function (key, value) {
			isallcrate = (isallcrate && value.ID !== null)
		});
		return isallcrate;

	};
	LRServices.GetIsWorkflowMapping = function () {
		if (LRServices.isSiteAdmin()) {
			return LRServices.Variables.IsAdminWorkflowMaping;
		}
		return LRServices.Variables.IsWorkflowMaping;
	};
	LRServices.GetIsFoundWorkflow = function () {
		if (LRServices.isSiteAdmin()) {
			return LRServices.Variables.IsAdminFoundWorkflow;
		}
		return LRServices.Variables.IsFoundWorkflow;
	};
	LRServices.GetIsSetEndCircle = function () {
		return LRServices.Variables.IsSetEndCircle;
	};
	LRServices.GetIsFeatureActivate = function () {
		return LRServices.Variables.IsFeatureActivate;
	};
	LRServices.GetOfficerManager = function () {
		if (LRServices.Variables.OfficerInfo === null) {
			return null;
		}
		else {
			return LRServices.Variables.OfficerInfo[LRListManagement.Lists.LeaveRequestOfficer.Fields.Approver.Internal]
		}
	};
    /*LRServices.GetOfficerHR = function(){
        if(LRServices.Variables.OfficerInfo.length === 0) 
        {	
        	return null;
        }
        else{
        	var hrcoll = [];
        	ko.utils.arrayForEach(LRServices.Variables.OfficerHR, function(ouser ) {
		         hrcoll.push(ouser.Officer);         
		    });

        	return hrcoll;
        }
    };*/
	LRServices.GetUserId = function () {
		return _spPageContextInfo.userId;
	};
	LRServices.isSiteAdmin = function () {
		return _spPageContextInfo.isSiteAdmin
	};
	LRServices.isFoundOfficer = function () {
		return LRServices.Variables.OfficerInfo !== null;
	};
	LRServices.CheckOfficerRole = function (role) {
		if (LRServices.Variables.OfficerInfo === null) {
			return false;
		}
		else {
			var posstr = LRServices.Variables.OfficerInfo[LRListManagement.Lists.LeaveRequestOfficer.Fields.Role.Internal];
			if (posstr !== null) {
				return posstr.indexOf(role) > -1
			}
			else {
				return false;
			}
		}

	};
	LRServices.isHr = function () {
		return LRServices.CheckOfficerRole("HR");
	};
	LRServices.isManager = function () {
		return LRServices.CheckOfficerRole("Approver");
	};
	LRServices.isAppReady = function () {
		return LRServices.IsAllListCreated()
			&& LRServices.GetIsWorkflowMapping()
			&& LRServices.GetIsFoundWorkflow()
			&& LRServices.GetIsFeatureActivate();
	};

	//Table Binding
	LRServices.bindStatus = function (data) {
		
		var ls = data || "";
		if(typeof data === "object"){
			ls = data[LRListManagement.Lists.LeaveRequestItem.Fields.LeaveStatus.Internal]
		}
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
	};
	LRServices.bindDate = function (data) {
        var sd = data[LRListManagement.Lists.LeaveRequestItem.Fields.StartDate.Internal];
        var ed = data[LRListManagement.Lists.LeaveRequestItem.Fields.EndDate.Internal];
        var tday = data[LRListManagement.Lists.LeaveRequestItem.Fields.LeaveDayTotal.Internal];
        var inttday = parseInt(tday, 10);
        if (inttday > 1) {
            return sd + " - " + ed;
        }
        return sd;
    };
	LRServices.bindLeaveType = function (data) {
		var lcode = data[LRListManagement.Lists.LeaveRequestItem.Fields.LeaveType.Internal];
		var ltitle = (typeof lcode === "function"?lcode() : lcode);
		var mycondigtion = ko.utils.arrayFilter(LRServices.Variables.LeaveConditions, function (cdata) {
			return lcode === cdata[LRListManagement.Lists.LeaveRequestCondition.Fields.LeaveCode.Internal]
		});
		if (mycondigtion.length > 0) {
			ltitle = mycondigtion[0][LRListManagement.Lists.LeaveRequestCondition.Fields.Title.Internal]
		}
		return ltitle
	};

})();
ko.bindingHandlers.bindLeaveType = (function(){
	var self = this,
	unwrap = ko.utils.unwrapObservable; //support older KO versions that did not have ko.unwrap

   this.bindLeaveText= function(element, valueAccessor, allBindingsAccessor,isfirst){
		var lcode = valueAccessor()();
		var ltitle = (typeof lcode === "function"?lcode() : lcode);
		var mycondigtion = ko.utils.arrayFilter(LRServices.Variables.LeaveConditions, function (cdata) {
			return lcode === cdata[LRListManagement.Lists.LeaveRequestCondition.Fields.LeaveCode.Internal]
		});
		if (mycondigtion.length > 0) {
			ltitle = mycondigtion[0][LRListManagement.Lists.LeaveRequestCondition.Fields.Title.Internal]
		}
		$(element).text(ltitle);
   }

return {
	 init: function (element, valueAccessor, allBindingsAccessor, data, context) {
		self.bindLeaveText(element, valueAccessor, allBindingsAccessor,true);
	 },
	update: function (element, valueAccessor, allBindingsAccessor) {
		self.bindLeaveText(element, valueAccessor, allBindingsAccessor,false);

	}

}

})(jQuery);