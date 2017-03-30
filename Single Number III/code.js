/**
 * @param {number[]} nums
 * @return {number[]}
 */
var singleNumber = function(nums) {
    var count = nums.length;
    if (count == 2 && nums[0] == nums[1])
        return nums;

    var arr = [];
    for (var i = 0; i < count; i++) {
        arr[nums[i]] = arr[nums[i]] ? ++arr[nums[i]] : 1;

    }
    
    var result = [];
    for (i = 0; i < count; i++) {
        if (arr[nums[i]] == 1)
            result.push( nums[i]);
    }

    return result;
};