using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringtoDataStructures
{
    public class Node
    {
        public Node Parent;
        public string strValue;
        public List<Node> listSubnodes;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <param name="strlevel"></param>
        public static void PrintNode(Node node, string strlevel)
        {
            if (node.strValue.Length > 0)
            {
                Console.WriteLine(strlevel + "-" + node.strValue);
            }
               
            foreach (Node n in node.listSubnodes)
            {
                PrintNode(n, strlevel + "  ");
            }
        }

    }
}
