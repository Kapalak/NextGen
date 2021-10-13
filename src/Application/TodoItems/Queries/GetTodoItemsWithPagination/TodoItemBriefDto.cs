using NextGen.Application.Common.Mappings;
using NextGen.Domain.Entities;

namespace NextGen.Application.TodoItems.Queries.GetTodoItemsWithPagination
{
    public class TodoItemBriefDto : IMapFrom<TodoItem>
    {
        public int Id { get; set; }

        public int ListId { get; set; }

        public string Title { get; set; }

        public bool Done { get; set; }
    }
}
