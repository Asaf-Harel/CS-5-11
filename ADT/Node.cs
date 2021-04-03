public class Node<T>
{
    private T value;
    private Node<T> next;

    //בנאים
    public Node(T value)
    {
        //הפעולה בונה ומחזירה חוליה שהערך שלה הוא value ואין לה חוליה עוקבת
        this.value = value;
        this.next = null;
    }
    public Node(T value, Node<T> next)
    {
        //הפעולה בונה ומחזירה חוליה, שהערך שלה הוא value
        //והחוליה העוקבת לה היא החוליה next
        this.value = value;
        this.next = next;
    }

    //Get
    public T GetValue()
    {
        //הפעולה מחזירה את הערך של החוליה הנוכחית
        return value;
    }
    public Node<T> GetNext()
    {
        //הפעולה מחזירה את החוליה העוקבת לחוליה הנוכחית
        return next;
    }
    //Set
    public void SetValue(T value)
    {
        //הפעולה קובעת את ערך החוליה הנוכחית להיות value
        this.value = value;
    }
    public void SetNext(Node<T> next)
    {
        //הפעולה קובעת את החוליה העוקבת לחוליה הנוכחית להיות החוליה next
        this.next = next;
    }


    public bool HasNext()
    {
        //הפעולה מחזירה האם קיימת החוליה העוקבת לחוליה הנוכחית
        return next != null;
    }
    public override string ToString()
    {
        //הפעולה מחזירה מחרוזת המתארת את החוליה הנוכחית
        return this.value.ToString();
    }
}
