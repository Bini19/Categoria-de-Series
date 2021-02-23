using System;
using System.Collections.Generic;
using System.Text;

namespace Cadastro_em_Série
{
    public interface IRepositorio<T>
    {
        List<T> Lista();

        T RetornoPorID(int id);

        void Insere(T entidade);

        void Exclui(int id);

        void Atualiza(int id, T entidade);

        int ProximoId();
    }
}
