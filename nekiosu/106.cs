using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

// Token: 0x020002D8 RID: 728
[ComVisible(false)]
public sealed class 106
{
	// Token: 0x060015D0 RID: 5584 RVA: 0x0004B6CD File Offset: 0x000498CD
	public 106(Stream 1) : this(1, 4096)
	{
	}

	// Token: 0x060015D1 RID: 5585 RVA: 0x0004B6DB File Offset: 0x000498DB
	public 106(Stream 1, int 2)
	{
		this.inputStream = 1;
		if (2 < 1024)
		{
			2 = 1024;
		}
		this.rawData = new byte[2];
		this.clearText = this.rawData;
	}

	// Token: 0x060015D2 RID: 5586 RVA: 0x0004B711 File Offset: 0x00049911
	public int GetRawLength()
	{
		return this.rawLength;
	}

	// Token: 0x060015D3 RID: 5587 RVA: 0x0004B719 File Offset: 0x00049919
	public byte[] GetRawData()
	{
		return this.rawData;
	}

	// Token: 0x060015D4 RID: 5588 RVA: 0x0004B721 File Offset: 0x00049921
	public int GetClearTextLength()
	{
		return this.clearTextLength;
	}

	// Token: 0x060015D5 RID: 5589 RVA: 0x0004B729 File Offset: 0x00049929
	public byte[] GetClearText()
	{
		return this.clearText;
	}

	// Token: 0x060015D6 RID: 5590 RVA: 0x0004B731 File Offset: 0x00049931
	public int GetAvailable()
	{
		return this.available;
	}

	// Token: 0x060015D7 RID: 5591 RVA: 0x0004B739 File Offset: 0x00049939
	public void SetAvailable(int 1)
	{
		this.available = 1;
	}

	// Token: 0x060015D8 RID: 5592 RVA: 0x0004B742 File Offset: 0x00049942
	public void SetInflaterInput(105 1)
	{
		if (this.available > 0)
		{
			1.Method10662(this.clearText, this.clearTextLength - this.available, this.available);
			this.available = 0;
		}
	}

	// Token: 0x060015D9 RID: 5593 RVA: 0x0004B774 File Offset: 0x00049974
	public void Fill()
	{
		this.rawLength = 0;
		int num;
		for (int i = this.rawData.Length; i > 0; i -= num)
		{
			num = this.inputStream.Read(this.rawData, this.rawLength, i);
			if (num <= 0)
			{
				break;
			}
			this.rawLength += num;
		}
		if (this.cryptoTransform != null)
		{
			this.clearTextLength = this.cryptoTransform.TransformBlock(this.rawData, 0, this.rawLength, this.clearText, 0);
		}
		else
		{
			this.clearTextLength = this.rawLength;
		}
		this.available = this.clearTextLength;
	}

	// Token: 0x060015DA RID: 5594 RVA: 0x0004B80D File Offset: 0x00049A0D
	public int Method5820(byte[] 1)
	{
		return this.Method5820(1, 0, 1.Length);
	}

	// Token: 0x060015DB RID: 5595 RVA: 0x0004B81C File Offset: 0x00049A1C
	public int Method5820(byte[] 1, int 2, int 3)
	{
		if (3 < 0)
		{
			throw new ArgumentOutOfRangeException("#=zidzotuw=");
		}
		int num = 2;
		int i = 3;
		while (i > 0)
		{
			if (this.available <= 0)
			{
				this.Fill();
				if (this.available <= 0)
				{
					return 0;
				}
			}
			int num2 = Math.Min(i, this.available);
			Array.Copy(this.rawData, this.rawLength - this.available, 1, num, num2);
			num += num2;
			i -= num2;
			this.available -= num2;
		}
		return 3;
	}

	// Token: 0x060015DC RID: 5596 RVA: 0x0004B89C File Offset: 0x00049A9C
	public int ReadClearTextBuffer(byte[] 1, int 2, int 3)
	{
		if (3 < 0)
		{
			throw new ArgumentOutOfRangeException("#=zidzotuw=");
		}
		int num = 2;
		int i = 3;
		while (i > 0)
		{
			if (this.available <= 0)
			{
				this.Fill();
				if (this.available <= 0)
				{
					return 0;
				}
			}
			int num2 = Math.Min(i, this.available);
			Array.Copy(this.clearText, this.clearTextLength - this.available, 1, num, num2);
			num += num2;
			i -= num2;
			this.available -= num2;
		}
		return 3;
	}

	// Token: 0x060015DD RID: 5597 RVA: 0x0004B91C File Offset: 0x00049B1C
	public int ReadLeByte()
	{
		if (this.available <= 0)
		{
			this.Fill();
			if (this.available <= 0)
			{
				throw new 415("EOF in header");
			}
		}
		int result = (int)this.rawData[this.rawLength - this.available];
		this.available--;
		return result;
	}

	// Token: 0x060015DE RID: 5598 RVA: 0x0004B96E File Offset: 0x00049B6E
	public int ReadLeShort()
	{
		return this.ReadLeByte() | this.ReadLeByte() << 8;
	}

	// Token: 0x060015DF RID: 5599 RVA: 0x0004B97F File Offset: 0x00049B7F
	public int ReadLeInt()
	{
		return this.ReadLeShort() | this.ReadLeShort() << 16;
	}

	// Token: 0x060015E0 RID: 5600 RVA: 0x0004B991 File Offset: 0x00049B91
	public long ReadLeLong()
	{
		return (long)((ulong)this.ReadLeInt() | (ulong)((ulong)((long)this.ReadLeInt()) << 32));
	}

	// Token: 0x060015E1 RID: 5601 RVA: 0x0004B9A8 File Offset: 0x00049BA8
	public void SetCryptoTransform(ICryptoTransform 1)
	{
		this.cryptoTransform = 1;
		if (this.cryptoTransform != null)
		{
			if (this.rawData == this.clearText)
			{
				if (this.clearTextBuffer == null)
				{
					this.clearTextBuffer = new byte[this.rawData.Length];
				}
				this.clearText = this.clearTextBuffer;
			}
			this.clearTextLength = this.rawLength;
			if (this.available > 0)
			{
				this.cryptoTransform.TransformBlock(this.rawData, this.rawLength - this.available, this.available, this.clearText, this.rawLength - this.available);
				return;
			}
		}
		else
		{
			this.clearText = this.rawData;
			this.clearTextLength = this.rawLength;
		}
	}

	// Token: 0x04000A55 RID: 2645
	private int rawLength;

	// Token: 0x04000A56 RID: 2646
	private byte[] rawData;

	// Token: 0x04000A57 RID: 2647
	private int clearTextLength;

	// Token: 0x04000A58 RID: 2648
	private byte[] clearText;

	// Token: 0x04000A59 RID: 2649
	private byte[] clearTextBuffer;

	// Token: 0x04000A5A RID: 2650
	private int available;

	// Token: 0x04000A5B RID: 2651
	private ICryptoTransform cryptoTransform;

	// Token: 0x04000A5C RID: 2652
	private Stream inputStream;
}
