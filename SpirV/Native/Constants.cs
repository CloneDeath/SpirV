using System.Diagnostics.CodeAnalysis;

namespace SpirV.Native
{
	[SuppressMessage("ReSharper", "InconsistentNaming")]
	public static class Constants
	{
		public const int MagicNumber = 0x07230203;
		public const int Version = 0x00010000;
		public const int Revision = 6;
		public const int OpCodeMask = 0x0000FFFF;
		public const int WordCountShift = 16;
	}
}
