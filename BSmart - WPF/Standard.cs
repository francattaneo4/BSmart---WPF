using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSmart___WPF
{
    public class Standard
    {
        public List<string> Get()
        {
            List<string> List = new List<string>();
            List.Add("Premium");
            List.Add("Standard");
            List.Add("Basic");
            return List;
        }
    }
}
