using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Opc.UaFx;
using Opc.UaFx.Server;

namespace OPCUAServer
{
    internal class Robot : OpcNodeManager
    {
        public Robot()
            : base("http://Robot/machines")
        {
        }
        protected override IEnumerable<IOpcNode> CreateNodes(OpcNodeReferenceCollection references)
        {
            var Robot1 = new OpcFolderNode(this.DefaultNamespace.GetName("Robot1"));
            references.Add(Robot1, OpcObjectTypes.ObjectsFolder);
            new OpcDataVariableNode<string>(Robot1, "Name");
            new OpcDataVariableNode<double>(Robot1, "Position");
            new OpcDataVariableNode<bool>(Robot1, "Status");
            new OpcDataVariableNode<int>(Robot1, "Mode");
            new OpcDataVariableNode<double>(Robot1, "Temperature");

            var Robot2 = new OpcFolderNode(this.DefaultNamespace.GetName("Robot2"));
            references.Add(Robot2, OpcObjectTypes.ObjectsFolder);
            new OpcDataVariableNode<string>(Robot2, "Name");
            new OpcDataVariableNode<double>(Robot2, "Position");
            new OpcDataVariableNode<bool>(Robot2, "Status");
            new OpcDataVariableNode<int>(Robot2, "Mode");
            new OpcDataVariableNode<double>(Robot2, "Temperature");

            return new IOpcNode[] { Robot1, Robot2 };
        }
    }
}
