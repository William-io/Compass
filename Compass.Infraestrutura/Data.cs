using Compass.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Compass.Infraestrutura;

/// <summary>
/// Classe que representa o contexto de dados do Entity Framework.
/// </summary>
public class Data : DbContext
{
    /// <summary>
    /// Construtor padrão sem parâmetros.
    /// </summary>
    public Data() { }
     /// <summary>
    /// Construtor que aceita opções de contexto e as passa para a classe base DbContext.
    /// 
    /// O base(options) chama o construtor da classe base (DbContext) e passa as options para ele.
    /// Isso é necessário porque a classe Data herda de DbContext, e o DbContext precisa dessas opções para configurar o contexto, 
    /// como a string de conexão e outros parâmetros.
    /// </summary>
    /// <param name="options">Opções de configuração do contexto.</param>
    public Data(DbContextOptions<Data> options) : base(options) { }

    /// <summary>
    /// DbSet que representa a coleção de entidades Produto no contexto.
    /// </summary>
    public DbSet<Produto> Produtos { get; set; }

    /// <summary>
    /// Método chamado ao criar o modelo para o contexto de dados.
    /// </summary>
    /// <param name="builder">Construtor de modelos utilizado para configurar o modelo.</param>
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Aplica todas as configurações de entidade encontradas no assembly atual
        builder.ApplyConfigurationsFromAssembly(typeof(Data)
            .Assembly);
    }
}
