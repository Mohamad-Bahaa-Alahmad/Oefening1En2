using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AandelenBeheer
{
    public partial class FormAandelen : Form
    {
        public FormAandelen()
        {
            InitializeComponent();
        }

        private void aandelenBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aandelenBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aandelenBeheerDataSet);

        }

        private void FormAandelen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aandelenBeheerDataSet.Transacties' table. You can move, or remove it, as needed.
            this.transactiesTableAdapter.Fill(this.aandelenBeheerDataSet.Transacties);
            // TODO: This line of code loads data into the 'aandelenBeheerDataSet.Aandelen' table. You can move, or remove it, as needed.
            this.aandelenTableAdapter.Fill(this.aandelenBeheerDataSet.Aandelen);

        }
    }
}
