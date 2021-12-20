using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace learnpoint_mock_REST.Entities
{
    public class GroupsApiResponse
    {
        [Key]
        public int Id { get; set; }
        public string ApiVersion { get; set; }
        public GroupsData Data { get; set; }
        public ApiError Error { get; set; }
    }
}
