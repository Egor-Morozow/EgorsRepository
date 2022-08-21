﻿using System;
using System.Windows;
using System.Windows.Media.Imaging;
using Catel.MVVM;

namespace ConvolutionWpf.Commands
{
    public class NegateCommand : Command
    {
        private readonly Func<WriteableBitmap> _imageFactory;

        public NegateCommand(Func<WriteableBitmap> imageFactory)
            : base(() => { })
        {
            _imageFactory = imageFactory;
        }

        public void ExecuteCommand()
        {
            var image = _imageFactory();
            if (image == null)
                return;

            var pixels = new byte[image.PixelHeight * image.BackBufferStride];
            image.CopyPixels(pixels, image.BackBufferStride, 0);

            /*var resultPixels = new byte[image.PixelHeight * image.BackBufferStride];
            for (int i = 0; i < image.PixelWidth; ++i)
            {
                for (int j = 0; j < image.PixelHeight; ++j)
                {
                    int index = j * image.BackBufferStride + 4 * i;
                    for (int c = 0; c < 3; c++)
                    {
                        
                        double red = 255 - pixels[index];
                        double green = 255 - pixels[index + 1];
                        double blue = 255 - pixels[index + 2];
                        byte negative = (byte)(red + green + blue);
                        resultPixels[index + c] = negative;
                    }

                    resultPixels[index + 3] = pixels[index + 3];
                }
            }*/
            /*var resultPixels = new byte[image.PixelHeight * image.BackBufferStride];
            for (int i = 0; i < image.PixelWidth; ++i)
            {
                for (int j = 0; j < image.PixelHeight; ++j)
                {
                    int index = j * image.BackBufferStride + 4 * i;
                    double red = pixels[index];
                    double green = pixels[index + 1];
                    double blue = pixels[index + 2];
                    for (int c = 0; c < 3; c++)
                    {
                        red = 255 - red;
                        green = 255 - green;
                        blue = 255 - blue;
                        resultPixels[index + c] = (byte)(red + green + blue);
                    }
                    resultPixels[index + 3] = pixels[index + 3];
                }
            }*/
            var resultPixels = new byte[image.PixelHeight * image.BackBufferStride];
            for (int i = 0; i < image.PixelWidth; ++i)
            {
                for (int j = 0; j < image.PixelHeight; ++j)
                {
                    int index = j * image.BackBufferStride + 4 * i;
                    double red = pixels[index];
                    double green = pixels[index + 1];
                    double blue = pixels[index + 2];

                    for (int c = 0; c < 3; ++c)
                    {
                        red = 255 - red;
                        green = 255 - green;
                        blue = 255 - blue;

                        byte negate = (byte)(red + green + blue);
                        resultPixels[index + c] = negate;
                    }

                    resultPixels[index + 3] = pixels[index + 3];
                }

            }

            image.WritePixels(new Int32Rect(0, 0, image.PixelWidth, image.PixelHeight), resultPixels, image.BackBufferStride, 0);
        }

        protected override void Execute(object parameter, bool ignoreCanExecuteCheck)
        {
            ExecuteCommand();
        }
    }
}