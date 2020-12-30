using System;


namespace Application
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
		}

		static int biggest2digits(Queue<Char> q)
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

			return (biggest * 10 + second);
		}
	}
}