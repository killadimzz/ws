using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ws
{
    public partial class FormAuthorisation : Form
    {
        //Строка подколючения к базе данных
        MySqlConnection cn = new MySqlConnection("server=127.0.0.1;user id=root;password=1234;port=3310;persistsecurityinfo=True;database=ws;");
        public FormAuthorisation()
        {
            InitializeComponent();
        }

        //Кнопка отмены ввода данных для входа
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
        }

        //Кнопка для входа
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //запрос на выбор из таблицы user столбцов Email и password
            MySqlCommand cmd = new MySqlCommand("select * from user where Email = '" + textBox1.Text + "' and Password = '" + textBox2.Text + "'");
            cn.Open();
            cmd.Connection = cn;
            MySqlDataReader read = cmd.ExecuteReader();
            read.Read();
            try
            {
                //Сравнения textbox с полями таблицы
                if (read[0].ToString() == textBox1.Text && read[1].ToString() == textBox2.Text)
                {
                    //Открытие диалогового окна при введение правильных данных
                    MessageBox.Show("Вход выполнен");
                    switch (read[4].ToString())
                    {
                        //Открытие форм в соответсвии с из ролями
                        case "R":
                            FormRunner poisk = new FormRunner();
                            Hide();
                            poisk.Show();
                            break;
                    }
                }
            }
            catch
            {
                //Открытие диалогового окна при введение неправильных данных
                MessageBox.Show("Вход не выполнен, повторите попытку");
            }
            cn.Close();
        }
    }
}
