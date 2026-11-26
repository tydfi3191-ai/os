using System;

// Token: 0x0200029F RID: 671
public sealed class 801
{
	// Token: 0x06001463 RID: 5219 RVA: 0x00046D95 File Offset: 0x00044F95
	public 801()
	{
		this.Method13414();
	}

	// Token: 0x06001464 RID: 5220 RVA: 0x00046DA3 File Offset: 0x00044FA3
	private long Method13411()
	{
		return this.Method13412();
	}

	// Token: 0x06001465 RID: 5221 RVA: 0x00046DAC File Offset: 0x00044FAC
	private long Method13412()
	{
		long num = this.number;
		if (this.flag)
		{
			long num2 = 801.Method13413() - this.number2;
			num += num2;
		}
		return num;
	}

	// Token: 0x06001466 RID: 5222 RVA: 0x00046DDC File Offset: 0x00044FDC
	public static long Method13413()
	{
		return DateTime.UtcNow.Ticks;
	}

	// Token: 0x06001467 RID: 5223 RVA: 0x00046DF6 File Offset: 0x00044FF6
	public void Method13414()
	{
		this.number = 0L;
		this.flag = false;
		this.number2 = 0L;
	}

	// Token: 0x06001468 RID: 5224 RVA: 0x00046E0F File Offset: 0x0004500F
	public void Method13415()
	{
		if (!this.flag)
		{
			this.number2 = 801.Method13413();
			this.flag = true;
		}
	}

	// Token: 0x06001469 RID: 5225 RVA: 0x00046E2B File Offset: 0x0004502B
	public static 801 Method13416()
	{
		801 <<EMPTY_NAME>> = new 801();
		<<EMPTY_NAME>>.Method13415();
		return <<EMPTY_NAME>>;
	}

	// Token: 0x0600146A RID: 5226 RVA: 0x00046E38 File Offset: 0x00045038
	public void Method13417()
	{
		if (this.flag)
		{
			long num = 801.Method13413() - this.number2;
			this.number += num;
			this.flag = false;
		}
	}

	// Token: 0x0600146B RID: 5227 RVA: 0x00046E6F File Offset: 0x0004506F
	public TimeSpan Method13418()
	{
		return new TimeSpan(this.Method13411());
	}

	// Token: 0x0600146C RID: 5228 RVA: 0x00046E7C File Offset: 0x0004507C
	public long Method13419()
	{
		return this.Method13411() / 10000L;
	}

	// Token: 0x0600146D RID: 5229 RVA: 0x00046DA3 File Offset: 0x00044FA3
	public long Method13420()
	{
		return this.Method13412();
	}

	// Token: 0x0600146E RID: 5230 RVA: 0x00046E8B File Offset: 0x0004508B
	public bool GetFlag10396_13421()
	{
		return this.flag;
	}

	// Token: 0x04000998 RID: 2456
	private long number;

	// Token: 0x04000999 RID: 2457
	private bool flag;

	// Token: 0x0400099A RID: 2458
	private long number2;
}
