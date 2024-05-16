using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WinGui.FileTypes;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinGui.Utils
{
    internal class SpriteChange
    {

        // Re-sprite all characters
        // Returns an error string, or "" for "no error"
        public static string DoChange()
        {
            foreach (string chName in Form1.AllCharas)
            {
                string path = Assets.ConvertPath(Assets.chara_sprites[chName].imagePath); // Constants.CharaPaths[chName];
                string outPath = Assets.ConvertPath(Assets.chara_sprites[chName].imagePath.Replace("STEAM_EXPORT_DIR", "STEAM_IMPORT_DIR"));
                string newChara = Config.SpriteName(chName);

                // Load "source" image, clone it (so we have the same format).
                Bitmap dstOrig = new Bitmap(path);
                Bitmap dst = new Bitmap(dstOrig.Width, dstOrig.Height, dstOrig.PixelFormat);

                // Muck with the path for the true source image
                string newPath = Assets.ConvertPath(Assets.chara_sprites[newChara].imagePath);

                // Load the true source image
                Bitmap src = new Bitmap(newPath);

                // Copy all our rectangles
                using (Graphics g = Graphics.FromImage(dst))
                {
                    // Iterate over all animation frames we want to *write* for this character.
                    foreach (var dstAnim in Assets.chara_sprites[chName].animFrames)
                    {
                        // Key/Value
                        var animName = dstAnim.Key;
                        var dstFrame = dstAnim.Value;

                        // Find the matching "src" character frame.
                        var newFrames = Assets.chara_sprites[newChara].animFrames;
                        var srcFrame = newFrames.ContainsKey(animName) ? newFrames[animName] : newFrames[Constants.BackupFrames[animName]];

                        // Now, draw it!
                        drawFrame(g, dstFrame, src, srcFrame);
                    }
                }

                // Save to PNG
                dst.Save(outPath, System.Drawing.Imaging.ImageFormat.Png);
            }

            return "";
        }

        // Draw a single frame from the source image to the destination image.
        private static void drawFrame(Graphics dstG, Rectangle dstFrame, Bitmap srcImg, Rectangle srcFrame)
        {
            dstG.DrawImage(srcImg, dstFrame.X, dstFrame.Y, srcFrame, GraphicsUnit.Pixel);
        }



    }
}
