function WorkingDaysCheck(name, checked)
{
  var self = this;
  
  self.Name = ko.observable(name || "Unnamed");
  self.IsChecked = ko.observable(checked || false);
}
function LRSettingViewModel(parent){
	var self = this;
	this.listoptions = ToraAsiaLeaveRequestInfo.ListManagement.Options.Title;
	this.dateformate = "DD MMMM";
	this.oldcircledate = ko.observable(ToraAsiaLeaveRequestInfo.Services.EndCircleDate);
	this.circledate = ko.observable(ToraAsiaLeaveRequestInfo.Services.EndCircleDate);
	this.circleEnable = ko.observable(false);
	this.NavLinkArr = ko.observableArray([
    	{title:"เพิ่ม แก้ไข ลบ ประเภทการลา",url:ToraAsiaLeaveRequestInfo.ListManagement.LeaveMaxDate.Url,icon:"glyphicon-list-alt"},
    	{title:"เพิ่ม แก้ไข ลบ ข้อมูลพนักงาน",url:ToraAsiaLeaveRequestInfo.ListManagement.Officer.Url,icon:"glyphicon-user"},
    	//{title:"เพิ่ม แก้ไข ลบ ข้อมูลผู้ดูแลระบบและฝ่ายบุคคล",url:ToraAsiaLeaveRequestInfo.ListManagement.AdminHr.Url,icon:"glyphicon-asterisk"},
    	{title:"พื้นที่จัดเก็บการลา",url:ToraAsiaLeaveRequestInfo.ListManagement.RequestForm.Url,icon:"glyphicon-hdd"},
    	{title:"จัดการวันหยุด",url:ToraAsiaLeaveRequestInfo.ListManagement.Holidays.Url,icon:"glyphicon-time"},
    ]);
    
   
    this.workingEnable = ko.observable(false);
    this.allday= ko.observableArray(["Sunday","Monday","Tuesday","Wednesday","Thursday","Friday","Saturday"]);
	
	var workingDays = ToraAsiaLeaveRequestInfo.Services.WorkingDays ;
    this.oldworkingDays = ko.observableArray(workingDays.slice()); 
    this.workingDays= ko.observableArray(workingDays.slice()); 
      
    this.enableEdit = function(){ self.circleEnable(true);}
    this.saveNewDate = function(){
    	swal({
		  title:"Are you sure to Save Date?",
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
					var cirid = parseInt(ToraAsiaLeaveRequestInfo.Services.EndCircleID.toString(),10);
    				var addfieldata = [
									{
										Title:"Details",
										Value: self.circledate().format(ko.dateformat.endcircletoList)
									}								
								];
					if(cirid === 0 ){
						addfieldata.push({
										Title:"Title",
										Value: "EndCircleYear"
									})
					}
					var optioninside = {
					            listTitle:self.listoptions,
					            data :addfieldata,
								itemid :cirid 
				    }
			   
		   			// parent.navLinkClick("idapprove");
				    ko.SaveDatatoList(optioninside ,function(id){   
				    		//self.courseID (id);
			            	//self.saveImagefilesVideo(self.title(),id);
			            	ToraAsiaLeaveRequestInfo.Services.GetEndCircleData().then(function(){
			            		swal("Save Success", {
								      icon: "success",
								    }).then(() => {
										ko.contentDialog.hide();
					            	    self.oldcircledate(self.circledate());
					            		self.circleEnable(false);
					            		//console.log(ToraAsiaLeaveRequestInfo.Services.GetIsSetEndCircle());
					            		parent.isFoundEndCircle (ToraAsiaLeaveRequestInfo.Services.GetIsSetEndCircle());
			
					           });	

			            		//self.oldcircledate(self.circledate());
			            		//self.circleEnable(false);
			            		//console.log(ToraAsiaLeaveRequestInfo.Services.GetIsSetEndCircle());
			            		//parent.isFoundEndCircle (ToraAsiaLeaveRequestInfo.Services.GetIsSetEndCircle());

			            		//alert("Save Success");
							});
			            	//if(!self.ishrForm()){
			            	//	parent.navLinkClick(self.backtoform());
			            	//}
			            	//else{
			            	//	 parent.navLinkClick("idhrapprove");
			            	//}
					});

		  } 		
		 });
/*
    	var r = confirm("Are you sure to Save Date?");
    	if(r){
    			var cirid = parseInt(ToraAsiaLeaveRequestInfo.Services.EndCircleID.toString(),10);
    				var addfieldata = [
									{
										Title:"Details",
										Value: self.circledate().format(ko.dateformat.endcircletoList)
									}								
								];
					if(cirid === 0 ){
						addfieldata.push({
										Title:"Title",
										Value: "EndCircleYear"
									})
					}
					var optioninside = {
					            listTitle:self.listoptions,
					            data :addfieldata,
								itemid :cirid 
				    }
				    ko.SaveDatatoList(optioninside ,function(id){   
				    		//self.courseID (id);
			            	//self.saveImagefilesVideo(self.title(),id);
			            	//alert("Save Success");
			            	//parent.navLinkClick("idhomepage");
			            	ToraAsiaLeaveRequestInfo.Services.GetEndCircleData().then(function(){
			            		self.oldcircledate(self.circledate());
			            		self.circleEnable(false);
			            		//console.log(ToraAsiaLeaveRequestInfo.Services.GetIsSetEndCircle());
			            		parent.isFoundEndCircle (ToraAsiaLeaveRequestInfo.Services.GetIsSetEndCircle());

			            		alert("Save Success");
							});

					})

    	
    	}*/
    }
    this.disableEdit = function(){ 
    	self.circledate(self.oldcircledate());
    	self.circleEnable(false);
    }
    
    this.workingCheckEvent = function(){ return true;}
    this.enableWorkingEdit = function(){ self.workingEnable(true);}
    this.saveNewWorkingDate = function(){
    	swal({
		  title:"Are you sure to Save Date?",
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
					var cirid = parseInt(ToraAsiaLeaveRequestInfo.Services.WorkingDaysID.toString(),10);
    				var addfieldata = [
									{
										Title:"Details",
										Value: self.workingDays().join(',')
									}								
								];
					if(cirid === 0 ){
						addfieldata.push({
										Title:"Title",
										Value: "WorkingDays"
									})
					}
					var optioninside = {
					            listTitle:self.listoptions,
					            data :addfieldata,
								itemid :cirid 
				    }
			   
		   			// parent.navLinkClick("idapprove");
				    ko.SaveDatatoList(optioninside ,function(id){   
				    		//self.courseID (id);
			            	//self.saveImagefilesVideo(self.title(),id);
			            	ToraAsiaLeaveRequestInfo.Services.WorkingDaysID = id;
			            	ToraAsiaLeaveRequestInfo.Services.WorkingDays =  self.workingDays().slice();
			            	swal("Save Success", {
								      icon: "success",
								    }).then(() => {
										ko.contentDialog.hide();
					            	    self.oldworkingDays(self.workingDays().slice());
					            		self.workingEnable(false);
					            		//console.log(ToraAsiaLeaveRequestInfo.Services.GetIsSetEndCircle());
					            		//parent.isFoundEndCircle (ToraAsiaLeaveRequestInfo.Services.GetIsSetEndCircle());
			
					        });	
					});

		  } 		
		 });
    }
    this.disableWorkingEdit = function(){ 
    	//console.log(self.workingDaysChecked());
    	//console.log(self.oldworkingDays().join(','));
    	//console.log(self.workingDays().join(','));
    	self.workingDays(self.oldworkingDays().slice());
    	self.workingEnable(false);
    }
    
    this.worktypeEnable = ko.observable(false);
	this.worktypearr=["ปัดเศษทิ้ง","คำนวณตามสัดส่วน"];
	this.oldworktype = ko.observable(ToraAsiaLeaveRequestInfo.Services.WorkType);
	this.worktype = ko.observable(ToraAsiaLeaveRequestInfo.Services.WorkType);
	
	//this.worktypeEventEdit = function(){ return true;}
    this.enableWorktype = function(){ self.worktypeEnable(true);}
    
    this.saveNewWorktype = function(){
    	swal({
		  title:"Are you sure to Save Date?",
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
					var cirid = parseInt(ToraAsiaLeaveRequestInfo.Services.WorkTypeID.toString(),10);
    				var addfieldata = [
									{
										Title:"Details",
										Value: self.worktype()
									}								
								];
					if(cirid === 0 ){
						addfieldata.push({
										Title:"Title",
										Value: "WorkType"
									})
					}
					var optioninside = {
					            listTitle:self.listoptions,
					            data :addfieldata,
								itemid :cirid 
				    }
			   
		   			// parent.navLinkClick("idapprove");
				    ko.SaveDatatoList(optioninside ,function(id){   
				    		//self.courseID (id);
			            	//self.saveImagefilesVideo(self.title(),id);
			            	ToraAsiaLeaveRequestInfo.Services.WorkTypeID= id;
			            	ToraAsiaLeaveRequestInfo.Services.WorkType=  self.worktype();
			            	swal("Save Success", {
								      icon: "success",
								    }).then(() => {
										ko.contentDialog.hide();
					            	    self.oldworktype(self.worktype());
					            		self.worktypeEnable(false);
					            		//console.log(ToraAsiaLeaveRequestInfo.Services.GetIsSetEndCircle());
					            		//parent.isFoundEndCircle (ToraAsiaLeaveRequestInfo.Services.GetIsSetEndCircle());
			
					        });	
					});

		  } 		
		 });
    }
    this.disableWorktype = function(){ 
    	//console.log(self.workingDaysChecked());
    	//console.log(self.oldworkingDays().join(','));
    	//console.log(self.workingDays().join(','));
    	self.worktype(self.oldworktype());
    	self.worktypeEnable(false);
    }

}
