public class Stack<T>
{
    public Stack()
    {
        //מחזירה מחסנית ריקה
        
    }

    public void Push(T x)
    {
        //מכניסה את הערך x לראש המחסנית
        //הנחה - המחסנית אותחלה
       
    }

    public T Pop()
    {
        //מוציאה ומחזירה את הערך הנמצא בראש המחסנית
        //הנחה - המחסנית אותחלה ואינה ריקה
        return default(T);
    }
    public T Top()
    {
        //מחזירה את הערך הנמצא בראש המחסנית
        //הנחה - המחסנית אותחלה ואינה ריקה
        return default(T);
    }

    public bool IsEmpty()
    {
        //מחזירה האם המחסנית ריקה
        //הנחה - המחסנית אותחלה
        return false;
    }
}