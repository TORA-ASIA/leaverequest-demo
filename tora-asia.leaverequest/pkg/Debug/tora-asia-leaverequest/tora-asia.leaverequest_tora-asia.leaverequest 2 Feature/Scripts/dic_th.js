var dic_lang_th = {
	alldays:{
		$0: "อาทิตย์",
		$1: "จันทร์",
		$2: "อังคาร",
		$3: "พุธ",
		$4: "พฤหัสบดี",
		$5: "ศุกร์",
		$6: "เสาร์",
	},
	leavetime:{
		$1: "เช้า",
		$2: "บ่าย",
		$3: "เต็มวัน"
	},
    btn:{
        newform: "สร้างแบบฟอร์มการลา",
        edit: "แก้ไข",
        save: "บันทึก",
        cancel: "ยกเลิก",
        genquota: "สร้างโควต้า"
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
        setting: "ตั้งค่า",
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
        remaintitle: "วันลาคงเหลือ",
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

var dic_swal_lang_th = {
	setting: {
        confirmsave: "ยืนยันการบันทึกข้อมูล?",
        savesuccess: "บันทึกสำเร็จ",
        inputquota: "ใส่ปีที่ต้องการ (ถ้ามี - ไม่ใส่จะยึดปีปัจจุบัน)",
        quotasuccess: "สร้างโควต้าสำเร็จ",
    },
    newleave: {
        confirmsave: "ยืนยันการบันทึกข้อมูล?",
        alertcantyesterday: "ไม่สามารถเลือกวันลาย้อนหลังได้",
        or: "หรือ",
        alertgreater: "{0} วันลาต้องมากกว่า {1} วัน",
        alertlower: "{0} ลาย้อนหลังได้ไม่เกิน {1} วัน",
        maxleave: "จำนวนวันลาเกิน สามารถลาได้สูงสุด {0} วัน",
        cantacrossyear: "ไม่สามารถลาข้ามปีได้",
        leavealreadyexist:"วันที่ลามีในระบบแล้ว",
        leavenotfound:"ไม่พบประเภทวันลา",
        leaveremainnotfound:"ไม่พบวันลาคงเหลือ",
        managernotfound: "ไม่พบผู้อนุมัติ",
        checksubmitsion: "กรอกข้อมูลไม่ครบถ้วน กรุณาตรวจสอบความถูกต้อง",
        savesuccess: "บันทึกสำเร็จ"
    },
    taskapprove: {
        confirmsave: "ยืนยันการ {0} ?",
        tasksuccess: "{0} สำเร็จ",
        confirmcancel: "ยืนยันการยกเลิก?",
        confirmreqcancel: "ยืนยันการยกเลิกคำขอ?",
        taskreqcancelsuccess: "ยกเลิกคำขอสำเร็จ",
        taskcancelsuccess: "ยกเลิกสำเร็จ",
    },
    admin: {
        createlist: "ยืนยันการสร้าง Lists?",
        createlistsuccess: "สร้าง Lists สำเร็จ",
        activatefeature: "ยืนยันการ Activate Feature?",
        activatefeaturesuccess: "Activate Feature สำเร็จ",
        clonewf: "ยืนยันการ update/clone Workflow?",
        clonewfsuccess: "Clone/Update Workflow สำเร็จ",
        mapwf: "ยืนยันการผูก workflow กับ List?",
        mapwfsuccess: "ผูก workflow กับ List สำเร็จ",
        deletelist: "ยืนยันการลบ Lists?",
    }

};