using System;
using AspNetCoreIntro.Models.Dto;
using AspNetCoreIntro.Models.Entities;

namespace AspNetCoreIntro.Models.Repository;

public class TodoItemRepository
{
    private List<TodoItem> _todoItems = [];

    public IEnumerable<TodoItem> Get() => _todoItems;
    public TodoItem? Get(Guid id) => _todoItems.FirstOrDefault(item => item.Id == id);
    //Mangler validering, bør refaktores.
    //Her kan vi potensielt ende opp, med to items med samme ID. 
    //Vi leverer heller ikke fra oss resultat om arbeid OK eller ikke. 
    public TodoItem AddItem(CreateTodoItemDto item){
        if (string.IsNullOrWhiteSpace(item.Name)) throw new ArgumentNullException(nameof(item.Name));
        if (string.IsNullOrWhiteSpace(item.Description)) throw new ArgumentNullException(nameof(item.Description));
        var newItem = new TodoItem
        {
            Id = Guid.NewGuid(),
            Name = item.Name,
            Description = item.Description,
            CreatedAt = DateTime.UtcNow,
        };
        _todoItems.Add(newItem);
        return newItem;
        }

    public TodoItem Put(TodoItem item)
    {
        var existing = _todoItems.FirstOrDefault(i => i.Id == item.Id);
        if (existing is null)
        {
            _todoItems.Add(item);
            return item;
        }
        _todoItems.Remove(existing);
        _todoItems.Add(item);
        return item;
    }

    public void Delete(Guid id)
    {
        var existing = _todoItems.FirstOrDefault(item => item.Id == id);
        if (existing is null) return;
        _todoItems.Remove(existing);
        return;
    }


}
