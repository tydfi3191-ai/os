using System;
using System.IO;

// Token: 0x02000034 RID: 52
public static class 35
{
	// Token: 0x0600014E RID: 334 RVA: 0x000076CC File Offset: 0x000058CC
	public static byte[] Decode(string 1)
	{
		if (1 == null)
		{
			throw new Exception();
		}
		MemoryStream memoryStream = new MemoryStream(1.Length * 4 / 5);
		byte[] result;
		try
		{
			int num = 0;
			uint num2 = 0U;
			foreach (char c in 1)
			{
				if (c == 'z' && num == 0)
				{
					35.WriteGroupBytes(memoryStream, num2, 0);
				}
				else
				{
					if (c < '!' || c > 'u')
					{
						throw new Exception();
					}
					checked
					{
						num2 += (uint)(unchecked((ulong)35.powersOf85[num]) * (ulong)(unchecked((long)(checked(c - '!')))));
					}
					num++;
					if (num == 5)
					{
						35.WriteGroupBytes(memoryStream, num2, 0);
						num = 0;
						num2 = 0U;
					}
				}
			}
			if (num == 1)
			{
				throw new Exception();
			}
			if (num > 1)
			{
				for (int j = num; j < 5; j++)
				{
					checked
					{
						num2 += 84U * 35.powersOf85[j];
					}
				}
				35.WriteGroupBytes(memoryStream, num2, 5 - num);
			}
			result = memoryStream.ToArray();
		}
		finally
		{
			((IDisposable)memoryStream).Dispose();
		}
		return result;
	}

	// Token: 0x0600014F RID: 335 RVA: 0x000077BC File Offset: 0x000059BC
	private static void WriteGroupBytes(Stream 1, uint 2, int 3)
	{
		1.WriteByte((byte)(2 >> 24));
		if (3 == 3)
		{
			return;
		}
		1.WriteByte((byte)(2 >> 16));
		if (3 != 2)
		{
			1.WriteByte((byte)(2 >> 8));
			if (3 != 1)
			{
				1.WriteByte((byte)2);
			}
		}
	}

	// Token: 0x04000080 RID: 128
	private static readonly uint[] powersOf85 = new uint[]
	{
		52200625U,
		614125U,
		7225U,
		85U,
		1U
	};
}
