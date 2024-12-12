using Compass.Dominio.Repositorios;
using Compass.Infraestrutura.Repositorios;
using Compass.Infraestrutura;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSqlServer<Data>(builder.Configuration["ConnectionStrings:DefaultConnection"]);

/// <summary>
/// Adiciona o repositório de produtos ao contêiner de injeção de dependência.
/// AddScoped é utilizado para criar uma instância do repositório por solicitação HTTP.
/// Isso garante que cada solicitação HTTP receba uma nova instância do repositório,
/// mantendo o estado da instância isolado entre as solicitações.
/// </summary>
builder.Services.AddScoped<IProdutoRepositorio, ProdutoRepositorio>();

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

/// <summary>
/// Configura o Swagger para gerar a documentação da API.
/// Swagger é utilizado para documentar e testar os endpoints da API.
/// </summary>
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "Compass-TESTE",
        Version = "v1",
        Description = "API, obtendo lista de produtos",
        Contact = new Microsoft.OpenApi.Models.OpenApiContact
        {
            Name = "William G.Silva",
            Email = "williamgsilva@live.com"
        }
    });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.DocumentTitle = "Compass - Swagger UI";
    });
}

app.UseHttpsRedirection();

/// <summary>
/// Configura o CORS para permitir solicitações do front-end Angular.
/// Permite qualquer cabeçalho e método de solicitação do domínio especificado.
/// </summary>
app.UseCors(options => options.WithOrigins("http://localhost:4200")
    .AllowAnyHeader()
    .AllowAnyMethod());

app.UseAuthorization();

app.MapControllers();

app.Run();
