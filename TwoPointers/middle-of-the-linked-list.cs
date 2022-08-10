// 22/08/10 -> 15 minutes -> T O(n) / S = O(1)

public class Solution {
    public ListNode MiddleNode(ListNode head) {
        var final = head;
        var middle = head;
        var idx = 0;
        while(final.next is not null)
        {
            final = final.next;
            if(idx++ % 2 == 0) middle = middle.next;
        }
        return middle;
    }
}
