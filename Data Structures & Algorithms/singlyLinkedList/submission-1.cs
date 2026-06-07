public class ListNode 
{
    public int val;
    public ListNode Next;

    public ListNode(int val) 
    { 
        this.val = val;
        this.Next = null;
    }
}

public class LinkedList 
{
    private ListNode head;

    public LinkedList()
    { 
        head = null;
    }

    public int Get(int index) 
    { 
        ListNode current = head;
        int i = 0;

        while (current != null)
        {
            if (i == index) return current.val;
            current = current.Next;
            i++;
        }

        return -1;
    }

    public void InsertHead(int val) 
    { 
        ListNode newNode = new ListNode(val);
        newNode.Next = head;
        head = newNode;
    }

    public void InsertTail(int val) 
    { 
        ListNode newNode = new ListNode(val);

        if (head == null)
        {
            head = newNode;
            return;
        }

        ListNode current = head;
        while (current.Next != null)
        {
            current = current.Next;
        }

        current.Next = newNode;
    }

    public bool Remove(int index) 
    { 
        if (head == null) return false;

        if (index == 0)
        {
            head = head.Next;
            return true;
        }

        ListNode current = head;
        int i = 0;

        while (current != null && current.Next != null)
        {
            if (i == index - 1)
            {
                current.Next = current.Next.Next;
                return true;
            }
            current = current.Next;
            i++;
        }

        return false;
    }

    public List<int> GetValues() 
    { 
        List<int> result = new List<int>();

        ListNode current = head;

        while (current != null)
        {
            result.Add(current.val);
            current = current.Next;
        }

        return result;
    }
}