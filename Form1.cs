using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace treeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fordel(treeView1.Nodes);
        }
        int rNodeNumber, i;
        List<TreeNode> checkednodes = new List<TreeNode>();
        void fordel(TreeNodeCollection nodes)

        {
         foreach(TreeNode node in nodes)
            {
                if(node.Checked)
                {
                    checkednodes.Add(node);
                }
                else
                {
                    fordel(node.Nodes);
                }
                foreach(TreeNode checkednode in checkednodes)
                {
                    nodes.Remove(checkednode);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Add(textBox1.Text);
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            rNodeNumber = Convert.ToInt32(textBox3.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
          
                
              if(rNodeNumber==0)
            {
                treeView1.Nodes[0].Nodes.Add(textBox2.Text);
            }
              else
            {
                for(i=1;i<1000;i++)
                {
                    if(i==rNodeNumber)
                    {
                        treeView1.Nodes[i].Nodes.Add(textBox2.Text);
                    }
                }
            }
              
                
          
        }
    }
}
