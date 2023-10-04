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
            colors[0] = GameArea.BackColor;
            DrawFigure(1);

            test();

        }

        Figure currentFigure = new Figure();


        private void test()
        {
            
            OneStep();
            DrawFrame();
            GameArea.Image = map;
        }


        private class Figure
        {

            public byte classs;


            List<Point> pixels = new List<Point>();

            public List<Point> GetPoints() { return this.pixels;}

            public void SetPoints(List<Point> points) { this.pixels = points; }
        }
        

        private byte[,] pixels = new byte[10, 20];




        private Color[] colors = new Color[9] {Color.White ,Color.Black, Color.Yellow, Color.Orange, Color.Red, Color.Green, Color.Blue, Color.Violet, Color.CadetBlue };


        Bitmap map = new Bitmap(10, 10);

        Graphics graphics;

        Size sizeStndr = new Size(20, 20);

        Figure prevPosition = new Figure();

        private byte nextVector = 0;


        private void TetrisForm_KeyUp(object sender, KeyEventArgs e)
        {

        }


        private void OneStep() 
        {
            var prevPosition = this.prevPosition.GetPoints();
            int x = 0;
            int y = 0;
            for (int i = 0; i < prevPosition.Count; i++) 
            {
                x = prevPosition[i].X;
                y = prevPosition[i].Y;
                pixels[x, y] = 0;
            }
            ChangeFigurePositon();
            var curentPosition = this.currentFigure.GetPoints();
            for (int i = 0; i < curentPosition.Count; i++)
            {
                x = curentPosition[i].X;
                y = curentPosition[i].Y;
                pixels[x, y] = currentFigure.classs;
            }
            this.prevPosition = currentFigure;
        }


        private void ChangeFigurePositon() 
        {
            var currentposition = currentFigure.GetPoints();
            for (int i = 0;i < currentFigure.GetPoints().Count; i++) 
            {
                Point point = currentposition[i];
                
                if (nextVector == 1) point.X--;
                if (nextVector == 2) point.X++;
                if (nextVector == 3) point.Y--;
                if (nextVector == 4) point.Y++;

                currentposition[i] = point;
            }
            currentFigure.SetPoints(currentposition);
        }


        private void DrawFigure(byte figure)
        {
            switch (figure)
            {
                case 0:
                    DrawCube();
                    break;
                case 1:
                    DrawStick();
                    break;
                case 2:
                    DrawL();
                    break;
                case 3:
                    DrawT();
                    break;
                case 4:
                    DrawS();
                    break;
                case 5:
                    DrawJ();
                    break;
                case 6:
                    DrawZ();
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
                    
                    
                        DrawPixel(GetPoint(i, j), colors[pixels[i,j]]);
                    
                    
                }
            
        }

        private void DrawCube() 
        {
            List<Point> points = new List<Point>();

            points.Add (new Point(5, 0));
            points.Add(  new Point(5, 1));
            points.Add ( new Point(6, 0));
            points.Add(new Point(6, 1));

            currentFigure.SetPoints(points);
            currentFigure.classs = 2;
        }


        private void DrawStick() 
        {
            List <Point> points = new List<Point>();
            points.Add(new Point(3,0));
            points.Add(new Point(4, 0));
            points.Add(new Point(5, 0));
            points.Add(new Point(6, 0));
            currentFigure.SetPoints (points);
            currentFigure.classs = 8;

        }

        private void DrawJ() 
        {
            List<Point> points = new List<Point>();
            points.Add(new Point(5, 0));
            points.Add(new Point(6, 0));
            points.Add(new Point(7, 0));
            points.Add(new Point(7, 1));
            currentFigure.SetPoints(points);
            currentFigure.classs=7;

        }

        private void DrawL() 
        {
            List<Point> points = new List<Point>();
            points.Add(new Point(5, 0));
            points.Add(new Point(6, 0));
            points.Add(new Point(7, 0));
            points.Add(new Point(5, 1));
            currentFigure.SetPoints(points);
            currentFigure.classs = 3;

        }


        private void DrawS() 
        {
            List<Point> points = new List<Point>();
            points.Add(new Point(5, 0));
            points.Add(new Point(6, 0));
            points.Add(new Point(5, 1));
            points.Add(new Point(4, 1));
            currentFigure.SetPoints(points);
            currentFigure.classs = 4;

        }

        private void DrawZ() 
        {
            List<Point> points = new List<Point>();
            points.Add(new Point(5, 0));
            points.Add(new Point(4, 0));
            points.Add(new Point(5, 1));
            points.Add(new Point(6, 1));
            currentFigure.SetPoints(points);
            currentFigure.classs = 6;

        }

        private void DrawT() 
        {
            List<Point> points = new List<Point>();
            points.Add(new Point(5, 0));
            points.Add(new Point(6, 0));
            points.Add(new Point(7, 0));
            points.Add(new Point(6, 1));
            currentFigure.SetPoints(points);
            currentFigure.classs = 7;

        }

        private void FlipFigure() 
        {
            var points = currentFigure.GetPoints();

            int x = 0, y = 0; 

            for(int i = 0; i < points.Count; i++) 
            {
                Point point = points[i];
                
                x = points[0].X  - points[i].Y;
                y = points[0].Y - points[i].X;

                point.X += x;
                point.Y += y;

                points[i] = point;
            }
            currentFigure.SetPoints(points);

        }


        private void TetrisForm_Load(object sender, EventArgs e)
        {

        }

        private void TetrisForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode) 
            {
                case Keys.Left:
                    nextVector = 1;
                    break;
                case Keys.Right:
                    nextVector = 2;
                    break;
                case Keys.Up:
                    FlipFigure();
                    break;    
                case Keys.Down:
                    nextVector = 4;
                    break;
            }
        }

        private void TetrisForm_KeyUp_1(object sender, KeyEventArgs e)
        {
            test();
        }


        //private void DrawFigureZero()
        //{

        //}

        //private void DrawFigurePalka(int x, int y, byte orientation)
        //{
        //    Point point = GetPoint(x, y);
        //    for (int i = 0; i < 4; i++)
        //    {
        //        if (orientation == 1) point = GetPoint((int)x, (int)y++);
        //        else point = GetPoint(x++, y);
        //        DrawPixel(point, Color.CadetBlue);
        //    }
        //}

        //private void DrawFigureCube(int x, int y)
        //{
        //    Point point = GetPoint(x, y);
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