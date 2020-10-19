using Purchases;
using StoreKit;

namespace Xamarin.RevenueCat.iOS.Extensions
{
    public class PurchaseSuccessInfo
    {
        public SKPaymentTransaction Transaction { get; }
        public RCPurchaserInfo PurchaserInfo { get; }

        public PurchaseSuccessInfo(SKPaymentTransaction transaction, RCPurchaserInfo purchaserInfo)
        {
            Transaction = transaction;
            PurchaserInfo = purchaserInfo;
        }
    }
}
