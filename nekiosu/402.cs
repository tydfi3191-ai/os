using System;
using System.IO;
using System.Runtime.InteropServices;

// Token: 0x020002E6 RID: 742
[ComVisible(false)]
public sealed class 402
{
	// Token: 0x06001624 RID: 5668 RVA: 0x000055AC File Offset: 0x000037AC
	private 402()
	{
	}

	// Token: 0x06001625 RID: 5669 RVA: 0x0004C493 File Offset: 0x0004A693
	public static void Method2546(Stream 1, byte[] 2)
	{
		402.Method2546(1, 2, 0, 2.Length);
	}

	// Token: 0x06001626 RID: 5670 RVA: 0x0004C4A0 File Offset: 0x0004A6A0
	public static void Method2546(Stream 1, byte[] 2, int 3, int 4)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("#=zls9YYyc=");
		}
		if (2 == null)
		{
			throw new ArgumentNullException("#=zpMJwVYM=");
		}
		if (3 < 0 || 3 > 2.Length)
		{
			throw new ArgumentOutOfRangeException("#=zJ_sgkP4=");
		}
		if (4 < 0 || 3 + 4 > 2.Length)
		{
			throw new ArgumentOutOfRangeException("#=zW32YDQ0=");
		}
		while (4 > 0)
		{
			int num = 1.Read(2, 3, 4);
			if (num <= 0)
			{
				throw new EndOfStreamException();
			}
			3 += num;
			4 -= num;
		}
	}

	// Token: 0x06001627 RID: 5671 RVA: 0x0004C518 File Offset: 0x0004A718
	public static void Method2548(Stream 1, Stream 2, byte[] 3)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("#=zUCAUQIw=");
		}
		if (2 == null)
		{
			throw new ArgumentNullException("#=zvfPGZ8E=");
		}
		if (3 == null)
		{
			throw new ArgumentNullException("#=zpMJwVYM=");
		}
		if (3.Length < 128)
		{
			throw new ArgumentException("Buffer is too small", "#=zpMJwVYM=");
		}
		bool flag = true;
		while (flag)
		{
			int num = 1.Read(3, 0, 3.Length);
			if (num > 0)
			{
				2.Write(3, 0, num);
			}
			else
			{
				2.Flush();
				flag = false;
			}
		}
	}

	// Token: 0x06001628 RID: 5672 RVA: 0x0004C593 File Offset: 0x0004A793
	public static void Method2548(Stream 1, Stream 2, byte[] 3, 380 4, TimeSpan 5, object 6, string 7)
	{
		402.Method2548(1, 2, 3, 4, 5, 6, 7, -1L);
	}

	// Token: 0x06001629 RID: 5673 RVA: 0x0004C5A8 File Offset: 0x0004A7A8
	public static void Method2548(Stream 1, Stream 2, byte[] 3, 380 4, TimeSpan 5, object 6, string 7, long 8)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("source");
		}
		if (2 == null)
		{
			throw new ArgumentNullException("destination");
		}
		if (3 == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (3.Length < 128)
		{
			throw new ArgumentException("Buffer is too small", "buffer");
		}
		if (4 == null)
		{
			throw new ArgumentNullException("progressHandler");
		}
		bool flag = true;
		DateTime now = DateTime.Now;
		long num = 0L;
		long 9 = 0L;
		if (8 >= 0L)
		{
			9 = 8;
		}
		else if (1.CanSeek)
		{
			9 = 1.Length - 1.Position;
		}
		761 10 = new 761(7, num, 9);
		4(6, 10);
		bool flag2 = true;
		while (flag)
		{
			int num2 = 1.Read(3, 0, 3.Length);
			if (num2 > 0)
			{
				num += (long)num2;
				flag2 = false;
				2.Write(3, 0, num2);
			}
			else
			{
				2.Flush();
				flag = false;
			}
			if (DateTime.Now - now > 5)
			{
				flag2 = true;
				now = DateTime.Now;
				10 = new 761(7, num, 9);
				4(6, 10);
				flag = 10.GetFlag9645_12330();
			}
		}
		if (!flag2)
		{
			10 = new 761(7, num, 9);
			4(6, 10);
		}
	}
}
