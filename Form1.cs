using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NETCore.Encrypt;

namespace ProjectTealSealDestruction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            outputTextBox.Clear();
            if (typeCombo.Text == "SHA256")
            {
                var encryptprocess = EncryptProvider.Sha256(inputTextBox.ToString());
                outputTextBox.Text = encryptprocess;
                outputTextBox.Update();
            }
            if (typeCombo.Text == "DES")
            {
                string makekey = EncryptProvider.CreateDesKey();
                var encryptprocess = EncryptProvider.DESEncrypt(inputTextBox.ToString(), makekey);
                keyTextBox.Text = makekey.ToString();
                outputTextBox.Text = encryptprocess;
                outputTextBox.Update();
                keyTextBox.Update();
            }
            
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            outputTextBox.Clear();
            if (typeCombo.Text == "SHA256")
            {
                outputTextBox.Text = "That's fucking impossible you cuntface";
                outputTextBox.Update();
            }
            if (typeCombo.Text == "DES")
            {
                string makekey = keyTextBox.Text;
                var encryptprocess = EncryptProvider.DESDecrypt(inputTextBox.ToString(), makekey);
                outputTextBox.Text = encryptprocess;
                outputTextBox.Update();
            }
        }


        //endcode/QOL code
        ///drag options for form since border was removed
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
