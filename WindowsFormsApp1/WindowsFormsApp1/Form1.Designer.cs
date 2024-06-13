using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Avg = new System.Windows.Forms.DataGridView();
            this.labelStart = new System.Windows.Forms.Label();
            this.V = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Avg)).BeginInit();
            this.SuspendLayout();
            // 
            // Avg
            // 
            this.Avg.AllowUserToAddRows = false;
            this.Avg.AllowUserToResizeColumns = false;
            this.Avg.AllowUserToResizeRows = false;
            this.Avg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Avg.Location = new System.Drawing.Point(12, 12);
            this.Avg.Name = "Avg";
            this.Avg.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.Avg.Size = new System.Drawing.Size(460, 361);
            this.Avg.TabIndex = 0;
            this.Avg.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.Avg_CellValueChanged);
            this.Avg.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Avg_EditingControlShowing);
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStart.Location = new System.Drawing.Point(533, 55);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(261, 23);
            this.labelStart.TabIndex = 1;
            this.labelStart.Text = "Введите количество вершин\r\n";
            // 
            // V
            // 
            this.V.Location = new System.Drawing.Point(616, 90);
            this.V.Name = "V";
            this.V.Size = new System.Drawing.Size(100, 20);
            this.V.TabIndex = 2;
            this.V.TextChanged += new System.EventHandler(this.V_TextChanged);
            this.V.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.V_KeyPress);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(597, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "Инструкция";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(491, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(356, 34);
            this.button2.TabIndex = 4;
            this.button2.Text = "Построить матрицу инцидентности";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(491, 185);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(356, 34);
            this.button3.TabIndex = 5;
            this.button3.Text = "Очистить матрицу смежности";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 385);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.V);
            this.Controls.Add(this.labelStart);
            this.Controls.Add(this.Avg);
            this.Name = "Form1";
            this.Text = "Программа построения матрицы инцидентности по матрице смежности";
            ((System.ComponentModel.ISupportInitialize)(this.Avg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Avg;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.TextBox V;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Button button3;
    }
}

