/**
 * @param {...(null|boolean|number|string|Array|Object)} args
 * @return {number}
 */
var argumentsLength = function(...args) {
    let o = [args].flat().length
    return o
};

/**
 * argumentsLength(1, 2, 3); // 3
 */
