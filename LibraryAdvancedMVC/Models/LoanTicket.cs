using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LibraryAdvancedMVC.Models;

public partial class LoanTicket
{
    [Key]
    public int Id { get; set; }

    [StringLength(150)]
    public string BorrowerName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? BorrowDate { get; set; }

    [StringLength(50)]
    public string? Status { get; set; }

    [InverseProperty("LoanTicket")]
    public virtual ICollection<LoanDetail> LoanDetails { get; set; } = new List<LoanDetail>();
}