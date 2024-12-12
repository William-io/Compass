using Compass.Dominio.Entidades;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Compass.Infraestrutura.Configuracoes;

/// <summary>
/// Classe de configuração para a entidade Produto.
/// Implementa a interface IEntityTypeConfiguration para configurar a entidade Produto no Entity Framework.
/// </summary>
public class ProdutoConfiguracao : IEntityTypeConfiguration<Produto>
{
    /// <summary>
    /// Método para configurar a entidade Produto.
    /// </summary>
    /// <param name="builder">Construtor de entidades utilizado para configurar a entidade Produto.</param>
    public void Configure(EntityTypeBuilder<Produto> builder)
    {
        // Define a chave primária
        builder.HasKey(x => x.Id);
        // Configura a propriedade Nome como nvarchar(100) e obrigatória
        builder.Property(p => p.Nome).HasColumnType("nvarchar(100)").IsRequired();
        // Configura a precisão da propriedade Preco
        builder.Property(p => p.Preco).HasPrecision(18, 2);
        // Configura a propriedade Quantidade
        builder.Property(p => p.Quantidade);

        // Insere dados iniciais na tabela Produtos
        // O sufixo 'm' é utilizado para indicar que o número é do tipo decimal.
        // Isso é necessário porque, por padrão, números com ponto flutuante são tratados como double.
        // O tipo decimal é mais preciso para valores monetários.
        builder.HasData(
            new Produto(1, "Produto A", 10.50m, 100),
            new Produto(2, "Produto B", 20.00m, 200),
            new Produto(3, "Produto C", 30.75m, 300)
        );
    }
}
