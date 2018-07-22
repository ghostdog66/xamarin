

namespace lands.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Xamarin.Forms;
    using ViewModels;

    public class InstanceLocator : ContentPage
    {
        #region Properties
        
        public MainViewModel Main { get; set; }


        #endregion




        #region Constructors

        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }




        #endregion

    }
}
