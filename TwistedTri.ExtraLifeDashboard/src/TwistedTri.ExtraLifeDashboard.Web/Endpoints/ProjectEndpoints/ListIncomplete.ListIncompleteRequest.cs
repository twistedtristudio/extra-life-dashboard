using Microsoft.AspNetCore.Mvc;

namespace TwistedTri.ExtraLifeDashboard.Web.Endpoints.ProjectEndpoints
{
    public class ListIncompleteRequest
    {
        [FromRoute]
        public int ProjectId { get; set; }
        [FromQuery]
        public string? SearchString { get; set; }
    }
}