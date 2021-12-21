using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace learnpoint_mock_REST.Controllers
{
    [ApiController]
    [Route("api/groups")]
    public class GroupsApiResponsesController : ControllerBase
    {
        [HttpGet]
        public string GetGroups()
        {
            using (StreamReader r = new StreamReader("Data/jsonGroups.json"))
            {
                string json = r.ReadToEnd();
                return json;
            }
        }
    }
}
