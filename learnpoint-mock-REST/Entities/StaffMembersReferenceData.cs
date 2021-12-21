using System.Collections.Generic;

namespace learnpoint_mock_REST.Entities
{
    public class StaffMembersReferenceData
    {
        public IEnumerable<Group> Groups { get; set; }
        public IEnumerable<GroupRole> GroupRoles { get; set; }
    }
}