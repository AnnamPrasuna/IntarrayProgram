using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntarrayProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 1, 1, 2, 2, 3 };
            int k = 2;

            int[] result = TopKFrequentElements(nums, k);

            Console.WriteLine("Output: {" + string.Join(", ", result) + "}");
            Console.ReadLine();
        }
        static int[] TopKFrequentElements(int[] nums, int k)
        {
            Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

            // Step 1: Count the frequency of each element
            foreach (int num in nums)
            {
                if (frequencyMap.ContainsKey(num))
                    frequencyMap[num]++;
                else
                    frequencyMap[num] = 1;
            }

            // Step 2: Create a list of unique elements
            List<int> uniqueElements = frequencyMap.Keys.ToList();

            // Step 3: Sort the list based on frequency and element value
            uniqueElements.Sort((a, b) =>
            {
                int freqComparison = frequencyMap[b].CompareTo(frequencyMap[a]);
                return freqComparison != 0 ? freqComparison : b.CompareTo(a);
            });

            // Step 4: Take the first k elements
            return uniqueElements.Take(k).ToArray();
            Console.ReadLine();
        }
        
    }
    }
