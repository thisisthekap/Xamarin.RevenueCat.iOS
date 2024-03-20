using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;
using RevenueCat;

namespace Xamarin.RevenueCatUI.iOS
{
    // @interface RCPaywallViewController : UIViewController
    [BaseType (typeof(UIViewController))]
    [DisableDefaultCtor]
    interface RCPaywallViewController
    {
        [Wrap ("WeakDelegate")]
        [NullAllowed]
        RCPaywallViewControllerDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<RCPaywallViewControllerDelegate> _Nullable delegate;
        [NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // -(instancetype _Nonnull)initWithOffering:(RCOffering * _Nullable)offering displayCloseButton:(BOOL)displayCloseButton dismissRequestedHandler:(void (^ _Nullable)(RCPaywallViewController * _Nonnull))dismissRequestedHandler;
        [Export ("initWithOffering:displayCloseButton:dismissRequestedHandler:")]
        IntPtr Constructor ([NullAllowed] RCOffering offering, bool displayCloseButton, [NullAllowed] Action<RCPaywallViewController> dismissRequestedHandler);
        
        // -(void)loadView;
        [Export ("loadView")]
        void LoadView ();

        // -(void)viewDidDisappear:(BOOL)animated;
        [Export ("viewDidDisappear:")]
        void ViewDidDisappear (bool animated);

        // -(void)updateWithOffering:(RCOffering * _Nonnull)offering;
        [Export ("updateWithOffering:")]
        void UpdateWithOffering (RCOffering offering);

        // -(void)updateWithOfferingIdentifier:(NSString * _Nonnull)offeringIdentifier;
        [Export ("updateWithOfferingIdentifier:")]
        void UpdateWithOfferingIdentifier (string offeringIdentifier);

        // -(void)updateWithDisplayCloseButton:(BOOL)displayCloseButton;
        [Export ("updateWithDisplayCloseButton:")]
        void UpdateWithDisplayCloseButton (bool displayCloseButton);

        // -(void)updateFontWithFontName:(NSString * _Nonnull)fontName;
        [Export ("updateFontWithFontName:")]
        void UpdateFontWithFontName (string fontName);
    }

    // @interface RCPaywallFooterViewController : RCPaywallViewController
    [BaseType (typeof(RCPaywallViewController))]
    [DisableDefaultCtor]
    interface RCPaywallFooterViewController
    {
        // -(instancetype _Nonnull)initWithOffering:(RCOffering * _Nullable)offering dismissRequestedHandler:(void (^ _Nullable)(RCPaywallViewController * _Nonnull))dismissRequestedHandler __attribute__((objc_designated_initializer));
        [Export ("initWithOffering:dismissRequestedHandler:")]
        [DesignatedInitializer]
        IntPtr Constructor ([NullAllowed] RCOffering offering, [NullAllowed] Action<RCPaywallViewController> dismissRequestedHandler);

        // -(instancetype _Nonnull)initWithOfferingIdentifier:(NSString * _Nonnull)offeringIdentifier dismissRequestedHandler:(void (^ _Nullable)(RCPaywallViewController * _Nonnull))dismissRequestedHandler __attribute__((objc_designated_initializer));
        [Export ("initWithOfferingIdentifier:dismissRequestedHandler:")]
        [DesignatedInitializer]
        IntPtr Constructor (string offeringIdentifier, [NullAllowed] Action<RCPaywallViewController> dismissRequestedHandler);

        // -(instancetype _Nonnull)initWithOfferingIdentifier:(NSString * _Nonnull)offeringIdentifier fontName:(NSString * _Nonnull)fontName dismissRequestedHandler:(void (^ _Nullable)(RCPaywallViewController * _Nonnull))dismissRequestedHandler __attribute__((objc_designated_initializer));
        [Export ("initWithOfferingIdentifier:fontName:dismissRequestedHandler:")]
        [DesignatedInitializer]
        IntPtr Constructor (string offeringIdentifier, string fontName, [NullAllowed] Action<RCPaywallViewController> dismissRequestedHandler);
    }

    // @protocol RCPaywallViewControllerDelegate
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface RCPaywallViewControllerDelegate
    {
        // @optional -(void)paywallViewControllerDidStartPurchase:(RCPaywallViewController * _Nonnull)controller;
        [Export ("paywallViewControllerDidStartPurchase:")]
        void PaywallViewControllerDidStartPurchase (RCPaywallViewController controller);

        // @optional -(void)paywallViewController:(RCPaywallViewController * _Nonnull)controller didStartPurchaseWithPackage:(RCPackage * _Nonnull)package;
        [Export ("paywallViewController:didStartPurchaseWithPackage:")]
        void PaywallViewController (RCPaywallViewController controller, RCPackage package);

        // @optional -(void)paywallViewController:(RCPaywallViewController * _Nonnull)controller didFinishPurchasingWithCustomerInfo:(RCCustomerInfo * _Nonnull)customerInfo;
        [Export ("paywallViewController:didFinishPurchasingWithCustomerInfo:")]
        void PaywallViewController (RCPaywallViewController controller, RCCustomerInfo customerInfo);

        // @optional -(void)paywallViewController:(RCPaywallViewController * _Nonnull)controller didFinishPurchasingWithCustomerInfo:(RCCustomerInfo * _Nonnull)customerInfo transaction:(RCStoreTransaction * _Nullable)transaction;
        [Export ("paywallViewController:didFinishPurchasingWithCustomerInfo:transaction:")]
        void PaywallViewController (RCPaywallViewController controller, RCCustomerInfo customerInfo, [NullAllowed] RCStoreTransaction transaction);

        // @optional -(void)paywallViewControllerDidCancelPurchase:(RCPaywallViewController * _Nonnull)controller;
        [Export ("paywallViewControllerDidCancelPurchase:")]
        void PaywallViewControllerDidCancelPurchase (RCPaywallViewController controller);

        // @optional -(void)paywallViewController:(RCPaywallViewController * _Nonnull)controller didFailPurchasingWithError:(NSError * _Nonnull)error;
        [Export ("paywallViewController:didFailPurchasingWithError:")]
        void PaywallViewController (RCPaywallViewController controller, NSError error);

        // @optional -(void)paywallViewControllerDidStartRestore:(RCPaywallViewController * _Nonnull)controller;
        [Export ("paywallViewControllerDidStartRestore:")]
        void PaywallViewControllerDidStartRestore (RCPaywallViewController controller);

        // @optional -(void)paywallViewController:(RCPaywallViewController * _Nonnull)controller didFinishRestoringWithCustomerInfo:(RCCustomerInfo * _Nonnull)customerInfo;
        [Export ("paywallViewController:didFinishRestoringWithCustomerInfo:")]
        void PaywallViewControllerDidFinishRestoringWithCustomerInfo (RCPaywallViewController controller, RCCustomerInfo customerInfo);

        // @optional -(void)paywallViewController:(RCPaywallViewController * _Nonnull)controller didFailRestoringWithError:(NSError * _Nonnull)error;
        [Export ("paywallViewController:didFailRestoringWithError:")]
        void PaywallViewControllerDidFailRestoringWithError (RCPaywallViewController controller, NSError error);

        // @optional -(void)paywallViewControllerWasDismissed:(RCPaywallViewController * _Nonnull)controller;
        [Export ("paywallViewControllerWasDismissed:")]
        void PaywallViewControllerWasDismissed (RCPaywallViewController controller);

        // @optional -(void)paywallViewController:(RCPaywallViewController * _Nonnull)controller didChangeSizeTo:(CGSize)size;
        [Export ("paywallViewController:didChangeSizeTo:")]
        void PaywallViewController (RCPaywallViewController controller, CGSize size);
    }
}
