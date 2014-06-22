using System.Collections.Generic;
using OutputTable.Models;

namespace OutputTable.Helpers
{
    public class CreateRowList : ICreateRowList
    {
        private readonly IConvertStringArrayToString _convertStringArrayToString;

        public CreateRowList(IConvertStringArrayToString convertStringArrayToString)
        {
            _convertStringArrayToString = convertStringArrayToString;
        }

        public List<string> GetRowList(SaveToFileViewModel saveToFileViewModel )
        {
            var column = new List<string>();
            var row = new List<string>();

            for (int i = 0; i < saveToFileViewModel.Column; i++)
            {
                column.Add(i.ToString() + ' ');
            }

            var coloumString = _convertStringArrayToString.ArrayToString(column.ToArray());

            for (var i = 0; i < saveToFileViewModel.Row; i++)
            {
                if (saveToFileViewModel.FileType == "html")
                {
                    row.Add(coloumString + " <br>");
                }
                else
                {
                    row.Add(string.Join(" ", column.ToArray()));
                }
            }
            return row;
        }
    }
}