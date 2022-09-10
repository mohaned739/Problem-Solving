/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node CopyRandomList(Node head) {
         if (head == null)
                return null;
         Node node = head;
            Dictionary<Node, Node> deepCopy = new Dictionary<Node, Node>();
            while (node!=null)
            {
                Node copy = new Node(node.val);
                deepCopy[node] = copy;
                node = node.next;
            }
            node = head;
            while (node != null)
            {
                Node copy = deepCopy[node];
                if(node.next!=null)
                    copy.next = deepCopy[node.next];
                if (node.random != null)
                    copy.random = deepCopy[node.random];
                node = node.next;
            }
            return deepCopy[head];
    }
}