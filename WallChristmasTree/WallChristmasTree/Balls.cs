﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallChristmasTree
{
    class Balls
    {
        Bitmap bImage;
        public Balls(Profiles user)
        {
            bImage = new Bitmap("E:\\2.png");
        }

        public string Image
        {
            get
            {
                bImage.Save("tmp.png", ImageFormat.Png);
                return "tmp.png";
            }
        }
    }
}
