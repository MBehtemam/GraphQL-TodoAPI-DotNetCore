using System;
using GraphQL.Types;
using GraphQL;
using TodoAPI.Data;
namespace TodoAPI.Models
{
    public class TodoQuery : ObjectGraphType
    {
        public TodoQuery(ITodoRepository todoRepository)
        {
            Field<TodoType>("todo", arguments: new QueryArguments(
                new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "id", Description = "id of todo" }
            ),
            resolve: context => todoRepository.GetTodoById(context.GetArgument<int>("id")).Result
            );


            Field<ListGraphType<TodoType>>("todos",
            resolve: context => todoRepository.GetTodos().Result
            );
        }
    }
}