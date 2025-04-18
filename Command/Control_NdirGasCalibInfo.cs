using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP {

	public class ClassNdirGasCalibInfo {
		public int Result;
		public int CalibCount;
		public int[] CalibPointValues;
		public int ManualSpan;
	}

	static public class Control_GetNdirGasCalibInfo {

		static public ClassNdirGasCalibInfo Get(int ch, int rtry = 1) {
			while(rtry-- > 0) {
				var writeDatas = CreatePacket();
				List<byte> receivedatas = Common.Sensor.Exec((byte)ClassSensorMain.FuncCode.NDIRガス調整情報取得, ch, writeDatas);

				/// 受信パケット解析
				var rev = Parse(receivedatas);
				if(rev != null) return rev;
			}
			return null;
		}

		static public ClassNdirGasCalibInfo Parse(List<byte> dataList) {
			if(dataList?.Count < 23) return null;       // 実データ保証
			var datas = dataList.Skip(4).ToArray();     // 4バイト目から実データ

			if(datas[0] != 0) return null;
			var result = new ClassNdirGasCalibInfo() {
				Result = datas[0],
				CalibCount = datas[1],
				ManualSpan = datas[18],
			};

			var prms = new int[8];
			for(int pos=2,i=0; i<result.CalibCount;i++) {
				prms[i] = BitConverter.ToUInt16(datas, pos);
				pos += 2;
			}
			result.CalibPointValues = prms;
			return result;
		}

		static public List<byte> CreatePacket() {
			return new Byte[] { 1 }.ToList();	// ガス種No 1固定
		}
	}

	static public class Control_SetNdirGasCalibInfo {

		static public bool Set(ClassNdirGasCalibInfo info, int ch, int rtry = 1) {
			while(rtry-- > 0) {
				var writeDatas = CreatePacket(info);
				List<byte> receivedatas = Common.Sensor.Exec((byte)ClassSensorMain.FuncCode.NDIRガス調整情報設定, ch, writeDatas);

				var rev = Parse(receivedatas);
				if((rev!=null) && (rev.Result==0)) return true;
			}
			return false;
		}

		static public ClassNdirGasCalibInfo Parse(List<byte> dataList) {
			if(dataList == null || dataList.Count < 4) return null;       // 実データ保証
			var datas = dataList.Skip(4).ToArray();     // 4バイト目から実データ
			return new ClassNdirGasCalibInfo() {
				Result = datas[0],
			};
		}

		static public List<byte> CreatePacket(ClassNdirGasCalibInfo info) {
			var buf = new Byte[19];
			buf[0] = 1; // ガス種No 1固定
			buf[1] = (byte)info.CalibCount;
			for(int pos=2,i=0;i < info.CalibCount;i++) {
				Buffer.BlockCopy(BitConverter.GetBytes((UInt16)info.CalibPointValues[i]), 0, buf, pos, 2);
				pos += 2;
			}
			buf[18] = (byte)info.ManualSpan;
			return buf.ToList();
		}

	}

}
