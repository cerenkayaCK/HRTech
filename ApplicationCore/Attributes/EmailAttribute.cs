using System.ComponentModel.DataAnnotations;

namespace Ornek.Attributes
{
    public class EmailAttribute : ValidationAttribute
    {
        public EmailAttribute() 
        {
            ErrorMessage = "Geçersiz E-Mail adresi";
        }
        public override bool IsValid(object? value)
        {
            if(value == null) return true;

            String? mail = value.ToString();

            int index = mail.IndexOf('@');

            if(index == -1) return false;

            return true;
        }

    }
}
