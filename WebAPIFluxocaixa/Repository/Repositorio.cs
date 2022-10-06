
using NHibernate;
using System;
using System.Collections.Generic;
using NHibernate.Linq;
using System.Linq;
using static WebAPIFluxocaixa.Interface.ILancamentoCrud;
using WebAPIFluxocaixa.Models;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices.ObjectiveC;
using NHibernate.Util;

namespace WebAPIFluxocaixa.Repository
{
    public class Repositorio<T> : IUsuarioCrud<T> where T : class
    {
        public void Inserir(T entidade)
        {
            using (NHibernate.ISession session = SessionFactory.AbrirSession())
            {
                using (ITransaction transacao = session.BeginTransaction())
                {
                    try
                    {
                        session.Save(entidade);
                        transacao.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (!transacao.WasCommitted)
                        {
                            transacao.Rollback();
                        }
                        throw new Exception("Erro ao inserir Lançamento : " + ex.Message);
                    }
                }
            }
        }
        public void Alterar(T entidade)
        {
            using (NHibernate.ISession session = SessionFactory.AbrirSession())
            {
                using (ITransaction transacao = session.BeginTransaction())
                {
                    try
                    {
                        session.Update(entidade);
                        transacao.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (!transacao.WasCommitted)
                        {
                            transacao.Rollback();
                        }
                        throw new Exception("Erro ao Alterar Lançamento : " + ex.Message);
                    }
                }
            }
        }
        public void Excluir(T entidade)
        {
            using (NHibernate.ISession session = SessionFactory.AbrirSession())
            {
                using (ITransaction transacao = session.BeginTransaction())
                {
                    try
                    {
                        session.Delete(entidade);
                        transacao.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (!transacao.WasCommitted)
                        {
                            transacao.Rollback();
                        }
                        throw new Exception("Erro ao Excluir Lançamento : " + ex.Message);
                    }
                }
            }
        }
        public T RetornarPorId(int Id)
        {
            using (NHibernate.ISession session = SessionFactory.AbrirSession())
            {
                return session.Get<T>(Id);
            }
        }
        public IList<T> Consultar()
        {
            using (NHibernate.ISession session = SessionFactory.AbrirSession())
            {                
                var result = session.Query<T>().Select(l => l).ToList();
                return result;                
            }
        }

    public IList<T> ConsultarId(int id)
    {
      using (NHibernate.ISession session = SessionFactory.AbrirSession())
      {
        var result = session.Query<T>().Select(l => l).ToList();
        string hql = $"select * from Lancamentos where Id = {id}";
        IQuery query = session.CreateQuery(hql);
        return result;
      }
    }

    public IList<T> ConsultarConsolidado()
    {
      using (NHibernate.ISession session = SessionFactory.AbrirSession())
      {
        string hql = @"select DataLancamento,
          case when TipoLancamento = 'E' then sum(ValorLancamento) else sum(ValorLancamento) * -1 end as ValorLancamento
          from Lancamentos
          group by DataLancamento, TipoLancamento
          order by DataLancamento";
        
        IQuery query = session.CreateQuery(hql);

        IList<Object[]> result = query.List<Object[]>();

        IList<Lancamentos> relatorio = new List<Lancamentos>();

        DateTime data = DateTime.MinValue;
        double valor = 0;
        Lancamentos p;
        foreach (Object[] resultado in result)
        {
          if (valor == 0)
            { data = (DateTime)resultado[0]; }

          if ((DateTime)resultado[0] == data)
          {
            data = (DateTime)resultado[0];
            valor += (double)resultado[1];
          }
          else
          {
            p = new Lancamentos();
            p.DataLancamento = data;
            p.ValorLancamento = valor;
            relatorio.Add(p);
            valor = 0;
            data = (DateTime)resultado[0];
            valor += (double)resultado[1];
          }
        }
        p = new Lancamentos();
        p.DataLancamento = data;
        p.ValorLancamento = valor;
        relatorio.Add(p);
        return (IList<T>)relatorio.ToList();        
      }
    }
  }
}
