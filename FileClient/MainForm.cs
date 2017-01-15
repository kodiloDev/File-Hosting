using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileClient.ServiceReference1;
using System.Web.Security;
using System.Threading;
using System.IO;

namespace FileClient
{
   
    public partial class MainForm : Form
    {
        FileServiceClient client;
        MembershipUser user;
        int currentFileId = 0;
        public MainForm()
        {
            InitializeComponent();
        }
        public MainForm(string login)
        {
            InitializeComponent();       
            client = new FileServiceClient("BasicHttpBinding_IFileService");
            user = Membership.GetUser(login);
            UpdateDGV(user);
            OptionsDataGrid();
           
        }
        public void OptionsDataGrid()
        {
            try
            {
                dgv_allFiles.Columns["Id"].Visible = false;
                dgv_allFiles.Columns["ContentType"].Visible = false;
                dgv_allFiles.Columns["UserId"].Visible = false;
                dgv_allFiles.Columns["Data"].Visible = false;
                dgv_allFiles.Columns["Created"].Visible = false;
                dgv_allFiles.Columns["Description"].Width = 300;
            }
            catch { }
        }
        static double ConvertBytesToMegabytes(long bytes)
        {
            return (bytes / 1024f) / 1024f;
        }
        public bool ByteArrayToFile(string _FileName, byte[] _ByteArray)
        {
            bool result = false;
            try
            {
               FileStream _FileStream =  new FileStream(_FileName, FileMode.Create, FileAccess.Write);
               _FileStream.Write(_ByteArray, 0, _ByteArray.Length);
               _FileStream.Close();
                result = true;
            }
            catch (Exception ex)
            {
            }
            return result;
        }
        public void UpdateDGV(MembershipUser user)
        {
            
            DataTable allDebitors = client.GetAllFiles(new Guid(user.ProviderUserKey.ToString()));
            dgv_allFiles.DataSource = allDebitors;
        } 
        private void MainForm_Load(object sender, EventArgs e)
        {
            dgv_allFiles.CellEnter += new DataGridViewCellEventHandler(dgv_allFiles_CellEnter);
        }

        private void dgv_allFiles_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                currentFileId = (Int32)dgv_allFiles.Rows[e.RowIndex].Cells["Id"].Value;
                txbx_fileName.Text = dgv_allFiles.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                txbx_contentType.Text = dgv_allFiles.Rows[e.RowIndex].Cells["ContentType"].Value.ToString();
                txbx_created.Text = dgv_allFiles.Rows[e.RowIndex].Cells["Created"].Value.ToString();
                rtxbx_description.Text = dgv_allFiles.Rows[e.RowIndex].Cells["Description"].Value.ToString();
                txbx_FileSize.Text = dgv_allFiles.Rows[e.RowIndex].Cells["Data"].Value.ToString();
            }
            catch (Exception ex)
            {}
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            if (currentFileId != 0 && client.UpdateFileInfo(currentFileId, rtxbx_description.Text))
            {
                MessageBox.Show("Описание успешно обновлено", "Обновление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateDGV(user);
            }
            else
            {
                MessageBox.Show("Описание не обновлено", "Обновление", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delFile_Click(object sender, EventArgs e)
        {
            if (currentFileId != 0 && client.DeleteFile(currentFileId))
            {
                MessageBox.Show("Файл успешно удален", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateDGV(user);
            }
            else
            {
                MessageBox.Show("Файл не удален", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btn_download_Click(object sender, EventArgs e)
        {
           
                FolderBrowserDialog folderDialog = new FolderBrowserDialog();
                DialogResult dialogResult = folderDialog.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    string path = folderDialog.SelectedPath;
                    byte[] file = await client.GetFileAsync(currentFileId, new Guid(user.ProviderUserKey.ToString()));
                if (ByteArrayToFile(path + "\\" + txbx_fileName.Text, file))
                {
                    MessageBox.Show("Файл успешно загружен", "Загрузка завершена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Что то пошло не так. Попробуйте позже.", "Ошибка загрузки", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                }

        }

        private void grbx_DebitorsDetails_Enter(object sender, EventArgs e)
        {

        }

        private void draganddropToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DownloadForms.DragAndDropForm form = new DownloadForms.DragAndDropForm(user);
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                UpdateDGV(user);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            client.Close();
            Application.Exit();
        }

        private void fileDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFiles = new OpenFileDialog();
            openFiles.InitialDirectory = "c:\\";
            openFiles.FilterIndex = 2;
            openFiles.RestoreDirectory = true;
            openFiles.Multiselect = true;
            if (openFiles.ShowDialog() == DialogResult.OK)
            {
                string[] files = openFiles.FileNames;
                if (files != null)
                {
                    if (Helper.DownloadFiles(files, new Guid(user.ProviderUserKey.ToString()), client))
                    {
                        UpdateDGV(user);
                        MessageBox.Show("Загрузка завершена");
                    }
                }
            }
        }
    }
}
