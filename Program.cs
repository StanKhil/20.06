

namespace _20._06
{
    internal class Program
    {

        static void Permute(char[] arr, int start, List<string> perm)
        {
            if (start == arr.Length - 1) perm.Add(new string(arr));
            else
            {
                for (int i = start; i < arr.Length; i++)
                {
                    char temp = arr[start];
                    arr[start] = arr[i];
                    arr[i] = temp;
                    Permute(arr, start + 1, perm);
                    temp = arr[start];
                    arr[start] = arr[i];
                    arr[i] = temp;
                }
            }
        }

        static void Main()
        {
            Console.WriteLine("Enter string");
            string input = Console.ReadLine();
            List<string> perm = new List<string>();
            Permute(input.ToCharArray(), 0, perm);

            foreach (string p in perm)
                Console.WriteLine(p);
        }
    }
}