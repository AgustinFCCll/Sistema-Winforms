using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulos
    {
        [DisplayName("Codigo")]
        public string codigoArticulo {  get; set; }
        public string Nombre { get; set; }

        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        public string Imagen {  get; set; }
        [DisplayName("Precio")]
        public decimal precio { get; set; }

        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }

        public int Id { get; set; }
    }
}
