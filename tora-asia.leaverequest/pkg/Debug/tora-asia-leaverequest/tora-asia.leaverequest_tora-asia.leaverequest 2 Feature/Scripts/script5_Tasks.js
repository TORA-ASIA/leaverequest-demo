function LRTasksViewModel(parent, ishrform) {
    //ishrform = (typeof ishrform !== "undefined") ? ishrform : false;
    var self = this;
    this.listtaskstitle = ToraAsiaLeaveRequestInfo.ListManagement.LeaveRequestWorkflowTask.Title;
    this.listformtitle = ToraAsiaLeaveRequestInfo.ListManagement.LeaveRequestItem.Title;
    //this.tasksdatas = ko.observableArray();

    this.datawithpaging = ko.observable(new datawithpaging());
    //this.datawithpagingHr = ko.observable(new datawithpaging());

    this.isHR = ko.observable(parent.isHr());
    this.isManager = ko.observable(parent.isManager());
    this.curUser = ko.observable(ToraAsiaLeaveRequestInfo.Services.GetUserId());
   // this.ishrForm = ko.observable(ishrform);

    this.generateQuery = function (ishrrview) {

        var allquery = [];
        var queryBegin = [];
        allquery.push(String.format(ko.defaultquery, "Neq", "Status", "Choice", "Completed", "", ""));
        allquery.push(String.format(ko.defaultquery, "Contains", "RelatedItems", "Text", "[{\"ItemId\":", "", ""));
        if (self.isManager() || (ishrrview && self.isHR())) {
            allquery.push(String.format(ko.defaultquery, "Eq", "AssignedTo", "Lookup", self.curUser(), "LookupId='TRUE'", ""));
        }
        if (!ishrrview) {

            queryBegin.push(String.format(ko.defaultquery, "BeginsWith", "Title", "Text", "แจ้งการขออนุมัติการลา", "", ""));
            queryBegin.push(String.format(ko.defaultquery, "BeginsWith", "Title", "Text", "อนุมัติขอยกเลิกการลา", "", ""));

        }
        else {
            queryBegin.push(String.format(ko.defaultquery, "BeginsWith", "Title", "Text", "Review การลา", "", ""));
            queryBegin.push(String.format(ko.defaultquery, "BeginsWith", "Title", "Text", "Review ขอยกเลิกการลา", "", ""));
        }
        allquery.push(ko.MergeCAMLConditions(queryBegin, ko.MergeType.Or))

        if (allquery.length > 0) {
            return "<Where>" + ko.MergeCAMLConditions(allquery, ko.MergeType.And) + "</Where>";
        }
        return "";
    }
    this.loadTasksData = function (datapaging,ishrreview, callback) {
        ishrreview = (typeof ishrreview !== "undefined") ? ishrreview : false;
        var querytxt = self.generateQuery(ishrreview);
        var listServices = new SharePointClient.Services.JSOM.ListServices();

        //Get SP clientContext
        var context = new SharePointClient.Services.JSOM.Context();
        //Create Caml object
        var camlConstant = SharePointClient.Constants.CAML_CONSTANT;
        var camlQuery = new SharePointClient.CamlExtension.JSOM.CamlQuery();
        camlQuery
        .ViewAttribute("")
        .Query(querytxt)
        .QueryThrottleMode(camlConstant.CAML_QUERY_THROTTLE_MODE.OVERRIDE)
        .OrderByMe("<FieldRef Name='Created' Ascending='false'/>")
        //.OrderByIndex()
        .RowLimit(30);
        //.FolderServerRelativeUrl(self.selectdFolder());
        //Get All list items batch by list name
        var relatedfield = [
            { field: "LeaveId", type: "Default", typefield: "ID" },
            { field: "LeaveTitle", type: "Default", typefield: "Title" },
            { field: "StartDate", type: "Date", format: ko.dateformat.normal },
            { field: "LeaveDayTotal" },
            { field: "LeaveStatus" },
            //{ field: "CancelLeaveStatus" },
            { field: "LeaveType" }
        ]
        var options = {};
        options.fileData = [
            { field: "Id", type: "Default", typefield: "ID" },
            { field: "Title" },
            {
                field: "RelatedItems", type: "RelatedItems", typefield: "RelatedItems",
                relatedField: relatedfield, relatedListName: self.listformtitle
            }
        ];
        options.format = ko.dateformat.nomal;

        listServices.GetListItemsBatchByListName(context,
                self.listtaskstitle, camlQuery.BuildQuery()).Execute(function (result) {
                    //console.log(result.get_count());
                    //console.log(result);
                    var alldata = ko.getdataFromEnum({
                        ItemEnum: result,
                        filedDisplay: options.fileData,
                        format: options.format
                    }, options);

                    var olddata = datapaging().rows();
                    var newdata = olddata.concat(alldata);
                    datapaging().rows(newdata);


                    var nextpost = result.get_listItemCollectionPosition();
                    if (nextpost == null) {
                        if (callback) {
                            callback();
                        }

                    }
                });

    }
    this.goToApproveForm = function (data) {
        //console.log(data.LeaveId());
        //parent.selectTemplate("idwating");
        //parent.selectModel (new LRApproveViewModel(parent,data.LeaveId(),data.Id,self.ishrForm()));
        //parent.selectTemplate("idapproveform");
        //GoToApproveViewModel(parent,data);
        var isviewonly = true;
        if (self.isManager()) {
            isviewonly = false;
        }

        parent.GoToApproveViewModel(parent, data, data.LeaveId(), "idapprove", isviewonly, self.isManager(), false);
    }
    //this.goToApproveFormHR = function (data) {
    //    //console.log(data.LeaveId());
    //    //parent.selectTemplate("idwating");
    //    //parent.selectModel (new LRApproveViewModel(parent,data.LeaveId(),data.Id,self.ishrForm()));
    //    //parent.selectTemplate("idapproveform");
    //    //GoToApproveViewModel(parent,data);
    //    var isviewonly = true;
    //    if (self.isHR()) {
    //        isviewonly = false;
    //    }

    //    parent.GoToApproveViewModel(parent, data, data.LeaveId(), "idapprove", isviewonly, self.isManager(), true);
    //}
    ko.contentDialog.show();
    //var maxloaded = 2;
    //var countloaded = 0;
    this.loadTasksData(self.datawithpaging, false, function () {
        //countloaded++;
        //if (maxloaded === countloaded) {
        //    ko.contentDialog.hide();
        //}
        ko.contentDialog.hide();
        //console.log(self.tasksdatas());
    });
    //this.loadTasksData(self.datawithpagingHr,true,function () {
    //    countloaded++;
    //    if (maxloaded === countloaded) {
    //        ko.contentDialog.hide();
    //    }
    //});
}
