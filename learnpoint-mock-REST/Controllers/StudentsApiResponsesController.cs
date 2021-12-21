using Microsoft.AspNetCore.Mvc;
using learnpoint_mock_REST.Entities;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

namespace learnpoint_mock_REST.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class StudentsApiResponsesController : ControllerBase
    {

        //private readonly DataContext _context;

        //public StudentsApiResponsesController(DataContext context)
        //{
        //    _context = context;
        //}

        [HttpGet]
        public async Task<ActionResult<StudentsApiResponse>> GetGroups()
        {
            //return await _context.StudentsApiResponses.FindAsync();

            //if (await _context.StudentsApiResponses.AnyAsync()) return;

            var studentsData = await File.ReadAllTextAsync("Data/jsonStudents.json");
            var studentsApiResponses = JsonSerializer.Deserialize<List<StudentsApiResponse>>(studentsData);

            return Json(model, JsonRequestBehavior.AllowGet);
        }
    }
}
