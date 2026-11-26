using System;

// Token: 0x02000AB9 RID: 2745
public sealed class 1422 : 1404
{
	// Token: 0x06004C3B RID: 19515 RVA: 0x001E1B3C File Offset: 0x001DFD3C
	public 1422(int 1, 208 2, int 3 = 20, 1066 4 = (1066)0) : base(6, 2, 0f, true, 0.98f)
	{
		1422.1424 searchTextBoxClosure = new 1422.1424
		{
			1 = 4
		};
		searchTextBoxClosure.2 = this;
		base.24(true);
		this.1.54(false);
		this.1.10 = false;
		this.4 = 3;
		this.30 = (float)6;
		this.31 = 2;
		this.32 = searchTextBoxClosure.1;
		base.22(false);
		base.26(1568.1(2679.SongSelection_TypeToBegin));
		this.29 = new 1386(1048.search, (float)(6 + 2), new 208(2.X, 2.Y + (float)6 * 0.1f));
		this.29.2 = this.1.2;
		this.2.Add(this.29);
		if (searchTextBoxClosure.1 != (1066)2)
		{
			1452 5 = this.1;
			5.17.X = 5.17.X + (float)6;
		}
		this.2.ForEach(delegate(1433 1)
		{
			switch (searchTextBoxClosure.1)
			{
			case (1066)0:
				1.41 = (1376)6;
				1.49 = 1065.TopLeft;
				return;
			case (1066)1:
				break;
			case (1066)2:
				1.41 = (1376)7;
				1.49 = 1065.TopCentre;
				return;
			case (1066)3:
				1.41 = (1376)8;
				1.49 = 1065.TopRight;
				break;
			default:
				return;
			}
		});
		base.4(new 1448.1449(searchTextBoxClosure.6));
	}

	// Token: 0x06004C3C RID: 19516 RVA: 0x001E1C85 File Offset: 0x001DFE85
	public bool 28()
	{
		return this.8;
	}

	// Token: 0x06004C3D RID: 19517 RVA: 0x001E1C90 File Offset: 0x001DFE90
	private void 29()
	{
		if (this.32 == (1066)2)
		{
			float x = this.1.GetTextSize().X;
			this.1.17.X = this.31.X + this.30 / 2f;
			this.29.17.X = this.31.X - x / 2f;
		}
	}

	// Token: 0x06004C3E RID: 19518 RVA: 0x001E1D02 File Offset: 0x001DFF02
	internal void 30()
	{
		this.2.ForEach(new Action<1433>(1422.1423.instance.1));
	}

	// Token: 0x040038BB RID: 14523
	private 1386 29;

	// Token: 0x040038BC RID: 14524
	private float 30;

	// Token: 0x040038BD RID: 14525
	private 208 31;

	// Token: 0x040038BE RID: 14526
	private 1066 32;

	// Token: 0x02000ABA RID: 2746
	[Serializable]
	public sealed class 1423
	{
		// Token: 0x06004C3F RID: 19519 RVA: 0x001E1D1F File Offset: 0x001DFF1F
		internal void 1(1433 1)
		{
			1.40(2630.14, 500);
			1.14 = 1196.7(-0.5f, 0.5f);
			1.26(0f, 500, (1046)0);
		}

		// Token: 0x040038BF RID: 14527
		public static readonly 1422.1423 instance = new 1422.1423();

		// Token: 0x040038C0 RID: 14528
		public static Action<1433> action;
	}

	// Token: 0x02000ABB RID: 2747
	public sealed class 1424
	{
		// Token: 0x06004C42 RID: 19522 RVA: 0x001E1D63 File Offset: 0x001DFF63
		internal void 1(1448 1, bool 2)
		{
			this.2.29();
		}

		// Token: 0x040038C1 RID: 14529
		public 1066 1;

		// Token: 0x040038C2 RID: 14530
		public 1422 2;
	}
}
