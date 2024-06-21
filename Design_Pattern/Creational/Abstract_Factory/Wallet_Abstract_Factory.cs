
namespace Design_Pattern.Creational.Abstract_Factory
{ 
    public abstract class WalletFactory
    {
        public abstract IWalletAuthorization CreateAuthorization();
        public abstract IWalletTransfer CreateTransfer();

        public virtual bool CheckWalletTransferAvailibilty()
        {
            return true;
        }
    }

    // Concrete Factories
    public class MWalletFactory : WalletFactory
    {
        public override IWalletAuthorization CreateAuthorization()
        {
            return new MWalletAuthorization();
        }
        public override IWalletTransfer CreateTransfer() => new MWalletTransfer();
    }
    public class TWalletFactory : WalletFactory
    {
        public override IWalletAuthorization CreateAuthorization() => new TWalletAuthorization();
        public override IWalletTransfer CreateTransfer() => new TWalletTransfer();
    }
    public class MEWalletFactory : WalletFactory
    {
        public override IWalletAuthorization CreateAuthorization() => new TWalletAuthorization();
        public override IWalletTransfer CreateTransfer() => new TWalletTransfer();
    }
}
