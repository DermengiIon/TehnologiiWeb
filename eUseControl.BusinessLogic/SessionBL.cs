using System;
using System.Collections.Generic;
using System.Text;
using eUseControl.BusinessLogic.Core;
using eUseControl.BusinessLogic.Interfaces;
using eUseControl.Domain.Entities.User;

namespace eUseControl.BusinessLogic
{
    public class SessionBL: UserApi, ISession
    {
        public ULoginResp UserLogin(ULoginData data)
        {
            return new ULoginResp();//UserLoginAction(data)
        }
       
    }
}
