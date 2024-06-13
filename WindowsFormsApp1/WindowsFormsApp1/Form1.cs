using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void button2_Click(object sender, EventArgs e) //Matrix maker
        {
            int arcs = 0;
            int[,] avgMatrix;
            if (V.Text != ""){
                int max = int.Parse(V.Text);
                avgMatrix = new int[max+1, max+1];
                for (int i = 0; i < max; i++){
                    for (int j = 0; j < max; j++){
                        if (string.IsNullOrEmpty(Avg[j, i].Value as string)){
                            Avg[j, i].Value = 0;
                        }
                    }
                }
                    for (int i = 0; i < max; i++){
                        for (int j = 0; j < max; j++){
                            avgMatrix[i, j] = Convert.ToInt32(Avg.Rows[i].Cells[j].Value);
                        }
                    }
                    int variable = 0;
                    Form2 form2 = new Form2();

                    for (int i = 0; i < max; i++){
                        for (int j = 0; j < max; j++){
                            variable = Convert.ToInt32(Avg.Rows[i].Cells[j].Value);
                            arcs += variable;
                        }
                    }
                try
                {
                    int[,] incMatrix = new int[arcs+5, max+5];
                    form2.Matrix.RowCount = arcs;
                    form2.Matrix.ColumnCount = max;
                    foreach (DataGridViewColumn column in form2.Matrix.Columns)
                        column.Width = 20;
                    foreach (DataGridViewColumn column in form2.Matrix.Columns)
                        column.SortMode = DataGridViewColumnSortMode.NotSortable;

                    int edgeIndexCol = 0;
                        int edgeIndexRow = 0;
                        int j_temp = 0;
                        for(int i=0; i<max; i++){
                            for(int j=0; j<max; j++){
                            edgeIndexCol = j;
                                if (avgMatrix[i,j] == 1){
                                    if (i == j){
                                    incMatrix[edgeIndexRow,edgeIndexCol] = 2;
                                    edgeIndexRow++;
                                    }
                                    else{
                                    incMatrix[edgeIndexRow, i] = -1;
                                    incMatrix[edgeIndexRow, j] = 1;
                                    edgeIndexRow++;
                                    }
                                }
                                else if (avgMatrix[i,j] >= 2){
                                    if (i == j){
                                    int count = 0;
                                    for (int k=0; k < avgMatrix[i,j]; k++){
                                        incMatrix[edgeIndexRow+k, edgeIndexCol] = 2;
                                        count++;
                                        }
                                    edgeIndexRow += count;
                                    }
                                    else{
                                    int count = 0;
                                    for(int k =0; k < avgMatrix[i,j]; k++){
                                        incMatrix[edgeIndexRow + k, i] = -1;
                                        incMatrix[edgeIndexRow + k, j] = 1;
                                        count++;
                                        }
                                    edgeIndexRow += count;
                                    }
                                }
                            }
                        }
                    foreach (DataGridViewRow row in form2.Matrix.Rows)
                    {
                        row.HeaderCell.Value = (row.Index + 1).ToString();
                    }
                    foreach (DataGridViewColumn column in form2.Matrix.Columns)
                    {
                        column.HeaderCell.Value = (column.Index + 1).ToString();
                        column.Width = 25;
                        column.SortMode = DataGridViewColumnSortMode.NotSortable;
                    }

                    for (int i = 0; i < arcs; i++){
                            for (int j = 0; j < max; j++){
                                form2.Matrix[j, i].Value = incMatrix[i, j];
                            }
                        }
                        form2.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Возникла ошибка на этапе построения матрицы инидентности. Пожалуйста, проверьте введёную матрицу смежности на корректность.", "ОШИБКА!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else MessageBox.Show("Количество вершин не должно быть пустым!", "ОШИБКА!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button1_Click(object sender, EventArgs e) //Instruction
        {
            MessageBox.Show("В текстовое поле написать число вершин (допустимы только целые числовые значения от 0 до 15 включительно). " +
                "В получившуюся матрицу вписать элементы (элемент матрицы должен быть целым числом не превышающим 9), " +
                "нажать кнопку 'построить матрицу инцидентности'", "Инструкция", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void V_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

                if (!Char.IsDigit(number) && number != 8){
                    if (number == 188 || number == 190) MessageBox.Show("Допустимы только целые цифры без плавающей точки (1.. 2.. 3.. и т.д", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Handled = true;
                }
        }

        private void V_TextChanged(object sender, EventArgs e)
        {
            if (V.Text != ""){
                int nV = int.Parse(V.Text);
                if (nV > 15) {MessageBox.Show("Значение вершин не должно превышать 15", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error); V.Text = "";}
                else{
                    Avg.ColumnCount = nV;
                    Avg.RowCount = nV;
                    foreach (DataGridViewRow row in Avg.Rows)
                        row.HeaderCell.Value = (row.Index + 1).ToString();
                    foreach (DataGridViewColumn column in Avg.Columns){
                        column.HeaderCell.Value = (column.Index + 1).ToString();
                        column.Width = 25;
                        column.SortMode = DataGridViewColumnSortMode.NotSortable;
                    }
                }
            }
        }

        void tb_KeyPressed(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != 8){
                e.Handled = true;
            }

            if (((TextBox)sender).Text.Length >= 1 && !char.IsControl(e.KeyChar)){
                e.Handled = true; 
            }


        }

        private void Avg_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e) 
        {
            if (e.Control is TextBox tb){
                tb.KeyPress -= tb_KeyPressed;
                tb.KeyPress += tb_KeyPressed;
            }
        }

        private void Avg_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (V.Text != ""){
                for (int i = 0; i < Convert.ToInt32(V.Text); i++){
                    for (int j = 0; j < Convert.ToInt32(V.Text); j++){
                        Avg.Rows[j].Cells[i].Value = "";
                    }
                }
            }
        }
    }
}
