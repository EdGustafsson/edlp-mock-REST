
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace learnpoint_mock_REST.Entities
{
    public class ApiError
    {
        [Key]
        public int Id { get; set; }
        public string Message { get; set; }
    }
}
