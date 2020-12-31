using System;


namespace Application
{
	class Program
	{
		static void Main(string[] args)
		{
			Queue<char> q = new Queue<char>();
			q.Insert('3'); q.Insert('5'); q.Insert('9');
            Console.WriteLine(Biggest2Digits(q));
		}

		static int Biggest2Digits(Queue<Char> q)
		{
			int biggest = 0;
			int second = 0;
			while (!q.IsEmpty())
			{
				int x = q.Head();
				if (biggest == 0)
					biggest = x;
				else
				{
					if (x > biggest)
					{
						second = biggest;
						biggest = x;
					}
					else if (x > second)
					{
						second = x;
					}
				}

				q.Remove();
			}

			return ((biggest - 48) * 10 + (second - 48));
		}
	}
}