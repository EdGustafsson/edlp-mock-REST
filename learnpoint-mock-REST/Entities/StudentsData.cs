using System;
using System.Collections.Generic;
using System.Text;

namespace learnpoint_mock_REST.Entities
{
    public class StudentsData
    {
        public int Id { get; set; }
        public IEnumerable<FullStudent> Students { get; set; }
        public StudentsReferenceData ReferenceData { get; set; }
    }
}
