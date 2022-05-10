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
    public ListNode MiddleNode(ListNode head) {
        if (head.next==null)
    {
        return head;
    }
        ListNode mid = head;
    List<ListNode> nodes = new List<ListNode>();
    int numOfNodes = 0;
    do
    {
        nodes.Add(mid);
        numOfNodes++;
        mid = mid.next;
    }
    while (mid != null);
    if (numOfNodes%2!=0)
    {
        numOfNodes--;
    }
    mid = nodes[numOfNodes/2];
    return mid;
    }
}