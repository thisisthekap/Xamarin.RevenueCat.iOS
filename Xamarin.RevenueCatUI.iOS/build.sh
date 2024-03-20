#!/bin/bash

IOS_SDK_VERSION="17.4"
WORKSPACE_PATH="ios/RevenueCatUIProxy.xcworkspace"
SCHEME_NAME="RevenueCatUIProxy"
BUILD_FLAG="SKIP_INSTALL=NO ENABLE_BITCODE=NO SWIFT_INSTALL_OBJC_HEADER=YES BUILD_LIBRARY_FOR_DISTRIBUTION=YES"
CONFIG="Release"

# shellcheck disable=SC2086
xcodebuild archive -sdk "iphoneos$IOS_SDK_VERSION" -workspace "$WORKSPACE_PATH" -scheme "$SCHEME_NAME" -configuration "$CONFIG" -archivePath "Output/Output-iphoneos" $BUILD_FLAG
# shellcheck disable=SC2086
xcodebuild archive -sdk "iphonesimulator$IOS_SDK_VERSION" -workspace "$WORKSPACE_PATH" -scheme "$SCHEME_NAME" -configuration "$CONFIG" -archivePath "Output/Output-iphonesimulator" $BUILD_FLAG EXCLUDED_ARCHS=arm64

cp -R "Output/Output-iphoneos.xcarchive/Products/Library/Frameworks/RevenueCatUI.framework/" "Output/RevenueCatUI.framework"
cp -R "Output/Output-iphonesimulator.xcarchive/Products/Library/Frameworks/RevenueCatUI.framework/Modules/RevenueCatUI.swiftmodule/" "Output/RevenueCatUI.framework/Modules/RevenueCatUI.swiftmodule/"

lipo -create -output "Output/RevenueCatUI.framework/RevenueCatUI" "Output/Output-iphoneos.xcarchive/Products/Library/Frameworks/RevenueCatUI.framework/RevenueCatUI" "Output/Output-iphonesimulator.xcarchive/Products/Library/Frameworks/RevenueCatUI.framework/RevenueCatUI"
