using System.ComponentModel.DataAnnotations;

namespace Ornek
{
    public class Sirket
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Alan boş bırakılamaz!")]
        [MaxLength(100)]
        public string Name { get; set; } = null!;        
    }
}
