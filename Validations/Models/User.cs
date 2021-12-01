using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Validations.Models.ModelMetadataTypes;

namespace Validations.Models
{
    // SingleResponsibility
    // [ModelMetadataType(typeof(UserMetadata))]
    public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Yas { get; set; }
        public string Email { get; set; }
    }
}
