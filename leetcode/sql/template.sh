#!/usr/bin/env bash

if [[ -z "$1" ]]; then
    echo "Usage: $0 \"problem name\""
    exit 1
fi

NAME="${1,,}"
NAME="${NAME// /_}"

mkdir -p "$NAME"
touch "$NAME/$NAME.sql"

echo "Created: $NAME/$NAME.sql"
