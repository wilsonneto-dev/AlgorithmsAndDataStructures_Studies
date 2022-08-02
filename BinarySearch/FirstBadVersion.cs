/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

// solution 1 => 40 min => 02/08

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        if(IsBadVersion(1)) 
            return 1;
        
        var leftPointer = 1;
        var rightPointer = n;
            
        while(rightPointer >= leftPointer && (rightPointer - leftPointer) > 1)
        {
            var pivot = leftPointer + ((rightPointer - leftPointer)/2);
            if(IsBadVersion(pivot)) rightPointer = pivot;
            else leftPointer = pivot;
        }
        return rightPointer;
    }
}
