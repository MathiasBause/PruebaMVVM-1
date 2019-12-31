using System;
using System.Collections.Generic;
using System.Text;

namespace App.ViewModels
{
    using Models; 
    using System;
    using System.Collections.ObjectModel;
    public class MainViewModel
    {
        #region Properties
        public string Token { get; set; }
        public string TokenType { get; set; }
        public List<Book> ListBook { get; set; }
        #endregion

        #region VievModels
        public LoginViewModel Login { get; set; }
        public BookViewModel bookViewModel { get; set; }
        #endregion

        #region Constructors
        public MainViewModel()
        {
            instance = this;
            this.Login = new LoginViewModel();
            this.bookViewModel = new BookViewModel();
        }
        #endregion

        #region Singleton
        private static MainViewModel instance;
        public static MainViewModel GetInstance() 
        { 
            if (instance == null) 
            {
                return new MainViewModel();
            }
            return instance;
        }
        #endregion
    }
}
