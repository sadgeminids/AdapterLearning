using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterLearning
{
    public class AdapterByClass : TargetClass
    {
        SourceClass m_source;

        public AdapterByClass(SourceClass sc)
        {
            m_source = sc;
        }

        public override void OnGUI()
        {
            m_source.ShowButton();
        }
    }
}
