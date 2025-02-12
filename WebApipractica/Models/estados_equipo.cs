using System.ComponentModel.DataAnnotations;
namespace WebApipractica.Models
{
    public class estados_equipo
    {
        [Key]
        public int id_estados_equipo { get; set; }

        public string descripcion { get; set; }

        public bool estado { get; set; }
    }
}
