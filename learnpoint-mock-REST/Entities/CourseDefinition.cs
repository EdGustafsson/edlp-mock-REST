using System;
using System.Collections.Generic;
using System.Text;

namespace learnpoint_mock_REST.Entities
{
    public class CourseDefinition
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool IsInternship { get; set; }
    }
}
