using System.Collections.Generic;

namespace learnpoint_mock_REST.Entities
{
    public class StaffMembersData
    {
        public IEnumerable<FullStaffMember> StaffMembers { get; set; }
        public StaffMembersReferenceData ReferenceData { get; set; }
    }
}