using System.Threading;
using System.Threading.Tasks;
using Foundation;
using Purchases;
using StoreKit;
using Xamarin.RevenueCat.iOS.Extensions.Exceptions;

namespace Xamarin.RevenueCat.iOS.Extensions
{
    public static class RCPurchasesExtensions
    {
        public static Task<RCPurchaserInfo> IdentifyAsync(this RCPurchases purchases, string appUserId,
            CancellationToken cancellationToken = default)
        {
            var tcs = new TaskCompletionSource<RCPurchaserInfo>();
            cancellationToken.Register(() => tcs.TrySetCanceled());
            purchases.Identify(appUserId, (purchaserInfo, error) =>
            {
                if (error != null)
                {
                    tcs.TrySetException(new PurchasesErrorException(error, false));
                }
                else
                {
                    tcs.TrySetResult(purchaserInfo);
                }
            });
            return tcs.Task;
        }

        public static Task<RCOfferings> GetOfferingsAsync(this RCPurchases purchases,
            CancellationToken cancellationToken = default)
        {
            var tcs = new TaskCompletionSource<RCOfferings>();
            cancellationToken.Register(() => tcs.TrySetCanceled());
            purchases.OfferingsWithCompletionBlock((RCOfferings offerings, NSError error) =>
            {
                if (error != null)
                {
                    tcs.TrySetException(new PurchasesErrorException(error, false));
                }
                else
                {
                    tcs.TrySetResult(offerings);
                }
            });
            return tcs.Task;
        }

        public static Task<PurchaseSuccessInfo> PurchasePackageAsync(this RCPurchases purchases,
            RCPackage packageToPurchase, CancellationToken cancellationToken = default)
        {
            var tcs = new TaskCompletionSource<PurchaseSuccessInfo>();
            cancellationToken.Register(() => tcs.TrySetCanceled());
            purchases.PurchasePackage(packageToPurchase,
                (SKPaymentTransaction transaction, RCPurchaserInfo purchaserInfo, NSError error, bool userCancelled) =>
                {
                    if (error != null)
                    {
                        tcs.TrySetException(new PurchasesErrorException(error, userCancelled));
                    }
                    else if (userCancelled)
                    {
                        tcs.TrySetException(new PurchasesErrorException(null, true));
                    }
                    else
                    {
                        tcs.TrySetResult(new PurchaseSuccessInfo(transaction, purchaserInfo));
                    }
                });
            return tcs.Task;
        }

        public static Task<RCPurchaserInfo> RestoreTransactionsAsync(this RCPurchases purchases,
            CancellationToken cancellationToken = default)
        {
            var tcs = new TaskCompletionSource<RCPurchaserInfo>();
            cancellationToken.Register(() => tcs.TrySetCanceled());
            purchases.RestoreTransactionsWithCompletionBlock((RCPurchaserInfo purchaserInfo, NSError error) =>
            {
                if (error != null)
                {
                    tcs.TrySetException(new PurchasesErrorException(error, false));
                }
                else
                {
                    tcs.TrySetResult(purchaserInfo);
                }
            });
            return tcs.Task;
        }

        public static Task<RCPurchaserInfo> GetPurchaserInfoAsync(this RCPurchases purchases,
            CancellationToken cancellationToken = default)
        {
            var tcs = new TaskCompletionSource<RCPurchaserInfo>();
            cancellationToken.Register(() => tcs.TrySetCanceled());
            purchases.PurchaserInfoWithCompletionBlock((RCPurchaserInfo purchaserInfo, NSError error) =>
            {
                if (error != null)
                {
                    tcs.TrySetException(new PurchasesErrorException(error, false));
                }
                else
                {
                    tcs.TrySetResult(purchaserInfo);
                }
            });
            return tcs.Task;
        }
    }
}
