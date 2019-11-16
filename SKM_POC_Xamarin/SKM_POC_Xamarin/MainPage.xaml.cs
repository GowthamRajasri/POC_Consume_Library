using SKM_POC_Standard_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SKM_POC_Xamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            lbl.Text = "";
            try
            {
                setLableMgs("Framework Library Call:");
                setLableMgs(SKM_POC_Framework_Library.Program.About());
                SKM_POC_Framework_Library.Program p1 = new SKM_POC_Framework_Library.Program();
                setLableMgs(await p1.MakeHttpCall());
            }
            catch (Exception ex)
            {
                setLableMgs(ex.Message + Environment.NewLine + ex.StackTrace);
            }

            try
            {
                setLableMgs("Standard Library Call:");
                setLableMgs(SKM_POC_Standard_Library.Program.About());
                SKM_POC_Standard_Library.Program p2 = new SKM_POC_Standard_Library.Program();
                setLableMgs(await p2.MakeHttpCall());
            }
            catch (Exception ex)
            {
                setLableMgs(ex.Message + Environment.NewLine + ex.StackTrace);
            }
        }

        void setLableMgs(string mgs)
        {
            lbl.Text += $"{DateTime.Now.ToString()} : {mgs} {Environment.NewLine}" ;
        }
    }
}
