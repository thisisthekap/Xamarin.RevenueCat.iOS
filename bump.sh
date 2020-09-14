#!/bin/bash
if [ "$#" -ne 1 ]; then
    echo "USAGE: $0 VersionNumber"
    exit 1;
fi

git pull
git push
git tag release-v$1
git push origin release-v$1

