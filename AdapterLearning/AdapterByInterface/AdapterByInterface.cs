using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterLearning
{
    public class AdapterByInterface : SourceClass, TargetInterface
    {
        public void OnGUI()
        {
            ShowButton();
        }
    }
}
