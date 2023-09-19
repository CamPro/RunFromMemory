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

            // load assembly
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

            // load assembly
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
            string exeurl = "https://github.com/CamPro/RunFromMemory/raw/main/RunFromMemory/ExeTest/bin/Release/ExeTest.exe";
            MemoryStream ms = new MemoryStream();
            //Access web and read the bytes from the binary file
            ms = new MemoryStream(client.DownloadData(exeurl));
            BinaryReader br = new BinaryReader(ms);
            byte[] bin = br.ReadBytes(Convert.ToInt32(ms.Length));
            ms.Close();
            br.Close();

            Assembly a = Assembly.Load(bin);
            MethodInfo m = a.EntryPoint;
            object o = a.CreateInstance(m.Name);
            m.Invoke(o, null);
        }

        private void buttonLoadDllFromLocal_Click(object sender, EventArgs e)
        {

        }

        private void buttonLoadExeFromLocal_Click(object sender, EventArgs e)
        {
            string exepath = "..\\..\\..\\ExeTest\\bin\\Release\\ExeTest.exe";
            exepath = Path.GetFullPath(exepath);

            Assembly a = Assembly.LoadFile(exepath);

            Type programType = a.GetTypes().FirstOrDefault(c => c.Name == "Program");
            MethodInfo method = programType.GetMethod("Start", BindingFlags.Public | BindingFlags.Static);
            method.Invoke(null, new object[] { });
        }

        private void buttonLoadExeNoFormLocal_Click(object sender, EventArgs e)
        {
            string exepath = "..\\..\\..\\ExeNoFormTest\\bin\\Release\\ExeNoFormTest.exe";
            exepath = Path.GetFullPath(exepath);

            FileStream fs = new FileStream(exepath, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            byte[] bin = br.ReadBytes(Convert.ToInt32(fs.Length));
            fs.Close();
            br.Close();

            Assembly a = Assembly.Load(bin);
            MethodInfo m = a.EntryPoint;
            a.EntryPoint.Invoke(null, new object[] { });
        }
    }
}
