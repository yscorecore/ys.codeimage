using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Text;

namespace YS.CodeImage
{

    public class QRCodeSetting
    {
        public ECCLevel Level { get; set; } = ECCLevel.M;

        public Color BackColor { get; set; } = Color.White;

        public Color ForeColor { get; set; } = Color.Black;

        [Range(1, 50)]
        public int PixelsPerModule { get; set; } = 10;

        public bool DrawQuietZones { get; set; } = true;
    }
    public enum ECCLevel
    {
        L = 0,
        M = 1,
        Q = 2,
        H = 3
    }
}
