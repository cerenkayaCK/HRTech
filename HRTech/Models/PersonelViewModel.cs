using System.ComponentModel.DataAnnotations;

namespace HRTech.Models
{
    public class PersonelViewModel
    {
        [Display(Name = "Ad")]
        [Required(ErrorMessage = "Ad alanı boş bırakılamaz.")]
        [StringLength(40, ErrorMessage = "Ad alanı en fazla 40 karakter olmalıdır.")]
        public string Ad { get; set; }

        [Display(Name = "Soyad")]
        [Required(ErrorMessage = "Soyad alanı boş bırakılamaz.")]
        [StringLength(60, ErrorMessage = "Soyad alanı en fazla 60 karakter olmalıdır.")]
        public string Soyad { get; set; }

        [Display(Name = "Doğum Tarihi")]
        [DataType(DataType.Date)]
        public DateTime DogumTarihi { get; set; }

        [Display(Name = "Tc Kimlik No")]
        [Required(ErrorMessage = "Tc Kimlik No alanı boş bırakılamaz.")]
        [StringLength(11, ErrorMessage = "Tc Kimlik No alanı 11 karakter olmalıdır.", MinimumLength = 11)]
        public string TcNo { get; set; }

        [Display(Name = "İşe Giriş Tarihi")]
        [DataType(DataType.Date)]
        public DateTime IseGirisTarihi { get; set; }

        [Display(Name = "İşten Çıkış Tarihi")]
        [DataType(DataType.Date)]
        public DateTime? IstenCikisTarihi { get; set; }

        [Display(Name = "Aktiflik Durumu")]
        public bool Aktiflik { get; set; }

        [Display(Name = "E-Posta")]
        [Required(ErrorMessage = "E-Posta alanı boş bırakılamaz.")]
        [EmailAddress(ErrorMessage = "Geçersiz e-posta adresi.")]
        [StringLength(100, ErrorMessage = "E-Posta alanı en fazla 100 karakter olmalıdır.")]
        public string Email { get; set; }

        [Display(Name = "Telefon")]
        [Required(ErrorMessage = "Telefon alanı boş bırakılamaz.")]
        [StringLength(60, ErrorMessage = "Telefon alanı en fazla 60 karakter olmalıdır.")]
        public string Telefon { get; set; }

        [Display(Name = "Maaş")]
        [Required(ErrorMessage = "Maaş alanı boş bırakılamaz.")]
        [DataType(DataType.Currency)]
        public decimal Maas { get; set; }
    }
}
