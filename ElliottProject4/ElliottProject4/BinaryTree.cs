using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElliottProject4
{
    public class BinaryTree
    {
        private BTreeNode root;
        private BTreeNode temp;

        public void addNode(string nodeValue)
        {
            temp = new BTreeNode();
            temp.value = nodeValue;

            if (root == null)
            {
                root = temp;
            }
            else
            {
                recAddNode(root);
            }
         
        }

        private void recAddNode(BTreeNode curNode)
        {
            //Compares two strings, if new value is "less than" previous/current will be put in left node
            if (string.Compare(temp.value, curNode.value, StringComparison.CurrentCulture) < 0)
            {
                if (curNode.leftNode == null)
                {
                    curNode.leftNode = temp;
                }
                else
                    recAddNode(curNode.leftNode);
            }

            //Compares two strings, if new value is "greater than" previous/current will be put in right node
            else if (string.Compare(temp.value, curNode.value, StringComparison.CurrentCulture) > 0)
            {
                if (curNode.rightNode == null)
                {
                    curNode.rightNode = temp;
                }
                else
                    recAddNode(curNode.rightNode);
            }
            else
                //If word exists in tree will increment counter
                curNode.counter++;
        }

        public String printOut()
        {
            return recPrintOut(root);
        }

        private String recPrintOut(BTreeNode cur)
        {
            String tempsString = "";

            if (cur.leftNode != null)
                tempsString = recPrintOut(cur.leftNode);

            tempsString += cur.value + " (" + cur.counter.ToString() + " occurrences)\r\n";

            if (cur.rightNode != null)
                tempsString += recPrintOut(cur.rightNode);

            return tempsString;
        }

    }

}
