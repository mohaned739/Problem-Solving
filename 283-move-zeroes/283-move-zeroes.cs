public class Solution {
    public void MoveZeroes(int[] nums) {
        int []temp=new int[nums.Length];
    Array.Copy(nums,temp,nums.Length);
    Array.Sort(temp);
    int zeros = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (temp[i] == 0)
        {
            zeros++;
        }
        else if(temp[i]>0)
        {
            break;
        }
    }
    if (zeros>0)
    {
        int zerosFound = 0;
        int i = nums.Length-1;
        while (zeros!=zerosFound)
        {
            if (nums[i]==0)
            {
                for (int j = i; j < nums.LongLength-1; j++)
                {
                    if (nums[j+1]==0)
                    {
                        break;
                    }
                    int swap = nums[j];
                    nums[j] = nums[j + 1];
                    nums[j + 1] = swap;
                }
                zerosFound++;
            }
            i--;
        }
    }
    }
}