#!/bin/bash
cd "${0%/*}"
find . -type d -and \( -name "obj" -or -name "bin" \)
echo
echo "===================================="
echo
while true; do
    read -p "This is going nuke all the bin and object folders given above. Are you sure? " yn
    case $yn in
        [Yy]* ) echo "nuking..." \
            && find . -type d -and \( -name "obj" -or -name "bin" \) -exec rm -rf {} \; \
            && echo "nuking done"; break;;
        [Nn]* ) echo "skipped nuking" && exit;;
        * ) echo "Please answer (y)es or (n)o.";;
    esac
done