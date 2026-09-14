using
    CashManagementSystem.Models.Enums;
namespace 
    CashManagementSystem.Models;

public class Transaction
{
    public int Id { get; set; }
    public decimal Amount { get; set; }
    public TransactionType Type { get; set; }
    public DateTime Date { get; set; }
    public string Description { get; set; } = string.Empty;
    public int CashBoxId { get; set; }
    public CashBox CashBox { get; set; } = null!;
    public int CategoryId { get; set; }
    public Category Category { get; set; } = null!;

}
