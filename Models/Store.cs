using System.ComponentModel.DataAnnotations;

namespace Warehouse.Models;

public class Store
{
    [Key] 
    [StringLength(5)] public string StoreID { get; set; }

    [Required] 
    [StringLength(50)] public string StoreName { get; set; }
}