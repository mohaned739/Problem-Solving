public class Solution {
    public int SearchInsert(int[] nums, int target) {
        return BinarySearch(0,nums.Length-1,target,nums);
    }
    int BinarySearch(int start, int end, int target, int[] arr)
{
    int mid = (start + end) / 2;
    if (start > end)
    {
        return -1;
    }
    if (arr[mid] == target || (mid!=0&&arr[mid]>target&&arr[mid-1]<target))
    {
        return mid;
    }
    else if (mid==0 && arr[mid]>target)
    {
        return mid;
    }
    else if (mid==arr.Length-1)
    {
        return mid + 1;
    }
    else if (target > arr[mid])
    {
        return BinarySearch(mid + 1, end, target, arr);
    }
    else
    {
        return BinarySearch(start, mid - 1, target, arr);

    }
}
}