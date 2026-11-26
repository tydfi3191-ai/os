using System;

// Token: 0x02000BB8 RID: 3000
public sealed class 1250 : 1350
{
	// Token: 0x0600529C RID: 21148 RVA: 0x00208450 File Offset: 0x00206650
	public 1250() : base(1662.11)
	{
	}

	// Token: 0x0600529D RID: 21149 RVA: 0x002084D6 File Offset: 0x002066D6
	public void Reset()
	{
		this.3 = -1;
		this.4 = (1272.5().6 % 2.0 == 0.0);
	}

	// Token: 0x0600529E RID: 21150 RVA: 0x00208504 File Offset: 0x00206704
	public override void Update()
	{
		if (!1226.75() || !1226.40 || (double)1226.16 < 1226.79())
		{
			return;
		}
		int num = (int)(1226.64() * 2.0 / 1226.76());
		if (num == this.3)
		{
			return;
		}
		this.3 = num;
		int num2 = num % (int)1226.84();
		if (num % (int)((1257)8 * 1226.84()) == 0)
		{
			this.5.Play(true, true);
			bool flag = false;
			try
			{
				flag = (num > 0 || (1226.81()[1226.70].8 & (1258)8) == (1258)0);
			}
			catch
			{
			}
			if (flag)
			{
				this.6.Play(true, true);
				return;
			}
		}
		else
		{
			if (num2 % 4 == 0)
			{
				this.5.Play(true, true);
				return;
			}
			if (num2 % 4 == 2)
			{
				this.7.Play(true, true);
				return;
			}
			if (this.4)
			{
				this.8.Play(true, true);
			}
		}
	}

	// Token: 0x04003EDD RID: 16093
	private int 3 = -1;

	// Token: 0x04003EDE RID: 16094
	private bool 4 = true;

	// Token: 0x04003EDF RID: 16095
	private 1256 5 = new 1256(1226.48("nightcore-kick", false, true, (1416)3));

	// Token: 0x04003EE0 RID: 16096
	private 1256 6 = new 1256(1226.48("nightcore-finish", false, true, (1416)3));

	// Token: 0x04003EE1 RID: 16097
	private 1256 7 = new 1256(1226.48("nightcore-clap", false, true, (1416)3));

	// Token: 0x04003EE2 RID: 16098
	private 1256 8 = new 1256(1226.48("nightcore-hat", false, true, (1416)3));
}
