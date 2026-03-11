using System;
using AspNetCoreIntro.Models.Dto;
using AspNetCoreIntro.Models.Entities;
using AspNetCoreIntro.Models.Repository;

namespace AspNetCoreIntro.Extensions;

public static class TodoItemAsQueryable
{
    extension(TodoItemQueryDto dto)
    {
        public IEnumerable<TodoItem> Query(TodoItemRepository repository)
        {
            var query = repository.Get().AsQueryable();

            if (!string.IsNullOrWhiteSpace(dto.Name))
            {
                query = query.Where(item => item.Name.Contains(dto.Name, StringComparison.OrdinalIgnoreCase));
            }
            if (!string.IsNullOrWhiteSpace(dto.DescriptionContains))
            {
                query = query.Where(item => item.Description.Contains(dto.DescriptionContains, StringComparison.OrdinalIgnoreCase));
            }

            if (dto.From.HasValue)
            {
                query = query.Where(item => item.CreatedAt >= dto.From);
            }
            if (dto.To.HasValue)
            {
                query = query.Where(item => item.CreatedAt <= dto.To);
            }
            if (dto.Complete.HasValue)
            {
                query = query.Where(item => item.Complete == dto.Complete);
            }
            return query;
        }
    }
}
