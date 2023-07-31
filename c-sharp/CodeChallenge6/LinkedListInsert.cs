namespace CodeChallenges
{
  public class InsertableLinkedList : LinkedList
  {

    //adds a new node with the given value to the end of the list
    public void Append(int value)
    {
      Node newNode = new Node(value);

      if (Head == null)
      {
        // If the list is empty, set the new node as the head
        Head = newNode;
      }
      else
      {
        // Otherwise, traverse the list to find the last node
        Node current = Head;
        while (current.Next != null)
        {
          current = current.Next;
        }

        // Add the new node to the end
        current.Next = newNode;
      }
    }
    //adds a new node with the given new value immediately before the first node that has the value specified
    public void InsertBefore(int value, int valueToInsert)
    {
      Node newNode = new Node(valueToInsert);

      if (Head == null)
      {
        // If the list is empty, set the new node as the head
        Head = newNode;
      }
      else if (Head.Value == value)
      {
        // If the first node matches the value, insert the new node before the current head
        newNode.Next = Head;
        Head = newNode;
      }
      else
      {
        // Otherwise, traverse the list to find the node with the specified value
        Node current = Head;
        while (current.Next != null && current.Next.Value != value)
        {
          current = current.Next;
        }

        // If the specified value is found, insert the new node before it
        if (current.Next != null)
        {
          newNode.Next = current.Next;
          current.Next = newNode;
        }
        else
        {
          // If the specified value is not found, throw an exception
          throw new ArgumentException("Value not found in the linked list.");
        }
      }
    }

    //adds a new node with the given new value immediately after the first node that has the value specified
    public void InsertAfter(int value, int valueToInsert)
    {
      Node newNode = new Node(valueToInsert);

      if (Head == null)
      {
        // If the list is empty, set the new node as the head
        Head = newNode;
      }

      else
      {
        // Traverse the list to find the node with the specified value
        Node current = Head;
        while (current != null && current.Value != value)
        {
          current = current.Next;
        }

        // If the specified value is found, insert the new node after it
        if (current != null)
        {
          newNode.Next = current.Next;
          current.Next = newNode;
        }
        else
        {
          // If the specified value is not found, throw an exception
          throw new ArgumentException("Value not found in the linked list.");
        }
      }
    }
  }
}
