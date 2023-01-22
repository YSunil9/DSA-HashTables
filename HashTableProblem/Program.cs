namespace HashTableProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyMapNode<int, string> map = new MyMapNode<int, string>(1);
            map.Add(0, "“Paranoids are not paranoid because they are" +
                       " paranoid but because they keep putting themselves " +
                       "deliberately into paranoid avoidable situations");
            string map0 = map.Get(0);
            Console.WriteLine(map0);
            Console.WriteLine("\nFrequency of Words\n");
            string[] arr = new string[map.size];
            for (int i = 0; i < map.size; i++)
            {
                arr[i] = map.Get(0);
            }
            map.FreqOfWords(arr, arr.Length);
        }
    }
}