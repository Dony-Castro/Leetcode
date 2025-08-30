public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int[] mergedArray = nums1.Concat(nums2).ToArray();
        Array.Sort(mergedArray);
        double median = 0.0d;
        if (mergedArray.Length % 2 == 0) {
            median = (double)(mergedArray[mergedArray.Length / 2] + mergedArray[(mergedArray.Length / 2 - 1)]) / 2;
        } else {
            median = (double)mergedArray[mergedArray.Length / 2];
        }
        Array.ForEach(mergedArray, Console.WriteLine);
        return median;
    }
}
