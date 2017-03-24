using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlSearchEngine
{
    internal partial class SearchResultForm : Form
    {
        public event EventHandler SeachItemSelected;

        Font Defaultfont; //= new Font(
        Font UserFont;
        public List<string> lstUserControl;
        SearchBusinessLogic search;

        public string SearchFormText { 
            set
            {
                this.Text = value;   
            }
        }
        public Boolean HideStandardControls 
        { 
            set
            {
                if (value == false) searchTab.TabPages.RemoveByKey("0");
            } 
        }
        public Boolean HideUserControls
        {
            set
            {
                if (value == false) searchTab.TabPages.RemoveByKey("1");
            }
        }
        public Boolean HideLabel
        {
            set
            {
                if (value == false) ChkLabel.Visible = false;
            }
        }
        public Boolean HideRadioButton
        {
            set
            {
                if (value == false) ChkRadioButton.Visible = false;
            }
        }
        public Boolean HideCheckBox
        {
            set
            {
                if (value == false) chkCheckBox.Visible = false;
            }
        }
        

        internal SearchResultForm()
        {
            InitializeComponent();
        }
        internal void Go(Control parentform, List<string> lstUserControl_Para, System.Drawing.Font font_para)
        {
            lstUserControl = lstUserControl_Para;
            UserFont = font_para;
            LoadUserControls();
            search = new SearchBusinessLogic(parentform);
            this.Show();
        }

        internal void Go(Control parentform, System.Drawing.Font font_para)
        {
            UserFont = font_para;
            search = new SearchBusinessLogic(parentform);
            this.Show();
        }
        internal void Go(Control parentform)
        {
            search = new SearchBusinessLogic(parentform);
            this.Show();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            search.SearchString = txtSearchText.Text;
            search.ProcessSearchControl(lslUserCtrl);
            lstResult.Items.Clear();
            foreach(ControlPath s in search.strControls1)
            {
                lstResult.Items.Add(s.strControlName);
            }
        }
        private void LoadUserControls()
        {
            lslUserCtrl.Items.Clear();
            foreach(string strControl in lstUserControl)
            {
                lslUserCtrl.Items.Add(strControl, CheckState.Unchecked);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.SeachItemSelected != null)
                this.SeachItemSelected(this, null);
        }
    }
}
