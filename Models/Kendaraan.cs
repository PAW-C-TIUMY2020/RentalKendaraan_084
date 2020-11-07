using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace RentalKendaraan_084.Models
{
    public partial class Kendaraan
    {
        public Kendaraan()
        {
            Peminjaman = new HashSet<Peminjaman>();
        }

        public int IdKendaraan { get; set; }
        [Required(ErrorMessage ="Nama kendaraan wajib diisi")]
        public string NamaKendaraan { get; set; }
        [MinLength(10, ErrorMessage = "No No polisi minimal 1 angka")]
        [MaxLength(13, ErrorMessage = "No No polisi 4 angka")]
        [RegularExpression("^[0-9]^$", ErrorMessage = "Hanya boleh diisi oleh angka")]
        [Required(ErrorMessage = "No polisi wajib diisi")]
        public string NoPolisi { get; set; }
        [MinLength(10, ErrorMessage = "No STNK minimal 1 angka")]
        [MaxLength(13, ErrorMessage = "No STNK maksimal 4 angka")]
        [RegularExpression("^[0-9]^$", ErrorMessage = "Hanya boleh diisi oleh angka")]
        [Required(ErrorMessage = "no STNK wajib diisi")]
        public string NoStnk { get; set; }
        public int? IdJenisKendaraan { get; set; }
        [RegularExpression("^[0-9]^$", ErrorMessage = "Hanya boleh diisi oleh angka")]
        [Required(ErrorMessage = "Ketersedian wajib diisi")]
        public string Ketersediaan { get; set; }

        public JenisKendaraan JenisKendaraan { get; set; }
        public ICollection<Peminjaman> Peminjaman { get; set; }
    }
}
