using System.Collections.Generic;
using System.Linq;


namespace MyReqest
{
        public class TestRequest
        {
            //sorted unique values in 2 arrays
            public static int[] GetUniqueValues(int[] arrayOne, int[] arrayTwo) =>
                                                        arrayOne.Except(arrayTwo).
                                                            Concat(arrayTwo.Except(arrayOne)).
                                                                OrderBy(x => x).ToArray();


            //unique odd numbers from the first array and information how many
            //times such a number occurs in the second array
            public static Dictionary<int, int> GetOddNumbers(int[] arrayOne, int[] arrayTwo) =>
                                                        arrayOne.Distinct()
                                                            .Where(x => x % 2 == 1)
                                                                .ToDictionary(x => x, x => arrayTwo.
                                                                    Where(a => a == x).Count());


            //the sum of even numbers of the first array,
            //which are not represented in the second array
            public static int GetEvenNbrSum(int[] arrayOne, int[] arrayTwo) =>
                                                        arrayOne.Except(arrayTwo)
                                                            .Where(x => x % 2 == 0)
                                                                .Sum();
    }
}
