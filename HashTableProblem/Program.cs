namespace HashTableProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyMapNode<int, string> map = new MyMapNode<int, string>(19);
            map.Add(0, "Paranoids");
            map.Add(1, "are");
            map.Add(2, "not");
            map.Add(3, "paranoid");
            map.Add(4, "because");
            map.Add(5, "they");
            map.Add(6, "are");
            map.Add(7, "paranoid");
            map.Add(8, "but");
            map.Add(9, "because");
            map.Add(10, "they");
            map.Add(11, "keep");
            map.Add(12, "putting");
            map.Add(13, "themselves");
            map.Add(14, "deliberately");
            map.Add(15, "into");
            map.Add(16, "paranoid");
            map.Add(17, "avoidable");
            map.Add(18, "situations");
            for (int i = 0; i < map.size; i++)
            {
                Console.WriteLine($"{i} index value : {map.Get(i)}");
            }
            Console.WriteLine("\nRemoving a Word from Paragraph");
            map.Remove(10);
            for (int i = 0; i < map.size; i++)
            {
                Console.WriteLine($"{i} index value : {map.Get(i)}");
            }        
        }
    }
}