using System;
using Foundation;
using RevenueCat;

namespace Xamarin.RevenueCat.iOS.Extensions
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
            : base($"{purchasesError?.Description} userCancelled: {userCancelled}", WrapError(purchasesError))
        {
            PurchasesError = purchasesError;
            UserCancelled = userCancelled;
            if (purchasesError != null)
            {
                purchasesError.UserInfo.TryGetValue(ErrorDetails.ReadableErrorCodeKey, out NSObject readableErrorCode);
                ReadableErrorCode = readableErrorCode;
                purchasesError.UserInfo.TryGetValue(NSError.UnderlyingErrorKey, out NSObject underlyingError);
                UnderlyingError = underlyingError;
                var localizedDescription = purchasesError.LocalizedDescription;
                LocalizedDescription = localizedDescription;

                int purchaseErrorCodeInt = (int)purchasesError.Code;
                PurchasesErrorCode = (RCPurchasesErrorCode)purchaseErrorCodeInt;
            }
        }

        private static NSErrorException WrapError(NSError purchasesError)
        {
            if (purchasesError != null)
            {
                return new NSErrorException(purchasesError);
            }

            return null;
        }
    }
}
