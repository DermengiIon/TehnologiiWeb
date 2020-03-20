using System;
using System.Collections.Generic;
using System.Text;
using eUseControl.BusinessLogic.Interfaces;

namespace eUseControl.BusinessLogic
{
    public class MyBusinessLogic
    {
        public ISession getSessionBL()
        {
            return new SessionBL();
        }
    }
}
