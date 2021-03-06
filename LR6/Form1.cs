using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace LR6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;            
        }
        class Figure   //базовый класс
        {
            protected Color color = Color.White;
            
            virtual public bool isClicked(MouseEventArgs e)
            {
                return true;
            }
            virtual public void Draw(Panel panel1, Graphics g)
            {
            }
            virtual public void DoCheckTrue()
            {
            }
            virtual public void DoCheckFalse()
            {
            }
            virtual public bool isChecked()
            {
                return true;
            }
            virtual public void Move(KeyEventArgs e)
            {
            }
            virtual public void ChangeSize(KeyEventArgs e)
            {
            }
            virtual public void ChangeColor(int color)
            {
            }            
            virtual public void Save(StreamWriter file)
            {
            }
            virtual public void Load(StreamReader file)
            {
            }            
            virtual public int getCount()
            {
                return 1;
            }            
            public int x, y, r;
        }

        class CCircle : Figure   //класс круга
        {
            private bool Checked;
            private Pen pen;
            private SolidBrush brush;
            public CCircle(int x, int y, int r)
            {
                this.x = x;
                this.y = y;
                this.r = r;
                Checked = false;
                brush = new SolidBrush(Color.White);
            }
            override public bool isClicked(MouseEventArgs e)
            {
                if (((e.X - x) * (e.X - x) + (e.Y - y) * (e.Y - y)) <= r * r)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public override void Draw(Panel panel1, Graphics g)
            {
                Rectangle rect = new Rectangle(x - r, y - r, r * 2, r * 2);
                if (Checked == true)
                {                    
                    pen = new Pen(Color.Yellow, 4);
                }
                else
                {
                    pen = new Pen(Color.Black);
                }
                brush.Color = color;
                g.FillEllipse(brush, rect);
                g.DrawEllipse(pen, rect);
            }
            override public void DoCheckTrue()
            {
                Checked = true;
            }
            override public void DoCheckFalse()
            {
                Checked = false;
            }
            override public bool isChecked()
            {
                return Checked;
            }
           
            override public void Move(KeyEventArgs e)
            {
                if (e.KeyCode == Keys.A)
                {
                    x = x - 5;
                }
                if (e.KeyCode == Keys.D)
                {
                    x = x + 5;
                }
                if (e.KeyCode == Keys.W)
                {
                    y = y - 5;
                }
                if (e.KeyCode == Keys.S)
                {
                    y = y + 5;
                }
            }

            public override void ChangeSize(KeyEventArgs e)
            {
                if (e.KeyValue == 187)
                {
                    r = r + 5;
                }
                if (e.KeyValue == 189)
                {
                    r = r - 5;
                }
            }
            public override void ChangeColor(int col)
            {
                switch (col)
                {
                    case 1:                        
                        color = Color.Black;
                        break;
                    case 2:                        
                        color = Color.Blue;
                        break;
                    case 3:                        
                        color = Color.Red;
                        break;
                }

            }
            public override void Save(StreamWriter file)
            {                
                file.WriteLine("CCircle");
                file.WriteLine(x);
                file.WriteLine(y);
                file.WriteLine(r);                
                file.WriteLine(color.ToKnownColor());
            }
            public override void Load(StreamReader file)
            {
                x = Convert.ToInt32(file.ReadLine());
                y = Convert.ToInt32(file.ReadLine());
                r = Convert.ToInt32(file.ReadLine());                
                color = Color.FromName(file.ReadLine());
            }
            
        }

        class Square : Figure    //класс квадрата 
        {            
            private bool Checked;
            private SolidBrush brush;
            private Pen pen;
            public Square(int x, int y, int r)
            {
                this.x = x;
                this.y = y;
                this.r = r;
                Checked = false;
                brush = new SolidBrush(Color.White);
            }
            override public bool isClicked(MouseEventArgs e)
            {
                if (e.X >= x - r && e.Y >= y - r && e.X <= x + r && e.Y <= y + r)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public override void Draw(Panel panel1, Graphics g)
            {
                Rectangle rect = new Rectangle(x - r, y - r, r * 2, r * 2);
                if (Checked == true)
                {
                    pen = new Pen(Color.Yellow, 4);
                }
                else
                {
                    pen = new Pen(Color.Black);
                }
                brush.Color = color;
                g.FillRectangle(brush, rect);
                g.DrawRectangle(pen, rect);
                
            }            
            override public void Move(KeyEventArgs e)
            {
                if (e.KeyCode == Keys.A)
                {
                    x = x - 5;
                }
                if (e.KeyCode == Keys.D)
                {
                    x = x + 5;
                }
                if (e.KeyCode == Keys.W)
                {
                    y = y - 5;
                }
                if (e.KeyCode == Keys.S)
                {
                    y = y + 5;
                }
            }
            public override void Save(StreamWriter file)
            {
                file.WriteLine("Square");
                file.WriteLine(x);
                file.WriteLine(y);
                file.WriteLine(r);                
                file.WriteLine(color.ToKnownColor());
            }
            public override void Load(StreamReader file)
            {
                x = Convert.ToInt32(file.ReadLine());
                y = Convert.ToInt32(file.ReadLine());
                r = Convert.ToInt32(file.ReadLine());                
                color = Color.FromName(file.ReadLine());
            }            
            override public void DoCheckTrue()
            {
                Checked = true;
            }
            override public void DoCheckFalse()
            {
                Checked = false;
            }
            override public bool isChecked()
            {
                return Checked;
            }

            public override void ChangeSize(KeyEventArgs e)
            {
                if (e.KeyValue == 187)
                {
                    r = r + 5;
                }
                if (e.KeyValue == 189)
                {
                    r = r - 5;
                }
            }
            public override void ChangeColor(int col)
            {
                switch (col)
                {
                    case 1:                        
                        color = Color.Black;
                        break;
                    case 2:                        
                        color = Color.Blue;
                        break;
                    case 3:                        
                        color = Color.Red;
                        break;
                }
            }
        }

        class Triangle : Figure   //класс треугольника
        {
            private Point[] p;
            private bool Checked;           
            private SolidBrush brush;
            private Pen pen;
            public Triangle(int x, int y, int r)
            {
                p = new Point[3];
                p[0].X = x;
                p[0].Y = y - r;
                p[1].X = x;
                p[1].Y = y + r;
                p[2].X = x + r * 2;
                p[2].Y = y + r;
                Checked = false;
                this.r = r;
                this.x = x;
                this.y = y;
                brush = new SolidBrush(Color.White);
            }
            override public bool isClicked(MouseEventArgs e)
            {
                int a = (p[0].X - e.X) * (p[1].Y - p[0].Y) - (p[1].X - p[0].X) * (p[0].Y - e.Y);
                int b = (p[1].X - e.X) * (p[2].Y - p[1].Y) - (p[2].X - p[1].X) * (p[1].Y - e.Y);
                int c = (p[2].X - e.X) * (p[0].Y - p[2].Y) - (p[0].X - p[2].X) * (p[2].Y - e.Y);
                if ((a >= 0 && b >= 0 && c >= 0) || (a <= 0 && b <= 0 && c <= 0))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public override void Draw(Panel panel1, Graphics g)
            {
                if (Checked == true)
                {
                    pen = new Pen(Color.Yellow, 4);
                }
                else
                {
                    pen = new Pen(Color.Black);
                }
                brush.Color = color;               
                g.FillPolygon(brush, p);
                g.DrawPolygon(pen, p);
                
            }
            override public void DoCheckTrue()
            {
                Checked = true;
            }
            override public void DoCheckFalse()
            {
                Checked = false;
            }
            override public bool isChecked()
            {
                return Checked;
            }
            public override void Move(KeyEventArgs e)
            {
                if (e.KeyCode == Keys.W)
                {
                    p[0].Y = p[0].Y - 5;
                    p[1].Y = p[1].Y - 5;
                    p[2].Y = p[2].Y - 5;
                }
                if (e.KeyCode == Keys.S)
                {
                    p[0].Y = p[0].Y + 5;
                    p[1].Y = p[1].Y + 5;
                    p[2].Y = p[2].Y + 5;
                }
                if (e.KeyCode == Keys.A)
                {
                    p[0].X = p[0].X - 5;
                    p[1].X = p[1].X - 5;
                    p[2].X = p[2].X - 5;
                }
                if (e.KeyCode == Keys.D)
                {
                    p[0].X = p[0].X + 5;
                    p[1].X = p[1].X + 5;
                    p[2].X = p[2].X + 5;
                }
            }
            public override void ChangeSize(KeyEventArgs e)
            {
                if (e.KeyValue == 187)
                {
                    p[0].X = p[0].X;
                    p[0].Y = p[0].Y - 3;
                    p[1].X = p[1].X;
                    p[1].Y = p[1].Y + 3;
                    p[2].X = p[2].X + 6;
                    p[2].Y = p[2].Y + 3;
                }
                if (e.KeyValue == 189)
                {
                    p[0].X = p[0].X;
                    p[0].Y = p[0].Y + 3;
                    p[1].X = p[1].X;
                    p[1].Y = p[1].Y - 3;
                    p[2].X = p[2].X - 6;
                    p[2].Y = p[2].Y - 3;
                }
            }
            public override void ChangeColor(int col)
            {
                switch (col)
                {
                    case 1:                        
                        color = Color.Black;
                        break;
                    case 2:                        
                        color = Color.Blue;
                        break;
                    case 3:
                        color = Color.Red;
                        break;
                }
            }
            public override void Save(StreamWriter file)
            {
                file.WriteLine("Triangle");
                file.WriteLine(p[0].X);
                file.WriteLine(p[0].Y);
                file.WriteLine(p[1].X);
                file.WriteLine(p[1].Y);
                file.WriteLine(p[2].X);
                file.WriteLine(p[2].Y);
                file.WriteLine(x);
                file.WriteLine(y);
                file.WriteLine(r);                
                file.WriteLine(color.ToKnownColor());
            }
            public override void Load(StreamReader file)
            {
                p[0].X = Convert.ToInt32(file.ReadLine());
                p[0].Y = Convert.ToInt32(file.ReadLine());
                p[1].X = Convert.ToInt32(file.ReadLine());
                p[1].Y = Convert.ToInt32(file.ReadLine());
                p[2].X = Convert.ToInt32(file.ReadLine());
                p[2].Y = Convert.ToInt32(file.ReadLine());
                x = Convert.ToInt32(file.ReadLine());
                y = Convert.ToInt32(file.ReadLine());
                r = Convert.ToInt32(file.ReadLine());               
                color = Color.FromName(file.ReadLine());
            }
        }
        class Factory
        {
            public Figure createShape(string name)
            {
                Figure obj = null;
                switch (name)
                {
                    case "CCircle":
                        obj = new CCircle(0, 0, 0);
                        break;
                    case "Square":
                        obj = new Square(0, 0, 0);
                        break;
                    case "CGroup":
                        obj = new CGroup(0);
                        break;
                    case "Triangle":
                        obj = new Triangle(0, 0, 0);
                        break;
                    default:
                        break;
                }
                return obj;
            }
        }

        class MyStorage
        {
            private int size;
            public Figure[] storage;           
            public MyStorage()
            {
                size = 0;
            }
            public MyStorage(int size)
            {
                this.size = size;
                storage = new Figure[size];
            }
            public void SetObjects(int index, Figure obj)
            {
                storage[index] = obj;
            }
            public void AddObject(Figure obj)
            {
                Figure[] new_storage = new Figure[size + 1];
                for (int i = 0; i < size; i++)
                {
                    new_storage[i] = storage[i];
                }
                storage = new_storage;
                storage[size] = obj;
                size = size + 1;
            }
            public void DeleteObject(int index)
            {
                Figure[] new_storage = new Figure[size - 1];
                for (int i = 0; i < index; i++)
                {
                    new_storage[i] = storage[i];
                }
                for (int i = index; i < size - 1; i++)
                {
                    new_storage[i] = storage[i + 1];
                }
                size = size - 1;
                storage = new_storage;
            }            
            public bool isCheckedStorage(MouseEventArgs e)
            {
                int k = 0;
                for (int i = 0; i < size; i++)
                {
                    if (storage[i].isClicked(e) == true)
                    {
                        storage[i].DoCheckTrue();
                        k++;
                    }
                    if (i == size - 1 && k != 0)                        // для выделения нескольких фигур, если они заходят друг на друга               
                    {
                        return true;
                    }
                }
                return false;
            }
            public void DeleteCheckObject(MyStorage storage)
            {
                for (int i = 0; i < size; i++)
                {
                    if (this.storage[i].isChecked() == true)
                    {
                        storage.DeleteObject(i);
                        i = i - 1;
                    }
                }
            }
            public void NotChecked()
            {
                for (int i = 0; i < size; i++)
                {
                    storage[i].DoCheckFalse();
                }
            }
            public void Draw(Panel panel1, Graphics g)
            {
                for (int i = 0; i < size; i++)
                {
                    storage[i].Draw(panel1, g);
                }
            }
            public void Move(KeyEventArgs e)
            {
                for (int i = 0; i < size; i++)
                {
                    if (storage[i].isChecked() == true)
                    {                        
                        storage[i].Move(e);
                    }
                }
            }

            public void ChangeSize(KeyEventArgs e)
            {
                for (int i = 0; i < size; i++)
                {
                    if (storage[i].isChecked() == true)
                    {
                        storage[i].ChangeSize(e);
                    }
                }
            }
            public void ChangeColor(int col)
            {
                for (int i = 0; i < size; i++)
                {
                    if (storage[i].isChecked() == true)
                    {
                        storage[i].ChangeColor(col);
                    }
                }
            }
            
            public void createGroup()
            {
                int count = 0;
                for (int i = 0; i < size; i++)
                {
                    if (storage[i].isChecked() == true)
                        count++;
                }
                if (count >= 2)
                {
                    CGroup group = new CGroup(count);
                    for (int i = size - 1; i >= 0; i--)
                    {
                        if (storage[i].isChecked() == true)
                        {
                            group.addShape(storage[i]);           
                            DeleteObject(i);
                        }
                    }
                    AddObject(group);                            
                }

            }


            public void deleteGroup()
            {
                for (int i = size - 1; i >= 0; i--)
                {
                    if (storage[i] is CGroup && storage[i].isChecked())     
                    {
                        CGroup group = (CGroup)storage[i];
                        for (int j = group.getCount() - 1; j >= 0; j--)
                        {
                            AddObject(group._figures[j]);                 
                        }
                        DeleteObject(i);                                  
                    }
                }
            }

            public void saveAll()
            {
                string way = @"D:\угат\2\3 СЕМ\ООП\LR6\LR6\bin\Debug\save.txt";
                StreamWriter file = new StreamWriter(way, false);
                file.WriteLine(size);
                for (int i = 0; i < size; i++)
                {
                    storage[i].Save(file);
                }
                file.Close();
            }

            public void loadAll()
            {
                string way = @"D:\угат\2\3 СЕМ\ООП\LR6\LR6\bin\Debug\save.txt";
                Factory factory = new Factory();
                StreamReader file = new StreamReader(way);
                int count = Convert.ToInt32(file.ReadLine());
                string name;
                for (int i = 0; i < count; i++)
                {                    
                    name = file.ReadLine();
                    AddObject(factory.createShape(name));                 
                    if (storage[i] != null)
                    {
                        storage[i].Load(file);
                    }
                }
                file.Close();
            }                       
            

        }

        class CGroup : Figure
        {
            private int _count;
            private int _maxcount;
            public Figure[] _figures;

            private bool Checked;

            public CGroup(int maxcount)
            {
                Checked = true;
                _maxcount = maxcount; _count = 0;
                _figures = new Figure[_maxcount];
            }
            
            public bool addShape(Figure obj)
            {                
                _count++;
                _figures[_count - 1] = obj;
                return true;
            }

            public override void Move(KeyEventArgs e)
            {
                for (int i = 0; i < _count; i++)
                {
                    _figures[i].Move(e);
                }

            }
            public override void DoCheckFalse()
            {
                Checked = false;
                for (int i = 0; i < _count; i++)
                {
                    _figures[i].DoCheckFalse();
                }

            }
            public override void Draw(Panel panel1, Graphics g)
            {
                for (int i = 0; i < _count; i++)
                {
                    _figures[i].Draw(panel1, g);
                }
            }

            public override void ChangeSize(KeyEventArgs e)
            {
                for (int i = 0; i < _count; i++)
                {
                    _figures[i].ChangeSize(e);
                }
            }

            public override void DoCheckTrue()
            {
                for (int i = 0; i < _count; i++)
                {
                    _figures[i].DoCheckTrue();
                }
            }


            public override bool isClicked(MouseEventArgs e)
            {
                for (int i = 0; i < _count; i++)
                {
                    if (_figures[i].isClicked(e) == true)
                    {
                        Checked = true;
                        return true;
                    }
                }
                return false;
            }

            public override bool isChecked()
            {
                return Checked;
            }

            public override void ChangeColor(int col)
            {
                for (int i = 0; i < _count; i++)
                {
                    _figures[i].ChangeColor(col);
                }
            }

            public override int getCount()
            {
                return _count;
            }                    

            public override void Save(StreamWriter file)
            {
                file.WriteLine("CGroup");
                file.WriteLine(_count);
                for (int i = 0; i < _count; i++)
                {
                    _figures[i].Save(file);
                }
            }

            public override void Load(StreamReader file)
            {
                _maxcount = Convert.ToInt32(file.ReadLine());
                _count = 0;
                string name;
                Factory factory = new Factory();
                _figures = new Figure[_maxcount];
                for (int i = 0; i < _maxcount; i++)
                {
                    name = file.ReadLine();
                    addShape(factory.createShape(name));
                    _figures[i].Load(file);
                }
            }
            
        }

        MyStorage storage = new MyStorage();
        int figure;
        int col;

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panel2.CreateGraphics();
            storage.Draw(panel2, g);
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            if (storage.isCheckedStorage(e) == false)
            {
                storage.NotChecked();
                switch (figure)
                {
                    case 1:
                        CCircle ellipse = new CCircle(e.X, e.Y, 45);
                        storage.AddObject(ellipse);
                        break;
                    case 2:
                        Square square = new Square(e.X, e.Y, 45);
                        storage.AddObject(square);
                        break;
                    case 3:
                        Triangle triangle = new Triangle(e.X, e.Y, 45);
                        storage.AddObject(triangle);
                        break;
                }
            }
            else
            {
                if (Control.ModifierKeys == Keys.Control)
                {
                    storage.isCheckedStorage(e);
                }
                else
                {
                    storage.NotChecked();
                    storage.isCheckedStorage(e);                    
                }
            }            
            Refresh();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {            
            if (e.KeyValue == 46)
            {
                storage.DeleteCheckObject(storage);               
            }
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.S || e.KeyCode == Keys.D || e.KeyCode == Keys.A)
            {
                storage.Move(e);
            }
            if (e.KeyValue == 187 || e.KeyValue == 189)
            {               
                storage.ChangeSize(e);
            }
            Refresh();
        }

        private void pbSquare_Click(object sender, EventArgs e)
        {
            figure = 2;
        }

        private void pbCircle_Click(object sender, EventArgs e)
        {
            figure = 1;
        }

        private void pbTriangle_Click(object sender, EventArgs e)
        {
            figure = 3;
        }

        private void pbBlack_Click(object sender, EventArgs e)
        {
            col = 1;
        }

        private void pbBlue_Click(object sender, EventArgs e)
        {
            col = 2;
        }

        private void pbRed_Click(object sender, EventArgs e)
        {
            col = 3;
        }
              

        private void btn_ungroop_Click(object sender, EventArgs e)
        {
            storage.deleteGroup();            
        }
        Random rnd = new Random();


        //-----------------------------------------------------

        private int GetRandomCheck()
        {
            //Создание объекта для генерации чисел (с указанием начального значения)
            

            //Получить случайное число 
            int value = rnd.Next(4, 8);

            //Вернуть полученное значение
            return value;
        }

        private int GetRandomItem()
        {
            //Создание объекта для генерации чисел (с указанием начального значения)


            //Получить случайное число 
            int value = rnd.Next(1, 16);

            //Вернуть полученное значение
            return value;
        }
        private string GetName()
        {
            string name = "";
            int rand = GetRandomItem();
            switch (rand)
            {
                case 1:
                    name = "Куртка";
                    break;
                case 2:
                    name = "Толстовка";
                    break;
                case 3:
                    name = "Брюки";
                    break;
                case 4:
                    name = "Футболка";
                    break;
                case 5:
                    name = "Ботинки";
                    break;
                case 6:
                    name = "Шлепанцы";
                    break;
                case 7:
                    name = "Шапка";
                    break;
                case 8:
                    name = "Перчатки";
                    break;
                case 9:
                    name = "Сумка";
                    break;
                case 10:
                    name = "Носки";
                    break;
                case 11:
                    name = "Горные лыжи";
                    break;
                case 12:
                    name = "Беговые лыжи";
                    break;
                case 13:
                    name = "Беговая дорожка";
                    break;
                case 14:
                    name = "Фитнес аксессуары";
                    break;
                case 15:
                    name = "Кроссовки";
                    break;
                case 16:
                    name = "Термобелье";
                    break;
                default:
                    break;
            }

            return name;
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            //storage.saveAll();
            string way = @"D:\угат\2\3 СЕМ\ООП\LR6\LR6\bin\Debug\save2.txt";
            string way1 = @"D:\угат\2\3 СЕМ\ООП\LR6\LR6\bin\Debug\save3.txt";
            StreamWriter file = new StreamWriter(way, false, System.Text.Encoding.GetEncoding(1251));
            StreamWriter file1 = new StreamWriter(way1, false); // utf

            file.WriteLine("ID;ITEM");
            file1.WriteLine("ID;ITEM");
            //int rand = GetRandom();
            int ran = 50000;
            int k = 0;
           
            bool alreadyThere;
            while (k <= 6500)
            {               
                int rand = GetRandomCheck();
                string[] a = new string[rand];
                for (int i = 0; i < rand; i++)
                {

                    alreadyThere = false;                                       
                    string newRanomValue = GetName();
                    for (int j = 0; j < i; j++)
                    {
                        if (a[j] == newRanomValue)
                        {
                            alreadyThere = true;
                            break;
                        }
                    }

                    if (!alreadyThere)
                    {
                        a[i] = newRanomValue;                        
                        i++;                        
                    }
                                      
                    k++;
                }
                for (int l = 0; l < rand; l++)
                {
                    if (a[l] != null) {
                    file.Write("SO");
                    file.Write(ran);
                    file.Write(";");
                    file.WriteLine(a[l]);
                        file1.Write("SO");
                        file1.Write(ran);
                        file1.Write(";");
                        file1.WriteLine(a[l]);
                    }
                }
                
                ran = ran + 4;                
            }

            file.Close();
        }


        // ----------------------------------------------------
        private void btn_load_Click(object sender, EventArgs e)
        {
            storage.loadAll();            
            Refresh();
        }

        private void btn_groop_Click(object sender, EventArgs e)
        {
            storage.createGroup();            
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (col == 1 || col == 2 || col == 3)
            {
                storage.ChangeColor(col);
            }
            Refresh();
        }
    }
}
