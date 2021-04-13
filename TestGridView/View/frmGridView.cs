using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace View
{
    public partial class frmGridView : Form
    {
        public frmGridView()
        {
            InitializeComponent();
        }

        List<EmployeesDTO> employeesDTOs = new List<EmployeesDTO>();
        private void frmGridView_Load(object sender, EventArgs e)
        {
            employeesDTOs = EmployeesBus.loadListEmployBUS();
            gcEmployee.DataSource = employeesDTOs;
            //MessageBox.Show(employeesDTOs.Count().ToString());
            //MessageBox.Show(EmployeesBus.loadListEmployBUS().Count.ToString());
            //MessageBox.Show(employeesDTOs.ElementAt(0).StrID);
        }
    }
}