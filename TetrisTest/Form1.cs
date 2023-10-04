using System.Drawing.Text;

namespace TetrisTest
{
    public partial class TetrisForm : Form
    {
        public TetrisForm()
        {
            InitializeComponent();

            map = new Bitmap(800, 800);
            graphics = Graphics.FromImage(map);

            test();

        }

        private void test()
        {
           


            GameArea.Image = map;
        }



        private bool[,] pixels = new bool[10, 20];

        private Color[] colors = new Color[8] {Color.Black, Color.Yellow, Color.Orange, Color.Red, Color.Green, Color.Blue, Color.Violet, Color.CadetBlue };


        Bitmap map = new Bitmap(10, 10);

        Graphics graphics;

        Size sizeStndr = new Size(20, 20);

        private void TetrisForm_KeyUp(object sender, KeyEventArgs e)
        {

        }


        private void DrawFigure(int x, int y, byte figure)
        {
            switch (figure)
            {
                case 0:

                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;


            }
        }

        private void DrawPixel(Point point, Color color)
        {
            Rectangle rectangle = new Rectangle(point, sizeStndr);
            Size size = sizeStndr;
            for (int i = 0; size.Width > 0; i++)
            {
                size.Width--;
                size.Height--;
                rectangle = new Rectangle(point, size);
                graphics.DrawRectangle(new Pen(color), rectangle);
            }
        }

        public Point GetPoint(int x, int y)
        {
            return new Point(x * 20, y * 20);
        }


        private void DrawFrame() 
        {
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 20; j++) 
                {
                    if (pixels[i, j]) 
                    {
                        DrawPixel(GetPoint(i, j), Color.Black); 
                    }
                }
        }


        //private void DrawFigureZero() 
        //{

        //}

        //private void DrawFigurePalka(int x, int y, byte orientation)
        //{
        //    Point point = GetPoint(x, y);
        //    for(int i = 0; i < 4; i++)
        //    {
        //        if (orientation == 1) point = GetPoint((int)x, (int)y++);
        //        else point = GetPoint(x++, y);
        //        DrawPixel(point, Color.CadetBlue); 
        //    }
        //}

        //private void DrawFigureCube(int x, int y) 
        //{
        //    Point point = GetPoint(x,y);
        //    DrawPixel(point, Color.Yellow);
        //    point.X += 10;
        //    DrawPixel(point, Color.Yellow);
        //    point.Y += 10;
        //    DrawPixel(point, Color.Yellow);
        //    point.X -= 10;
        //    DrawPixel(point, Color.Yellow);

        //}



    }
}