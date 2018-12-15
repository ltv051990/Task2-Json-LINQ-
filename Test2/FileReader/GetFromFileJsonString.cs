using System;

namespace MyFileReader
{
    public static class GetJsonString
    {
        public static bool ReadFromFile(string path, out string result)
        {
            result = string.Empty;
            try
            {
                result = System.IO.File.ReadAllText(path);
            }
            catch (Exception exc)
            {
                Console.WriteLine(string.Format("Can't read from file{0}{1}", Environment.NewLine, exc));
                return false;
            }
            return true;
        }
    }
}
