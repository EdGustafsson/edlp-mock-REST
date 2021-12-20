using System;
using System.Collections.Generic;
using System.Text;

namespace learnpoint_mock_REST.Entities
{
    public class StudentEducationPlan
    {
        public int Id { get; set; }
        public IEnumerable<EducationPlan> Parts { get; set; }
        public StudentEducationPlanState State { get; set; }
    }
}
