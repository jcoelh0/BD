using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stand
{
    class VeiculoCliente
    {
        private String _chassisId;
        private String _marca;
        private String _modelo;
        private String _tipoVeiculo;
        private String _clienteId;
            

        public String ChassisId
        {
            get { return _chassisId; }
            set { _chassisId = value; }
        }

        public String Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }

        public String Modelo
        {
            get { return _modelo; }
            set { _modelo = value; }
        }
        

        public String TipoVeiculo
        {
            get { return _tipoVeiculo; }
            set { _tipoVeiculo = value; }
        }

        public String ClienteId
        {
            get { return _clienteId; }
            set { _clienteId = value; }
        }


        public override String ToString()
        {
            return _clienteId + "   " + _marca + "   " + _modelo + "   " + _chassisId;
        }
        
    }
}
