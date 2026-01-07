using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Outlock
{
    public class PasswordForm : Form
    {
        TextBox txt;
        Button btn;

        private PasswordForm()
        {
            Text = "Outlook Locked";
            Width = 300;
            Height = 130;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterScreen;
            TopMost = true;

            txt = new TextBox { Left = 20, Top = 20, Width = 240, PasswordChar = '*' };
            btn = new Button { Text = "Unlock", Left = 100, Top = 55, Width = 80 };

            btn.Click += (s, e) =>
            {
                if (txt.Text == "LastWinter2025") // 🔑 รหัสผ่าน
                    DialogResult = DialogResult.OK;
                else
                    MessageBox.Show("Wrong password");
            };

            Controls.Add(txt);
            Controls.Add(btn);
        }

        public static bool ShowPassword()
        {
            using (var f = new PasswordForm())
            {
                return f.ShowDialog() == DialogResult.OK;
            }
        }
    }
}
