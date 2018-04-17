using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ws
{
    public partial class FormRegisterRunner : Form
    {
        //Строка подключения к базе данных
        MySqlConnection cn = new MySqlConnection("server=127.0.0.1;user id=root;password=1234;port=3310;persistsecurityinfo=True;database=ws;");
        public FormRegisterRunner()
        {
            InitializeComponent();
        }

        //Кнопка "регистрация", производит регистрацию бегуна в базу данных
        private void bt_reg_Click(object sender, EventArgs e)
        {
            cn.Open();
            string role = "R";

            //запрос на добавление в таблицу user столбцов Email, password, firstname, lastname, roleid
            MySqlCommand cmd = new MySqlCommand("insert into user (Email, Password, FirstName, LastName, RoleId) values ('" + this.tb_mail.Text + "','" + this.tb_pass.Text + "','" + this.tb_name.Text + "','" + this.tb_lname.Text + "','" + role + "')", cn);

            try
            {
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                //Класс открывает диалоговое окно в форме регистрации бегуна
                MessageBox.Show("Успешно");
            }
            catch
            {
                //Класс открывает диалоговое окно в форме регистрации бегуна
                MessageBox.Show("Ошибка в одном из полей");
            }
            cn.Close();
            //класс объявляет форму бегуна
            FormRunner f2 = new FormRunner();
            Hide();
            f2.Show();
        }

        //Загурзка формы
        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "wsDataSet.country". При необходимости она может быть перемещена или удалена.
            this.countryTableAdapter.Fill(this.wsDataSet.country);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "wsDataSet.gender". При необходимости она может быть перемещена или удалена.
            this.genderTableAdapter.Fill(this.wsDataSet.gender);

        }

        //Кнопка отмены и возвращения на форму авторизации
        private void buttonCancle_Click(object sender, EventArgs e)
        {
            //Класс, который объявляет форму авторизации
            FormAuthorisation f1 = new FormAuthorisation();
            Hide();
            f1.Show();
        }
    }
}
