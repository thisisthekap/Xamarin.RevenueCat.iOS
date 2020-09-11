using ObjCRuntime;

namespace Purchases
{
	[Native]
	public enum RCAttributionNetwork : long
	{
		AppleSearchAds = 0,
		Adjust,
		AppsFlyer,
		Branch,
		Tenjin,
		Facebook,
		MParticle
	}

	[Native]
	public enum RCIntroEligibilityStatus : long
	{
		Unknown = 0,
		Ineligible,
		Eligible
	}

	[Native]
	public enum RCPackageType : long
	{
		Unknown = -2,
		Custom,
		Lifetime,
		Annual,
		SixMonth,
		ThreeMonth,
		TwoMonth,
		Monthly,
		Weekly
	}

	[Native]
	public enum RCPurchasesErrorCode : long
	{
		UnknownError = 0,
		PurchaseCancelledError,
		StoreProblemError,
		PurchaseNotAllowedError,
		PurchaseInvalidError,
		ProductNotAvailableForPurchaseError,
		ProductAlreadyPurchasedError,
		ReceiptAlreadyInUseError,
		InvalidReceiptError,
		MissingReceiptFileError,
		NetworkError,
		InvalidCredentialsError,
		UnexpectedBackendResponseError,
		ReceiptInUseByOtherSubscriberError,
		InvalidAppUserIdError,
		OperationAlreadyInProgressError,
		UnknownBackendError,
		InvalidAppleSubscriptionKeyError,
		IneligibleError,
		InsufficientPermissionsError,
		PaymentPendingError,
		InvalidSubscriberAttributesError
	}

	[Native]
	public enum RCBackendErrorCode : long
	{
		InvalidPlatform = 7000,
		StoreProblem = 7101,
		CannotTransferPurchase = 7102,
		InvalidReceiptToken = 7103,
		InvalidAppStoreSharedSecret = 7104,
		InvalidPaymentModeOrIntroPriceNotProvided = 7105,
		ProductIdForGoogleReceiptNotProvided = 7106,
		InvalidPlayStoreCredentials = 7107,
		EmptyAppUserId = 7220,
		InvalidAuthToken = 7224,
		InvalidAPIKey = 7225,
		PlayStoreQuotaExceeded = 7229,
		PlayStoreInvalidPackageName = 7230,
		PlayStoreGenericError = 7231,
		UserIneligibleForPromoOffer = 7232,
		InvalidAppleSubscriptionKey = 7234,
		InvalidSubscriberAttributes = 7263,
		InvalidSubscriberAttributesBody = 7264
	}

	[Native]
	public enum RCStore : long
	{
		AppStore = 0,
		MacAppStore,
		PlayStore,
		Stripe,
		Promotional,
		UnknownStore
	}

	[Native]
	public enum RCPeriodType : long
	{
		Normal = 0,
		Intro,
		Trial
	}
}
