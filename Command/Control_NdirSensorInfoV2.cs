using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP {

	public class ClassNdirSensorInfoV2 {
		public int 応答結果;
		public int センサ種;
		public int ガス種数;
		public UInt32 シリアルNo;
		public int センサ断線エラー1判定値;
		public int サプレッション範囲内濃度取得周期;
		public int サプレッション範囲外濃度取得周期;
		public int 濃度取得要求通知周期;
		public int 温湿度設定周期;
	}

	static class Control_NdirSensorInfoV2 {
		static public string GetGasName(ClassNdirSensorInfoV2 param) {
			switch(param.センサ種) {
			case (byte)0x00: return ("未定義");
			case (byte)0x01: return ("定電位(O2)");
			case (byte)0x02: return ("定電位(CL2)");
			case (byte)0x03: return ("定電位(SO2)");
			case (byte)0x04: return ("定電位(NH3)");
			case (byte)0x05: return ("定電位(CO)");
			case (byte)0x06: return ("定電位(H2S)");
			case (byte)0x21: return ("NDIR(CO2)");
			case (byte)0x22: return ("NDIR(CH4)");
			case (byte)0x40: return ("MC2");
			case (byte)0x60: return ("MEMS-CH");
			default: return ("不明");
			}
		}

		static public ClassNdirSensorInfoV2 Parse(List<byte> dataList) {
			if(dataList?.Count < 17) return null;           // 最低値保障
			var datas = dataList.Skip(4).ToArray();         // 4から実データ

			return new ClassNdirSensorInfoV2() {
				応答結果 = datas[0],
				センサ種 = datas[1],
				ガス種数 = datas[2],
				シリアルNo = BitConverter.ToUInt32(datas, 3),
				センサ断線エラー1判定値 = BitConverter.ToUInt16(datas, 7),
				サプレッション範囲内濃度取得周期 = datas[9],
				サプレッション範囲外濃度取得周期 = datas[10],
				濃度取得要求通知周期 = datas[11],
				温湿度設定周期 = datas[12]
			};
		}

		static public List<byte> CreatePacket() {
			return new List<byte>();
		}

	}
}
