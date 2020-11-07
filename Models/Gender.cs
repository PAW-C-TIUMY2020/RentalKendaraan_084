using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_084.Models
{
    public partial class Gender
    {
        public int IdGender { get; set; }
        [Required(ErrorMessage ="Nama Gender wajib diisi")]
        public string NamaGender { get; set; }

        public Customer IdGenderNavigation { get; set; }
    }
}
