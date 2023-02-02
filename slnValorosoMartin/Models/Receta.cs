using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using slnValorosoMartin.Validations;
using SistemaWebRecetas.Validations;

namespace slnValorosoMartin.Models
{
    [Table("Receta")]

    public class Receta
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo es obligatorio")]
        [CheckValidCategoria]
        public string Categoria { get; set; }
        [Required(ErrorMessage = "El campo es obligatorio")]
        [Column(TypeName = "varchar(50)")]
        public string TituloReceta { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio")]

        [DataType(DataType.MultilineText)]
        public string Ingredientes { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio")]

        [DataType(DataType.MultilineText)]
        public string instrucciones { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "El campo es obligatorio")]
        [Display(Name = "Nombre Autor")]
        public string Autor { get; set; }


        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "El campo es obligatorio")]
        [Display(Name = "Apellido Autor")]
        public string Apellido { get; set; }


        [CheckValidEdadAtributte]
        public int Edad { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "El campo es obligatorio")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Se debe ingresar un email")]
        public string Email { get; set; }
    }
}
