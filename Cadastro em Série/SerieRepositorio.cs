using System;
using System.Collections.Generic;
using System.Text;

namespace Cadastro_em_Série
{
    public class SerieRepositorio : IRepositorio<Serie>
    {

        private List<Serie> listaSerie = new List<Serie>();
        private Serie objeto;

        public void Atualiza(int id, Serie entidade)
        {
            listaSerie[id] = entidade;
        }

        public void Exclui(int id)
        {
            listaSerie[id].Excluir();
            // implemento envio de e-mail
        }

        public void Insere(Serie entidade)
        {
            listaSerie.Add(objeto);
        }

        public List<Serie> Lista()
        {
            throw new NotImplementedException();
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Serie RetornoPorID(int id)
        {
            return listaSerie[id];
        }
    }
}
