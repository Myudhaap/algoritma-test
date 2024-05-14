namespace nawadata_2.Utils
{
    public class Util
    {
        public static string ArrayToString<T>(List<T> arrays){
            string arrayString = $"[{string.Join(",", arrays)}]";
            return arrayString;
        }
    }
}