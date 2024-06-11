namespace Assignment6._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 0, 5, 7, 0, 9 };

            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    arr[count++] = arr[i];
                }
            }

            while (count < arr.Length)
            {
                arr[count++] = 0;
            }
            

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}
