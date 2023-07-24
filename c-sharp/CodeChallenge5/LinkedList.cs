using System.Text;

namespace CodeChallenges
{
  public class LinkedList
  {
    private Node head;

    public Node Head
    {
      get { return head; }
      set { head = value; }
    }

    public void Insert(int value)
    {
      Node newNode = new Node(value);
      newNode.Next = Head;
      Head = newNode;
    }

    public bool Includes(int value)
    {
      Node current = Head;
      while (current != null)
      {
        if (current.Value == value)
        {
          return true;
        }
        current = current.Next;
      }
      return false;
    }

    public override string ToString()
    {
      Node current = Head;
      string result = "";
      while (current != null)
      {
        result += $"{current.Value} -> ";
        current = current.Next;
      }
      result += "NULL";
      return result;
    }
  }

  public class Node
  {
    public int Value { get; set; }
    public Node Next { get; set; }

    public Node(int value)
    {
      Value = value;
      Next = null;
    }
  }
}
