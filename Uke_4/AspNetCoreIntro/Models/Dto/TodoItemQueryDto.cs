namespace AspNetCoreIntro.Models.Dto;

public record TodoItemQueryDto(string? Name, string? DescriptionContains, DateTime? From, DateTime? To, bool? Complete);
