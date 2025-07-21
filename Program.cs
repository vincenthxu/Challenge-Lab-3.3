namespace Challenge_Lab_3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DetermineTargetIndices([2, 7, 11, 15], 9));
        }

        static (int, int) DetermineTargetIndices(int[] ints, int target)
        {
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] < target)
                {
                    for (int j = i; j < ints.Length; j++)
                    {
                        if (target - ints[j] == ints[i])
                            return (i, j);
                    }
                }
            }
            return (-1, -1);
        }
    }
}
