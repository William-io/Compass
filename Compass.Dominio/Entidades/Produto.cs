namespace Compass.Dominio.Entidades;

/// <summary>
/// Classe que representa a entidade Produto.
/// </summary>
public class Produto
{
    /// <summary>
    /// Construtor protegido sem parâmetros para uso do Entity Framework.
    /// O Entity Framework exige um construtor sem parâmetros para realizar o mapeamento
    /// e a criação de instâncias das entidades. Este construtor é protegido para evitar
    /// que a classe seja instanciada sem fornecer os valores necessários, garantindo assim
    /// a integridade dos dados.
    /// </summary>
    protected Produto() { }

    /// <summary>
    /// Construtor público para inicializar a entidade Produto com os valores fornecidos.
    /// </summary>
    /// <param name="id">ID do produto.</param>
    /// <param name="nome">Nome do produto.</param>
    /// <param name="preco">Preço do produto.</param>
    /// <param name="quantidade">Quantidade do produto.</param>
    public Produto(int id, string nome, decimal preco, int quantidade)
    {
        Id = id;
        Nome = nome;
        Preco = preco;
        Quantidade = quantidade;
    }

    public int Id { get; set; }

    /// <summary>
    /// As propriedades são privadas para garantir que só possam ser alteradas através do construtor.
    /// Isso assegura que a integridade dos dados seja mantida, evitando alterações não controladas
    /// após a criação da instância da entidade.
    /// Null! é utilizado para indicar que a propriedade não vai ser null.
    /// </summary>
    public string Nome { get; private set; } = null!;
    public decimal Preco { get; private set; }
    public int Quantidade { get; private set; }
}
