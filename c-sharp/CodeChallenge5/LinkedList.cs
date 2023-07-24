using System.Text;

namespace CodeChallenges
{
  public class LinkedList
  {
    private Node header;

    public Node Header
    {
      get { return header; }
      set { header = value; }
    }

    public void AddNewNode(int value)
    {
      Node newNode = new Node(value);
      newNode.Next = Header;
      Header = newNode;
    }

    public bool Contains(int value)
    {
      Node current = Header;
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
      Node current = Header;
      string result = "";
      while (current != null)
      {
        result += $"{{ {current.Value} }} -> ";
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
