using System.Collections.Generic;

namespace OutputTable.Helpers
{
    public interface IConvertStringArrayToString
    {
        string ArrayToString(IEnumerable<string> array);
    }
}
