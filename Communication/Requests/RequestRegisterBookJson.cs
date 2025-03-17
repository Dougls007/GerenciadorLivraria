using GerenciadorLivraria.Models.Enums;

namespace GerenciadorLivraria.Communication.Requests;

public class RequestRegisterBookJson
{
    public required int Id { get; set; }
    public required string Titulo { get; set; } = string.Empty;
    public required string Autor { get; set; } = string.Empty;
    public Genero Genero { get; set; }
    public double Price { get; set; }
    public int QntdEstoque { get; set; }
}
