﻿using System.ComponentModel.DataAnnotations;

namespace Ornek
{
    public class Departman
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Alan boş bırakılamaz!")]
        [MaxLength(100)]
        public string Ad { get; set; } = null!;        
    }
}
