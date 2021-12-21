using Microsoft.AspNetCore.Mvc;
using learnpoint_mock_REST.Data;
using learnpoint_mock_REST.Entities;
using System.Threading.Tasks;

namespace learnpoint_mock_REST.Controllers
{
    [ApiController]
    [Route("api/staffmembers")]
    public class StaffMembersApiResponsesController : ControllerBase
    {

        private readonly DataContext _context;

        public StaffMembersApiResponsesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<StaffMembersApiResponse>> GetGroups()
        {
            StaffMembersApiResponse asdf = new StaffMembersApiResponse();

            return await _context.StaffMembersApiResponses.FindAsync();
        }

    }

}
