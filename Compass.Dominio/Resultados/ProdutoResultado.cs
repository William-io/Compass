namespace Compass.Dominio.Resultados;

public class ProdutoResultado
{
    public int Id { get; set; }
    public string Nome { get; set; } = null!;
    public decimal Preco { get; set; }
    public int Quantidade { get; set; }
}
