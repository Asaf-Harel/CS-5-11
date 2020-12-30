using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Queue<T>
{
    private Node<T> first;
    private Node<T> last;

    public Queue()
    {
        //מחזירה תור ריק
        this.first = null;
        this.last = null;
    }

    public void Insert(T x)
    {
        //מכניסה את הערך x לסוף התור
        //הנחה - התור אותחל
        Node<T> temp = new Node<T>(x);
        if (first == null)
            first = temp;
        else
            last.SetNext(temp);
        last = temp;
    }
    public T Remove()
    {
        //מוציאה ומחזירה את הערך הנמצא בראש התור
        //הנחה - התור אותחל ואינו ריק
        T x = first.GetValue();
        first = first.GetNext();
        if (first == null)
            last = null;
        return x;
    }
    public T Head()
    {
        //מחזירה את הערך הנמצא בראש התור
        //הנחה - התור אותחל ואינו ריק
        return first.GetValue();
    }

    public bool IsEmpty()
    {
        //מחזירה האם התור ריק
        //הנחה - התור אותחל
        return first == null;
    }

    public override string ToString()
    {
        //מחזירה מחרוזת המתארת את תוכן התור
        //הנחה - התור אותחל
        string s = "[";
        Node<T> p = this.first;
        while (p != null)
        {
            s = s + p.GetValue().ToString();
            if (p.GetNext() != null)
                s = s + ",";
            p = p.GetNext();
        }
        s = s + "]";
        return s;
    }
}