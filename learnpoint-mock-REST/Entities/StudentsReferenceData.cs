using System.Collections;
using System.Collections.Generic;

namespace learnpoint_mock_REST.Entities
{
    public class StudentsReferenceData
    {
        public int Id { get; set; }
        public IEnumerable<Group> Groups { get; set; }
    }
}