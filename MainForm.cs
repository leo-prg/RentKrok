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
using RentKrok.DBWork;
using RentKrok.Common;
using System.Threading;

namespace RentKrok
{
    public partial class MainForm : Form
    {

        List<AreaRect> rects = new List<AreaRect>();
        Point point1;
        Point point2;

        Lazy<DBObject> dbo = new Lazy<DBObject>();
        Lazy<DBLayer> dbl = new Lazy<DBLayer>();
        Lazy<DBArea> dba = new Lazy<DBArea>();

        public MainForm()
        {
            InitializeComponent();
        }

    
        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshObjectList();
            RefreshLayerList();
        }

        private void addLayer_Click(object sender, EventArgs e)
        {
            string layerFileName = "";
            using (OpenFileDialog fd = new OpenFileDialog())
            {
                fd.Filter = "Файлы сканов JPEG|*.jpg";
                fd.Title = "Выберите схему слоя объекта";

                if (fd.ShowDialog() == DialogResult.OK)
                {
                    layerFileName = fd.FileName;
                }
                LayerPicture.Image = Image.FromFile(layerFileName);
            }
            string layerName = Interaction.InputBox("Введите название слоя", "Запрос", "", -1, -1);

            dbl.Value.AddObjectLayer(dgObjects.CurrentRow.DataBoundItem as ObjectRect, 
                new LayerRect() { Name = layerName, FileName = layerFileName, LayerFile = Transform.ImageToByte(LayerPicture.Image) }); ;
            RefreshLayerList();
        }

        private void addObject_Click(object sender, EventArgs e)
        {
            string nameO = Interaction.InputBox("Введите название объекта", "Запрос", "", -1, -1);
            string addressO = Interaction.InputBox("Введите адрес объекта", "Запрос", "", -1, -1);
            ObjectRect or = new ObjectRect() { Name = nameO, Address = addressO };

            dbo.Value.AddObject(or);
            RefreshObjectList();
        
        }

        private void RefreshObjectList()
        {
           
            dgObjects.DataSource = null;
            dgObjects.DataSource = dbo.Value.GetAllObjects();
            
            dgObjects.Columns[0].HeaderText = "Наименование объекта";
            dgObjects.Columns[0].Width = 100;
            //dgObjects.Columns[0].DataPropertyName = "Name";
            dgObjects.Columns[1].HeaderText = "Адрес объекта";
            dgObjects.Columns[1].Width = 200;
            //dgObjects.Columns[1].DataPropertyName = "Address";
            //dgObjects.Columns[2].Visible = false;
            //dgObjects.Rows[0].Selected = true;
        }

        private void RefreshLayerList()
        {
            dgLayers.DataSource = null;
            if (dgObjects.Rows.Count > 0) dgLayers.DataSource = dbl.Value.GetLayersOfObject(dgObjects.CurrentRow.DataBoundItem as ObjectRect);
            if (dgLayers.Rows.Count > 0) {
                dgLayers.Columns[0].HeaderText = "Наименование слоя";
                dgLayers.Columns[0].Width = 100;
                dgLayers.Columns[1].HeaderText = "Имя файла";
                dgLayers.Columns[1].Width = 200;
                dgLayers.Columns[2].Visible = false;
                dgLayers.Rows[0].Selected = true;
                LayerPicture.Image = null;
                if ((dgLayers.CurrentRow.DataBoundItem as LayerRect).LayerFile != null)
                LayerPicture.Image = Transform.ByteToImage((dgLayers.CurrentRow.DataBoundItem as LayerRect).LayerFile);
            }
            RefreshAreaList();
        }

        private void RefreshAreaList()
        {
            dgAreas.DataSource = null;
            if (dgLayers.Rows.Count > 0)
                dgAreas.DataSource = dba.Value.GetLayerAreas(dgLayers.CurrentRow.DataBoundItem as LayerRect);
            if (dgAreas.Rows.Count > 0)
            {
                
                dgAreas.Columns[0].HeaderText = "Наименование помешения";
                dgAreas.Columns[0].Width = 180;
                dgAreas.Columns[1].Visible = false;
                dgAreas.Columns[2].Visible = false;
                dgAreas.Columns[3].Visible = false;
                dgAreas.Columns[4].Visible = false;
                dgAreas.Columns[5].HeaderText = "Площадь";
                dgAreas.Columns[5].Width = 50;
                dgAreas.Columns[6].HeaderText = "Цена";
                dgAreas.Columns[6].Width = 50;
                dgAreas.Columns[7].HeaderText = "Стоимость";
                dgAreas.Columns[7].Width = 50;

                dgAreas.Rows[0].Selected = true;
            }
        }

        private void dgObjects_Click(object sender, EventArgs e)
        {
            RefreshLayerList();
        }

        private void dgLayers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LayerPicture.Image = null;
            if ((dgLayers.CurrentRow.DataBoundItem as LayerRect).LayerFile != null)
            LayerPicture.Image = Transform.ByteToImage((dgLayers.CurrentRow.DataBoundItem as LayerRect).LayerFile);
            RefreshAreaList();
        }

        private void AddArea_Click(object sender, EventArgs e)
        {
            this.LayerPicture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlanePic_MouseDown);
            this.LayerPicture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PlanePic_MouseUp);
            this.LayerPicture.Cursor = System.Windows.Forms.Cursors.Cross;
            // убираем обработку клика
            this.LayerPicture.Click -= new System.EventHandler(this.LayerPicture_Click);
        }

        private void PlanePic_MouseDown(object sender, MouseEventArgs e)
        {
            // Начальная точка площади
            point1 = e.Location;
        }

        private void PlanePic_MouseUp(object sender, MouseEventArgs e)
        {
           // MessageBox.Show(e.Location.X.ToString(), e.Location.Y.ToString());
            // Конечная точка площади
            point2 = e.Location;
            string nameR = Interaction.InputBox("Введите название помещения", "Запрос", "", -1, -1);
            // площадь
            string[] square = Interaction.InputBox("Введите через запятую площадь цену и стоимость аренды", "Запрос", "", -1, -1).Split(',');
            AreaRect orx = new AreaRect() { AreaName = nameR, x1 = point1.X, y1 = point1.Y, x2 = point2.X, y2 = point2.Y,
                                            Square = Convert.ToInt32(square[0]), Price = Convert.ToInt32(square[1]), Cost = Convert.ToInt32(square[2])
            };

            Graphics g = LayerPicture.CreateGraphics();
            Pen p = new Pen(Color.Red, 3);
            Rectangle r = new Rectangle(orx.x1, orx.y1, Math.Abs(orx.x2 - orx.x1), Math.Abs(orx.y2 - orx.y1));
            g.DrawRectangle(p, r);
            rects.Add(orx);

            // Здесь добавим в базу с привязкой к вбранному слою его площади 
            dba.Value.AddLayerArea(dgLayers.CurrentRow.DataBoundItem as LayerRect, orx);
            RefreshAreaList();
            // Отключаем обработку сообщений
            this.LayerPicture.MouseDown -= new System.Windows.Forms.MouseEventHandler(this.PlanePic_MouseDown);
            this.LayerPicture.MouseUp -= new System.Windows.Forms.MouseEventHandler(this.PlanePic_MouseUp);
            // добавляем обработку клика
            this.LayerPicture.Click += new System.EventHandler(this.LayerPicture_Click);

            this.LayerPicture.Cursor = System.Windows.Forms.Cursors.Default;
        }

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
            mPosition.Text = String.Format(@"{0}:{1}",e.X.ToString(), e.Y.ToString());
        }

        // Подсвечиваем на 3 сек выбранную площадь
        private void dgAreas_Click(object sender, EventArgs e)
        {
            LayerPicture.Invalidate();
            if (dgAreas.CurrentRow != null)
            {
                var selarea = dba.Value.FindAreaByName((dgAreas.CurrentRow.DataBoundItem as AreaRect).AreaName);
                Graphics g = LayerPicture.CreateGraphics();
                Pen p = new Pen(Color.Blue, 5);
                Rectangle r = new Rectangle(selarea.x1, selarea.y1, Math.Abs(selarea.x2 - selarea.x1), Math.Abs(selarea.y2 - selarea.y1));
                g.DrawRectangle(p, r);
                Thread.Sleep(1000);
            }
        }
    }
}
