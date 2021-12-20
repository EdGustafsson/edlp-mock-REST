using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace learnpoint_mock_REST.Entities
{
    public class ParentGroupReference
    {
        [Key]
        public int Id { get; set; }
        public GroupReference Group { get; set; }
        public ParentGroupReference ParentGroup { get; set; }
    }
}
