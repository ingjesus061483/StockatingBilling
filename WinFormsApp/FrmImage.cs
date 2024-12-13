using DataAccess.Repositories;
using DTO;
using Factory;
using Microsoft.EntityFrameworkCore.Storage.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class FrmImage : Form
    {
        public ProductDTO ProductDTO { get; set; }
        byte[] ImageData;
        public PictureRepository PictureRepository { get; set; }
        public List<PictureDTO> Images { get; set; }
        string path;
        public FrmImage()
        {
            InitializeComponent();
        }

        private void FrmImage_Load(object sender, EventArgs e)
        {
            if (ProductDTO == null)
            {
                newImage();
                return;
            }
            Images = ProductDTO.Images.Select(x => new PictureDTO
            {
                Id = x.Id,
                Code = x.Code,
                Name = x.Name,
                Type = x.Type,
                Data = x.Data
            }).ToList();
            newImage();
        }
        void newImage()
        {
            dgImages.DataSource = Images.Select(x => new
            {
                x.Id,
                Codigo=x.Code,
                Nombre = x.Name,
                Tipo = x.Type,
                x.Data
            }).ToList();
            if (dgImages.CurrentRow == null)
            {
                pictureBox1.Image = null;
                return;
            }
            ImageData = (byte[])dgImages.CurrentRow.Cells["Data"].Value;
            pictureBox1.Image = ControlForm.LoadImage(ImageData);

        }
        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (ControlForm.OpenDialog("Imagenes (JPG)|*.jpg", ref path))
            {
                string[] strings=path.Split('\\');
                string name=    strings[strings.Length-1];
                string[] names = name.Split('.');
                name = names[0];
                string type = names[1];
                ImageData = ControlForm.LoadImage(pictureBox1, path);
                PictureDTO picture = new()
                {
                    Code = DateTime.Now.ToOADate().ToString(),
                    Name = name,
                    Type = type,
                    Data = ImageData
                };
                if (ProductDTO != null)
                {
                    picture.ProductId = ProductDTO.Id;
                    PictureRepository.Save(picture);
                    Images = PictureRepository.Values.Where(x=>x.ProductId== ProductDTO.Id).ToList();                  
                    newImage();
                    return;
                }
                Images.Add(picture);
                newImage();
            }
        }

        private void dgImages_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           switch (e.ColumnIndex)
            {
                case 0:
                    {
                        byte[] bytes = (byte[])dgImages.Rows[e.RowIndex].Cells["Data"].Value;
                        pictureBox1.Image = ControlForm.LoadImage(bytes);
                        break;
                    }
                case 1:
                    {
                        string  code =  dgImages.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();                         
                        var P = Images.Where(x => x.Code == code).FirstOrDefault();

                        if (ProductDTO==null)
                        {
                            Images.Remove(P);

                        }
                        else
                        {
                            PictureRepository.DeleteById(P.Id);
                            Images = PictureRepository.Values.Where(x => x.ProductId == ProductDTO.Id).ToList();
                        }
                        newImage();
                        break;
                    }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
