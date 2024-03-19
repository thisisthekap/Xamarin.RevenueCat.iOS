#!/bin/bash

xcodebuild archive -sdk iphoneos -project ios/RevenueCatUIProxy.xcodeproj -scheme RevenueCatUIProxy -configuration Release -archivePath Output/Output-iphoneos SKIP_INSTALL=NO ENABLE_BITCODE=NO SWIFT_INSTALL_OBJC_HEADER=YES
xcodebuild archive -sdk iphonesimulator -project ios/RevenueCatUIProxy.xcodeproj -scheme RevenueCatUIProxy -configuration Release -archivePath Output/Output-iphonesimulator SKIP_INSTALL=NO ENABLE_BITCODE=NO SWIFT_INSTALL_OBJC_HEADER=YES EXCLUDED_ARCHS=arm64


cp -R "Output/Output-iphoneos.xcarchive/Products/Library/Frameworks/RevenueCatUIProxy.framework/" "Output/RevenueCatUIProxy.framework"
cp -R "Output/Output-iphonesimulator.xcarchive/Products/Library/Frameworks/RevenueCatUIProxy.framework/Modules/RevenueCatUIProxy.swiftmodule/" "Output/RevenueCatUIProxy.framework/Modules/$RevenueCatUIProxy.swiftmodule/"

lipo -create -output Output/RevenueCatUIProxy.framework/RevenueCatUIProxy Output/Output-iphoneos.xcarchive/Products/Library/Frameworks/RevenueCatUIProxy.framework/RevenueCatUIProxy Output/Output-iphonesimulator.xcarchive/Products/Library/Frameworks/RevenueCatUIProxy.framework/RevenueCatUIProxy