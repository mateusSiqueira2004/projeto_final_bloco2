using FluentValidation;
using ProjetoFinalBloco2.Model;

namespace ProjetoFinalBloco2.Validator
{
    public class ProdutoValidator : AbstractValidator<Produto>
    {
        public ProdutoValidator()
        {
            RuleFor(p => p.Nome)
                .NotEmpty()
                .MinimumLength(0)
                .MaximumLength(255);
            RuleFor(p => p.Decricao)
                .NotEmpty()
                .MinimumLength(5)
                .MaximumLength(255);
            
            RuleFor(p => p.Foto)
                .MaximumLength(510);

            RuleFor(p => p.Preco)
                .ScalePrecision(2, 6);


        }
    }
}
