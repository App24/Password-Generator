using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Password_Generator
{
    public partial class PasswordGenerator : Form
    {
        private static Random random = new Random();

        const string fileName = "password.txt";

        public PasswordGenerator()
        {
            InitializeComponent();
        }

        void UpdatePasswordList()
        {
            List<PasswordSettings> passwordSettings = new List<PasswordSettings>();
            if (File.Exists(fileName))
            {
                passwordSettings = JsonConvert.DeserializeObject<List<PasswordSettings>>(File.ReadAllText(fileName));
            }
            DataTable dt=new DataTable();

            dt.Columns.Add(new DataColumn("Name"));
            dt.Columns.Add(new DataColumn("Password"));

            foreach (PasswordSettings passwordSetting in passwordSettings)
            {
                dt.Rows.Add(passwordSetting.Name, passwordSetting.Password);
            }

            lbPasswords.DataSource = dt;
            lbPasswords.DisplayMember = "Name";
        }

        private void PasswordGenerator_Load(object sender, EventArgs e)
        {
            CenterControl(txtLength);
            CenterControl(lblFeatures);
            CenterControl(chkNumbers);
            CenterControl(chkLetters);
            CenterControl(chkSpecial);
            CenterControl(txtPassword);
            CenterControl(btnGenerate);
            CenterControl(txtName);
            CenterControl(btnSave);
            CenterControl(btnGet);

            UpdatePasswordList();
        }

        void CenterControl(Control c)
        {
            c.Left = (ClientSize.Width - c.Width) / 2;
        }

        private void txtLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string text = txtLength.Text;
            if (string.IsNullOrEmpty(text)||text==txtLength.Placeholder)
            {
                text = "1";
            }
            int length = Convert.ToInt32(text);
            string password = RandomString(length, chkLetters.Checked, chkNumbers.Checked, chkSpecial.Checked);
            txtPassword.Text = password;
        }

        public static string RandomString(int length, bool letters, bool numbers, bool special)
        {
            string chars = "";
            if (letters)
            {
                chars += "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            }
            if (numbers)
            {
                chars += "0123456789";
            }
            if (special)
            {
                chars += "~`!@#$%^&*()-_+={}[]|\\/:;\"'<>,.?";
            }
            if (chars.Length == 0) return "";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Need a password to save!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtName.Text)||txtName.Text==txtName.Placeholder)
            {
                MessageBox.Show("Need a name to save!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<PasswordSettings> passwordSettings = new List<PasswordSettings>();
            PasswordSettings passwordSetting =new PasswordSettings(txtName.Text, txtPassword.Text);
            if (File.Exists(fileName))
            {
                passwordSettings = JsonConvert.DeserializeObject<List<PasswordSettings>>(File.ReadAllText(fileName));
            }
            if (passwordSettings.FindIndex(delegate (PasswordSettings ps)
            {
                return ps.Name == passwordSetting.Name;
            }) >= 0)
            {
                MessageBox.Show("Name already Exists", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            passwordSettings.Add(passwordSetting);
            string output = JsonConvert.SerializeObject(passwordSettings, Formatting.Indented);
            File.WriteAllText(fileName, output);
            UpdatePasswordList();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || txtName.Text == txtName.Placeholder)
            {
                MessageBox.Show("Need a name to load!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<PasswordSettings> passwordSettings = new List<PasswordSettings>();
            PasswordSettings passwordSetting = new PasswordSettings(txtName.Text, "");
            if (File.Exists(fileName))
            {
                passwordSettings = JsonConvert.DeserializeObject<List<PasswordSettings>>(File.ReadAllText(fileName));
                int index = passwordSettings.FindIndex(delegate (PasswordSettings ps)
                 {
                     return ps.Name == passwordSetting.Name;
                 });
                if (index < 0)
                {
                    MessageBox.Show("Can't find a password by that name!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                passwordSetting = passwordSettings[index];
                txtPassword.Text = passwordSetting.Password;
            }
        }

        private void lbPasswords_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView test = (DataRowView) lbPasswords.Items[lbPasswords.SelectedIndex];
            string name = test.Row.Field<string>("Name");
            string password = test.Row.Field<string>("Password");
            txtPassword.Text = password;
            txtName.Text = name;
            txtLength.Text = password.Length.ToString();

            /*List<PasswordSettings> passwordSettings = new List<PasswordSettings>();
            PasswordSettings passwordSetting = new PasswordSettings(txtName.Text, "");
            if (File.Exists(fileName))
            {
                passwordSettings = JsonConvert.DeserializeObject<List<PasswordSettings>>(File.ReadAllText(fileName));
                int index = passwordSettings.FindIndex(delegate (PasswordSettings ps)
                {
                    return ps.Name == passwordSetting.Name;
                });
                if (index < 0)
                {
                    MessageBox.Show("Can't find a password by that name!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                passwordSetting = passwordSettings[index];
                txtPassword.Text = passwordSetting.Password;
            }*/
        }
    }

    struct PasswordSettings
    {
        public readonly string Name;
        public readonly string Password;

        [JsonConstructor]
        public PasswordSettings(string name, string password)
        {
            Name = name;
            Password = password;
        }
    }
}
