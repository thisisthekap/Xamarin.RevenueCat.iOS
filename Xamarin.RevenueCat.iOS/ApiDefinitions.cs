using System;
using Foundation;
using ObjCRuntime;
using StoreKit;

namespace RevenueCat
{
    delegate void ReadyForPromotedProductCallbackHandler(RCStoreTransaction transaction, RCCustomerInfo customerInfo, NSError error, bool userCancelled);
    delegate void StartPurchaseHandler([BlockCallback] ReadyForPromotedProductCallbackHandler defermentBlock);

    // @interface RCAttribution : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface RCAttribution
    {
        // -(void)collectDeviceIdentifiers;
        [Export("collectDeviceIdentifiers")]
        void CollectDeviceIdentifiers();

        // -(void)setAttributes:(NSDictionary<NSString *,NSString *> * _Nonnull)attributes;
        [Export("setAttributes:")]
        void SetAttributes(NSDictionary<NSString, NSString> attributes);

        // -(void)setEmail:(NSString * _Nullable)email;
        [Export("setEmail:")]
        void SetEmail([NullAllowed] string email);

        // -(void)setPhoneNumber:(NSString * _Nullable)phoneNumber;
        [Export("setPhoneNumber:")]
        void SetPhoneNumber([NullAllowed] string phoneNumber);

        // -(void)setDisplayName:(NSString * _Nullable)displayName;
        [Export("setDisplayName:")]
        void SetDisplayName([NullAllowed] string displayName);

        // -(void)setPushToken:(NSData * _Nullable)pushToken;
        [Export("setPushToken:")]
        void SetPushToken([NullAllowed] NSData pushToken);

        // -(void)setPushTokenString:(NSString * _Nullable)pushToken;
        [Export("setPushTokenString:")]
        void SetPushTokenString([NullAllowed] string pushToken);

        // -(void)setAdjustID:(NSString * _Nullable)adjustID;
        [Export("setAdjustID:")]
        void SetAdjustID([NullAllowed] string adjustID);

        // -(void)setAppsflyerID:(NSString * _Nullable)appsflyerID;
        [Export("setAppsflyerID:")]
        void SetAppsflyerID([NullAllowed] string appsflyerID);

        // -(void)setFBAnonymousID:(NSString * _Nullable)fbAnonymousID;
        [Export("setFBAnonymousID:")]
        void SetFBAnonymousID([NullAllowed] string fbAnonymousID);

        // -(void)setMparticleID:(NSString * _Nullable)mparticleID;
        [Export("setMparticleID:")]
        void SetMparticleID([NullAllowed] string mparticleID);

        // -(void)setOnesignalID:(NSString * _Nullable)onesignalID;
        [Export("setOnesignalID:")]
        void SetOnesignalID([NullAllowed] string onesignalID);

        // -(void)setAirshipChannelID:(NSString * _Nullable)airshipChannelID;
        [Export("setAirshipChannelID:")]
        void SetAirshipChannelID([NullAllowed] string airshipChannelID);

        // -(void)setCleverTapID:(NSString * _Nullable)cleverTapID;
        [Export("setCleverTapID:")]
        void SetCleverTapID([NullAllowed] string cleverTapID);

        // -(void)setMixpanelDistinctID:(NSString * _Nullable)mixpanelDistinctID;
        [Export("setMixpanelDistinctID:")]
        void SetMixpanelDistinctID([NullAllowed] string mixpanelDistinctID);

        // -(void)setFirebaseAppInstanceID:(NSString * _Nullable)firebaseAppInstanceID;
        [Export("setFirebaseAppInstanceID:")]
        void SetFirebaseAppInstanceID([NullAllowed] string firebaseAppInstanceID);

        // -(void)setMediaSource:(NSString * _Nullable)mediaSource;
        [Export("setMediaSource:")]
        void SetMediaSource([NullAllowed] string mediaSource);

        // -(void)setCampaign:(NSString * _Nullable)campaign;
        [Export("setCampaign:")]
        void SetCampaign([NullAllowed] string campaign);

        // -(void)setAdGroup:(NSString * _Nullable)adGroup;
        [Export("setAdGroup:")]
        void SetAdGroup([NullAllowed] string adGroup);

        // -(void)setAd:(NSString * _Nullable)installAd;
        [Export("setAd:")]
        void SetAd([NullAllowed] string installAd);

        // -(void)setKeyword:(NSString * _Nullable)keyword;
        [Export("setKeyword:")]
        void SetKeyword([NullAllowed] string keyword);

        // -(void)setCreative:(NSString * _Nullable)creative;
        [Export("setCreative:")]
        void SetCreative([NullAllowed] string creative);
    }

    // @interface RCConfiguration : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface RCConfiguration
    {
        // +(RCConfigurationBuilder * _Nonnull)builderWithAPIKey:(NSString * _Nonnull)apiKey __attribute__((warn_unused_result("")));
        [Static]
        [Export("builderWithAPIKey:")]
        RCConfigurationBuilder BuilderWithAPIKey(string apiKey);
    }

    // @interface RCConfigurationBuilder : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface RCConfigurationBuilder
    {
        // -(instancetype _Nonnull)initWithAPIKey:(NSString * _Nonnull)apiKey __attribute__((objc_designated_initializer));
        [Export("initWithAPIKey:")]
        [DesignatedInitializer]
        IntPtr Constructor(string apiKey);

        // -(RCConfigurationBuilder * _Nonnull)withApiKey:(NSString * _Nonnull)apiKey __attribute__((warn_unused_result("")));
        [Export("withApiKey:")]
        RCConfigurationBuilder WithApiKey(string apiKey);

        // -(RCConfigurationBuilder * _Nonnull)withAppUserID:(NSString * _Nonnull)appUserID __attribute__((warn_unused_result("")));
        [Export("withAppUserID:")]
        RCConfigurationBuilder WithAppUserID(string appUserID);

        // -(RCConfigurationBuilder * _Nonnull)withObserverMode:(BOOL)observerMode __attribute__((warn_unused_result("")));
        [Export("withObserverMode:")]
        RCConfigurationBuilder WithObserverMode(bool observerMode);

        // -(RCConfigurationBuilder * _Nonnull)withUserDefaults:(NSUserDefaults * _Nonnull)userDefaults __attribute__((warn_unused_result("")));
        [Export("withUserDefaults:")]
        RCConfigurationBuilder WithUserDefaults(NSUserDefaults userDefaults);

        // -(RCConfigurationBuilder * _Nonnull)withUsesStoreKit2IfAvailable:(BOOL)usesStoreKit2IfAvailable __attribute__((warn_unused_result("")));
        [Export("withUsesStoreKit2IfAvailable:")]
        RCConfigurationBuilder WithUsesStoreKit2IfAvailable(bool usesStoreKit2IfAvailable);

        // -(RCConfigurationBuilder * _Nonnull)withDangerousSettings:(RCDangerousSettings * _Nonnull)dangerousSettings __attribute__((warn_unused_result("")));
        [Export("withDangerousSettings:")]
        RCConfigurationBuilder WithDangerousSettings(RCDangerousSettings dangerousSettings);

        // -(RCConfigurationBuilder * _Nonnull)withNetworkTimeout:(NSTimeInterval)networkTimeout __attribute__((warn_unused_result("")));
        [Export("withNetworkTimeout:")]
        RCConfigurationBuilder WithNetworkTimeout(double networkTimeout);

        // -(RCConfigurationBuilder * _Nonnull)withStoreKit1Timeout:(NSTimeInterval)storeKit1Timeout __attribute__((warn_unused_result("")));
        [Export("withStoreKit1Timeout:")]
        RCConfigurationBuilder WithStoreKit1Timeout(double storeKit1Timeout);

        // -(RCConfigurationBuilder * _Nonnull)withPlatformInfo:(RCPlatformInfo * _Nonnull)platformInfo __attribute__((warn_unused_result("")));
        [Export("withPlatformInfo:")]
        RCConfigurationBuilder WithPlatformInfo(RCPlatformInfo platformInfo);

        // -(RCConfiguration * _Nonnull)build __attribute__((warn_unused_result("")));
        [Export("build")]
        RCConfiguration Build();
    }

    // @interface RCCustomerInfo : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface RCCustomerInfo
    {
        // @property (readonly, nonatomic, strong) RCEntitlementInfos * _Nonnull entitlements;
        [Export("entitlements", ArgumentSemantic.Strong)]
        RCEntitlementInfos Entitlements { get; }

        // @property (readonly, copy, nonatomic) NSSet<NSString *> * _Nonnull activeSubscriptions;
        [Export("activeSubscriptions", ArgumentSemantic.Copy)]
        NSSet<NSString> ActiveSubscriptions { get; }

        // @property (readonly, copy, nonatomic) NSSet<NSString *> * _Nonnull allPurchasedProductIdentifiers;
        [Export("allPurchasedProductIdentifiers", ArgumentSemantic.Copy)]
        NSSet<NSString> AllPurchasedProductIdentifiers { get; }

        // @property (readonly, copy, nonatomic) NSDate * _Nullable latestExpirationDate;
        [NullAllowed, Export("latestExpirationDate", ArgumentSemantic.Copy)]
        NSDate LatestExpirationDate { get; }

        // @property (readonly, copy, nonatomic) NSArray<RCNonSubscriptionTransaction *> * _Nonnull nonSubscriptions;
        [Export("nonSubscriptions", ArgumentSemantic.Copy)]
        RCNonSubscriptionTransaction[] NonSubscriptions { get; }

        // @property (readonly, copy, nonatomic) NSDate * _Nonnull requestDate;
        [Export("requestDate", ArgumentSemantic.Copy)]
        NSDate RequestDate { get; }

        // @property (readonly, copy, nonatomic) NSDate * _Nonnull firstSeen;
        [Export("firstSeen", ArgumentSemantic.Copy)]
        NSDate FirstSeen { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull originalAppUserId;
        [Export("originalAppUserId")] string OriginalAppUserId { get; }

        // @property (readonly, copy, nonatomic) NSURL * _Nullable managementURL;
        [NullAllowed, Export("managementURL", ArgumentSemantic.Copy)]
        NSUrl ManagementURL { get; }

        // @property (readonly, copy, nonatomic) NSDate * _Nullable originalPurchaseDate;
        [NullAllowed, Export("originalPurchaseDate", ArgumentSemantic.Copy)]
        NSDate OriginalPurchaseDate { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable originalApplicationVersion;
        [NullAllowed, Export("originalApplicationVersion")]
        string OriginalApplicationVersion { get; }

        // -(NSDate * _Nullable)expirationDateForProductIdentifier:(NSString * _Nonnull)productIdentifier __attribute__((warn_unused_result("")));
        [Export("expirationDateForProductIdentifier:")]
        [return: NullAllowed]
        NSDate ExpirationDateForProductIdentifier(string productIdentifier);

        // -(NSDate * _Nullable)purchaseDateForProductIdentifier:(NSString * _Nonnull)productIdentifier __attribute__((warn_unused_result("")));
        [Export("purchaseDateForProductIdentifier:")]
        [return: NullAllowed]
        NSDate PurchaseDateForProductIdentifier(string productIdentifier);

        // -(NSDate * _Nullable)expirationDateForEntitlement:(NSString * _Nonnull)entitlementIdentifier __attribute__((warn_unused_result("")));
        [Export("expirationDateForEntitlement:")]
        [return: NullAllowed]
        NSDate ExpirationDateForEntitlement(string entitlementIdentifier);

        // -(NSDate * _Nullable)purchaseDateForEntitlement:(NSString * _Nonnull)entitlementIdentifier __attribute__((warn_unused_result("")));
        [Export("purchaseDateForEntitlement:")]
        [return: NullAllowed]
        NSDate PurchaseDateForEntitlement(string entitlementIdentifier);

        // -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
        [Export("isEqual:")]
        [Override]
        bool IsEqual([NullAllowed] NSObject @object);

        // @property (readonly, nonatomic) NSUInteger hash;
        [Export("hash")] nuint Hash { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")] [Override] string Description { get; }

        // @property (readonly, copy, nonatomic) NSDictionary<NSString *,id> * _Nonnull rawData;
        [Export("rawData", ArgumentSemantic.Copy)]
        NSDictionary<NSString, NSObject> RawData { get; }

        // @property (readonly, copy, nonatomic) SWIFT_DEPRECATED_MSG("use nonSubscriptionTransactions") NSSet<NSString *> * nonConsumablePurchases __attribute__((deprecated("use nonSubscriptionTransactions")));
        [Export("nonConsumablePurchases", ArgumentSemantic.Copy)]
        NSSet<NSString> NonConsumablePurchases { get; }

        // @property (readonly, copy, nonatomic) SWIFT_DEPRECATED_MSG("", "nonSubscriptions") NSArray<RCStoreTransaction *> * nonSubscriptionTransactions __attribute__((deprecated("", "nonSubscriptions")));
        [Export("nonSubscriptionTransactions", ArgumentSemantic.Copy)]
        RCStoreTransaction[] NonSubscriptionTransactions { get; }
    }

    // @interface RCDangerousSettings : NSObject
    [BaseType(typeof(NSObject))]
    interface RCDangerousSettings
    {
        // @property (readonly, nonatomic) BOOL autoSyncPurchases;
        [Export("autoSyncPurchases")] bool AutoSyncPurchases { get; }

        // -(instancetype _Nonnull)initWithAutoSyncPurchases:(BOOL)autoSyncPurchases __attribute__((objc_designated_initializer));
        [Export("initWithAutoSyncPurchases:")]
        [DesignatedInitializer]
        IntPtr Constructor(bool autoSyncPurchases);
    }

    // @interface RCEntitlementInfo : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface RCEntitlementInfo : INativeObject
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull identifier;
        [Export("identifier")] string Identifier { get; }

        // @property (readonly, nonatomic) BOOL isActive;
        [Export("isActive")] bool IsActive { get; }

        // @property (readonly, nonatomic) BOOL willRenew;
        [Export("willRenew")] bool WillRenew { get; }

        // @property (readonly, nonatomic) enum RCPeriodType periodType;
        [Export("periodType")] RCPeriodType PeriodType { get; }

        // @property (readonly, copy, nonatomic) NSDate * _Nullable latestPurchaseDate;
        [NullAllowed, Export("latestPurchaseDate", ArgumentSemantic.Copy)]
        NSDate LatestPurchaseDate { get; }

        // @property (readonly, copy, nonatomic) NSDate * _Nullable originalPurchaseDate;
        [NullAllowed, Export("originalPurchaseDate", ArgumentSemantic.Copy)]
        NSDate OriginalPurchaseDate { get; }

        // @property (readonly, copy, nonatomic) NSDate * _Nullable expirationDate;
        [NullAllowed, Export("expirationDate", ArgumentSemantic.Copy)]
        NSDate ExpirationDate { get; }

        // @property (readonly, nonatomic) enum RCStore store;
        [Export("store")] RCStore Store { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull productIdentifier;
        [Export("productIdentifier")] string ProductIdentifier { get; }

        // @property (readonly, nonatomic) BOOL isSandbox;
        [Export("isSandbox")] bool IsSandbox { get; }

        // @property (readonly, copy, nonatomic) NSDate * _Nullable unsubscribeDetectedAt;
        [NullAllowed, Export("unsubscribeDetectedAt", ArgumentSemantic.Copy)]
        NSDate UnsubscribeDetectedAt { get; }

        // @property (readonly, copy, nonatomic) NSDate * _Nullable billingIssueDetectedAt;
        [NullAllowed, Export("billingIssueDetectedAt", ArgumentSemantic.Copy)]
        NSDate BillingIssueDetectedAt { get; }

        // @property (readonly, nonatomic) enum RCPurchaseOwnershipType ownershipType;
        [Export("ownershipType")] RCPurchaseOwnershipType OwnershipType { get; }

        // @property (readonly, copy, nonatomic) NSDictionary<NSString *,id> * _Nonnull rawData;
        [Export("rawData", ArgumentSemantic.Copy)]
        NSDictionary<NSString, NSObject> RawData { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")] [Override] string Description { get; }

        // -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
        [Export("isEqual:")]
        [Override]
        bool IsEqual([NullAllowed] NSObject @object);

        // @property (readonly, nonatomic) NSUInteger hash;
        [Export("hash")] nuint Hash { get; }

        // @property (readonly, nonatomic) BOOL isActiveInCurrentEnvironment;
        [Export("isActiveInCurrentEnvironment")]
        bool IsActiveInCurrentEnvironment { get; }

        // @property (readonly, nonatomic) BOOL isActiveInAnyEnvironment;
        [Export("isActiveInAnyEnvironment")] bool IsActiveInAnyEnvironment { get; }
    }

    // @interface RCEntitlementInfos : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface RCEntitlementInfos
    {
        // @property (readonly, copy, nonatomic) NSDictionary<NSString *,RCEntitlementInfo *> * _Nonnull all;
        [Export("all", ArgumentSemantic.Copy)] NSDictionary<NSString, RCEntitlementInfo> All { get; }

        // -(RCEntitlementInfo * _Nullable)objectForKeyedSubscript:(NSString * _Nonnull)key __attribute__((warn_unused_result("")));
        [Export("objectForKeyedSubscript:")]
        [return: NullAllowed]
        RCEntitlementInfo ObjectForKeyedSubscript(string key);

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")] [Override] string Description { get; }

        // -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
        [Export("isEqual:")]
        [Override]
        bool IsEqual([NullAllowed] NSObject @object);

        // @property (readonly, copy, nonatomic) NSDictionary<NSString *,RCEntitlementInfo *> * _Nonnull active;
        [Export("active", ArgumentSemantic.Copy)]
        NSDictionary<NSString, RCEntitlementInfo> Active { get; }

        // @property (readonly, copy, nonatomic) NSDictionary<NSString *,RCEntitlementInfo *> * _Nonnull activeInCurrentEnvironment;
        [Export("activeInCurrentEnvironment", ArgumentSemantic.Copy)]
        NSDictionary<NSString, RCEntitlementInfo> ActiveInCurrentEnvironment { get; }

        // @property (readonly, copy, nonatomic) NSDictionary<NSString *,RCEntitlementInfo *> * _Nonnull activeInAnyEnvironment;
        [Export("activeInAnyEnvironment", ArgumentSemantic.Copy)]
        NSDictionary<NSString, RCEntitlementInfo> ActiveInAnyEnvironment { get; }
    }

    // @interface RCIntroEligibility : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface RCIntroEligibility : INativeObject
    {
        // @property (readonly, nonatomic) enum RCIntroEligibilityStatus status;
        [Export("status")] RCIntroEligibilityStatus Status { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")] [Override] string Description { get; }
    }

    // @interface RCNonSubscriptionTransaction : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface RCNonSubscriptionTransaction
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull productIdentifier;
        [Export("productIdentifier")] string ProductIdentifier { get; }

        // @property (readonly, copy, nonatomic) NSDate * _Nonnull purchaseDate;
        [Export("purchaseDate", ArgumentSemantic.Copy)]
        NSDate PurchaseDate { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull transactionIdentifier;
        [Export("transactionIdentifier")] string TransactionIdentifier { get; }
    }

    // @interface RCOffering : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface RCOffering : INativeObject
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull identifier;
        [Export("identifier")] string Identifier { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull serverDescription;
        [Export("serverDescription")] string ServerDescription { get; }

        // @property (readonly, copy, nonatomic) NSArray<RCPackage *> * _Nonnull availablePackages;
        [Export("availablePackages", ArgumentSemantic.Copy)]
        RCPackage[] AvailablePackages { get; }

        // @property (readonly, nonatomic, strong) RCPackage * _Nullable lifetime;
        [NullAllowed, Export("lifetime", ArgumentSemantic.Strong)]
        RCPackage Lifetime { get; }

        // @property (readonly, nonatomic, strong) RCPackage * _Nullable annual;
        [NullAllowed, Export("annual", ArgumentSemantic.Strong)]
        RCPackage Annual { get; }

        // @property (readonly, nonatomic, strong) RCPackage * _Nullable sixMonth;
        [NullAllowed, Export("sixMonth", ArgumentSemantic.Strong)]
        RCPackage SixMonth { get; }

        // @property (readonly, nonatomic, strong) RCPackage * _Nullable threeMonth;
        [NullAllowed, Export("threeMonth", ArgumentSemantic.Strong)]
        RCPackage ThreeMonth { get; }

        // @property (readonly, nonatomic, strong) RCPackage * _Nullable twoMonth;
        [NullAllowed, Export("twoMonth", ArgumentSemantic.Strong)]
        RCPackage TwoMonth { get; }

        // @property (readonly, nonatomic, strong) RCPackage * _Nullable monthly;
        [NullAllowed, Export("monthly", ArgumentSemantic.Strong)]
        RCPackage Monthly { get; }

        // @property (readonly, nonatomic, strong) RCPackage * _Nullable weekly;
        [NullAllowed, Export("weekly", ArgumentSemantic.Strong)]
        RCPackage Weekly { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")] [Override] string Description { get; }

        // -(RCPackage * _Nullable)packageWithIdentifier:(NSString * _Nullable)identifier __attribute__((warn_unused_result("")));
        [Export("packageWithIdentifier:")]
        [return: NullAllowed]
        RCPackage PackageWithIdentifier([NullAllowed] string identifier);

        // -(RCPackage * _Nullable)objectForKeyedSubscript:(NSString * _Nonnull)key __attribute__((warn_unused_result("")));
        [Export("objectForKeyedSubscript:")]
        [return: NullAllowed]
        RCPackage ObjectForKeyedSubscript(string key);
    }

    // @interface RCOfferings : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface RCOfferings
    {
        // @property (readonly, copy, nonatomic) NSDictionary<NSString *,RCOffering *> * _Nonnull all;
        [Export("all", ArgumentSemantic.Copy)] NSDictionary<NSString, RCOffering> All { get; }

        // @property (readonly, nonatomic, strong) RCOffering * _Nullable current;
        [NullAllowed, Export("current", ArgumentSemantic.Strong)]
        RCOffering Current { get; }

        // -(RCOffering * _Nullable)offeringWithIdentifier:(NSString * _Nullable)identifier __attribute__((warn_unused_result("")));
        [Export("offeringWithIdentifier:")]
        [return: NullAllowed]
        RCOffering OfferingWithIdentifier([NullAllowed] string identifier);

        // -(RCOffering * _Nullable)objectForKeyedSubscript:(NSString * _Nonnull)key __attribute__((warn_unused_result("")));
        [Export("objectForKeyedSubscript:")]
        [return: NullAllowed]
        RCOffering ObjectForKeyedSubscript(string key);

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")] [Override] string Description { get; }
    }

    // @interface RCPackage : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface RCPackage
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull identifier;
        [Export("identifier")] string Identifier { get; }

        // @property (readonly, nonatomic) enum RCPackageType packageType;
        [Export("packageType")] RCPackageType PackageType { get; }

        // @property (readonly, nonatomic, strong) RCStoreProduct * _Nonnull storeProduct;
        [Export("storeProduct", ArgumentSemantic.Strong)]
        RCStoreProduct StoreProduct { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull offeringIdentifier;
        [Export("offeringIdentifier")] string OfferingIdentifier { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull localizedPriceString;
        [Export("localizedPriceString")] string LocalizedPriceString { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable localizedIntroductoryPriceString;
        [NullAllowed, Export("localizedIntroductoryPriceString")]
        string LocalizedIntroductoryPriceString { get; }

        // -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
        [Export("isEqual:")]
        [Override]
        bool IsEqual([NullAllowed] NSObject @object);

        // @property (readonly, nonatomic) NSUInteger hash;
        [Export("hash")] nuint Hash { get; }

        // +(NSString * _Nullable)stringFrom:(enum RCPackageType)packageType __attribute__((warn_unused_result("")));
        [Static]
        [Export("stringFrom:")]
        [return: NullAllowed]
        string StringFrom(RCPackageType packageType);

        // +(enum RCPackageType)packageTypeFrom:(NSString * _Nonnull)string __attribute__((warn_unused_result("")));
        [Static]
        [Export("packageTypeFrom:")]
        RCPackageType PackageTypeFrom(string @string);
    }

    // @interface RCPromotionalOffer : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface RCPromotionalOffer
    {
        // @property (readonly, nonatomic, strong) RCStoreProductDiscount * _Nonnull discount;
        [Export("discount", ArgumentSemantic.Strong)]
        RCStoreProductDiscount Discount { get; }

        // @property (readonly, nonatomic, strong) RCPromotionalOfferSignedData * _Nonnull signedData;
        [Export("signedData", ArgumentSemantic.Strong)]
        RCPromotionalOfferSignedData SignedData { get; }
    }

    // @interface RCPromotionalOfferSignedData : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface RCPromotionalOfferSignedData
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull identifier;
        [Export("identifier")] string Identifier { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull keyIdentifier;
        [Export("keyIdentifier")] string KeyIdentifier { get; }

        // @property (readonly, copy, nonatomic) NSUUID * _Nonnull nonce;
        [Export("nonce", ArgumentSemantic.Copy)]
        NSUuid Nonce { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull signature;
        [Export("signature")] string Signature { get; }

        // @property (readonly, nonatomic) NSInteger timestamp;
        [Export("timestamp")] nint Timestamp { get; }
    }

    // @interface RCPurchases : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface RCPurchases
    {
        // @property (readonly, nonatomic, strong, class) RCPurchases * _Nonnull sharedPurchases;
        [Static]
        [Export("sharedPurchases", ArgumentSemantic.Strong)]
        RCPurchases SharedPurchases { get; }

        // @property (readonly, nonatomic, class) BOOL isConfigured;
        [Static] [Export("isConfigured")] bool IsConfigured { get; }

        [Wrap("WeakDelegate")] [NullAllowed] RCPurchasesDelegate Delegate { get; set; }

        // @property (nonatomic, strong) id<RCPurchasesDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Strong)]
        NSObject WeakDelegate { get; set; }

        // @property (nonatomic, class) BOOL automaticAppleSearchAdsAttributionCollection;
        [Static]
        [Export("automaticAppleSearchAdsAttributionCollection")]
        bool AutomaticAppleSearchAdsAttributionCollection { get; set; }

        // @property (nonatomic, class) enum RCLogLevel logLevel;
        [Static]
        [Export("logLevel", ArgumentSemantic.Assign)]
        RCLogLevel LogLevel { get; set; }

        // @property (copy, nonatomic, class) NSURL * _Nullable proxyURL;
        [Static]
        [NullAllowed, Export("proxyURL", ArgumentSemantic.Copy)]
        NSUrl ProxyURL { get; set; }

        // @property (nonatomic, class) BOOL forceUniversalAppStore;
        [Static]
        [Export("forceUniversalAppStore")]
        bool ForceUniversalAppStore { get; set; }

        // @property (nonatomic, class) BOOL simulatesAskToBuyInSandbox __attribute__((availability(maccatalyst, introduced=13.0))) __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(macos, introduced=10.14))) __attribute__((availability(ios, introduced=8.0)));
        [Watch(6, 2), MacCatalyst(13, 0), Mac(10, 14), iOS(8, 0)]
        [Static]
        [Export("simulatesAskToBuyInSandbox")]
        bool SimulatesAskToBuyInSandbox { get; set; }

        // +(BOOL)canMakePayments __attribute__((warn_unused_result("")));
        [Static] [Export("canMakePayments")] bool CanMakePayments { get; }

        // @property (copy, nonatomic, class) void (^ _Nonnull)(enum RCLogLevel, NSString * _Nonnull) logHandler;
        [Static]
        [Export("logHandler", ArgumentSemantic.Copy)]
        Action<RCLogLevel, NSString> LogHandler { get; set; }

        // @property (copy, nonatomic, class) void (^ _Nonnull)(enum RCLogLevel, NSString * _Nonnull, NSString * _Nullable, NSString * _Nullable, NSUInteger) verboseLogHandler;
        [Static]
        [Export("verboseLogHandler", ArgumentSemantic.Copy)]
        Action<RCLogLevel, NSString, NSString, NSString, nuint> VerboseLogHandler { get; set; }

        // @property (nonatomic, class) BOOL verboseLogs;
        [Static] [Export("verboseLogs")] bool VerboseLogs { get; set; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull frameworkVersion;
        [Static] [Export("frameworkVersion")] string FrameworkVersion { get; }

        // @property (readonly, nonatomic, strong) RCAttribution * _Nonnull attribution;
        [Export("attribution", ArgumentSemantic.Strong)]
        RCAttribution Attribution { get; }

        // @property (nonatomic) BOOL finishTransactions;
        [Export("finishTransactions")] bool FinishTransactions { get; set; }

        // @property (nonatomic, strong, class) RCPlatformInfo * _Nullable platformInfo;
        [Static]
        [NullAllowed, Export("platformInfo", ArgumentSemantic.Strong)]
        RCPlatformInfo PlatformInfo { get; set; }

        // +(RCPurchases * _Nonnull)configureWithConfiguration:(RCConfiguration * _Nonnull)configuration;
        [Static]
        [Export("configureWithConfiguration:")]
        RCPurchases ConfigureWithConfiguration(RCConfiguration configuration);

        // +(RCPurchases * _Nonnull)configureWithConfigurationBuilder:(RCConfigurationBuilder * _Nonnull)builder;
        [Static]
        [Export("configureWithConfigurationBuilder:")]
        RCPurchases ConfigureWithConfigurationBuilder(RCConfigurationBuilder builder);

        // +(RCPurchases * _Nonnull)configureWithAPIKey:(NSString * _Nonnull)apiKey;
        [Static]
        [Export("configureWithAPIKey:")]
        RCPurchases ConfigureWithAPIKey(string apiKey);

        // -(void)readyForPromotedProduct:(RCStoreProduct * _Nonnull)product purchase:(void (^ _Nonnull)(void (^ _Nonnull)(RCStoreTransaction * _Nullable, RCCustomerInfo * _Nullable, NSError * _Nullable, BOOL)))startPurchase;
        [Export("readyForPromotedProduct:purchase:")]
        void ReadyForPromotedProduct(RCStoreProduct product, StartPurchaseHandler startPurchaseHandler);

        // @property (readonly, nonatomic) BOOL shouldShowPriceConsent __attribute__((availability(maccatalyst, introduced=13.4))) __attribute__((availability(ios, introduced=13.4)));
        [MacCatalyst(13, 4), iOS(13, 4)]
        [Export("shouldShowPriceConsent")]
        bool ShouldShowPriceConsent { get; }

        // @property (nonatomic, class) BOOL debugLogsEnabled __attribute__((deprecated("use Purchases.logLevel instead")));
        [Static] [Export("debugLogsEnabled")] bool DebugLogsEnabled { get; set; }

        // @property (nonatomic) BOOL allowSharingAppStoreAccount __attribute__((deprecated("Configure behavior through the RevenueCat dashboard instead")));
        [Export("allowSharingAppStoreAccount")]
        bool AllowSharingAppStoreAccount { get; set; }

        // +(void)addAttributionData:(NSDictionary<NSString *,id> * _Nonnull)data fromNetwork:(enum RCAttributionNetwork)network __attribute__((deprecated("Use the set<NetworkId> functions instead")));
        [Static]
        [Export("addAttributionData:fromNetwork:")]
        void AddAttributionData(NSDictionary<NSString, NSObject> data, RCAttributionNetwork network);

        // +(void)addAttributionData:(NSDictionary<NSString *,id> * _Nonnull)data fromNetwork:(enum RCAttributionNetwork)network forNetworkUserId:(NSString * _Nullable)networkUserId __attribute__((deprecated("Use the set<NetworkId> functions instead")));
        [Static]
        [Export("addAttributionData:fromNetwork:forNetworkUserId:")]
        void AddAttributionData(NSDictionary<NSString, NSObject> data, RCAttributionNetwork network,
            [NullAllowed] string networkUserId);

        // @property (readonly, copy, nonatomic) NSString * _Nonnull appUserID;
        [Export("appUserID")] string AppUserID { get; }

        // @property (readonly, nonatomic) BOOL isAnonymous;
        [Export("isAnonymous")] bool IsAnonymous { get; }

        // -(void)logIn:(NSString * _Nonnull)appUserID completion:(void (^ _Nonnull)(RCCustomerInfo * _Nullable, BOOL, NSError * _Nullable))completion;
        [Export("logIn:completion:")]
        void LogIn(string appUserID, Action<RCCustomerInfo, bool, NSError> completion);

        // -(void)logOutWithCompletion:(void (^ _Nullable)(RCCustomerInfo * _Nullable, NSError * _Nullable))completion;
        [Export("logOutWithCompletion:")]
        void LogOutWithCompletion([NullAllowed] Action<RCCustomerInfo, NSError> completion);

        // -(void)getOfferingsWithCompletion:(void (^ _Nonnull)(RCOfferings * _Nullable, NSError * _Nullable))completion;
        [Export("getOfferingsWithCompletion:")]
        void GetOfferingsWithCompletion(Action<RCOfferings, NSError> completion);

        // -(void)getCustomerInfoWithCompletion:(void (^ _Nonnull)(RCCustomerInfo * _Nullable, NSError * _Nullable))completion;
        [Export("getCustomerInfoWithCompletion:")]
        void GetCustomerInfoWithCompletion(Action<RCCustomerInfo, NSError> completion);

        // -(void)getCustomerInfoWithFetchPolicy:(enum RCCacheFetchPolicy)fetchPolicy completion:(void (^ _Nonnull)(RCCustomerInfo * _Nullable, NSError * _Nullable))completion;
        [Export("getCustomerInfoWithFetchPolicy:completion:")]
        void GetCustomerInfoWithFetchPolicy(RCCacheFetchPolicy fetchPolicy, Action<RCCustomerInfo, NSError> completion);

        // -(void)getProductsWithIdentifiers:(NSArray<NSString *> * _Nonnull)productIdentifiers completion:(void (^ _Nonnull)(NSArray<RCStoreProduct *> * _Nonnull))completion;
        [Export("getProductsWithIdentifiers:completion:")]
        void GetProductsWithIdentifiers(string[] productIdentifiers, Action<NSArray<RCStoreProduct>> completion);

        // -(void)purchaseProduct:(RCStoreProduct * _Nonnull)product withCompletion:(void (^ _Nonnull)(RCStoreTransaction * _Nullable, RCCustomerInfo * _Nullable, NSError * _Nullable, BOOL))completion;
        [Export("purchaseProduct:withCompletion:")]
        void PurchaseProduct(RCStoreProduct product,
            Action<RCStoreTransaction, RCCustomerInfo, NSError, bool> completion);

        // -(void)purchasePackage:(RCPackage * _Nonnull)package withCompletion:(void (^ _Nonnull)(RCStoreTransaction * _Nullable, RCCustomerInfo * _Nullable, NSError * _Nullable, BOOL))completion;
        [Export("purchasePackage:withCompletion:")]
        void PurchasePackage(RCPackage package, Action<RCStoreTransaction, RCCustomerInfo, NSError, bool> completion);

        // -(void)purchaseProduct:(RCStoreProduct * _Nonnull)product withPromotionalOffer:(RCPromotionalOffer * _Nonnull)promotionalOffer completion:(void (^ _Nonnull)(RCStoreTransaction * _Nullable, RCCustomerInfo * _Nullable, NSError * _Nullable, BOOL))completion __attribute__((availability(tvos, introduced=12.2))) __attribute__((availability(maccatalyst, introduced=13.0))) __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(macos, introduced=10.14.4))) __attribute__((availability(ios, introduced=12.2)));
        [Watch(6, 2), TV(12, 2), MacCatalyst(13, 0), Mac(10, 14, 4), iOS(12, 2)]
        [Export("purchaseProduct:withPromotionalOffer:completion:")]
        void PurchaseProduct(RCStoreProduct product, RCPromotionalOffer promotionalOffer,
            Action<RCStoreTransaction, RCCustomerInfo, NSError, bool> completion);

        // -(void)purchasePackage:(RCPackage * _Nonnull)package withPromotionalOffer:(RCPromotionalOffer * _Nonnull)promotionalOffer completion:(void (^ _Nonnull)(RCStoreTransaction * _Nullable, RCCustomerInfo * _Nullable, NSError * _Nullable, BOOL))completion __attribute__((availability(tvos, introduced=12.2))) __attribute__((availability(maccatalyst, introduced=13.0))) __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(macos, introduced=10.14.4))) __attribute__((availability(ios, introduced=12.2)));
        [Watch(6, 2), TV(12, 2), MacCatalyst(13, 0), Mac(10, 14, 4), iOS(12, 2)]
        [Export("purchasePackage:withPromotionalOffer:completion:")]
        void PurchasePackage(RCPackage package, RCPromotionalOffer promotionalOffer,
            Action<RCStoreTransaction, RCCustomerInfo, NSError, bool> completion);

        // -(void)syncPurchasesWithCompletion:(void (^ _Nullable)(RCCustomerInfo * _Nullable, NSError * _Nullable))completion;
        [Export("syncPurchasesWithCompletion:")]
        void SyncPurchasesWithCompletion([NullAllowed] Action<RCCustomerInfo, NSError> completion);

        // -(void)restorePurchasesWithCompletion:(void (^ _Nullable)(RCCustomerInfo * _Nullable, NSError * _Nullable))completion;
        [Export("restorePurchasesWithCompletion:")]
        void RestorePurchasesWithCompletion([NullAllowed] Action<RCCustomerInfo, NSError> completion);

        // -(void)checkTrialOrIntroDiscountEligibility:(NSArray<NSString *> * _Nonnull)productIdentifiers completion:(void (^ _Nonnull)(NSDictionary<NSString *,RCIntroEligibility *> * _Nonnull))completion;
        [Export("checkTrialOrIntroDiscountEligibility:completion:")]
        void CheckTrialOrIntroDiscountEligibility(string[] productIdentifiers,
            Action<NSDictionary<NSString, RCIntroEligibility>> completion);

        // -(void)checkTrialOrIntroDiscountEligibilityForProduct:(RCStoreProduct * _Nonnull)product completion:(void (^ _Nonnull)(enum RCIntroEligibilityStatus))completion;
        [Export("checkTrialOrIntroDiscountEligibilityForProduct:completion:")]
        void CheckTrialOrIntroDiscountEligibilityForProduct(RCStoreProduct product,
            Action<RCIntroEligibilityStatus> completion);

        // -(void)showPriceConsentIfNeeded __attribute__((availability(maccatalyst, introduced=13.4))) __attribute__((availability(ios, introduced=13.4)));
        [MacCatalyst(13, 4), iOS(13, 4)]
        [Export("showPriceConsentIfNeeded")]
        void ShowPriceConsentIfNeeded();

        // -(void)invalidateCustomerInfoCache;
        [Export("invalidateCustomerInfoCache")]
        void InvalidateCustomerInfoCache();

        // -(void)presentCodeRedemptionSheet __attribute__((availability(maccatalyst, unavailable))) __attribute__((availability(macos, unavailable))) __attribute__((availability(tvos, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(ios, introduced=14.0)));
        [NoWatch, NoTV, NoMacCatalyst, NoMac, iOS(14, 0)]
        [Export("presentCodeRedemptionSheet")]
        void PresentCodeRedemptionSheet();

        // -(void)getPromotionalOfferForProductDiscount:(RCStoreProductDiscount * _Nonnull)discount withProduct:(RCStoreProduct * _Nonnull)product withCompletion:(void (^ _Nonnull)(RCPromotionalOffer * _Nullable, NSError * _Nullable))completion __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(tvos, introduced=12.2))) __attribute__((availability(maccatalyst, introduced=13.0))) __attribute__((availability(macos, introduced=10.14.4))) __attribute__((availability(ios, introduced=12.2)));
        [Watch(6, 2), TV(12, 2), MacCatalyst(13, 0), Mac(10, 14, 4), iOS(12, 2)]
        [Export("getPromotionalOfferForProductDiscount:withProduct:withCompletion:")]
        void GetPromotionalOfferForProductDiscount(RCStoreProductDiscount discount, RCStoreProduct product,
            Action<RCPromotionalOffer, NSError> completion);

        // -(void)showManageSubscriptionsWithCompletion:(void (^ _Nonnull)(NSError * _Nullable))completion __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0))) __attribute__((availability(tvos, unavailable))) __attribute__((availability(watchos, unavailable)));
        [NoWatch, NoTV, Mac(10, 15), iOS(13, 0)]
        [Export("showManageSubscriptionsWithCompletion:")]
        void ShowManageSubscriptionsWithCompletion(Action<NSError> completion);

        // -(void)beginRefundRequestForProduct:(NSString * _Nonnull)productID completion:(void (^ _Nonnull)(enum RCRefundRequestStatus, NSError * _Nullable))completionHandler __attribute__((availability(tvos, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(macos, unavailable))) __attribute__((availability(ios, introduced=15.0)));
        [NoWatch, NoTV, NoMac, iOS(15, 0)]
        [Export("beginRefundRequestForProduct:completion:")]
        void BeginRefundRequestForProduct(string productID, Action<RCRefundRequestStatus, NSError> completionHandler);

        // -(void)beginRefundRequestForEntitlement:(NSString * _Nonnull)entitlementID completion:(void (^ _Nonnull)(enum RCRefundRequestStatus, NSError * _Nullable))completionHandler __attribute__((availability(tvos, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(macos, unavailable))) __attribute__((availability(ios, introduced=15.0)));
        [NoWatch, NoTV, NoMac, iOS(15, 0)]
        [Export("beginRefundRequestForEntitlement:completion:")]
        void BeginRefundRequestForEntitlement(string entitlementID,
            Action<RCRefundRequestStatus, NSError> completionHandler);

        // -(void)beginRefundRequestForActiveEntitlementWithCompletion:(void (^ _Nonnull)(enum RCRefundRequestStatus, NSError * _Nullable))completionHandler __attribute__((availability(tvos, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(macos, unavailable))) __attribute__((availability(ios, introduced=15.0)));
        [NoWatch, NoTV, NoMac, iOS(15, 0)]
        [Export("beginRefundRequestForActiveEntitlementWithCompletion:")]
        void BeginRefundRequestForActiveEntitlementWithCompletion(
            Action<RCRefundRequestStatus, NSError> completionHandler);
    }

    // @interface RCPlatformInfo : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface RCPlatformInfo
    {
        // -(instancetype _Nonnull)initWithFlavor:(NSString * _Nonnull)flavor version:(NSString * _Nonnull)version __attribute__((objc_designated_initializer));
        [Export("initWithFlavor:version:")]
        [DesignatedInitializer]
        IntPtr Constructor(string flavor, string version);
    }

    // @protocol RCPurchasesDelegate <NSObject>
    [Protocol, Model(AutoGeneratedName = true)]
    [BaseType(typeof(NSObject))]
    interface RCPurchasesDelegate
    {
        // @optional -(void)purchases:(RCPurchases * _Nonnull)purchases receivedUpdatedCustomerInfo:(RCCustomerInfo * _Nonnull)customerInfo;
        [Export("purchases:receivedUpdatedCustomerInfo:")]
        void ReceivedUpdatedCustomerInfo(RCPurchases purchases, RCCustomerInfo customerInfo);

        // @optional -(void)purchases:(RCPurchases * _Nonnull)purchases readyForPromotedProduct:(RCStoreProduct * _Nonnull)product purchase:(void (^ _Nonnull)(void (^ _Nonnull)(RCStoreTransaction * _Nullable, RCCustomerInfo * _Nullable, NSError * _Nullable, BOOL)))startPurchase;
        [Export("purchases:readyForPromotedProduct:purchase:")]
        void ReadyForPromotedProduct(RCPurchases purchases, RCStoreProduct product, StartPurchaseHandler startPurchase);

        // @optional @property (readonly, nonatomic) BOOL shouldShowPriceConsent __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable))) __attribute__((availability(macos, unavailable))) __attribute__((availability(maccatalyst, introduced=13.4))) __attribute__((availability(ios, introduced=13.4)));
        [NoWatch, NoTV, NoMac, MacCatalyst(13, 4), iOS(13, 4)]
        [Export("shouldShowPriceConsent")]
        bool ShouldShowPriceConsent { get; }
    }

    // @interface RCStoreProduct : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface RCStoreProduct : INativeObject
    {
        // -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
        [Export("isEqual:")]
        [Override]
        bool IsEqual([NullAllowed] NSObject @object);

        // @property (readonly, nonatomic) NSUInteger hash;
        [Export("hash")] nuint Hash { get; }

        // @property (readonly, nonatomic) enum RCStoreProductType productType;
        [Export("productType")] RCStoreProductType ProductType { get; }

        // @property (readonly, nonatomic) enum RCStoreProductCategory productCategory;
        [Export("productCategory")] RCStoreProductCategory ProductCategory { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull localizedDescription;
        [Export("localizedDescription")] string LocalizedDescription { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull localizedTitle;
        [Export("localizedTitle")] string LocalizedTitle { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable currencyCode;
        [NullAllowed, Export("currencyCode")] string CurrencyCode { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull localizedPriceString;
        [Export("localizedPriceString")] string LocalizedPriceString { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull productIdentifier;
        [Export("productIdentifier")] string ProductIdentifier { get; }

        // @property (readonly, nonatomic) BOOL isFamilyShareable __attribute__((availability(watchos, introduced=8.0))) __attribute__((availability(tvos, introduced=14.0))) __attribute__((availability(macos, introduced=11.0))) __attribute__((availability(ios, introduced=14.0)));
        [Watch(8, 0), TV(14, 0), Mac(11, 0), iOS(14, 0)]
        [Export("isFamilyShareable")]
        bool IsFamilyShareable { get; }

        // @property (readonly, copy, nonatomic) SWIFT_AVAILABILITY(watchos,introduced=6.2) NSString * subscriptionGroupIdentifier __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(macos, introduced=10.14))) __attribute__((availability(tvos, introduced=12.0))) __attribute__((availability(maccatalyst, introduced=13.0))) __attribute__((availability(ios, introduced=12.0)));
        [Watch(6, 2), TV(12, 0), MacCatalyst(13, 0), Mac(10, 14), iOS(12, 0)]
        [Export("subscriptionGroupIdentifier")]
        string SubscriptionGroupIdentifier { get; }

        // @property (readonly, nonatomic, strong) NSNumberFormatter * _Nullable priceFormatter;
        [NullAllowed, Export("priceFormatter", ArgumentSemantic.Strong)]
        NSNumberFormatter PriceFormatter { get; }

        // @property (readonly, nonatomic, strong) SWIFT_AVAILABILITY(watchos,introduced=6.2) RCSubscriptionPeriod * subscriptionPeriod __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(tvos, introduced=11.2))) __attribute__((availability(macos, introduced=10.13.2))) __attribute__((availability(ios, introduced=11.2)));
        [Watch(6, 2), TV(11, 2), Mac(10, 13, 2), iOS(11, 2)]
        [Export("subscriptionPeriod", ArgumentSemantic.Strong)]
        RCSubscriptionPeriod SubscriptionPeriod { get; }

        // @property (readonly, nonatomic, strong) SWIFT_AVAILABILITY(watchos,introduced=6.2) RCStoreProductDiscount * introductoryDiscount __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(tvos, introduced=11.2))) __attribute__((availability(macos, introduced=10.13.2))) __attribute__((availability(ios, introduced=11.2)));
        [Watch(6, 2), TV(11, 2), Mac(10, 13, 2), iOS(11, 2)]
        [Export("introductoryDiscount", ArgumentSemantic.Strong)]
        RCStoreProductDiscount IntroductoryDiscount { get; }

        // @property (readonly, copy, nonatomic) SWIFT_AVAILABILITY(watchos,introduced=6.2) NSArray<RCStoreProductDiscount *> * discounts __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(tvos, introduced=12.2))) __attribute__((availability(macos, introduced=10.14.4))) __attribute__((availability(ios, introduced=12.2)));
        [Watch(6, 2), TV(12, 2), Mac(10, 14, 4), iOS(12, 2)]
        [Export("discounts", ArgumentSemantic.Copy)]
        RCStoreProductDiscount[] Discounts { get; }

        // @property (readonly, nonatomic, strong) NSDecimalNumber * _Nonnull price;
        [Export("price", ArgumentSemantic.Strong)]
        NSDecimalNumber Price { get; }

        // @property (readonly, nonatomic, strong) SWIFT_AVAILABILITY(watchos,introduced=6.2) NSDecimalNumber * pricePerMonth __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(tvos, introduced=11.2))) __attribute__((availability(macos, introduced=10.13.2))) __attribute__((availability(ios, introduced=11.2)));
        [Watch(6, 2), TV(11, 2), Mac(10, 13, 2), iOS(11, 2)]
        [Export("pricePerMonth", ArgumentSemantic.Strong)]
        NSDecimalNumber PricePerMonth { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable localizedIntroductoryPriceString;
        [NullAllowed, Export("localizedIntroductoryPriceString")]
        string LocalizedIntroductoryPriceString { get; }

        // -(instancetype _Nonnull)initWithSk1Product:(SKProduct * _Nonnull)sk1Product;
        [Export("initWithSk1Product:")]
        IntPtr Constructor(SKProduct sk1Product);

        // @property (readonly, nonatomic, strong) SKProduct * _Nullable sk1Product;
        [NullAllowed, Export("sk1Product", ArgumentSemantic.Strong)]
        SKProduct Sk1Product { get; }
    }

    // @interface RCStoreProductDiscount : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface RCStoreProductDiscount
    {
        // @property (readonly, copy, nonatomic) NSString * _Nullable offerIdentifier;
        [NullAllowed, Export("offerIdentifier")]
        string OfferIdentifier { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable currencyCode;
        [NullAllowed, Export("currencyCode")] string CurrencyCode { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull localizedPriceString;
        [Export("localizedPriceString")] string LocalizedPriceString { get; }

        // @property (readonly, nonatomic) enum RCPaymentMode paymentMode;
        [Export("paymentMode")] RCPaymentMode PaymentMode { get; }

        // @property (readonly, nonatomic, strong) RCSubscriptionPeriod * _Nonnull subscriptionPeriod;
        [Export("subscriptionPeriod", ArgumentSemantic.Strong)]
        RCSubscriptionPeriod SubscriptionPeriod { get; }

        // @property (readonly, nonatomic) NSInteger numberOfPeriods;
        [Export("numberOfPeriods")] nint NumberOfPeriods { get; }

        // @property (readonly, nonatomic) enum RCDiscountType type;
        [Export("type")] RCDiscountType Type { get; }

        // -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
        [Export("isEqual:")]
        [Override]
        bool IsEqual([NullAllowed] NSObject @object);

        // @property (readonly, nonatomic) NSUInteger hash;
        [Export("hash")] nuint Hash { get; }

        // @property (readonly, nonatomic, strong) NSDecimalNumber * _Nonnull price;
        [Export("price", ArgumentSemantic.Strong)]
        NSDecimalNumber Price { get; }

        // @property (readonly, nonatomic, strong) SWIFT_AVAILABILITY(watchos,introduced=6.2) SKProductDiscount * sk1Discount __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(tvos, introduced=12.2))) __attribute__((availability(macos, introduced=10.14.4))) __attribute__((availability(ios, introduced=12.2)));
        [Watch(6, 2), TV(12, 2), Mac(10, 14, 4), iOS(12, 2)]
        [Export("sk1Discount", ArgumentSemantic.Strong)]
        SKProductDiscount Sk1Discount { get; }
    }

    // @interface RCStoreTransaction : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface RCStoreTransaction
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull productIdentifier;
        [Export("productIdentifier")] string ProductIdentifier { get; }

        // @property (readonly, copy, nonatomic) NSDate * _Nonnull purchaseDate;
        [Export("purchaseDate", ArgumentSemantic.Copy)]
        NSDate PurchaseDate { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull transactionIdentifier;
        [Export("transactionIdentifier")] string TransactionIdentifier { get; }

        // @property (readonly, nonatomic) NSInteger quantity;
        [Export("quantity")] nint Quantity { get; }

        // -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
        [Export("isEqual:")]
        [Override]
        bool IsEqual([NullAllowed] NSObject @object);

        // @property (readonly, nonatomic) NSUInteger hash;
        [Export("hash")] nuint Hash { get; }

        // @property (readonly, nonatomic, strong) SKPaymentTransaction * _Nullable sk1Transaction;
        [NullAllowed, Export("sk1Transaction", ArgumentSemantic.Strong)]
        SKPaymentTransaction Sk1Transaction { get; }
    }

    // @interface RCStorefront : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface RCStorefront
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull countryCode;
        [Export("countryCode")] string CountryCode { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull identifier;
        [Export("identifier")] string Identifier { get; }

        // -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
        [Export("isEqual:")]
        [Override]
        bool IsEqual([NullAllowed] NSObject @object);

        // @property (readonly, nonatomic) NSUInteger hash;
        [Export("hash")] nuint Hash { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")] [Override] string Description { get; }

        // @property (readonly, nonatomic, strong) SWIFT_AVAILABILITY(maccatalyst,introduced=13.1) SKStorefront * sk1Storefront __attribute__((availability(maccatalyst, introduced=13.1))) __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(tvos, introduced=13.0))) __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0)));
        [Watch(6, 2), TV(13, 0), MacCatalyst(13, 1), Mac(10, 15), iOS(13, 0)]
        [Export("sk1Storefront", ArgumentSemantic.Strong)]
        SKStorefront Sk1Storefront { get; }

        // @property (readonly, nonatomic, strong, class) RCStorefront * _Nullable sk1CurrentStorefront __attribute__((availability(maccatalyst, introduced=13.1))) __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(tvos, introduced=13.0))) __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0)));
        [Watch(6, 2), TV(13, 0), MacCatalyst(13, 1), Mac(10, 15), iOS(13, 0)]
        [Static]
        [NullAllowed, Export("sk1CurrentStorefront", ArgumentSemantic.Strong)]
        RCStorefront Sk1CurrentStorefront { get; }
    }

    // @interface RCSubscriptionPeriod : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface RCSubscriptionPeriod
    {
        // @property (readonly, nonatomic) NSInteger value;
        [Export("value")] nint Value { get; }

        // @property (readonly, nonatomic) enum RCSubscriptionPeriodUnit unit;
        [Export("unit")] RCSubscriptionPeriodUnit Unit { get; }

        // -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
        [Export("isEqual:")]
        [Override]
        bool IsEqual([NullAllowed] NSObject @object);

        // @property (readonly, nonatomic) NSUInteger hash;
        [Export("hash")] nuint Hash { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull debugDescription;
        [Export("debugDescription")] [Override] string DebugDescription { get; }
    }
}