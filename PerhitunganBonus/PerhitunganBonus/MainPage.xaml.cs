using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PerhitunganBonus
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }
    }

    public class MainViewModel:BaseNotify
    {

        private DataModel model;
        public List<FIType> FISource { get; set; } = new List<FIType> { FIType.LTI, FIType.TIFRMoreThen2, FIType.TIFRLestThen2, FIType.NoISIDENT };

        public DataModel Model
        {
            get { return model; }
            set { SetProperty(ref model , value); }
        }


        public MainViewModel()
        {
            model = new DataModel() { FIType= FIType.LTI };
        }
    }
}
