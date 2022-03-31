using System;
using System.Collections.Generic;
using System.Text;

namespace Practise2.Models
{
    interface IAcoount
    {
        public bool PasswordChecker(string password);
        public void ShowInfo();
    }
}
