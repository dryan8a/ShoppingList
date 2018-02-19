using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DylanShoppingForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] list = new string[0];
        private void AddButton_Click(object sender, EventArgs e)
        {
            string item = addItem.Text.Trim();
            string[] temp = new string[list.Length + 1];
            for (int i = 0; i < list.Length; i++)
            {
                temp[i] = list[i];
            }
            temp[temp.Length - 1] = item;
            list = temp;
            SetListBox();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            string[] temp = new string[list.Length - 1];
            int tempI = 0;
            for(int i = 0; i<temp.Length; i++)
            {
                if(list[i] == removeItem.Text)
                {
                    tempI--;
                }
                else
                {
                    temp[tempI] = list[i];
                }
                tempI++;
            }
            list = temp;
            SetListBox();
        }

        public void SetListBox()
        {
            ListBox.Items.Clear();
            for (int i = 0; i < list.Length; i++)
            {
                ListBox.Items.Add(list[i]);
            }
        }
    }
}