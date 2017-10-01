using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElliottProject4
{
    public class BTreeNode
    {
        public string value;
        //Need left pointer and a right pointer
        public BTreeNode leftNode;
        public BTreeNode rightNode;

        public int counter = 1;
    }
}
