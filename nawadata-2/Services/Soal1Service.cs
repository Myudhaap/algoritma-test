namespace nawadata_2.Services
{
    public class Soal1Service{
        public static int CountWord(string text){
            List<string> words = text.Split(" ").ToList();
            return words.Count;
        }
    }
}