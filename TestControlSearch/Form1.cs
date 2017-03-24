using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlSearchEngine;

namespace TestControlSearch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Build User defined Control list
            List<string> lst = new List<string>();
            lst.Add("Label");
            //lst.Add("CheckBox");
            lst.Add("RadioButton");

            ISearchControl ControlSearch = new SearchControl(lst);
            //Customize Search Form
            ControlSearch.SearchFormText = "vinay";
            ControlSearch.HideUserControls = false;
            ControlSearch.Find(this);
        }
    }
}
