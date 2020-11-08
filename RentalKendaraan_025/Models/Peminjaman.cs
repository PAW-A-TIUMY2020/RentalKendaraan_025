using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_025.Models
{
    public partial class Peminjaman
    {
        public Peminjaman()
        {
            Pengembalian = new HashSet<Pengembalian>();
        }
        [Required(ErrorMessage = "IdPeminjaman tidak boleh kosong")]
        public int IdPeminjaman { get; set; }
        [Required(ErrorMessage = "Tanggal Peminjaman tidak boleh kosong")]
        public DateTime? TglPeminjaman { get; set; }
        [Required(ErrorMessage = "IdKendaraan tidak boleh kosong")]
        public int? IdKendaraan { get; set; }
        [Required(ErrorMessage = "IdCostumer tidak boleh kosong")]
        public int? IdCostumer { get; set; }
        [Required(ErrorMessage = "IdJaminan tidak boleh kosong")]
        public int? IdJaminan { get; set; }
        [RegularExpression("^[0-9]*$", ErrorMessage = "Biaya Hanya boleh diisi dengan angka")]
        public int? Biaya { get; set; }

        public Customer IdCostumerNavigation { get; set; }
        public Jaminan IdJaminanNavigation { get; set; }
        public Kendaraan IdKendaraanNavigation { get; set; }
        public ICollection<Pengembalian> Pengembalian { get; set; }
    }
}
