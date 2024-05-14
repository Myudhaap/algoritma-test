using nawadata_2.Services;
using nawadata_2.Utils;

namespace nawadata_2.Views
{
    public class View
    {
        public static object Run(){
            while(true){
                Console.WriteLine("================Menu================");
                Console.WriteLine("1. Question 1 Count Word Text.");
                Console.WriteLine("2. Question 2 Max Value Array.");
                Console.WriteLine("3. Question 3 Sorting Array.");
                Console.WriteLine("4. Question 4 Max Letter Appear.");
                Console.WriteLine("5. Exit.");
                Console.WriteLine("====================================");
                Console.Write("Enter menu: ");
                var menu = Console.ReadLine();

                switch(menu){
                    case "1":
                        MenuQuestion1();
                        break;
                    case "2":
                        MenuQuestion2();
                        break;
                    case "3":
                        MenuQuestion3();
                        break;
                    case "4":
                        MenuQuestion4();
                        break;
                    case "5":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Menu not available");
                        break;
                }
            }
        }

        private static void MenuQuestion1(){
            try{
                string text = "Halo, nama saya jhon Dhoe";
                int wordsCount = Soal1Service.CountWord(text);

                Console.WriteLine($"In: '{text}'");
                Console.WriteLine($"Out: The number of words in the sentence '{text}' is: {wordsCount}");
            }catch(NullReferenceException){
                Console.WriteLine("Input cannot be null");
            }
        }

        private static void MenuQuestion2(){
            try{
                List<int> numbers = [1,5,3,7,2];
                int maxValue = Soal2Service.MaxValue(numbers);
                
                Console.WriteLine($"In: '{Util.ArrayToString<int>(numbers)}'");
                Console.WriteLine($"Out: Maximum value in array {Util.ArrayToString<int>(numbers)} is: {maxValue}");
            }catch(NullReferenceException){
                Console.WriteLine("Input cannot be null");
            }
        }

        private static void MenuQuestion3(){
            try{
                List<int> numbers = [3,1,5,2,4];
                var sortedNumbers = Soal3Service.BubbleSort(numbers);

                Console.WriteLine($"In: '{Util.ArrayToString<int>(numbers)}'");
                Console.WriteLine($"Out: The sorting result of the array {Util.ArrayToString<int>(numbers)} is: {Util.ArrayToString<int>(sortedNumbers)}");
            }catch(NullReferenceException){
                Console.WriteLine("Input cannot be null");
            }
        }

        private static void MenuQuestion4(){
            try{
                string word = "Hello";
                var res = Soal4Service.MaxLetter(word);

                Console.WriteLine($"In: '{word}'");
                Console.WriteLine($"Out: The most letters out of the word '{word}' is '{res["letter"]}' as many is: {res["value"]}");
            }catch(NullReferenceException){
                Console.WriteLine("Input cannot be null");
            }
        }
    }
}