using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql;
using MySql.Data.MySqlClient;


namespace ws
{
    public partial class FormRunner : Form
    {
        //Класс с строкой подключения базы данных
        MySqlConnection cn = new MySqlConnection("server=127.0.0.1;user id=root;password=1234;port=3310;persistsecurityinfo=True;database=ws;");
        public FormRunner()
        {
            InitializeComponent();
        }

        //Загрузка данных на форму
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "wsDataSet.runner". При необходимости она может быть перемещена или удалена.
            this.runnerTableAdapter.Fill(this.wsDataSet.runner);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "wsDataSet.runner". При необходимости она может быть перемещена или удалена.
            this.runnerTableAdapter.Fill(this.wsDataSet.runner);

        }


        //Кнопка для перехода на форму регистрации бегунов
        private void buttonIzmenenieDannych_Click(object sender, EventArgs e)
        {
            //Класс для объявления имени формы "бегуны"
            FormRegisterRunner f3 = new FormRegisterRunner();
            Hide();
            f3.Show();
        }

        //Кнопка поиска по таблице бегуны
        private void buttonPoisk_Click(object sender, EventArgs e)
        {
            //Объявление которое представляет таблицу бегунов в памяти
            DataTable dt = new DataTable();
            if (textBoxPoisk.Text.Length > 0)
            {
                //Класс для заполнения набора данных и обновления таблицы бегуны
                MySqlDataAdapter mysda = new MySqlDataAdapter("SELECT * FROM runner WHERE Email LIKE '" + textBoxPoisk.Text + "%'", cn);
                mysda.Fill(dt);
            }
            dataGridViewRunner.DataSource = dt;
        }

        //Кнопка обновления dataGridViewRunner
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            dataGridViewRunner.Refresh();
        }
    }
}
