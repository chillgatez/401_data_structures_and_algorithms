namespace CodeChallenges
{
  public class LinkedListKth : InsertableLinkedList
  {
    public int kthNodeValue; // Instance variable to store the kth node's value

    public int GetKthNodeValue()
    {
      return kthNodeValue;
    }

    public void KthFromEnd(int kthFromEnd)
    {
      Node main_ptr = Head;
      Node ref_ptr = Head;

      int count = 0;

      if (Head == null)
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

      //traverse the list to find kth node from end
      while (ref_ptr != null)
      {
        main_ptr = main_ptr.Next;
        ref_ptr = ref_ptr.Next;
      }

      kthNodeValue = main_ptr.Value;


    }
  }
}
