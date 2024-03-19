using System;
using Foundation;
using RevenueCat;
using UIKit;

namespace Xamarin.RevenueCatUI.iOS
{
	// @interface RevenueCatUIProxy : NSObject
	[BaseType (typeof(NSObject))]
	interface RevenueCatUIProxy
	{
		// +(NSString * _Nonnull)FancyString __attribute__((warn_unused_result("")));
		[Static]
		[Export ("FancyString")]
		string FancyString { get; }

		// +(void)presentPaywallFrom:(UIViewController * _Nonnull)topVC didFinishPurchasing:(void (^ _Nonnull)(RCCustomerInfo * _Nonnull))didFinishPurchasing;
		[Static]
		[Export ("presentPaywallFrom:didFinishPurchasing:")]
		void PresentPaywallFrom (UIViewController topVC, Action<RCCustomerInfo> didFinishPurchasing);
	}
}
