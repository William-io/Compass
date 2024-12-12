using Compass.Dominio.Repositorios;
using Microsoft.AspNetCore.Mvc;

namespace Compass.Api.Controllers;

[ApiController]
/// <summary>
/// Controlador responsável por gerenciar as operações relacionadas aos produtos.
/// </summary>
public class ProdutoController : ControllerBase
{
    private readonly IProdutoRepositorio _produtos;

    public ProdutoController(IProdutoRepositorio produtos) => _produtos = produtos;

    /// <summary>
    /// Endpoint para listar todos os produtos.
    /// </summary>
    /// <returns>Uma lista de produtos.</returns>
    [HttpGet]
    [Route("api/produtos")]
    public IActionResult ListarTodosProdutos()
    {
        return Ok(_produtos.ObterProdutos());
    }
}
