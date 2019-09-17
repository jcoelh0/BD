using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stand
{
    class Peça
    {
        private String _peçaId;
        private String _fabricante;
        private String _disponibilidade;
        private String _tipoPeça;
        private String _nome;



        public String PeçaId
        {
            get { return _peçaId; }
            set { _peçaId = value; }
        }

        public String Fabricante
        {
            get { return _fabricante; }
            set { _fabricante = value; }
        }

        public String Disponibilidade
        {
            get { return _disponibilidade; }
            set { _disponibilidade = value; }
        }

        public String TipoPeça
        {
            get { return _tipoPeça; }
            set { _tipoPeça = value; }
        }

        public String Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public override String ToString()
        {
            return _peçaId + "\t " + _nome;
        }
        
    }
}
