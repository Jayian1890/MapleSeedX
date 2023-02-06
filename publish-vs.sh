#!/bin/bash
dotnet publish -r osx-x64 --configuration Release -p:UseAppHost=true

APP_NAME="MapleSeedX.app"
PUBLISH_OUTPUT_DIRECTORY="/Users/jayian/Projects/MapleSeedX/bin/Release/net7.0/publish/"
# PUBLISH_OUTPUT_DIRECTORY should point to the output directory of your dotnet publish command.
INFO_PLIST="/Users/jayian/Projects/MapleSeedX/Assets/Info.plist"
ICON_FILE="/Users/jayian/Projects/MapleSeedX/Assets/MapleSeedX.icns"

if [ -d "$APP_NAME" ]
then
    rm -rf "$APP_NAME"
fi

mkdir "$APP_NAME"

mkdir "$APP_NAME/Contents"
mkdir "$APP_NAME/Contents/MacOS"
mkdir "$APP_NAME/Contents/Resources"

cp "$INFO_PLIST" "$APP_NAME/Contents/Info.plist"
cp "$ICON_FILE" "$APP_NAME/Contents/Resources/$ICON_FILE"
cp -a "$PUBLISH_OUTPUT_DIRECTORY" "$APP_NAME/Contents/MacOS"
