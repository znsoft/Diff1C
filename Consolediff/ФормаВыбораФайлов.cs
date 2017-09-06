using Consolediff.filetree;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Consolediff
{
    public partial class ФормаВыбораФайлов : Form
    {
        public ФормаВыбораФайлов()
        {
            InitializeComponent();
        }

        private void ИмяФайла2_MouseClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog ДиалогОткрытияФайла = new OpenFileDialog();
            ДиалогОткрытияФайла.ShowDialog();
            ИмяФайла2.Text = ДиалогОткрытияФайла.FileName;
        }

        private void ИмяФайла1_MouseClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog ДиалогОткрытияФайла = new OpenFileDialog();
            ДиалогОткрытияФайла.ShowDialog();
            ИмяФайла1.Text = ДиалогОткрытияФайла.FileName;
        }

        private void КнопкаНачатьСравнение_Click(object sender, EventArgs e)
        {

            ДеревоМетаданных Дерево1 = new Загрузчик(ИмяФайла1.Text, 3, (В, с, р)=>{ Прогресс.Maximum = (int)р; Прогресс.Increment(с.Length); }).КореньДерева;

            ДеревоМетаданных Дерево2 = new Загрузчик(ИмяФайла2.Text, 3, (В, с, р) => { Прогресс.Maximum = (int)р; Прогресс.Increment(с.Length); }).КореньДерева;
             var РазличияСписком = Дерево1.ПолучитьРазличияРекурсией(Дерево2);
            РазличияСписком.AddRange(Дерево2.ПолучитьРазличияРекурсией(Дерево1));
            Прогресс.Value = Прогресс.Maximum;
            СписокИзменений.Items.Clear();
             РазличияСписком = (from Различие in РазличияСписком where Различие.СуммаВложенныхРазличий > 0 select Различие).ToList();
             foreach (var Различие in РазличияСписком) {
                 string[] Строки = new string[3];
                 if (Различие.Корень.Имя.Contains(ИмяФайла1.Text)) Строки[0] = Различие.Имя;
                 if (Различие.Корень.Имя.Contains(ИмяФайла2.Text)) Строки[1] = Различие.Имя;
                 Строки[2] = Различие.СуммаВложенныхРазличий.ToString();
                 ListViewItem item = new ListViewItem(Строки);
                 СписокИзменений.Items.Add(item);
             }
            // ДеревоИзменений.Nodes.Clear();
            ДеревоИзменений.Nodes.Add( ОтобразитьДеревоРекурсивно(Дерево1, new TreeNode(Дерево1.Имя)));
            ДеревоИзменений2.Nodes.Add(ОтобразитьДеревоРекурсивно(Дерево2, new TreeNode(Дерево2.Имя)));
            tabControl1.SelectedIndex = 1;
        }


        TreeNode ОтобразитьДеревоРекурсивно(ДеревоМетаданных Дерево, TreeNode нода)
        {
           
            foreach (ДеревоМетаданных Лист in Дерево.Подчиненные) {
                TreeNode нодаЛист = new TreeNode(Лист.ПолноеИмя);
                нода.Nodes.Add(нодаЛист);
                ОтобразитьДеревоРекурсивно(Лист, нодаЛист);
            }
            return нода;
        }

        private void Прогресс_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(ИмяФайла1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(ИмяФайла2.Text);
        }
    }
}
