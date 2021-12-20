using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace learnpoint_mock_REST.Entities
{
    public class GroupStaffMember
    {
        [Key]
        public int Id { get; set; }
        public StaffMemberReference StaffMember { get; set; }
        public bool IsGroupManager { get; set; }
        public IEnumerable<GroupRoleReference> GroupRoles { get; set; }
    }
}
