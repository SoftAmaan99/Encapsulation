using System;
namespace Encapsulation;
public class Bank
{
    public long AccountNumber;
    public string? Name;
    private double Balance;
    // public double GetBalance()
    // {
    //     return Balance;
    // }
    // public void SetBalance(double _Balance)
    // {
    //     if (_Balance > 0)
    //     {
    //         this.Balance = _Balance;
    //     }
    //     else
    //     {
    //         throw new Exception("Please enter a positive amount");
    //     }
    // }
    // instead to apply setter and getter . use properties 
    public double amount
    {
        get
        {
            return Balance;
        }
        set
        {
            if (value < 0)
            {
                throw new Exception("Enter positive value");
            }
            else
            {
                Balance = value;
            }
        }
    }
}