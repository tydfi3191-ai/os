using System;

// Token: 0x02000801 RID: 2049
[276]
public abstract class 2036 : MarshalByRefObject
{
	// Token: 0x06003B60 RID: 15200 RVA: 0x00175BCF File Offset: 0x00173DCF
	public int GetDuration()
	{
		return this.2 - this.1;
	}

	// Token: 0x06003B61 RID: 15201 RVA: 0x00175BDE File Offset: 0x00173DDE
	public bool HasObjectType(2047 1)
	{
		return this.3.1(1);
	}

	// Token: 0x06003B62 RID: 15202 RVA: 0x00175BEC File Offset: 0x00173DEC
	public bool HasWhistle()
	{
		return this.4.2(1245.Whistle);
	}

	// Token: 0x06003B63 RID: 15203 RVA: 0x00175BFA File Offset: 0x00173DFA
	public void SetWhistle(bool 1)
	{
		if (1)
		{
			this.4 |= 1245.Whistle;
			return;
		}
		this.4 &= ~1245.Whistle;
	}

	// Token: 0x06003B64 RID: 15204 RVA: 0x0013FA89 File Offset: 0x0013DC89
	public bool HasFinish()
	{
		return this.4.2(1245.Finish);
	}

	// Token: 0x06003B65 RID: 15205 RVA: 0x00175C1D File Offset: 0x00173E1D
	public void SetFinish(bool 1)
	{
		if (1)
		{
			this.4 |= 1245.Finish;
			return;
		}
		this.4 &= ~1245.Finish;
	}

	// Token: 0x06003B66 RID: 15206 RVA: 0x00175C40 File Offset: 0x00173E40
	public bool HasClap()
	{
		return this.4.2(1245.Clap);
	}

	// Token: 0x06003B67 RID: 15207 RVA: 0x00175C4E File Offset: 0x00173E4E
	public void SetClap(bool 1)
	{
		if (1)
		{
			this.4 |= 1245.Clap;
			return;
		}
		this.4 &= ~1245.Clap;
	}

	// Token: 0x06003B68 RID: 15208 RVA: 0x00175C71 File Offset: 0x00173E71
	public int GetSpanDuration()
	{
		return this.GetDuration() / this.5;
	}

	// Token: 0x06003B69 RID: 15209 RVA: 0x00175C80 File Offset: 0x00173E80
	public virtual bool IsNewCombo()
	{
		return this.HasObjectType(2047.NewCombo);
	}

	// Token: 0x06003B6A RID: 15210 RVA: 0x00175C89 File Offset: 0x00173E89
	public virtual void SetNewCombo(bool 1)
	{
		if (1)
		{
			this.3 |= 2047.NewCombo;
			return;
		}
		this.3 &= ~2047.NewCombo;
	}

	// Token: 0x06003B6B RID: 15211
	public abstract 208 GetEndPosition();

	// Token: 0x06003B6C RID: 15212
	public abstract void SetEndPosition(208 1);

	// Token: 0x06003B6D RID: 15213
	public abstract int GetComboNumber();

	// Token: 0x06003B6E RID: 15214
	public abstract void SetComboNumber(int 1);

	// Token: 0x06003B6F RID: 15215 RVA: 0x00175CAC File Offset: 0x00173EAC
	public override string ToString()
	{
		return string.Concat(new string[]
		{
			this.3.ToString(),
			": ",
			this.1.ToString(),
			"-",
			this.2.ToString(),
			" stack:",
			this.9.ToString()
		});
	}

	// Token: 0x06003B70 RID: 15216 RVA: 0x0013FA97 File Offset: 0x0013DC97
	public virtual 208 GetPositionAtTime(int 1)
	{
		return this.8;
	}

	// Token: 0x04002BEF RID: 11247
	public int 1;

	// Token: 0x04002BF0 RID: 11248
	public int 2;

	// Token: 0x04002BF1 RID: 11249
	public 2047 3;

	// Token: 0x04002BF2 RID: 11250
	public 1245 4;

	// Token: 0x04002BF3 RID: 11251
	public int 5 = 1;

	// Token: 0x04002BF4 RID: 11252
	public double 6;

	// Token: 0x04002BF5 RID: 11253
	public 198 7;

	// Token: 0x04002BF6 RID: 11254
	public 208 8;

	// Token: 0x04002BF7 RID: 11255
	public int 9;

	// Token: 0x04002BF8 RID: 11256
	public bool 10;
}
