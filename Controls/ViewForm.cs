using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using RentDB; 
using RentCommon;
using System.Threading;
using RentKrok.Controls;
using RentLibrary;

namespace RentKrok
{
    public partial class ViewForm : Form
    {
        private bool moving = false;

        List<AreaRect> rects = new List<AreaRect>();
      
        Point point1;
        Point point2;

        Bitmap _old;
        Bitmap _new;

        Lazy<DBObject> dbo = new Lazy<DBObject>(); // объект
        Lazy<DBLayer> dbl = new Lazy<DBLayer>(); // слой
        Lazy<DBArea> dba = new Lazy<DBArea>(); // площадь
        Lazy<DBRenter> dbr = new Lazy<DBRenter>(); // арендатор

        public ViewForm()
        {
            InitializeComponent();
        }

        // открытие формы
        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshObjectList();
            RefreshLayerList();
        }
        //добавление слоя
        private void addLayer_Click(object sender, EventArgs e)
        {
            using (InputLayerInfo ili = new InputLayerInfo())
            {
                ili.ShowDialog();
                if (ili.DialogResult == DialogResult.OK)
                {
                    LayerPicture.Image = Image.FromFile(ili.lrNew.FileName);
                    dbl.Value.AddObjectLayer(dgObjects.CurrentRow.DataBoundItem as ObjectRect, ili.lrNew); ;
                }
            }
            RefreshLayerList();
        }
        // добавление объекта
        private void addObject_Click(object sender, EventArgs e)
        {
            //string nameO = Interaction.InputBox("Введите название объекта", "Запрос", "", -1, -1);
            //string addressO = Interaction.InputBox("Введите адрес объекта", "Запрос", "", -1, -1);
            using (InputObjectInfo ioi = new InputObjectInfo())
            {
                ioi.ShowDialog();
                //ObjectRect or = new ObjectRect() { Name = nameO, Address = addressO };
                if (ioi.DialogResult == DialogResult.OK) dbo.Value.AddObject(ioi.orNew);
            }

            RefreshObjectList();

        }
        // добавление площади 
        private void addArea_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выделите необходимую площадь на изображении с помощью мыши.");
            this.LayerPicture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlanePic_MouseDown);
            this.LayerPicture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PlanePic_MouseUp);
            this.LayerPicture.Cursor = System.Windows.Forms.Cursors.Cross;
            // убираем обработку клика
            this.LayerPicture.Click -= new System.EventHandler(this.LayerPicture_Click);
        }
        
        // обновление списка объектов
        private void RefreshObjectList()
        {
           
            dgObjects.DataSource = null;
            dgObjects.DataSource = dbo.Value.GetAllObjects();
            dgObjects.Columns[0].Visible = false;
            dgObjects.Columns[1].HeaderText = "Наименование объекта";
            dgObjects.Columns[1].Width = 180;
            dgObjects.Columns[2].HeaderText = "Адрес объекта";
            dgObjects.Columns[2].Width = 180;
            dgObjects.Columns[3].HeaderText = "Кадастровый номер";
            dgObjects.Columns[3].Width = 150;
            dgObjects.Columns[4].Visible = false;
            dgObjects.Columns[5].Visible = false;
            dgObjects.ClearSelection();
            if (dgObjects.Rows.Count != 0)
            {
                dgObjects.CurrentCell = dgObjects.Rows[0].Cells[1];
            }
            
        }

        // обновление списка слоев
        private void RefreshLayerList()
        {
            dgLayers.DataSource = null;

            if (dgObjects.CurrentRow != null)
            {
                dgLayers.DataSource = dbl.Value.GetLayersOfObject(dgObjects.CurrentRow.DataBoundItem as ObjectRect);
            }

            if (dgLayers.Rows.Count > 0) {
                dgLayers.Columns[0].Visible = false;
                dgLayers.Columns[1].HeaderText = "Наименование слоя";
                dgLayers.Columns[1].Width = 160;
                dgLayers.Columns[2].HeaderText = "Имя файла";
                dgLayers.Columns[2].Width = 200;
                dgLayers.Columns[3].Visible = false;
                dgLayers.Columns[4].Visible = false;
                dgLayers.Columns[5].Visible = false;
                dgLayers.CurrentCell = dgLayers.Rows[0].Cells[1]; 
                LayerPicture.Image = null;
                if ((dgLayers.CurrentRow.DataBoundItem as LayerRect).LayerFile != null)
                LayerPicture.Image = Transform.ByteToImage((dgLayers.CurrentRow.DataBoundItem as LayerRect).LayerFile);
            }
            else { dgLayers.Columns.Clear(); }
            RefreshAreaList();
        }

        // обновление списка площадей
        private void RefreshAreaList()
        {
            dgAreas.DataSource = null;
            if (dgLayers.Rows.Count > 0)
                dgAreas.DataSource = dba.Value.GetLayerAreas(dgLayers.CurrentRow.DataBoundItem as LayerRect);


            if (dgAreas.Rows.Count > 0)
            {
                dgAreas.Columns[0].Visible = false;
                dgAreas.Columns[1].HeaderText = "Наименование помещения";
                dgAreas.Columns[1].Width = 150;
                dgAreas.Columns[2].Visible = false;
                dgAreas.Columns[3].Visible = false;
                dgAreas.Columns[4].Visible = false;
                dgAreas.Columns[5].Visible = false;
                dgAreas.Columns[6].HeaderText = "Площадь";
                dgAreas.Columns[6].Width = 65;
                dgAreas.Columns[7].HeaderText = "Цена";
                dgAreas.Columns[7].Width = 55;
                dgAreas.Columns[8].HeaderText = "Стоимость";
                dgAreas.Columns[8].Width = 75;
                dgAreas.Columns[9].HeaderText = "Аренда";
                dgAreas.Columns[9].Width = 55;
                dgAreas.CurrentCell = dgAreas.Rows[0].Cells[1]; 
            }
            else { dgAreas.Columns.Clear(); }
        }

        // клик на объекте
        private void dgObjects_Click(object sender, EventArgs e)
        {
            RefreshLayerList();
        }

        // клик на списке слоев объекта
        private void dgLayers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LayerPicture.Image = null;
            if ((dgLayers.CurrentRow.DataBoundItem as LayerRect).LayerFile != null)
            LayerPicture.Image = Transform.ByteToImage((dgLayers.CurrentRow.DataBoundItem as LayerRect).LayerFile);

            RefreshAreaList();
        }
        // начало выделения области площади
        private void PlanePic_MouseDown(object sender, MouseEventArgs e)
        {
            // Начальная точка площади
            point1 = e.Location;
            moving = true;
          // _old = new Bitmap(LayerPicture.Width, LayerPicture.Height);
            _old = new Bitmap(LayerPicture.Image);
        }

        // отпускание кнопки мыши - завершение выделения области
        private void PlanePic_MouseUp(object sender, MouseEventArgs e)
        {
            // MessageBox.Show(e.Location.X.ToString(), e.Location.Y.ToString());
            // Конечная точка площади
            point2 = e.Location;

            using (InputAreaInfo iai = new InputAreaInfo())
            {
                //string nameR = Interaction.InputBox("Введите название помещения", "Запрос", "", -1, -1);
                //// площадь
                //string[] square = Interaction.InputBox("Введите через запятую площадь цену и стоимость аренды", "Запрос", "", -1, -1).Split(',');
                //AreaRect orx = new AreaRect() { AreaName = nameR, x1 = point1.X, y1 = point1.Y, x2 = point2.X, y2 = point2.Y,
                //                                Square = Convert.ToInt32(square[0]), Price = Convert.ToInt32(square[1]), Cost = Convert.ToInt32(square[2])
                //};
                iai.ShowDialog();
                if (iai.DialogResult == DialogResult.OK)
                {
                    iai.ar.x1 = point1.X;
                    iai.ar.y1 = point1.Y;
                    iai.ar.x2 = point2.X;
                    iai.ar.y2 = point2.Y;

                    Graphics g = LayerPicture.CreateGraphics();
                    Pen p = new Pen(Color.Blue, 3);
                    Rectangle r = new Rectangle(iai.ar.x1, iai.ar.y1, Math.Abs(iai.ar.x2 - iai.ar.x1), Math.Abs(iai.ar.y2 - iai.ar.y1));
                    g.DrawRectangle(p, r);
                    rects.Add(iai.ar);

                    // Здесь добавим в базу с привязкой к вбранному слою его площади 
                    dba.Value.AddLayerArea(dgLayers.CurrentRow.DataBoundItem as LayerRect, iai.ar);
                    RefreshAreaList();
                    g.Clear(Color.White);
                }
                moving = false;
                LayerPicture.Image = _old;
                
            }


            // Отключаем обработку сообщений
            this.LayerPicture.MouseDown -= new System.Windows.Forms.MouseEventHandler(this.PlanePic_MouseDown);
            this.LayerPicture.MouseUp -= new System.Windows.Forms.MouseEventHandler(this.PlanePic_MouseUp);
            // добавляем обработку клика
            this.LayerPicture.Click += new System.EventHandler(this.LayerPicture_Click);
            this.LayerPicture.Cursor = System.Windows.Forms.Cursors.Default;
        }

        // выделяет в списке площадей кликнутую
        private void LayerPicture_Click(object sender, EventArgs e)
        {
            string area = dba.Value.FindAreaByPoint(dgLayers.CurrentRow.DataBoundItem as LayerRect,
                                      Convert.ToInt32(mPosition.Text.Split(':')[0]),
                                      Convert.ToInt32(mPosition.Text.Split(':')[1]));
            if (area != null)
            {
                DataGridViewRow row = dgAreas.Rows
                  .Cast<DataGridViewRow>()
                  .Where(r => r.Cells["AreaName"].Value.ToString().Equals(area))
                  .FirstOrDefault();
                //if (row != null)
                //{
                    dgAreas.ClearSelection();
                    dgAreas.Rows[row.Index].Selected = true;
                    dgAreas.FirstDisplayedScrollingRowIndex = row.Index;
                //}
            }
            
            // dgAreas.Rows[].Selected = true;
        }

        //трекинг позиции внутри схемы слоя
        private void LayerPicture_MouseMove(object sender, MouseEventArgs e)
        {
            if (!moving)
            {
                mPosition.Text = String.Format(@"{0}:{1}", e.X.ToString(), e.Y.ToString());
            }
            else
            {
                Graphics g = LayerPicture.CreateGraphics();
                _new = new Bitmap(_old);
                LayerPicture.Image = _new;
                Pen p = new Pen(Color.Blue, 3);
                Rectangle r = new Rectangle(point1.X, point1.Y, Math.Abs(e.X - point1.X), Math.Abs(e.Y - point1.Y));
                g = Graphics.FromImage(_new);
                g.DrawRectangle(p, r);
                g.Dispose();
                LayerPicture.Invalidate();
            }
        }

        // Подсвечиваем на 3 сек выбранную площадь и выводит информацию об арендаторе если она есть
        private void dgAreas_Click(object sender, EventArgs e)
        {
            LayerPicture.Invalidate();
            if (dgAreas.CurrentRow != null)
            {
                AreaRect ar = dgAreas.CurrentRow.DataBoundItem as AreaRect;
                var selarea = dba.Value.FindAreaByName(ar.AreaName);
                Graphics g = LayerPicture.CreateGraphics();
                Pen p = new Pen(ar.isRented ? Color.Red : Color.Green, 5);
                Rectangle r = new Rectangle(selarea.x1, selarea.y1, Math.Abs(selarea.x2 - selarea.x1), Math.Abs(selarea.y2 - selarea.y1));
                g.DrawRectangle(p, r);
                Thread.Sleep(3000);
                if (ar.isRented)
                {
                    using InputRenterInfo iri = new InputRenterInfo
                    {
                        rrNew = dba.Value.GetAreaRenter(ar)
                    };
                    iri.ShowDialog();
                }
            }

        }

        private void AddAreaInfo_Click(object sender, EventArgs e)
        {
            //DialogResult result = MessageBox.Show("Ввести нового арендатора?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //if (result == DialogResult.Yes)
            //{
            //    using InputRenterInfo iri = new InputRenterInfo();
            //    iri.ShowDialog();
            //    if (iri.DialogResult == DialogResult.OK)
            //    {
            //        // добавляем самого арендатора?? а если существует уже в базе запрос на создание нового 
            //        dbr.Value.AddRenter(iri.rrNew);
            //        // добавим к текущей площади арендатора
            //        dba.Value.AddRenterToArea(dgAreas.CurrentRow.DataBoundItem as AreaRect, iri.rrNew);
            //    }
            //}
            //else 
            //{
                // форма выбора существующего арендатора
                RenterList rl = new RenterList();
                rl.ShowDialog();
                dba.Value.AddRenterToArea(dgAreas.CurrentRow.DataBoundItem as AreaRect, rl.renterOut);
                MessageBox.Show("Арендатор площади: "+rl.renterOut.RenterName, "Аренда Крок", MessageBoxButtons.OK);
            //}
            RefreshAreaList();
        }
        // редактирование объекта
        private void editObject_Click(object sender, EventArgs e)
        {
            using (InputObjectInfo ioi = new InputObjectInfo() { orNew = dgObjects.CurrentRow.DataBoundItem as ObjectRect })
            {
                ObjectRect old = dgObjects.CurrentRow.DataBoundItem as ObjectRect;
                ioi.ShowDialog();
                if (ioi.DialogResult == DialogResult.OK)
                {
                    dbo.Value.UpdateObject(old, ioi.orNew);
                }
            }
            RefreshObjectList();
        }
        // редактирование слоя
        private void editLayer_Click(object sender, EventArgs e)
        {
            using (InputLayerInfo ili = new InputLayerInfo() { lrNew = dgLayers.CurrentRow.DataBoundItem as LayerRect })
            {
                var old = dgLayers.CurrentRow.DataBoundItem as LayerRect;
                ili.ShowDialog();
                if (ili.DialogResult == DialogResult.OK)
                {
                    dbl.Value.UpdateObjectLayer(old, ili.lrNew);
                }
            }
            RefreshLayerList();
        }

        private void removeObject_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить выбранный объект?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                dbo.Value.RemoveObject(dgObjects.CurrentRow.DataBoundItem as ObjectRect);
            }
            RefreshObjectList();
        }

        private void editArea_Click(object sender, EventArgs e)
        {
            using (InputAreaInfo iai = new InputAreaInfo() { ar = dgAreas.CurrentRow.DataBoundItem as AreaRect })
            {
                var old = dgAreas.CurrentRow.DataBoundItem as AreaRect;
                iai.ShowDialog();
                if (iai.DialogResult == DialogResult.OK)
                {
                    dba.Value.UpdateAreaData(old, iai.ar);
                }
            }
            RefreshLayerList();
        }
    }
}
