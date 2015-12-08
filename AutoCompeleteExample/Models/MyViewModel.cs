using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoCompeleteExample.Models
{
    public class MyViewModel
    {
        public DropItems e1 { get; set; }
        public string e2 { get; set; }
    }

    public class DropItems
    {
        public DropItems()
        {
            this.Lst = new SelectList(
                new List<SelectListItem>
                {
                    new SelectListItem { Selected = true, Text = string.Empty, Value = "-1"},
                    new SelectListItem { Selected = false, Text = "optionA", Value = "0"},
                    new SelectListItem { Selected = false, Text = "optionB", Value = "1"},
                    new SelectListItem { Selected = false, Text = "optionC", Value = "2"},
                }, "Value", "Text", 1);
        }
        public SelectList Lst { get; set; }
        public string ChosenVal { get; set; }
    }
}