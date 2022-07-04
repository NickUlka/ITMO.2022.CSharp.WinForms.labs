using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO._2022.CSharp.WinForms.lab1._4
{
    public partial class ParentForm : Form
    {
        private int openDocuments = 0;
        public ParentForm()
        {
            InitializeComponent();
            // Свойству Text панели spData устанавливается текущая дата
            spData.Text = Convert.ToString(System.DateTime.Today.ToLongDateString());
        }

        private void MdiMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void WindowCascadeMenuItem_Click(object sender, EventArgs e)
        {
            spWin.Text = "Windows is cascade";
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        private void WindowTileMenuItem_Click(object sender, EventArgs e)
        {
            spWin.Text = "Windows is horizontal";
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        private void ParentForm_Load(object sender, EventArgs e)
        {

        }

        private void NewMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm newChild = new ChildForm();
            newChild.Text = newChild.Text + " " + ++openDocuments;
            newChild.MdiParent = this;
            newChild.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Tag.ToString())
            {
                case "NewDoc":
                    ChildForm newChild = new ChildForm();
                    newChild.MdiParent = this;
                    newChild.Show();
                    newChild.Text = newChild.Text + " " + ++openDocuments;
                    break;
                case "Cascade":
                    spWin.Text = "Windows is cascade";
                    this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
                    break;
            case "Title":
                    spWin.Text = "Windows is horizontal";
                    this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
                    break;
            }

        }

   

        private void spWin_Click(object sender, EventArgs e)
        {

        }
    }
}
