using System;
using System.Collections.Generic;
using System.Text;

namespace DataUtilities.ViewModel
{
    public class Model_Recipe
    {
        public int id { get; set; }
        public String name { get; set; }
        public List<Model_Step> steps { get; set; }

        public Model_Recipe() { }
    }
}
