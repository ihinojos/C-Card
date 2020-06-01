using C_Card.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Card
{
    class Controller
    {
        private static Controller controller;
        public LogIn logIn { get; set; }
        public MainView mainView { get; set; }
        public NewTransaction transactionView { get; set; }
        public EditTransaction editTransaction { get; set; }

        public Controller()
        {
            controller = this;
        }

        public static Controller GetInstance()
        {
            return controller ?? new Controller();
        }

    }
}
