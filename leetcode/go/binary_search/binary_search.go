package binary_search

func solution(nums []int, target int) int {
	var min int = 0
	var max int = len(nums) - 1

	for min <= max {
		var middle int = (min + max) / 2

		if nums[middle] == target {
			return middle
		}

		if nums[middle] > target {
			max = middle - 1
		} else if nums[middle] < target {
			min = middle + 1
		}
	}

	return -1
}
