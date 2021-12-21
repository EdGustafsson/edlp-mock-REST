using Microsoft.AspNetCore.Mvc;
using learnpoint_mock_REST.Data;
using learnpoint_mock_REST.Entities;
using System.Threading.Tasks;

namespace learnpoint_mock_REST.Controllers
{
    [ApiController]
    [Route("api/groups")]
    public class GroupsApiResponsesController : ControllerBase
    {

        private readonly DataContext _context;

        public GroupsApiResponsesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<GroupsApiResponse>> GetGroups()
        {
            GroupsApiResponse asdf = new GroupsApiResponse();

            return await _context.GroupsApiResponses.FindAsync();
        }




    }
}
