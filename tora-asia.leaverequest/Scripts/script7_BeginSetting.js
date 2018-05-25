function LRBeginSettingViewModel(parent){
	var self = this;
	this.obtionListName = ToraAsiaLeaveRequestInfo.ListManagement.Options.Title;
	this.isAllcreate = ko.observable(ToraAsiaLeaveRequestInfo.Services.IsAllListCreated());
	this.isFeatureActivate = ko.observable(ToraAsiaLeaveRequestInfo.Services.GetIsFeatureActivate());
	this.isfoundWorkflow = ko.observable(ToraAsiaLeaveRequestInfo.Services.GetIsFoundWorkflow ());
	this.isWorkflowMap = ko.observable(ToraAsiaLeaveRequestInfo.Services.GetIsWorkflowMapping());
	
	
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

		//console.log(curstep );
    	//if(self.createStep()){ return 1;}
    	//if(self.hasworkflowStep ()){ return 2;}
    	//if(self.mapWorkflowStep()){ return 3;}
    	//if(self.deleteStep()){ return 4;}
    	return curstep ;
    });
	this.CreateListClick = function(){
		swal({
		  title: "Are you sure to create Lists?",
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
		   		ToraAsiaLeaveRequestInfo.Services.GetListInfomation(true,function () {
		            //self.isAllcreate(true);
		            //console.log(self);
		            swal("Create List Success", {
						      icon: "success",
						    }).then(() => {
								ko.contentDialog.hide();
			            	    self.isAllcreate(ToraAsiaLeaveRequestInfo.Services.IsAllListCreated());
		            			parent.isBeginSetupSuccess(ToraAsiaLeaveRequestInfo.Services.isAppReady());


							});

		            //self.isAllcreate(ToraAsiaLeaveRequestInfo.Services.IsAllListCreated());
		            //parent.isBeginSetupSuccess(ToraAsiaLeaveRequestInfo.Services.isAppReady());
					//alert("Create List Success");
		        });

		  } 		
		 });

		/*var r = confirm("Are you sure to create Lists?");
		if(r){
			ToraAsiaLeaveRequestInfo.Services.GetListInfomation(true,function () {
	            //self.isAllcreate(true);
	            //console.log(self);
	            self.isAllcreate(ToraAsiaLeaveRequestInfo.Services.IsAllListCreated());
	            parent.isBeginSetupSuccess(ToraAsiaLeaveRequestInfo.Services.isAppReady());
				alert("Create List Success");
	        });
        }*/
	}
	this.ActivateFeatureClick = function(){
		swal({
		  title:"Are you sure to Activate Feature?",
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
		   		ToraAsiaLeaveRequestInfo.Services.ActivateFeature().then(function(){
					            	//UpdateSetupID
							var setfieldata = [
											{
												Title:"Title",
												Value: "ActivateFeature",
											},	
											{
												Title:"Details",
												Value: "true"
											}							
										];
							var optioninside = {
							            listTitle:self.obtionListName,
							            data :setfieldata,
										itemid :ToraAsiaLeaveRequestInfo.Services.ActivateFeatureID
						    }
						   // parent.navLinkClick("idapprove");
						    ko.SaveDatatoList(optioninside ,function(id){   
						    
						    	swal("Activate Feature Success", {
							      icon: "success",
							    }).then(() => {
									ko.contentDialog.hide();
				            	    ToraAsiaLeaveRequestInfo.Services.ActivateFeatureID = id;
									self.isFeatureActivate(ToraAsiaLeaveRequestInfo.Services.GetIsFeatureActivate());
									parent.isBeginSetupSuccess(ToraAsiaLeaveRequestInfo.Services.isAppReady());
								});		
							});
					},
					function(merr){
						//console.log(merr);
						swal(merr, {
						      icon: "error",
						    }).then(() => {
									ko.contentDialog.hide();							
				           });

					});

		  } 		
		 });

		/*var r = confirm("Are you sure to Activate Feature?");
		if(r){
			ToraAsiaLeaveRequestInfo.Services.ActivateFeature().then(function(){
					            	//UpdateSetupID
					var setfieldata = [
									{
										Title:"Title",
										Value: "ActivateFeature",
									},	
									{
										Title:"Details",
										Value: "true"
									}							
								];
					var optioninside = {
					            listTitle:self.obtionListName,
					            data :setfieldata,
								itemid :ToraAsiaLeaveRequestInfo.Services.ActivateFeatureID
				    }
				   // parent.navLinkClick("idapprove");
				    ko.SaveDatatoList(optioninside ,function(id){   
				    	ToraAsiaLeaveRequestInfo.Services.ActivateFeatureID = id;
						self.isFeatureActivate(ToraAsiaLeaveRequestInfo.Services.GetIsFeatureActivate());
						parent.isBeginSetupSuccess(ToraAsiaLeaveRequestInfo.Services.isAppReady());
		
						alert("Activate Feature Success");

					});
			},
			function(merr){
				console.log(merr);
			});

		}*/
	}

	this.CloneWorkflowClick = function(){
		swal({
		  title:"Are you sure to update/clone Workflow?",
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
		   		ToraAsiaLeaveRequestInfo.Services.CloneWorkflow().then(function(){
					        var setfieldata = [
									{
										Title:"Title",
										Value: "FoundWorkflow",
									},	
									{
										Title:"Details",
										Value: "true"
									}							
								];
							var optioninside = {
							            listTitle:self.obtionListName,
							            data :setfieldata,
										itemid :ToraAsiaLeaveRequestInfo.Services.FoundWorkflowID
						    }
						   // parent.navLinkClick("idapprove");
						    ko.SaveDatatoList(optioninside ,function(id){   
								swal("Clone/Update Workflow Success", {
							      icon: "success",
							    }).then(() => {
									ko.contentDialog.hide();
				            	    ToraAsiaLeaveRequestInfo.Services.FoundWorkflowID = id;
									self.isfoundWorkflow (ToraAsiaLeaveRequestInfo.Services.GetIsFoundWorkflow ());
									parent.isBeginSetupSuccess(ToraAsiaLeaveRequestInfo.Services.isAppReady());
								});	
		
							});
					},
					function(merr){
						//console.log(merr);
						swal(merr, {
						      icon: "error",
						    }).then(() => {
									ko.contentDialog.hide();							
				           });

					});

		  } 		
		 });
/*
		var r = confirm("Are you sure to update/clone Workflow?");
		if(r){
			ToraAsiaLeaveRequestInfo.Services.CloneWorkflow().then(function(){
					            	//UpdateSetupID
					var setfieldata = [
									{
										Title:"Title",
										Value: "FoundWorkflow",
									},	
									{
										Title:"Details",
										Value: "true"
									}							
								];
					var optioninside = {
					            listTitle:self.obtionListName,
					            data :setfieldata,
								itemid :ToraAsiaLeaveRequestInfo.Services.FoundWorkflowID
				    }
				   // parent.navLinkClick("idapprove");
				    ko.SaveDatatoList(optioninside ,function(id){   
				    	ToraAsiaLeaveRequestInfo.Services.FoundWorkflowID = id;
						self.isfoundWorkflow (ToraAsiaLeaveRequestInfo.Services.GetIsFoundWorkflow ());
						parent.isBeginSetupSuccess(ToraAsiaLeaveRequestInfo.Services.isAppReady());
		
						alert("Clone/Update Workflow Success");

					});
			},
			function(merr){
				console.log(merr);
			});

		}*/
	}

	this.MappingWorkflowClick = function(){
		swal({
		  title:"Are you sure to mapping Workflow?",
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
		   		ToraAsiaLeaveRequestInfo.Services.AddWorkflowdefinitiontoList().then(function(){
					        var setfieldata = [
									{
										Title:"Title",
										Value: "WorkflowMaping",
									},	
									{
										Title:"Details",
										Value: "true"
									}							
								];
								var optioninside = {
								            listTitle:self.obtionListName,
								            data :setfieldata,
											itemid :ToraAsiaLeaveRequestInfo.Services.WorkflowMapingID
							    }
						   // parent.navLinkClick("idapprove");
						    ko.SaveDatatoList(optioninside ,function(id){   
								swal("Add workflow to List Success", {
							      icon: "success",
							    }).then(() => {
									ko.contentDialog.hide();
				            	    ToraAsiaLeaveRequestInfo.Services.WorkflowMapingID = id;
									self.isWorkflowMap(ToraAsiaLeaveRequestInfo.Services.GetIsWorkflowMapping());
									parent.isBeginSetupSuccess(ToraAsiaLeaveRequestInfo.Services.isAppReady());
								});	
		
							});
					},
					function(merr){
						//console.log(merr);
						swal(merr, {
						      icon: "error",
						    }).then(() => {
									ko.contentDialog.hide();							
				           });

					});

		  } 		
		 });

		/*var r = confirm("Are you sure to mapping Workflow?");
		if(r){
			ToraAsiaLeaveRequestInfo.Services.AddWorkflowdefinitiontoList().then(function(){
			
				var setfieldata = [
									{
										Title:"Title",
										Value: "WorkflowMaping",
									},	
									{
										Title:"Details",
										Value: "true"
									}							
								];
					var optioninside = {
					            listTitle:self.obtionListName,
					            data :setfieldata,
								itemid :ToraAsiaLeaveRequestInfo.Services.WorkflowMapingID
				    }
				   // parent.navLinkClick("idapprove");
				    ko.SaveDatatoList(optioninside ,function(id){   
							ToraAsiaLeaveRequestInfo.Services.WorkflowMapingID = id;
							self.isWorkflowMap(ToraAsiaLeaveRequestInfo.Services.GetIsWorkflowMapping());
							parent.isBeginSetupSuccess(ToraAsiaLeaveRequestInfo.Services.isAppReady());
			
							alert("Add workflow to List Success");	

					});
			},
			function(merr){
				console.log(merr);
			});
		}*/
	}
	this.DeleteListClick = function(){
		swal({
		  title:"Are you sure to delete Lists?",
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
		   		ToraAsiaLeaveRequestInfo.Services.deleteAllList().then(function(m){
					       swal(m, {
							      icon: "success",
							    }).then(() => {
									ko.contentDialog.hide();
				            	    window.location.href = window.location.href;								
				           });	
					},
					function(merr){
						//console.log(merr);
						swal(merr, {
						      icon: "error",
						    }).then(() => {
									ko.contentDialog.hide();							
				           });
					});

		  } 		
		 });

		/*var r = confirm("Are you sure to delete Lists?");
		if(r){
			//alert("Delete");
			ToraAsiaLeaveRequestInfo.Services.deleteAllList().then(function(m){
					alert(m);
					window.location.href = window.location.href;
			},function(em){
				alert(em);
			});
        }*/
	}



}
