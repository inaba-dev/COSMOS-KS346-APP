using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP {

	public class ClassNdirSensorStart {
		public int Result;
		public int CmdResult;
		public int Status;
	}

	static public class Control_NdirSensorStart {

		static public bool Start(int ch) {
			/// 受信処理
			var writeDatas = CreatePacket();
			List<byte> receivedatas = Common.Sensor.Exec((byte)ClassSensorMain.FuncCode.NDIRセンサ起動, ch, writeDatas);

			/// 受信パケット解析
			var rev = Parse(receivedatas);
			return (rev?.Result == 0) ? true : false;
			
		}

		static public ClassNdirSensorStart Parse(List<byte> dataList) {
			if(dataList == null || dataList.Count < 7) return null;		// 実データ保証
			var datas = dataList.Skip(4).ToArray();     // 4バイト目から実データ

			return new ClassNdirSensorStart() {
				Result = datas[0],
				CmdResult = datas[1],
				Status = datas[2],
			};
		}

		static public List<byte> CreatePacket() {
			return new Byte[] { 0 }.ToList();
		}
	}
}
