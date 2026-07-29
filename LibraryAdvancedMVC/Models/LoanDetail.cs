using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LibraryAdvancedMVC.Models;

[PrimaryKey("LoanTicketId", "BookId")]
public partial class LoanDetail
{
    [Key]
    public int LoanTicketId { get; set; }

    [Key]
    public int BookId { get; set; }

    public int Quantity { get; set; }

    [ForeignKey("BookId")]
    [InverseProperty("LoanDetails")]
    public virtual Book Book { get; set; } = null!;

    [ForeignKey("LoanTicketId")]
    [InverseProperty("LoanDetails")]
    public virtual LoanTicket LoanTicket { get; set; } = null!;
}
