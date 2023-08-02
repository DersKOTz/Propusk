using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace Propusk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            group_dbDataGridView.Columns[1].Visible = false;
            group_dbBindingNavigator.Visible = false;
            group_dbDataGridView.ReadOnly = true;

        }


        private void group_dbBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.group_dbBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.propuskDataSet);

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "propuskDataSet.group_db". При необходимости она может быть перемещена или удалена.
            this.group_dbTableAdapter.Fill(this.propuskDataSet.group_db);

        }


        private bool disableCellClick = false;
        private void group_dbDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!disableCellClick)
            {
                int rowIndex = e.RowIndex;
                object value = group_dbDataGridView.Rows[rowIndex].Cells[1].Value;
                if (e.RowIndex == rowIndex)
                {
                    string pasS = Interaction.InputBox("Введите пароль:");
                    if (pasS.Length > 0)
                    {
                        {
                            if (Convert.ToInt32(value) == Convert.ToInt32(pasS))
                            {
                                 // yes
                            }
                            else
                            {
                                MessageBox.Show("Пароль не верный!");
                            }
                        }
                    }
                }
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {
            string pasSadm = Interaction.InputBox("Введите пароль:", "Настройки");
            if (pasSadm.Length > 0)
            {
                if (1736 == Convert.ToInt32(pasSadm))
                {
                    group_dbBindingNavigator.Visible = true;
                    group_dbDataGridView.Columns[1].Visible = true;
                    group_dbDataGridView.ReadOnly = false;
                    disableCellClick = true;

                }
                else
                {
                    MessageBox.Show("Пароль не верный!");
                }
            }
        }



    }
}
