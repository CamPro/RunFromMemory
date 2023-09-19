using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunFromMemory
{
    public partial class RunFromRAM : Form
    {
        WebClient client = new WebClient();
        
        public RunFromRAM()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void RunFromRAM_Load(object sender, EventArgs e)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/110.0.0.0 Safari/537.36");
        }

        private void buttonLoadDllFromWeb_Click(object sender, EventArgs e)
        {
            string dllurl = "https://github.com/CamPro/RunFromMemory/raw/main/RunFromMemory/DllTest/bin/Release/DllTest.dll";
            MemoryStream ms = new MemoryStream();
            //Access web and read the bytes from the binary file
            ms = new MemoryStream(client.DownloadData(dllurl));
            BinaryReader br = new BinaryReader(ms);
            byte[] bin = br.ReadBytes(Convert.ToInt32(ms.Length));
            ms.Close();
            br.Close();

            // First load the assembly
            Assembly a = Assembly.Load(bin);
            Type class1Typetype = a.GetType("DllTest.UserControl1");
            object class1Instance = Activator.CreateInstance(class1Typetype);
            MethodInfo method = class1Typetype.GetMethod("RunTestDll");
            object[] args = new object[] { "hello", "me" };
            object result = method.Invoke(class1Instance, args);
            MessageBox.Show(result.ToString());
        }

        private void buttonLoadStaticDllFromWeb_Click(object sender, EventArgs e)
        {
            string dllurl = "https://github.com/CamPro/RunFromMemory/raw/main/RunFromMemory/DllTest/bin/Release/DllTest.dll";
            MemoryStream ms = new MemoryStream();
            //Access web and read the bytes from the binary file
            ms = new MemoryStream(client.DownloadData(dllurl));
            BinaryReader br = new BinaryReader(ms);
            byte[] bin = br.ReadBytes(Convert.ToInt32(ms.Length));
            ms.Close();
            br.Close();

            // First load the assembly
            Assembly a = Assembly.Load(bin);
            Type class1Typetype = a.GetType("DllTest.UserControl1");
            object class1Instance = Activator.CreateInstance(class1Typetype);
            MethodInfo method = class1Typetype.GetMethod("RunTestStaticDll");
            object[] args = new object[] { };
            object result = method.Invoke(class1Instance, args);
            MessageBox.Show(result.ToString());
        }

        private void buttonLoadExeFromWeb_Click(object sender, EventArgs e)
        {

        }

        private void buttonLoadDllFromLocal_Click(object sender, EventArgs e)
        {

        }

        private void buttonLoadExeFromLocal_Click(object sender, EventArgs e)
        {

        }

        public static void loadAssembly(byte[] bin)
        {
            // First load the assembly
            Assembly a = Assembly.Load(bin);

            // Get the type that includes the method you want to call by name (must include namespace and class name)
            Type class1Typetype = a.GetType("DllTest.UserControl1");

            // Since your method is not static you must create an instance of that class.
            // The following line will create an instance using the default parameterless constructor.
            // If the class does not have a parameterless constructor, the following line will faile
            object class1Instance = Activator.CreateInstance(class1Typetype);

            // Find the method you want to call by name
            // If there are multiple overloads, use the GetMethod overload that allows specifying parameter types
            MethodInfo method = class1Typetype.GetMethod("RunTestDll");

            // Use method.Invoke to call the method and pass the parameters in an array, cast the result to int
            //var result = (int)method.Invoke(class1Instance, new object[] { null, null });
            object[] args = new object[] { null, null };
            object result = method.Invoke(class1Instance, args);
        }
    }
}
