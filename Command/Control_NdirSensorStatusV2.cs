using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP {

	// Command 0x39

	public class ClassNdirSensorStatusV2 {
		public int Result;
		public int Status;
		public int GasConc;
		public int GasValue2;
		public int Error;
	}

	static public class Control_NdirSensorStatusV2 {

		static public ClassNdirSensorStatusV2 Get(int ch, int rtry = 1) {
			while(rtry-- > 0) {
				/// 受信処理
				var writeDatas = CreatePacket();
				List<byte> receivedatas = Common.Sensor.Exec((byte)ClassSensorMain.FuncCode.NDIRセンサ状態取得, ch, writeDatas);

				/// 受信パケット解析
				var rcv = Parse(receivedatas);
				if(rcv != null) return rcv;
			}
			return null;
		}

		static public ClassNdirSensorStatusV2 Parse(List<byte> dataList) {
			if(dataList == null || dataList.Count < 10 ) return null;			// 最低値保障
			var datas = dataList.Skip(4).ToArray();         // 4から実データ

			return new ClassNdirSensorStatusV2() {
				Result = datas[0],
				Status = datas[1],
				GasConc = BitConverter.ToInt16(datas, 2),
				GasValue2 = BitConverter.ToInt16(datas, 4),
				Error = datas[6]
			};
		}

		static public List<byte> CreatePacket() {
			return new Byte[] { 0,0 }.ToList();
		}

	}
}
