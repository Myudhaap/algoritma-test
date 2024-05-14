namespace nawadata_2.Services
{
    public class Soal2Service
    {
        public static int MaxValue(List<int> numbers){
            int max = numbers[0];

            foreach(var number in numbers){
                if(max < number) max = number;
            }

            return max;
        }
    }
}