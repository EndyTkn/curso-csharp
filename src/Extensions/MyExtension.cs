namespace Extensions
{
    public static class MyExtension
    {
        public static Int32? ToInt(this string str)
        {
            int res = 0;
            bool canParse = int.TryParse(str, out res);
            return canParse ? res : null;

        }

        public static double? ToDouble(this string str)
        {
            double res = 0;
            bool canParse = double.TryParse(str, out res);
            return canParse ? res : null;

        }
    }
}