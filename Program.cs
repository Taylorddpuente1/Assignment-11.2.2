using System;

public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    // Reverse linked list
    public ListNode ReverseList(ListNode head)
    {
        ListNode prev = null;
        ListNode current = head;

        while (current != null)
        {
            ListNode nextTemp = current.next;
            current.next = prev;
            prev = current;
            current = nextTemp;
        }

        return prev;
    }

 
    public static void PrintList(ListNode head)
    {
        ListNode current = head;
        while (current != null)
        {
            Console.Write(current.val + " ");
            current = current.next;
        }
        Console.WriteLine();
    }
}

public class Program
{
    public static void Main()
    {
        int[] values = { 1, 2, 3, 4, 5 };

      
        ListNode head = null;
        ListNode current = null;

        foreach (int val in values)
        {
            if (head == null)
            {
                head = new ListNode(val);
                current = head;
            }
            else
            {
                current.next = new ListNode(val);
                current = current.next;
            }
        }

        Console.WriteLine("Original list:");
        Solution.PrintList(head);

        // Reverse the list
        Solution solution = new Solution();
        ListNode reversed = solution.ReverseList(head);

        Console.WriteLine("Reversed list:");
        Solution.PrintList(reversed);
    }
}