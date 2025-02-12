using System.ComponentModel.DataAnnotations;
namespace WebApipractica.Models
{
    public class marcas
    {

        [Key]
        public int id_marcas { get; set; }

        public string nombre_marca { get; set; }

        public bool estados { get; set; }

    }
}
