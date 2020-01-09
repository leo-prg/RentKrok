using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.ToolTips;
using GMap.NET.WindowsForms.Markers;
using System.Net;
using RentDB;

namespace RentKrok.Controls
{
    public partial class MapControl : UserControl
    {

        private static MapControl _instance;

        //// Pattern Singleton
        public static MapControl GetInstance()
        {
            return _instance ?? (_instance = new MapControl());
        }

        public MapControl()
        {
            InitializeComponent();
        }

        private void gMapControl_Load(object sender, EventArgs e)
        {
       
        }

        private void MapControl_Load(object sender, EventArgs e)
        {
          
        }

        private void MapControl_Enter(object sender, EventArgs e)
        {
            //Настройки для компонента GMap.
            gMapControl.Bearing = 0;
            //CanDragMap - Если параметр установлен в True,
            //пользователь может перетаскивать карту 
            ///с помощью правой кнопки мыши. 
            gMapControl.CanDragMap = true;
            //Указываем, что перетаскивание карты осуществляется 
            //с использованием левой клавишей мыши.
            //По умолчанию - правая.
            gMapControl.DragButton = MouseButtons.Left;
            gMapControl.GrayScaleMode = true;
            //MarkersEnabled - Если параметр установлен в True,
            //любые маркеры, заданные вручную будет показаны.
            //Если нет, они не появятся.
            gMapControl.MarkersEnabled = true;
            gMapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            //Отказываемся от негативного режима.
            gMapControl.NegativeMode = false;
            //Разрешаем полигоны.
            gMapControl.PolygonsEnabled = true;
            //Разрешаем маршруты
            gMapControl.RoutesEnabled = true;
            //Скрываем внешнюю сетку карты
            //с заголовками.
            gMapControl.ShowTileGridLines = false;
            //Указываем, что при загрузке карты будет использоваться 
            //18ти кратное приближение.
            gMapControl.Zoom = 5;
            //Указываем что все края элемента управления
            //закрепляются у краев содержащего его элемента
            //управления(главной формы), а их размеры изменяются 
            //соответствующим образом.
            gMapControl.Dock = DockStyle.Fill;
            //Указываем что будем использовать карты Google.
            gMapControl.MapProvider = GMap.NET.MapProviders.GMapProviders.OpenStreetMap;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;

            Lazy<DBObject> dbo = new Lazy<DBObject>(); // объект 

            var map_obj = dbo.Value.GetAllObjects();

            GMapOverlay markersOverlay = new GMapOverlay("markers");

            foreach (var mo in map_obj)
            {
                var status = gMapControl.SetPositionByKeywords(mo.Address);
                if (status != GeoCoderStatusCode.OK)
                {
                    MessageBox.Show("Geocoder can't find selected place!", "GMap.NET", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                GMarkerGoogle marker = new GMarkerGoogle(gMapControl.Position, GMarkerGoogleType.green);
                marker.ToolTip = new GMapToolTip(marker);
                marker.ToolTipMode = MarkerTooltipMode.Always;
                marker.ToolTipText = mo.Name;
                markersOverlay.Markers.Add(marker);
            }

            gMapControl.Overlays.Add(markersOverlay);


            gMapControl.MinZoom = 0;
            gMapControl.MaxZoom = 24;
            gMapControl.Zoom = 12;
        }
    }
}
