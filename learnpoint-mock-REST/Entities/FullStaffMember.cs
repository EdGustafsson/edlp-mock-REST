using System.Collections.Generic;

namespace learnpoint_mock_REST.Entities
{
    public class FullStaffMember : StaffMember
    {
        public IEnumerable<StaffMemberGroup> Groups { get; set; }
    }
}
