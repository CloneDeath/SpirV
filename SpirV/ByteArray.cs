using System;
using System.Collections.Generic;
using System.Text;

namespace SpirV
{
	public class ByteArray
	{
		private readonly List<byte> _bytes = new List<byte>();
		 
		public byte[] ToArray() {
			return _bytes.ToArray();
		}

		public void PushInt32(int value) {
			_bytes.AddRange(BitConverter.GetBytes(value));
		}

		public void PushUInt32(uint value) {
			_bytes.AddRange(BitConverter.GetBytes(value));
		}
		
		public void PushUInt32(int value) {
			_bytes.AddRange(BitConverter.GetBytes((uint)value));
		}
		
		public void PushUInt32(IEnumerable<uint> values) {
			foreach (var value in values) {
				_bytes.AddRange(BitConverter.GetBytes(value));
			}
		}
		
		public void PushUInt32(IEnumerable<int> values) {
			foreach (var value in values) {
				_bytes.AddRange(BitConverter.GetBytes((uint)value));
			}
		}

		public void Push(byte[] bytes) {
			_bytes.AddRange(bytes);
		}

		public void PushUInt16(ushort value) {
			_bytes.AddRange(BitConverter.GetBytes(value));
		}

		public static int GetWordCount(string value) {
			return (int)Math.Ceiling((value.Length + 1)/4.0);
		}

		public void PushString(string value) {
			var array = new byte[GetWordCount(value)*4];
			var stringArray = Encoding.UTF8.GetBytes(value);
			Array.Copy(stringArray, array, stringArray.Length);
			_bytes.AddRange(array);
		}
	}
}