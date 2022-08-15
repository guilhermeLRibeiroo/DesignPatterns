using Facade.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class FacadeExample
    {
        private Subsystem1 _subsystem1;
        private Subsystem2 _subsystem2;

        public FacadeExample(Subsystem1 subsystem1, Subsystem2 subsystem2)
        {
            _subsystem1 = subsystem1;
            _subsystem2 = subsystem2;
        }

        public string Operation()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(_subsystem1.Operation1());
            sb.Append(_subsystem1.OperationN());

            sb.Append("\n");

            sb.Append(_subsystem2.Operation1());
            sb.Append(_subsystem2.OperationZ());

            return sb.ToString();
        }
    }
}
