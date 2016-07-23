using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringtoDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            string strInput = "(id,created,employee(id,firstname,employeeType(id),lastname),location)";

            Node root = new Node { Parent = null, strValue = "root", listSubnodes = new List<Node>() };
            Node node = root;

            bool escape = false;
            foreach (char c in strInput)
            {
                if(escape)
                {
                    node.strValue += c;
                    escape = false;
                }
                else
                {
                    switch (c)
                    {
                        case '{':
                            node = new Node { Parent = node, strValue = String.Empty, listSubnodes = new List<Node>() };
                            node.Parent.listSubnodes.Add(node);
                            break;
                        case '}':
                            node = new Node { Parent = node, strValue = String.Empty, listSubnodes = new List<Node>() };
                            if(node.Parent!=null)
                            {
                                node.Parent.listSubnodes.Add(node);
                            }
                            break;

                        case '\\':
                            escape = true;
                            break;
                        default:
                            node.strValue += c;
                            break;
                    }
                }
            }


            Node.PrintNode(root,string.Empty);

        }
    }

}