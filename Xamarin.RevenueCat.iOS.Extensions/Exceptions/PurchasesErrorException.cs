using System;
using Foundation;
using Purchases;

namespace Xamarin.RevenueCat.iOS.Extensions.Exceptions
{
    public class PurchasesErrorException : Exception
    {
        public NSError PurchasesError { get; }
        public bool UserCancelled { get; }

        public NSObject ReadableErrorCode { get; }
        public NSObject UnderlyingError { get; }
        public string LocalizedDescription { get; }
        public RCPurchasesErrorCode PurchasesErrorCode { get; }

        public PurchasesErrorException(NSError purchasesError, bool userCancelled)
            : base($"{purchasesError?.Description} userCancelled: {userCancelled}")
        {
            PurchasesError = purchasesError;
            UserCancelled = userCancelled;
            if (purchasesError != null)
            {
                purchasesError.UserInfo.TryGetValue(RCPurchasesErrors.RCReadableErrorCodeKey,
                    out NSObject readableErrorCode);
                ReadableErrorCode = readableErrorCode;
                purchasesError.UserInfo.TryGetValue(NSError.UnderlyingErrorKey, out NSObject underlyingError);
                UnderlyingError = underlyingError;
                var localizedDescription = purchasesError.LocalizedDescription;
                LocalizedDescription = localizedDescription;

                int purchaseErrorCodeInt = (int) purchasesError.Code;
                PurchasesErrorCode = (RCPurchasesErrorCode) purchaseErrorCodeInt;
            }
        }
    }
}
