using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Opc.UaFx;
using Opc.UaFx.Server;

namespace OPCUAServer
{
    internal class Sensor : OpcNodeManager
    {
        public Sensor()
            : base("http://sensor/machines")
        {
        }
        protected override IEnumerable<IOpcNode> CreateNodes(OpcNodeReferenceCollection references)
        {
            var Sensor1 = new OpcFolderNode(this.DefaultNamespace.GetName("Sensor1"));
            references.Add(Sensor1, OpcObjectTypes.ObjectsFolder);
            new OpcDataVariableNode<string>(Sensor1, "Name");
            new OpcDataVariableNode<bool>(Sensor1, "Status");
            new OpcDataVariableNode<double>(Sensor1, "MeasValue");

            var Sensor2 = new OpcFolderNode(this.DefaultNamespace.GetName("Sensor2"));
            references.Add(Sensor2, OpcObjectTypes.ObjectsFolder);
            new OpcDataVariableNode<string>(Sensor2, "Name");
            new OpcDataVariableNode<bool>(Sensor2, "Status");
            new OpcDataVariableNode<double>(Sensor2, "MeasValue");

            return new IOpcNode[] { Sensor1, Sensor2 };
        }
    }
}
