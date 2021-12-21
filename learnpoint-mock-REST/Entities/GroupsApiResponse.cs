namespace learnpoint_mock_REST.Entities
{
    public class GroupsApiResponse
    {
        public string ApiVersion { get; set; }
        public GroupsData Data { get; set; }
        public ApiError Error { get; set; }
    }
}
