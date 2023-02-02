using System.ComponentModel.DataAnnotations;

namespace SistemaWebRecetas.Validations
{
    public class CheckValidCategoriaAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null || string.IsNullOrEmpty(value.ToString()))
            {
                return ValidationResult.Success;
            }

            if (value.ToString() != "Desayuno")
            {
                return new ValidationResult("Solo se permite ingresar la categoría Desayuno");
            }

            return ValidationResult.Success;
        }
    }
}
