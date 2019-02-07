using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Net.Mail;
namespace Data_лаба_номер_2
{
    public partial class Form1 : Form
    {
        CustomDataGridView dataGridView;
        public Form1()
        {
            InitializeComponent();
            dataGridView = new CustomDataGridView(397,544,19,54, 0, 4);
            Controls.Add(dataGridView);
        }
        #region потом крч
        string[,] rows;
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 4;
            dataGridView1.RowCount = 0;


           
            rows = new string[,]{ // 1   2     3     4 
                                           
                                            {"1","Картофель","25","99"},//1
                                             {"2","Молоко","DDD","90"},//2
                                             {"3","Яйца","YYY","30"},//3
                                             {"4","Хлеб","MMM","406"},
                                             {"5","Сахар","TTT","50"},
                                             {"6","Гречка","RRR","60"},
                                             {"7","Чипсы","PPP","11"}//7
                                          };
           
            // rows.GetLength(0) return length of the first D (7)
            // rows.GetLength(1) return length of the second D
            for (int i = 0; i < rows.GetLength(0); i++)// array rows
            {
                string[] row = new string[rows.GetLength(1)];

                for (int j = 0; j < rows.GetLength(1); j++)
                {
                    row[j] = rows[i, j];
                }

                dataGridView.Rows.Add(row);
                dataGridView1.Rows.Add(row);

            }

            /*
             * Читать все содержимое файла. Сделайте замену с String.Replace. Записать содержимое обратно в файл.
             * string text = File.ReadAllText("test.txt");
             * text = text.Replace("some text", "new value");
             * File.WriteAllText("test.txt", text);
             * 
             */


            int[] Column4=new int[7];
            for (int i = 1; i < 7; i++)
            {
                 Column4[i] = int.Parse(rows[i,3]);
            }
            
            //label1.Text = rows[0,1];
            for (int i = 0; i < dataGridView.ColumnCount; i++)
            {
                dataGridView.Rows[3].Cells[i].Style.BackColor = System.Drawing.Color.Red;
            }
           // label2.Text = Column4.Min().ToString();

            // label2.Text = Column4.Max().ToString();

        }

        #endregion

        public void ExitBtn(object sender, EventArgs e) => Application.Exit();
        InputFile input = new InputFile();
        DataTable dtDataGrid=new DataTable();

        private void textBox1_TextChanged(object sender, EventArgs e)
        { //source = new BindingSource();

            //  ((DataView)dataGridView.DataSource).RowFilter = "(A LIKE  '" + textBox1.Text.Trim() + "*')";
            try
            {
               
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                
                }
            // BindingSource dt;
            // dt = (BindingSource)dataGridView.DataSource;
            for (int i = 0; i < dataGridView.ColumnCount; i++)
            {

                if (dataGridView.Columns[0].HeaderText =="")
                dataGridView.Columns[0].HeaderText = " [Наименование] LIKE'" + textBox1.Text + "%'";
            }
        }

       
    }
}
