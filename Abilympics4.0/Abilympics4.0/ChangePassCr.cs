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
    public partial class ChangePassCr : Form
    {
        public ChangePassCr()
        {
            InitializeComponent();
        }

        /* сохранение значения textBox в переменную ChangePassCr и
         переход на форму CreatorMenu*/
        private void Button2_Click(object sender, EventArgs e)
        {
            Data.ChangePassCr = textBox3.Text;
            Form cm = new CreatorMenu();
            Hide();
            DialogResult res = cm.ShowDialog();
            if (res != DialogResult.Cancel)
            {
                Show();
            }
            else Close();
        }

        // закрытие формы
        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
