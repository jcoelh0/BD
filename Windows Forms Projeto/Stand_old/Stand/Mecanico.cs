using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stand
{
    class Mecanico
    {
        private String _nome;
        private String _morada;
        private String _nif;
        private String _contacto;
        private String _veiculoId;
        private String _nrFuncionario;


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

        public String VeiculoId
        {
            get { return _veiculoId; }
            set { _veiculoId = value; }
        }
        public String NrFuncionario
        {
            get { return _nrFuncionario; }
            set { _nrFuncionario = value; }
        }

        public override String ToString()
        {
            return _nrFuncionario + "   " + _nome;
        }

        public Mecanico() : base()
        {
        }

    }
}
