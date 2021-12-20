
using System.ComponentModel.DataAnnotations;

namespace learnpoint_mock_REST.Entities
{
    public class EducationPlanType
    {
        [Key]
        public int Id { get; set; }
        public string Code { get; set; }
    }
}
