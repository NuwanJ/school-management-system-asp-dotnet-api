using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentAdmissionManagement.Data;

namespace StudentAdmissionManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAdmissionController : ControllerBase
    {
        private readonly MyApiServiceContext _context;

        public StudentAdmissionController(MyApiServiceContext context)
        {
            _context = context;
        }

        // GET: api/admissions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StudentAdmissionDetailsModel>>> GetAllAdmissions()
        {
            //StudentAdmissionDetailsModel admissionobj1 = new StudentAdmissionDetailsModel();
            //StudentAdmissionDetailsModel admissionobj2 = new StudentAdmissionDetailsModel();

            //admissionobj1.StudentID = 1;
            //admissionobj1.StudentName = "Adam";
            //admissionobj1.StudentClass = "X";
            //admissionobj1.DateOfJoining = DateTime.Now;

            //admissionobj2.StudentID = 2;
            //admissionobj2.StudentName = "Brad";
            //admissionobj2.StudentClass = "IX";
            //admissionobj2.DateOfJoining = DateTime.Now;
            //List<StudentAdmissionDetailsModel> listofobj = new List<StudentAdmissionDetailsModel>
            //{
            //    admissionobj1,
            //    admissionobj2
            //};
            //return listofobj;
            return await _context.Admissions.ToListAsync();
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StudentAdmissionDetailsModel>> GetAdmissionRecord(int id)
        {
            var admissionRecord = await _context.Admissions.FindAsync(id);

            if (admissionRecord == null)
            {
                return NotFound();
            }

            return admissionRecord;
        }

        // POST: api/Products
        [HttpPost]
        public async Task<ActionResult<StudentAdmissionDetailsModel>> PostProduct(StudentAdmissionDetailsModel admissionRecord)
        {
            _context.Admissions.Add(admissionRecord);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAdmissionRecord", new { id = admissionRecord.Id }, admissionRecord);
        }

        // PUT: api/Products/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct(int id, StudentAdmissionDetailsModel admissionRecord)
        {
            if (id != admissionRecord.Id)
            {
                return BadRequest();
            }

            _context.Entry(admissionRecord).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AdmissionsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        private bool AdmissionsExists(int id)
        {
            return _context.Admissions.Any(e => e.Id == id);
        }
    }
}