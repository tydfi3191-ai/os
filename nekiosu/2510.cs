using System;
using System.Collections.Generic;

// Token: 0x02000502 RID: 1282
[276]
internal abstract class 2510 : IDisposable
{
	// Token: 0x06002737 RID: 10039 RVA: 0x000C37B6 File Offset: 0x000C19B6
	protected 2510(2511 1, 2528 2)
	{
		this.1 = 1;
		this.2 = 2;
		2.27 = new Action<string>(this.OnSettingChanged);
	}

	// Token: 0x17000256 RID: 598
	// (get) Token: 0x06002738 RID: 10040 RVA: 0x000C37EA File Offset: 0x000C19EA
	protected 1436 Layer
	{
		get
		{
			return this.1.1;
		}
	}

	// Token: 0x17000257 RID: 599
	// (get) Token: 0x06002739 RID: 10041 RVA: 0x000C37F7 File Offset: 0x000C19F7
	protected 208 Pivot
	{
		get
		{
			return this.2.34(2528.WindowWidth, 480f);
		}
	}

	// Token: 0x0600273A RID: 10042 RVA: 0x000C3810 File Offset: 0x000C1A10
	protected T 1<T>(T 1, bool 2 = true) where T : 1371
	{
		this.Layer.12(1);
		if (2)
		{
			this.2.22(1);
		}
		else
		{
			1.18 = this.2;
		}
		this.3.Add(1);
		this.2.32();
		return 1;
	}

	// Token: 0x0600273B RID: 10043 RVA: 0x000C3874 File Offset: 0x000C1A74
	protected void Remove(1371 1)
	{
		if (1 == null || !this.3.Remove(1))
		{
			return;
		}
		this.2.23(1);
		bool 2 = 1.27;
		this.Layer.Remove(1);
		if (!2)
		{
			1.Dispose();
		}
		this.2.32();
	}

	// Token: 0x0600273C RID: 10044 RVA: 0x000C38C4 File Offset: 0x000C1AC4
	protected void 2()
	{
		foreach (1371 <<EMPTY_NAME>> in this.3.ToArray())
		{
			this.Remove(<<EMPTY_NAME>>);
		}
	}

	// Token: 0x0600273D RID: 10045
	internal abstract void Build();

	// Token: 0x0600273E RID: 10046
	internal abstract void Update();

	// Token: 0x0600273F RID: 10047 RVA: 0x000C38F6 File Offset: 0x000C1AF6
	protected virtual void OnSettingChanged(string 1)
	{
		if (!this.4)
		{
			this.2();
			this.Build();
			2522.15();
		}
	}

	// Token: 0x06002740 RID: 10048 RVA: 0x000C3914 File Offset: 0x000C1B14
	protected void 3(1452 1, float 2)
	{
		float num = Math.Max(0.05f, this.2.10);
		if (1.69 != num || Math.Abs(1.65() - 2 * num) > 0.001f)
		{
			1.69 = num;
			1.66(2 * num);
		}
	}

	// Token: 0x06002741 RID: 10049 RVA: 0x000C3966 File Offset: 0x000C1B66
	public virtual void Dispose()
	{
		this.4 = true;
		this.2();
		if (this.2.27 == new Action<string>(this.OnSettingChanged))
		{
			this.2.27 = null;
		}
	}

	// Token: 0x06002742 RID: 10050 RVA: 0x000C39A0 File Offset: 0x000C1BA0
	protected static 1452 4(string 1, float 2, 208 3, 1065 4, 198 5, bool 6 = false)
	{
		1452 7 = new 1452(1, 2, 3, 0.95f, true, 5);
		7.49 = 4;
		7.63(6);
		return 7;
	}

	// Token: 0x06002743 RID: 10051 RVA: 0x000C39C4 File Offset: 0x000C1BC4
	protected static 1433 5(208 1, 208 2, 1065 3, 198 4, float 5 = 0.95f)
	{
		return new 1433(1662.34, (1376)6, 3, (1044)0, 1, 5, true, 4, null)
		{
			15 = 1.6f,
			20 = 2
		};
	}

	// Token: 0x04001C3C RID: 7228
	protected readonly 2511 1;

	// Token: 0x04001C3D RID: 7229
	internal readonly 2528 2;

	// Token: 0x04001C3E RID: 7230
	private readonly List<1371> 3 = new List<1371>();

	// Token: 0x04001C3F RID: 7231
	private bool 4;
}
