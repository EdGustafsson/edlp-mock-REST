using System;

namespace learnpoint_mock_REST.Entities
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public DateTime? LifespanFrom { get; set; }
        public DateTime? LifespanUntil { get; set; }
        public GroupCategory Category { get; set; }
        public ParentGroupReference ParentGroup { get; set; }
    }
}
