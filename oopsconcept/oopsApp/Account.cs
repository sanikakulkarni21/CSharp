
using system;

namespace Banking;

class Account {

    public static int count;
    private decimal balance;//encapsulation
    public decimal Balance {
        get{
            return this.balance;
        }

        set{
            if (value >=2000)
            {
                this.balance=value;
            }else{
                throw new ArgumentException("balance should be greater than 2000");
            }
        }
    }


    




}