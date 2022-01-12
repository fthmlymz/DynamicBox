namespace DynamicBox.Workflow.Shared
{
    public static class Helpers
    {

    }

    public static class StringExtensions
    {
        public static string GetValueOrDefault(this string str, string alternative)
        {
            if (string.IsNullOrEmpty(str))
            {
                return alternative;
            }

            return str;
        }
    }
}
