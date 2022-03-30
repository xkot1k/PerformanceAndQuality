using System;
using System.Windows.Forms;

namespace PerformanceAndQuality
{
    public partial class FormHelp : Form
    {
        public FormHelp()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Рамка вокруг подписи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            labelRef.BorderStyle = BorderStyle.Fixed3D;

        }

        /// <summary>
        /// Открытие основной формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNext_Click_1(object sender, EventArgs e)
        {
            FormMain f1 = new FormMain(); 
            f1.Show();
        }

        /// <summary>
        /// Выход из программы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
