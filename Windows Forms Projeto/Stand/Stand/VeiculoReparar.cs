using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stand
{
    class VeiculoReparar
    {
        private String _chassisId;
        private String _anoFabrico;
        private String _marca;
        private String _modelo;
        private String _quilometragem;
        private String _estado;
        private String _tipoVeiculo;
        private String _peçaId;
        private String _oficinaId;
        private String _mecanico;

        public String ChassisId
        {
            get { return _chassisId; }
            set { _chassisId = value; }
        }

        public String AnoFabrico
        {
            get { return _anoFabrico; }
            set { _anoFabrico = value; }
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

        public String Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        public String TipoVeiculo
        {
            get { return _tipoVeiculo; }
            set { _tipoVeiculo = value; }
        }

        public String PeçaId
        {
            get { return _peçaId; }
            set { _peçaId = value; }
        }

        public String OficinaId
        {
            get { return _oficinaId; }
            set { _oficinaId = value; }
        }

        public String Mecanico
        {
            get { return _mecanico; }
            set { _mecanico = value; }
        }

        public override String ToString()
        {
            return _chassisId + "\t" + _marca + "\t" + _modelo + "\t" + _mecanico;
        }
        
    }
}
