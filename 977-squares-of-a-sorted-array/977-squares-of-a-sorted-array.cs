public class Solution {
    public int[] SortedSquares(int[] nums) {
        nums = SquareArr(nums);
        Array.Sort(nums);
        return nums;
    }
    int[] SquareArr(int []nums)
    {
    int start = 0;
    int end = nums.Length-1;
    while (start<=end)
    {
        int left = nums[start] * nums[start];
        int right = nums[end] * nums[end];
        nums[start] = left;
        nums[end] = right;
        start++;
        end--;
    }
    return nums;
}
}