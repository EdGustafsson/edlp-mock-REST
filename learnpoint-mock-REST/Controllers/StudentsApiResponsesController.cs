using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace learnpoint_mock_REST.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class StudentsApiResponsesController : ControllerBase
    {
        [HttpGet]
        public string GetStudents()
        {
            using (StreamReader r = new StreamReader("Data/jsonStudents.json"))
            {
                string json = r.ReadToEnd();
                return json;
            }
        }
    }
}
