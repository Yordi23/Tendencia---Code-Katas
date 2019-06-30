
namespace WordWrap2
{
    public class Wrapper
    {
        public static string Wrap(string sentence, int columnLenght)
        {
            string word = "", output = "";
            int count = 0;


            for (int i = 0; i < sentence.Length; i++)
            {
                word += sentence[i];

                if (sentence[i] == ' ' || i ==  sentence.Length)
                {
                    if (count >= columnLenght)
                    {
                        output +=  word.Substring(0,word.Length-1) + "\n" ;
                        count = 0;
                        
                    }
                    else output += word;

                    word = "";
                }

                count++;

            }

            
            return output;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
