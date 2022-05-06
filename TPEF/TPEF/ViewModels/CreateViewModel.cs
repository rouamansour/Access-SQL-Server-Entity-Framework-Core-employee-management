using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace TPEF.ViewModels
{
    public class CreateViewModel
    {
        [Required]
        [MaxLength(20, ErrorMessage = "Taille Max 50 cc")]
        public string Name { get; set; }
        public string Department { get; set; }
        [Range(300, 5000, ErrorMessage = "Doit être entre 300 et 5000")]
        public int Salary { get; set; }
        public IFormFile Photo { get; set; }

    }
}
