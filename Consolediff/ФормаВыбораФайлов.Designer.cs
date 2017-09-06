namespace Consolediff
{
    partial class ФормаВыбораФайлов
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ИмяФайла1 = new System.Windows.Forms.TextBox();
            this.ИмяФайла2 = new System.Windows.Forms.TextBox();
            this.КнопкаНачатьСравнение = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.СписокИзменений = new System.Windows.Forms.ListView();
            this.ОбъектКонфигурации1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ОбъектКонфигурации2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Разница = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ДеревоИзменений = new System.Windows.Forms.TreeView();
            this.Прогресс = new System.Windows.Forms.ProgressBar();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ДеревоИзменений2 = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Отчет о сравнении конфигураций 1 .txt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Отчет о сравнении конфигураций 1 .txt";
            // 
            // ИмяФайла1
            // 
            this.ИмяФайла1.Location = new System.Drawing.Point(212, 7);
            this.ИмяФайла1.Name = "ИмяФайла1";
            this.ИмяФайла1.Size = new System.Drawing.Size(211, 20);
            this.ИмяФайла1.TabIndex = 2;
            this.ИмяФайла1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ИмяФайла1_MouseClick);
            // 
            // ИмяФайла2
            // 
            this.ИмяФайла2.Location = new System.Drawing.Point(212, 31);
            this.ИмяФайла2.Name = "ИмяФайла2";
            this.ИмяФайла2.Size = new System.Drawing.Size(211, 20);
            this.ИмяФайла2.TabIndex = 3;
            this.ИмяФайла2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ИмяФайла2_MouseClick);
            // 
            // КнопкаНачатьСравнение
            // 
            this.КнопкаНачатьСравнение.Location = new System.Drawing.Point(4, 50);
            this.КнопкаНачатьСравнение.Name = "КнопкаНачатьСравнение";
            this.КнопкаНачатьСравнение.Size = new System.Drawing.Size(446, 24);
            this.КнопкаНачатьСравнение.TabIndex = 4;
            this.КнопкаНачатьСравнение.Text = "Начать сравнение отчетов о сравнении конфигураций";
            this.КнопкаНачатьСравнение.UseVisualStyleBackColor = true;
            this.КнопкаНачатьСравнение.Click += new System.EventHandler(this.КнопкаНачатьСравнение_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(467, 577);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.СписокИзменений);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(459, 551);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ошибки";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // СписокИзменений
            // 
            this.СписокИзменений.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ОбъектКонфигурации1,
            this.ОбъектКонфигурации2,
            this.Разница});
            this.СписокИзменений.Dock = System.Windows.Forms.DockStyle.Fill;
            this.СписокИзменений.GridLines = true;
            this.СписокИзменений.ImeMode = System.Windows.Forms.ImeMode.On;
            this.СписокИзменений.Location = new System.Drawing.Point(3, 3);
            this.СписокИзменений.MultiSelect = false;
            this.СписокИзменений.Name = "СписокИзменений";
            this.СписокИзменений.Size = new System.Drawing.Size(453, 545);
            this.СписокИзменений.TabIndex = 0;
            this.СписокИзменений.UseCompatibleStateImageBehavior = false;
            this.СписокИзменений.View = System.Windows.Forms.View.Details;
            // 
            // ОбъектКонфигурации1
            // 
            this.ОбъектКонфигурации1.Text = "Объект конфигурации 1";
            this.ОбъектКонфигурации1.Width = 160;
            // 
            // ОбъектКонфигурации2
            // 
            this.ОбъектКонфигурации2.Text = "Объект конфигурации 2";
            this.ОбъектКонфигурации2.Width = 160;
            // 
            // Разница
            // 
            this.Разница.Text = "Разница";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ДеревоИзменений);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(459, 551);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Отчет 1";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ДеревоИзменений
            // 
            this.ДеревоИзменений.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ДеревоИзменений.Location = new System.Drawing.Point(3, 3);
            this.ДеревоИзменений.Name = "ДеревоИзменений";
            this.ДеревоИзменений.ShowNodeToolTips = true;
            this.ДеревоИзменений.Size = new System.Drawing.Size(453, 545);
            this.ДеревоИзменений.TabIndex = 0;
            // 
            // Прогресс
            // 
            this.Прогресс.Location = new System.Drawing.Point(4, 78);
            this.Прогресс.Name = "Прогресс";
            this.Прогресс.Size = new System.Drawing.Size(446, 16);
            this.Прогресс.TabIndex = 6;
            this.Прогресс.Click += new System.EventHandler(this.Прогресс_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ДеревоИзменений2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(459, 551);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Отчет 2";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ДеревоИзменений2
            // 
            this.ДеревоИзменений2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ДеревоИзменений2.Location = new System.Drawing.Point(3, 3);
            this.ДеревоИзменений2.Name = "ДеревоИзменений2";
            this.ДеревоИзменений2.ShowNodeToolTips = true;
            this.ДеревоИзменений2.Size = new System.Drawing.Size(453, 545);
            this.ДеревоИзменений2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Прогресс);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.КнопкаНачатьСравнение);
            this.panel1.Controls.Add(this.ИмяФайла1);
            this.panel1.Controls.Add(this.ИмяФайла2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 545);
            this.panel1.TabIndex = 6;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.panel1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(459, 551);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Старт";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(429, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Открыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(429, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Открыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ФормаВыбораФайлов
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 577);
            this.Controls.Add(this.tabControl1);
            this.Name = "ФормаВыбораФайлов";
            this.Text = "ФормаВыбораФайлов";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ИмяФайла1;
        private System.Windows.Forms.TextBox ИмяФайла2;
        private System.Windows.Forms.Button КнопкаНачатьСравнение;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView СписокИзменений;
        private System.Windows.Forms.ColumnHeader ОбъектКонфигурации1;
        private System.Windows.Forms.ColumnHeader ОбъектКонфигурации2;
        private System.Windows.Forms.ColumnHeader Разница;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TreeView ДеревоИзменений;
        private System.Windows.Forms.ProgressBar Прогресс;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TreeView ДеревоИзменений2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}