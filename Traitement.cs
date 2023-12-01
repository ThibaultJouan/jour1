
using System.Text.RegularExpressions;

class Traitement
{
    public  static int GetNumbers(string input)
    {
        string result = String.Empty;
        input = ReplaceStringByInt(input);
        Regex reg = new Regex("[a-zA-Z]");
        input = reg.Replace(input, "");

        result = input[0].ToString();
        result += input[^1].ToString();
        
        
        if(int.TryParse(result, out int number))
        {
            return number;
        }
        return 0;
    }

    public static string ReplaceStringByInt(string input)
    {
        input = input.Replace("one", "o1e");
        input = input.Replace("two", "t2o");
        input = input.Replace("three", "t3e");
        input = input.Replace("four", "f4r");
        input = input.Replace("five", "f5e");
        input = input.Replace("six", "s6x");
        input = input.Replace("seven", "s7n");
        input = input.Replace("eight", "e8t");
        input = input.Replace("nine", "n9e");

        return input;
    }
}