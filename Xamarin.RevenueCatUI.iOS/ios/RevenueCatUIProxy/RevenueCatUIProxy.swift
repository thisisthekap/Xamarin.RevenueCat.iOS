//
//  RevenueCatUIProxy.swift
//  RevenueCatUIProxy
//
//  Created by Albilaga Pradana on 15/03/24.
//

import Foundation
import UIKit
import RevenueCatUI
import RevenueCat

@objc(RevenueCatUIProxy)
 public class RevenueCatUIProxy: NSObject {
        
     @objc public static func presentPaywall(from topVC: UIViewController,
                                               didFinishPurchasing: @escaping (CustomerInfo) -> Void) {
            let controller = PaywallViewController()
            
            controller.delegate = DelegatedPaywallViewControllerDelegate(didFinishPurchasing: didFinishPurchasing)
            DispatchQueue.main.async {
                topVC.present(controller, animated: true, completion: nil)
            }
        }
    }


// Delegate wrapper class
class DelegatedPaywallViewControllerDelegate: PaywallViewControllerDelegate {
    private let didFinishPurchasing: (CustomerInfo) -> Void

    init(didFinishPurchasing: @escaping (CustomerInfo) -> Void) {
        self.didFinishPurchasing = didFinishPurchasing
    }

    func paywallViewController(_ controller: PaywallViewController, didFinishPurchasingWith customerInfo: CustomerInfo) {
        didFinishPurchasing(customerInfo)
    }
}
