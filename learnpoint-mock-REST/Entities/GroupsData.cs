using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace learnpoint_mock_REST.Entities
{
    public class GroupsData
    {
        [Key]
        public int Id { get; set; }
        public IEnumerable<FullGroup> Groups { get; set; }
        public IEnumerable<FullGroup> ParentGroups { get; set; }
        public GroupsReferenceData ReferenceData { get; set; }

        public class GroupsReferenceData
        {
            [Key]
            public int Id { get; set; }
            public IEnumerable<StaffMember> StaffMembers { get; set; }
            public IEnumerable<Student> Students { get; set; }
            public IEnumerable<CourseDefinition> CourseDefinitions { get; set; }
            public IEnumerable<GroupRole> GroupRoles { get; set; }
        }
    }
}
