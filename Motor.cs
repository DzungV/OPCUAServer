using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Opc.UaFx;
using Opc.UaFx.Server;

namespace OPCUAServer
{
    internal class Motor : OpcNodeManager
    {
        public Motor()
            : base("http://motor/machines")
        {
        }
        protected override IEnumerable<IOpcNode> CreateNodes(OpcNodeReferenceCollection references)
        {
            
            var Motor1 = new OpcFolderNode(this.DefaultNamespace.GetName("Motor1"));
            references.Add(Motor1, OpcObjectTypes.ObjectsFolder);
            new OpcDataVariableNode<string>(Motor1, "Name");
            #region StoreCppString
            //new OpcDataVariableNode<int>(Motor1, "NameLen");
            //for (int i = 0; i < 20; i++)            
            //new OpcDataVariableNode<int>(Motor1, $"nName{i}");
            #endregion
            new OpcDataVariableNode<int>(Motor1, "Name");
            new OpcDataVariableNode<double>(Motor1, "Position");
            new OpcDataVariableNode<bool>(Motor1, "Status");
            new OpcDataVariableNode<int>(Motor1, "Mode");
            new OpcDataVariableNode<double>(Motor1, "Temperature");

            

            var Motor2 = new OpcFolderNode(this.DefaultNamespace.GetName("Motor2"));
            references.Add(Motor2, OpcObjectTypes.ObjectsFolder);
            new OpcDataVariableNode<string>(Motor2, "Name");
            new OpcDataVariableNode<double>(Motor2, "Position");
            new OpcDataVariableNode<bool>(Motor2, "Status");
            new OpcDataVariableNode<int>(Motor2, "Mode");
            new OpcDataVariableNode<double>(Motor2, "Temperature");

            return new IOpcNode[] { Motor1, Motor2 };
        }
    }
}
