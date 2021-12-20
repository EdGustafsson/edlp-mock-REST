using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace learnpoint_mock_REST.Entities
{
    public class EducationPlan
    {
        [Key]
        public string Code { get; set; }
        public string Name { get; set; }
        public EducationPlanType Type { get; set; }
    }
}
