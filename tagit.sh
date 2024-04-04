#!/bin/bash
if [ "$#" -ne 1 ]; then
    echo "USAGE: $0 BindingVersionNumber"
    exit 1;
fi
git pull
bindingsVersion=$1
git tag release-bindings-v${bindingsVersion}
git tag release-extensions-v${bindingsVersion}
git tag release-ui-bindings-v${bindingsVersion}
git tag release-ui-extensions-v${bindingsVersion}
git push origin release-bindings-v${bindingsVersion}
git push origin release-extensions-v${bindingsVersion}
git push origin release-ui-bindings-v${bindingsVersion}
git push origin release-ui-extensions-v${bindingsVersion}
