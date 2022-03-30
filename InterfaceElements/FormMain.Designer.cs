
namespace PerformanceAndQuality
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromATextFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.performanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qualityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.asATextFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBoxEnterGroup = new System.Windows.Forms.TextBox();
            this.labelGroup = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.calculationsToolStripMenuItem,
            this.saveStripMenuItem1,
            this.closeStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(2, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(318, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fromATextFileToolStripMenuItem});
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.loadToolStripMenuItem.Text = "Загрузить ";
            // 
            // fromATextFileToolStripMenuItem
            // 
            this.fromATextFileToolStripMenuItem.Name = "fromATextFileToolStripMenuItem";
            this.fromATextFileToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.fromATextFileToolStripMenuItem.Text = "Из текстового файла";
            this.fromATextFileToolStripMenuItem.Click += new System.EventHandler(this.fromATextFileToolStripMenuItem_Click);
            // 
            // calculationsToolStripMenuItem
            // 
            this.calculationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.performanceToolStripMenuItem,
            this.qualityToolStripMenuItem});
            this.calculationsToolStripMenuItem.Name = "calculationsToolStripMenuItem";
            this.calculationsToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.calculationsToolStripMenuItem.Text = "Вычисления";
            // 
            // performanceToolStripMenuItem
            // 
            this.performanceToolStripMenuItem.Name = "performanceToolStripMenuItem";
            this.performanceToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.performanceToolStripMenuItem.Text = "Успеваемость";
            this.performanceToolStripMenuItem.Click += new System.EventHandler(this.performanceToolStripMenuItem_Click);
            // 
            // qualityToolStripMenuItem
            // 
            this.qualityToolStripMenuItem.Name = "qualityToolStripMenuItem";
            this.qualityToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.qualityToolStripMenuItem.Text = "Качество";
            this.qualityToolStripMenuItem.Click += new System.EventHandler(this.qualityToolStripMenuItem_Click);
            // 
            // saveStripMenuItem1
            // 
            this.saveStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asATextFileToolStripMenuItem});
            this.saveStripMenuItem1.Name = "saveStripMenuItem1";
            this.saveStripMenuItem1.Size = new System.Drawing.Size(78, 20);
            this.saveStripMenuItem1.Text = "Сохранить";
            // 
            // asATextFileToolStripMenuItem
            // 
            this.asATextFileToolStripMenuItem.Name = "asATextFileToolStripMenuItem";
            this.asATextFileToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.asATextFileToolStripMenuItem.Text = "В текстовый файл";
            this.asATextFileToolStripMenuItem.Click += new System.EventHandler(this.asATextFileToolStripMenuItem_Click);
            // 
            // closeStripMenuItem1
            // 
            this.closeStripMenuItem1.Name = "closeStripMenuItem1";
            this.closeStripMenuItem1.Size = new System.Drawing.Size(68, 20);
            this.closeStripMenuItem1.Text = "Закрыть ";
            this.closeStripMenuItem1.Click += new System.EventHandler(this.closeStripMenuItem1_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(2, 55);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(318, 272);
            this.dataGridView.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBoxEnterGroup
            // 
            this.textBoxEnterGroup.Location = new System.Drawing.Point(146, 27);
            this.textBoxEnterGroup.Name = "textBoxEnterGroup";
            this.textBoxEnterGroup.Size = new System.Drawing.Size(131, 23);
            this.textBoxEnterGroup.TabIndex = 4;
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Location = new System.Drawing.Point(12, 30);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(131, 15);
            this.labelGroup.TabIndex = 5;
            this.labelGroup.Text = "Введите шифр группы";
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.FloralWhite;
            this.buttonOK.Location = new System.Drawing.Point(283, 26);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(38, 23);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(322, 332);
            this.ControlBox = false;
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.textBoxEnterGroup);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MaximumSize = new System.Drawing.Size(338, 371);
            this.MinimumSize = new System.Drawing.Size(338, 371);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Качество и успеваемость";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeStripMenuItem1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ToolStripMenuItem saveStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem asATextFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromATextFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem performanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qualityToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.TextBox textBoxEnterGroup;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}