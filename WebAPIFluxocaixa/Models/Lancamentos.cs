namespace WebAPIFluxocaixa.Models
{
  public class Lancamentos
  {
    public virtual int IdLancamento { get; set; }
    public virtual DateTime DataLancamento { get; set; }
    public virtual string? TipoLancamento { get; set; }
    public virtual double ValorLancamento { get; set; }
  }
}
