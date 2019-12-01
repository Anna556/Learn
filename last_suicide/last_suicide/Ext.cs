using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace last_suicide
{
    public static class Ext
    {
        public static void OpenForm(this Form form,Form secondform )
        {
            form.Hide();
            secondform.ShowDialog();
            form.Show();
        }
    }
}
