using Ornek.Attributes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ornek
{
    public class Personel
    {
        public int Id { get; set; }
        public string FotografYolu { get; set; } = null!;

        [Required(ErrorMessage = "Alan boş bırakılamaz!")]
        [AdSoyad]
        [MaxLength(40)]
        public string Ad { get; set; } = null!;

        [AdSoyad]
        [MaxLength(40)]
        public string? Ad2 { get; set; }

        [Required(ErrorMessage = "Alan boş bırakılamaz!")]
        [AdSoyad]
        [MaxLength(60)]
        public string Soyad { get; set; } = null!;

        [AdSoyad]
        [MaxLength(60)]
        public string? Soyad2 { get; set; }

        [DogumTarihi]
        public DateTime DogumTarihi { get; set; }

        [Required(ErrorMessage = "Alan boş bırakılamaz!")]
        [TcNo]
        public string TcNo { get; set; } = null!;

        [GirisCikisTarihi]
        public DateTime IseGirisTarihi { get; set; }

        [GirisCikisTarihi]
        public DateTime IstenCikisTarihi { get; set; }
        public bool Aktiflik {  get; set; }
        public int MeslekId { get; set; }        
        public Meslek Meslek { get; set; } = null!;
        public int DepartmanId { get; set; }
        public Departman Departman { get; set; } = null!;
        public int SirketId { get; set; }
        public Sirket Sirket { get; set; } = null!;

        [Required(ErrorMessage = "Alan boş bırakılamaz!")]
        [Email]
        [MaxLength(100)]
        public string Email { get; set; } = null!;
        public Adres Adres { get; set; } = null!;

        [Required(ErrorMessage = "Alan boş bırakılamaz!")]
        [Telefon]
        [MaxLength(60)]
        public string Telefon { get; set; } = null!;

        [Required(ErrorMessage = "Alan boş bırakılamaz!")]
        [Maas]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Maas { get; set; }
    }
}
