#!/bin/bash
if [ "$#" -ne 1 ]; then
    echo "USAGE: $0 BindingVersionNumber"
    exit 1;
fi

bindingsVersion=$1
git tag release-bindings-v${bindingsVersion}
git tag release-extensions-v${bindingsVersion}
git push origin release-bindings-v${bindingsVersion}
git push origin release-extensions-v${bindingsVersion}
