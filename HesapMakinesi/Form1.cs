using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Hesap hesap = new Hesap();
            MethodInfo[] methods = hesap.GetMethodInfo();

            foreach (var item in methods)
            {
                comboBox1.Items.Add(item);
                comboBox1.DisplayMember = "ıtems.Name";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal sayi1, sayi2;
            try
            {

                sayi1 = Convert.ToDecimal(textBox1.Text);
                sayi2 = Convert.ToDecimal(textBox2.Text);

                Hesap hesap = new Hesap();


                MethodInfo methodInfo = (MethodInfo)comboBox1.SelectedItem;
                decimal sonuc = Convert.ToDecimal(methodInfo.Invoke(hesap,new object[2] { sayi1, sayi2 }));

                label1.Text = sonuc.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
