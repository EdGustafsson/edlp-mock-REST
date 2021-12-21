using System.Collections.Generic;

namespace learnpoint_mock_REST.Entities
{
    public class GroupStudent
    {
        public StudentReference Student { get; set; }
        public IEnumerable<GroupRoleReference> GroupRoles { get; set; }
    }
}
