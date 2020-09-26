using System;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using QRCoder;
using YS.Knife;

namespace YS.CodeImage.Impl
{
    [Service(typeof(IQRCodeService), Lifetime = ServiceLifetime.Singleton)]
    public class QRCodeService : IQRCodeService, IDisposable
    {
        QRCodeGenerator generator;
        public QRCodeService()
        {
            generator = new QRCodeGenerator();
        }
        public Task<Bitmap> CodeToImage(string text, QRCodeSetting codeSetting)
        {
            var codeSettingInternal = codeSetting ?? new QRCodeSetting();
            QRCodeGenerator.ECCLevel level = (QRCodeGenerator.ECCLevel)(int)codeSettingInternal.Level;
            QRCodeData codeData = generator.CreateQrCode(text ?? string.Empty, level, true);
            using (QRCode qrcode = new QRCode(codeData))
            {
                var bitmap = qrcode.GetGraphic(codeSettingInternal.PixelsPerModule, codeSettingInternal.ForeColor, codeSettingInternal.BackColor, codeSettingInternal.DrawQuietZones);
                return Task.FromResult(bitmap);
            }
        }

        public void Dispose()
        {
            if (generator != null)
            {
                generator.Dispose();
            }
        }
    }
}
