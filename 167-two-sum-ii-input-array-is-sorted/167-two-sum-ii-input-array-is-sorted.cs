public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
       int [] res= new int[2];

    for (int i = 0; i <= numbers.Length; i++)
    {
        int diff = target - numbers[i];
        var search = BinarySearch(i, numbers.Length-1, diff,i,numbers);
        if (search != -1)
        {
            res[0] = i+1;
            res[1] = search+1;
            break;
        }
    }

    return res;
}
int BinarySearch(int start, int end, int target,int pointer, int[] arr)
{
    int mid = (start + end) / 2;
    if (start > end)
    {
        return -1;
    }
    if (arr[mid] == target && mid==pointer)
    {
        if (mid!=arr.Length-1 && arr[mid+1]==target)
        {
            return mid+1;
        }
        else if (mid!=0 && arr[mid-1]==target)
        {
            return mid-1;
        }
    }
    else if (arr[mid] == target )
    {
        return mid;
    }
    else if (target > arr[mid])
    {
        return BinarySearch(mid + 1, end, target,pointer, arr);
    }
    else
    {
        return BinarySearch(start, mid - 1, target,pointer, arr);

    }
    return -1;
}
}