using System;
using System.Runtime.InteropServices;

// Token: 0x020002D0 RID: 720
[ComVisible(false)]
public sealed class 51
{
	// Token: 0x0600156B RID: 5483 RVA: 0x00049BB6 File Offset: 0x00047DB6
	public 51() : this(-1, false)
	{
	}

	// Token: 0x0600156C RID: 5484 RVA: 0x00049BC0 File Offset: 0x00047DC0
	public 51(int 1) : this(1, false)
	{
	}

	// Token: 0x0600156D RID: 5485 RVA: 0x00049BCC File Offset: 0x00047DCC
	public 51(int 1, bool 2)
	{
		if (1 != -1)
		{
			if (1 > 9)
			{
				throw new ArgumentOutOfRangeException("#=zsQQ_ZcE=");
			}
		}
		else
		{
			1 = 6;
		}
		this.pending = new 760();
		this.engine = new 795(this.pending);
		this.noZlibHeaderOrFooter = 2;
		this.SetStrategy((589)0);
		this.SetLevel(1);
		this.Reset();
	}

	// Token: 0x0600156E RID: 5486 RVA: 0x00049C31 File Offset: 0x00047E31
	public void Reset()
	{
		this.state = (this.noZlibHeaderOrFooter ? 16 : 0);
		this.totalOut = 0L;
		this.pending.SetNumber8068_10315();
		this.engine.Method13207();
	}

	// Token: 0x0600156F RID: 5487 RVA: 0x00049C64 File Offset: 0x00047E64
	public int GetAdler()
	{
		return this.engine.Method13209();
	}

	// Token: 0x06001570 RID: 5488 RVA: 0x00049C71 File Offset: 0x00047E71
	public long GetTotalIn()
	{
		return this.engine.GetNumber10273_13210();
	}

	// Token: 0x06001571 RID: 5489 RVA: 0x00049C7E File Offset: 0x00047E7E
	public long GetTotalOut()
	{
		return this.totalOut;
	}

	// Token: 0x06001572 RID: 5490 RVA: 0x00049C86 File Offset: 0x00047E86
	public void Flush()
	{
		this.state |= 4;
	}

	// Token: 0x06001573 RID: 5491 RVA: 0x00049C96 File Offset: 0x00047E96
	public void Finish()
	{
		this.state |= 12;
	}

	// Token: 0x06001574 RID: 5492 RVA: 0x00049CA7 File Offset: 0x00047EA7
	public bool IsFinished()
	{
		return this.state == 30 && this.pending.Method10324();
	}

	// Token: 0x06001575 RID: 5493 RVA: 0x00049CC0 File Offset: 0x00047EC0
	public bool IsNeedingInput()
	{
		return this.engine.Method13205();
	}

	// Token: 0x06001576 RID: 5494 RVA: 0x00049CCD File Offset: 0x00047ECD
	public void Method10464(byte[] 1)
	{
		this.Method10464(1, 0, 1.Length);
	}

	// Token: 0x06001577 RID: 5495 RVA: 0x00049CDA File Offset: 0x00047EDA
	public void Method10464(byte[] 1, int 2, int 3)
	{
		if ((this.state & 8) != 0)
		{
			throw new InvalidOperationException("Finish() already called");
		}
		this.engine.Method13204(1, 2, 3);
	}

	// Token: 0x06001578 RID: 5496 RVA: 0x00049CFF File Offset: 0x00047EFF
	public void SetLevel(int 1)
	{
		if (1 != -1)
		{
			if (1 > 9)
			{
				throw new ArgumentOutOfRangeException("#=zsQQ_ZcE=");
			}
		}
		else
		{
			1 = 6;
		}
		if (this.level != 1)
		{
			this.level = 1;
			this.engine.Method13213(1);
		}
	}

	// Token: 0x06001579 RID: 5497 RVA: 0x00049D38 File Offset: 0x00047F38
	public int GetLevel()
	{
		return this.level;
	}

	// Token: 0x0600157A RID: 5498 RVA: 0x00049D40 File Offset: 0x00047F40
	public void SetStrategy(589 1)
	{
		this.engine.SetRecoveredType139910266_13212(1);
	}

	// Token: 0x0600157B RID: 5499 RVA: 0x00049D4E File Offset: 0x00047F4E
	public int Method10469(byte[] 1)
	{
		return this.Method10469(1, 0, 1.Length);
	}

	// Token: 0x0600157C RID: 5500 RVA: 0x00049D5C File Offset: 0x00047F5C
	public int Method10469(byte[] 1, int 2, int 3)
	{
		int num = 3;
		if (this.state == 127)
		{
			throw new InvalidOperationException("Deflater closed");
		}
		if (this.state < 16)
		{
			int num2 = 30720;
			int num3 = this.level - 1 >> 1;
			if (num3 < 0 || num3 > 3)
			{
				num3 = 3;
			}
			num2 |= num3 << 6;
			if ((this.state & 1) != 0)
			{
				num2 |= 32;
			}
			num2 += 31 - num2 % 31;
			this.pending.Method10323(num2);
			if ((this.state & 1) != 0)
			{
				int num4 = this.engine.Method13209();
				this.engine.Method13208();
				this.pending.Method10323(num4 >> 16);
				this.pending.Method10323(num4 & 65535);
			}
			this.state = (16 | (this.state & 12));
		}
		for (;;)
		{
			int num5 = this.pending.Method10325(1, 2, 3);
			2 += num5;
			this.totalOut += (long)num5;
			3 -= num5;
			if (3 == 0 || this.state == 30)
			{
				goto IL_1D8;
			}
			if (!this.engine.Method13203((this.state & 4) != 0, (this.state & 8) != 0))
			{
				if (this.state == 16)
				{
					break;
				}
				if (this.state == 20)
				{
					if (this.level != 0)
					{
						for (int i = 8 + (-this.pending.GetNumber8071_10320() & 7); i > 0; i -= 10)
						{
							this.pending.Method10322(2, 10);
						}
					}
					this.state = 16;
				}
				else if (this.state == 28)
				{
					this.pending.Method10321();
					if (!this.noZlibHeaderOrFooter)
					{
						int num6 = this.engine.Method13209();
						this.pending.Method10323(num6 >> 16);
						this.pending.Method10323(num6 & 65535);
					}
					this.state = 30;
				}
			}
		}
		return num - 3;
		IL_1D8:
		return num - 3;
	}

	// Token: 0x0600157D RID: 5501 RVA: 0x00049F44 File Offset: 0x00048144
	public void Method10471(byte[] 1)
	{
		this.Method10471(1, 0, 1.Length);
	}

	// Token: 0x0600157E RID: 5502 RVA: 0x00049F51 File Offset: 0x00048151
	public void Method10471(byte[] 1, int 2, int 3)
	{
		if (this.state != 0)
		{
			throw new InvalidOperationException();
		}
		this.state = 1;
		this.engine.Method13206(1, 2, 3);
	}

	// Token: 0x04000A1D RID: 2589
	private int level;

	// Token: 0x04000A1E RID: 2590
	private bool noZlibHeaderOrFooter;

	// Token: 0x04000A1F RID: 2591
	private int state;

	// Token: 0x04000A20 RID: 2592
	private long totalOut;

	// Token: 0x04000A21 RID: 2593
	private 760 pending;

	// Token: 0x04000A22 RID: 2594
	private 795 engine;
}
