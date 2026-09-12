namespace 
    CashManagementSystem.Models;

public class CashBox
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Currency { get; set;  } = string.Empty;
    public decimal OpeningBalance {  get; set; }
    public DateTime CreatedDate { get; set; }
}
