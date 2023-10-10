using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjetoFinalBloco2.Model;
using ProjetoFinalBloco2.Service;

namespace ProjetoFinalBloco2.Controllers
{
    [Route("~/produto")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _produtoService;
        private readonly IValidator<Produto> _produtoValidator;
        public ProdutoController(
                IProdutoService produtoService,
                IValidator<Produto> ProdutoValidator
        )
        {
            _produtoService = produtoService;
            _produtoValidator = ProdutoValidator;
        }
        [HttpGet("all")]
        public async Task<ActionResult> GetAll()
        {
            return Ok(await _produtoService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetById(long id)
        {
            var Resposta = await _produtoService.GetById(id);
            if (Resposta is null)
            {
                return NotFound();
            }
            return Ok(Resposta);
        }
        [HttpGet("nome/{nome}")]
        public async Task<ActionResult> GetByNome(string nome)
        {
            return Ok(await _produtoService.GetByNome(nome));
        }

        [HttpGet("preco/{preco}")]
        public async Task<ActionResult> GetByPreco(decimal preco)
        {
            var produtos = await _produtoService.GetByPreco(preco);

            return Ok(produtos);

        }

        [HttpPost("cadastrar")]
        public async Task<ActionResult> Create([FromBody] Produto produto)
        {
            var validarProduto = await _produtoValidator.ValidateAsync(produto);

            if (!validarProduto.IsValid)
                return StatusCode(StatusCodes.Status400BadRequest, validarProduto);

            var Resposta = await _produtoService.Create(produto);

            if (Resposta is null)
                return BadRequest("Tema não encontrado");

            return CreatedAtAction(nameof(GetById), new { id = produto.Id }, produto);
        }
        [HttpPut("atualizar")]
        public async Task<ActionResult> Update([FromBody] Produto produto)
        {
            if (produto.Id == 0)
                return BadRequest("Id da Produto é invalida");

            var validarProduto = await _produtoValidator.ValidateAsync(produto);

            if (!validarProduto.IsValid)
                return StatusCode(StatusCodes.Status400BadRequest, validarProduto);

            var Resposta = await _produtoService.Update(produto);

            if (Resposta is null)
                return NotFound("Produto e/ou Tema não encontrada!");
            return Ok(Resposta);
        }
        [HttpDelete("delete/{id}")]
        public async Task<ActionResult> Delete(long id)
        {
            var BuscarProduto = await _produtoService.GetById(id);
            if (BuscarProduto is null)
                return NotFound("Produto não encontrada!");
            await _produtoService.Delete(BuscarProduto);
            return NoContent();
        }
       
       
    }
}
