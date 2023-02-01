using System.ComponentModel.DataAnnotations;

namespace SistemaWebRecetas.Validations
{
    public class CheckValidCategoriaAttribute : ValidationAttribute
    {
        public CheckValidCategoriaAttribute()
        {
            ErrorMessage = "La categoria solo puede ser DESAYUNO";
        }
        public override bool IsValid(object value)
        {
            string categoria = (string)value;
            if (categoria.ToUpper() == "DESAYUNO")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
