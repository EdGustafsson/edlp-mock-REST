using System.Collections.Generic;

namespace learnpoint_mock_REST.Entities
{
    public class StaffMemberGroup
    {
        public GroupReference Group { get; set; }
        public bool IsGroupManager { get; set; }
        public IEnumerable<GroupRoleReference> GroupRoles { get; set; }
    }
}
