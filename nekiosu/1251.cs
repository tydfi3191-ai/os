using System;
using System.IO;
using System.Linq;
using System.Threading;

// Token: 0x02000BB9 RID: 3001
public sealed class 1251 : Stream
{
	// Token: 0x1700031D RID: 797
	// (get) Token: 0x0600529F RID: 21151 RVA: 0x0001702D File Offset: 0x0001522D
	public override bool CanRead
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700031E RID: 798
	// (get) Token: 0x060052A0 RID: 21152 RVA: 0x0001702D File Offset: 0x0001522D
	public override bool CanSeek
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700031F RID: 799
	// (get) Token: 0x060052A1 RID: 21153 RVA: 0x0000FF75 File Offset: 0x0000E175
	public override bool CanWrite
	{
		get
		{
			return false;
		}
	}

	// Token: 0x17000320 RID: 800
	// (get) Token: 0x060052A2 RID: 21154 RVA: 0x002085FC File Offset: 0x002067FC
	public override long Length
	{
		get
		{
			return (long)this.1.Length;
		}
	}

	// Token: 0x17000321 RID: 801
	// (get) Token: 0x060052A3 RID: 21155 RVA: 0x00208607 File Offset: 0x00206807
	// (set) Token: 0x060052A4 RID: 21156 RVA: 0x00208612 File Offset: 0x00206812
	public override long Position
	{
		get
		{
			return (long)this.6;
		}
		set
		{
			this.6 = 1052.18((int)value, 0, this.1.Length);
		}
	}

	// Token: 0x060052A5 RID: 21157 RVA: 0x0020862C File Offset: 0x0020682C
	public 1251(Stream 1, int 2, 1251 3 = null)
	{
		this.8 = (1304.217 ? -1 : 2);
		this.9 = 1;
		if (this.9.CanSeek)
		{
			this.9.Seek(0L, SeekOrigin.Begin);
		}
		long? num = (3 != null) ? new long?(3.Length) : null;
		long length = 1.Length;
		if (!(num.GetValueOrDefault() == length & num != null))
		{
			this.1 = new byte[this.9.Length];
			this.2 = new bool[this.1.Length / 32768 + 1];
		}
		else
		{
			this.1 = 3.1;
			this.2 = 3.2;
			this.4 = 3.4;
		}
		1662.17(new 1189(this.1));
	}

	// Token: 0x060052A6 RID: 21158 RVA: 0x0020871C File Offset: 0x0020691C
	~1251()
	{
		this.Dispose(false);
	}

	// Token: 0x060052A7 RID: 21159 RVA: 0x0020874C File Offset: 0x0020694C
	private void 1()
	{
		if (this.4)
		{
			return;
		}
		int num = -1;
		try
		{
			while (!this.4 && !this.3)
			{
				int num2 = this.2();
				if (num2 < 0)
				{
					Thread.Sleep(1);
				}
				else
				{
					int num3 = num2 * 32768;
					if (num + 1 != num2)
					{
						this.9.Seek((long)num3, SeekOrigin.Begin);
					}
					int num4 = Math.Min(this.1.Length - num3, 32768);
					int num5;
					for (int i = 0; i < num4; i += num5)
					{
						num5 = this.9.Read(this.1, num3 + i, num4 - i);
						if (num5 <= 0)
						{
							break;
						}
					}
					this.2[num2] = true;
					num = num2;
					this.4 |= this.2.All(new Func<bool, bool>(1251.1252.Instance.1));
				}
			}
		}
		catch
		{
			this.5 = true;
			if (!this.3)
			{
				throw;
			}
			return;
		}
		this.4 = true;
		if (!this.3)
		{
			Stream stream = this.9;
			if (stream == null)
			{
				return;
			}
			stream.Close();
		}
	}

	// Token: 0x060052A8 RID: 21160 RVA: 0x00208880 File Offset: 0x00206A80
	private int 2()
	{
		if (this.3)
		{
			return -1;
		}
		int num = this.9.CanSeek ? (this.6 / 32768) : 0;
		int num2 = this.2.Length;
		if (this.8 > -1)
		{
			num2 = Math.Min(num2, (this.6 + this.7) / 32768 + this.8 + 1);
		}
		for (int i = num; i < num2; i++)
		{
			if (!this.2[i])
			{
				return i;
			}
		}
		return -1;
	}

	// Token: 0x060052A9 RID: 21161 RVA: 0x00208908 File Offset: 0x00206B08
	protected override void Dispose(bool 1)
	{
		if (!this.3)
		{
			this.Close();
		}
		base.Dispose(1);
	}

	// Token: 0x060052AA RID: 21162 RVA: 0x00208921 File Offset: 0x00206B21
	public override void Close()
	{
		this.3 = true;
		Stream stream = this.9;
		if (stream != null)
		{
			stream.Close();
		}
		base.Close();
	}

	// Token: 0x060052AB RID: 21163 RVA: 0x00053ADC File Offset: 0x00051CDC
	public override void Flush()
	{
		throw new NotImplementedException();
	}

	// Token: 0x060052AC RID: 21164 RVA: 0x00208944 File Offset: 0x00206B44
	public override int Read(byte[] 1, int 2, int 3)
	{
		this.7 = Math.Min(3, this.1.Length - this.6);
		int num = this.6 / 32768;
		int num2 = (this.6 + this.7) / 32768;
		for (int i = num; i <= num2; i++)
		{
			while (!this.2[i])
			{
				if (this.3 || this.5)
				{
					this.7 = 0;
					return 0;
				}
				Thread.Sleep(1);
			}
		}
		Array.Copy(this.1, this.6, 1, 2, this.7);
		int num3 = this.7;
		this.7 = 0;
		this.6 += num3;
		return num3;
	}

	// Token: 0x060052AD RID: 21165 RVA: 0x00208A14 File Offset: 0x00206C14
	public override long Seek(long 1, SeekOrigin 2)
	{
		switch (2)
		{
		case SeekOrigin.Begin:
			this.Position = 1;
			break;
		case SeekOrigin.Current:
			this.Position += 1;
			break;
		case SeekOrigin.End:
			this.Position = (long)this.1.Length + 1;
			break;
		}
		return (long)this.6;
	}

	// Token: 0x060052AE RID: 21166 RVA: 0x00053ADC File Offset: 0x00051CDC
	public override void SetLength(long 1)
	{
		throw new NotImplementedException();
	}

	// Token: 0x060052AF RID: 21167 RVA: 0x00053ADC File Offset: 0x00051CDC
	public override void Write(byte[] 1, int 2, int 3)
	{
		throw new NotImplementedException();
	}

	// Token: 0x04003EE3 RID: 16099
	private readonly byte[] 1;

	// Token: 0x04003EE4 RID: 16100
	private readonly bool[] 2;

	// Token: 0x04003EE5 RID: 16101
	private volatile bool 3;

	// Token: 0x04003EE6 RID: 16102
	private volatile bool 4;

	// Token: 0x04003EE7 RID: 16103
	private volatile bool 5;

	// Token: 0x04003EE8 RID: 16104
	private volatile int 6;

	// Token: 0x04003EE9 RID: 16105
	private volatile int 7;

	// Token: 0x04003EEA RID: 16106
	private readonly int 8;

	// Token: 0x04003EEB RID: 16107
	private readonly Stream 9;

	// Token: 0x02000BBA RID: 3002
	[Serializable]
	public sealed class 1252
	{
		// Token: 0x060052B0 RID: 21168 RVA: 0x00022391 File Offset: 0x00020591
		internal bool 1(bool 1)
		{
			return 1;
		}

		// Token: 0x04003EEC RID: 16108
		public static readonly 1251.1252 Instance = new 1251.1252();

		// Token: 0x04003EED RID: 16109
		public static Func<bool, bool> func;
	}
}
