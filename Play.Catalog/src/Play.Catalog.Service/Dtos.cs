using System;
using System.ComponentModel.DataAnnotations;

namespace Play.Catalog.Service.Dtos
{
    public record ItemDto(Guid Id,
        string Name,
        string Description,
        decimal Price,
        DateTimeOffset CreatedDate);

    public record CreateItemDto(
        [Required(ErrorMessage = "O Nome é Obrigatório")] string Name,
        [Required(ErrorMessage = "A Descrição é Obrigatória")] string Description,
        [Range(0, 1000, ErrorMessage = "O Preço deve estar entre 0 e 1000")] decimal Price);

    public record UpdateItemDto(
        [Required(ErrorMessage = "O Nome é Obrigatório")] string Name,
        [Required(ErrorMessage = "A Descrição é Obrigatório")] string Description,
        [Range(0, 1000, ErrorMessage = "O Preço deve estar entre 0 e 1000")] decimal Price);
}