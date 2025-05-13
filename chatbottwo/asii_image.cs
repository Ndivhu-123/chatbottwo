using System;
using System.Drawing;
using System.IO;

namespace chatbottwo
{

    public class asii_image
    {
        //constructor
        public asii_image()
        {
            //getting the image path
            string path_project = AppDomain.CurrentDomain.BaseDirectory;

            string new_path_project = path_project.Replace("bin\\Debug\\", "");

            //combine the project full path 
            string full_path = Path.Combine(new_path_project, "lock.jpg");

            //the logo.ascii
            Bitmap image = new Bitmap(full_path);
            image = new Bitmap(image, new Size(110, 50));

            // for loop.nested ,inner loop nd outer loop
            for (int height = 0; height < image.Height; height++)
            {
                //width
                for (int width = 0; width < image.Width; width++)
                {
                    //the ascii design
                    Color pixelColor = image.GetPixel(width, height);
                    int color = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    //using char 
                    char ascii_design = color > 200 ? '#' : color > 150 ? ' ' : color > 100 ? ' ' : color > 50 ? '#' : '@';
                    // displaying the output
                    Console.Write(ascii_design);
                }//end of inner loop
                Console.WriteLine();
            }//end of outer loop

        }
    }
}


