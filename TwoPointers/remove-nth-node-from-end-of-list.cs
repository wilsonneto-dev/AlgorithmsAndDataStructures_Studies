// https://leetcode.com/problems/remove-nth-node-from-end-of-list/

public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        var end = head;
        for(int i = 1; i < n; i++) end = end.next;
        var beforeList = new ListNode(0, head);
        var toRemoveNext = beforeList;
        while(end?.next is not null)
        {
            end = end.next;
            toRemoveNext = toRemoveNext.next;            
        }
        toRemoveNext.next = toRemoveNext.next?.next;
        return beforeList.next;
    }
}
