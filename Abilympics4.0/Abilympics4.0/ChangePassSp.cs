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
    public partial class ChangePassSp : Form
    {
        public ChangePassSp()
        {
            InitializeComponent();
        }

        /* сохранение значения textBox в переменную ChangePassSp и
         переход на форму SpecialistMenu*/
        private void Button2_Click(object sender, EventArgs e)
        {
            Data.ChangePassSp = textBox3.Text;
            Form sm = new SpecialistMenu();
            Hide();
            DialogResult res = sm.ShowDialog();
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
