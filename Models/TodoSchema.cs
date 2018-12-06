using System;
using GraphQL;
using GraphQL.Types;

namespace TodoAPI.Models
{
    public class TodoSchema : Schema
    {
        public TodoSchema(Func<Type, GraphType> resolveType)
            : base(resolveType)
        {
            Query = (TodoQuery)resolveType(typeof(TodoQuery));
        }
    }
}
