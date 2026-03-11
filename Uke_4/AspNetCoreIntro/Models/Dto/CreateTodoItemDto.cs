using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace AspNetCoreIntro.Models.Dto;

public record CreateTodoItemDto([Required][NotNull]string Name, [Required][NotNull]string Description);