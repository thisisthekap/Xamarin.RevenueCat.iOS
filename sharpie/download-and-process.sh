#!/bin/bash
revenueCatVersion=3.5.3
targetSdk=iphoneos13.7

wget https://github.com/RevenueCat/purchases-ios/releases/download/${revenueCatVersion}/Purchases.framework.zip
unzip Purchases.framework.zip
mv Carthage/Build/iOS/Purchases.framework .
rm -rf Carthage
rm Purchases.framework.zip
sharpie bind \
	-sdk ${targetSdk} \
	Purchases.framework/Headers/Purchases.h \
	-scope Purchases.framework/Headers \
	-namespace Purchases \
	-c -F .
mv *cs ../Xamarin.RevenueCat.iOS/
rm -rf ../Xamarin.RevenueCat.iOS/nativelib/Purchases.framework
mv Purchases.framework ../Xamarin.RevenueCat.iOS/nativelib/
