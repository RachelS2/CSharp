namespace System
{
    static class StringExtensions
    {
        public static string Cut(this string thisString, int num)
        {
            if (thisString.Length > 10)
            {
                string nova = thisString.Substring(0, num);
                return nova + "...";
            }
            else return thisString;
        }
    }
}
