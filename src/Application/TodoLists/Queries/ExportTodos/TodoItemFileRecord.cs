using NextGen.Application.Common.Mappings;
using NextGen.Domain.Entities;

namespace NextGen.Application.TodoLists.Queries.ExportTodos
{
    public class TodoItemRecord : IMapFrom<TodoItem>
    {
        public string Title { get; set; }

        public bool Done { get; set; }
    }
}
