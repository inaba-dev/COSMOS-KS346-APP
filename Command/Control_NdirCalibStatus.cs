using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP {

	public class ClassNdirCalibStatus {
		public int Result;
		public int CalibStatus;
		public int error;
	}

	static public class Control_NdirCalibStatus {

		static public ClassNdirCalibStatus Get(int ch, int rtry = 1) {

			while(rtry-- > 0) {
				var writeDatas = CreatePacket();
				List<byte> receivedatas = Common.Sensor.Exec((byte)ClassSensorMain.FuncCode.NDIRセンサ校正状態取得, ch, writeDatas);

				/// 受信パケット解析
				var rcv = Parse(receivedatas);
				if(rcv != null) return rcv;
			}
			return null;
		}

		static public ClassNdirCalibStatus Parse(List<byte> dataList) {
			if(dataList == null || dataList.Count < 8) return null;       // 実データ保証
			var datas = dataList.Skip(4).ToArray();     // 4バイト目から実データ
			return new ClassNdirCalibStatus() {
				Result = datas[0],
				CalibStatus = datas[1],
				error = BitConverter.ToInt16(datas, 2),
			};
		}

		static public List<byte> CreatePacket() {
			return new List<byte>();
		}
	}
}
