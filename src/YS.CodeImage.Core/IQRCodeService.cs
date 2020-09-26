using System;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Threading.Tasks;
using YS.Knife.Aop;

namespace YS.CodeImage
{
    [ParameterValidation]
    public interface IQRCodeService
    {
        Task<Bitmap> CodeToImage(string code,QRCodeSetting codeSetting);
    }
    [ParameterValidation]
    public interface IRemoteQRCodeService
    {
        Task<String> CodeToUrl(string code, QRCodeSetting codeSetting);
    }
}
