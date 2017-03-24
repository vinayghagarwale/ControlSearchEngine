using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ControlSearchEngine
{
    internal class SearchBusinessLogic
    {
        #region Variable
        Control CtrlSearch;
        private List<ControlPath> strControls;
        List<TabConrl> strHandleTabControlsFrom1;

        CheckedListBox lstUserControl;

        #endregion Variable

        #region Properties
        public List<ControlPath> strControls1 
        { 
            get 
            { 
                return strControls;
            } 
        }
        
        String strErrormsg = "Search Error";

        public string SearchString { set; get; }

        #endregion Properties


        public SearchBusinessLogic(Control CtrlSearch1)
        {
            CtrlSearch = new Control();
            strControls = new List<ControlPath>();
            strHandleTabControlsFrom1 = new List<TabConrl>();
            CtrlSearch = CtrlSearch1;
        }

        #region publicMethods

        public void ProcessSearchControl(CheckedListBox lstUserControlPara = null)
        {
            try
            {
                lstUserControl = lstUserControlPara;

                foreach (Control CtrlChild in CtrlSearch.Controls)
                {
                    if (CtrlChild.HasChildren == false)
                    {
                        NoChildControl(CtrlChild);
                    }
                    else
                    {
                        if (CtrlChild.GetType().ToString() == "System.Windows.Forms.TabControl")
                        {
                            for (int iTab = 0; iTab <= CtrlChild.Controls.Count - 1; iTab++)
                            {
                                HandleTabControls(CtrlChild.Controls[iTab]);
                            }
                        }
                        else
                        {
                            HasChildControls(CtrlChild);
                        }
                    }
                }

            }
            catch (Exception e)
            {
                //MsgBox(strErrormsg, MsgBoxStyle.Exclamation)
            }
        }

        #endregion publicMethods

        #region PrivateMethods

        private void LoadUserDefinedControls()
        {



        }

        private void HandleTabControls(Control ctrl, int iTabIP = 0)
        {
            try
            {
                if (ctrl.GetType().ToString() == "System.Windows.Forms.TabPage")
                {
                    ctrl.Tag = iTabIP;
                    foreach (Control CtrlChild in ctrl.Controls)
                    {
                        if (CtrlChild.HasChildren == false)
                        {
                            NoChildControl(CtrlChild);
                        }
                        else
                        {
                            if (CtrlChild.GetType().ToString() == "System.Windows.Forms.TabControl")
                            {
                                for (int iTab = 0; iTab <= CtrlChild.Controls.Count - 1; iTab++)
                                {
                                    HandleTabControls(CtrlChild.Controls[iTab]);
                                }
                            }
                            else
                            {
                                HasChildControls(CtrlChild);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                //MsgBox(strErrormsg, MsgBoxStyle.Exclamation)
            }
        }

        private void HasChildControls(Control ctrl)
       {
           try
           {
               foreach(Control CtrlChild in ctrl.Controls)
               {
                   if (CtrlChild.HasChildren == false)
                       NoChildControl(CtrlChild);
                   else
                   {
                       if (CtrlChild.GetType().ToString() == "System.Windows.Forms.TabControl")
                       {
                           for (int iTab = 0; iTab <= CtrlChild.Controls.Count - 1; iTab++)
                           {
                               HandleTabControls(CtrlChild.Controls[iTab]);
                           }
                       }
                       else
                       {
                           HasChildControls(CtrlChild);
                       }
                   }
               }
           }
           catch(Exception e)
           {
               //MsgBox(strErrormsg, MsgBoxStyle.Exclamation)
           }
       }

        private void NoChildControl(Control ctrl)
        {
            String strCtrlValuse;
            try
            {
                strCtrlValuse = ctrl.Text.ToUpper();


                if (SearchString.Length <= 0 || SearchString == null) return;

                if (strCtrlValuse.Contains(SearchString.ToUpper()) || SearchString == "*")
                {
                    if (ctrl.GetType().ToString() == "System.Windows.Forms.CheckBox")
                    {
                        AddControlPathList(ctrl);
                    }
                    else if (ctrl.GetType().ToString() == "System.Windows.Forms.Label")
                    {
                        AddControlPathList(ctrl);
                    }
                    else if (ctrl.GetType().ToString() == "System.Windows.Forms.RadioButton")
                    {
                        AddControlPathList(ctrl);
                    }
                    else
                    {
                        SearchinUserDefinedcontrol(ctrl);
                    }
                    SearchinUserDefinedcontrol(ctrl);
                }
            }
            catch (Exception e)
            {
                //MsgBox(strErrormsg, MsgBoxStyle.Exclamation)
            }
        }


        private void SearchinUserDefinedcontrol(Control Ctrl)
        {
            //foreach (Control strcontrol in lstUserControl)
            //{
            //    if (Ctrl.GetType().ToString() == strcontrol.Text)
            //    {
            //        AddControlPathList(Ctrl);
            //    }
            //}
            foreach (object a in lstUserControl.CheckedItems)
            {
                if (Ctrl.GetType().ToString() == a)
                {
                    AddControlPathList(Ctrl);
                }


            }
        }


        private void AddControlPathList(Control ctrl)
        {
           ControlPath objControlPath = new ControlPath();
           List<TabConrl> strHandleTabControlsFrom2 = new List<TabConrl>();
           try
           {
               //if( ctrl.Visible == false) return;

               objControlPath.strControlName = ctrl.Text;
               objControlPath.strControl = ctrl;
               //GetTabPath(ctrl);
               foreach(TabConrl tabctrl  in strHandleTabControlsFrom1)
               {
                   strHandleTabControlsFrom2.Add(tabctrl);
               }
               objControlPath.listControlParents = strHandleTabControlsFrom2;
               strControls.Add(objControlPath);
               strHandleTabControlsFrom1.Clear();
           }
           catch(Exception e)
           {
               //MsgBox(strErrormsg, MsgBoxStyle.Exclamation)
           }
       }

        private bool GetTabPath(Control ctrl, int intTabin = 0)
        {
            try
            {
                do 
                {
                    if (ctrl == null)
                    {
                        return false;
                    }

                    if (ctrl.GetType().ToString() != CtrlSearch.GetType().ToString())
                    {
                        if (ctrl.GetType().ToString() == "NGEPMCTabControl")
                        {
                            TabConrl tabb;
                            tabb.strTabControl = ctrl;
                            tabb.strTabIndex = intTabin;
                            strHandleTabControlsFrom1.Add(tabb);
                        }
                        if (ctrl.GetType().ToString() == "System.Windows.Forms.TabPage")
                        {
                            int intindex;
                            intindex = Convert.ToInt16(ctrl.Tag);

                            if (GetTabPath(ctrl.Parent, intindex) == false)
                            {
                                return false;
                            }
                            else
                            {
                                if (GetTabPath(ctrl.Parent) == false)
                                {
                                    return false;

                                }
                            }
                        }
                    }
                    else
                    {
                        return false;
                    }
                } while (true);
            }
            catch (Exception e)
            {
                //MsgBox(strErrormsg, MsgBoxStyle.Exclamation)
                return false;
            }
        }

        #endregion PrivateMethods

    }
}
               
    struct ControlPath
    {
        public Object strControlName;
        public Object strControl;
        public List<TabConrl> listControlParents;
    }
    struct TabConrl
    {
        public Object strTabControl;
        public int strTabIndex;
    }

