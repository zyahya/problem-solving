#!/bin/bash

if [ -z "$1" ]; then
    echo "Usage: $0 <directory-path> [extension]"
    exit 1
fi

DIR="$1"
EXT="${2:-cs}"

if [ -d "$DIR" ]; then
    echo "Directory '$DIR' already exists."
    exit 1
fi

mkdir -p "$DIR"

touch "$DIR/solution.$EXT"
