using System;

// Token: 0x02000465 RID: 1125
public abstract class 2656
{
	// Token: 0x06002277 RID: 8823 RVA: 0x0009553B File Offset: 0x0009373B
	internal bool 1()
	{
		return this.1 > 2659.None;
	}

	// Token: 0x06002278 RID: 8824 RVA: 0x00095546 File Offset: 0x00093746
	internal 2659 2()
	{
		if (this.1())
		{
			return this.1;
		}
		return this.GetDefaultGroup();
	}

	// Token: 0x06002279 RID: 8825
	internal abstract 2659 GetDefaultGroup();

	// Token: 0x0600227A RID: 8826
	internal abstract void Attach(2647 1, 2657 2, 1433 3);

	// Token: 0x0600227B RID: 8827 RVA: 0x00095560 File Offset: 0x00093760
	protected void 3(2647 1, 2657 2, 1433 3, bool 4)
	{
		if (4)
		{
			1.2(this.2());
		}
		if (2.5 != 0 && (1226.16 < 2.6 || 1226.16 > 2.5))
		{
			return;
		}
		if (!4)
		{
			if (this.1())
			{
				1.2(this.2());
			}
			else
			{
				1.3(2);
			}
		}
		2.2 = 1226.16;
		3.12(2);
	}

	// Token: 0x0600227C RID: 8828 RVA: 0x000955D3 File Offset: 0x000937D3
	internal void 4(2659 1)
	{
		if (1 > 2659.None)
		{
			throw new InvalidOperationException("Invalid trigger group");
		}
		if (this.1 != 2659.None)
		{
			throw new InvalidOperationException("A trigger's group can't be changed once set");
		}
		this.1 = 1;
	}

	// Token: 0x0600227D RID: 8829 RVA: 0x00095600 File Offset: 0x00093800
	public override string ToString()
	{
		return this.GetDefaultGroup().ToString();
	}

	// Token: 0x0600227E RID: 8830 RVA: 0x00095624 File Offset: 0x00093824
	internal static 2656 5(string 1)
	{
		2659 2;
		if (1192.1<2659>(1, out 2))
		{
			int length = 2.ToString().Length;
			string text = 1.Substring(length, 1.Length - length);
			switch (2)
			{
			case 2659.HitSound:
				return new 2641(text);
			case 2659.Passing:
				return new 2643(text);
			case 2659.Failing:
				return new 2636(text);
			case 2659.HitObjectHit:
				return new 2638(text);
			}
		}
		throw new Exception(1 + " isn't a valid trigger name");
	}

	// Token: 0x040017E2 RID: 6114
	private 2659 1;
}
