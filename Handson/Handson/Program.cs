namespace Handson
{
    internal class Program
    {
     
  static int[] ProcessArrays(int[] input1, int[] input2)
            {
                
                if (input1.Any(x => x < 0) || input2.Any(x => x < 0))
                {
                    return new int[] { -1 };
                }
                if (input1.Length != input2.Length)
                {
                    return new int[] { -2 };
                }
                Array.Sort(input1);
                input2 = input2.OrderByDescending(x => x).ToArray();
                int[] output = new int[input1.Length];
                for (int i = 0; i < input1.Length; i++)
                {
                    output[i] = input1[i] * input2[i];
                }

                return output;
            }

            static void Main()
            {
    
                int[] input1 = { 1, 2, 3, 4, 5 };
                int[] input2 = { 9, 8, 7, 6, 5 };
                int[] result = ProcessArrays(input1, input2);
                Console.WriteLine("Output: " + string.Join(", ", result));
            }
        }

    }


