using System;
using System.Collections.Generic;

// Token: 0x020007F5 RID: 2037
[276]
public abstract class 2026 : 2039
{
	// Token: 0x06003AEB RID: 15083 RVA: 0x00173BAC File Offset: 0x00171DAC
	internal 2026(2039 1) : base(true)
	{
		this.59 = 1;
	}

	// Token: 0x06003AEC RID: 15084 RVA: 0x00173BD2 File Offset: 0x00171DD2
	protected override void OnBeatmapChanged()
	{
		this.59.6(this.21, this.22);
		base.OnBeatmapChanged();
	}

	// Token: 0x06003AED RID: 15085 RVA: 0x00173BF6 File Offset: 0x00171DF6
	internal override void RecalculateDifficulty(bool 1 = true, bool 2 = true, bool 3 = true)
	{
		this.59.RecalculateDifficulty(1, 2, true);
		base.RecalculateDifficulty(1, 2, 3);
	}

	// Token: 0x06003AEE RID: 15086 RVA: 0x00173C0F File Offset: 0x00171E0F
	protected internal override void PrepareHitObjects()
	{
		this.59.PrepareHitObjects();
		base.PrepareHitObjects();
	}

	// Token: 0x06003AEF RID: 15087 RVA: 0x00173C22 File Offset: 0x00171E22
	internal override 2037 CreateHitObjectFactory()
	{
		return new 2026.2027(this, this.59);
	}

	// Token: 0x06003AF0 RID: 15088 RVA: 0x00173C30 File Offset: 0x00171E30
	protected internal override void AddCircle(2072 1)
	{
		this.75(1);
		this.59.AddCircle(1);
		this.76(1);
		this.77();
	}

	// Token: 0x06003AF1 RID: 15089 RVA: 0x00173C52 File Offset: 0x00171E52
	protected internal override void AddSlider(2063 1)
	{
		this.75(1);
		this.59.AddSlider(1);
		this.76(1);
		this.77();
	}

	// Token: 0x06003AF2 RID: 15090 RVA: 0x00173C74 File Offset: 0x00171E74
	internal override void AddCircleReplacingContainingObject(2034 1)
	{
		this.75(1);
		this.59.AddCircleReplacingContainingObject(1);
		this.76(1);
		this.77();
	}

	// Token: 0x06003AF3 RID: 15091 RVA: 0x00173C96 File Offset: 0x00171E96
	protected internal override void AddSpinner(2070 1)
	{
		this.75(1);
		this.59.AddSpinner(1);
		this.76(1);
		this.77();
	}

	// Token: 0x06003AF4 RID: 15092 RVA: 0x00173CB8 File Offset: 0x00171EB8
	protected void 75(2034 1)
	{
		this.60 = 1;
		this.61.Clear();
	}

	// Token: 0x06003AF5 RID: 15093 RVA: 0x00173CCC File Offset: 0x00171ECC
	protected void 76(2034 1)
	{
		this.61.Add(1);
	}

	// Token: 0x06003AF6 RID: 15094 RVA: 0x00173CDC File Offset: 0x00171EDC
	protected void 77()
	{
		1282 <<EMPTY_NAME>> = this._0003_2004_2004_2005_2008_2005_2002_2002_2009_2002_2001_200A_2005_2005_2000_2005_2001_2006_2002_2008_2002();
		<<EMPTY_NAME>>.StartTime = (double)this.60.1;
		foreach (2034 2 in this.61)
		{
			<<EMPTY_NAME>>.Objects.Add(this._0006_200B_2002_2004_2006_2007_2005_2002_200B_2007_2008_2000_2001(2));
		}
		this.58.Mappings.Add(<<EMPTY_NAME>>);
	}

	// Token: 0x06003AF7 RID: 15095 RVA: 0x00005ADD File Offset: 0x00003CDD
	protected virtual void _0008_2003_2000_2005_200B_2003_2003_2007_2009_2009_2006_2009_2007_2004_2009_2004()
	{
	}

	// Token: 0x06003AF8 RID: 15096 RVA: 0x00173D64 File Offset: 0x00171F64
	protected virtual 1282 _0003_2004_2004_2005_2008_2005_2002_2002_2009_2002_2001_200A_2005_2005_2000_2005_2001_2006_2002_2008_2002()
	{
		return new 1282();
	}

	// Token: 0x06003AF9 RID: 15097
	protected abstract object _0006_200B_2002_2004_2006_2007_2005_2002_200B_2007_2008_2000_2001(2034 1);

	// Token: 0x06003AFA RID: 15098
	internal abstract 2147 _0002_2006_200A_2000_2002_2001_2002_2002_2000_2008_2006_2003_200B_2005();

	// Token: 0x04002BB2 RID: 11186
	private readonly 1283 58 = new 1283();

	// Token: 0x04002BB3 RID: 11187
	protected new readonly 2039 59;

	// Token: 0x04002BB4 RID: 11188
	private new 2034 60;

	// Token: 0x04002BB5 RID: 11189
	private new List<2034> 61 = new List<2034>();

	// Token: 0x020007F6 RID: 2038
	[276]
	public sealed class 2027 : 2037
	{
		// Token: 0x06003AFB RID: 15099 RVA: 0x00173D6B File Offset: 0x00171F6B
		internal 2027(2026 1, 2039 2) : base(2)
		{
			this.2 = 1;
		}

		// Token: 0x06003AFC RID: 15100 RVA: 0x00173D7C File Offset: 0x00171F7C
		internal override 2072 CreateCircle(208 1, int 2, bool 3, 1245 4, int 5, 1254 6, 1254 7, 1253 8, int 9, string 10)
		{
			this.1();
			return this.1.33.CreateCircle(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
		}

		// Token: 0x06003AFD RID: 15101 RVA: 0x00173DB0 File Offset: 0x00171FB0
		internal override 2063 CreateSlider(208 1, int 2, bool 3, 1245 4, 2064 5, int 6, double 7, List<208> 8, List<1245> 9, int 10, 1254 11, 1254 12, List<1254> 13, List<1254> 14, 1253 15, int 16, string 17)
		{
			this.1();
			return this.1.33.CreateSlider(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17);
		}

		// Token: 0x06003AFE RID: 15102 RVA: 0x00173DF4 File Offset: 0x00171FF4
		internal override 2072 CreateHold(208 1, int 2, int 3, bool 4, 1245 5, int 6, 1254 7, 1254 8, 1253 9, int 10, string 11)
		{
			this.1();
			return this.1.33.CreateHold(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11);
		}

		// Token: 0x06003AFF RID: 15103 RVA: 0x00173E2C File Offset: 0x0017202C
		internal override 2070 CreateSpinner(int 1, int 2, 1245 3, 1254 4, 1254 5, 1253 6, int 7, string 8)
		{
			this.1();
			return this.1.33.CreateSpinner(1, 2, 3, 4, 5, 6, 7, 8);
		}

		// Token: 0x06003B00 RID: 15104 RVA: 0x00173E5C File Offset: 0x0017205C
		private new void 1()
		{
			this.1.27 = this.2.27;
		}

		// Token: 0x04002BB6 RID: 11190
		private 2026 2;
	}
}
