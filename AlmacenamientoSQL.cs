using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionDependencia
{
    public class AlmacenamientoSQL : IAlmacenamiento
    {
        private readonly DBRepositorio _dBRepositorio;
        public AlmacenamientoSQL(DBRepositorio dBRepositorio)
        {
            _dBRepositorio = dBRepositorio;
        }

        public void Guardar(string titulo, string contenido)
        {
            _dBRepositorio.Guardar(titulo, contenido);
        }
       
        public string Leer(string titulo)
        {
            return _dBRepositorio.Leer(titulo);
        }
        
    }
}
