using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ControlSearchEngine
{
    public interface ISearchControl
    {
        //Properties
        Boolean HideStandardControls { set; get; }
        Boolean HideUserControls { set; get; }
        Boolean HideLabel { set; get; }
        Boolean HideRadioButton { set; get; }
        Boolean HideCheckBox { set; get; }
        string SearchFormText { set; get; }

        //Public Methods
        void Find(Control ParentForm);
        void Find(Control ParentForm, System.Drawing.Font font_Para);


    }
    public class SearchControl : ISearchControl
    {
      
        List<string> lstUserControls;
        System.Drawing.Font font;// = new System.Drawing.Font();
        SearchResultForm ctrlSearchform = new SearchResultForm();

        public Boolean HideStandardControls { set; get; }
        public Boolean HideUserControls { set; get; }
        public Boolean HideLabel { set; get; }
        public Boolean HideRadioButton { set; get; }
        public Boolean HideCheckBox { set; get; }
        public string SearchFormText { set; get; }

        public SearchControl()
        {

        }
        public SearchControl(List<string> lstUserControl_Para):this()
        {
            lstUserControls = lstUserControl_Para;
        } 

        public  List<string> UserControls 
        { 
            set 
            { 
                lstUserControls =  value;
            } 
        }

       public void Find(Control ParentForm)
       {
            setControlFormProperty();
            ctrlSearchform.Go(ParentForm, lstUserControls, font);
       }

       private void RefreshConfig()
       {
           ctrlSearchform.HideStandardControls = true;
           ctrlSearchform.HideUserControls = true;
           ctrlSearchform.HideLabel = true;
           ctrlSearchform.HideRadioButton = true;
           ctrlSearchform.HideCheckBox = true;
       }

       private void setControlFormProperty()
       {
            RefreshConfig();

            ctrlSearchform.SearchFormText = SearchFormText;
            ctrlSearchform.HideStandardControls = HideStandardControls;
            ctrlSearchform.HideUserControls = HideUserControls;
            ctrlSearchform.HideLabel = HideLabel;
            ctrlSearchform.HideRadioButton = HideRadioButton;
            ctrlSearchform.HideCheckBox = HideCheckBox;
       }
       public void Find(Control ParentForm, System.Drawing.Font font_Para)
       {
           setControlFormProperty();
           ctrlSearchform.Go(ParentForm, lstUserControls, font_Para);
       }
    }
}
