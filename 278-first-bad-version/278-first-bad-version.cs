/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
            if (n == 1 || IsBadVersion(1))
            {
                return 1;
            }
            else
            {
                return BinarySearch(2, (uint)n);
            }
    }
            int BinarySearch(uint start, uint end)
        {
            uint mid = (start + end) / 2;
            bool isBad = IsBadVersion((int)mid);
            if (start == end && isBad)
            {
                return (int)mid;
            }
            else if (isBad)
            {
                return BinarySearch(start, mid);
            }
            else
            {
                return BinarySearch(mid + 1, end);
            }
        }
}