#!/bin/bash

xcodebuild archive -sdk iphoneos -project ios/RevenueCatUIProxy.xcodeproj -scheme RevenueCatUIProxy -configuration Release -archivePath Output/Output-iphoneos SKIP_INSTALL=NO ENABLE_BITCODE=NO SWIFT_INSTALL_OBJC_HEADER=YES
xcodebuild archive -sdk iphonesimulator -project ios/RevenueCatUIProxy.xcodeproj -scheme RevenueCatUIProxy -configuration Release -archivePath Output/Output-iphonesimulator SKIP_INSTALL=NO ENABLE_BITCODE=NO SWIFT_INSTALL_OBJC_HEADER=YES

xcodebuild -create-xcframework -framework Output/Output-iphonesimulator.xcarchive/Products/Library/Frameworks/RevenueCatUIProxy.framework -framework Output/Output-iphoneos.xcarchive/Products/Library/Frameworks/RevenueCatUIProxy.framework -output Output/RevenueCatUIProxy.xcframework