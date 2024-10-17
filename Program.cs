namespace MiddleElementOfLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(10);
            list.AddLast(20);
            list.AddLast(30);
            list.AddLast(40);
            LinkedList<int> result = new LinkedList<int>();
            int res=0;
         
                res = list.Count/2;
            Console.WriteLine(list.ElementAt<int>(res));

           



        }
    }
}
