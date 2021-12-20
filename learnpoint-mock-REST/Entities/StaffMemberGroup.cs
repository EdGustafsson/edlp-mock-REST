using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace learnpoint_mock_REST.Entities
{
    public class StaffMemberGroup
    {
        [Key]
        public int Id { get; set; }
        public GroupReference Group { get; set; }
        public bool IsGroupManager { get; set; }
        public IEnumerable<GroupRoleReference> GroupRoles { get; set; }
    }
}
