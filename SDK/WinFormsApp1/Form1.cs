using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SDK;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<string, ISDK> efektler = new Dictionary<string, ISDK>();
        private void button1_Click(object sender, EventArgs e)
        {
            ISDK efekt = efektler
                [listBox1.SelectedItem.ToString()];
            label1.Text = efekt.Islem(textBox1.Text);
            foreach (string dosya in Directory.GetFiles(@"C:\Users\303ABDULLAH_SABAH\source\repos\SDK\WinFormsApp1\bin\Debug\netcoreapp3.1\Pluggın"))
            {
                //MessageBox.Show(dosya);


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string dosya in Directory.GetFiles(@"C:\Users\303ABDULLAH_SABAH\source\repos\SDK\WinFormsApp1\bin\Debug\netcoreapp3.1\Pluggın"))
            {
                //MessageBox.Show(dosya);
                Assembly assembly = Assembly.LoadFrom(dosya);
                foreach (Type type in assembly.GetTypes())
                {
                    //MessageBox.Show(type.Name);
                    //if (type is ISDK)
                    //{
                    object obj = Activator.CreateInstance(type);
                    ISDK efekt = (ISDK)obj;
                    efektler.Add(efekt.EklentiAdi, efekt);
                    listBox1.Items.Add(efekt.EklentiAdi);
                    //}
                }

            }

        }
    }
}
