#!/bin/bash
revenueCatVersion=$(cat ./revenuecat-version.txt)
targetSdk=iphoneos13.7

git clone https://github.com/RevenueCat/purchases-ios.git
cd purchases-ios
git checkout $revenueCatVersion
cd ..

sharpie bind \
	-sdk ${targetSdk} \
	./purchases-ios/Purchases/Public/Purchases.h \
	-scope ./purchases-ios/Purchases/Public \
	-namespace Purchases \
	-c -F .

rm -rf purchases-ios
