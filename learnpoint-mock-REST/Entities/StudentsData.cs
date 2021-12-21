using System.Collections.Generic;

namespace learnpoint_mock_REST.Entities
{
    public class StudentsData
    {
        public IEnumerable<FullStudent> Students { get; set; }
        public StudentsReferenceData ReferenceData { get; set; }
    }
}
