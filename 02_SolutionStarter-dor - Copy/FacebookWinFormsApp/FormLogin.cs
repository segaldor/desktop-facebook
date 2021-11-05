using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FormLogin : Form
    {
		public User m_LoggedInUser;
		public bool login_success = false;
        public FormLogin()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
			loginAndInit();
        }
		private void loginAndInit()
		{
			FacebookWrapper.LoginResult loginResult = FacebookService.Login("615568443218854",
			   "public_profile",
				   "email",
				   "publish_to_groups",
				   "user_birthday",
				   //"user_age_range",
				   "user_gender",
				   //"user_link",
				   //"user_videos",
				   //"publish_to_groups",
				   //"groups_access_member_info",
				   //"user_friends",
				   //"user_events",
				   "user_likes",
				   //"user_location",
				   "user_photos",
				   "user_posts"
				   //"user_hometown"
				   );
			if (!string.IsNullOrEmpty(loginResult.AccessToken))
			{
				m_LoggedInUser = loginResult.LoggedInUser;
				login_success = true;
				this.Dispose();
			}
			else 
			{
				MessageBox.Show(loginResult.ErrorMessage, "Login faild");
			}

				
		}
    }
}
