using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

// Token: 0x0200020E RID: 526
[ComVisible(false)]
public static class 182
{
	// Token: 0x0600108E RID: 4238 RVA: 0x00038DB4 File Offset: 0x00036FB4
	public static byte[] Compress(byte[] 1)
	{
		object obj = 182.value;
		byte[] result;
		lock (obj)
		{
			MemoryStream memoryStream = new MemoryStream(1);
			MemoryStream memoryStream2 = new MemoryStream();
			182.lzmaEncoder.Method4578(182.propertyIds, 182.valueArray);
			182.lzmaEncoder.Method4574(memoryStream2);
			long length = memoryStream.Length;
			for (int i = 0; i < 8; i++)
			{
				memoryStream2.WriteByte((byte)(length >> 8 * i));
			}
			182.lzmaEncoder.Method6888(memoryStream, memoryStream2, -1L, -1L, null);
			result = memoryStream2.ToArray();
		}
		return result;
	}

	// Token: 0x0600108F RID: 4239 RVA: 0x00038E60 File Offset: 0x00037060
	public static MemoryStream DecompressStream(Stream 1)
	{
		object obj = 182.value;
		MemoryStream result;
		lock (obj)
		{
			183 2 = new 183();
			1.Seek(0L, SeekOrigin.Begin);
			MemoryStream memoryStream = new MemoryStream();
			byte[] array = new byte[5];
			if (1.Read(array, 0, 5) != 5)
			{
				throw new Exception("input .lzma is too short");
			}
			long num = 0L;
			for (int i = 0; i < 8; i++)
			{
				int num2 = 1.ReadByte();
				if (num2 < 0)
				{
					throw new Exception("Can't Read 1");
				}
				num |= (long)((long)((ulong)((byte)num2)) << 8 * i);
			}
			2.Method6889(array);
			long 3 = 1.Length - 1.Position;
			2.Method6888(1, memoryStream, 3, num, null);
			result = memoryStream;
		}
		return result;
	}

	// Token: 0x06001090 RID: 4240 RVA: 0x00038F38 File Offset: 0x00037138
	public static MemoryStream CompressStream(Stream 1)
	{
		object obj = 182.value;
		MemoryStream result;
		lock (obj)
		{
			1.Seek(0L, SeekOrigin.Begin);
			MemoryStream memoryStream = new MemoryStream();
			182.lzmaEncoder.Method4578(182.propertyIds, 182.valueArray);
			182.lzmaEncoder.Method4574(memoryStream);
			long length = 1.Length;
			for (int i = 0; i < 8; i++)
			{
				memoryStream.WriteByte((byte)(length >> 8 * i));
			}
			182.lzmaEncoder.Method6888(1, memoryStream, -1L, -1L, null);
			result = memoryStream;
		}
		return result;
	}

	// Token: 0x06001091 RID: 4241 RVA: 0x00038FE0 File Offset: 0x000371E0
	public static byte[] DecompressResource(Assembly 1, string 2)
	{
		object obj = 182.value;
		byte[] result;
		lock (obj)
		{
			Stream manifestResourceStream = 1.GetManifestResourceStream(2);
			byte[] array = new byte[(int)manifestResourceStream.Length];
			manifestResourceStream.Read(array, 0, array.Length);
			result = 182.Decompress(array);
		}
		return result;
	}

	// Token: 0x06001092 RID: 4242 RVA: 0x00039040 File Offset: 0x00037240
	public static byte[] Decompress(byte[] 1)
	{
		object obj = 182.value;
		byte[] result;
		lock (obj)
		{
			MemoryStream memoryStream = new MemoryStream(1);
			183 2 = new 183();
			memoryStream.Seek(0L, SeekOrigin.Begin);
			MemoryStream memoryStream2 = new MemoryStream();
			byte[] array = new byte[5];
			if (memoryStream.Read(array, 0, 5) != 5)
			{
				throw new Exception("input .lzma is too short");
			}
			long num = 0L;
			for (int i = 0; i < 8; i++)
			{
				int num2 = memoryStream.ReadByte();
				if (num2 < 0)
				{
					throw new Exception("Can't Read 1");
				}
				num |= (long)((long)((ulong)((byte)num2)) << 8 * i);
			}
			2.Method6889(array);
			long 3 = memoryStream.Length - memoryStream.Position;
			2.Method6888(memoryStream, memoryStream2, 3, num, null);
			result = memoryStream2.ToArray();
		}
		return result;
	}

	// Token: 0x04000808 RID: 2056
	private static int dictionarySize = 2097152;

	// Token: 0x04000809 RID: 2057
	private static bool flag = false;

	// Token: 0x0400080A RID: 2058
	private static 737[] propertyIds = new 737[]
	{
		(737)1024,
		(737)1088,
		(737)1089,
		(737)1090,
		(737)1136,
		(737)1104,
		(737)1105,
		(737)1168
	};

	// Token: 0x0400080B RID: 2059
	private static object[] valueArray = new object[]
	{
		182.dictionarySize,
		2,
		3,
		0,
		2,
		255,
		"bt4",
		182.flag
	};

	// Token: 0x0400080C RID: 2060
	private static 187 lzmaEncoder = new 187();

	// Token: 0x0400080D RID: 2061
	private static object value = new object();
}
