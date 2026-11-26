using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Permissions;

// Token: 0x0200008E RID: 142
[ComVisible(false)]
public sealed class 386 : 98
{
	// Token: 0x060002F0 RID: 752 RVA: 0x000094A4 File Offset: 0x000076A4
	public 386(Stream 1)
	{
		if (!1.CanSeek)
		{
			byte[] array = new byte[256];
			int num = 0;
			int num2;
			do
			{
				if (array.Length < num + 256)
				{
					byte[] array2 = new byte[array.Length * 2];
					Array.Copy(array, array2, array.Length);
					array = array2;
				}
				num2 = 1.Read(array, num, 256);
				num += num2;
			}
			while (num2 != 0);
			this.stream2 = new MemoryStream(array);
			return;
		}
		this.stream2 = 1;
	}

	// Token: 0x060002F1 RID: 753 RVA: 0x00009520 File Offset: 0x00007720
	private void Method2218()
	{
		if (this.number4 != -1L)
		{
			if (this.number4 > this.stream2.Length)
			{
				this.stream2.SetLength(this.number4);
			}
			this.stream2.Position = this.number4;
			this.number4 = -1L;
		}
	}

	// Token: 0x060002F2 RID: 754 RVA: 0x00009574 File Offset: 0x00007774
	public 98 Clone()
	{
		386.Method2225();
		return null;
	}

	// Token: 0x060002F3 RID: 755 RVA: 0x0000957C File Offset: 0x0000777C
	public void Commit(int 1)
	{
		this.stream2.Flush();
		this.Method2218();
	}

	// Token: 0x060002F4 RID: 756 RVA: 0x00009590 File Offset: 0x00007790
	[UIPermission(SecurityAction.Demand, Window = UIPermissionWindow.AllWindows)]
	[SecurityPermission(SecurityAction.Assert, Flags = SecurityPermissionFlag.UnmanagedCode)]
	public long CopyTo(98 1, long 2, long[] 3)
	{
		int num = 4096;
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		if (intPtr == IntPtr.Zero)
		{
			throw new OutOfMemoryException();
		}
		long num2 = 0L;
		try
		{
			while (num2 < 2)
			{
				int num3 = num;
				if (num2 + (long)num3 > 2)
				{
					num3 = (int)(2 - num2);
				}
				int num4 = this.Read(intPtr, num3);
				if (num4 == 0)
				{
					break;
				}
				if (1.Write(intPtr, num4) != num4)
				{
					throw 386.Method2222("Wrote an incorrect number of bytes");
				}
				num2 += (long)num4;
			}
		}
		finally
		{
			Marshal.FreeHGlobal(intPtr);
		}
		if (3 != null && 3.Length != 0)
		{
			3[0] = num2;
		}
		return num2;
	}

	// Token: 0x060002F5 RID: 757 RVA: 0x00009628 File Offset: 0x00007828
	protected static ExternalException Method2222(string 1)
	{
		throw new ExternalException(1, -2147467259);
	}

	// Token: 0x060002F6 RID: 758 RVA: 0x00009635 File Offset: 0x00007835
	public Stream GetStream1554_2223()
	{
		return this.stream2;
	}

	// Token: 0x060002F7 RID: 759 RVA: 0x00005ADD File Offset: 0x00003CDD
	public void LockRegion(long 1, long 2, int 3)
	{
	}

	// Token: 0x060002F8 RID: 760 RVA: 0x00005ADD File Offset: 0x00003CDD
	protected static void Method2225()
	{
	}

	// Token: 0x060002F9 RID: 761 RVA: 0x00009640 File Offset: 0x00007840
	public int Read(IntPtr 1, int 2)
	{
		byte[] array = new byte[2];
		int result = this.Method22262(array, 2);
		Marshal.Copy(array, 0, 1, 2);
		return result;
	}

	// Token: 0x060002FA RID: 762 RVA: 0x00009665 File Offset: 0x00007865
	public int Method22262(byte[] 1, int 2)
	{
		this.Method2218();
		return this.stream2.Read(1, 0, 2);
	}

	// Token: 0x060002FB RID: 763 RVA: 0x0000967B File Offset: 0x0000787B
	public void Revert()
	{
		386.Method2225();
	}

	// Token: 0x060002FC RID: 764 RVA: 0x00009684 File Offset: 0x00007884
	public long Seek(long 1, int 2)
	{
		long position = this.number4;
		if (this.number4 == -1L)
		{
			position = this.stream2.Position;
		}
		long length = this.stream2.Length;
		switch (2)
		{
		case 0:
			if (1 > length)
			{
				this.number4 = 1;
			}
			else
			{
				this.stream2.Position = 1;
				this.number4 = -1L;
			}
			break;
		case 1:
			if (1 + position > length)
			{
				this.number4 = 1 + position;
			}
			else
			{
				this.stream2.Position = position + 1;
				this.number4 = -1L;
			}
			break;
		case 2:
			if (1 > 0L)
			{
				this.number4 = length + 1;
			}
			else
			{
				this.stream2.Position = length + 1;
				this.number4 = -1L;
			}
			break;
		}
		if (this.number4 != -1L)
		{
			return this.number4;
		}
		return this.stream2.Position;
	}

	// Token: 0x060002FD RID: 765 RVA: 0x0000975C File Offset: 0x0000795C
	public void SetSize(long 1)
	{
		this.stream2.SetLength(1);
	}

	// Token: 0x060002FE RID: 766 RVA: 0x0000976A File Offset: 0x0000796A
	public void Stat(IntPtr 1, int 2)
	{
		Marshal.StructureToPtr(new 386.387
		{
			number2 = this.stream2.Length
		}, 1, true);
	}

	// Token: 0x060002FF RID: 767 RVA: 0x00005ADD File Offset: 0x00003CDD
	public void UnlockRegion(long 1, long 2, int 3)
	{
	}

	// Token: 0x06000300 RID: 768 RVA: 0x0000978C File Offset: 0x0000798C
	public int Write(IntPtr 1, int 2)
	{
		byte[] array = new byte[2];
		Marshal.Copy(1, array, 0, 2);
		return this.Method22332(array, 2);
	}

	// Token: 0x06000301 RID: 769 RVA: 0x000097B1 File Offset: 0x000079B1
	public int Method22332(byte[] 1, int 2)
	{
		this.Method2218();
		this.stream2.Write(1, 0, 2);
		return 2;
	}

	// Token: 0x04000347 RID: 839
	protected Stream stream2;

	// Token: 0x04000348 RID: 840
	private long number4 = -1L;

	// Token: 0x0200008F RID: 143
	[StructLayout(LayoutKind.Sequential)]
	public sealed class 387
	{
		// Token: 0x04000349 RID: 841
		public IntPtr intPtr = IntPtr.Zero;

		// Token: 0x0400034A RID: 842
		public int number;

		// Token: 0x0400034B RID: 843
		[MarshalAs(UnmanagedType.I8)]
		public long number2;

		// Token: 0x0400034C RID: 844
		[MarshalAs(UnmanagedType.I8)]
		public long number3;

		// Token: 0x0400034D RID: 845
		[MarshalAs(UnmanagedType.I8)]
		public long number4;

		// Token: 0x0400034E RID: 846
		[MarshalAs(UnmanagedType.I8)]
		public long number5;

		// Token: 0x0400034F RID: 847
		[MarshalAs(UnmanagedType.I4)]
		public int number6;

		// Token: 0x04000350 RID: 848
		[MarshalAs(UnmanagedType.I4)]
		public int number7;

		// Token: 0x04000351 RID: 849
		public int number8;

		// Token: 0x04000352 RID: 850
		[MarshalAs(UnmanagedType.I2)]
		public short intValue;

		// Token: 0x04000353 RID: 851
		[MarshalAs(UnmanagedType.I2)]
		public short intValue2;

		// Token: 0x04000354 RID: 852
		[MarshalAs(UnmanagedType.U1)]
		public byte byteValue;

		// Token: 0x04000355 RID: 853
		[MarshalAs(UnmanagedType.U1)]
		public byte byteValue2;

		// Token: 0x04000356 RID: 854
		[MarshalAs(UnmanagedType.U1)]
		public byte byteValue3;

		// Token: 0x04000357 RID: 855
		[MarshalAs(UnmanagedType.U1)]
		public byte byteValue4;

		// Token: 0x04000358 RID: 856
		[MarshalAs(UnmanagedType.U1)]
		public byte byteValue5;

		// Token: 0x04000359 RID: 857
		[MarshalAs(UnmanagedType.U1)]
		public byte byteValue6;

		// Token: 0x0400035A RID: 858
		[MarshalAs(UnmanagedType.U1)]
		public byte byteValue7;

		// Token: 0x0400035B RID: 859
		[MarshalAs(UnmanagedType.U1)]
		public byte byteValue8;

		// Token: 0x0400035C RID: 860
		[MarshalAs(UnmanagedType.I4)]
		public int number9;

		// Token: 0x0400035D RID: 861
		[MarshalAs(UnmanagedType.I4)]
		public int number10;
	}
}
