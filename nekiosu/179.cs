using System;
using System.IO;

// Token: 0x020002A2 RID: 674
public static class 179
{
	// Token: 0x06001477 RID: 5239 RVA: 0x00046F74 File Offset: 0x00045174
	public static void WriteInt32(int 1, byte[] 2, int 3)
	{
		2[3] = (byte)1;
		2[3 + 1] = (byte)(1 >> 8);
		2[3 + 2] = (byte)(1 >> 16);
		2[3 + 3] = (byte)(1 >> 24);
	}

	// Token: 0x06001478 RID: 5240 RVA: 0x00046F98 File Offset: 0x00045198
	public static void WriteInt64(long 1, byte[] 2, int 3)
	{
		2[3] = (byte)1;
		2[3 + 1] = (byte)(1 >> 8);
		2[3 + 2] = (byte)(1 >> 16);
		2[3 + 3] = (byte)(1 >> 24);
		2[3 + 4] = (byte)(1 >> 32);
		2[3 + 5] = (byte)(1 >> 40);
		2[3 + 6] = (byte)(1 >> 48);
		2[3 + 7] = (byte)(1 >> 56);
	}

	// Token: 0x06001479 RID: 5241 RVA: 0x00046FF0 File Offset: 0x000451F0
	public static byte[] GetInt32Bytes(int 1)
	{
		if (BitConverter.IsLittleEndian)
		{
			return BitConverter.GetBytes(1);
		}
		byte[] array = new byte[4];
		179.WriteInt32(1, array, 0);
		return array;
	}

	// Token: 0x0600147A RID: 5242 RVA: 0x0004701C File Offset: 0x0004521C
	public static byte[] GetInt64Bytes(long 1)
	{
		if (BitConverter.IsLittleEndian)
		{
			return BitConverter.GetBytes(1);
		}
		byte[] array = new byte[8];
		179.WriteInt64(1, array, 0);
		return array;
	}

	// Token: 0x0600147B RID: 5243 RVA: 0x00047047 File Offset: 0x00045247
	public static int ReadInt32(byte[] 1, int 2)
	{
		if (BitConverter.IsLittleEndian)
		{
			return BitConverter.ToInt32(1, 2);
		}
		return (int)1[2] | (int)1[2 + 1] << 8 | (int)1[2 + 2] << 16 | (int)1[2 + 3] << 24;
	}

	// Token: 0x0600147C RID: 5244 RVA: 0x00047078 File Offset: 0x00045278
	public static long ReadInt64(byte[] 1, int 2)
	{
		if (BitConverter.IsLittleEndian)
		{
			return BitConverter.ToInt64(1, 2);
		}
		return (long)((ulong)1[2] | (ulong)1[2 + 1] << 8 | (ulong)1[2 + 2] << 16 | (ulong)1[2 + 3] << 24 | (ulong)1[2 + 4] << 32 | (ulong)1[2 + 5] << 40 | (ulong)1[2 + 6] << 48 | (ulong)1[2 + 7] << 56);
	}

	// Token: 0x0600147D RID: 5245 RVA: 0x000470E0 File Offset: 0x000452E0
	public static float ReadSingle(byte[] 1, int 2)
	{
		if (BitConverter.IsLittleEndian && 287.flag)
		{
			return BitConverter.ToSingle(1, 2);
		}
		BinaryReader binaryReader = new BinaryReader(new MemoryStream(1, 2, 4, false));
		float result = binaryReader.ReadSingle();
		binaryReader.Close();
		return result;
	}

	// Token: 0x0600147E RID: 5246 RVA: 0x00047120 File Offset: 0x00045320
	public static double ReadDouble(byte[] 1, int 2)
	{
		if (BitConverter.IsLittleEndian && 328.flag)
		{
			return BitConverter.ToDouble(1, 2);
		}
		BinaryReader binaryReader = new BinaryReader(new MemoryStream(1, 2, 8, false));
		double result = binaryReader.ReadDouble();
		binaryReader.Close();
		return result;
	}
}
