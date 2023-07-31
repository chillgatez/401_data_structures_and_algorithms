using System.Collections.Generic;
namespace CodeChallenges
{
  public class CodeChallenge8
  {
    public static LinkedListKth ZipLists(LinkedListKth list1, LinkedListKth list2)
    {
      // Check if either of the lists is empty
      if (list1.IsEmpty)
        return list2;

      if (list2.IsEmpty)
        return list1;

      // Initialize two pointers to traverse the lists
      Node current1 = list1.Head;
      Node current2 = list2.Head;

      // Create a new linked list to store the merged result
      LinkedListKth result = new LinkedListKth();

      // Traverse through the two lists and alternate between nodes
      while (current1 != null && current2 != null)
      {
        result.Append(current1.Value);
        result.Append(current2.Value);
        current1 = current1.Next;
        current2 = current2.Next;
      }

      // If one of the lists is longer, append the rest of its nodes
      while (current1 != null)
      {
        result.Append(current1.Value);
        current1 = current1.Next;
      }

      while (current2 != null)
      {
        result.Append(current2.Value);
        current2 = current2.Next;
      }

      return result;
    }
  }
}
