﻿using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciTopluluklari
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void buttonKayıt_Click(object sender, EventArgs e)
        {
            User u = new User();
            u.KullanıcıAdı = kAdi.Text;
            u.Şifre = Sifre.Text;
           

            IFirebaseConfig config = new FirebaseConfig()
            {
                AuthSecret = "Um2q5EJk0TzKlL8BJIEI8XfHrylv0Nx5JpewBOiN",
                BasePath = "https://ogrenci-topluluklari.firebaseio.com/USERS"
            };
            IFirebaseClient client = new FirebaseClient(config);

            var set = client.Set(@"/" + kAdi.Text, u);

            Login lgn = new Login();
            lgn.Show();
            this.Close();
        }

        private void buttonGeri_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Close();
        }

        private void kAdi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
