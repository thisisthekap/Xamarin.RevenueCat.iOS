#!/bin/bash

make

mv libPurchases.a ../Xamarin.RevenueCat.iOS/nativelib/libPurchases.a

rm libPurchases-arm64.a libPurchases-i386.a

rm -rf Purchases purchases-ios
