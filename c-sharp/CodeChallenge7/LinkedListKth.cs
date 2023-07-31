namespace CodeChallenges
{
  public class LinkedListKth : InsertableLinkedList
  {
    public int kthNodeValue; // Instance variable to store the kth node's value

    public int GetKthNodeValue()
    {
      return kthNodeValue;
    }

    // Modify the KthFromEnd method to accept two arguments
    public void KthFromEnd(int kthFromEnd, LinkedListKth list)
    {
      Node main_ptr = list.Head;
      Node ref_ptr = list.Head;

      int count = 0;

      if (list.Head == null)
      {
        throw new ArgumentException("The linked list is empty.");
      }

      if (kthFromEnd <= 0)
      {
        throw new ArgumentException("kthFromEnd must be a positive integer.");
      }

      while (count < kthFromEnd)
      {
        if (ref_ptr == null)
        {
          throw new ArgumentException("kthFromEnd is larger than the number of nodes in the list.");
        }
        ref_ptr = ref_ptr.Next;
        count++;
      }

      // Traverse the list to find the kth node from the end
      while (ref_ptr != null)
      {
        main_ptr = main_ptr.Next;
        ref_ptr = ref_ptr.Next;
      }

      kthNodeValue = main_ptr.Value;

    }
  }
}
