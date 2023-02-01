using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using slnValorosoMartin.Validations;
using SistemaWebRecetas.Validations;

namespace slnValorosoMartin.Models
{
    public class Receta
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo es obligatorio")]
        [CheckValidCategoria]
        public string Categoria { get; set; }

        public string TituloReceta { get; set; }


        [DataType(DataType.MultilineText)]
        public string Ingredientes { get; set; }

        [DataType(DataType.MultilineText)]
        public string instrucciones { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio")]
        // [Display (Name = "lo que quiera poner de nombre")]
        [Column(TypeName = "varchar(50)")]
        public string Autor { get; set; }


        [Required(ErrorMessage = "El campo es obligatorio")]
        // [Display (Name = "lo que quiera poner de nombre")]
        [Column(TypeName = "varchar(50)")]
        public string Apellido { get; set; }


        [CheckValidEdadAtributte]
        public int Edad { get; set; }

        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")]
        public string Email { get; set; }
    }
}
