using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP
{
    public partial class UserControlChart : UserControl
    {
        //データ数
        private const int DEF_CHART_POINT = 100;

        private List<DataClass> DataArray = new List<DataClass>();

        private class DataClass
        {
            public UInt32[] sensor = new UInt32[8];
        }

        public UserControlChart()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 初期値
        /// </summary>

        public void Initialization()
        {
            DataArray.Clear();

            DataClass data = new DataClass();

            data.sensor = (Enumerable.Range(0, 8).Select(x => (UInt32)0).ToArray());

            for (int i = 0; i < DEF_CHART_POINT; i++)
            {
                DataArray.Add(data);
            }
        }

        /// <summary>
        /// グラフ更新
        /// </summary>

        public void GraphPlot()
        {
            {
                while (true)
                {
                    //サイズが規定数まで達してなければBreak
                    if (DataArray.Count < DEF_CHART_POINT) break;

                    //先頭のデータを削除
                    DataArray.RemoveAt(0);
                }

                DataClass _data = new DataClass();

                ///データを最後尾に追加

                _data.sensor[0] = Common.Sensor.CurrentStatus[0].GasConc;
                _data.sensor[1] = Common.Sensor.CurrentStatus[1].GasConc;
                _data.sensor[2] = Common.Sensor.CurrentStatus[2].GasConc;
                _data.sensor[3] = Common.Sensor.CurrentStatus[3].GasConc;
                _data.sensor[4] = Common.Sensor.CurrentStatus[4].GasConc;
                _data.sensor[5] = Common.Sensor.CurrentStatus[5].GasConc;
                _data.sensor[6] = Common.Sensor.CurrentStatus[6].GasConc;
                _data.sensor[7] = Common.Sensor.CurrentStatus[7].GasConc;

                DataArray.Add(_data);

                ///グラフクリア

                for (int i = 0; i < _data.sensor.Count(); i++)
                {
                    chartSensor.Series[i].Points.Clear();
                }

                ///グラフ描画

                for (int i = 0; i < _data.sensor.Count(); i++)
                {
                    for (int index = 0; index < DataArray.Count(); index++)
                    {
                        chartSensor.Series[i].Points.Add(DataArray[index].sensor[i]);
                    }
                }
            }
        }
    }
}
