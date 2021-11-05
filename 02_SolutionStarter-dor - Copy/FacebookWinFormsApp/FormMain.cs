using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        User m_LoggedInUser;
        public FormMain(User user)
        {
            m_LoggedInUser = user;
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
            profilePic.Image = user.ImageNormal;
            ProfileName.Text = user.Name;
            time.Text = user.Location + user.TimeZone.ToString();
            fetchPhotos();
        }
        private void fetchPhotos() {
            {
                MessageBox.Show(m_LoggedInUser.Name);
                
                listBoxPics.Items.Clear();
                listBoxPics.DisplayMember = "Name";
                foreach (Album album in m_LoggedInUser.Albums)
                {
                    listBoxPics.Items.Add(album);
                    //album.ReFetch(DynamicWrapper.eLoadOptions.Full);
                }

                if (m_LoggedInUser.PhotosTaggedIn.Count == 0)
                {
                    MessageBox.Show("No Photos to retrieve :(");
                }
            }

        }
        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            
        }

        private void loggedOutFinished()
        {
            m_LoggedInUser = null;
            MessageBox.Show("You are now logged out!");
        }
    }
}
