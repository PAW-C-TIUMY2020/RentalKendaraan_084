﻿using System;
using System.Collections.Generic;

namespace RentalKendaraan_084.Models
{
    public partial class JenisKendaraan
    {
        public int IdJenisKendaraan { get; set; }
        public string NamaJenisKendaraan { get; set; }

        public Kendaraan IdJenisKendaraanNavigation { get; set; }
    }
}
