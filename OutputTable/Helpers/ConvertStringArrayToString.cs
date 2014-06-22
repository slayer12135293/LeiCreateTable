using System.Collections.Generic;
using System.Text;

namespace OutputTable.Helpers
{
    public class ConvertStringArrayToString : IConvertStringArrayToString
    {
        public string ArrayToString(IEnumerable<string> array)
        {
            var builder = new StringBuilder();
            foreach (var value in array)
            {
                builder.Append(value);
                builder.Append(' ');
            }
            return builder.ToString();
        }
    }
}