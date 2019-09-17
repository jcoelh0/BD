using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stand
{
    class Veiculo
    {
        private String _chassisId;
        private String _marca;
        private String _modelo;
        private String _estado;
        private String _quilometragem;
        private String _paisOrigem;
        private String _anoFabrico;
        private String _combustivel;
        private String _traçao;
        private String _tipoVeiculo;
        private String _potencia;
        private String _standId;
            

        public String ChassisId
        {
            get { return _chassisId; }
            set { _chassisId = value; }
        }
        public String Estado
        {
            get { return _estado; }
            set { _estado = value; }
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

        public String Quilometragem
        {
            get { return _quilometragem; }
            set { _quilometragem = value; }
        }

        public String PaisOrigem
        {
            get { return _paisOrigem; }
            set { _paisOrigem = value; }
        }

        public String AnoFabrico
        {
            get { return _anoFabrico; }
            set { _anoFabrico = value; }
        }

        public String Combustivel
        {
            get { return _combustivel; }
            set { _combustivel = value; }
        }

        public String Traçao
        {
            get { return _traçao; }
            set { _traçao = value; }
        }

        public String TipoVeiculo
        {
            get { return _tipoVeiculo; }
            set { _tipoVeiculo = value; }
        }

        public String Potencia
        {
            get { return _potencia; }
            set { _potencia = value; }
        }

        public String StandId
        {
            get { return _standId; }
            set { _standId = value; }
        }

        public override String ToString()
        {
            return _chassisId + "\t" + _marca + "\t" + _modelo;
        }
        
    }
}
