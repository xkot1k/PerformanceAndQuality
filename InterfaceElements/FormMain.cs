using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace PerformanceAndQuality
{
    /// <summary>
    /// подготовительные данные
    /// </summary>
    public partial class FormMain : Form
    {       
        public struct Students
        {
            public string name;
            public double mark;

            public Students(string _name, double _mark)
            {
                name = _name;
                mark = _mark;
            }
        }

        List<Students> students = new List<Students>();

        public double Performance = 0;
        public double Quality = 0;
        public string name;
        public string name2;
        public string nameOfGroup;

        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Вывод даннх при загрузке формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Загрузите файл со списком группы " +
                "(только в .txt формате) В документе через пробел необходимо " +
                "написать имя, фамилию и оценку студента, после заполнения " +
                "данных одного студента перейти на следующую строку. " +
                "Пример заполнения документа можно посмотреть " +
                "в документации программы.", 
                "Справка", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            dataGridView.AllowUserToAddRows = false;
        }

        /// <summary>
        /// Загрузка списка студентов из текстового файла и заполнение им таблицы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fromATextFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // чтение из текстового файла
            try
            {
                using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
                {

                    openFileDialog1.Filter = "txt files (*.txt)|*.txt";
                    
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        name = openFileDialog1.FileName;
                        using (StreamReader sr = new StreamReader(name, System.Text.Encoding.UTF8))
                        {
                            while ((!sr.EndOfStream))
                            {
                                string[] words = sr.ReadLine().Split(' ');
                                if (words.Length != 3)
                                {
                                    throw new OperationCanceledException("Нарушение структуры исходного файла");
                                }
                                students.Add(new Students(words[0] + " " + words[1], double.Parse(words[2])));
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка");
            }

            // создание таблицы из исходного файла
            DataTable table = new DataTable();
            table.Columns.Add("Студент", typeof(string));
            table.Columns.Add("Оценка", typeof(double));

            for (int i = 0; i < students.Count; i++)
            {
                table.Rows.Add(students[i].name, students[i].mark);
            }

            // заполнение таблицы на форме
            dataGridView.DataSource = table;
            dataGridView.Columns[0].Width = 148;
            dataGridView.Columns[1].Width = 110;
            dataGridView.ReadOnly = true;
        }

        /// <summary>
        /// Расчет успеваемости студентов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void performanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // создание счетчиков количества оценок
            double count5 = 0;
            double count4 = 0;
            double count3 = 0;

            // подсчет оценок
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                if (Convert.ToDouble(dataGridView[1, i].Value) == 5)
                {
                    count5++;
                }
                if (Convert.ToDouble(dataGridView[1, i].Value) == 4)
                {
                    count4++;
                }
                if (Convert.ToDouble(dataGridView[1, i].Value) == 3)
                {
                    count3++;
                }
            }

            // вывод результата на экран
            Performance = (count3 + count4 + count5) / dataGridView.RowCount;
            MessageBox.Show($"Успеваемость студентов = {Performance * 100}%", 
                "Успеваемость", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Расчет качества обучения студентов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void qualityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // создание счетчиков количества оценок
            double count5 = 0;
            double count4 = 0;

            // подсчет оценок
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                if (Convert.ToDouble(dataGridView[1, i].Value) == 5)
                {
                    count5++;
                }
                if (Convert.ToDouble(dataGridView[1, i].Value) == 4)
                {
                    count4++;
                }
            }

            // вывод результата на экран 
            Quality = (count5 + count4) / dataGridView.RowCount;
            MessageBox.Show($"Качество обучения студентов = {Quality * 100}%", 
                "Качество обучения", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Закрытие текущей формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Cохранение результатов работы в текстовый файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void asATextFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // запись в файл
            using (SaveFileDialog openFileDialog1 = new SaveFileDialog())
            {
                saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
                saveFileDialog1.FileName = "Качество и успеваемость группы " + nameOfGroup;
                
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    name2 = saveFileDialog1.FileName;
                    Stream file = saveFileDialog1.OpenFile();
                    StreamWriter sw = new StreamWriter(file);

                    sw.WriteLine("Оценки студентов группы " + nameOfGroup + "\n");
                    for (int i = 0; i < students.Count; i++)
                    {
                        sw.WriteLine(i + 1 + "." + students[i].name + " - " + students[i].mark);
                    }
                    Console.WriteLine();
                    sw.WriteLine($"\nКачество обучения студентов: {Quality * 100}%");
                    sw.WriteLine($"Успеваемость студентов: {Performance * 100}%");
                    sw.Close();
                    file.Close();

                }
            }
        }

        /// <summary>
        ///  получение шифра группы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOK_Click(object sender, EventArgs e)
        {
            nameOfGroup = textBoxEnterGroup.Text;
        }
    }
}
