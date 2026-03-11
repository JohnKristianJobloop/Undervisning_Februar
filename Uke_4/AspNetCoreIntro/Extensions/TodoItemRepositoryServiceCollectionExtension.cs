using System;
using AspNetCoreIntro.Models.Repository;

namespace AspNetCoreIntro.Extensions;

public static class TodoItemRepositoryServiceCollectionExtension
{
    extension(IServiceCollection collection)
    {
        public IServiceCollection AddTodoItemRepository()
        {
            collection.AddSingleton<TodoItemRepository>();
            return collection;
        }
    }
}
