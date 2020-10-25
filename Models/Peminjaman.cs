using System;
using System.Collections.Generic;

namespace RentalKendaraan_084.Models
{
    public partial class Peminjaman
    {
        public int IdPeminjaman { get; set; }
        public DateTime? TglPeminjamaan { get; set; }
        public int? IdKendaraan { get; set; }
        public int? IdCostumer { get; set; }
        public int? IdJaminan { get; set; }
        public int? Biaya { get; set; }

        public Kendaraan IdCostumerNavigation { get; set; }
        public Pengembalian IdPeminjaman1 { get; set; }
        public Customer IdPeminjamanNavigation { get; set; }
        public Jaminan Jaminan { get; set; }
    }
}
