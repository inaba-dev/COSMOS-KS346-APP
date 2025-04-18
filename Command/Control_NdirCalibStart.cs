using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP {

	public class ClassNdirCalibStart {
		public int Result;
		public int CmdResult;
	}

	static public class Control_NdirCalibStart {

		static public bool Start(int calType, int ch, int rtry = 1) {
			while(rtry-- > 0) {
				var writeDatas = CreatePacket(calType);
				List<byte> receivedatas = Common.Sensor.Exec((byte)ClassSensorMain.FuncCode.NDIRセンサ校正開始, ch, writeDatas);

				/// 受信パケット解析
				var rcv = Parse(receivedatas);
				if(rcv != null) return true;
			}
			return false;
		}

		static public ClassNdirCalibStart Parse(List<byte> dataList) {
			if(dataList==null || dataList.Count < 4) return null;       // 実データ保証
			var datas = dataList.Skip(4).ToArray();     // 4バイト目から実データ
			return new ClassNdirCalibStart() {
				Result = datas[0],
				CmdResult = datas[1]
			};
		}

		static public List<byte> CreatePacket(int calType) {
			var dt = DateTime.Now;
			var buf = new Byte[4];
			buf[0] = (byte)calType; // ガス種No 1固定
			buf[1] = (byte)(dt.Year - 2000);
			buf[2] = (byte)dt.Month;
			buf[3] = (byte)dt.Day;
			return buf.ToList();
		}
	}
}
