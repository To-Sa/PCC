using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace PCC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); //METHODS: Clear, Contains, ToArray...
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stack<int> stacCk = new Stack<int>();

            stacCk.Push(1);      //STACK - LIFO: Last in First out
            stacCk.Push(2);
            stacCk.Push(3);      //.Push
            stacCk.Push(4);

            foreach (int item in stacCk)
            {
                listBox1.Items.Add(item); //swap
            }

            while (stacCk.Count != 0)
            {
                listBox1.Items.Add(stacCk.Pop()); //get the last item and delete
            }
        }
    }
}
