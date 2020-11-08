using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_025.Models
{
    public partial class Pengembalian
    {
        [Required(ErrorMessage = "IdPengembalian tidak boleh kosong")]
        public int IdPengembalian { get; set; }
        [Required(ErrorMessage = "TglPengembalian tidak boleh kosong")]
        public DateTime? TglPengembalian { get; set; }
        [Required(ErrorMessage = "IdPeminjaman tidak boleh kosong")]
        public int? IdPeminjaman { get; set; }
        [Required(ErrorMessage = "IdKondisi tidak boleh kosong")]
        public int? IdKondisi { get; set; }
        [RegularExpression("^[0-9]*$", ErrorMessage = "Denda Hanya boleh diisi dengan angka")]
        public int? Denda { get; set; }

        public KondisiKendaraan IdKondisiNavigation { get; set; }
        public Peminjaman IdPeminjamanNavigation { get; set; }
    }
}
