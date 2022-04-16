// 21. Merge Two Sorted Lists on Leetcode https://leetcode.com/problems/merge-two-sorted-lists/

namespace MergeTwoLinkedLists;

public class ListNode {
     public int val;
     public ListNode next;
     public ListNode(int val=0, ListNode next=null) {
         this.val = val;
         this.next = next;
     } 
}
internal class Program
{
    
    static void Main(string[] args)
    {
        Program pr = new Program();
        pr.Start();
    }

    public void Start()
    {
        ListNode a1 = new ListNode(1);
        ListNode a2 = new ListNode(2);
        ListNode a3 = new ListNode(4);
        ListNode b1 = new ListNode(1);
        ListNode b2 = new ListNode(3);
        ListNode b3 = new ListNode(4);

        a1.next = a2;
        a2.next = a3;

        b1.next = b2;
        b2.next = b3;

        MergeTwoLists(a1, b1);
    }
    
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode tempNode = new ListNode(0); //You always want to start with an empty head node
        ListNode currentNode = tempNode;
        
        if (list1 == null && list2 == null) return null;

        while (list1 != null && list2 != null)
        {
            if (list1.val < list2.val) //if the node from list 1 is smaller, pick that as the current node and look to the next item on the list from now on
            {
                currentNode.next = list1; 
                list1 = list1.next;
            }
            else
            {
                currentNode.next = list2;
                list2 = list2.next;   
            }

            currentNode = currentNode.next;
        }

        if (list1 != null) //if there are leftovers, use that to continue the list
        {
            currentNode.next = list1;
            list1 = list1.next;
        }
        
        if (list2 != null)
        {
            currentNode.next = list2;
            list2 = list2.next;

        }

        return tempNode.next;
    }
    
}