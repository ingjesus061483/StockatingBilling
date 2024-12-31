using System.Drawing;
using System.Drawing.Printing;
using DTO;

namespace DataAccess.Repositories
{
    public  class PrinterTemplateRepository
    {
        string Path { get { return Application.StartupPath + "\\Imprimir"; } }
        string file = "\\Imprimir.txt";

        private  PrintDocument Printer { get; set; }
    ProductRepository ProductRepository { get; set; }
    
        public PrinterTemplateRepository( ProductRepository _productRepository)
        {
            ProductRepository = _productRepository;
           Printer  = new PrintDocument();
        }
        public void BillingTemplate(BillHeaderDTO billHeaderDTO)
        {           
            StreamWriter sw =Utilities <string>. Createfile(Path,file );
            try
            {
                if (billHeaderDTO == null)
                {
                    return;
                }
                var cliente = billHeaderDTO .Client ;
                var empresa = billHeaderDTO .Employee .User .Company;
                sw.WriteLine("========= Datos de Empresa ==============");
                sw.WriteLine("=" + empresa.Name );
                sw.WriteLine("Nit:" + empresa.Nit);
                sw.WriteLine("Direccion:" + empresa.Address );
                sw.WriteLine("=Tipo de regimen:" + empresa.RegimenType .Name );
                sw.WriteLine("Telefono:" + empresa.Phone );
                sw.WriteLine("=========================================");
                sw.WriteLine("========== Encabezado ====================");
                sw.WriteLine("Tipo de Documento: " + billHeaderDTO .DocumentType  .Name    + " No. " + billHeaderDTO .Code );
                sw.WriteLine("Fecha: " + billHeaderDTO .Date );
                //sw.WriteLine("Forma de pago:" + factura.FormaPago .Nombre  );
                sw.WriteLine("Estado:" + billHeaderDTO .State .Name );
                sw.WriteLine("=========================================");
                if (cliente != null) 
                {
                    sw.WriteLine("===== Informacion Cliente ===========");
                    sw.WriteLine("Tipo de identificacion:" + cliente.IdentificationType.Name   );
                    sw.WriteLine("Identifcacion: " + cliente.Identification);
                    sw.WriteLine("Nombre Completo: " + cliente.Name +" "+cliente .LastName );
                    sw.WriteLine("Direccion: " + cliente.Address);
                    sw.WriteLine("Telefono: " + cliente.Phone );
                    sw.WriteLine("=====================================");
                }
                var billDetails=billHeaderDTO .BillDetails;
                if (billDetails .Count != 0)
                {
                    sw.WriteLine("==============  Detalle   ==================");
                    foreach (var item in billDetails )
                    {
                        var arti = ProductRepository .GetById(item .ProductId );
                        sw.WriteLine("= codigo: " + arti.Code);
                        sw.WriteLine("= Articulo: " + arti.Name );
                        sw.WriteLine("Cantidad: " + item.Amount);
                        sw.WriteLine("Valor Unitario: $" + item.UnitPrice);
                        sw.WriteLine("Total: $" + item.Total);
                       
                    }
                    sw.WriteLine("=========================================");
                }
                sw.WriteLine("=============== Totales ===================");
                sw.WriteLine("= Subtotal: $" + billHeaderDTO .Total );
             /*   sw.WriteLine("= Total impuesto $" + factura.Impuesto );
                sw.WriteLine("= Descuento $" + factura.Descuento);                
                sw.WriteLine("= Total a pagar $" + factura.TotalPagar );
                sw.WriteLine("= Recibido: $" + factura.Recibido);
                sw.WriteLine("= Cambio: $" + factura.Cambio);*/
                sw.WriteLine("==========================================");
                if (!string.IsNullOrEmpty(empresa.Slogan ))
                {
                    sw.WriteLine("==========================================");
                    sw.WriteLine("  " + empresa.Slogan);
                    sw.WriteLine("==========================================");
                }
                sw.WriteLine("==========================================");
                sw.WriteLine("=          GRACIAS POR SU COMPRA         =");
                sw.WriteLine("==========================================");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sw.Close();
                Printer.PrintPage += PrinterBilling_PrintPage;
                Printer.Print();
            }
        }

        private void PrinterBilling_PrintPage(object sender, PrintPageEventArgs e)
        {
            StreamReader sreader =Utilities<string>. ReadFile (Path,file );
            try
            {
                Font font = new Font( "arial", 8, FontStyle.Regular, GraphicsUnit.Point);
                float tam = font.Size + 5;
                float y = 0;
                string? line = sreader != null ? sreader.ReadLine():"" ;
                while (!string.IsNullOrEmpty(line))
                {
                    if (line.IndexOf("=") == -1)
                    {
                        Paintfont(line,8, FontStyle.Regular, y, e.Graphics);
               //         font = new Font("arial", 8, FontStyle.Regular, GraphicsUnit.Point);
                 //       e.Graphics.DrawString(line, font, Brushes.Black, new RectangleF(0, y, 3000, 20));
                    }
                    else
                    {
                        Paintfont(line,8, FontStyle.Bold , y, e.Graphics);
                     //   font = new Font("arial", 8, FontStyle.Bold, GraphicsUnit.Point);
                       // e.Graphics.DrawString(line, font, Brushes.Black, new RectangleF(0, y, 3000, 20));
                    }
                    line = sreader.ReadLine();
                    y += tam;
                }
            }

            catch (Exception ex)
            {
                e.Cancel = true;
                throw ex;
            }
            finally
            {
                if (sreader != null)
                {
                    sreader.Close();
                }
  
                Utilities<string > .   DeleteFile(Path,file);
//                e.Cancel = true;
            }
            void Paintfont(string line,float size, FontStyle fontStyle,float y ,Graphics?  graphics )
            {
              Font  font = new ("arial", size , fontStyle , GraphicsUnit.Point);
                graphics.DrawString(line, font, Brushes.Black, new RectangleF(0, y, 3000, 20));
            }
        }
    }
}
