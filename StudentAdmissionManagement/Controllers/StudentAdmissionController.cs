//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace StudentAdmissionManagement.Controllers
//{

//    [ApiController]
//    [Route("api/[controller]")]
//    public class StudentAdmissionController : Controller
//    {
//        [HttpGet]
//        public IEnumerable<StudentAdmissionDetailsModel> Get()
//        {
//            StudentAdmissionDetailsModel admObj1 = new StudentAdmissionDetailsModel();
//            StudentAdmissionDetailsModel admObj2 = new StudentAdmissionDetailsModel();

//            admObj1.StudentID = 1;
//            admObj1.StudentName = "Adam";
//            admObj1.StudentClass = "X";
//            admObj1.DateOfJoining = DateTime.Now;

//            admObj2.StudentID = 2;
//            admObj2.StudentName = "Brad";
//            admObj2.StudentClass = "IX";
//            admObj2.DateOfJoining = DateTime.Now;

//            List<StudentAdmissionDetailsModel> listOfObj = new List<StudentAdmissionDetailsModel> { admObj1, admObj2 };

//            return listOfObj;
//        }

//    }
//}

using Microsoft.AspNetCore.Mvc;
namespace StudentAdmissionManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAdmissionController : ControllerBase
    {
        // GET: api/<StudentAdmissionController>
        [HttpGet]
        public IEnumerable<StudentAdmissionDetailsModel> Get()
        {
            StudentAdmissionDetailsModel admissionobj1 = new StudentAdmissionDetailsModel();
            StudentAdmissionDetailsModel admissionobj2 = new StudentAdmissionDetailsModel();

            admissionobj1.StudentID = 1;
            admissionobj1.StudentName = "Adam";
            admissionobj1.StudentClass = "X";
            admissionobj1.DateOfJoining = DateTime.Now;

            admissionobj2.StudentID = 2;
            admissionobj2.StudentName = "Brad";
            admissionobj2.StudentClass = "IX";
            admissionobj2.DateOfJoining = DateTime.Now;
            List<StudentAdmissionDetailsModel> listofobj = new List<StudentAdmissionDetailsModel>
            {
                admissionobj1,
                admissionobj2
            };
            return listofobj;
        }
    }
}