namespace HashTableProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyMapNode<int, string> map = new MyMapNode<int, string>();
            map.Add(0, "to");
            map.Add(1, "be");
            map.Add(2, "or");
            map.Add(3, "not");
            map.Add(4, "to");
            map.Add(5, "be");
            map.GetFreq();

        }
    }
}