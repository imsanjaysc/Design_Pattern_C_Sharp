using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Creational.Abstract_Factory
{
    /*Scenario is we have three types of wallet in Modicare [Mwallet (Modicare Wallet), Twallet (Trade Wallet), MEWallet (Modicare Employee Wallet)].
    In these user can transfer money to their downline but before the transfer 
    we have to check the following points:
    1. Authorize the transaction that the user has sufficient balance in account.
    2. Authorize the transfer that user is sending to the downline.
    3. Authorize the transfer to check the user does not exceed daily transaction limit i.e 25000 for
        mwallet and 50000 for trade wallet.
    4. Authorize the transfer to check that user can send only 3 transaction per day. not more that that.
    5. MEWallet users can transfer but only 1 transaction in a day and a limit of 5000/-
    */

    // Abstract Products
    public interface IWalletAuthorization
    {
        bool AuthorizeWallet(decimal amount);
    }
    public interface IWalletTransfer
    {
        bool WalletTransfer(decimal amount);
    }

    // Concrete Products for MWallet
    public class MWalletAuthorization : IWalletAuthorization
    {
        public bool AuthorizeWallet(decimal amount)
        {
            Console.WriteLine($"Authorizing payment of {amount} via MWallet...");
            return true; // Mocked success
        }
    }
    public class MWalletTransfer : IWalletTransfer
    {
        public bool WalletTransfer(decimal amount)
        {
            Console.WriteLine($"Transferring payment of {amount} via MWallet...");
            return true; // Mocked success
        }
    }

    // Concrete Products for TWallet
    public class TWalletAuthorization : IWalletAuthorization
    {
        public bool AuthorizeWallet(decimal amount)
        {
            Console.WriteLine($"Authorizing payment of {amount} via TWallet...");
            return true; // Mocked success
        }
    }
    public class TWalletTransfer : IWalletTransfer
    {
        public bool WalletTransfer(decimal amount)
        {
            Console.WriteLine($"Transferring payment of {amount} via TWallet...");
            return true; // Mocked success
        }
    }

    // Concrete Products for MEWallet
    public class MEWalletAuthorization : IWalletAuthorization
    {
        public bool AuthorizeWallet(decimal amount)
        {
            Console.WriteLine($"Authorizing payment of {amount} via MEWallet...");
            return true; // Mocked success
        }
    }
    public class MEWalletTransfer : IWalletTransfer
    {
        public bool WalletTransfer(decimal amount)
        {
            Console.WriteLine($"Transferring payment of {amount} via TWallet...");
            return true; // Mocked success
        }
    }

}
