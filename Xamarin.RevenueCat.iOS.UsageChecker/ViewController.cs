using System;
using UIKit;
using Xamarin.RevenueCat.iOS.Extensions;

namespace Xamarin.RevenueCat.iOS.UsageChecker
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
            var userCancelledException = new PurchasesErrorException(null, true);
            Console.WriteLine(userCancelledException);
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
        }
    }
}