using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abilympics4._0
{
    public partial class CreatorMenu : Form
    {
        public CreatorMenu()
        {
            InitializeComponent();
        }

        private void OrdersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbDataSet);

        }

        private void CreatorMenu_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.Workers". При необходимости она может быть перемещена или удалена.
            this.workersTableAdapter.Fill(this.dbDataSet.Workers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.TypeServices". При необходимости она может быть перемещена или удалена.
            this.typeServicesTableAdapter.Fill(this.dbDataSet.TypeServices);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.Orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.dbDataSet.Orders);

        }

        // переходы по tabPage
        private void Button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        // закрытие формы
        private void Button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        // переход на форму ChangePassCr
        private void Button6_Click(object sender, EventArgs e)
        {
            Form cpc = new ChangePassCr();
            Hide();
            DialogResult res = cpc.ShowDialog();
            if (res != DialogResult.Cancel)
            {
                Show();
            }
            else Close();
        }
    }
}
