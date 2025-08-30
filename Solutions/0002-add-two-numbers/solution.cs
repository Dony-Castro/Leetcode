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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode resultLinkedList = null;
        ListNode prevResultLinkedList = null;
        int remainingNextSum = 0;
        while(l1 != null || l2 != null || remainingNextSum > 0) {
            if(l1 != null && l2 != null) {
                int resultSum = (l1.val + l2.val + remainingNextSum) % 10;
                remainingNextSum = (l1.val + l2.val + remainingNextSum) / 10;
                if (resultLinkedList == null) {
                    resultLinkedList = new ListNode(resultSum);
                } else {
                    prevResultLinkedList = resultLinkedList;
                    resultLinkedList = new ListNode(resultSum, prevResultLinkedList);
                }
            } else if (l1 != null) {
                int resultSum = (l1.val + remainingNextSum) % 10;
                remainingNextSum = (l1.val + remainingNextSum) / 10;
                if (resultLinkedList == null) {
                    resultLinkedList = new ListNode(resultSum);
                } else {
                    prevResultLinkedList = resultLinkedList;
                    resultLinkedList = new ListNode(resultSum, prevResultLinkedList);
                }
            } else if (l2 != null) {
                int resultSum = (l2.val + remainingNextSum) % 10;
                remainingNextSum = (l2.val + remainingNextSum) / 10;
                if (resultLinkedList == null) {
                    resultLinkedList = new ListNode(resultSum);
                } else {
                    prevResultLinkedList = resultLinkedList;
                    resultLinkedList = new ListNode(resultSum, prevResultLinkedList);
                }
            } else if (remainingNextSum > 0) {
                int resultSum = remainingNextSum % 10;
                remainingNextSum = remainingNextSum / 10;
                if (resultLinkedList == null) {
                    resultLinkedList = new ListNode(resultSum);
                } else {
                    prevResultLinkedList = resultLinkedList;
                    resultLinkedList = new ListNode(resultSum, prevResultLinkedList);
                }
            }
            if(l1 != null) l1 = l1.next;
            if(l2 != null) l2 = l2.next;
        }
        
        ListNode start = resultLinkedList;
        ListNode prev = null;
        ListNode next;
        
        while (start != null) {
            next = start.next;
            start.next = prev;
            prev = start;
            start = next;
        }
        
        if (prev != null) return prev;
        return null;
    }
}
