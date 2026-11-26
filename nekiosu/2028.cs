using System;

// Token: 0x020007F7 RID: 2039
[276]
public sealed class 2028 : 2039
{
	// Token: 0x06003B01 RID: 15105 RVA: 0x00173E74 File Offset: 0x00172074
	internal 2028(bool 1, bool 2 = true) : base(2)
	{
		this.58 = 1;
	}

	// Token: 0x06003B02 RID: 15106 RVA: 0x00173E84 File Offset: 0x00172084
	protected override void ClearBeatmapResources()
	{
		if (!this.58)
		{
			base.ClearBeatmapResources();
		}
	}

	// Token: 0x06003B03 RID: 15107 RVA: 0x0014A52B File Offset: 0x0014872B
	internal override 2037 CreateHitObjectFactory()
	{
		return new 2121(this);
	}

	// Token: 0x06003B04 RID: 15108 RVA: 0x00173E94 File Offset: 0x00172094
	protected internal override void AddSlider(2063 1)
	{
		if (this.21.3() == 2147.OsuMania)
		{
			2048 2 = new 2048(this, 1.8, 1.1, false, 1.4, 0)
			{
				2 = ((2123)1).25(),
				32 = 1.32,
				33 = 1.33,
				35 = 1.35,
				36 = 1.36,
				34 = 1.34,
				37 = 1.37
			};
			this.AddHitObject(2, false, true);
			1.Dispose();
			return;
		}
		this.AddHitObject(1, false, true);
	}

	// Token: 0x06003B05 RID: 15109 RVA: 0x00173F3F File Offset: 0x0017213F
	internal override void UpdateTimeWindowObjects()
	{
		this.59 = false;
		base.UpdateTimeWindowObjects();
		this.37.Clear();
		if (!this.59 && 1226.19())
		{
			1226.34();
		}
	}

	// Token: 0x06003B06 RID: 15110 RVA: 0x00173F70 File Offset: 0x00172170
	protected override void ProcessOverdueJudgement(2034 1)
	{
		2123 2 = 1 as 2123;
		if (2 != null && 1226.16 >= 2.1 && 1226.16 <= 2.2)
		{
			2.48();
			this.59 = true;
		}
		if (1226.32 == (1042)1 && 1226.43 < 300f)
		{
			if ((1.1 <= 1226.16 && 1.1 >= 1226.18 && !1.HasObjectType(2047.Spinner)) || (1.2 <= 1226.16 && 1.2 >= 1226.18))
			{
				if (!1.31)
				{
					1.PlayHitSound();
					1.31 = true;
				}
			}
			else if (1.31 && (float)Math.Abs(1.1 - 1226.16) > 1226.43 * 4f)
			{
				1.31 = false;
			}
		}
		base.ProcessOverdueJudgement(1);
	}

	// Token: 0x06003B07 RID: 15111 RVA: 0x00174054 File Offset: 0x00172254
	internal override void AddCircleReplacingContainingObject(2034 1)
	{
		2028.2029 2 = new 2028.2029();
		2.1 = 1;
		2034 3 = this.34.Find(new Predicate<2034>(2.1));
		if (3 != null)
		{
			base.29(3, false);
		}
		this.AddHitObject(2.1, false, true);
	}

	// Token: 0x06003B08 RID: 15112 RVA: 0x001740A0 File Offset: 0x001722A0
	internal override void RemoveContainingObject(2034 1)
	{
		2028.2030 2 = new 2028.2030();
		2.1 = 1;
		2034 3 = this.34.Find(new Predicate<2034>(2.1));
		if (3 != null)
		{
			base.29(3, false);
		}
	}

	// Token: 0x04002BB7 RID: 11191
	private readonly bool 58;

	// Token: 0x04002BB8 RID: 11192
	private new bool 59;

	// Token: 0x020007F8 RID: 2040
	[276]
	public sealed class 2029
	{
		// Token: 0x06003B09 RID: 15113 RVA: 0x001740E0 File Offset: 0x001722E0
		internal bool 1(2034 1)
		{
			return 1.1 <= this.1.1 && 1.2 >= this.1.2 && 1.8.X == this.1.8.X;
		}

		// Token: 0x04002BB9 RID: 11193
		public 2034 1;
	}

	// Token: 0x020007F9 RID: 2041
	[276]
	public sealed class 2030
	{
		// Token: 0x06003B0B RID: 15115 RVA: 0x00174134 File Offset: 0x00172334
		internal bool 1(2034 1)
		{
			return 1 != this.1 && 1.1 <= this.1.1 && 1.2 >= this.1.2 && 1.8.X == this.1.8.X;
		}

		// Token: 0x04002BBA RID: 11194
		public 2034 1;
	}
}
