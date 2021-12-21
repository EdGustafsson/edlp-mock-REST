using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace learnpoint_mock_REST.Controllers
{
    [ApiController]
    [Route("api/staffmembers")]
    public class StaffMembersApiResponsesController : ControllerBase
    {
        [HttpGet]
        public string GetStaffMembers()
        {
            using (StreamReader r = new StreamReader("Data/jsonStaffMembers.json"))
            {
                string json = r.ReadToEnd();
                return json;
            }
        }

    }

}
