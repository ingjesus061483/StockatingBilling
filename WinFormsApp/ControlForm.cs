using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp
{
    public abstract class ControlForm
    {
        public static DataGridViewCellStyle GetGridViewCellStyle(Color back,Color fore )
        {
           DataGridViewCellStyle DefaultCellStyle = new () { BackColor =back , ForeColor = fore  };
            return DefaultCellStyle;
        }
        public static DataGridViewButtonColumn  GetButtonColumn(string  Text ,string header)
           
        {
            DataGridViewButtonColumn buttonColumn = new ()
            {
                FlatStyle = FlatStyle.Flat,
                Text = Text ,
                UseColumnTextForButtonValue = true,
                HeaderText =header 
            };
            return buttonColumn ;
        }
        public static DataGridView GetDatagrid()
        {
            DataGridView dataGridView = new()
            {
                RowHeadersVisible = false,
                BackgroundColor = Color.FromArgb(42, 46, 50),
                ScrollBars = ScrollBars.Both,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                Dock = DockStyle.Fill
            };
            return dataGridView;
        }
        public static Image LoadImage(byte[] imagenbuffer)
        {
            try
            {
                MemoryStream MemoryStream; Image img;
                MemoryStream = new MemoryStream(imagenbuffer);
                img = Image.FromStream(MemoryStream);                  
                return img;
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        } 
        public static byte[] LoadImage(PictureBox picture , string path)
        {
            try
            {
                byte[] bytes = [];
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                picture.Load(path);
                bytes = GetBytes(path);
                return bytes;                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        static byte[] GetBytes(string path) 
        {
            byte[] bytes = [];
            FileStream fileStream = new(path, FileMode.Open, FileAccess.Read);
            int.TryParse(fileStream.Length.ToString(), out int length);
            Array.Resize(ref bytes, length);
            fileStream.Read(bytes, 0, length);
            return bytes;
        }
        public static bool OpenDialog(string filter,ref string path)
        {
            OpenFileDialog OpenFile = new() { Filter = filter };
            bool b= OpenFile.ShowDialog() == DialogResult.OK;                 
            path = OpenFile.FileName;
            return b;
        }
        public static void GetMessage(string message, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            MessageBox.Show(message, caption, buttons, icon);
        }
    }
}
