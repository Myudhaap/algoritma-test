namespace nawadata_2.Services
{
    public class Soal4Service
    {
        public static Dictionary<string, string> MaxLetter(string text){
            if(text.Trim().Length == 0) return new Dictionary<string, string>{
                {"letter", ""},
                {"value", "0"}
            };

            Dictionary<char,int> letters = new Dictionary<char, int>();
            char[] textArray = text.ToCharArray();
            char res = textArray[0];
            
            foreach(char val in text){
                if(letters.ContainsKey(val)) letters[val]++;
                else letters[val] = 1;
            }

            foreach(var letter in letters){
                if(letters[res] < letter.Value){
                    res = letter.Key;
                }
            }

            return new Dictionary<string, string>{
                {"letter", res.ToString()},
                {"value", letters[res].ToString()}
            };
        }
    }
}