using Books.BLL;
using Books.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookSys
{
    public partial class EditReaderForm : Form
    {
        private string id;
        public EditReaderForm(string rdID, string rdType, string rdName, string rdDept,string rdQQ,string rdborrowQty)
        {
            InitializeComponent();
            rdIDTB.Text = rdID;
            //rdTypeTB.Text = rdType;
            rdNameTB.Text = rdName;
            rdDeptTB.Text = rdDept;
            rdQQTB.Text = rdQQ;
            rdBorrovQtyTB.Text = rdborrowQty;
            id=rdID;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            int rdTypee = Convert.ToInt32(rdTypeCbx.SelectedValue);
            Reader reader = new Reader
            {
                rdID = rdIDTB.Text.Trim(),
                rdType = rdTypee.ToString(),
                rdName = rdNameTB.Text.Trim(),
                rdDept = rdDeptTB.Text.Trim(),
                rdQQ = rdQQTB.Text.Trim(),
                rdborrowQty = rdBorrovQtyTB.Text.Trim(),
            };
            bool b = ReaderBll.EditReader(reader);
            if (b)
            {
                MessageBox.Show("修改成功");
            }
            else
            {
                MessageBox.Show("修改失败");
            }
            new ReadForm().Refersh();
        }

        private void EditReaderForm_Load(object sender, EventArgs e)
        {
            rdTypeCbx.DataSource = ReaderTypeBll.GetReaderList();
            rdTypeCbx.DisplayMember = "rdTypeName";//需要显示的内容
            rdTypeCbx.ValueMember = "rdType"; //给程序员看的
        }
    }
}
