using System;

namespace AspNetCoreIntro.Models.Entities;

public class TodoItem
{
    public Guid Id {get;set;}
    public string Name {get;set;} = string.Empty;
    public string Description {get;set;} = string.Empty;
    public DateTime CreatedAt {get;set;}
    public bool Complete {get;set;}
}
