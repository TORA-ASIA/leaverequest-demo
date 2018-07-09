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
            Url: null
        },
        //เก็บข้อมูลวันหยุด
        LeaveRequestHoliday: {
            Title: "Leave Request Holiday",
            Internal: "LeaveRequestHoliday",
            ID: null,
            Url: null
        },
        //เก็บข้อมูลประเภทการลาและเงื่อนไขต่างๆ ในแต่ละประเภท
        LeaveRequestCondition: {
            Title: "Leave Request Condition",
            Internal: "LeaveRequestCondition",
            ID: null,
            Url: null
        },
        //เก็บข้อมูล Configuration ของ Leave Request
        LeaveRequestConfiguration: {
            Title: "Leave Request Configuration",
            Internal: "LeaveRequestConfiguration",
            ID: null,
            Url: null
        },
        //เก็บข้อมูลการลา
        LeaveRequestItem: {
            Title: "Leave Request Item",
            Internal: "LeaveRequestItem",
            ID: null,
            Url: null
        },
        //เก็บ workflow historys
        LeaveRequestWorkflowHistory: {
            Title: "Leave Request Workflow History",
            Internal: "LeaveRequestWorkflowHistory",
            ID: null,
            Url: null
        },
        //เก็บ workflow tasks
        LeaveRequestWorkflowTask: {
            Title: "Leave Request Workflow Task",
            Internal: "LeaveRequestWorkflowTask",
            ID: null,
            Url: null
        },
    };
    //#endregion
})();
