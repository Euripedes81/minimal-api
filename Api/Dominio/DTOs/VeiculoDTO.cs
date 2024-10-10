
namespace MinimalApi.DTOs;
public record VeiculoDTO
{
    public string Nome { get;set; } = default!;
    public int MarcaVeiculoId { get;set; } = default!;
    public int Ano { get;set; } = default!;
}