using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Validations.Models.ModelMetadataTypes
{
    public class UserMetadata
    {
        [Required(ErrorMessage = "Bu Veri Mecburi"), MaxLength(50, ErrorMessage = "20 Karakterden Fazla İsim Giremezsiniz.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Bu Veri Mecburi"), Range(20, int.MaxValue, ErrorMessage = "Lütfen {0} Alanı için {1}'den büyük bir rakam girin")]
        public int Yas { get; set; }

        [Required(ErrorMessage = "Bu Veri Mecburi"), EmailAddress(ErrorMessage = "Lütfen Geçerli Bir Mail Adresi Girin")]
        public string Email { get; set; }
    }
}
