

class Node
{
    Node next;
    Object data;
}

class Stack {

  Node Top;

  public Node Pop()
  {
    if(Top==null)
       return null;

    Node n = Top;
    Top = Top.Next;
    return n;
  }

  public void Push(Object i)
  {
    Node n = new Node(i);
    n.Next = Top;
    Top = n;
  }
}

class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack(7);
            s.Push(5);
            s.Push(6);
            s.Push(7);
            s.Push(8);
            s.Push(1);
            s.Push(8);
            s.Push(8);

           foreach(int ss in s)
           {
                Console.WriteLine("{0}" ,ss);
           }
        }

}
