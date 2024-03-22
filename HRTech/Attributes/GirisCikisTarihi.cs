﻿using System.ComponentModel.DataAnnotations;

namespace Ornek.Attributes
{
    public class GirisCikisTarihi : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            DateTime tarih;

            DateTime.TryParse(value?.ToString(), out tarih);        
            if (tarih < DateTime.Now.AddYears(-100))
            {
                ErrorMessage = "Eski tarih girdiniz!";
                return false;
            }        
            
            return true;
        }
    }
}
