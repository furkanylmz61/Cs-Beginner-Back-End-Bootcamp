using System.ComponentModel.DataAnnotations;

namespace FormsApp.Models;

public class Product
{
    [Display(Name = "Ürün Id")]
    public int ProductId { get; set; }
    [Display(Name= "Ürün ADI")]
    [Required(ErrorMessage = "Ürün Adı zorunludur")]
    [StringLength(100)]
    public string Name { get; set; } = string.Empty;
    [Required]
    [Range(0,100000)]
    public decimal price { get; set; }
    [Required]
    public string Image { get; set; } = string.Empty;
    public bool isActive { get; set; }
    [Required]
    public int CategoryId { get; set; } //Category deki id ile eşlenecek
}