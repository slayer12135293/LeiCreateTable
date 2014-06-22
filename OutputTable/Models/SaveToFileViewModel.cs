using System.ComponentModel.DataAnnotations;

namespace OutputTable.Models
{
    public class SaveToFileViewModel
    {
        [Range(1,20)]
        public int Row { get; set; }
        [Range(1,20)]
        public int Column { get; set; }
        public string FileType { get; set; }
    }
}