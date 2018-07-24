

namespace lands.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Xamarin.Forms;

    public class MainViewModel 
	{
        #region ViewModels

        public LoginViewModel Login { get; set; }

        public LandsViewModel Lands { get; set; }

        #endregion

        #region Constructors
        public MainViewModel ()
		{
            instance = this;
            this.Login = new LoginViewModel();
		}
        #endregion

        #region Singletons

        private static MainViewModel instance;

        public static MainViewModel getInstance()
        {
            if (instance==null)
            {
                return new MainViewModel();

            }
            return instance;
        }
        #endregion
    }


}