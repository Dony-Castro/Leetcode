/**
 * @param {number} x
 * @return {boolean}
 */
var isPalindrome = function(x) {
    if(x >= 0){
        let y = x.toString().split("").reverse().join("");
        return x == y
    } else {
        return false;
    }
};
