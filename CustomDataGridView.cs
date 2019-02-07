using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Data_лаба_номер_2
{
     class CustomDataGridView:DataGridView
    {
        private int Row { get; set; }
        private int Column { get; set; }
        private int WidthGrid { get; set; }
        private int LocationX { get; set; }
        private int LocationY { get; set; }
        Random R = new Random();

        public CustomDataGridView(int width,int height,int locX, int locY, int row, int column)
        {
            //Initial properties            
            this.AllowUserToAddRows = false;
            this.AllowUserToResizeRows = false;
            
            this.AllowUserToResizeColumns = false;
            this.BackgroundColor = Color.LightGreen;
            this.GridColor = Color.Black;
            this.BorderStyle = BorderStyle.FixedSingle;
            this.RowHeadersVisible = false;
            this.Height = height;
            this.Width = width;
            this.CellBorderStyle =  DataGridViewCellBorderStyle.SunkenHorizontal;
            
            //Transfer characteristics
            LocationX = locX;
            LocationY = locY;
            Column = column;
            Row = row;
            this.ColumnCount = column;
            this.RowCount = row;
                       
            this.Location = new Point(locX, locY);



            
            
            string[] FirstColumn = new string[] { "ID Продукта", "Наименование продуктов", "КГ", "Количество" };

            for (int i = 0; i < this.ColumnCount; i++)
            {
                this.Columns[i].HeaderCell.Value = FirstColumn[i];
            }
            
           
           

            ///////////////////////////////////////////////////////////////////////////AutoSizeMode
            this.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            this.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
        }
      
    }
}
