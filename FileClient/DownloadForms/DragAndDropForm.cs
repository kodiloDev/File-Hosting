using FileClient.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace FileClient.DownloadForms
{
    public partial class DragAndDropForm : Form
    {
        MembershipUser user;
        FileServiceClient client;
        public DragAndDropForm()
        {
            InitializeComponent();
        }
        public DragAndDropForm(MembershipUser user)
        {
            InitializeComponent();
            client = new FileServiceClient("BasicHttpBinding_IFileService");
            this.user = user;
        }
        private void pnl_dragAndDrop_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private async void pnl_dragAndDrop_DragDrop(object sender, DragEventArgs e)
        {
           string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
           int count = await Helper.UploadPicturesAsync(files, new Guid(user.ProviderUserKey.ToString()), new Progress<int>(percent => pb_form.Value = percent), client);
          
            if (count == 100)
            {
                this.Close();
            }
        }

     
        private void DragAndDropForm_Load(object sender, EventArgs e)
        {

        }
    
    }
}
