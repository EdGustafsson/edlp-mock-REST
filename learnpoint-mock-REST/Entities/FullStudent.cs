using System;
using System.Collections.Generic;
using System.Text;

namespace learnpoint_mock_REST.Entities
{
    public class FullStudent : Student
    {
        public IEnumerable<StudentGroup> Groups { get; set; }
        public IEnumerable<StudentEducationPlan> EducationPlans { get; set; }
    }
}
