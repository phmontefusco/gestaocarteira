using gestaocarteira.domain.Enums;

namespace  gestaocarteira.domain;


public class OperacaoRF : Entity
{
    public DateOnly dtOperacao { get; set; }
    public string nomeEmpresa { get; set; } = string.Empty;
    public decimal vlOperacao { get; set; }
    public short qtdeParcelas { get; set; }
    public decimal vlParcela { get; set; }
    public StatusEnum statusOperacao { get; set; }
    public RatingEnum rating { get; set; }
    public decimal txOperacao { get; set; }

    public int produtoId { get; set; }
    public virtual Produto Produto { get; set; }
    public int ClearingId { get; set; }
    public virtual Produto Clearing { get; set; }
}