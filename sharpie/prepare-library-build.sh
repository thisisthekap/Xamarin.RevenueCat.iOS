#!/bin/bash
revenueCatVersion=$(cat revenuecat-version.txt)

git clone https://github.com/RevenueCat/purchases-ios.git
cd purchases-ios
git checkout $revenueCatVersion
cd ..

tar -xzf Purchases.zip

cd Purchases/Purchases/

cp -r ../../purchases-ios/Purchases/* .

cd ..
xed .
cd ..
