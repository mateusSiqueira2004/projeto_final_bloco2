using FluentValidation;
using ProjetoFinalBloco2.Model;

namespace ProjetoFinalBloco2.Validator
{
    public class CategoriaValidator : AbstractValidator<Categoria>
    {
        public CategoriaValidator()
        {
            RuleFor(c => c.Tipo)
                .NotEmpty()
                .MinimumLength(5)
                .MaximumLength(100);

            RuleFor(c => c.DescricaoCategoria)
               .NotEmpty()
               .MinimumLength(5)
               .MaximumLength(255);

            RuleFor(c => c.Sigla)
               .NotEmpty()
               .MaximumLength(20);

            RuleFor(c => c.Imposto)
                .ScalePrecision(2, 6);

            RuleFor(c => c.CorBula)
               .MaximumLength(20);

            RuleFor(c => c.Ativa)
              .NotEmpty()
              .MaximumLength(10);
        }
    }
}
