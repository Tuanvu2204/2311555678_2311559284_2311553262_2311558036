using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LibraryAdvancedMVC.Models;

public partial class Book
{
    [Key]
    public int Id { get; set; }

    [StringLength(200)]
    public string Title { get; set; } = null!;

    [StringLength(150)]
    public string Author { get; set; } = null!;

    public int AvailableQuantity { get; set; }

    public int CategoryId { get; set; }

    [ForeignKey("CategoryId")]
    [InverseProperty("Books")]
    public virtual Category Category { get; set; } = null!;

    [InverseProperty("Book")]
    public virtual ICollection<LoanDetail> LoanDetails { get; set; } = new List<LoanDetail>();
}
