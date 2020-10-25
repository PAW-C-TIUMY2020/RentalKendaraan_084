using System;
using System.Collections.Generic;

namespace RentalKendaraan_084.Models
{
    public partial class Pengembalian
    {
        public int IdPengembalian { get; set; }
        public DateTime? TglPeminjaman { get; set; }
        public int? IdPeminjaman { get; set; }
        public int? IdKondisi { get; set; }
        public int? Denda { get; set; }

        public KondisiKendaraan IdPeminjamanNavigation { get; set; }
        public Peminjaman Peminjaman { get; set; }
    }
}
