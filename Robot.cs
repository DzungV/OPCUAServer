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
            new OpcDataVariableNode<int>(Robot1, "Clientcntstt", 0);
            new OpcDataVariableNode<bool>(Robot1, "Confirmation");
            new OpcDataVariableNode<string>(Robot1, "Name");
            new OpcDataVariableNode<byte>(Robot1, "LenName");
            //new OpcDataVariableNode<double>(Robot1, "Position");
            //new OpcDataVariableNode<bool>(Robot1, "Status");
            //new OpcDataVariableNode<int>(Robot1, "Mode");
            //new OpcDataVariableNode<double>(Robot1, "Temperature");
            new OpcDataVariableNode<double>(Robot1, "x");
            new OpcDataVariableNode<double>(Robot1, "y");
            new OpcDataVariableNode<double>(Robot1, "z");
            new OpcDataVariableNode<double>(Robot1, "roll");
            new OpcDataVariableNode<double>(Robot1, "pitch");
            new OpcDataVariableNode<double>(Robot1, "yaw");
            new OpcDataVariableNode<double>(Robot1, "theta1");
            new OpcDataVariableNode<double>(Robot1, "theta2");
            new OpcDataVariableNode<double>(Robot1, "theta4");
            new OpcDataVariableNode<double>(Robot1, "d3");
            new OpcDataVariableNode<string>(Robot1, "CMDSend","No Command Sent yet");
            new OpcDataVariableNode<string>(Robot1, "CMDAck", "No Command Ack yet ");
            new OpcDataVariableNode<string>(Robot1, "DOSend", "No DO signal Sent yet");
            new OpcDataVariableNode<string>(Robot1, "DOAck", "No DO signal Ack yet");
            new OpcDataVariableNode<byte>(Robot1, "DIgroup1");
            new OpcDataVariableNode<byte>(Robot1, "DIgroup2");
            new OpcDataVariableNode<byte>(Robot1, "DOgroup1");
            new OpcDataVariableNode<byte>(Robot1, "DOgroup2");
            new OpcDataVariableNode<bool>(Robot1, "StatusMsg", true);
            new OpcDataVariableNode<int>(Robot1, "Startchar");
            new OpcDataVariableNode<string>(Robot1, "AlarmMsg", "No Errors");
            new OpcDataVariableNode<int>(Robot1, "ToolNumber");
            new OpcDataVariableNode<int>(Robot1, "JogSpeed");
            new OpcDataVariableNode<int>(Robot1, "Coordinate");
            new OpcDataVariableNode<bool>(Robot1, "ServoStt");
            new OpcDataVariableNode<int>(Robot1, "SystemStt");
            new OpcDataVariableNode<bool>(Robot1, "Mode");
            new OpcDataVariableNode<int>(Robot1, "SecLevel");
            new OpcDataVariableNode<bool>(Robot1, "LockRBC");
            new OpcDataVariableNode<bool>(Robot1, "CMDflag", true);
            new OpcDataVariableNode<bool>(Robot1, "CMDcheck", false);



            new OpcEventNode(Robot1, "Activated");

            //var outOfMaterial = new OpcDialogConditionNode(Robot1, "MaterialAlert");

            //outOfMaterial.Message = "Out of Material"; // Generic event message
            //outOfMaterial.Prompt = "The machine is out of material. Refill material supply to continue.";
            //outOfMaterial.ResponseOptions = new OpcText[] { "Continue", "Cancel" };
            //outOfMaterial.DefaultResponse = 0; // Index of ResponseOption to use
            //outOfMaterial.CancelResponse = 1;  // Index of ResponseOption to use
            //outOfMaterial.OkResponse = 0;      // Index of ResponseOption to use




            var Robot2 = new OpcFolderNode(this.DefaultNamespace.GetName("Robot2"));
            references.Add(Robot2, OpcObjectTypes.ObjectsFolder);
            new OpcDataVariableNode<string>(Robot2, "Name");
            new OpcDataVariableNode<double>(Robot2, "Position");
            new OpcDataVariableNode<bool>(Robot2, "Status");
            new OpcDataVariableNode<int>(Robot2, "Mode");
            new OpcDataVariableNode<double>(Robot2, "Temperature");
            new OpcDataVariableNode<double>(Robot2, "x");
            new OpcDataVariableNode<double>(Robot2, "y");
            new OpcDataVariableNode<double>(Robot2, "z");
            new OpcDataVariableNode<double>(Robot2, "roll");
            new OpcDataVariableNode<double>(Robot2, "pitch");
            new OpcDataVariableNode<double>(Robot2, "yaw");
            new OpcDataVariableNode<double>(Robot2, "theta1");
            new OpcDataVariableNode<double>(Robot2, "theta2");
            new OpcDataVariableNode<double>(Robot2, "theta3");
            new OpcDataVariableNode<string>(Robot2, "CMDSend", "No Command Sent yet");
            new OpcDataVariableNode<string>(Robot2, "CMDAck", "No Command Ack yet ");
            new OpcDataVariableNode<string>(Robot2, "IOSend", "No IO signal Sent yet");
            new OpcDataVariableNode<string>(Robot2, "IOAck", "No IO signal yet");
            new OpcDataVariableNode<string>(Robot2, "StartMsg");
            new OpcDataVariableNode<int>(Robot2, "ToolNumber");
            new OpcDataVariableNode<int>(Robot2, "JogSpeed");
            new OpcDataVariableNode<int>(Robot2, "Coordinate");
            new OpcDataVariableNode<bool>(Robot2, "ServoStt");
            new OpcDataVariableNode<int>(Robot2, "SystemStt");
            new OpcDataVariableNode<bool>(Robot2, "Mode");
            new OpcDataVariableNode<int>(Robot2, "SecLevel");
            new OpcDataVariableNode<bool>(Robot2, "LockRBC");

            var Robot3 = new OpcFolderNode(this.DefaultNamespace.GetName("Robot2"));
            references.Add(Robot3, OpcObjectTypes.ObjectsFolder);
            new OpcDataVariableNode<string>(Robot3, "Name");
            new OpcDataVariableNode<double>(Robot3, "Position");
            new OpcDataVariableNode<bool>(Robot3, "Status");
            new OpcDataVariableNode<int>(Robot3, "Mode");
            new OpcDataVariableNode<double>(Robot3, "Temperature");

            new OpcDataVariableNode<double>(Robot3, "x");
            new OpcDataVariableNode<double>(Robot3, "y");
            new OpcDataVariableNode<double>(Robot3, "z");
            new OpcDataVariableNode<double>(Robot3, "roll");
            new OpcDataVariableNode<double>(Robot3, "pitch");
            new OpcDataVariableNode<double>(Robot3, "yaw");
            new OpcDataVariableNode<double>(Robot3, "theta1");
            new OpcDataVariableNode<double>(Robot3, "theta2");
            new OpcDataVariableNode<double>(Robot3, "theta3");
            new OpcDataVariableNode<string>(Robot3, "CMDSend", "No Command Sent yet");
            new OpcDataVariableNode<string>(Robot3, "CMDAck", "No Command Ack yet ");
            new OpcDataVariableNode<string>(Robot3, "DOSend", "No DO signal Sent yet");
            new OpcDataVariableNode<string>(Robot3, "DOAck", "No DO signal Ack yet");
            new OpcDataVariableNode<string>(Robot3, "DISend", "No DI signal Sent yet");
            new OpcDataVariableNode<string>(Robot3, "DIAck", "No DI signal Ack yet");
            new OpcDataVariableNode<string>(Robot3, "StartMsg");
            new OpcDataVariableNode<int>(Robot3, "ToolNumber");
            new OpcDataVariableNode<int>(Robot3, "JogSpeed");
            new OpcDataVariableNode<int>(Robot3, "Coordinate");
            new OpcDataVariableNode<bool>(Robot3, "ServoStt");
            new OpcDataVariableNode<int>(Robot3, "SystemStt");
            new OpcDataVariableNode<bool>(Robot3, "Mode");
            new OpcDataVariableNode<int>(Robot3, "SecLevel");
            new OpcDataVariableNode<bool>(Robot3, "LockRBC");

            return new IOpcNode[] { Robot1, Robot2 };
        }
    }
}
