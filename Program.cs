namespace Week_3_Challenge_Labs_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter some letters and numbers");

            string myAnswer = Console.ReadLine();

            Console.WriteLine(SumDigitsInString(myAnswer));



            static int SumDigitsInString(string userInput) 
            {
                int sum = 0;
                int character;
                for (int i = 0; i<userInput.Length; i++)
                {
                    if (int.TryParse(Convert.ToString(userInput[i]), out character)) 
                    {
                        sum += character;
                    }

                }
                return sum;
            }
           
            
        }    
    }
}
