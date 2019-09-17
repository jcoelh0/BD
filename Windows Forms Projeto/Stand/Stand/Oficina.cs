using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stand
{
    class Oficina
    {
        private String _oficinaId;
        private String _contacto;
        private String _localizaçao;
        private String _nome;



        public String OficinaId
        {
            get { return _oficinaId; }
            set { _oficinaId = value; }
        }

        public String Contacto
        {
            get { return _contacto; }
            set { _contacto = value; }
        }

        public String Localizaçao
        {
            get { return _localizaçao; }
            set { _localizaçao = value; }
        }

        public String Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public override String ToString()
        {
            return _oficinaId + "\t " + _nome;
        }
        
    }
}
