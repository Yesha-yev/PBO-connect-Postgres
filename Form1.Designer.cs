namespace PBO_connect_Postgres
{
    partial class Dekstop
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gridToDo = new DataGridView();
            BoxToDo = new TextBox();
            Simpan = new Button();
            ((System.ComponentModel.ISupportInitialize)gridToDo).BeginInit();
            SuspendLayout();
            // 
            // gridToDo
            // 
            gridToDo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridToDo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridToDo.Location = new Point(12, 12);
            gridToDo.Name = "gridToDo";
            gridToDo.RowTemplate.Resizable = DataGridViewTriState.True;
            gridToDo.Size = new Size(480, 215);
            gridToDo.TabIndex = 0;
            // 
            // BoxToDo
            // 
            BoxToDo.Location = new Point(12, 245);
            BoxToDo.Multiline = true;
            BoxToDo.Name = "BoxToDo";
            BoxToDo.Size = new Size(480, 23);
            BoxToDo.TabIndex = 1;
            BoxToDo.TextChanged += BoxToDo_TextChanged;
            // 
            // Simpan
            // 
            Simpan.BackColor = Color.FromArgb(64, 0, 0);
            Simpan.ForeColor = SystemColors.HighlightText;
            Simpan.Location = new Point(12, 288);
            Simpan.Name = "Simpan";
            Simpan.Size = new Size(75, 23);
            Simpan.TabIndex = 2;
            Simpan.Text = "SIMPAN";
            Simpan.UseVisualStyleBackColor = false;
            Simpan.Click += Simpan_Click;
            // 
            // Dekstop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 450);
            Controls.Add(Simpan);
            Controls.Add(BoxToDo);
            Controls.Add(gridToDo);
            Name = "Dekstop";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)gridToDo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridToDo;
        private TextBox BoxToDo;
        private Button Simpan;
    }
}
