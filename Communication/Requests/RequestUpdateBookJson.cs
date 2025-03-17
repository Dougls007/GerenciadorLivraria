namespace GerenciadorLivraria.Communication.Requests;

public class RequestUpdateBookJson
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int QntdEstoque { get; set; }
}
