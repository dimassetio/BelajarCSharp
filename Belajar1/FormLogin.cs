using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Belajar1
{
    public partial class FormLogin : Form
    {
        public SqlConnection cnn;
        bool isRegister = true;

        public FormLogin()
        {
            Connection conn = new Connection();
            cnn = conn.cnn;
            cnn.Open();
            InitializeComponent();
            toggleForm();
        }



        private void btn_login_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (isRegister)
                {
                    
                    add_user(txt_username.Text, txt_password.Text, txt_name.Text, txt_email.Text, txt_address.Text);

                }
                else
                {
                    login(txt_username.Text, txt_password.Text);
                }
            }
            clearForm();
        }

        private void toggleForm() { 
            isRegister = !isRegister;
            label3.Visible = isRegister;
            txt_name.Visible = isRegister;
            label4.Visible = isRegister;
            txt_email.Visible = isRegister;
            label5.Visible = isRegister;
            txt_address.Visible = isRegister;


            if (isRegister)
            {
                toggleButton.Text = "Sign In";
            } else
            {
                toggleButton.Text = "Register Account";
            }
        }

        private void clearForm() {
            txt_username.Clear();
            txt_password.Clear();
            txt_name.Clear();
            txt_email.Clear();
            txt_address.Clear();
        }

        private void add_user(string username, string password, string name, string email, string address)
        {
            string sqlQUery = $"insert into employee values ('{username}','{HashedPassword(password)}','{name}','{email}','{address}','2004-05-23',2)";
            SqlCommand cmd = new SqlCommand(sqlQUery, cnn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Employee Registered Successfully");
        }

        private void login(string username, string password)
        {
            string sqlQuery = $"select * from employee where username = '{username}'";
            SqlCommand cmd = new SqlCommand(sqlQuery, cnn);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (!reader.HasRows)
                {
                    MessageBox.Show("Invalid Username");
                }
                else
                    while (reader.Read())
                    {
                        if(reader["password"].ToString() == HashedPassword(password))
                        {
                            Form targetForm = this;
                            if(reader["jobID"].ToString() == "1")
                            {
                                targetForm = new FormUser();
                            } else if(reader["jobID"].ToString() == "2") {
                                targetForm = new FormFO();
                            }
                            //targetForm.Parent = this;
                            targetForm.Show();
                            this.Hide();
                        }else
                        {
                            MessageBox.Show("Invalid Password");
                        }
                    }
            }
            
            //var result = cmd.ExecuteNonQuery();
            
           // Console.WriteLine(result);
        }

        

        static string HashedPassword(string rawText)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawText));
                StringBuilder sb = new StringBuilder(); 
                for (int i = 0; i< bytes.Length; i++)
                {
                    sb.Append(bytes[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }

        private void toggleButton_Click(object sender, EventArgs e)
        {
            toggleForm();
        }

        private void txt_username_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_username.Text)) { 
                e.Cancel = true;
                txt_username.Focus();

                errorProvider1.SetError(txt_username, "Username must not be empty");
            } else {
                e.Cancel= false;
               // errUsername.SetError(txt_username, "");
            }
        }
    }
}
