using System;
using Foundation;
using RevenueCat;
using UIKit;

namespace Xamarin.RevenueCatUI.iOS
{
	// @interface RevenueCatUIProxy : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface RevenueCatUIProxy
	{
		// +(void)presentPaywallFrom:(UIViewController * _Nonnull)topVC didFinishPurchasing:(void (^ _Nonnull)(RCCustomerInfo * _Nonnull))didFinishPurchasing;
		[Static]
		[Export ("presentPaywallFrom:didFinishPurchasing:")]
		void PresentPaywallFrom (UIViewController topVC, Action<RCCustomerInfo> didFinishPurchasing);
	}
}
