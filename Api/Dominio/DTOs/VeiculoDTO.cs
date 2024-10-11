
namespace MinimalApi.DTOs;
public record VeiculoDTO
{
    public string Nome { get;set; } = default!;
    public int MarcaVeiculosId { get;set; } = default!;
    public int Ano { get;set; } = default!;
}