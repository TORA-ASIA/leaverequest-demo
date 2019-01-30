var LRListManagement = LRListManagement || {};
(function () {
    "use strict";
    LRListManagement.AddNameSpace = function (namespace) {
        ///<summary>
        /// Define New Namespance or class into the root namespace.
        ///</summary>
        /// <param name="namespace" type="String">Name of the new namespace.</param>
        /// <returns type="Object">Parent namespace</returns>
        var nsparts = namespace.split("."), parent = LRListManagement, i = 0, partname;

        // we want to be able to include or exclude the root namespace so we strip
        // it if it's in the namespace
        if (nsparts[0] === "LRListManagement") {
            nsparts = nsparts.slice(1);
        }

        // loop through the parts and create a nested namespace if necessary
        for (i = 0; i < nsparts.length; i++) {
            partname = nsparts[i];
            // check if the current parent already has the namespace declared
            // if it isn't, then create it
            if (!parent[partname]) {
                parent[partname] = {};
            }
            // get a reference to the deepest element in the hierarchy so far
            parent = parent[partname];
        }
        // the parent is now constructed with empty namespaces and can be used.
        // we return the outermost namespace
        return parent;
    };
    LRListManagement.AddNameSpace("Lists");
    LRListManagement.Lists = {
        //เก็บข้อมูลพนักงานภายใน
        LeaveRequestOfficer: {
            Title: "Leave Request Officer",
            Internal: "LeaveRequestOfficer",
            ID: null,
            Url: null,
            Fields: {
                ID: { Name: "ID", Internal: "ID"},
                Title: { Name: "Title", Internal: "Title"},
                Officer: { Name: "Officer", Internal: "Officer"},
                Gender: { Name: "Gender", Internal: "OfficerGender"},
                Position: { Name: "Position", Internal: "OfficerPosition"},
                Department: { Name: "Department", Internal: "OfficerDepartment"},
				Role: { Name: "Role", Internal: "OfficerRole"},
                StartWorking: { Name: "StartWorking", Internal: "OfficerStartWorking"},
                Approver: { Name: "Approver", Internal: "OfficerApprover"}
            }
        },
        //เก็บข้อมูลวันหยุด
        LeaveRequestHoliday: {
            Title: "Leave Request Holiday",
            Internal: "LeaveRequestHoliday",
            ID: null,
            Url: null,
            Fields: {
                ID: { Name: "ID", Internal: "ID"},
                Title: { Name: "Title", Internal: "Title"},
                HolidayDate: { Name: "Holiday Date", Internal: "HolidayDate"}
            }
        },
        //เก็บข้อมูลประเภทการลาและเงื่อนไขต่างๆ ในแต่ละประเภท
        LeaveRequestCondition: {
            Title: "Leave Request Condition",
            Internal: "LeaveRequestCondition",
            ID: null,
            Url: null,
            Fields: {
                ID: { Name: "ID", Internal: "ID"},
                Title: { Name: "Title", Internal: "Title"},
                LeaveCode: { Name: "Leave Code", Internal: "LeaveCode"},
                ConditionGender: { Name: "Gender", Internal: "ConditionGender"},
                ShowHide: { Name: "Show/Hide", Internal: "ShowHide"},
                ConditionEmployeeRights: { Name: "Max Leave Value", Internal: "ConditionEmployeeRights"},
                ConditionDate: { Name: "Condition Date", Internal: "ConditionDate"},
            }
        },
        //เก็บข้อมูล Configuration ของ Leave Request
        LeaveRequestConfiguration: {
            Title: "Leave Request Configuration",
            Internal: "LeaveRequestConfiguration",
            ID: null,
            Url: null,
            Fields: {
                ID: { Name: "ID", Internal: "ID"},
                Title: { Name: "Title", Internal: "Title"},
                Details: { Name: "Details", Internal: "Details"},
            }
        },
        //เก็บข้อมูลการลา
        LeaveRequestItem: {
            Title: "Leave Request Item",
            Internal: "LeaveRequestItem",
            ID: null,
            Url: null,
            Fields: {
                ID: { Name: "ID", Internal: "ID"},
                Title: { Name: "Title", Internal: "Title"},
                Requester: { Name: "Requester", Internal: "Requester"},
                LeaveType: { Name: "Leave Type", Internal: "LeaveType"},
                StartDate: { Name: "Start Date", Internal: "StartDate"},
                EndDate: { Name: "End Date", Internal: "EndDate"},
                LeaveTime: { Name: "Leave Time", Internal: "LeaveTime"},
                LeaveDayTotal: { Name: "Leave Day Total", Internal: "LeaveDayTotal"},
                LeaveYear: { Name: "Leave Year", Internal: "LeaveYear"},
                LeaveReason: { Name: "Reason", Internal: "LeaveReason"},
                LeaveStatus: { Name: "Leave Status", Internal: "LeaveStatus"},
                LeaveDictionary: { Name: "Leave Dictionary", Internal: "LeaveDictionary"},
                LeaveParentId: { Name: "Leave Parent Id", Internal: "LeaveParentId"},
                RequestType: { Name: "Request Type", Internal: "RequestType"},
                OfficerApprover: { Name: "Approver", Internal: "OfficerApprover"},
                OfficerHr: { Name: "HR", Internal: "OfficerHr"},
                CancelWorkflow: { Name: "Cancel Workflow", Internal: "CancelWorkflow"},
                IsActive: { Name: "Is Active", Internal: "IsActive"},
                CurrentUrl: { Name: "Current Url", Internal: "CurrentUrl"},
                CurrentHostUrl: { Name: "Current HostUrl", Internal: "CurrentHostUrl"},
				CurrentAppUrl: { Name: "Current AppUrl", Internal: "CurrentAppUrl"},
            }
        },
        //เก็บ Quota ของพนักงาน
        LeaveRequestQuota: {
            Title: "Leave Request Quota",
            Internal: "LeaveRequestQuota",
            ID: null,
            Url: null,
            Fields: {
                ID: { Name: "ID", Internal: "ID"},
                Title: { Name: "Title", Internal: "Title"},
                Officer: { Name: "Officer", Internal: "Officer"},
                QuotaYear: { Name: "Year", Internal: "QuotaYear"},
                Quota: { Name: "Quota", Internal: "Quota"},
            }
        },
        //เก็บ workflow historys
        LeaveRequestWorkflowHistory: {
            Title: "Leave Request Workflow History",
            Internal: "LeaveRequestWorkflowHistory",
            ID: null,
            Url: null,
            Fields: {
                ID: { Name: "ID", Internal: "ID"},
                Title: { Name: "Title", Internal: "Title"},
            }
        },
        //เก็บ workflow tasks
        LeaveRequestWorkflowTask: {
            Title: "Leave Request Workflow Task",
            Internal: "LeaveRequestWorkflowTask",
            ID: null,
            Url: null,
            Fields: {
                ID: { Name: "ID", Internal: "ID"},
                Title: { Name: "Title", Internal: "Title"},
                Status: { Name: "Status", Internal: "Status"},
                RelatedItems: { Name: "RelatedItems", Internal: "RelatedItems"},
                TaskReason: { Name: "Task Reason", Internal: "TaskReason"},
            }
        },
    };

    LRListManagement.AddNameSpace("Services");
    LRListManagement.Services = {
        FindListByTitle: function (ctx,web,_listitle) {
            // Create a new Deferred object
            var deferred = $.Deferred();
            // add list in host web  
            var list = web.get_lists().getByTitle(_listitle);
            var listRootFolder = list.get_rootFolder();
            ctx.load(list);
            ctx.load(listRootFolder);
            ctx.load(web);
            ctx.executeQueryAsync(function () {
                //alert("Sharepoint custom list is created Successfully..")
                var rootweb = web.get_url();//.replace(currentWEB.get_serverRelativeUrl(),"");
                var relatveweb = web.get_serverRelativeUrl();
                if (relatveweb !== "/") {
                    rootweb = rootweb.replace(relatveweb, "");
                }
                return deferred.resolve(list.get_id(), rootweb + listRootFolder.get_serverRelativeUrl());
            }, function (sender, args) {
                //console.log('Failed to create list. Error:' + args.get_message());
                return deferred.reject('Failed to get list. Error:' + args.get_message());
            });
            // Return the Deferred's Promise object
            return deferred.promise();
        },
        SetFieldToList : function (ctx, fieldColl, option, type) {
            option.title = option.f.Name || "";
            option.internalname = option.f.Internal || "";
            option.require = option.require || false;
            option.arraychoice = option.arraychoice || new Array();
            option.defaultvalue = option.defaultvalue || null;
            option.allowmutiple = option.allowmutiple || false;
            switch (type) {

                case "Text":
                    //Add Single line of text field to the Field Collection    
                    var singleTextField = fieldColl.addFieldAsXml('<Field Type="Text" DisplayName="' + option.internalname + '" Name="' + option.internalname + '" Required="' + option.require + '" />', true, SP.AddFieldOptions.addToDefaultContentType);
                    //singleTextField.set_description("This is a single line of text field");
                    singleTextField.set_title(option.title);
                    singleTextField.update();
                    //var f1 = ctx.castTo(fieldcoll.addFieldAsXml('<Field Type="Text" DisplayName="' + title + '" Name="' + internalname + '" />', true, SP.AddFieldOptions.addToDefaultContentType), SP.FieldText);
                    //console.log("About to set the field");
                    //  f1.set_title(title);
                    //f1.set_description("sample desc");
                    //console.log("About to update");
                    // f1.update();
                    break;
                case "PlainText":
                    //Add Plain Text field to the Field Collection    
                    var plainTextField = fieldColl.addFieldAsXml('<Field Type="Note" DisplayName="' + option.internalname + '" Name="' + option.internalname + '" Required="' + option.require + '" NumLines="30" RichText="FALSE" AppendOnly="TRUE" />', true, SP.AddFieldOptions.addToDefaultContentType);
                    // plainTextField.set_description("This is a Plain multi line field");
                    plainTextField.set_title(option.title);
                    plainTextField.update();
                    break;
                case "RichText":
                    //Add Rich Text field to the Field Collection    
                    var richTextField = fieldColl.addFieldAsXml('<Field Type="Note" DisplayName="' + option.internalname + '" Name="' + option.internalname + '" Required="' + option.require + '" NumLines="30" RichText="TRUE" AppendOnly="TRUE" />', true, SP.AddFieldOptions.addToDefaultContentType);
                    //richTextField.set_description("This is a Rich Text multi line field");
                    richTextField.set_title(option.title);
                    richTextField.update();
                    break;
                case "EnhancedText":
                    //Add Enhanced Text field to the Field Collection    
                    var enhancedTextField = fieldColl.addFieldAsXml('<Field Type="Note" DisplayName="' + option.internalname + '" Name="' + option.internalname + '" Required="' + option.require + '" NumLines="15" RestrictedMode="TRUE" RichText="TRUE" RichTextMode="FullHtml" AppendOnly="TRUE" />', true, SP.AddFieldOptions.addToDefaultContentType);
                    //enhancedTextField.set_description("This is an Enhanced multi line field");
                    enhancedTextField.set_title(option.title);
                    enhancedTextField.update();
                    break;
                case "Boolean":
                    //Add Boolean field to the Field Collection    
                    var booleanField = fieldColl.addFieldAsXml('<Field Type="Boolean" DisplayName="' + option.internalname + '" Name="' + option.internalname + '"><Default>0</Default></Field>', true, SP.AddFieldOptions.addToDefaultContentType);
                    //booleanField.set_description("This is a boolean field");
                    booleanField.set_title(option.title);
                    booleanField.update();
                    break;
                case "Image":
                    //Add Image Field to the field Collection     
                    var imageField = fieldColl.addFieldAsXml('<Field Type="URL" DisplayName="' + option.internalname + '" Name="' + option.internalname + '" Required="' + option.require + '" Format="Image" />', true, SP.AddFieldOptions.addToDefaultContentType);
                    //imageField.set_description("This is an image field");
                    imageField.set_title(option.title);
                    imageField.update();
                    break;
                case "URL":
                    //Add URL Field to the field Collection     
                    var hyperLinkField = fieldColl.addFieldAsXml('<Field Type="URL" DisplayName="' + option.internalname + '" Name="' + option.internalname + '" Required="' + option.require + '" Format="Hyperlink" />', true, SP.AddFieldOptions.addToDefaultContentType);
                    //hyperLinkField.set_description("This is a hyperlink field");
                    hyperLinkField.set_title(option.title);
                    hyperLinkField.update();
                    break;
                case "Number":
                    //Add Number field to the Field Collection    
                    var numberField = fieldColl.addFieldAsXml('<Field Type="Number" DisplayName="' + option.internalname + '" Name="' + option.internalname + '" Required="' + option.require + '" />', true, SP.AddFieldOptions.addToDefaultContentType);
                    //numberField.set_description("This is a number field");
                    numberField.set_title(option.title);
                    numberField.set_defaultValue(option.defaultvalue);
                    numberField.update();
                    break;
                case "Percentage":
                    //Add Percentage field to the Field Collection    
                    var percentageField = fieldColl.addFieldAsXml('<Field Type="Number" DisplayName="' + option.internalname + '" Name="' + option.internalname + '" Required="' + option.require + '" Percentage="TRUE" />', true, SP.AddFieldOptions.addToDefaultContentType);
                    //percentageField.set_description("This is a percentage field");
                    percentageField.set_title(option.title);
                    percentageField.update();
                    break;
                case "User":
                    //Add User Field to the collection    
                    var userField = ctx.castTo(
                        fieldColl.addFieldAsXml('<Field Type="User" DisplayName="' + option.internalname + '" Name="' + option.internalname + '" Required="' + option.require + '" Format="Hyperlink" />', true, SP.AddFieldOptions.addToDefaultContentType),
                    SP.FieldUser);
                    //userField.set_description("This is an user field");
                    userField.set_title(option.title);
                    userField.set_selectionMode(0);
                    userField.set_allowMultipleValues(option.allowmutiple);
                    userField.update();
                    break;
                case "UserGroup":
                    //Add User Field to the collection    
                    var userField = ctx.castTo(
                        fieldColl.addFieldAsXml('<Field Type="User" DisplayName="' + option.internalname + '" Name="' + option.internalname + '" Required="' + option.require + '" Format="Hyperlink" />', true, SP.AddFieldOptions.addToDefaultContentType),
                    SP.FieldUser);
                    //userField.set_description("This is an user field");
                    userField.set_title(option.title);
                    userField.set_allowMultipleValues(option.allowmutiple);
                    userField.update();
                    break;
                case "DateOnly":
                    //Add Date Only field to the Field Collection    
                    var dateField = fieldColl.addFieldAsXml('<Field Type="DateTime" DisplayName="' + option.internalname + '" Name="' + option.internalname + '" Required="' + option.require + '" Format="DateOnly" />', true, SP.AddFieldOptions.addToDefaultContentType);
                    //dateField.set_description("This is a date field");
                    dateField.set_title(option.title);
                    dateField.update();
                    break;
                case "DateTime":
                    //Add Date Time field to the Field Collection    
                    var dateTimeField = fieldColl.addFieldAsXml('<Field Type="DateTime" DisplayName="' + option.internalname + '" Name="' + option.internalname + '" Required="' + option.require + '" Format="DateTime" />', true, SP.AddFieldOptions.addToDefaultContentType);
                    //dateTimeField.set_description("This is a DateTime field");
                    dateTimeField.set_title(option.title);
                    dateTimeField.update();
                    break;
                case "ChoiceDropDown":
                    //Add Choice DropDown field to the Field Collection    
                    var choiceDropDownField = ctx.castTo(
                    fieldColl.addFieldAsXml('<Field Type="Choice" DisplayName="' + option.internalname + '" Name="' + option.internalname + '" Required="' + option.require + '" Format="Dropdown" />', true, SP.AddFieldOptions.addToDefaultContentType),
                    SP.FieldChoice);
                    choiceDropDownField.set_title(option.title);
                    choiceDropDownField.set_choices(option.arraychoice);
                    if (option.defaultvalue !== null) {
                        choiceDropDownField.set_defaultValue(option.defaultvalue);
                    }
                    choiceDropDownField.update();
                    break;
                case "ChoiceRadio":
                    //Add Choice Radio Button field to the Field Collection     
                    var choiceDropDownField = ctx.castTo(
                    fieldColl.addFieldAsXml('<Field Type="Choice" DisplayName="' + option.internalname + '" Name="' + option.internalname + '" Required="' + option.require + '" Format="RadioButtons" />', true, SP.AddFieldOptions.addToDefaultContentType),
                    SP.FieldChoice);
                    choiceDropDownField.set_title(option.title);
                    choiceDropDownField.set_choices(option.arraychoice);
                    choiceDropDownField.update();
                    break;
                case "ChoiceCheckBox":
                    //Add Choice CheckBox field to the Field Collection     
                    var choiceDropDownField = ctx.castTo(
                    fieldColl.addFieldAsXml('<Field Type="MultiChoice" DisplayName="' + option.internalname + '" Name="' + option.internalname + '" Required="' + option.require + '"/>', true, SP.AddFieldOptions.addToDefaultContentType),
                    SP.FieldMultiChoice);
                    choiceDropDownField.set_title(option.title);
                    choiceDropDownField.set_choices(option.arraychoice);
                    choiceDropDownField.update();
                    break;
            }
        },
        CreateList: function (ctx,web,_key, pdata) {
            // Create a new Deferred object
            var deferred = $.Deferred();

            //create object for list creation  
            var listCreationInfo = new SP.ListCreationInformation();
            listCreationInfo.set_title(pdata.Title);

            //set list template
            switch (_key) {
                case "LeaveRequestOfficer":
                case "LeaveRequestHoliday":
                case "LeaveRequestCondition":
                case "LeaveRequestConfiguration":
                case "LeaveRequestQuota":
                case "LeaveRequestItem":
                    //provide template type - genericList is custom list template  
                    listCreationInfo.set_templateType(SP.ListTemplateType.genericList);
                    break;
                case "LeaveRequestWorkflowHistory":
                    //provide template type - genericList is custom list template  
                    listCreationInfo.set_templateType(SP.ListTemplateType.workflowHistory);
                    break;
                case "LeaveRequestWorkflowTask":
                    //provide template type - genericList is custom list template  
                    listCreationInfo.set_templateType(SP.ListTemplateType.tasks);
                    break;

            }


            // add list in host web  
            var list = web.get_lists().add(listCreationInfo);
            // Get filed collection
            var fldCollection = list.get_fields();
            switch (_key) {
                //example
                //setFieldToList(context, fldCollection, { title: "AText", internalname: "AText" }, "Text");
                //setFieldToList(context, fldCollection, { title: "APlainText", internalname: "APlainText" }, "PlainText");
                //setFieldToList(context, fldCollection, { title: "ARichText", internalname: "ARichText" }, "RichText");
                //setFieldToList(context, fldCollection, { title: "AEnhancedText", internalname: "AEnhancedText" }, "EnhancedText");
                //setFieldToList(context, fldCollection, { title: "ABoolean", internalname: "ABoolean" }, "Boolean");
                //setFieldToList(context, fldCollection, { title: "AImage", internalname: "AImage" }, "Image");
                //setFieldToList(context, fldCollection, { title: "AURL", internalname: "AURL" }, "URL");
                //setFieldToList(context, fldCollection, { title: "ANumber", internalname: "ANumber" }, "Number");
                //setFieldToList(context, fldCollection, { title: "APercentage", internalname: "APercentage" }, "Percentage");
                //setFieldToList(context, fldCollection, { title: "AUser", internalname: "AUser" }, "User");
                //setFieldToList(context, fldCollection, { title: "AUserGroup", internalname: "AUserGroup",allowmutiple:true }, "UserGroup");
                //setFieldToList(context, fldCollection, { title: "ADateOnly", internalname: "ADateOnly" }, "DateOnly");
                //setFieldToList(context, fldCollection, { title: "ADateTime", internalname: "ADateTime" }, "DateTime");
                //setFieldToList(context, fldCollection, { title: "AChoiceDropDown", internalname: "AChoiceDropDown", arraychoice: new Array("Admin", "HR"), defaultvalue: "HR" }, "ChoiceDropDown");
                //setFieldToList(context, fldCollection, { title: "AChoiceRadio", internalname: "AChoiceRadio", arraychoice: new Array("Admin", "HR") }, "ChoiceRadio");
                //setFieldToList(context, fldCollection, { title: "AChoiceCheckBox", internalname: "AChoiceCheckBox", arraychoice: new Array("Admin", "HR") }, "ChoiceCheckBox");
                case "LeaveRequestOfficer":
                    LRListManagement.Services.SetFieldToList(ctx, fldCollection, { f: LRListManagement.Lists.LeaveRequestOfficer.Fields.Officer, require: true }, "User");
                    LRListManagement.Services.SetFieldToList(ctx, fldCollection, { f: LRListManagement.Lists.LeaveRequestOfficer.Fields.Gender, arraychoice: new Array("Male", "Female"), require: true }, "ChoiceDropDown");
                    LRListManagement.Services.SetFieldToList(ctx, fldCollection, { f: LRListManagement.Lists.LeaveRequestOfficer.Fields.Position}, "Text");
                    LRListManagement.Services.SetFieldToList(ctx, fldCollection, { f: LRListManagement.Lists.LeaveRequestOfficer.Fields.Department}, "Text");
                    LRListManagement.Services.SetFieldToList(ctx, fldCollection, { f: LRListManagement.Lists.LeaveRequestOfficer.Fields.Role, arraychoice: new Array("HR", "Approver", "Officer"), require: true }, "ChoiceCheckBox");
                    LRListManagement.Services.SetFieldToList(ctx, fldCollection, { f: LRListManagement.Lists.LeaveRequestOfficer.Fields.StartWorking, require: true }, "DateOnly");
                    LRListManagement.Services.SetFieldToList(ctx, fldCollection, { f: LRListManagement.Lists.LeaveRequestOfficer.Fields.Approver }, "User");
                    //LRListManagement.Services.SetFieldToList(ctx, fldCollection, { title: "My Quata", internalname: "OfficerQuata" }, "PlainText");
                    //LRListManagement.Services.SetFieldToList(ctx, fldCollection, { title: "Stamp Year", internalname: "OfficerYear" }, "Number");
                    break;
                case "LeaveRequestHoliday":
                    LRListManagement.Services.SetFieldToList(ctx, fldCollection, { f: LRListManagement.Lists.LeaveRequestHoliday.Fields.HolidayDate}, "DateOnly");
                    break;
                case "LeaveRequestCondition":
                    LRListManagement.Services.SetFieldToList(ctx, fldCollection, { f: LRListManagement.Lists.LeaveRequestCondition.Fields.LeaveCode }, "Text");
                    LRListManagement.Services.SetFieldToList(ctx, fldCollection, { f: LRListManagement.Lists.LeaveRequestCondition.Fields.ConditionGender, arraychoice: new Array("1", "2", "3"), defaultvalue: "1" }, "ChoiceDropDown");// 1 = all 2 = male 3= female
                    LRListManagement.Services.SetFieldToList(ctx, fldCollection, { f: LRListManagement.Lists.LeaveRequestCondition.Fields.ShowHide}, "Boolean");
                    LRListManagement.Services.SetFieldToList(ctx, fldCollection, { f: LRListManagement.Lists.LeaveRequestCondition.Fields.ConditionEmployeeRights}, "Text");//PlainText
                    LRListManagement.Services.SetFieldToList(ctx, fldCollection, { f: LRListManagement.Lists.LeaveRequestCondition.Fields.ConditionDate}, "Text");

                    break;
                case "LeaveRequestConfiguration":
                    LRListManagement.Services.SetFieldToList(ctx, fldCollection, { f: LRListManagement.Lists.LeaveRequestConfiguration.Fields.Details}, "Text");
                    break;
                case "LeaveRequestQuota":
                    LRListManagement.Services.SetFieldToList(ctx, fldCollection, { f: LRListManagement.Lists.LeaveRequestQuota.Fields.Officer, require: true }, "User");
					LRListManagement.Services.SetFieldToList(ctx, fldCollection, { f: LRListManagement.Lists.LeaveRequestQuota.Fields.QuotaYear}, "Number");
					LRListManagement.Services.SetFieldToList(ctx, fldCollection, { f: LRListManagement.Lists.LeaveRequestQuota.Fields.Quota}, "PlainText");
                    break;    
                case "LeaveRequestItem":
                    LRListManagement.Services.SetFieldToList(ctx, fldCollection, { f: LRListManagement.Lists.LeaveRequestItem.Fields.Requester}, "User");
                    LRListManagement.Services.SetFieldToList(ctx, fldCollection, { f: LRListManagement.Lists.LeaveRequestItem.Fields.LeaveType}, "Text");
                    LRListManagement.Services.SetFieldToList(ctx, fldCollection, { f: LRListManagement.Lists.LeaveRequestItem.Fields.StartDate }, "DateOnly");
                    LRListManagement.Services.SetFieldToList(ctx, fldCollection, { f: LRListManagement.Lists.LeaveRequestItem.Fields.EndDate }, "DateOnly");
                    LRListManagement.Services.SetFieldToList(ctx, fldCollection, { f: LRListManagement.Lists.LeaveRequestItem.Fields.LeaveTime }, "Text");
                    LRListManagement.Services.SetFieldToList(ctx, fldCollection, { f: LRListManagement.Lists.LeaveRequestItem.Fields.LeaveDayTotal }, "Number");
                    LRListManagement.Services.SetFieldToList(ctx, fldCollection, { f: LRListManagement.Lists.LeaveRequestItem.Fields.LeaveYear}, "Number");
                    LRListManagement.Services.SetFieldToList(ctx, fldCollection, { f: LRListManagement.Lists.LeaveRequestItem.Fields.LeaveReason }, "PlainText");
                    LRListManagement.Services.SetFieldToList(ctx, fldCollection, { f: LRListManagement.Lists.LeaveRequestItem.Fields.LeaveStatus, arraychoice: new Array("In Progress", "Approved", "Rejected","Cancelled By User","Approved Cancel Request","Cancelled By HR"), defaultvalue: "In Progress" }, "ChoiceDropDown");
                    LRListManagement.Services.SetFieldToList(ctx, fldCollection, { f: LRListManagement.Lists.LeaveRequestItem.Fields.LeaveDictionary }, "PlainText");
                    LRListManagement.Services.SetFieldToList(ctx, fldCollection, { f: LRListManagement.Lists.LeaveRequestItem.Fields.LeaveParentId}, "Text");
                    LRListManagement.Services.SetFieldToList(ctx, fldCollection, { f: LRListManagement.Lists.LeaveRequestItem.Fields.RequestType, arraychoice: new Array("1", "2") }, "ChoiceDropDown");
                    LRListManagement.Services.SetFieldToList(ctx, fldCollection, { f: LRListManagement.Lists.LeaveRequestItem.Fields.OfficerApprover }, "User");
                    LRListManagement.Services.SetFieldToList(ctx, fldCollection, { f: LRListManagement.Lists.LeaveRequestItem.Fields.OfficerHr, allowmutiple: true }, "User");
                    LRListManagement.Services.SetFieldToList(ctx, fldCollection, { f: LRListManagement.Lists.LeaveRequestItem.Fields.IsActive }, "Boolean");
                    LRListManagement.Services.SetFieldToList(ctx, fldCollection, { f: LRListManagement.Lists.LeaveRequestItem.Fields.CancelWorkflow }, "Text");
                    LRListManagement.Services.SetFieldToList(ctx, fldCollection, { f: LRListManagement.Lists.LeaveRequestItem.Fields.CurrentUrl }, "Text");
                    LRListManagement.Services.SetFieldToList(ctx, fldCollection, { f: LRListManagement.Lists.LeaveRequestItem.Fields.CurrentHostUrl }, "Text");
                    LRListManagement.Services.SetFieldToList(ctx, fldCollection, { f: LRListManagement.Lists.LeaveRequestItem.Fields.CurrentAppUrl }, "Text");
                    break;
                case "LeaveRequestWorkflowTask":
                    LRListManagement.Services.SetFieldToList(ctx, fldCollection, { f: LRListManagement.Lists.LeaveRequestWorkflowTask.Fields.TaskReason}, "PlainText");
                    break;

            }

            var listRootFolder = list.get_rootFolder();

            ctx.load(list);
            ctx.load(listRootFolder);
            ctx.load(web);
            ctx.executeQueryAsync(function () {
                //alert("Sharepoint custom list is created Successfully..")
                var rootweb = web.get_url();//.replace(currentWEB.get_serverRelativeUrl(),"");
                var relatveweb = web.get_serverRelativeUrl();
                if (relatveweb !== "/") {
                    rootweb = rootweb.replace(relatveweb, "");
                }
                return deferred.resolve(list.get_id(), rootweb + listRootFolder.get_serverRelativeUrl());
            }, function (sender, args) {
                //console.log('Failed to create list. Error:' + args.get_message());
                return deferred.reject('Failed to create list. Error:' + args.get_message());
            });

            // Return the Deferred's Promise object
            return deferred.promise();
        },
        CreateDefaultListitem: function (ctx, web,_key, pdata) {
            // Create a new Deferred object
            var deferred = $.Deferred();

            // get list in host web  
            var list = web.get_lists().getByTitle(pdata.Title);

            //New Item to List
            switch (_key) {
                case "LeaveRequestCondition":
                    //ลากิจ
                    var itemCreateInfo = new SP.ListItemCreationInformation();
                    var listitem1 = list.addItem(itemCreateInfo);

                    listitem1.set_item(LRListManagement.Lists.LeaveRequestCondition.Fields.Title.Internal, 'ลากิจ');
                    listitem1.set_item(LRListManagement.Lists.LeaveRequestCondition.Fields.LeaveCode.Internal , 'L1');
                    listitem1.set_item(LRListManagement.Lists.LeaveRequestCondition.Fields.ConditionEmployeeRights.Internal, 6);
                    listitem1.set_item(LRListManagement.Lists.LeaveRequestCondition.Fields.ShowHide.Internal, true);

                    listitem1.update();
                    //ลาป่วย
                    var listitem2 = list.addItem(itemCreateInfo);

                    listitem2.set_item(LRListManagement.Lists.LeaveRequestCondition.Fields.Title.Internal, 'ลาป่วย');
                    listitem2.set_item(LRListManagement.Lists.LeaveRequestCondition.Fields.LeaveCode.Internal , 'L2');
                    listitem2.set_item(LRListManagement.Lists.LeaveRequestCondition.Fields.ConditionEmployeeRights.Internal, 30);
                    listitem2.set_item(LRListManagement.Lists.LeaveRequestCondition.Fields.ShowHide.Internal, true);

                    listitem2.update();

                    //ลาพักร้อน
                    var listitem4 = list.addItem(itemCreateInfo);

                    listitem4.set_item(LRListManagement.Lists.LeaveRequestCondition.Fields.Title.Internal, 'ลาพักร้อน');
                    listitem4.set_item(LRListManagement.Lists.LeaveRequestCondition.Fields.LeaveCode.Internal , 'L3');
                    listitem4.set_item(LRListManagement.Lists.LeaveRequestCondition.Fields.ConditionEmployeeRights.Internal, 6);
                    listitem4.set_item(LRListManagement.Lists.LeaveRequestCondition.Fields.ShowHide.Internal, true);

                    listitem4.update();
                    //"Gender", internalname: "GenderMaxDate", arraychoice: new Array("All", "Male", "Female")
                    // ลาบวช 
                    var listitem5 = list.addItem(itemCreateInfo);

                    listitem5.set_item(LRListManagement.Lists.LeaveRequestCondition.Fields.Title.Internal, 'ลาบวช');
                    listitem5.set_item(LRListManagement.Lists.LeaveRequestCondition.Fields.LeaveCode.Internal , 'L4');
                    listitem5.set_item(LRListManagement.Lists.LeaveRequestCondition.Fields.ConditionEmployeeRights.Internal, 15);
                    listitem5.set_item(LRListManagement.Lists.LeaveRequestCondition.Fields.ShowHide.Internal, false);
                    listitem5.set_item(LRListManagement.Lists.LeaveRequestCondition.Fields.ConditionGender.Internal, 2);

                    listitem5.update();

                    //ลาคลอด
                    var listitem6 = list.addItem(itemCreateInfo);

                    listitem6.set_item(LRListManagement.Lists.LeaveRequestCondition.Fields.Title.Internal, 'ลาคลอด');
                    listitem6.set_item(LRListManagement.Lists.LeaveRequestCondition.Fields.LeaveCode.Internal , 'L5');
                    listitem6.set_item(LRListManagement.Lists.LeaveRequestCondition.Fields.ConditionEmployeeRights.Internal, 90);
                    listitem6.set_item(LRListManagement.Lists.LeaveRequestCondition.Fields.ShowHide.Internal, false);
                    listitem6.set_item(LRListManagement.Lists.LeaveRequestCondition.Fields.ConditionGender.Internal, 3);


                    listitem6.update();
                    break;
                    //case "Options":
                    //    break;
            }

            ctx.executeQueryAsync(function () {
                //alert("Sharepoint custom list is created Successfully..")
                return deferred.resolve();
            }, function (sender, args) {
                //console.log('Failed to create list. Error:' + args.get_message());
                return deferred.reject('Failed to add default item to list. Error:' + args.get_message());
            });

            // Return the Deferred's Promise object
            return deferred.promise();
        },
        AddContenTypeToList: function (ctx, web, _key, pdata) {
            // Create a new Deferred object
            var deferred = $.Deferred();
            //get rootweb  
            var rootWeb = ctx.get_site().get_rootWeb();
            //Get all content types from root web site  
            var allContentTypeColl = rootWeb.get_contentTypes();
            // get list in host web  

            var contentTypeNameArr = [];

            switch (_key) {
                case "LeaveRequestWorkflowTask":
                    contentTypeNameArr = ["Workflow Task (SharePoint 2013)"]
                    break;
                    //case "Options":
                    //    break;
            }
            ctx.load(rootWeb);
            ctx.load(allContentTypeColl);
            ctx.executeQueryAsync(function () {
                if (contentTypeNameArr.length == 0) {
                    return deferred.resolve();
                }
                else {
                    //var CTypeID;
                    var list = web.get_lists().getByTitle(pdata.Title);
                    //Enable the content type in custom list  
                    list.set_contentTypesEnabled(true);
                    list.update();
                    ctx.load(list);
                    var listCollectionCT = list.get_contentTypes();

                    //then load the list collection content types  
                    for (var i = 0; i < contentTypeNameArr.length; i++) {
                        var contentTypeName = contentTypeNameArr[i];
                        //Get the Content type ID , if we know content type id we dont want to get the id again  
                        var contentTypeEnum = allContentTypeColl.getEnumerator();
                        while (contentTypeEnum.moveNext()) {
                            var currentCT = contentTypeEnum.get_current();
                            if (currentCT.get_name() == contentTypeName) {
                                //CTypeID = currentCT.get_stringId();
                                listCollectionCT.addExistingContentType(currentCT);
                                break;
                            }
                        }
                    }
                    ctx.executeQueryAsync(function () {
                        //alert("Sharepoint custom list is created Successfully..")
                        return deferred.resolve();
                    }, function (sender, args) {
                        //console.log('Failed to create list. Error:' + args.get_message());
                        return deferred.reject('Failed to add content type to list. Error:' + args.get_message());
                    });
                }
            }, function (sender, args) {
                //console.log('Failed to create list. Error:' + args.get_message());
                return deferred.reject('Failed to get content types. Error:' + args.get_message());
            });

            // Return the Deferred's Promise object
            return deferred.promise();
        },
        GetListInformation: function (iscreatelist) {
            var deferred = $.Deferred();
            //SharePointClient.Configurations.IsApp = true;
            //SharePointClient.Configurations.IsCrossDomainRequest = true;
            //SharePointClient.Services.JSOM.Initialize(function () {

            var maxListCount = Object.keys(LRListManagement.Lists).length;
            var currentListCount = 0;

            SharePointClient.Configurations.IsCrossDomainRequest = LRGlobalFunc.IsCrossDomain;
            //Get SP clientContext
            var hostcontext = new SharePointClient.Services.JSOM.Context();
            // var appCtxSite = listService.JSOM // new SP.AppContextSite(context, utility.GetHostUrl());
            //get current context
            var context = hostcontext.GetClientContext();
            //get current web  
            var currentWEB = hostcontext.GetWeb();

            ko.utils.objectForEach(LRListManagement.Lists, function (key, value) {
                //alert(key + ": " + value);
                var curkey = key;
                var curvalue = value;
                LRListManagement.Services.FindListByTitle(context, currentWEB,curvalue.Title).then(function (id, url) {
                    curvalue.ID = id.toString();
                    curvalue.Url = url;
                    //ToraAsiaLeaveRequestInfo.ListManagement[curkey] = curvalue;
                    currentListCount++;
                    //console.log(ToraAsiaLeaveRequestInfo.ListManagement);
                    //console.log(currentListCount +"---"+maxListCount);
                    if (currentListCount === maxListCount) {
                        return deferred.resolve();
                    }
                }, function (egr) {
                    //console.log(egr);
                    if (iscreatelist) {
                    	//return deferred.resolve();
                    		LRListManagement.Services.CreateList(context, currentWEB,curkey, curvalue).then(function (id2, url2) {
                    				curvalue.ID = id2.toString();
									curvalue.Url = url2;
									var countdefault = 0;
									var maxcountdefault = 2;

	                                LRListManagement.Services.AddContenTypeToList(context, currentWEB,curkey, curvalue).then(function () {
		                                countdefault++;
		                                if (countdefault === maxcountdefault) {
		                                    currentListCount++;
		                                    if (currentListCount === maxListCount) {
		                                        return deferred.resolve();
		                                    }	                                
	                                    }	
		                           }, function (err_addcty) {
		                                return deferred.reject(err_addcty);
		                            });
		                            
		                           LRListManagement.Services.CreateDefaultListitem(context, currentWEB,curkey, curvalue).then(function () {
		                                countdefault++;
		                                if (countdefault === maxcountdefault) {
		                                    currentListCount++;
		                                    if (currentListCount === maxListCount) {
		                                        return deferred.resolve();
		                                    }	                                
	                                    }	
		                            }, function (err_default) {
		                                return deferred.reject(err_default);                            
		                            });


							},function(err_create){
								return deferred.reject(err_create);
							});
                    }
                    else {
                    	return deferred.reject(egr);
                    }
                })
            });

            return deferred.promise();
            //});
        },
    };
    //#endregion
})();
