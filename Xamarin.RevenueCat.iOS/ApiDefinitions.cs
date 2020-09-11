using Foundation;
using ObjCRuntime;
using Purchases;
using StoreKit;

namespace Purchases
{
	[Static]
	partial interface Constants
	{
		// extern double PurchasesVersionNumber;
		[Field ("PurchasesVersionNumber", "__Internal")]
		double PurchasesVersionNumber { get; }

		// extern const unsigned char [] PurchasesVersionString;
		[Field ("PurchasesVersionString", "__Internal")]
		NSString PurchasesVersionString { get; }
	}

	// @interface RCOffering : NSObject
	[BaseType (typeof(NSObject))]
	interface RCOffering : INativeObject
	{
		// @property (readonly) NSString * _Nonnull identifier;
		[Export ("identifier")]
		string Identifier { get; }

		// @property (readonly) NSString * _Nonnull serverDescription;
		[Export ("serverDescription")]
		string ServerDescription { get; }

		// @property (readonly) NSArray<RCPackage *> * _Nonnull availablePackages;
		[Export ("availablePackages")]
		RCPackage[] AvailablePackages { get; }

		// @property (readonly) RCPackage * _Nullable lifetime;
		[NullAllowed, Export ("lifetime")]
		RCPackage Lifetime { get; }

		// @property (readonly) RCPackage * _Nullable annual;
		[NullAllowed, Export ("annual")]
		RCPackage Annual { get; }

		// @property (readonly) RCPackage * _Nullable sixMonth;
		[NullAllowed, Export ("sixMonth")]
		RCPackage SixMonth { get; }

		// @property (readonly) RCPackage * _Nullable threeMonth;
		[NullAllowed, Export ("threeMonth")]
		RCPackage ThreeMonth { get; }

		// @property (readonly) RCPackage * _Nullable twoMonth;
		[NullAllowed, Export ("twoMonth")]
		RCPackage TwoMonth { get; }

		// @property (readonly) RCPackage * _Nullable monthly;
		[NullAllowed, Export ("monthly")]
		RCPackage Monthly { get; }

		// @property (readonly) RCPackage * _Nullable weekly;
		[NullAllowed, Export ("weekly")]
		RCPackage Weekly { get; }

		// -(RCPackage * _Nullable)packageWithIdentifier:(NSString * _Nullable)identifier __attribute__((swift_name("package(identifier:)")));
		[Export ("packageWithIdentifier:")]
		[return: NullAllowed]
		RCPackage PackageWithIdentifier ([NullAllowed] string identifier);

		// -(RCPackage * _Nullable)objectForKeyedSubscript:(NSString * _Nonnull)key;
		[Export ("objectForKeyedSubscript:")]
		[return: NullAllowed]
		RCPackage ObjectForKeyedSubscript (string key);
	}

	// @interface RCOfferings : NSObject
	[BaseType (typeof(NSObject))]
	interface RCOfferings : INativeObject
	{
		// @property (readonly) RCOffering * _Nullable current;
		[NullAllowed, Export ("current")]
		RCOffering Current { get; }

		// @property (readonly) NSDictionary<NSString *,RCOffering *> * _Nonnull all;
		[Export ("all")]
		NSDictionary<NSString, RCOffering> All { get; }

		// -(RCOffering * _Nullable)offeringWithIdentifier:(NSString * _Nullable)identifier __attribute__((swift_name("offering(identifier:)")));
		[Export ("offeringWithIdentifier:")]
		[return: NullAllowed]
		RCOffering OfferingWithIdentifier ([NullAllowed] string identifier);

		// -(RCOffering * _Nullable)objectForKeyedSubscript:(NSString * _Nonnull)key;
		[Export ("objectForKeyedSubscript:")]
		[return: NullAllowed]
		RCOffering ObjectForKeyedSubscript (string key);
	}

	// typedef void (^RCReceivePurchaserInfoBlock)(RCPurchaserInfo * _Nullable, NSError * _Nullable);
	delegate void RCReceivePurchaserInfoBlock ([NullAllowed] RCPurchaserInfo arg0, [NullAllowed] NSError arg1);

	// typedef void (^RCReceiveIntroEligibilityBlock)(NSDictionary<NSString *,RCIntroEligibility *> * _Nonnull);
	delegate void RCReceiveIntroEligibilityBlock (NSDictionary<NSString, RCIntroEligibility> arg0);

	// typedef void (^RCReceiveOfferingsBlock)(RCOfferings * _Nullable, NSError * _Nullable);
	delegate void RCReceiveOfferingsBlock ([NullAllowed] RCOfferings arg0, [NullAllowed] NSError arg1);

	// typedef void (^RCReceiveProductsBlock)(NSArray<SKProduct *> * _Nonnull);
	delegate void RCReceiveProductsBlock (SKProduct[] arg0);

	// typedef void (^RCPurchaseCompletedBlock)(SKPaymentTransaction * _Nullable, RCPurchaserInfo * _Nullable, NSError * _Nullable, BOOL);
	delegate void RCPurchaseCompletedBlock ([NullAllowed] SKPaymentTransaction arg0, [NullAllowed] RCPurchaserInfo arg1, [NullAllowed] NSError arg2, bool arg3);

	// typedef void (^RCDeferredPromotionalPurchaseBlock)(RCPurchaseCompletedBlock _Nonnull);
	delegate void RCDeferredPromotionalPurchaseBlock (RCPurchaseCompletedBlock arg0);

	// typedef void (^RCPaymentDiscountBlock)(SKPaymentDiscount * _Nullable, NSError * _Nullable);
	delegate void RCPaymentDiscountBlock ([NullAllowed] SKPaymentDiscount arg0, [NullAllowed] NSError arg1);

	// @interface RCPurchases : NSObject
	[BaseType (typeof(NSObject))]
	interface RCPurchases : INativeObject
	{
		// @property (assign, nonatomic, class) BOOL automaticAppleSearchAdsAttributionCollection;
		[Static]
		[Export ("automaticAppleSearchAdsAttributionCollection")]
		bool AutomaticAppleSearchAdsAttributionCollection { get; set; }

		// @property (assign, nonatomic, class) BOOL debugLogsEnabled;
		[Static]
		[Export ("debugLogsEnabled")]
		bool DebugLogsEnabled { get; set; }

		// @property (copy, nonatomic, class) NSURL * _Nullable proxyURL;
		[Static]
		[NullAllowed, Export ("proxyURL", ArgumentSemantic.Copy)]
		NSUrl ProxyURL { get; set; }

		// +(instancetype _Nonnull)configureWithAPIKey:(NSString * _Nonnull)APIKey;
		[Static]
		[Export ("configureWithAPIKey:")]
		RCPurchases ConfigureWithAPIKey (string APIKey);

		// +(instancetype _Nonnull)configureWithAPIKey:(NSString * _Nonnull)APIKey appUserID:(NSString * _Nullable)appUserID;
		[Static]
		[Export ("configureWithAPIKey:appUserID:")]
		RCPurchases ConfigureWithAPIKey (string APIKey, [NullAllowed] string appUserID);

		// +(instancetype _Nonnull)configureWithAPIKey:(NSString * _Nonnull)APIKey appUserID:(NSString * _Nullable)appUserID observerMode:(BOOL)observerMode;
		[Static]
		[Export ("configureWithAPIKey:appUserID:observerMode:")]
		RCPurchases ConfigureWithAPIKey (string APIKey, [NullAllowed] string appUserID, bool observerMode);

		// +(instancetype _Nonnull)configureWithAPIKey:(NSString * _Nonnull)APIKey appUserID:(NSString * _Nullable)appUserID observerMode:(BOOL)observerMode userDefaults:(NSUserDefaults * _Nullable)userDefaults;
		[Static]
		[Export ("configureWithAPIKey:appUserID:observerMode:userDefaults:")]
		RCPurchases ConfigureWithAPIKey (string APIKey, [NullAllowed] string appUserID, bool observerMode, [NullAllowed] NSUserDefaults userDefaults);

		// +(BOOL)canMakePayments;
		[Static]
		[Export ("canMakePayments")]
		bool CanMakePayments { get; }

		// @property (readonly, nonatomic, class) RCPurchases * _Nonnull sharedPurchases;
		[Static]
		[Export ("sharedPurchases")]
		RCPurchases SharedPurchases { get; }

		// @property (nonatomic) BOOL allowSharingAppStoreAccount;
		[Export ("allowSharingAppStoreAccount")]
		bool AllowSharingAppStoreAccount { get; set; }

		// @property (nonatomic) BOOL finishTransactions;
		[Export ("finishTransactions")]
		bool FinishTransactions { get; set; }

		// +(NSString * _Nonnull)frameworkVersion;
		[Static]
		[Export ("frameworkVersion")]
		string FrameworkVersion { get; }

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		RCPurchasesDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<RCPurchasesDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (readonly, nonatomic) NSString * _Nonnull appUserID;
		[Export ("appUserID")]
		string AppUserID { get; }

		// @property (readonly, nonatomic) BOOL isAnonymous;
		[Export ("isAnonymous")]
		bool IsAnonymous { get; }

		// -(void)createAlias:(NSString * _Nonnull)alias completionBlock:(RCReceivePurchaserInfoBlock _Nullable)completion __attribute__((swift_name("createAlias(_:_:)")));
		[Export ("createAlias:completionBlock:")]
		void CreateAlias (string alias, [NullAllowed] RCReceivePurchaserInfoBlock completion);

		// -(void)identify:(NSString * _Nonnull)appUserID completionBlock:(RCReceivePurchaserInfoBlock _Nullable)completion __attribute__((swift_name("identify(_:_:)")));
		[Export ("identify:completionBlock:")]
		void Identify (string appUserID, [NullAllowed] RCReceivePurchaserInfoBlock completion);

		// -(void)resetWithCompletionBlock:(RCReceivePurchaserInfoBlock _Nullable)completion __attribute__((swift_name("reset(_:)")));
		[Export ("resetWithCompletionBlock:")]
		void ResetWithCompletionBlock ([NullAllowed] RCReceivePurchaserInfoBlock completion);

		// +(void)addAttributionData:(NSDictionary * _Nonnull)data fromNetwork:(RCAttributionNetwork)network;
		[Static]
		[Export ("addAttributionData:fromNetwork:")]
		void AddAttributionData (NSDictionary data, RCAttributionNetwork network);

		// +(void)addAttributionData:(NSDictionary * _Nonnull)data fromNetwork:(RCAttributionNetwork)network forNetworkUserId:(NSString * _Nullable)networkUserId __attribute__((swift_name("addAttributionData(_:from:forNetworkUserId:)")));
		[Static]
		[Export ("addAttributionData:fromNetwork:forNetworkUserId:")]
		void AddAttributionData (NSDictionary data, RCAttributionNetwork network, [NullAllowed] string networkUserId);

		// -(void)purchaserInfoWithCompletionBlock:(RCReceivePurchaserInfoBlock _Nonnull)completion __attribute__((swift_name("purchaserInfo(_:)")));
		[Export ("purchaserInfoWithCompletionBlock:")]
		void PurchaserInfoWithCompletionBlock (RCReceivePurchaserInfoBlock completion);

		// -(void)offeringsWithCompletionBlock:(RCReceiveOfferingsBlock _Nonnull)completion __attribute__((swift_name("offerings(_:)")));
		[Export ("offeringsWithCompletionBlock:")]
		void OfferingsWithCompletionBlock (RCReceiveOfferingsBlock completion);

		// -(void)productsWithIdentifiers:(NSArray<NSString *> * _Nonnull)productIdentifiers completionBlock:(RCReceiveProductsBlock _Nonnull)completion __attribute__((swift_name("products(_:_:)")));
		[Export ("productsWithIdentifiers:completionBlock:")]
		void ProductsWithIdentifiers (string[] productIdentifiers, RCReceiveProductsBlock completion);

		// -(void)purchaseProduct:(SKProduct * _Nonnull)product withCompletionBlock:(RCPurchaseCompletedBlock _Nonnull)completion __attribute__((swift_name("purchaseProduct(_:_:)")));
		[Export ("purchaseProduct:withCompletionBlock:")]
		void PurchaseProduct (SKProduct product, RCPurchaseCompletedBlock completion);

		// -(void)purchasePackage:(RCPackage * _Nonnull)package withCompletionBlock:(RCPurchaseCompletedBlock _Nonnull)completion __attribute__((swift_name("purchasePackage(_:_:)")));
		[Export ("purchasePackage:withCompletionBlock:")]
		void PurchasePackage (RCPackage package, RCPurchaseCompletedBlock completion);

		// -(void)restoreTransactionsWithCompletionBlock:(RCReceivePurchaserInfoBlock _Nullable)completion __attribute__((swift_name("restoreTransactions(_:)")));
		[Export ("restoreTransactionsWithCompletionBlock:")]
		void RestoreTransactionsWithCompletionBlock ([NullAllowed] RCReceivePurchaserInfoBlock completion);

		// -(void)checkTrialOrIntroductoryPriceEligibility:(NSArray<NSString *> * _Nonnull)productIdentifiers completionBlock:(RCReceiveIntroEligibilityBlock _Nonnull)receiveEligibility;
		[Export ("checkTrialOrIntroductoryPriceEligibility:completionBlock:")]
		void CheckTrialOrIntroductoryPriceEligibility (string[] productIdentifiers, RCReceiveIntroEligibilityBlock receiveEligibility);

		// -(void)paymentDiscountForProductDiscount:(SKProductDiscount * _Nonnull)discount product:(SKProduct * _Nonnull)product completion:(RCPaymentDiscountBlock _Nonnull)completion __attribute__((availability(ios, introduced=12.2))) __attribute__((availability(macos, introduced=10.14.4)));
		[Mac (10,14,4), iOS (12,2)]
		[Export ("paymentDiscountForProductDiscount:product:completion:")]
		void PaymentDiscountForProductDiscount (SKProductDiscount discount, SKProduct product, RCPaymentDiscountBlock completion);

		// -(void)purchaseProduct:(SKProduct * _Nonnull)product withDiscount:(SKPaymentDiscount * _Nonnull)discount completionBlock:(RCPurchaseCompletedBlock _Nonnull)completion __attribute__((swift_name("purchaseProduct(_:discount:_:)"))) __attribute__((availability(ios, introduced=12.2))) __attribute__((availability(macos, introduced=10.14.4)));
		[Mac (10,14,4), iOS (12,2)]
		[Export ("purchaseProduct:withDiscount:completionBlock:")]
		void PurchaseProduct (SKProduct product, SKPaymentDiscount discount, RCPurchaseCompletedBlock completion);

		// -(void)purchasePackage:(RCPackage * _Nonnull)package withDiscount:(SKPaymentDiscount * _Nonnull)discount completionBlock:(RCPurchaseCompletedBlock _Nonnull)completion __attribute__((swift_name("purchasePackage(_:discount:_:)"))) __attribute__((availability(ios, introduced=12.2))) __attribute__((availability(macos, introduced=10.14.4)));
		[Mac (10,14,4), iOS (12,2)]
		[Export ("purchasePackage:withDiscount:completionBlock:")]
		void PurchasePackage (RCPackage package, SKPaymentDiscount discount, RCPurchaseCompletedBlock completion);

		// -(void)invalidatePurchaserInfoCache;
		[Export ("invalidatePurchaserInfoCache")]
		void InvalidatePurchaserInfoCache ();

		// -(void)setAttributes:(NSDictionary<NSString *,NSString *> * _Nonnull)attributes;
		[Export ("setAttributes:")]
		void SetAttributes (NSDictionary<NSString, NSString> attributes);

		// -(void)setEmail:(NSString * _Nullable)email;
		[Export ("setEmail:")]
		void SetEmail ([NullAllowed] string email);

		// -(void)setPhoneNumber:(NSString * _Nullable)phoneNumber;
		[Export ("setPhoneNumber:")]
		void SetPhoneNumber ([NullAllowed] string phoneNumber);

		// -(void)setDisplayName:(NSString * _Nullable)displayName;
		[Export ("setDisplayName:")]
		void SetDisplayName ([NullAllowed] string displayName);

		// -(void)setPushToken:(NSData * _Nullable)pushToken;
		[Export ("setPushToken:")]
		void SetPushToken ([NullAllowed] NSData pushToken);
	}

	// typedef void (^RCReceiveEntitlementsBlock)(id _Nullable, NSError * _Nullable);
	delegate void RCReceiveEntitlementsBlock ([NullAllowed] NSObject arg0, [NullAllowed] NSError arg1);

	// @protocol RCPurchasesDelegate <NSObject>
	[Protocol, Model (AutoGeneratedName = true)]
	[BaseType (typeof(NSObject))]
	interface RCPurchasesDelegate : INativeObject
	{
		// @optional -(void)purchases:(RCPurchases * _Nonnull)purchases didReceiveUpdatedPurchaserInfo:(RCPurchaserInfo * _Nonnull)purchaserInfo __attribute__((swift_name("purchases(_:didReceiveUpdated:)")));
		[Export ("purchases:didReceiveUpdatedPurchaserInfo:")]
		void DidReceiveUpdatedPurchaserInfo (RCPurchases purchases, RCPurchaserInfo purchaserInfo);

		// @optional -(void)purchases:(RCPurchases * _Nonnull)purchases shouldPurchasePromoProduct:(SKProduct * _Nonnull)product defermentBlock:(RCDeferredPromotionalPurchaseBlock _Nonnull)makeDeferredPurchase;
		[Export ("purchases:shouldPurchasePromoProduct:defermentBlock:")]
		void ShouldPurchasePromoProduct (RCPurchases purchases, SKProduct product, RCDeferredPromotionalPurchaseBlock makeDeferredPurchase);
	}

	// @interface RCPurchaserInfo : NSObject
	[BaseType (typeof(NSObject))]
	interface RCPurchaserInfo : INativeObject
	{
		// @property (readonly, nonatomic) RCEntitlementInfos * _Nonnull entitlements;
		[Export ("entitlements")]
		RCEntitlementInfos Entitlements { get; }

		// @property (readonly, nonatomic) NSSet<NSString *> * _Nonnull activeSubscriptions;
		[Export ("activeSubscriptions")]
		NSSet<NSString> ActiveSubscriptions { get; }

		// @property (readonly, nonatomic) NSSet<NSString *> * _Nonnull allPurchasedProductIdentifiers;
		[Export ("allPurchasedProductIdentifiers")]
		NSSet<NSString> AllPurchasedProductIdentifiers { get; }

		// @property (readonly) NSDate * _Nullable latestExpirationDate;
		[NullAllowed, Export ("latestExpirationDate")]
		NSDate LatestExpirationDate { get; }

		// @property (readonly, nonatomic) NSSet<NSString *> * _Nonnull nonConsumablePurchases;
		[Export ("nonConsumablePurchases")]
		NSSet<NSString> NonConsumablePurchases { get; }

		// @property (readonly, nonatomic) NSString * _Nullable originalApplicationVersion;
		[NullAllowed, Export ("originalApplicationVersion")]
		string OriginalApplicationVersion { get; }

		// @property (readonly, nonatomic) NSDate * _Nullable originalPurchaseDate;
		[NullAllowed, Export ("originalPurchaseDate")]
		NSDate OriginalPurchaseDate { get; }

		// @property (readonly, nonatomic) NSDate * _Nullable requestDate;
		[NullAllowed, Export ("requestDate")]
		NSDate RequestDate { get; }

		// @property (readonly, nonatomic) NSDate * _Nonnull firstSeen;
		[Export ("firstSeen")]
		NSDate FirstSeen { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull originalAppUserId;
		[Export ("originalAppUserId")]
		string OriginalAppUserId { get; }

		// @property (readonly, nonatomic) NSURL * _Nullable managementURL;
		[NullAllowed, Export ("managementURL")]
		NSUrl ManagementURL { get; }

		// -(NSDate * _Nullable)expirationDateForProductIdentifier:(NSString * _Nonnull)productIdentifier;
		[Export ("expirationDateForProductIdentifier:")]
		[return: NullAllowed]
		NSDate ExpirationDateForProductIdentifier (string productIdentifier);

		// -(NSDate * _Nullable)purchaseDateForProductIdentifier:(NSString * _Nonnull)productIdentifier;
		[Export ("purchaseDateForProductIdentifier:")]
		[return: NullAllowed]
		NSDate PurchaseDateForProductIdentifier (string productIdentifier);

		// -(NSDate * _Nullable)expirationDateForEntitlement:(NSString * _Nonnull)entitlementId;
		[Export ("expirationDateForEntitlement:")]
		[return: NullAllowed]
		NSDate ExpirationDateForEntitlement (string entitlementId);

		// -(NSDate * _Nullable)purchaseDateForEntitlement:(NSString * _Nonnull)entitlementId;
		[Export ("purchaseDateForEntitlement:")]
		[return: NullAllowed]
		NSDate PurchaseDateForEntitlement (string entitlementId);
	}

	// @interface RCIntroEligibility : NSObject
	[BaseType (typeof(NSObject))]
	interface RCIntroEligibility : INativeObject
	{
		// @property (readonly) RCIntroEligibilityStatus status;
		[Export ("status")]
		RCIntroEligibilityStatus Status { get; }
	}

	// @interface RCPackage : NSObject
	[BaseType (typeof(NSObject))]
	interface RCPackage : INativeObject
	{
		// @property (readonly) NSString * _Nonnull identifier;
		[Export ("identifier")]
		string Identifier { get; }

		// @property (readonly) RCPackageType packageType;
		[Export ("packageType")]
		RCPackageType PackageType { get; }

		// @property (readonly) SKProduct * _Nonnull product;
		[Export ("product")]
		SKProduct Product { get; }

		// @property (readonly) NSString * _Nonnull localizedPriceString;
		[Export ("localizedPriceString")]
		string LocalizedPriceString { get; }

		// @property (readonly) NSString * _Nonnull localizedIntroductoryPriceString;
		[Export ("localizedIntroductoryPriceString")]
		string LocalizedIntroductoryPriceString { get; }
	}

	// @interface RCPurchasesErrorUtils : NSObject
	[BaseType (typeof(NSObject))]
	interface RCPurchasesErrorUtils : INativeObject
	{
		// +(NSError * _Nonnull)networkErrorWithUnderlyingError:(NSError * _Nonnull)underlyingError;
		[Static]
		[Export ("networkErrorWithUnderlyingError:")]
		NSError NetworkErrorWithUnderlyingError (NSError underlyingError);

		// +(NSError * _Nonnull)backendErrorWithBackendCode:(NSNumber * _Nullable)backendCode backendMessage:(NSString * _Nullable)backendMessage;
		[Static]
		[Export ("backendErrorWithBackendCode:backendMessage:")]
		NSError BackendErrorWithBackendCode ([NullAllowed] NSNumber backendCode, [NullAllowed] string backendMessage);

		// +(NSError * _Nonnull)backendErrorWithBackendCode:(NSNumber * _Nullable)backendCode backendMessage:(NSString * _Nullable)backendMessage finishable:(BOOL)finishable;
		[Static]
		[Export ("backendErrorWithBackendCode:backendMessage:finishable:")]
		NSError BackendErrorWithBackendCode ([NullAllowed] NSNumber backendCode, [NullAllowed] string backendMessage, bool finishable);

		// +(NSError * _Nonnull)unexpectedBackendResponseError;
		[Static]
		[Export ("unexpectedBackendResponseError")]
		NSError UnexpectedBackendResponseError { get; }

		// +(NSError * _Nonnull)missingReceiptFileError;
		[Static]
		[Export ("missingReceiptFileError")]
		NSError MissingReceiptFileError { get; }

		// +(NSError * _Nonnull)missingAppUserIDError;
		[Static]
		[Export ("missingAppUserIDError")]
		NSError MissingAppUserIDError { get; }

		// +(NSError * _Nonnull)purchasesErrorWithSKError:(NSError * _Nonnull)skError;
		[Static]
		[Export ("purchasesErrorWithSKError:")]
		NSError PurchasesErrorWithSKError (NSError skError);
	}

	// @interface RCPurchasesErrors
	[BaseType(typeof(NSObject))]
	interface RCPurchasesErrors : INativeObject
	{
		// extern const NSErrorDomain RCPurchasesErrorDomain __attribute__((swift_name("Purchases.ErrorDomain")));
		[Field("RCPurchasesErrorDomain", "__Internal")]
		NSString RCPurchasesErrorDomain { get; }

		// extern const NSErrorDomain RCBackendErrorDomain __attribute__((swift_name("Purchases.RevenueCatBackendErrorDomain")));
		[Field("RCBackendErrorDomain", "__Internal")]
		NSString RCBackendErrorDomain { get; }

		// extern const NSErrorUserInfoKey RCFinishableKey __attribute__((swift_name("Purchases.FinishableKey")));
		[Field("RCFinishableKey", "__Internal")]
		NSString RCFinishableKey { get; }

		// extern const NSErrorUserInfoKey RCReadableErrorCodeKey __attribute__((swift_name("Purchases.ReadableErrorCodeKey")));
		[Field("RCReadableErrorCodeKey", "__Internal")]
		NSString RCReadableErrorCodeKey { get; }
	}

	// @interface RCEntitlementInfo : NSObject
	[BaseType (typeof(NSObject))]
	interface RCEntitlementInfo : INativeObject
	{
		// @property (readonly) NSString * _Nonnull identifier;
		[Export ("identifier")]
		string Identifier { get; }

		// @property (readonly) BOOL isActive;
		[Export ("isActive")]
		bool IsActive { get; }

		// @property (readonly) BOOL willRenew;
		[Export ("willRenew")]
		bool WillRenew { get; }

		// @property (readonly) RCPeriodType periodType;
		[Export ("periodType")]
		RCPeriodType PeriodType { get; }

		// @property (readonly) NSDate * _Nonnull latestPurchaseDate;
		[Export ("latestPurchaseDate")]
		NSDate LatestPurchaseDate { get; }

		// @property (readonly) NSDate * _Nonnull originalPurchaseDate;
		[Export ("originalPurchaseDate")]
		NSDate OriginalPurchaseDate { get; }

		// @property (readonly) NSDate * _Nullable expirationDate;
		[NullAllowed, Export ("expirationDate")]
		NSDate ExpirationDate { get; }

		// @property (readonly) RCStore store;
		[Export ("store")]
		RCStore Store { get; }

		// @property (readonly) NSString * _Nonnull productIdentifier;
		[Export ("productIdentifier")]
		string ProductIdentifier { get; }

		// @property (readonly) BOOL isSandbox;
		[Export ("isSandbox")]
		bool IsSandbox { get; }

		// @property (readonly) NSDate * _Nullable unsubscribeDetectedAt;
		[NullAllowed, Export ("unsubscribeDetectedAt")]
		NSDate UnsubscribeDetectedAt { get; }

		// @property (readonly) NSDate * _Nullable billingIssueDetectedAt;
		[NullAllowed, Export ("billingIssueDetectedAt")]
		NSDate BillingIssueDetectedAt { get; }
	}

	// @interface RCEntitlementInfos : NSObject
	[BaseType (typeof(NSObject))]
	interface RCEntitlementInfos
	{
		// @property (readonly) NSDictionary<NSString *,RCEntitlementInfo *> * _Nonnull all;
		[Export ("all")]
		NSDictionary<NSString, RCEntitlementInfo> All { get; }

		// @property (readonly) NSDictionary<NSString *,RCEntitlementInfo *> * _Nonnull active;
		[Export ("active")]
		NSDictionary<NSString, RCEntitlementInfo> Active { get; }

		// -(RCEntitlementInfo * _Nullable)objectForKeyedSubscript:(id _Nonnull)key;
		[Export ("objectForKeyedSubscript:")]
		[return: NullAllowed]
		RCEntitlementInfo ObjectForKeyedSubscript (NSObject key);
	}
}
