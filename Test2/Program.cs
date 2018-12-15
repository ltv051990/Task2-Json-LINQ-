using System;
using MyFileReader;
using MyJsonModel;
using JsonConverter;
using MyOutput;
using MyReqest;

namespace Test2
{

    sealed class InfoStr
    {
        public readonly string uniqueStr = "sorted unique values in 2 arrays";

        public readonly string oddNbrStr = "unique odd numbers from the first array and information" +
            " how many times such a number occurs in the second array";

        public readonly string sumStr = "the sum of even numbers of the first array, which" +
            " are not represented in the second array";
    }


    class Program
    {
        static void Main(string[] args)
        {
            string jsonString = string.Empty;
            if (GetJsonString.ReadFromFile(@".\..\..\JSON.txt", out jsonString) == false)
                return;


            JsonModel model = JsonToModel.StringToModel(jsonString);
            try
            {
                ResultOutput.Print(model.arrayOne, "ArrayOne");
                ResultOutput.Print(model.arrayTwo, "ArrayTwo");

                var Info = new InfoStr();
                ResultOutput.Print(TestRequest.GetUniqueValues(model.arrayOne, model.arrayTwo), Info.uniqueStr);
                ResultOutput.Print(TestRequest.GetOddNumbers(model.arrayOne, model.arrayTwo), Info.oddNbrStr);
                ResultOutput.Print(TestRequest.GetEvenNbrSum(model.arrayOne, model.arrayTwo), Info.sumStr);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("EmptyArray");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow!");
            }

            Console.ReadLine();
        }
    }
}