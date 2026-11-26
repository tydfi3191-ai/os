using System;
using System.IO;

// Token: 0x020002AF RID: 687
public sealed class 348 : Stream
{
	// Token: 0x170000DD RID: 221
	// (get) Token: 0x060014D6 RID: 5334 RVA: 0x0001702D File Offset: 0x0001522D
	public override bool CanRead
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170000DE RID: 222
	// (get) Token: 0x060014D7 RID: 5335 RVA: 0x0001702D File Offset: 0x0001522D
	public override bool CanSeek
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170000DF RID: 223
	// (get) Token: 0x060014D8 RID: 5336 RVA: 0x0000FF75 File Offset: 0x0000E175
	public override bool CanWrite
	{
		get
		{
			return false;
		}
	}

	// Token: 0x170000E0 RID: 224
	// (get) Token: 0x060014D9 RID: 5337 RVA: 0x00048A6F File Offset: 0x00046C6F
	public override long Length
	{
		get
		{
			return this.stream2.Length;
		}
	}

	// Token: 0x170000E1 RID: 225
	// (get) Token: 0x060014DA RID: 5338 RVA: 0x00048A7C File Offset: 0x00046C7C
	// (set) Token: 0x060014DB RID: 5339 RVA: 0x00048A98 File Offset: 0x00046C98
	public override long Position
	{
		get
		{
			return this.stream2.Position + (long)(this.number3 - this.number4);
		}
		set
		{
			this.Seek(value, SeekOrigin.Begin);
		}
	}

	// Token: 0x060014DC RID: 5340 RVA: 0x00048AA4 File Offset: 0x00046CA4
	public 348(Stream 1, 345 2 = null, 332 3 = null, bool 4 = false)
	{
		this.stream2 = 1;
		this.flag2 = 4;
		this._recoveredType01530644 = 3;
		this._recoveredType02000643 = 2;
		if (this._recoveredType02000643 == null)
		{
			this._recoveredType02000643 = 345.GetRecoveredType02000634_1103();
		}
		if (this._recoveredType02000643.GetNumber0630_1095() == 0)
		{
			throw new ArgumentException("parameters");
		}
		if (this._recoveredType02000643.GetNumber0631_1097() == 0)
		{
			throw new ArgumentException("parameters");
		}
		if (!this.stream2.CanRead)
		{
			throw new ArgumentException("stream");
		}
		if (!this.stream2.CanSeek)
		{
			throw new ArgumentException("stream");
		}
	}

	// Token: 0x060014DD RID: 5341 RVA: 0x00048B48 File Offset: 0x00046D48
	private void Method1129()
	{
		if (!this.flag3)
		{
			this._recoveredType0155Array0642 = new 334[this._recoveredType02000643.GetNumber0630_1095()];
			for (int i = 0; i < this._recoveredType02000643.GetNumber0630_1095(); i++)
			{
				this._recoveredType0155Array0642[i] = new 334();
			}
			if (this._recoveredType01530644 != null)
			{
				this._recoveredType01380645 = this._recoveredType01530644.Method0879(this._recoveredType02000643);
			}
			this.flag3 = true;
		}
	}

	// Token: 0x060014DE RID: 5342 RVA: 0x00048BBC File Offset: 0x00046DBC
	protected override void Dispose(bool 1)
	{
		try
		{
			if (1 && !this.flag2)
			{
				this.stream2.Close();
			}
		}
		finally
		{
			base.Dispose(1);
		}
	}

	// Token: 0x060014DF RID: 5343 RVA: 0x00005BE8 File Offset: 0x00003DE8
	public override void SetLength(long 1)
	{
		throw new NotSupportedException();
	}

	// Token: 0x060014E0 RID: 5344 RVA: 0x00005BE8 File Offset: 0x00003DE8
	public override void Write(byte[] 1, int 2, int 3)
	{
		throw new NotSupportedException();
	}

	// Token: 0x060014E1 RID: 5345 RVA: 0x00005ADD File Offset: 0x00003CDD
	public override void Flush()
	{
	}

	// Token: 0x060014E2 RID: 5346 RVA: 0x00048BFC File Offset: 0x00046DFC
	private int Method1130(byte[] 1, int 2, int 3)
	{
		int num = this.number4 - this.number3;
		if (num <= 0)
		{
			return 0;
		}
		if (num > 3)
		{
			num = 3;
		}
		Buffer.BlockCopy(this.byteArray2, this.number3, 1, 2, num);
		this.number3 += num;
		return num;
	}

	// Token: 0x060014E3 RID: 5347 RVA: 0x00048C48 File Offset: 0x00046E48
	private void Method1131(int 1)
	{
		int num = (int)this.stream2.Position;
		if ((long)num >= this.stream2.Length)
		{
			return;
		}
		int num2 = num + 1;
		foreach (334 2 in this._recoveredType0155Array0642)
		{
			if (2.number <= num && 2.number2 >= num2)
			{
				this.byteArray2 = 2.byteArray;
				this.number4 = 2.number2 - 2.number;
				this.number3 = num - 2.number;
				this.stream2.Position = (long)2.number2;
				2.dateTime = DateTime.UtcNow;
				return;
			}
		}
		int num3 = 0;
		DateTime dateTime = this._recoveredType0155Array0642[0].dateTime;
		for (int j = 1; j < this._recoveredType0155Array0642.Length; j++)
		{
			if (this._recoveredType0155Array0642[j].dateTime < dateTime)
			{
				num3 = j;
			}
		}
		334 3 = this._recoveredType0155Array0642[num3];
		if (3.byteArray == null)
		{
			3.byteArray = new byte[this._recoveredType02000643.GetNumber0629_1093()];
		}
		int num4 = num;
		num = this.Method1132(num);
		if (num < 0)
		{
			num = 0;
		}
		num2 = num + this._recoveredType02000643.GetNumber0629_1093();
		if (this._recoveredType01380645 == null || !this._recoveredType01380645.Method0783(num, ref 3))
		{
			3.number = num;
			3.dateTime = DateTime.UtcNow;
			this.byteArray2 = 3.byteArray;
			this.stream2.Position = (long)num;
			this.number4 = this.stream2.Read(this.byteArray2, 0, num2 - num);
			this.number3 = num4 - num;
			3.number2 = num + this.number4;
			if (this._recoveredType01380645 != null)
			{
				this._recoveredType01380645.Method0781(3);
				return;
			}
		}
		else
		{
			this.byteArray2 = 3.byteArray;
			this.number4 = 3.number2 - num;
			this.stream2.Position = (long)3.number2;
			this.number3 = num4 - num;
		}
	}

	// Token: 0x060014E4 RID: 5348 RVA: 0x00048E4F File Offset: 0x0004704F
	private int Method1132(int 1)
	{
		return 1 - 1 % this._recoveredType02000643.GetNumber0629_1093();
	}

	// Token: 0x060014E5 RID: 5349 RVA: 0x00048E60 File Offset: 0x00047060
	public override int Read(byte[] 1, int 2, int 3)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("#=zMcx_QXg=");
		}
		if (2 < 0)
		{
			throw new ArgumentOutOfRangeException("#=zpN8VQsY=");
		}
		if (3 < 0)
		{
			throw new ArgumentOutOfRangeException("#=zkETy$Ck=");
		}
		if (1.Length - 2 < 3)
		{
			throw new ArgumentException();
		}
		int 4 = 2;
		int num = this.Method1130(1, 2, 3);
		if (num == 3)
		{
			return num;
		}
		int num2 = num;
		if (num > 0)
		{
			3 -= num;
			2 += num;
		}
		this.number3 = (this.number4 = 0);
		this.Method1129();
		if (3 < this._recoveredType02000643.GetNumber0629_1093())
		{
			this.Method1131(3);
			num = this.Method1130(1, 2, 3);
			return num + num2;
		}
		if (this._recoveredType01380645 == null)
		{
			return this.stream2.Read(1, 2, 3) + num2;
		}
		int 5 = (int)this.stream2.Position - num2;
		int num3;
		if (this._recoveredType01380645.Method0788(5, 1, 4, 3 + num2, out num3))
		{
			this.stream2.Seek((long)(num3 - num2), SeekOrigin.Current);
			return num3;
		}
		num3 = this.stream2.Read(1, 2, 3);
		if (num3 != 0)
		{
			this._recoveredType01380645.Method0787(5, 1, 4, num3 + num2, num3 < 3);
		}
		return num3 + num2;
	}

	// Token: 0x060014E6 RID: 5350 RVA: 0x00048F8C File Offset: 0x0004718C
	public override long Seek(long 1, SeekOrigin 2)
	{
		if (this.number4 - this.number3 > 0 && 2 == SeekOrigin.Current)
		{
			1 -= (long)(this.number4 - this.number3);
		}
		long position = this.Position;
		long num = this.stream2.Seek(1, 2);
		this.number3 = (int)(num - (position - (long)this.number3));
		if (0 <= this.number3 && this.number3 < this.number4)
		{
			this.stream2.Seek((long)(this.number4 - this.number3), SeekOrigin.Current);
		}
		else
		{
			this.number3 = (this.number4 = 0);
		}
		return num;
	}

	// Token: 0x040009CC RID: 2508
	private bool flag2;

	// Token: 0x040009CD RID: 2509
	private Stream stream2;

	// Token: 0x040009CE RID: 2510
	private 334[] _recoveredType0155Array0642;

	// Token: 0x040009CF RID: 2511
	private 345 _recoveredType02000643;

	// Token: 0x040009D0 RID: 2512
	private 332 _recoveredType01530644;

	// Token: 0x040009D1 RID: 2513
	private 325 _recoveredType01380645;

	// Token: 0x040009D2 RID: 2514
	private bool flag3;

	// Token: 0x040009D3 RID: 2515
	private byte[] byteArray2;

	// Token: 0x040009D4 RID: 2516
	private int number3;

	// Token: 0x040009D5 RID: 2517
	private int number4;
}
