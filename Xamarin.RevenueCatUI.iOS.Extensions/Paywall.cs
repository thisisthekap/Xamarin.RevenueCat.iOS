﻿using System;
using System.Threading;
using System.Threading.Tasks;
using RevenueCat;
using UIKit;

namespace Xamarin.RevenueCatUI.iOS.Extensions
{
    public static class Paywall
    {
        public static Task<RCCustomerInfo> PresentPaywallAsync(this UIViewController topVc, RCOffering offering,
            bool animate = false, CancellationToken cancellationToken = default)
        {
            var tcs = new TaskCompletionSource<RCCustomerInfo>();
            cancellationToken.Register(() => tcs.TrySetCanceled());
            var controller = new RCPaywallViewController(offering, true, null);
            var paywallDelegate = new DelegatedPaywallViewControllerDelegate(customerInfo =>
            {
                tcs.SetResult(customerInfo);
            });

            controller.Delegate = paywallDelegate;

            topVc.InvokeOnMainThread(() => { topVc.PresentViewController(controller, animate, null); });
            return tcs.Task;
        }

        public static Task<RCCustomerInfo> PushPaywallAsync(this UINavigationController navigationController,
            RCOffering offering, bool animate = false, CancellationToken cancellationToken = default)
        {
            var tcs = new TaskCompletionSource<RCCustomerInfo>();
            cancellationToken.Register(() => tcs.TrySetCanceled());
            var controller = new RCPaywallViewController(offering, true, null);
            var paywallDelegate = new DelegatedPaywallViewControllerDelegate(customerInfo =>
            {
                tcs.SetResult(customerInfo);
            });

            controller.Delegate = paywallDelegate;

            navigationController.InvokeOnMainThread(
                () => { navigationController.PushViewController(controller, animate); });
            return tcs.Task;
        }

        private class DelegatedPaywallViewControllerDelegate : RCPaywallViewControllerDelegate
        {
            private readonly Action<RCCustomerInfo> _callback;

            public DelegatedPaywallViewControllerDelegate(Action<RCCustomerInfo> callback)
            {
                _callback = callback ?? throw new ArgumentNullException(nameof(callback));
            }

            public override void DidFinishRestoring(RCPaywallViewController controller, RCCustomerInfo customerInfo)
            {
                _callback?.Invoke(customerInfo);
            }

            public override void DidFinishPurchasing(RCPaywallViewController controller, RCCustomerInfo customerInfo)
            {
                _callback?.Invoke(customerInfo);
            }
        }
    }
}