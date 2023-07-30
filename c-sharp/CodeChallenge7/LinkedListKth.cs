namespace CodeChallenges
{
  public class LinkedListKth : InsertableLinkedList
  {
    private int kthNodeValue; // Instance variable to store the kth node's value

    public void KthFromEnd(int kthFromEnd)
    {
      Node main_ptr = Head;
      Node ref_ptr = Head;

      int count = 0;

      if (Head != null)
      {
        while (count < kthFromEnd)
        {
          if (ref_ptr == null)
          {
            throw new ArgumentException("kthFromEnd is larger than the number of nodes in the list.");

          }
          ref_ptr = ref_ptr.Next;
          count++;
        }

        if (ref_ptr == null)
        {
          Head = Head.Next;
          if (Head != null)
            kthNodeValue = main_ptr.Value;
        }

        else
        {
          while (ref_ptr != null)
          {
            main_ptr = main_ptr.Next;
            ref_ptr = ref_ptr.Next;
          }
          return main_ptr.Value;

        }

        throw new ArgumentException("The linked list is empty.");
      }


    }
    // Method to get the kth node's value after calling the KthFromEnd method
    public int GetKthNodeValue()
    {
      return kthNodeValue;
    }
  }
}
