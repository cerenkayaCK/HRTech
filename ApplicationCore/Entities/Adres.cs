

using System.ComponentModel.DataAnnotations;

namespace HRTech
{
    public class Adres
    {
        [MaxLength(30)]
        public string Il { get; set; } = null!;

        [MaxLength(50)]
        public string Ilce { get; set; } = null!;

        [MaxLength(60)]
        public string Mahalle { get; set; } = null!;

        [MaxLength(50)]
        public string Sokak { get; set;} = null!;
        public int KapiNo { get; set; }
        public int DaireNo { get; set; }
    }
}
