function twoSum(nums: number[], target: number): number[] {
    let returnArray: number[];
    for( let i of nums.keys()){
        let sumNums = nums.slice();
        delete sumNums[i]
        for(let j of sumNums.keys()){
            if(sumNums[j] + nums[i] === target) {
                return [i, j]
            }
        }
    }
};
