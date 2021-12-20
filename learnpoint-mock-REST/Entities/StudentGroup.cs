using System;
using System.Collections.Generic;
using System.Text;

namespace learnpoint_mock_REST.Entities
{
    public class StudentGroup
    {
        public GroupReference Group { get; set; }
        public IEnumerable<GroupRoleReference> GroupRoles { get; set; }
    }
}
