using System;
using System.Collections.Generic;

// Token: 0x020006D2 RID: 1746
public sealed class 2201 : 2535
{
	// Token: 0x060033C2 RID: 13250 RVA: 0x0013CDE4 File Offset: 0x0013AFE4
	internal override void Initialize()
	{
		this.1.25 = false;
		this.3 = new 1351(null, (1376)6, 1065.BottomLeft, (1044)1, 208.Zero, 1f, true, 198.White);
		this.3.49(new 1189(this.1));
		this.3.15 = 0.6f;
		this.1.12(this.3);
		this.4.Add((2196)4, new 2195(1455.5("pippidonclear", (1416)7, false), new int[]
		{
			0,
			1,
			2,
			3,
			4,
			5,
			6,
			5,
			6,
			5,
			4,
			3,
			2,
			1,
			0
		}, 100.0));
		this.4.Add((2196)2, new 2195(1455.5("pippidonfail", (1416)7, false), null, 0.0));
		this.4.Add((2196)3, new 2195(1455.5("pippidonkiai", (1416)7, false), null, 0.0));
		this.4.Add((2196)1, new 2195(1455.5("pippidonidle", (1416)7, false), null, 0.0));
		this.3((2196)1, false);
		base.Initialize();
	}

	// Token: 0x060033C3 RID: 13251 RVA: 0x0013CF0F File Offset: 0x0013B10F
	private new void 1()
	{
		this.3.71 = 1446.LoopForever;
		this.3(this.5, false);
	}

	// Token: 0x060033C4 RID: 13252 RVA: 0x0013CF2A File Offset: 0x0013B12A
	internal void 2(208 1)
	{
		this.3.17 = 1;
	}

	// Token: 0x060033C5 RID: 13253 RVA: 0x0013CF38 File Offset: 0x0013B138
	internal void 3(2196 1, bool 2)
	{
		if (!2)
		{
			this.5 = 1;
		}
		this.6 = 1;
		if (this.3.71 != 1446.LoopOnce)
		{
			2195 3 = this.4[1];
			this.3.55(3.1);
			this.3.53((3.3 != 0.0) ? 3.3 : 1226.76());
			this.3.57(3.2);
			this.3.71 = (2 ? 1446.LoopOnce : 1446.LoopForever);
		}
	}

	// Token: 0x060033C6 RID: 13254 RVA: 0x0013CFCE File Offset: 0x0013B1CE
	internal override void Update()
	{
		if (this.3.71 == 1446.LoopForever)
		{
			this.3.53(1226.76());
		}
		base.Update();
	}

	// Token: 0x060033C7 RID: 13255 RVA: 0x0013CFF3 File Offset: 0x0013B1F3
	public 2201() : base(false)
	{
	}

	// Token: 0x040026A3 RID: 9891
	private 1351 3;

	// Token: 0x040026A4 RID: 9892
	private Dictionary<2196, 2195> 4 = new Dictionary<2196, 2195>();

	// Token: 0x040026A5 RID: 9893
	internal 2196 5;

	// Token: 0x040026A6 RID: 9894
	internal 2196 6;
}
