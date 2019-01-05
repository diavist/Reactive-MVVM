using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.MVVM.Configuration
{
    public class MVVMConfiguration
    {
        public static MVVMConfiguration Configuration
        {
            get
            {
                return new MVVMConfiguration();
            }
        }
        public string DefaultTitle
        {
            get
            {
                return "Some Title";
            }
        }

        public string MessageBoxTitle
        {
            get
            {
                return "MessageBox Title";
            }
        }
    }
}
