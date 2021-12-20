using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace learnpoint_mock_REST.Entities
{
    public class GroupCategory
    {
        [Key]
        public string Name { get; set; }
        public string Code { get; set; }
    }
}
