using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Warehouse.Models;

public class Stuff
{
    [Key]
    [StringLength(10)]
    public string StuffID { get; set; }

    [Required]
    [StringLength(50)]
    public string StuffName { get; set; }

    [Required]
    [Column(TypeName = "decimal(10,2)")]
    public decimal StuffPrice { get; set; }

    [Required]
    public int StuffQty { get; set; }

    [Required]
    public DateTime StuffExpired { get; set; }

    [Required]
    [StringLength(5)]
    public string StoreID { get; set; }

    [ForeignKey("StoreID")]
    public Store Store { get; set; }
}