using System.ComponentModel.DataAnnotations;

namespace Ornek.Attributes
{
    public class MaasAttribute : ValidationAttribute
    {       
        public override bool IsValid(object? value)
        {
            double maas;

            if (value == null) return true;

            if (!double.TryParse(value.ToString(), out maas))
            {
                ErrorMessage = "Geçersiz değer!";
                return false;
            }

            if (maas < 1) return false;            

            return true;
        }
    }
}
