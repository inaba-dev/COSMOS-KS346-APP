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
