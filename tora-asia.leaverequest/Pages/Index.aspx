<%@ Page language="C#" MasterPageFile="~masterurl/default.master" Inherits="Microsoft.SharePoint.WebPartPages.WebPartPage, Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>

<asp:Content ContentPlaceHolderId="PlaceHolderAdditionalPageHead" runat="server">
    <!--SharePoint  2-->
    <SharePoint:ScriptLink name="sp.js" runat="server" OnDemand="true" LoadAfterUI="true" Localizable="false" />
    <SharePoint:ScriptLink name="clientforms.js" runat="server" OnDemand="true" LoadAfterUI="true" Localizable="false" />
    <SharePoint:ScriptLink name="autofill.js" runat="server" OnDemand="true" LoadAfterUI="true" Localizable="false" />

    <!--Jquery  3-->
    <link href="../Scripts/lib/jquery-ui-1.11.4/jquery-ui.min.css" rel="Stylesheet" type="text/css" />
    <script type="text/javascript" src="../Scripts/lib/jquery-1.10.2.min.js"></script>
    <script type="text/javascript" src="../Scripts/lib/jquery-ui-1.11.4/jquery-ui.min.js"></script>

    <!--Other  2-->
    <script type="text/javascript" src="../Scripts/lib/moment-with-locales.js"></script>
    <script type="text/javascript" src="../Scripts/lib/moment-weekday-calc.js"></script>
    <script type="text/javascript" src="../Scripts/lib/SharePointClient.js"></script>

    <!--Bootstrap 6-->
    <link href="../Scripts/lib/bootstrap-3.3.6-dist/css/bootstrap.min.css" rel="Stylesheet" type="text/css" />
    <link href="../Scripts/lib/bootstrap-datetimepicker.css" rel="Stylesheet" type="text/css" />
    <link href="../Scripts/lib/bootstrap-select.min.css"rel="Stylesheet" type="text/css" />
    <script type="text/javascript" src="../Scripts/lib/bootstrap-3.3.6-dist/js/bootstrap.min.js"></script>
    <script type="text/javascript" src="../Scripts/lib/bootstrap-datetimepicker.js"></script>
    <script type="text/javascript" src="../Scripts/lib/bootstrap-select.min.js"></script>

    <!--Knockout 4-->
    <script type="text/javascript" src="../Scripts/lib/knockout-3.4.2.js"></script>
    <script type="text/javascript" src="../Scripts/lib/knockout.validation.min.js"></script>
    <script type="text/javascript" src="../Scripts/lib/knockout.mapping-latest.js"></script>
    <script type="text/javascript" src="../Scripts/lib/knockout-jqAutocomplete.js"></script>

    <!--pagination 3-->
    <link rel="stylesheet" type="text/css" href="../Scripts/lib/bs_pagination-master/jquery.bs_pagination.css"/>
    <script type="text/javascript" src="../Scripts/lib/bs_pagination-master/jquery.bs_pagination.min.js"></script>
    <script type="text/javascript" src="../Scripts/lib/bs_pagination-master/localization/en.min.js"></script>

    <!--sweetalert 2-->
    <link rel="stylesheet" type="text/css" href="../Scripts/lib/sweetalert-master/sweetalert.css"/>
    <script type="text/javascript" src="../Scripts/lib/sweetalert-master/sweetalert.min.js"></script>

    <!--My Scripts 12-->
    <link rel="stylesheet" type="text/css" href="../Content/style.css"/>
    <script type="text/javascript" src="../Scripts/knockout-custom.js"></script>
    <script type="text/javascript" src="../Scripts/tora-setup.js"></script>
    <script type="text/javascript" src="../Scripts/script0_global.js"></script>
    <script type="text/javascript" src="../Scripts/script1_New.js"></script>
    <script type="text/javascript" src="../Scripts/script2_Home.js"></script>
    <script type="text/javascript" src="../Scripts/script3_History.js"></script>
    <script type="text/javascript" src="../Scripts/script4_ViewForm.js"></script>
    <script type="text/javascript" src="../Scripts/script5_Tasks.js"></script>
    <script type="text/javascript" src="../Scripts/script6_Setting.js"></script>
    <script type="text/javascript" src="../Scripts/script7_BeginSetting.js"></script>
    <script type="text/javascript" src="../Scripts/script8_myleaveremain.js"></script>
    <script type="text/javascript" src="../Scripts/ready.js"></script>

</asp:Content>

<asp:Content ContentPlaceHolderId="PlaceHolderMain" runat="server">
    <script type="text/html" id="idnotpermission">
    	<div class="row form-group">
			<div class="col-xs-12">
				คุณยังไม่มีสิทธิ์ในการใช้งาน กรุณาติดต่อ Admin
			</div>
		</div>

    </script>

    <script type="text/html" id="idmorethenone">
        	<div class="row form-group">
				<div class="col-sm-offset-2 col-xs-offset-0 col-xs-2 control-label">
					<span>ถึงวันที่</span>
				</div>
				<div class="col-xs-10 col-sm-6">
					<div class='input-group date dateTimes'>
						<input type="text"  autocomplete="off" class="form-control" data-bind="datepicker: todate,datepickerOptions:{format:$parent.dateformate,minDate:$parent.fromdate()},plusday:1" /> <span class="input-group-addon"><span class="glyphicon glyphicon-calendar"></span></span>
					</div>
				</div>
			</div>
    </script>
    <script type="text/html" id="idotherLeaveType">
			<div class="row form-group">
				<div class="col-sm-offset-2 col-xs-offset-0 col-xs-2 control-label">
				</div>
				<div class="col-xs-10 col-sm-6">
					<input type="text" class="form-control" autocomplete="off" data-bind="value:othertype"/>
				</div>
			</div>

    </script>
	<script type="text/html" id="idnewleaveform">
	       	 <div class="row form-group">
				<div class="col-sm-offset-2 col-xs-offset-0 col-xs-2 control-label">
					<span>ชื่อ-สกุล</span>
				</div>
				<div class="col-xs-10 col-sm-6">
					<input type="text" class="form-control" autocomplete="off" data-bind="value:title"/>
				</div>
			</div>
			<div class="row form-group">
				<div class="col-sm-offset-2 col-xs-offset-0 col-xs-2 control-label">
					<span>ประเภทวันลา</span>
				</div>
				<div class="col-xs-10 col-sm-6 bootstrap-customselect">
					<select class="form-control" data-bind="selectedOptions: leavetype,options: leavetypearr,optionsText: 'Title',optionsValue : 'Title', optionsCaption: 'select...',selectPicker: {},selectPickerOptions:{liveSearch:true}"></select>
				</div>
			</div>
			<div data-bind="template: { name: othertyptemplate,data:othertypModel() }"></div>
			<div class="row form-group">
				<div class="col-sm-offset-2 col-xs-offset-0 col-xs-2 control-label">
					<span>วันที่ลา</span>
				</div>
				<div class="col-xs-10 col-sm-6">
					<div class='input-group date dateTimes'>
						<input type="text"  autocomplete="off" class="form-control" data-bind="datepicker: fromdate,datepickerOptions:{format:dateformate}" /> <span class="input-group-addon"><span class="glyphicon glyphicon-calendar"></span></span>
					</div>
				</div>
			</div>
			<div class="row form-group" data-bind="visible:!morebool()">
				<div class="col-sm-offset-2 col-xs-offset-0 col-xs-2 control-label">
				</div>
				<div class="col-xs-10 col-sm-6">
					<select class="form-control form-select" data-bind="options:leavedatetypearr ,value: fromdatetype"></select>
				</div>
			</div>
			
			<div data-bind="template: { name: moretemplate,data:moreModel () }"></div>
			<div class="row form-group">
				<div class="col-sm-offset-2 col-xs-offset-0 col-xs-2 control-label">
				</div>
				<div class="col-xs-10 col-sm-6 text-right">
					<button class="btn btn-xs btn-info" data-bind="text:(morebool ()?'ลา 1 วัน': 'ลามากกว่า 1 วัน'),click:moreclick "></button>
				</div>
			</div>

			 <div class="row form-group">
				<div class="col-sm-offset-2 col-xs-offset-0 col-xs-2 control-label">
					<span>รวม</span>
				</div>
				<div class="col-xs-10 col-sm-6">
					<div class='input-group date dateTimes'>
						<input type="text"  autocomplete="off" class="form-control" data-bind="value:totalday,enable:false" /> 
						<span class="input-group-addon">วัน</span>
					</div>
				</div>
			</div>
			 <div class="row form-group">
				<div class="col-sm-offset-2 col-xs-offset-0 col-xs-2 control-label">
					<span>เหตุผล</span>
				</div>
				<div class="col-xs-10 col-sm-6">
					<textarea class="form-control" autocomplete="off" rows="4" data-bind="value:reason"></textarea>
				</div>
			</div>
			<div class="row form-group">
				<div class="col-sm-offset-2 col-xs-offset-0 col-xs-2 control-label">
					<span>หมายเลขโทรศัพท์</span>
				</div>
				<div class="col-xs-10 col-sm-6">
					<input type="text" class="form-control" autocomplete="off" data-bind="value:phonenumber"/>
				</div>
			</div>
			<div class="row form-group">
				<div class="col-xs-12 col-sm-10 text-right">
					<button class="btn btn-primary" data-bind="click:SaveSubmit.bind($data,$parent)">Submit</button>
					<button class="btn btn-default" data-bind="click: $parent.navLinkClick.bind($data, 'idhomepage')">Cancel</button>
				</div>
			</div>
    </script>
    <script type="text/html" id="idapproveform">
    		<div class="row form-group" data-bind="foreach: singleLeaveremail">
					<div class="col-xs-offset-0 col-md-offset-2 col-xs-5 col-sm-6 col-md-3 text-center">
						<div class="day-header"><span  data-bind="text:Title"></span><span> (คงเหลือ)</span></div>
						<div class="day-number themeColor">
							<table>
								<tbody>
									<tr>
										<td class="remain-day" data-bind="text:$parent.calulateDay($data)"></td>
	
									</tr>
								</tbody>
							</table>
						</div>
					</div>
			</div>
	       	 <div class="row form-group">
				<div class="col-sm-offset-2 col-xs-offset-0 col-xs-2 control-label">
					<span>ชื่อ-สกุล</span>
				</div>
				<div class="col-xs-10 col-sm-6">
					<input type="text" class="form-control" autocomplete="off" data-bind="value:title,enable:false"/>
				</div>
			</div>
			<div class="row form-group">
				<div class="col-sm-offset-2 col-xs-offset-0 col-xs-2 control-label">
					<span>ประเภทวันลา</span>
				</div>
				<div class="col-xs-10 col-sm-6">
					<input type="text" class="form-control" autocomplete="off" data-bind="value:leavetype,enable:false"/>
				</div>
			</div>
			<div class="row form-group" data-bind="visible:otherleavetype()!== null">
				<div class="col-sm-offset-2 col-xs-offset-0 col-xs-2 control-label">
				</div>
				<div class="col-xs-10 col-sm-6">
					<input type="text" class="form-control" autocomplete="off" data-bind="value:otherleavetype,enable:false"/>
				</div>
			</div>
			<div class="row form-group">
				<div class="col-sm-offset-2 col-xs-offset-0 col-xs-2 control-label">
					<span>วันที่ลา</span>
				</div>
				<div class="col-xs-10 col-sm-6">
					<div class='input-group date dateTimes'>
						<input type="text" class="form-control" autocomplete="off" data-bind="value:fromdate,enable:false"/>
						<span class="input-group-addon"><span class="glyphicon glyphicon-calendar"></span></span>
					</div>
				</div>
			</div>
			<div class="row form-group">
				<div class="col-sm-offset-2 col-xs-offset-0 col-xs-2 control-label">
				</div>
				<div class="col-xs-10 col-sm-6">
					<input type="text" class="form-control form-sm" autocomplete="off" data-bind="value:fromdatetype,enable:false"/>
				</div>
			</div>
			<div data-bind="visible:todatevisible ">
				<div class="row form-group">
					<div class="col-sm-offset-2 col-xs-offset-0 col-xs-2 control-label">
						<span>ถึงวันที่</span>
					</div>
					<div class="col-xs-10 col-sm-6">
						<div class='input-group date dateTimes'>
							<input type="text" class="form-control" autocomplete="off" data-bind="value:todate,enable:false"/>
							<span class="input-group-addon"><span class="glyphicon glyphicon-calendar"></span></span>
						</div>
					</div>
				</div>
				<div class="row form-group">
					<div class="col-sm-offset-2 col-xs-offset-0 col-xs-2 control-label">
					</div>
					<div class="col-xs-10 col-sm-6">
						<input type="text" class="form-control form-sm" autocomplete="off" data-bind="value:todatetype,enable:false"/>
					</div>
				</div>

			</div>
			<div class="row form-group">
				<div class="col-sm-offset-2 col-xs-offset-0 col-xs-2 control-label">
					<span>รวม</span>
				</div>
				<div class="col-xs-10 col-sm-6">
					<div class='input-group date dateTimes'>
						<input type="text" class="form-control form-select" autocomplete="off" data-bind="value:totalday ,enable:false"/>
						<span class="input-group-addon">วัน</span>
					</div>
				</div>
			</div>
			 <div class="row form-group">
				<div class="col-sm-offset-2 col-xs-offset-0 col-xs-2 control-label">
					<span>เหตุผล</span>
				</div>
				<div class="col-xs-10 col-sm-6">
					<textarea class="form-control" autocomplete="off" rows="4" data-bind="value:reason,enable:false"></textarea>
				</div>
			</div>
			<div class="row form-group">
				<div class="col-sm-offset-2 col-xs-offset-0 col-xs-2 control-label">
					<span>หมายเลขโทรศัพท์</span>
				</div>
				<div class="col-xs-10 col-sm-6">
					<input type="text" class="form-control" autocomplete="off" data-bind="value:phonenumber,enable:false"/>
				</div>
			</div>
			 <div class="row form-group" data-bind="visible:!isHR()&&isManager()&&!isviewOnly()">
				<div class="col-sm-offset-2 col-xs-offset-0 col-xs-2 control-label">
					<span>เหตุผล (ถ้ามี)</span>
				</div>
				<div class="col-xs-10 col-sm-6">
					<textarea class="form-control" autocomplete="off" rows="4" data-bind="value:taskreason"></textarea>
				</div>
			</div>

			<div class="row form-group">
				<div class="col-xs-12 col-sm-10 text-right" >
					<button class="btn btn-primary" data-bind="visible:!isHR()&&isManager()&&!isviewOnly(),click:SaveTasksClick.bind($data,'Approve') ">Approve</button>
					<button class="btn btn-danger" data-bind="visible:!isHR()&&isManager()&&!isviewOnly(),click: SaveTasksClick.bind($data,'Reject')  ">Reject</button>
					<button class="btn btn-primary" data-bind="visible:ishrForm()&&isHR()&&!isManager()&&!isviewOnly(),click:SaveTasksClick.bind($data,'Approve') ">Acknowledge</button>
					<button class="btn btn-default" data-bind="text:BackToText ,click: $parent.navLinkClick.bind($data,backtoform() )"></button>
				</div>
			</div>
    </script>
	<script type="text/html" id="idwating">
        
    </script>
    <script type="text/html" id="idmyleaveremain">
        <div class="row form-group">
			<div class="col-xs-12">
				<span class="sp-header themeColor">วันลาของฉัน</span>	
			</div>
		</div>
		<div class="row form-group" data-bind="foreach: leavedays ">
				<div class="form-group col-xs-offset-1 col-xs-10 col-sm-offset-1 col-sm-5 col-md-offset-1 col-md-3 text-center">
					<div class="day-header" data-bind="text:Title"></div>
					<div class="day-number themeColor">
						<table>
							<tbody>
								<tr>
									<td class="remain-day" rowspan="3" data-bind="text:$parent.calulateDay($data)"></td>
									<td class="infomax-day" title="Max Days" data-bind="text:MaxLeaveValue"></td>
								</tr>
								<tr>
									<td class="infoapprove-day" title="Approved Days" data-bind="text:MyUseDay.approve"></td>
								</tr>
								<tr>
									<td class="infoinprogress-day" title="Inprogress Days" data-bind="text:MyUseDay.inprogress"></td>
								</tr>
							</tbody>
						</table>
					</div>
				</div>
		</div>
    </script>
	<script type="text/html" id="idhomepage">
        <div class="row form-group">
			<div class="col-xs-12">
				<span class="sp-header themeColor">วันลาคงเหลือ</span>	
			</div>
		</div>
		<div class="row form-group" data-bind="foreach: leavedaysfilter ">
				<div class="form-group col-xs-offset-1 col-xs-10 col-sm-offset-1 col-sm-5 col-md-offset-1 col-md-3 text-center">
					<div class="day-header" data-bind="text:Title"></div>
					<div class="day-number themeColor">
						<table>
							<tbody>
								<tr>
									<td class="remain-day" rowspan="3" data-bind="text:$parent.calulateDay($data)"></td>
									<td class="infomax-day" title="Max Days" data-bind="text:MaxLeaveValue"></td>
								</tr>
								<tr>
									<td class="infoapprove-day" title="Approved Days" data-bind="text:MyUseDay.approve"></td>
								</tr>
								<tr>
									<td class="infoinprogress-day" title="Inprogress Days" data-bind="text:MyUseDay.inprogress"></td>
								</tr>
							</tbody>
						</table>
					</div>
				</div>
		</div>
		<div class="row form-group">
			<div class="col-xs-12">
				<span class="sp-header themeColor">ประวัติการลาล่าสุด</span>	
			</div>			
		</div>
		<div class="row form-group">
			<div class="col-xs-12">
				<table class="table table-bordered">
						<thead class="thead-light">
							<tr>
								<th>วันที่</th>
								<th>จำนวนวัน</th>
								<th>ประเภท</th>
								<th>สถานะ</th>
							</tr>
						</thead>
						<tbody data-bind="foreach: datawithpaging().datas">
							<tr>
								<td><a href="#" data-bind="text:StartDate,click:$parent.goToApproveForm"></a></td>
								<td data-bind="text:NumberOfDay"></td>
								<td data-bind="text:LeaveType"></td>
								<td data-bind="html:$parent.bindStatus($data) "></td>
							</tr>

						</tbody>
					</table>
					<div id="paging" data-bind="visible:datawithpaging().showPaging() && datawithpaging().maxPageIndex() > 1,bs_pagination:datawithpaging().pagingObj,pagingOptions:{maxRowsPerPage:datawithpaging().totalItems(),rowsPerPage:datawithpaging().pageSize(),currentPage:datawithpaging().pageIndex(),eventclick:datawithpaging().gotoPage}"></div>
			</div>
		</div>
    </script>
    <script type="text/html" id="idmyhistory">
    	<div class="row form-group">
			<div class="col-xs-12">
				<span class="sp-header themeColor">ค้นหาประวัติการลา</span>	
			</div>
		</div>

       	<div class="row form-group">
				<div class="col-xs-4 col-sm-2 control-label">
					<span>จากวันที่</span>
				</div>
				<div class="col-xs-8 col-sm-4">
					<div class='input-group date dateTimes'>
						<input type="text"  autocomplete="off" class="form-control" data-bind="datepicker: fromdate,datepickerOptions:{format:dateformate}" /> <span class="input-group-addon"><span class="glyphicon glyphicon-calendar"></span></span>
					</div>
				</div>
				<div class="col-xs-4 col-sm-2 control-label">
					<span>ถึงวันที่</span>
				</div>
				<div class="col-xs-8 col-sm-4">
					<div class='input-group date dateTimes'>
						<input type="text"  autocomplete="off" class="form-control" data-bind="datepicker: todate,datepickerOptions:{format:dateformate,minDate:fromdate()}" /> <span class="input-group-addon"><span class="glyphicon glyphicon-calendar"></span></span>
					</div>
				</div>

		</div>
		<div class="row form-group">
				<div class="col-xs-4 col-sm-2 control-label">
					<span>ประเภทวันลา</span>
				</div>
				<div class="col-xs-8 col-sm-4 bootstrap-customselect">
					<select class="form-control" data-bind="selectedOptions: leavetype,options: leavetypearr,optionsText: 'Title',optionsValue : 'Title', optionsCaption: 'select...',selectPicker: {},selectPickerOptions:{liveSearch:true}"></select>				
				</div>
				<div class="col-xs-12 col-sm-6">
					<button class="btn btn-xs btn-info" data-bind="click:searchClick">Search</button>
				</div>
		</div>
		<div class="row form-group">
			<div class="col-xs-12">
				<span class="sp-header themeColor">ผลการค้นหา</span>	
			</div>
		</div>
		<div class="row form-group" data-bind="visible:issearch">
			<div class="col-xs-12">
				<table class="table table-bordered">
						<thead class="thead-light">
							<tr>
								<th>วันที่</th>
								<th>จำนวนวัน</th>
								<th>ประเภท</th>
								<th>สถานะ</th>
							</tr>
						</thead>
						<tbody data-bind="foreach: datawithpaging().datas">
							<tr>
								<td><a href="#" data-bind="text:StartDate,click:$parent.goToApproveForm"></a></td>
								<td data-bind="text:NumberOfDay"></td>
								<td data-bind="text:LeaveType"></td>
								<td data-bind="text:LeaveStatus"></td>
							</tr>

						</tbody>
						<tbody data-bind="visible: !datawithpaging().ishasdata()" class="text-center">
							<tr>
								<td colspan="5">ไม่พบข้อมูล</td>
							</tr>

						</tbody>

					</table>
				 <div id="paging" data-bind="visible:datawithpaging().showPaging() && datawithpaging().maxPageIndex() > 1,bs_pagination:datawithpaging().pagingObj,pagingOptions:{maxRowsPerPage:datawithpaging().totalItems(),rowsPerPage:datawithpaging().pageSize(),currentPage:datawithpaging().pageIndex(),eventclick:datawithpaging().gotoPage}"></div>

			</div>
		</div>

    </script>
    <script type="text/html" id="idapprove">
        <div class="row form-group">
			<div class="col-xs-12">
				<span class="sp-header themeColor">รายการที่ต้องอนุมัติ</span>	
			</div>
		</div>
        <div class="row form-group">
			<div class="col-xs-12">
				<table class="table table-bordered">
						<thead class="thead-light">
							<tr>
								<th>รายการ</th>
								<th>วันที่</th>
								<th>ชื่อผู้ลา</th>
								<th>จำนวนวัน</th>
								<th>ประเภท</th>
							</tr>
						</thead>
						<tbody data-bind="foreach: datawithpaging().datas">
							<tr>
								<td><a href="#" data-bind="text:Title,click:$parent.goToApproveForm"></a></td>
								<td data-bind="text:StartDate"></td>
								<td data-bind="text:LeaveTitle"></td>
								<td data-bind="text:NumberOfDay"></td>
								<td data-bind="text:LeaveType"></td>
							</tr>

						</tbody>
						<tbody data-bind="visible: !datawithpaging().ishasdata()" class="text-center">
							<tr>
								<td colspan="5">ไม่พบข้อมูล</td>
							</tr>

						</tbody>

					</table>
				<div id="paging" data-bind="visible:datawithpaging().showPaging() && datawithpaging().maxPageIndex() > 1,bs_pagination:datawithpaging().pagingObj,pagingOptions:{maxRowsPerPage:datawithpaging().totalItems(),rowsPerPage:datawithpaging().pageSize(),currentPage:datawithpaging().pageIndex(),eventclick:datawithpaging().gotoPage}"></div>

			</div>
		</div>

    </script>
    <script type="text/html" id="idhrapprove">
        <div class="row form-group">
			<div class="col-xs-12">
				<span class="sp-header themeColor">รายการที่ต้องรับทราบ</span>	
			</div>
		</div>
        <div class="row form-group">
			<div class="col-xs-12">
				<table class="table table-bordered">
						<thead class="thead-light">
							<tr>
								<th>รายการ</th>
								<th>วันที่</th>
								<th>ชื่อผู้ลา</th>
								<th>จำนวนวัน</th>
								<th>ประเภท</th>
							</tr>
						</thead>
						<tbody data-bind="foreach: datawithpaging().datas">
							<tr>
								<td><a href="#" data-bind="text:Title,click:$parent.goToApproveForm"></a></td>
								<td data-bind="text:StartDate"></td>
								<td data-bind="text:LeaveTitle"></td>
								<td data-bind="text:NumberOfDay"></td>
								<td data-bind="text:LeaveType"></td>
							</tr>

						</tbody>
						<tbody data-bind="visible: !datawithpaging().ishasdata()" class="text-center">
							<tr>
								<td colspan="5">ไม่พบข้อมูล</td>
							</tr>

						</tbody>

					</table>
					<div id="paging" data-bind="visible:datawithpaging().showPaging() && datawithpaging().maxPageIndex() > 1,bs_pagination:datawithpaging().pagingObj,pagingOptions:{maxRowsPerPage:datawithpaging().totalItems(),rowsPerPage:datawithpaging().pageSize(),currentPage:datawithpaging().pageIndex(),eventclick:datawithpaging().gotoPage}"></div>

			</div>
		</div>

    </script>

    <script type="text/html" id="idcancel">
       	 
       	 <div class="row form-group">
			<div class="col-xs-12">
				<span class="sp-header themeColor">ยกเลิกการลา</span>	
			</div>
		</div>
		<div class="row form-group">
			<div class="col-xs-12">
				<table class="table table-bordered">
						<thead class="thead-light">
							<tr>
								<th>วันที่</th>
								<th>จำนวนวัน</th>
								<th>ประเภท</th>
								<th>สถานะ</th>
								<th></th>
							</tr>
						</thead>
						<tbody data-bind="foreach: datawithpaging().datas">
							<tr>
								<td data-bind="text:StartDate"></td>
								<td data-bind="text:NumberOfDay"></td>
								<td data-bind="text:LeaveType"></td>
								<td data-bind="text:LeaveStatus"></td>
								<td data-bind="click:$parent.CancelClick"><button class="btn btn-danger btn-xs">ขอยกเลิก</button</td>
							</tr>

						</tbody>
						<tbody data-bind="visible: !datawithpaging().ishasdata()" class="text-center">
							<tr>
								<td colspan="5">ไม่พบข้อมูล</td>
							</tr>

						</tbody>

					</table>
					<div id="paging" data-bind="visible:datawithpaging().showPaging() && datawithpaging().maxPageIndex() > 1,bs_pagination:datawithpaging().pagingObj,pagingOptions:{maxRowsPerPage:datawithpaging().totalItems(),rowsPerPage:datawithpaging().pageSize(),currentPage:datawithpaging().pageIndex(),eventclick:datawithpaging().gotoPage}"></div>

			</div>
		</div>

    </script>
    <script type="text/html" id="idofficerinfo">  
        <div class="row form-group">
			<div class="col-xs-12">
				<span class="sp-header themeColor">ค้นหาข้อมูลการลาของพนักงาน</span>	
			</div>
		</div>
		<div class="row form-group">
				<div class="col-xs-4  col-sm-2 control-label">
					<span>รายชื่อพนักงาน</span>
				</div>
				<div class="col-xs-8 col-sm-10">
					<div id="ppkofficers" data-bind='peoplepicker:officers,peopleOptions:{AllowMultipleValues:true,PeopleorGroup:"ALL",oldvaluetmp:officerstmp}'></div> 
				</div>
			</div>

       	<div class="row form-group">
				<div class="col-xs-4 col-sm-2 control-label">
					<span>จากวันที่</span>
				</div>
				<div class="col-xs-8 col-sm-4">
					<div class='input-group date dateTimes'>
						<input type="text"  autocomplete="off" class="form-control" data-bind="datepicker: fromdate,datepickerOptions:{format:dateformate}" /> <span class="input-group-addon"><span class="glyphicon glyphicon-calendar"></span></span>
					</div>
				</div>
				<div class="col-xs-4 col-sm-2 control-label">
					<span>ถึงวันที่</span>
				</div>
				<div class="col-xs-8 col-sm-4">
					<div class='input-group date dateTimes'>
						<input type="text"  autocomplete="off" class="form-control" data-bind="datepicker: todate,datepickerOptions:{format:dateformate,minDate:fromdate()}" /> <span class="input-group-addon"><span class="glyphicon glyphicon-calendar"></span></span>
					</div>
				</div>

		</div>
		<div class="row form-group">
				<div class="col-xs-4 col-sm-2 control-label">
					<span>ประเภทวันลา</span>
				</div>
				<div class="col-xs-8 col-sm-4 bootstrap-customselect">
					<select class="form-control" data-bind="selectedOptions: leavetype,options: leavetypearr,optionsText: 'Title',optionsValue : 'Title', optionsCaption: 'select...',selectPicker: {},selectPickerOptions:{liveSearch:true}"></select>
				</div>
				<div class="col-xs-12 col-sm-6">
					<button class="btn btn-xs btn-info" data-bind="click:searchClick">Search</button>
				</div>
		</div>

		<div class="row form-group">
			<div class="col-xs-12">
				<span class="sp-header themeColor">ผลการค้นหา</span>	
			</div>
		</div>
		<div class="row form-group" data-bind="visible:issearch">
			<div class="col-xs-12">
				<table class="table table-bordered">
						<thead class="thead-light">
							<tr>
								<th>วันที่</th>
								<th>ชื่อผู้ลา</th>
								<th>จำนวนวัน</th>
								<th>ประเภท</th>
								<th>สถานะ</th>
							</tr>
						</thead>
						<tbody data-bind="foreach: datawithpaging().datas">
							<tr>
								<td><a href="#" data-bind="text:StartDate,click:$parent.goToApproveForm"></a></td>
								<td data-bind="text:Title"></td>
								<td data-bind="text:NumberOfDay"></td>
								<td data-bind="text:LeaveType"></td>
								<td data-bind="text:LeaveStatus"></td>
							</tr>

						</tbody>
						<tbody data-bind="visible: !datawithpaging().ishasdata()" class="text-center">
							<tr>
								<td colspan="4">ไม่พบข้อมูล</td>
							</tr>

						</tbody>

					</table>
					<div id="paging" data-bind="visible:datawithpaging().showPaging() && datawithpaging().maxPageIndex() > 1,bs_pagination:datawithpaging().pagingObj,pagingOptions:{maxRowsPerPage:datawithpaging().totalItems(),rowsPerPage:datawithpaging().pageSize(),currentPage:datawithpaging().pageIndex(),eventclick:datawithpaging().gotoPage}"></div>

			</div>
		</div>

    </script>
    <script type="text/html" id="idsetting">
    	<div class="row form-group">
			<div class="col-xs-offset-0 col-sm-offset-1 col-xs-12 col-sm-3">
				<span class="end-circle-title">วันสิ้นสุดรอบปี</span>
			</div>
			<div class="col-xs-12 col-sm-4">
				<div class='input-group date disableyear'>
						<input type="text"  autocomplete="off" class="form-control" data-bind="datepicker: circledate,enable:circleEnable,datepickerOptions:{format:dateformate,viewMode:'months'}" /> <span class="input-group-addon"><span class="glyphicon glyphicon-calendar"></span></span>
				</div>
			</div>
			<div class="col-xs-12 col-sm-3">
				<button class="btn btn-xs btn-info" data-bind="visible:!circleEnable(),click:enableEdit">Edit</button>
				<button class="btn btn-xs btn-info" data-bind="visible:circleEnable(),click:saveNewDate ">Save</button>
				<button class="btn btn-xs btn-danger" data-bind="visible:circleEnable(),click:disableEdit ">Cancel</button>
			</div>
		</div>
		<div class="row form-group">
			<div class="col-xs-offset-0 col-sm-offset-1 col-xs-12 col-sm-7">
				<div class="panel panel-info">
					<div class="panel-heading text-center">วันทำงาน</div>
					<div class="panel-body form" data-bind="foreach:allday">
						 <label class="col-xs-12 col-md-6 col-lg-4">
						    <input type="checkbox" data-bind="checkedValue: $data, checked: $parent.workingDays,enable:$parent.workingEnable"/>
						    <span data-bind="text:$data"></span>
						  </label>
					</div>
				</div>
			</div>
			<div class="col-xs-12 col-sm-4">
				<button class="btn btn-xs btn-info" data-bind="visible:!workingEnable(),click:enableWorkingEdit ">Edit</button>
				<button class="btn btn-xs btn-info" data-bind="visible:workingEnable(),click:saveNewWorkingDate ">Save</button>
				<button class="btn btn-xs btn-danger" data-bind="visible:workingEnable(),click:disableWorkingEdit ">Cancel</button>
			</div>
		</div>
        <div class="row form-group" data-bind="foreach:NavLinkArr">
			<div class="col-xs-12 col-sm-6">
				<div class="setting-box">
					<a target="_blank" data-bind="attr:{href:url}">
						<table>
							<tbody>
								<tr>
									<td><i class="glyphicon icon-setting" data-bind="css: icon"></i></td>
									<td><span data-bind="text:title"></span></td>
								</tr>
							</tbody>
						</table>					
					</a>
				</div>
			</div>
		</div>
		
    </script>
    <script type="text/html" id="idbiginingwating"> 
		<div class="row form-group">
			<div class="col-xs-12 col-sm-6">
				<div class='input-group'>
					<span class="input-group-addon"><span class="glyphicon" data-bind="css:(currentStep()>1?'glyphicon-ok-circle':'')"></span></span>
					<button class="btn btn-primary form-control" data-bind="enable:createStep,click:CreateListClick">สร้าง List</button>					
				</div>				
			</div>
		</div>
		<div class="row form-group">
			<div class="col-xs-12 col-sm-6">
				<div class='input-group'>
					<span class="input-group-addon"><span class="glyphicon" data-bind="css:(currentStep()>2?'glyphicon-ok-circle':'')"></span></span>
					<button class="btn btn-primary form-control" data-bind="enable:featureStep ,click:ActivateFeatureClick ">Activate Feature</button>					
				</div>	
			</div>
		</div>
		<div class="row form-group">
			<div class="col-xs-12 col-sm-6">
				<div class='input-group'>
					<span class="input-group-addon"><span class="glyphicon" data-bind="css:(currentStep()>3?'glyphicon-ok-circle':'')"></span></span>
					<button class="btn btn-primary form-control" data-bind="enable:foundworkflowStep ,click:CloneWorkflowClick ">Update/Clone Workflow (ทำซ้ำได้)</button>					
				</div>	
			</div>
		</div>
		<div class="row form-group">
			<div class="col-xs-12 col-sm-6">
				<div class='input-group'>
					<span class="input-group-addon"><span class="glyphicon" data-bind="css:(currentStep()>4?'glyphicon-ok-circle':'')"></span></span>
					<button class="btn btn-primary form-control" data-bind="enable:mapWorkflowStep,click:MappingWorkflowClick ">ผูก Workflow กับ List</button>					
				</div>	
			</div>
		</div>
		<div class="row form-group">
			<div class="col-xs-12 col-sm-6">
				<div class='input-group'>
					<span class="input-group-addon"></span>
					<button class="btn btn-danger form-control" data-bind="enable:deleteStep,click:DeleteListClick ">ลบ List/Workflow</button>					
				</div>	
			</div>
		</div>
    </script>

    	 <div  id="LeaveRequestContent">
	         <div class="col-xs-12 header themeColor">
	                <div class="container">
	                    <h2 class="txtheader">ยินดีต้อนรับ  <span data-bind="text:userdisplayName"></span></h2>
	                </div>
	         </div>
	        <div class="col-xs-12 contentblock" >
	            <div class="container">
	            		<div class="newleave">
	                    		<ul class="list-group" data-bind="visible:!notPermisson()">
	                    			<li class="list-group-item" data-bind="css: { 'active': checkLinkActive('idnewleaveform') }, click: navLinkClick.bind($data, 'idnewleaveform')">
	                                	<i class="glyphicon glyphicon-plus icon-nav"></i><span>  สร้างแบบฟอร์มการลา</span>
	                                </li>
	                    		</ul>
	                    </div>
	
	                    <div class="contentdata">
	                        <div class="leftnav">
	                            <ul class="list-group" data-bind="foreach:NavLinkArr ">
	                                <li class="list-group-item" data-bind="visible:isvisible,css: { 'active': $parent.checkLinkActive(template) }, click: $parent.navLinkClick.bind($data, template)">
	                                	<i class="glyphicon icon-nav" data-bind="css: icon"></i><span data-bind="text:title"></span>
	                                </li>
	                            </ul>
	                        </div>
	                        <div class="rightcontent">
	                        	<div class="panel panel-default">
						        	<div class="panel-heading"></div>
						        	<div class="panel-body" style="position:relative;">
						        		<div id="contentloading" class="sk-circle-block" style="display:none;">
							        		<div class="sk-circle">
											  <div class="sk-circle1 sk-child"></div>
											  <div class="sk-circle2 sk-child"></div>
											  <div class="sk-circle3 sk-child"></div>
											  <div class="sk-circle4 sk-child"></div>
											  <div class="sk-circle5 sk-child"></div>
											  <div class="sk-circle6 sk-child"></div>
											  <div class="sk-circle7 sk-child"></div>
											  <div class="sk-circle8 sk-child"></div>
											  <div class="sk-circle9 sk-child"></div>
											  <div class="sk-circle10 sk-child"></div>
											  <div class="sk-circle11 sk-child"></div>
											  <div class="sk-circle12 sk-child"></div>
											</div>		
										</div>					        		
			                            <div data-bind="template: { name: selectTemplate,data:selectModel() }"></div>
						        	</div>
						        </div>
	                        </div>
	                    </div>               
	            </div>	   			
	        </div>
            <div class="col-xs-12 footer themeColor">
                <div class="container">
                    <span class="txtfooter">Copyright © 2015 Tora Asia (Thailand) Co., Ltd. All rights reserved.</span>
                </div>
            </div>
	</div>
</asp:Content>
