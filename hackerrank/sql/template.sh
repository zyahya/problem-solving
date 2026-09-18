#!/usr/bin/env bash

if [[ -z "$1" ]]; then
    echo "Usage: $0 \"problem name\""
    exit 1
fi

NAME="${1// /_}"

mkdir -p "$NAME"
touch "$NAME/$NAME.sql"
touch "$NAME/README.md"

echo "Created: $NAME/$NAME.sql"
