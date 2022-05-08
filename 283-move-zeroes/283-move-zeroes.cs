public class Solution {
    public void MoveZeroes(int[] nums) {
      List<int> nonZeros = new List<int>();
    int zerosCount = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i]==0)
        {
            zerosCount++;
        }
        else
        {
            nonZeros.Add(nums[i]);
        }
    }
    for (int i = 0; i < zerosCount; i++)
    {
        nonZeros.Add(0);
    }
    Array.Copy(nonZeros.ToArray(),nums,nums.Length);    
    }
}