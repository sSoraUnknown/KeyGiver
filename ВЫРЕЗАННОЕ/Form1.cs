using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KeyGiver
{
    public partial class Form1 : Form
    {

        /*****************************************************************************************************************************************************************************************
        * Регистрация ключей (Номер кабинета, ФИО преподавателя, Время начала сеанса, Время окончания сеанса
        * 
        * 
        * 
        * 
        * 
        * 
        * 
        * 
        * 
        * 
        * 
        * 
        * 
        * 
        * 
        * 
        * 
        * 
        * 
        * 
        * 
        *****************************************************************************************************************************************************************************************/
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }

        // BD
        // START
        // BD_NAME.ABC - расширение
        const string PREP = ".abc";
        const string LOGS = ".abc";
        const string KEYS = ".abc";
        const string ROOMS = ".abc";
        static string cmd="";

        public static void SaveLogs()
        {

            StreamWriter file = new StreamWriter(LOGS, true);

            file.WriteLine(cmd);

        }

        public static void SaveBD()
        {
            // Проверяем существует ли наша база данных
            if (File.Exists())
            {
                // Если есть то мы сохраняем нормальные переменные

                File.Delete();
                StreamWriter file = new StreamWriter(PATH, true);

                file.WriteLine(lvl + " LVL");
                
                file.Close();
            }
            else
            {
                // Если ее нет тогда создаем ее с чистого листа(все по нулям)

                StreamWriter file = new StreamWriter(PATH, true);

                lvl = 1; file.WriteLine(lvl + " LVL");
                
                file.Close();
            }
        }

        /*      file.WriteLine("LVL");
                
        */

        public static void ReadBD()
        {
            // Проверяем существует ли наша база данных
            if (!File.Exists())
            {
                // Если нет то запишем ее
                SaveBD();
            }

            // Теперь читаем ее

            StreamReader file = new StreamReader(PATH, true);

            string a;

            a = file.ReadLine();
            int.TryParse(string.Join("", a.Where(c => char.IsDigit(c))), out lvl); // LVL

            file.Close();
        }

        public static void ResetBD()
        {
            File.Delete(PATH);
            SaveBD();
        }
        // END

        // Эти НИ В КОЕМ СЛУЧАЕ не трогать, они для header'а, а точнее - перемещения игры и её закрытия
        // START
        Point lastPoint;
        private new void MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private new void MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // END
    }
}
