/**
 * @param {number[]} arr
 * @param {Function} fn
 * @return {number[]}
 */
function map(arr, fn) {
    for(let [i, n] of arr.entries()){
        arr[i] = fn(n, i)
    }
    return arr
};
