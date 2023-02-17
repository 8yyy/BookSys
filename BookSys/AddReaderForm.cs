using Books.BLL;
using Books.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BookSys
{
    public partial class AddReaderForm : Form
    {
        public AddReaderForm()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void AddReaderForm_Load(object sender, EventArgs e)
        {
            rdTypeCbx.DataSource=ReaderTypeBll.GetReaderList();
            rdTypeCbx.DisplayMember = "rdTypeName";//需要显示的内容
            rdTypeCbx.ValueMember= "rdType"; //给程序员看的
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            //简单判断，如果写在Model会更好
            if (rdIDTB.Text.Trim() == null)
            {
                MessageBox.Show("缺少学号");
                return;
            }
            int rdTypee = Convert.ToInt32(rdTypeCbx.SelectedValue);

            Reader reader = new Reader {
                rdID = rdIDTB.Text.Trim(),
                rdType = rdTypee.ToString(),
                rdName = rdNameTB.Text.Trim(),
                rdDept = rdDeptTB.Text.Trim(),
                rdQQ = rdQQTB.Text.Trim(),
                rdborrowQty = rdBorrovQtyTB.Text.Trim(),
            };
            bool b = ReaderBll.AddReader(reader);
            if(b)
            {
                MessageBox.Show("添加成功");
            }
            else
            {
                MessageBox.Show("添加失败");
            }
            new ReadForm().Refersh();
        }
    }
}
