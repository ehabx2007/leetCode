/**
 * @param {number[]} nums
 * @return {number}
 */
var singleNumber = function(nums) {
    var count = nums.length;
    if (count == 1)
        return nums[0];

    var arr = [];
    for (var i = 0; i < count; i++) {
        arr[nums[i]] = arr[nums[i]] ? ++arr[nums[i]] : 1;
        
    }

    for (i = 0; i < count; i++) {
        if (arr[nums[i]] == 1)
            return nums[i];
    }
};