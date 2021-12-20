using System.Collections.Generic;

namespace learnpoint_mock_REST.Entities
{
    public class StaffMembersData
    {
        public int Id { get; set; }
        public IEnumerable<FullStaffMember> StaffMembers { get; set; }
        public StaffMembersReferenceData ReferenceData { get; set; }
    }
}