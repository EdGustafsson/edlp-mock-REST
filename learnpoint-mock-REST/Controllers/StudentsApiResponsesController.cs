using Microsoft.AspNetCore.Mvc;
using learnpoint_mock_REST.Entities;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Json;

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
        public string GetStudents()
        {
            //return await _context.StudentsApiResponses.FindAsync();

            //if (await _context.StudentsApiResponses.AnyAsync()) return;

            //return File.ReadAllTextAsync("Data/jsonStudents.json");
            //var studentsApiResponses = JsonSerializer.Deserialize<List<StudentsApiResponse>>(studentsData)

            //StreamReader r = new StreamReader("Data/jsonStudents.json");
            //var a =  r.ReadToEnd();

            //return studentsApiResponses;

            //return Json(a);

            using (StreamReader r = new StreamReader("Data/jsonStudents.json"))
            {
                string json = r.ReadToEnd();
                return json;
            }
        }
    }
}
