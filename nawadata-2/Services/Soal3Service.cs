namespace nawadata_2.Services
{
    public class Soal3Service
    {
        public static List<int> BubbleSort(List<int> numbers){
            List<int> sortedNumbers = numbers[0..numbers.Count];
            while(true){
                int counter = 0;
                
                for(int i=0; i < sortedNumbers.Count - 1; i++){
                    if(sortedNumbers[i] > sortedNumbers[i + 1]){
                        (sortedNumbers[i], sortedNumbers[i+1]) = (sortedNumbers[i+1], sortedNumbers[i]); 
                        counter++;
                    }
                }

                if(counter == 0) break;
            }
            return sortedNumbers;
        }
    }
}