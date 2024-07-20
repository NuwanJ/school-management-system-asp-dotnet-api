//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using StudentAttendenceManagement;

//namespace StudentAttendenceManagement.Controllers
//{
//    [ApiController]
//    [Route("api/[controller]")]
//    public class StudentAttendanceController : ControllerBase
//    {
//        [HttpGet]
//        public IEnumerable<StudentAttendanceDetailsModel> Get()
//        {
//            StudentAttendanceDetailsModel atdObj1 = new StudentAttendanceDetailsModel();
//            StudentAttendanceDetailsModel atdObj2 = new StudentAttendanceDetailsModel();

//            atdObj1.StudentID = 1;
//            atdObj1.StudentName = "Adam";
//            atdObj1.AttendencePercentage = 83.2;


//            atdObj2.StudentID = 2;
//            atdObj2.StudentName = "Brad";
//            atdObj2.AttendencePercentage = 71.02;

//            List<StudentAttendanceDetailsModel> listOfObj = new List<StudentAttendanceDetailsModel> { atdObj1, atdObj2 };

//            return listOfObj;
//        }

//    }
//}


//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;


using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentAttendenceManagement;

namespace StudentAttendanceManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAttendanceController : ControllerBase
    {
        // GET: api/<StudentAttendanceController>
        [HttpGet]
        public IEnumerable<StudentAttendanceDetailsModel> Get()
        {
            StudentAttendanceDetailsModel attendanceObj1 = new StudentAttendanceDetailsModel();
            StudentAttendanceDetailsModel attendanceObj2 = new StudentAttendanceDetailsModel();

            attendanceObj1.StudentID = 1;
            attendanceObj1.StudentName = "Adam";
            attendanceObj1.AttendencePercentage = 83.02;

            attendanceObj2.StudentID = 2;
            attendanceObj2.StudentName = "Brad";
            attendanceObj2.AttendencePercentage = 71.02;

            List<StudentAttendanceDetailsModel> listObj = new List<StudentAttendanceDetailsModel>
            {
                attendanceObj1,
                attendanceObj2
            };
            return listObj;
        }
    }
}