using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyGiver
{
    public partial class mainForm : Form
    {
        // Привязка классов - ОТМЕНЕНО
        // Задумка: Разбить функции и переменные по разным классам.
        // Причина отмены: Постоянная ошибка StackOverflowException
        // START
        // END


        /*****************************************************************************************************************************************************************************************
        * INFO FOR DEVS
        * 
        * WHAT TO DO:
        * Регистрация ключей (Номер кабинета, ФИО преподавателя, Время начала сеанса) - 
        * Сдача ключей (Номер кабинета, Время сдачи (окончания сеанса) - 
        * Перемещение кастомного интерфейса (Верхняя панель (header), Название программы (Название+версия), Кнопка выхода) - DONE
        * 
        * 
        * 
        * 
        * 
        * 
        * BUG's LOGS:
        * Окно программы открывается снизу экрана, при том, что StartPosition указана CenterScreen - НЕ РЕШЕНО
        * 
        * 
        * 
        * 
        * 
        * 
        * 
        * DEV LIST:
        * sSora aka [unknown] - vk.com/soranyashka
        * Boshelf aka Дмитрий Сурков - vk.com/me_boshelf
        * DWAD aka Шадрин Сергей - vk.com/d1s3ct
        * 
        *****************************************************************************************************************************************************************************************/
        public mainForm()
        {
            InitializeComponent();
            WindowEventHandler winHandler = new WindowEventHandler();
            panel1.MouseMove += new MouseEventHandler(winHandler.MouseMove);
            panel1.MouseDown += new MouseEventHandler(winHandler.MouseDown);
            label1.MouseClick += new MouseEventHandler(winHandler.ExitClick);
        }
       

        // Создание переменных, в которых указаны пути до Баз Данных (БД) с расширением ABC
        // Серверные БД
        // START
        const string PREP = "Lecturer.abc";
        const string LOGS = "Logs.abc";
        // END

        // Локальные БД
        // START
        const string KEYS = "Keys.abc";
        const string ROOM = "Rooms.abc";
        // END

        public void SetScreenSize()
        {
            // Установка размеров окна программы
            // START
            Top = 720;
            Left = 460;
            // END
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            // Начало программы и установка параметров
            // START
            // ShowDevs();
            SetScreenSize();
            // END
        }
        
        public void ShowDevs()
        {
            MessageBox.Show("Список разработчиков:\n" +
                "sSora\n" +
                "Boshelf\n" +
                "DWAD");
        }
    }
}
