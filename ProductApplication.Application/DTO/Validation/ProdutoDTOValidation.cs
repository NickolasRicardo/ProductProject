using FluentValidation;

namespace ProductApplication.Application.DTO.Validation
{
    public class ProdutoDTOValidation : AbstractValidator<ProdutoDTO>
    {
        public ProdutoDTOValidation()
        {
            RuleFor(x => x.Descricao)
                .NotNull()
                .NotEmpty()
                .WithMessage("Descrição Obrigatória!");

            RuleFor(x => x.DataFabricacao).LessThan(x => x.DataValidade).WithMessage("Data de fabricação não pode ser maior ou igual a data de vencimento!");
        }
    }
}
