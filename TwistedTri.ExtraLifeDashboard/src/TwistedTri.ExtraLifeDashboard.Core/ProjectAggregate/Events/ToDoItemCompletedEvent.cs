using TwistedTri.ExtraLifeDashboard.Core.ProjectAggregate;
using TwistedTri.ExtraLifeDashboard.SharedKernel;

namespace TwistedTri.ExtraLifeDashboard.Core.ProjectAggregate.Events
{
    public class ToDoItemCompletedEvent : BaseDomainEvent
    {
        public ToDoItem CompletedItem { get; set; }

        public ToDoItemCompletedEvent(ToDoItem completedItem)
        {
            CompletedItem = completedItem;
        }
    }
}