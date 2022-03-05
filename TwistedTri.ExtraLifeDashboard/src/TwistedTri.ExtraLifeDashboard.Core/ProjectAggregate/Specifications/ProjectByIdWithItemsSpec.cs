using Ardalis.Specification;
using TwistedTri.ExtraLifeDashboard.Core.ProjectAggregate;

namespace TwistedTri.ExtraLifeDashboard.Core.ProjectAggregate.Specifications
{
    public class ProjectByIdWithItemsSpec : Specification<Project>, ISingleResultSpecification
    {
        public ProjectByIdWithItemsSpec(int projectId)
        {
            Query
                .Where(project => project.Id == projectId)
                .Include(project => project.Items);
        }
    }
}