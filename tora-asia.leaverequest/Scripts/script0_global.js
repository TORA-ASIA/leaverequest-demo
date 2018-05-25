var beforehistory = [];
var beforid = "";
var gcurrentPageIndex = 0;
var getParameterByName = function(name, url) {
    if (!url) url = window.location.href;
    name = name.replace(/[\[\]]/g, "\\$&");
    var regex = new RegExp("[?&]" + name + "(=([^&#]*)|&|#|$)"),
        results = regex.exec(url);
    if (!results) return null;
    if (!results[2]) return '';
    return decodeURIComponent(results[2].replace(/\+/g, " "));
}
function datawithpaging(options){
	options = options || {};
	var self =this;
	this.showPaging = ko.observable(typeof options.showPaging !== 'undefined'?options.showPaging : true);
    this.pageSize = ko.observable(typeof options.pageSize !== 'undefined'?options.pageSize : 15);
	this.rows = ko.observableArray([]);
	this.pagingObj = ko.observable();
	//this.leavedatas
	//this.leavedata = ko.computed(function() {
    //    //var first = self.pageNumber() * self.nbPerPage;
    //    return self.leavedatas.slice(0, 5);
    //});
    this.totalItems = ko.computed(function() {
          return self.rows ().length;
    }, this);

    this.pageIndex = ko.observable(0),
    this.gotoPage = function(data) {
        self.pageIndex(data);
        gcurrentPageIndex  = data;
    },
    this.maxPageIndex = ko.computed(function() {
      // var m =Math.ceil(self.rows().length / self.pageSize());
      // console.log(m);
       return Math.ceil(self.rows().length / self.pageSize());
   }, this);
    this.datas = ko.computed(function() {
        //console.log(self.rows());
        var curpage =self.pageIndex();
        var size = self.pageSize();
        var start = (curpage===0?curpage:curpage-1) * size;
        return self.rows().slice(start, start + size);
    }, self);
    this.ishasdata = ko.computed(function() {
          return self.rows().length > 0;
    }, this);

}
