using System;
using System.Threading;
using System.Threading.Tasks;
using RevenueCat;
using UIKit;

namespace Xamarin.RevenueCatUI.iOS.Extensions
{
    public static class Paywall
    {
        public static Task<RCCustomerInfo> PresentPaywallAsync(this UIViewController topVc, RCOffering offering,
            CancellationToken cancellationToken = default)
        {
            var tcs = new TaskCompletionSource<RCCustomerInfo>();
            var controller = new RCPaywallViewController(offering, true, null);
            var paywallDelegate = new DelegatedPaywallViewControllerDelegate(customerInfo =>
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    tcs.SetCanceled();
                }
                else
                {
                    tcs.SetResult(customerInfo);
                }
            });

            controller.Delegate = paywallDelegate;

            topVc.InvokeOnMainThread(() => { topVc.PresentViewController(controller, true, null); });

            return tcs.Task;
        }

        private class DelegatedPaywallViewControllerDelegate : RCPaywallViewControllerDelegate
        {
            private readonly Action<RCCustomerInfo> _callback;

            public DelegatedPaywallViewControllerDelegate(Action<RCCustomerInfo> callback)
            {
                _callback = callback ?? throw new ArgumentNullException(nameof(callback));
            }

            public override void PaywallViewControllerDidFinishRestoringWithCustomerInfo(
                RCPaywallViewController controller, RCCustomerInfo customerInfo)
            {
                _callback?.Invoke(customerInfo);
            }
        }
    }
}