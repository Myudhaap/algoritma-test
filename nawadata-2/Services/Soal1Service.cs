namespace nawadata_2.Services
{
    public class Soal1Service{
        public static int CountWord(string text){
            if(text.Trim().Length == 0) return 0;

            List<string> words = text.Split(" ").ToList();
            return words.Count;
        }
    }
}