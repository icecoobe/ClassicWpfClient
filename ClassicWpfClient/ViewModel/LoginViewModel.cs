using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClassicWpfClient.Common;

namespace ClassicWpfClient.ViewModel
{
    public class LoginViewModel
    {
        public CommandBase CloseWindowCommand { get; set; }

        public LoginViewModel()
        {
            CloseWindowCommand = new CommandBase();
        }
    }
}
