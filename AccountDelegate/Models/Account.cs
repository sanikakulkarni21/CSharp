

namespace AccountDelegate.Models;

public class Account{

    public string Id {get; set;}

    public string Name {get; set;}

    private decimal Balance { get; set; }

    public decimal Amount {get; set;}
}
