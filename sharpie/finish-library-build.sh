#!/bin/bash

make

mv libPurchases.a ../Xamarin.RevenueCat.iOS/nativelib/libPurchases.a

rm libPurchases-arm64.a libPurchases-armv7.a libPurchases-x86_64.a

rm -rf Purchases purchases-ios
