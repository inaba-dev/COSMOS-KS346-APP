using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP {
	public class ClassNdirSensorStop {
		public int Result;
		public int CmdResult;
	}
	static public class Control_NdirSensorStop {

		static public bool Stop(int ch) {
			/// 受信処理
			var writeDatas = CreatePacket();
			List<byte> receivedatas = Common.Sensor.Exec((byte)ClassSensorMain.FuncCode.NDIRセンサ待機, ch, writeDatas);

			/// 受信パケット解析
			var rev = Parse(receivedatas);
			return (rev?.Result == 0) ? true : false;
		}

		static public ClassNdirSensorStop Parse(List<byte> dataList) {
			if(dataList==null || dataList.Count < 6) return null;       // 実データ保証
			var datas = dataList.Skip(4).ToArray();     // 4バイト目から実データ

			return new ClassNdirSensorStop() {
				Result = datas[0],
				CmdResult = datas[1],
			};
		}

		static public List<byte> CreatePacket() {
			return new List<byte>();
		}
	}
}
