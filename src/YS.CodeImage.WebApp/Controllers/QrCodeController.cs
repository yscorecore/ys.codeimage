using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QRCoder;

namespace YS.CodeImage.WebApp.Controllers
{
    //[ApiController]
    //[Route("qrcode")]
    public class QrCodeController : ControllerBase
    {

        [HttpGet]
        public void Create([FromQuery] string text = "")
        {

            //using QRCodeGenerator generator = new QRCodeGenerator();
            //QRCodeData codeData = generator.CreateQrCode(text, QRCodeGenerator.ECCLevel.M, true);
            //using QRCode qrcode = new QRCode(codeData);

            //Bitmap qrImage = qrcode.GetGraphic(10, Color.Blue, Color.White, false);
            //Response.ContentType = "image/png";
            //using var memoryStream = new MemoryStream();

            //qrImage.Save(memoryStream, ImageFormat.Png);
            //memoryStream.Seek(0, SeekOrigin.Begin);



            //memoryStream.CopyToAsync(Response.Body);
        }

    }

}
