using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;


namespace slnValorosoMartin.Validations
{
    public class CheckValidEdadAtributte : ValidationAttribute
    {
        public CheckValidEdadAtributte()
        {
            ErrorMessage = "La edad debe ser mayor o igual que 18 años";
        }

        public override bool IsValid(object value)
        {
            //return base.IsValid(value);

            int edad = (int)value;
            if (edad < 18)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
