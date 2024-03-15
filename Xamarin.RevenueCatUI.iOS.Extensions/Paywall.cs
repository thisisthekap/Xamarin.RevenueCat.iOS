using System.Threading;
using System.Threading.Tasks;
using RevenueCat;
using UIKit;

namespace Xamarin.RevenueCatUI.iOS.Extensions
{
    public static class Paywall
    {
        public static Task<RCCustomerInfo> PresentPaywallAsync(UIViewController topVC,
            CancellationToken cancellationToken = default)
        {
            var tcs = new TaskCompletionSource<RCCustomerInfo>();
            cancellationToken.Register(() => tcs.TrySetCanceled());

            RevenueCatUIProxy.PresentPaywallFrom(topVC, didFinishPurchasing: (customerInfo) =>
            {
                if (!cancellationToken.IsCancellationRequested)
                {
                    tcs.TrySetResult(customerInfo);
                }
            });

            return tcs.Task;
        }
    }
}