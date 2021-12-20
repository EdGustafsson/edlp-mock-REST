using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace learnpoint_mock_REST.Entities
{
    public class GroupStudent
    {
        [Key]
        public int Id { get; set; }
        public StudentReference Student { get; set; }
        public IEnumerable<GroupRoleReference> GroupRoles { get; set; }
    }
}
