var dic_lang_en = {
	alldays:{
		$0: "Sunday",
		$1: "Monday",
		$2: "Tuesday",
		$3: "Wednesday",
		$4: "Thursday",
		$5: "Friday",
		$6: "Saturday",
	},
	leavetime:{
		$1: "Morning",
		$2: "Afternoon",
		$3: "Full day"
	},
    btn:{
        newform: "New"
    },
    form:{
        totals:"วันลาคงเหลือ"
    },
    leftmenu: {
        home: "หน้าหลัก",
        myleave: "วันลาของฉัน",
        myleavehis: "ประวัติการลา",
        approve: "อนุมัติการลา",
        leavehis: "ข้อมูลการลาของพนักงาน",
        nopermis: "ไม่มีสิทธิ์ใช้งาน",
        setting: "Settings",
        beginsetting: "ตั้งค่าเริ่มต้น (site collection admin)"
    },
    tableheader:{
        date: "วันที่",
        days: "จำนวนวัน",
        types: "ประเภท",
        status: "สถานะ",
        user: "ชื่อผู้ลา",
        list: "รายการ",
        nodata: "ไม่พบข้อมูล"
    },
    heading: {
        remaintitle: "Leave Remain",
        historytitle: "ประวัติการลาล่าสุด",
        approvetitle: "รายการที่ต้องอนุมัติ",
        accepttitle: "รายการที่ต้องรับทราบ",
        searchusertitle: "ค้นหาข้อมูลการลาของพนักงาน",
        searchresult: "ผลการค้นหา",
        searchhistorytitle: "ค้นหาประวัติการลา",
    },
    searchleave: {
        myleavetitle: "วันลาของฉัน",
        searchresult: "ผลการค้นหา",
        fromdate: "จากวันที่",
        todate: "ถึงวันที่",
        type: "ประเภทวันลา",
        officername: "รายชื่อพนักงาน"
    },
    setting: {
        setlanguage: "เลือกภาษา",
        endcircle: "วันสิ้นสุดรอบปี",
        workday: "วันทำงาน",
        calwork: "คำนวณวันทำงาน",
        addform: "ตั้งค่าประเภทการลา",
        adduser: "ตั้งค่าข้อมูลพนักงาน",
        leavehdd: "พื้นที่จัดเก็บการลา",
        holiday: "ตั้งค่าวันหยุดประจำปี",
        quota: "พื้นที่จัดเก็บโควต้า",
        runingformat: "ตั้งค่ารูปแบบ",
    },
    admin: {
        btn: {
            createlist: "สร้าง List",
            ativatefeature: "Activate Feature",
            clonewf: "Update/Clone Workflow (ทำซ้ำได้)",
            mappingwftolist: "ผูก Workflow กับ List",
            deletelist: "ลบ List/Workflow",
        }
    },
    EmailText:{
        TitleManager1:"{0} : แจ้งการขอพิจารณาอนุมัติการลา",
        TitleManager2:"{0} : แจ้งการขอพิจารณาอนุมัติยกเลิกการลา",
        BodyManager1:"กรุณาพิจารณา การลา {0} เป็นจำนวน {1} วัน ของ {2}",
        BodyManager2:"กรุณาพิจารณา ยกเลิกการลา {0} เป็นจำนวน {1} ของ {2}",
        TitleRequester1:"{0} : แจ้งผลการขออนุมัติการลา",
        TitleRequester2:"{0} : แจ้งผลการขออนุมัติยกเลิกการลา",
        BodyRequester1:"ตามที่ท่านได้ขออนุมัติการลา {0} เป็นจำนวน {1} วัน มีผลการพิจารณา คือ",
        BodyRequester2:"ตามที่ท่านได้ขออนุมัติยกเลิกการลา {0} เป็นจำนวน {1} วัน มีผลการพิจารณา คือ",
        TitleHr1:"Review - {0} : แจ้งผลการขออนุมัติการลา",
        TitleHr2:"Review - {0} : แจ้งผลการขออนุมัติยกเลิกการลา",
        BodyHr1:"ตามที่ {0} ได้ขออนุมัติการลา {1} เป็นจำนวน {2} วัน มีผลการพิจารณา คือ",
        BodyHr2:"ตามที่ {0} ได้ขออนุมัติยกเลิกการลา {1} เป็นจำนวน {2} วัน มีผลการพิจารณา คือ",
    }
};

var dic_swal_lang_en = {
	setting: {
        confirmsave: "Are you sure to Save Date?",
        savesuccess: "Save Success"
    },
    newleave: {
        confirmsave: "Are you sure to Save Date?",
        alertcantyesterday: "ไม่สามารถเลือกวันลาย้อนหลังได้",
        or: "หรือ",
        alertgreater: "{0} วันลาต้องมากกว่า {1} วัน",
        alertlower: "{0} ลาย้อนหลังได้ไม่เกิน {1} วัน",
        maxleave: "จำนวนวันลาเกิน สามารถลาได้สูงสุด {0} วัน",
        cantacrossyear: "ไม่สามารถลาข้ามปีได้",
        leavealreadyexist:"วันที่ลามีในระบบแล้ว",
        leavenotfound:"ไม่พบประเภทวันลา",
        leaveremainnotfound:"ไม่พบวันลาคงเหลือ",
        managernotfound: "Manager Not Found",
        checksubmitsion: "Please check your submission.",
        savesuccess: "Save Success"
    },
    taskapprove: {
        confirmsave: "Are you sure to {0} ?",
        tasksuccess: "{0} success.",
        confirmcancel: "Are you sure to Cancel?",
        confirmreqcancel: "Are you sure to Request Cancel?",
        taskreqcancelsuccess: "Request Cancel Success",
        taskcancelsuccess: "Cancel Success",
    },
    admin: {
        createlist: "Are you sure to create Lists?",
        createlistsuccess: "Create List Success",
        activatefeature: "Are you sure to Activate Feature?",
        activatefeaturesuccess: "Activate Feature Success",
        clonewf: "Are you sure to update/clone Workflow?",
        clonewfsuccess: "Clone/Update Workflow Success",
        mapwf: "Are you sure to mapping Workflow?",
        mapwfsuccess: "Add workflow to List Success",
        deletelist: "Are you sure to delete Lists?",
    }

};