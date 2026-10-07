package binary_search

import (
	"testing"
)

func Test(t *testing.T) {
	result := solution([]int{-1, 0, 3, 5, 9, 12}, 9)

	if result != 4 {
		t.Errorf("expected 4, got %d", result)
	}
}
