/**
 * @param {number[]} nums
 * @param {Function} fn
 * @param {number} init
 * @return {number}
 */
var reduce = function(nums, fn, init) {
    let a = init;
    nums.forEach((e, i) => {
        a = fn(a, e)
    })
    return a
};
