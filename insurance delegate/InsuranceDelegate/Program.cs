
using System;


while(choice){
    Console.WriteLine("=============================");
    Console.WriteLine("Insurance Management System");
    Console.WriteLine("=============================");

    Console.WriteLine("Purchase Policy");
    Console.WriteLine("Pay Premium");
    Console.WriteLine("Register Claim");
    Console.WriteLine("Renew Policy");
    Console.WriteLine("Exit");

    choice=false;

    Switch(choice){

        case 1 :
        PurchasePolicy();
        break;

        case 2:
        PayPremium();
        break;

        case 3:
        RegisterClaim();

        case 4:
        RenewPolicy();
        break;

        case 5:
        Exit();
        break;


    }

    
    

    
    

}



