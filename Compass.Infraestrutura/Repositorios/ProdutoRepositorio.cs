using Compass.Dominio.Repositorios;
using Compass.Dominio.Resultados;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Compass.Infraestrutura.Repositorios;

/// <summary>
/// Classe que implementa o repositório de produtos.
/// </summary>
public class ProdutoRepositorio : IProdutoRepositorio
{
    //Declaração de variáveis privadas somente leitura
    private readonly Data _contexto;
    private readonly string _connectionString;

    /// <summary>
    /// Construtor que inicializa o contexto de dados e a string de conexão.
    /// </summary>
    /// <param name="contexto">Contexto de dados do Entity Framework.</param>
    /// <param name="configuration">Configuração da aplicação para obter a string de conexão.</param>
    public ProdutoRepositorio(Data contexto, IConfiguration configuration)
    {
        _contexto = contexto;
        _connectionString = configuration.GetConnectionString("DefaultConnection") ?? null!;
    }

    public IEnumerable<ProdutoResultado> ObterProdutos()
    {
        // Define a consulta SQL para selecionar todos os produtos da tabela Produto
        var query = "SELECT * FROM Produtos";
        // Cria uma nova conexão SQL usando a string de conexão fornecida
        using (var conn = new SqlConnection(_connectionString))
        {
            // Abre a conexão com o banco de dados
            conn.Open();
            // Executa a consulta SQL usando Dapper e retorna os resultados como uma coleção de objetos ProdutoResultado
            return conn.Query<ProdutoResultado>(query);
        }
    }
}
