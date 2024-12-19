namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> myStack = new MyStack<int>();
            myStack.Push(10);
            myStack.Push(20);

            myStack.Pop();

            int x = myStack.Pop();

            Console.WriteLine($"Item(s) left in my stack is: {x}");

        }
    }
}
