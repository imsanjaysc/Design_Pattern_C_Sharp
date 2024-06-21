using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Creational.Abstract_Factory
{
    public class PaymentProcessor
    {
        private readonly IWalletAuthorization _authorization;
        private readonly IWalletTransfer _transfer;
        public PaymentProcessor(WalletFactory factory)
        {
            _authorization = factory.CreateAuthorization();
            _transfer = factory.CreateTransfer();
        }
        public bool ProcessPayment(decimal amount)
        {
            if (_authorization.AuthorizeWallet(amount))
            {
                return _transfer.WalletTransfer(amount);
            }
            return false;
        }
    }
}

/*
Program.cs File
------------------------
using Design_Pattern.Creational.Abstract_Factory;

Console.WriteLine("Processing payment using MWallet:");
var mwalletFactory = new MWalletFactory();
var mwalletProcessor = new PaymentProcessor(mwalletFactory);
mwalletProcessor.ProcessPayment(100.00M);

Console.WriteLine("\nProcessing payment using TWallet:");
var twalletFactory = new TWalletFactory();
var twalletProcessor = new PaymentProcessor(twalletFactory);
twalletProcessor.ProcessPayment(100.00M);

Console.WriteLine("\nProcessing payment using MEWallet:");
var me_walletFactory = new TWalletFactory();
var me_walletProcessor = new PaymentProcessor(me_walletFactory);
me_walletProcessor.ProcessPayment(100.00M);
Console.ReadKey();
*/