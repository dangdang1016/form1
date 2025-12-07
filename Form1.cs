using System.IO;
using ClassLibrary1;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = CustomMessageBox.Show(
                "這是從 ClassLibrary1 彈出的自訂訊息！",
                "自訂訊息標題"
            );

            if (result == DialogResult.OK)
            {
                MessageBox.Show("您點擊了 OK 按鈕！");
            }
        }
    }
}
