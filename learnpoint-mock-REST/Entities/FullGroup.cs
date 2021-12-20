using System.Collections.Generic;

namespace learnpoint_mock_REST.Entities
{
    public class FullGroup : Group
    {
        public CourseDefinitionReference CourseDefinition { get; set; }
        public IEnumerable<GroupStaffMember> StaffGroupMembers { get; set; }
        public IEnumerable<GroupStudent> StudentGroupMembers { get; set; }
    }
}
