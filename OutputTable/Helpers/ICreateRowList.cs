using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OutputTable.Models;

namespace OutputTable.Helpers
{
    public interface ICreateRowList
    {
        List<string> GetRowList(SaveToFileViewModel saveToFileViewModel);
    }
}
