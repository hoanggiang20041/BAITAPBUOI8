
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Lab3Layer.DAL.Entities;

[Table("Sinhvien")]
public partial class Sinhvien
{
    [Key]
    [StringLength(40)]
    public string MaSV { get; set; }

    [Required]
    [StringLength(40)]
    public string HoTenSV { get; set; }

    [Required]
    [StringLength(3)]
    public string MaLop { get; set; }

    public DateTime NgaySinh { get; set; }

    public virtual Lop Lop { get; set; }
}
