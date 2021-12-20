
using System;

namespace learnpoint_mock_REST.Entities
{
    public class StudentEducationPlanState
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActiveStudent { get; set; }
        public DateTime? FromDate { get; set; }
    }
}
