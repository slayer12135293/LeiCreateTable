using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Web.Mvc;
using OutputTable.Helpers;
using OutputTable.Models;

namespace OutputTable.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICreateRowList _iCreateRowList;

        public HomeController(ICreateRowList iCreateRowList)
        {
            _iCreateRowList = iCreateRowList;
        }


        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Index(SaveToFileViewModel saveToFileViewModel)
        {
            if (ModelState.IsValid)
            {
                var fileName = "target." + saveToFileViewModel.FileType;
                var row = _iCreateRowList.GetRowList(saveToFileViewModel);
                var byteArray = Encoding.ASCII.GetBytes(string.Join(Environment.NewLine, row.ToArray()));
                var stream = new MemoryStream(byteArray);

                return File(stream, "text/plain", fileName);
            }
            return View();

        }
       
    }

}
