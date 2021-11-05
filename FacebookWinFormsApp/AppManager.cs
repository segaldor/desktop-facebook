using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class AppManager
    {
        User m_LoggedInUser;
        LoginResult m_LoginResult;
        FormLogin m_FormLogin;
        FormMain m_FormMain;

        
        

        public AppManager() 
        {   
            m_FormLogin = new FormLogin();
            m_FormLogin.ShowDialog();
            if (m_FormLogin.login_success)
            {
                m_LoggedInUser = m_FormLogin.m_LoggedInUser;
                m_FormMain = new FormMain(m_LoggedInUser);
                m_FormMain.ShowDialog();
            }
        }
                
    }
   
}
