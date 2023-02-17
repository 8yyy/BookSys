using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Books.BLL;

namespace BookSys
{
    public partial class ReadForm : Form
    {
        public ReadForm()
        {
            InitializeComponent();
        }

        private  void ReadForm_Load(object sender, EventArgs e)
        {
            Refersh();
        }

        //增删改查后刷新dgv
        public void Refersh()
        {
            //调用BLL层代码
            DataTable dt = ReaderBll.GetReaderList();
            if (dt != null)
            {
                dgvReader.DataSource = dt;
            }
            else
            {
                MessageBox.Show("未查到数据");
            }
        }

        private void SelectBtn_Click(object sender, EventArgs e)
        {
            string name=txtName.Text;
            //调用BLL代码
            DataTable dt = ReaderBll.GetReaderByName(name);
            if (dt != null)
            {
                dgvReader.DataSource = dt;
            }
            else
            {
                MessageBox.Show("未查到数据");
            }
            Refersh();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddReaderForm adr = new AddReaderForm();   
            adr.ShowDialog(); 
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            //方法1：获取选择那一行第一列的数据
            //SelectedRows[0]表示选择的第一行
            //获取用于填充行的单元格集合。
            string tid = dgvReader.SelectedRows[0].Cells[0].Value.ToString();
            
            if(MessageBox.Show("确实要删除吗？", tid, MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                return;
            }

            //方法二：根据文本框
            string id = txtName.Text.Trim();
            //调用BLL代码
            //bool b = ReaderBll.DeleteReader(id);
            bool b = ReaderBll.DeleteReader(tid);
            if (b)
            {
                MessageBox.Show("删除成功!");
            }
            else
            {
                MessageBox.Show("删除失败");
            }
            Refersh();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //拿到需要修改的数据
                string rdid = dgvReader.SelectedRows[0].Cells[0].Value.ToString().Trim();
                string rdType = dgvReader.SelectedRows[0].Cells[1].Value.ToString().Trim();
                string rdName = dgvReader.SelectedRows[0].Cells[2].Value.ToString().Trim();
                string rdDept = dgvReader.SelectedRows[0].Cells[3].Value.ToString().Trim();
                string rdQQ = dgvReader.SelectedRows[0].Cells[4].Value.ToString().Trim();
                string rdborrowQty = dgvReader.SelectedRows[0].Cells[5].Value.ToString().Trim();
                //传到EditReaderForm窗口
                EditReaderForm erf = new EditReaderForm(rdid, rdType, rdName, rdDept, rdQQ, rdborrowQty);
                erf.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message},必须选择一行数据");
            }
            Refersh();
        }
    }
}
