using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP {

	public class ClassNdirCalibStop {
		public int Result;
	}

	static public class Control_NdirCalibStop {

		static public bool Stop(int ch, int rtry = 1) {
			while(rtry-- > 0) {
				var writeDatas = CreatePacket();
				List<byte> receivedatas = Common.Sensor.Exec((byte)ClassSensorMain.FuncCode.NDIRセンサ校正中断, ch, writeDatas);

				/// 受信パケット解析
				var rcv = Parse(receivedatas);
				if(rcv != null) return true;
			}
			return false;
		}

		static public ClassNdirCalibStop Parse(List<byte> dataList) {
			if(dataList==null || dataList.Count < 4) return null;       // 実データ保証
			var datas = dataList.Skip(4).ToArray();     // 4バイト目から実データ
			return new ClassNdirCalibStop() {
				Result = datas[0],
			};
		}

		static public List<byte> CreatePacket() {
			return new List<byte>();
		}
	}
}
