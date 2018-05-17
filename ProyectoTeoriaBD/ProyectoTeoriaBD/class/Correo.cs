using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using CEUTEC;

namespace EnviarCorreo
{
    class Correo
    {
      MailMessage  correos= new MailMessage();
      SmtpClient envios = new SmtpClient();

      public void EnviarCorreo(string emisor, string password, string mensaje, string asunto, string destinatario)
      {
          try
          {
            correos.To.Clear();
            correos.Body = "";
            correos.Subject = "";
            correos.Body = mensaje;
            correos.Subject = asunto;
            correos.IsBodyHtml = true;
            correos.To.Add(destinatario.Trim());

            //if(ruta.Equals("")==false)
            //{
            //  System.Net.Mail.Attachment archivo = new System.Net.Mail.Attachment(ruta);
            //  correos.Attachments.Add(archivo);
            //}

            correos.From = new MailAddress("joaquin.izaguirre.g@gmail.com");
            envios.Credentials = new NetworkCredential("joaquin.izaguirre.g@gmail.com", "JIzaguirre9026G");

            //Datos importantes no modificables para tener acceso a las cuentas

            envios.Host = "smtp.gmail.com";
            envios.Port = 587;
            envios.EnableSsl = true;

            envios.Send(correos);
            MessageBox.Show("Factura Enviada Exitosamente");
          }
          catch(Exception ex)
          {
              MessageBox.Show(ex.Message, "No se envio el correo correctamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
              return;
          }
      }
    }
}
