using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DllTest
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        /*
         PUBLIC METHOD
         */
        public string RunTestDll(string a, string b)
        {
            MessageBox.Show("Dll start OK");
            return $"OK {a},{b}";
        }

        public static string RunTestStaticDll()
        {
            MessageBox.Show("Static Dll start OK");
            return "OK 2";
        }
    }
}
