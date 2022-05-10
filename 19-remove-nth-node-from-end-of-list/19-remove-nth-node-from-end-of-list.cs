/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
      int sz = 0;
    ListNode iterator = head;
    do
    {
        sz++;
        iterator = iterator.next;
    } while (iterator != null);
    iterator = head;
    ListNode pointer = head;
    for (int i = 0; i < sz-n; i++)
    {
        iterator = iterator.next;
        if (i+2<=sz-n)
        {
            pointer = iterator;
        }
    }
    if (iterator == head)
    {
        head = head.next;
    }
    else if (iterator.next==null)
    {
        pointer.next = null;
    }
    else
    {
        pointer.next = iterator.next;
    }
    return head;
    }
}