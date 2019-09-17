using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stand
{
    class Cliente
    {
        private String _nome;
        private String _morada;
        private String _nif;
        private String _contacto;
        private String _nrCliente;
        private String _veiculoId;



        public String Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public String Morada
        {
            get { return _morada; }
            set { _morada = value; }
        }

        public String Nif
        {
            get { return _nif; }
            set { _nif = value; }
        }

        public String Contacto
        {
            get { return _contacto; }
            set { _contacto = value; }
        }

        public String NrCliente
        {
            get { return _nrCliente; }
            set { _nrCliente = value; }
        }

        public String VeiculoId
        {
            get { return _veiculoId; }
            set { _veiculoId = value; }
        }

        public override String ToString()
        {
            return _nrCliente + "   " + _nome;
        }

        public Cliente() : base()
        {
        }
        
    }
}
