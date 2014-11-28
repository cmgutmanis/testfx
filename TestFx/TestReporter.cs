using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFx
{
    public class TestReporter
    {
        private string serviceName;
        private KeyValuePair<int, string> CurrentStep;
     //   private IDictionary<int, string> 

        public TestReporter(string serviceName)
        {
            this.serviceName = serviceName;
        }

        public void AddStep(string stepName)
        {
            
        }




    }
}
