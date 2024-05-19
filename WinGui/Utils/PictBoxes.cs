using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinGui.FileTypes;

namespace WinGui.Utils
{
    // Various helpers for character picture boxes
    internal class PictBoxes
    {
        // Bitmaps to show in our window
        // e.g., "Bartz" -> Bartz's down-facing sprite
        public static Dictionary<string, Bitmap> CharaPicSprites;

        // Update picture boxes with the correct picture for each character
        public static void UpdatePictBoxes()
        {
            Console.WriteLine("Loading character images...");

            // Cache for future use
            CharaPicSprites = new Dictionary<string, Bitmap>();
            foreach (string sprName in Assets.sprite_names_ordered)
            {
                // Generate
                string path = Assets.ConvertPath(Assets.chara_sprites[sprName].imagePath);
                Rectangle clip = Assets.chara_sprites[sprName].animFrames["Default_00"];

                // Save
                CharaPicSprites[sprName] = GetCharaPic(path, clip);
            }

            // Set images, crop, and zoom
            //for (int i = 0; i < Form1.AllCharas.Count; i++)
            //{
            //    Form1.AllPicts[i].Image = CharaPicSprites[Form1.AllCharas[i]];
            //}
        }

        private static Bitmap GetCharaPic(string srcPath, Rectangle clipRect)
        {
            // Load source image, clip it.
            Bitmap src = new Bitmap(srcPath);
            Bitmap clipped = src.Clone(clipRect, src.PixelFormat);

            // Scale it manually (to get a pixel-perfect scale).
            const int z = 2;
            Bitmap zoomed = new Bitmap(clipped.Width * z, clipped.Height * z, clipped.PixelFormat);
            using (Graphics g = Graphics.FromImage(zoomed))
            {
                g.InterpolationMode = InterpolationMode.NearestNeighbor;
                g.PixelOffsetMode = PixelOffsetMode.Half;
                g.DrawImage(clipped, new Rectangle(Point.Empty, zoomed.Size));
            }

            // Done
            return zoomed;
        }

    }
}
