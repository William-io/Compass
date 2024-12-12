using Compass.Dominio.Resultados;

namespace Compass.Dominio.Repositorios;

/// <summary>
/// Interface que define o contrato para o repositório de produtos.
/// </summary>
public interface IProdutoRepositorio
{
    /// <summary>
    /// Método para obter a lista de produtos.
    /// </summary>
    /// <returns>Uma coleção de objetos ProdutoResultado. Onde retorno minha classe result
    /// privando o retorno do meu dominio</returns>
    IEnumerable<ProdutoResultado> ObterProdutos();
}
