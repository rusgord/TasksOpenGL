using System;
using System.Drawing;
using System.Security.Policy;
using System.Windows.Forms;
using static Task02.OpenGL;


namespace Task02
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OnChangeHorizontal(object sender, System.EventArgs e)
        {
            int horizontales = (int)horizontalUD.Value;
            int verticales = (int)verticalUD.Value;
            renderControl1.Horizontales = horizontales;
            renderControl1.Verticales = verticales;
            renderControl1.Invalidate();
        }

        private void OnChangeVertical(object sender, System.EventArgs e)
        {
            int horizontales = (int)horizontalUD.Value;
            int verticales = (int)verticalUD.Value;
            renderControl1.Horizontales = horizontales;
            renderControl1.Verticales = verticales;
            renderControl1.Invalidate();
        }

        private void OnFillModeCheckedChanged(object sender, System.EventArgs e)
        {
            if (fillModeRB.Checked)
            {
                renderControl1.DrawingMode = DrawingMode.Fill;
                renderControl1.Invalidate();
            }
        }

        private void OnLineModeCheckedChanged(object sender, System.EventArgs e)
        {
            if (lineModeRB.Checked)
            {
                renderControl1.DrawingMode = DrawingMode.Line;
                renderControl1.Invalidate();
            }
        }

        private void OnPointModeCheckedChanged(object sender, System.EventArgs e)
        {
            if (pointModeRB.Checked)
            {
                renderControl1.DrawingMode = DrawingMode.Point;
                renderControl1.Invalidate();
            }
        }
    }
}

//private void OnClick(object sender, MouseEventArgs e)
//{
//    double sizeX = renderControl1.ClientRectangle.Right;
//    double sizeY = renderControl1.ClientRectangle.Bottom;
//    double size = Math.Min(sizeX, sizeY);

//    //double trueY = sizeY - e.Y;
//    //double trueX = (e.X / (sizeX - ((sizeX - sizeY) / 2))) * size;
//    //double spacing = (size / 2) * 0.05;

//    //for (int i = 0; i < 3; i++)
//    //{
//    //    double x = size - i * (size * 0.05 + spacing) - size * 0.05; 
//    //    double y = size - (size * 0.025);

//    //    if (trueX >= x && trueX <= x + (size * 0.05) && trueY >= y && trueY <= y + (size * 0.025))
//    //    {
//    //        renderControl1.DrawingMode = (DrawingMode)i;
//    //        renderControl1.Invalidate();
//    //        break;
//    //    }
//    //}
//    double trueY = sizeY - e.Y;
//    //double trueX = (e.X / (sizeX - ((sizeX - sizeY) / 2))) * size;

//    double buttonWidth = size * 0.05;
//    double buttonHeight = size * 0.025;
//    double spacing = (sizeX / 2) * 0.05;
//    for (int i = 0; i < 3; i++)
//    {
//        double x = sizeY - i * (buttonWidth + spacing) - buttonWidth;
//        double y = sizeY - buttonHeight;

//        if (e.X >= x && e.X <= x + buttonWidth && trueY >= y && trueY <= y + buttonHeight)
//        {
//            renderControl1.DrawingMode = (DrawingMode)i; 
//            renderControl1.Invalidate(); 
//            break; 
//        }
//    }
//}