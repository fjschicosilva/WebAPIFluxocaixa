using FluentNHibernate.Mapping;
using WebAPIFluxocaixa.Models;

namespace WebAPIFluxocaixa.Mappings
{
  public class LancamentosMap : ClassMap<Lancamentos>
  {
    public LancamentosMap()
    {
      Id(l => l.IdLancamento);
      Map(l => l.DataLancamento);
      Map(l => l.TipoLancamento);
      Map(l => l.ValorLancamento);
      Table("Lancamentos");
    }
  }

}
