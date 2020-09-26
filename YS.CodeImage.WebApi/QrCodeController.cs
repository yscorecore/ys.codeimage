using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace YS.CodeImage.WebApi
{
   // [ApiController]
    [Route("qrcode")]
    public  class QrCodeController: ControllerBase
    {
        private readonly IQRCodeService qRCodeService;

        public QrCodeController(IQRCodeService qRCodeService)
        {
            this.qRCodeService = qRCodeService;
        }
        [HttpGet]
        //[Produces("image/png")]
        [Produces("image/png")]
        [ProducesErrorResponseType(typeof(void))]
        [ProducesResponseType(typeof(Bitmap), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task Create([FromQuery] string text = "")
        {
            Bitmap qrImage = await qRCodeService.CodeToImage(text, null);
            Response.ContentType = "image/png";
            using (var memoryStream = new MemoryStream())
            {
                qrImage.Save(memoryStream, ImageFormat.Png);
                memoryStream.Seek(0, SeekOrigin.Begin);
                await memoryStream.CopyToAsync(Response.Body);
            }
        }
    }
}
