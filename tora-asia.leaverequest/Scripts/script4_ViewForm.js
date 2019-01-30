function LRApproveViewModel(parent, itemId, taskid, backtoform, isviewonly, showdate, ishrform) {
	//taskid,ishrform
	ko.contentDialog.show();
	showdate = (typeof showdate !== "undefined" ? showdate : false);
	ishrform = (typeof ishrform !== "undefined" ? ishrform : false)

	var self = this;
	this.currentitemid = ko.observable(itemId);
	this.currenttaskid = ko.observable(taskid);
	this.listTasksTitle = LRListManagement.Lists.LeaveRequestWorkflowTask.Title;
	this.listFormTitle = LRListManagement.Lists.LeaveRequestItem.Title;
	this.dateformate = ko.dateformat.normal;
	this.isHR = ko.observable(parent.isHr());
	this.isManager = ko.observable(parent.isManager());
	this.ishrForm = ko.observable(ishrform);
	this.backtoform = ko.observable(backtoform);
	this.isviewOnly = ko.observable(isviewonly);
	this.isOwner = ko.observable((backtoform === 'idhomepage' || backtoform === 'idmyhistory'));

	this.BackToText = ko.observable(isviewonly ? "Close" : "Cancel");

	this.isshowdate = ko.observable(showdate);

	this.currentOfficerQuota = ko.observable();
	this.currentOfficerQuotaID = ko.observable(0);

	this.runningno = ko.observable();
	this.title = ko.observable();
	this.mymanagerName = ko.observable();
	this.leavetype = ko.observable();
	this.leavecode = ko.observable();
	this.otherleavetype = ko.observable(null);
	this.fromdate = ko.observable();
	this.fromdatetype = ko.observable();
	this.todatevisible = ko.observable(false);
	this.todate = ko.observable();
	this.todatetype = ko.observable();
	this.totalday = ko.observable();
	//this.phonenumber = ko.observable();
	this.reason = ko.observable();
	this.leavedays = ko.observableArray([]);
	this.requesterId = ko.observable();
	this.taskreason = ko.observable();
	this.leavestatus = ko.observable();
	this.leavestatusclass = ko.computed(function () {
		var csslscolor = "color-yellow";
		//var cssclscolor ="color-yellow";
		var ls = self.leavestatus();
		if (ls === "Approved") {
			csslscolor = "color-green";
		}
		else if (ls === "Rejected" || ls === "Cancelled") {
			csslscolor = "color-red";

		}
		return csslscolor;
	}, this);
	this.leavetotalremain = ko.observable(0);
	this.cancelleavestatus = ko.observable();
	this.cancelworkflow = ko.observable();
	this.istaskgenerate = ko.observable(false);
	this.isgraterthentoday = ko.observable(true);
	this.singleLeaveremail = ko.computed(function () {
		return ko.utils.arrayFilter(self.leavedays(), function (d) {
			return d.Title === self.leavetype()
		});

	}, this);
	this.calulateDay = function (data) {
		//console.log(data);
		var maxd = parseFloat(data.MaxLeaveValue.toString(), 10);
		var inprod = parseFloat(data.MyUseDay.inprogress.toString(), 10);
		var appd = parseFloat(data.MyUseDay.approve.toString(), 10);
		return maxd - appd;
	}
	this.SaveTasksClick = function (type, data) {
		LRGlobalFunc.swalalrt({
			title: String.format(gswalText().taskapprove.confirmsave, type),
			//text: "To save data!",
			type: 'warning',
			showCancelButton: true,
		}, function () {
			ko.contentDialog.show();
			var approvestatus = (type === "Approve" ? type + "d" : type + "ed");
			//console.log(approvestatus );
			var setfieldata = [
				{
					Title: "TaskReason",
					Value: self.taskreason()
				},
				{
					Title: "PercentComplete",
					Value: 1
				},
				{
					Title: "Status",
					Value: 'Completed'
				},
				{
					Title: "TaskOutcome",
					Value: approvestatus
				}
			];
			var optioninside = {
				listTitle: self.listTasksTitle,
				data: setfieldata,
				itemid: self.currenttaskid()
			}
			LRGlobalFunc.SaveDatatoList(optioninside).then(function (id) {
				if (type === "Approve") {
					ko.utils.arrayForEach(self.currentOfficerQuota(), function (lr) {
						if (lr.code === self.leavecode()) {
							var inttotal = parseFloat(lr.total, 10);
							var intleavetotal = parseFloat(self.totalday(), 10);
							var diff = inttotal - intleavetotal;
							lr.total = diff.toString();
						}
					});
					
					LRServices.UpdateOfficerQuota(self.currentOfficerQuota(),self.currentOfficerQuotaID()).then(function () {
						LRGlobalFunc.swalalrt({
							title: String.format(gswalText().taskapprove.tasksuccess, type),
							type: 'success'
						}, null, function () {
							ko.contentDialog.hide();
							parent.navLinkClick(self.backtoform());
						});
					}, LRServices.errorshowaler);
				}
				else {
					LRGlobalFunc.swalalrt({
						title: String.format(gswalText().taskapprove.tasksuccess, type),
						type: 'success'
					}, null, function () {
						ko.contentDialog.hide();
						parent.navLinkClick(self.backtoform());
					});
				}
			}, LRServices.errorshowaler);
		});
	}
	this.CancelClick = function (data) {
		LRGlobalFunc.swalalrt({
			title: gswalText().taskapprove.confirmcancel,
			//text: "To save data!",
			type: 'warning',
			showCancelButton: true,
		}, function () {
			ko.contentDialog.show();
					var setfieldata = [
						{
							Title: LRListManagement.Lists.LeaveRequestItem.Fields.CancelWorkflow.Internal,
							Value: "true"
						}
					];
					var optioninside = {
						listTitle: self.listFormTitle,
						data: setfieldata,
						itemid: self.currentitemid()
					}
			LRGlobalFunc.SaveDatatoList(optioninside).then(function () {
				LRGlobalFunc.swalalrt({
					title: gswalText().taskapprove.taskcancelsuccess,
					type: 'success'
				}, null, function () {
					ko.contentDialog.hide();
					parent.navLinkClick(self.backtoform());
				});
			}, LRServices.errorshowaler);
		});
		/*swal({
			title: "Are you sure to cancel?",
			// text: "To create Lists!",
			icon: "warning",
			buttons: true,
			dangerMode: true,
		})
			.then((willDelete) => {
				if (willDelete) {
					// swal("Poof! Your imaginary file has been deleted!", {
					//  icon: "success",
					// });
					ko.contentDialog.show();
					var setfieldata = [
						{
							Title: "CancelWorkflow",
							Value: "true"
						}
					];
					var optioninside = {
						listTitle: self.listFormTitle,
						data: setfieldata,
						itemid: self.currentitemid()
					}


					// parent.navLinkClick("idapprove");
					ko.SaveDatatoList(optioninside, function (id) {
						//self.courseID (id);
						//self.saveImagefilesVideo(self.title(),id);
						swal("Cancel Success", {
							icon: "success",
						}).then(() => {
							ko.contentDialog.hide();
							parent.navLinkClick(self.backtoform());
						});
						//if(!self.ishrForm()){
						//	parent.navLinkClick(self.backtoform());
						//}
						//else{
						//	 parent.navLinkClick("idhrapprove");
						//}
					});
				}
			});*/
		/*
				var r = confirm("Are you sure to cancel?");
				if(r){
						var setfieldata = [
											{
												Title:"CancelWorkflow",
												Value: "true"
											}
							];
							var optioninside = {
								  listTitle:self.listFormTitle ,
								  data :setfieldata,
								  itemid :itemId
							}
						   // parent.navLinkClick("idapprove");
							ko.SaveDatatoList(optioninside ,function(id){   
		
								alert("Save Success");
								parent.navLinkClick(self.backtoform());
		
								//ToraAsiaLeaveRequestInfo.Services.deleteCancelRequestTask(id).then(function(e){
								//	alert("Save Success");
								//    parent.navLinkClick(self.backtoform());
				
								//},function(e){
								//	console.log(e);
								//})
		
		
							});
		
		
				}
			*/
	}
	this.ReqquestCancelClick = function (data) {
		LRGlobalFunc.swalalrt({
			title: gswalText().taskapprove.confirmreqcancel,
			//text: "To save data!",
			type: 'warning',
			showCancelButton: true,
		}, function () {
			ko.contentDialog.show();
			var addfieldata = [
				{
					Title: "RequestType",
					Value: "2"
				},
				{
					Title: "LeaveStatus",
					Value: "In Progress"
				}
			];
			var optioninside = {
				listTitle: self.listFormTitle,
				data: addfieldata,
				itemid: self.currentitemid()
			}
			LRGlobalFunc.SaveDatatoList(optioninside).then(function () {
				LRGlobalFunc.swalalrt({
					title: gswalText().taskapprove.taskreqcancelsuccess,
					type: 'success'
				}, null, function () {
					ko.contentDialog.hide();
					parent.navLinkClick(self.backtoform());
				});
			}, LRServices.errorshowaler);
		});
		/*swal({
			title: "Are you sure to Request Cancel?",
			// text: "To create Lists!",
			icon: "warning",
			buttons: true,
			dangerMode: true,
		})
			.then((willDelete) => {
				if (willDelete) {
					// swal("Poof! Your imaginary file has been deleted!", {
					//  icon: "success",
					// });
					ko.contentDialog.show();
					var addfieldata = [
						{
							Title: "RequestType",
							Value: "2"
						},
						{
							Title: "CancelLeaveStatus",
							Value: "In Progress"
						}
					];
					var optioninside = {
						listTitle: self.listFormTitle,
						data: addfieldata,
						itemid: self.currentitemid()
					}


					// parent.navLinkClick("idapprove");
					ko.SaveDatatoList(optioninside, function (id) {
						//self.courseID (id);
						//self.saveImagefilesVideo(self.title(),id);
						swal("Request Cancel Success", {
							icon: "success",
						}).then(() => {
							ko.contentDialog.hide();
							parent.navLinkClick(self.backtoform());
						});
						//if(!self.ishrForm()){
						//	parent.navLinkClick(self.backtoform());
						//}
						//else{
						//	 parent.navLinkClick("idhrapprove");
						//}
					});
				}
			});*/
		/*
				var r = confirm("Are you sure to Request Cancel?");
				if(r){
					//console.log(self.errors().length);
					var addfieldata = [
								{
									Title:"RequestType",
									Value: "Cancel"
								},
								{
									Title:"CancelLeaveStatus",
									Value: "In Progress"
								}														
							];
							var optioninside = {
										listTitle:self.listFormTitle ,
										data :addfieldata,
										itemid :itemId
							}
							ko.SaveDatatoList(optioninside ,function(id){   
									alert("Request Cancel Success");
									parent.navLinkClick(self.backtoform());
							});
				}
		
		*/

	}

	this.queryLeaveForm = function (callback) {
		var leavedataarr = ko.observableArray([]);
		var props = {};
		props.listtitle = self.listFormTitle;
		props.options = {
			fileData: [
				{ field: LRListManagement.Lists.LeaveRequestItem.Fields.ID.Internal },
				{
					field: LRListManagement.Lists.LeaveRequestItem.Fields.Title.Internal, type: "Default",
					typefield: LRListManagement.Lists.LeaveRequestItem.Fields.Title.Internal
				},
				{ field: LRListManagement.Lists.LeaveRequestItem.Fields.LeaveType.Internal },
				{ field: LRListManagement.Lists.LeaveRequestItem.Fields.StartDate.Internal, type: "Date", format: self.dateformate },
				{ field: LRListManagement.Lists.LeaveRequestItem.Fields.LeaveTime.Internal },
				{ field: LRListManagement.Lists.LeaveRequestItem.Fields.EndDate.Internal, type: "Date", format: self.dateformate },
				{ field: LRListManagement.Lists.LeaveRequestItem.Fields.LeaveDayTotal.Internal },
				{ field: LRListManagement.Lists.LeaveRequestItem.Fields.LeaveYear.Internal},
				{ field: LRListManagement.Lists.LeaveRequestItem.Fields.LeaveReason.Internal },
				{ field: LRListManagement.Lists.LeaveRequestItem.Fields.LeaveStatus.Internal },
				{ field: LRListManagement.Lists.LeaveRequestItem.Fields.OfficerApprover.Internal },
				{ field: LRListManagement.Lists.LeaveRequestItem.Fields.Requester.Internal },
				{ field: LRListManagement.Lists.LeaveRequestItem.Fields.CancelWorkflow.Internal }
			],
			format: ko.dateformat.nomal
		}
		var allquery = [];
		//var queryBegin = [];
		allquery.push(String.format(ko.defaultquery, "Eq", LRListManagement.Lists.LeaveRequestItem.Fields.ID.Internal, "Number", self.currentitemid(), "", ""));
		if (allquery.length > 0) {
			props.query = "<Where>" + ko.MergeCAMLConditions(allquery, ko.MergeType.And) + "</Where>";
		}
		LRGlobalFunc.queryDataJSOM(leavedataarr, props, function () {
			//deferred.resolve(configdataarr().length > 0);
			//console.log(leavedataarr());
			if (leavedataarr().length > 0) {
				var dataitem = leavedataarr()[0];
				self.runningno(dataitem[LRListManagement.Lists.LeaveRequestItem.Fields.Title.Internal]);
				//var requesterid = 0;
				if(dataitem.Requester != null){
					//console.log(dataitem.Requester);
					self.title(dataitem[LRListManagement.Lists.LeaveRequestItem.Fields.Requester.Internal].get_lookupValue());
					self.requesterId(dataitem[LRListManagement.Lists.LeaveRequestItem.Fields.Requester.Internal].get_lookupId());
				}
				self.leavecode(dataitem[LRListManagement.Lists.LeaveRequestItem.Fields.LeaveType.Internal ]);
				//self.leavetype();
				//self.otherleavetype(dataitem.OtherLeaveType);
				self.fromdate(dataitem[LRListManagement.Lists.LeaveRequestItem.Fields.StartDate.Internal]);
				//self.fromdatetype(dataitem.LeaveTime);
				
				var a = moment(dataitem[LRListManagement.Lists.LeaveRequestItem.Fields.StartDate.Internal]);
				var b = moment(moment().format(self.dateformate));
				var adifb = a.diff(b, 'days');
				//console.log(adifb );
				self.isgraterthentoday(adifb < 1);
				if (dataitem[LRListManagement.Lists.LeaveRequestItem.Fields.EndDate.Internal] !== null) {
					var yearmoment = moment(dataitem[LRListManagement.Lists.LeaveRequestItem.Fields.EndDate.Internal]).format("YYYY");
					if (yearmoment !== null && typeof yearmoment !== "undefined") {
						var yearmomentint = parseInt(yearmoment, 10);
						if (yearmomentint > 1999) {
							self.todate(dataitem[LRListManagement.Lists.LeaveRequestItem.Fields.EndDate.Internal]);
							self.todatevisible(true);
						}
					}
				}
				if (dataitem[LRListManagement.Lists.LeaveRequestItem.Fields.OfficerApprover.Internal] !== null) {
					self.mymanagerName(dataitem[LRListManagement.Lists.LeaveRequestItem.Fields.OfficerApprover.Internal].get_lookupValue());
				}
				//if(dataitem.EndTime !== null){
				//self.todatevisible(true);
				//self.todate(dataitem.EndDate);
				//self.todatetype (dataitem.EndTime);	
				//}
				self.totalday(dataitem[LRListManagement.Lists.LeaveRequestItem.Fields.LeaveDayTotal.Internal]);
				//self.phonenumber(dataitem.PhoneNumber);
				self.reason(dataitem[LRListManagement.Lists.LeaveRequestItem.Fields.LeaveReason.Internal ]);
				//if (dataitem.Requester !== null) {
				//	self.requesterId(dataitem.Requester.get_lookupId());
				//}
				self.leavestatus(dataitem[LRListManagement.Lists.LeaveRequestItem.Fields.LeaveStatus.Internal]);

				self.cancelworkflow(dataitem[LRListManagement.Lists.LeaveRequestItem.Fields.CancelWorkflow.Internal]);
				//Check Quota
				//LRServices.Variables.OfficerQuota
				//leavetotalremain
				//var filterleavebytype =  ko.utils.arrayFilter(self.products(), function(l) {
				//	return l.code == self.leavetype;
				//});
				
				var filterltime = ko.utils.arrayFilter(LRServices.Variables.LeaveTime, function (litme) {
					return dataitem[LRListManagement.Lists.LeaveRequestItem.Fields.LeaveTime.Internal] == litme.value;
				});
				if (filterltime.length > 0) {
					self.fromdatetype(filterltime[0].title);
				}

				new LRServices.GetOfficerQuotaByYear(dataitem[LRListManagement.Lists.LeaveRequestItem.Fields.LeaveYear.Internal],self.requesterId()).then(function (d_quota) {
					if (d_quota.length > 0 ) {
						try {
							var d_quota_json = JSON.parse(d_quota[0][LRListManagement.Lists.LeaveRequestQuota.Fields.Quota.Internal]);
							self.currentOfficerQuota(d_quota_json);
							self.currentOfficerQuotaID(d_quota[0][LRListManagement.Lists.LeaveRequestQuota.Fields.ID.Internal]);
							
						} catch (ex) {
			
						}
						ko.utils.arrayForEach(self.currentOfficerQuota(), function (lr) {
							if (lr.code === dataitem.LeaveType) {
								self.leavetotalremain(parseFloat(lr.total, 10));
		
								var filterlcon = ko.utils.arrayFilter(LRServices.Variables.LeaveConditions, function (lcon) {
									return lr.code == lcon[LRListManagement.Lists.LeaveRequestCondition.Fields.LeaveCode.Internal];
								});
								if (filterlcon.length > 0) {
									self.leavetype(filterlcon[0][LRListManagement.Lists.LeaveRequestCondition.Fields.Title.Internal]);
								}
							}
						});
						callback();
					}
				});

				//console.log(self.leavetotalremain());
			}
			else{
				callback();
			}
		});
	}
	this.queryLeaveForm(function () {
		ko.contentDialog.hide();
	});

	LRServices.GetTaskByRequestId(self.currentitemid()).then(function (r) {
		self.istaskgenerate(r);
	});
}

