using System;
using GraphQL.Types;
using TodoAPI.Data;
namespace TodoAPI.Models
{
    class TodoType : ObjectGraphType<Todo>
    {
        public TodoType(ITodoRepository todoRepository)
        {
            Field(x => x.Id).Description("Id of Todo");
            Field(x => x.Title).Description("Title of todo");
            Field(x => x.Completed).Description("Is Todo Completed");
        }
    }
}