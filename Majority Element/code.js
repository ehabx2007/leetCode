/**
 * @param {number[]} nums
 * @return {number}
 */
var majorityElement = function(nums) {
    var arr = [];
    var count = nums.length;

    if (count == 0)
        return -1;
    if (count == 1)
        return nums[0];

    for (var i = 0; i < count; i++) {
        arr[nums[i]] = arr[nums[i]] ? ++arr[nums[i]] : 1;
    }

    for (var i = 0; i < count; i++) {
        if (arr[nums[i]] > (count / 2))
            return nums[i];
    }

    return null;
};