using System.Collections.Generic;

namespace WebAPIFluxocaixa.Interface
{
    public interface ILancamentoCrud
    {
        public interface IUsuarioCrud<T>
        {
            void Inserir(T entidade);
            void Alterar(T entidade);
            void Excluir(T entidade);
            T RetornarPorId(int Id);
            IList<T> Consultar();
        }
    }
}
