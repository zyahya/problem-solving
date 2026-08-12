#!/usr/bin/env bash

set -e

if [ $# -lt 2 ]; then
    echo "Usage: $0 <kyu(1-8)> <problem-name>"
    exit 1
fi

kyu="$1"
shift

problem_name="$*"

if ! [[ "$kyu" =~ ^[1-8]$ ]]; then
    echo "Error: kyu must be a number from 1 to 8."
    exit 1
fi

dir="${kyu}Kyu/${problem_name}"

mkdir -p "$dir"
touch "$dir/README.md"
touch "$dir/${problem_name}.cpp"

# Changed to EOF (no quotes) so $dir will expand
cat > "$dir/${problem_name}Tests.cpp" <<EOF
#include <doctest.h>
#include "./${problem_name}.cpp"

TEST_CASE("$dir")
{
    SUBCASE("$problem_name")
    {
        // CHECK(solution() == );
    }
}
EOF

echo "Created: $dir/${problem_name}.cpp"
