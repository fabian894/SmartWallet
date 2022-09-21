using System.ComponentModel.DataAnnotations;

namespace SmartWallet2.Web.Data.Entities
{
    public class Country : BaseEntity<Guid>
    {
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }


        [Required]
        [MaxLength(5)]
        public string IsoCode { get; set; }


        [Required]
        [MaxLength(5)]
        public string CallCode { get; set; }
    }
}
