using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Windows;
using System.Diagnostics.Eventing.Reader;

namespace GrEditor
{
    public partial class FrmGrEditor : Form
    {
        Graphics mobjCanvas;
        int mintMouseX, mintMouseY;

        Bitmap mobjBitmapInMemory;
        Graphics mobjGraphicsInMemory;

        //Drawing Tools
        enum enTool
        {
            Line,
            Rectangle,
            Ellipse,
            Triangle,
            RightAngleTriangle,
            Curve
        }
        //Tool that is used
        enTool memActiveTool;

        public FrmGrEditor()
        {
            InitializeComponent();

            // creation of drawing graphic
            mobjCanvas = pbCanvas.CreateGraphics();



            // init of tool
            memActiveTool = enTool.Line;


            //Creation of Bitmap
            mobjBitmapInMemory = new Bitmap(pbCanvas.Width, pbCanvas.Height, mobjCanvas);

            //Creation of Graphics in memory
            mobjGraphicsInMemory = Graphics.FromImage(mobjBitmapInMemory);
            mobjGraphicsInMemory.Clear(Color.White);



        }

        private void tsmSave_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFD = new SaveFileDialog();

            saveFD.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            saveFD.Title = "Save an Image File";
            saveFD.RestoreDirectory = true;
            saveFD.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFD.FileName != "")
            {
                // Saves the Image via a FileStream created by the OpenFile method.
                System.IO.FileStream fs =
                    (System.IO.FileStream)saveFD.OpenFile();
                // Saves the Image in the appropriate ImageFormat based upon the
                // File type selected in the dialog box.
                // NOTE that the FilterIndex property is one-based.
                switch (saveFD.FilterIndex)
                {
                    case 1:
                        mobjBitmapInMemory.Save(fs,
                          System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 2:
                        mobjBitmapInMemory.Save(fs,
                          System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 3:
                        mobjBitmapInMemory.Save(fs,
                          System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                }

                fs.Close();
            }


            ///    mobjBitmapInMemory.Save("c:\\Temp\\Lmao.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        private void tsmLoad_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;

            using (OpenFileDialog openFD = new OpenFileDialog())
            {
                openFD.InitialDirectory = "c:\\";
                openFD.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
                openFD.RestoreDirectory = true;

                    if (openFD.ShowDialog() == DialogResult.OK)
                    {
                        System.IO.FileStream fs =
                        (System.IO.FileStream)openFD.OpenFile();
                            //Get the path of specified file
                            filePath = openFD.FileName;


                                //clearing canvas and memories
                                mobjBitmapInMemory = new Bitmap(pbCanvas.Width, pbCanvas.Height, mobjCanvas);
                                mobjGraphicsInMemory = Graphics.FromImage(mobjBitmapInMemory);
                                mobjGraphicsInMemory.Clear(Color.White);
                                mobjCanvas.Clear(Color.White);

                                //putting loaded image on a canvas and into memories
                                mobjBitmapInMemory = new Bitmap(filePath);
                                mobjGraphicsInMemory = Graphics.FromImage(mobjBitmapInMemory);
                                mobjCanvas.DrawImage(Image.FromFile(filePath), 0, 0);


                    fs.Close ();
                    }
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
          mobjBitmapInMemory = new Bitmap(pbCanvas.Width, pbCanvas.Height, mobjCanvas);
          mobjGraphicsInMemory = Graphics.FromImage(mobjBitmapInMemory);
          mobjGraphicsInMemory.Clear(Color.White);
          mobjCanvas.Clear(Color.White);
        }

        /// <summary>
        /// Defines pen and brush
        /// Defines drawing onto canvas
        /// </summary>
        /// <param name="objGraphics"></param>
        /// <param name="e"></param>

        private void GraphicsDraw(Graphics objGraphics, MouseEventArgs e)
        {
            Pen lobjActivePen;

            lobjActivePen = new Pen(pbColorBorder.BackColor);

            Brush lobjActiveBrush;

            lobjActiveBrush = new SolidBrush(pbColorBackground.BackColor);

            if (e.Button == MouseButtons.Right || e.Button == MouseButtons.Left)
                //Drawing by tool
                switch (memActiveTool)
                {
                    case enTool.Line:
                        objGraphics.DrawLine(lobjActivePen, mintMouseX, mintMouseY, e.X, e.Y);
                        break;
                    case enTool.Rectangle:
                        objGraphics.FillRectangle(lobjActiveBrush, mintMouseX, mintMouseY, e.X - mintMouseX, e.Y - mintMouseY);
                        objGraphics.DrawRectangle(lobjActivePen, mintMouseX, mintMouseY, e.X - mintMouseX, e.Y - mintMouseY);
                        break;
                    case enTool.Ellipse:
                        objGraphics.FillEllipse(lobjActiveBrush, mintMouseX, mintMouseY, e.X - mintMouseX, e.Y - mintMouseY);
                        objGraphics.DrawEllipse(lobjActivePen, mintMouseX, mintMouseY, e.X - mintMouseX, e.Y - mintMouseY);
                        break;
                }
        }

        private void pbCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            tsCursorCoordinations.Text = "x:" + e.X + " y:" + e.Y;


            // place last image on PB
            if (e.Button == MouseButtons.None) return;
            mobjCanvas.Clear(Color.White);
            mobjCanvas.DrawImage(mobjBitmapInMemory, 0, 0);

            // drawing on PB
            GraphicsDraw(mobjCanvas, e);


        }

        private void pbCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            // drawing on memory
            GraphicsDraw(mobjGraphicsInMemory, e);
        }

        private void pbColorSelectRed_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox lobjpictureBox;

            lobjpictureBox = (PictureBox)sender;

            if (e.Button == MouseButtons.Left)
                pbColorBorder.BackColor = lobjpictureBox.BackColor;
            else if (e.Button == MouseButtons.Right)
                pbColorBackground.BackColor = lobjpictureBox.BackColor;

        }

        private void rbLine_Click(object sender, EventArgs e)
        {
            RadioButton lrbTool;

            lrbTool = (RadioButton)sender;

            switch (lrbTool.Text)
            {
                case "Line": memActiveTool = enTool.Line; break;
                case "Rectangle": memActiveTool = enTool.Rectangle; break;
                case "Ellipse": memActiveTool = enTool.Ellipse; break;
                case "Triangle": memActiveTool = enTool.Triangle; break;
                case "Right angle triangle": memActiveTool = enTool.RightAngleTriangle; break;
                case "Curve": memActiveTool = enTool.Curve; break;
            }
        }

        private void tsmEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            mintMouseX = e.X;
            mintMouseY = e.Y;
        }
    }
}