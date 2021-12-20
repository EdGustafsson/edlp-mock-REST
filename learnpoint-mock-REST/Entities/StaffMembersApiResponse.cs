using System.ComponentModel.DataAnnotations;

namespace learnpoint_mock_REST.Entities
{
    public class StaffMembersApiResponse
    {
        [Key]
        public int Id { get; set; }
        public string ApiVersion { get; set; }
        public StaffMembersData Data { get; set; }
        public ApiError Error { get; set; }
    }
}
