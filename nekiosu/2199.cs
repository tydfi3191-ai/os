using System;
using System.Collections.Generic;

// Token: 0x020006CF RID: 1743
public sealed class 2199 : 2506
{
	// Token: 0x060033B1 RID: 13233 RVA: 0x0013CAE0 File Offset: 0x0013ACE0
	internal 2199(1436 1) : base(1)
	{
		this.9 = false;
		this.3.17 = new 208(this.1.17.X + (float)this.1.39 * 1662.70.9(), this.3.17.Y);
		this.3.3.Add(new 1445(1456.Scale, 0f, 1f, 1662.33, 1662.33 + 1000, (1046)1));
		this.3.3.Add(new 1445(1456.Rotation, -4f, 0f, 1662.33, 1662.33 + 1000, (1046)1));
	}

	// Token: 0x060033B2 RID: 13234 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal override void Show()
	{
	}

	// Token: 0x060033B3 RID: 13235 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal override void Hide()
	{
	}

	// Token: 0x060033B4 RID: 13236 RVA: 0x0013CBB0 File Offset: 0x0013ADB0
	protected override void OnVisibilityChanged(bool 1)
	{
		if (!2)
		{
			this.20.ForEach(delegate(1433 1)
			{
				1.16(100, (1046)0, 0);
			});
		}
		base.OnVisibilityChanged(2);
	}

	// Token: 0x060033B5 RID: 13237 RVA: 0x0013CBE6 File Offset: 0x0013ADE6
	internal override void AddHealth(double 1)
	{
		base.AddHealth(1 * 0.06);
		this.11();
	}

	// Token: 0x060033B6 RID: 13238 RVA: 0x0013CBFF File Offset: 0x0013ADFF
	protected override 1381 GetTexture(string 1)
	{
		return 1455.2(1, (1416)3, null);
	}

	// Token: 0x060033B7 RID: 13239 RVA: 0x0013CC09 File Offset: 0x0013AE09
	protected override 1381[] GetFrames(string 1)
	{
		return 1455.5(1, (1416)3, true);
	}

	// Token: 0x060033B8 RID: 13240 RVA: 0x00005ADD File Offset: 0x00003CDD
	protected override void UpdateMarkerPosition()
	{
	}

	// Token: 0x060033B9 RID: 13241 RVA: 0x0013CC14 File Offset: 0x0013AE14
	private new void 11()
	{
		if (2486.21 || base.3() == 200.0 == this.19)
		{
			return;
		}
		this.19 = (base.3() == 200.0);
		if (this.19)
		{
			1433 <<EMPTY_NAME>> = this.1.Clone();
			<<EMPTY_NAME>>.28 = true;
			<<EMPTY_NAME>>.2 += 0.01f;
			1445 2 = new 1445(1456.Fade, 0.2f, 1f, 1662.33, 1662.33 + 1000, (1046)0);
			2.17 = true;
			2.11 = 1000;
			<<EMPTY_NAME>>.3.Add(2);
			2 = new 1445(1456.Fade, 1f, 0.12f, 1662.33 + 1000, 1662.33 + 2000, (1046)0);
			2.17 = true;
			2.11 = 1000;
			<<EMPTY_NAME>>.3.Add(2);
			this.20.Add(<<EMPTY_NAME>>);
			this.3.28 = true;
			this.20.Add(<<EMPTY_NAME>>);
			this.7.14<1433>(this.20);
			return;
		}
		this.20.ForEach(delegate(1433 1)
		{
			1.16(50, (1046)0, 0);
			1.5 = false;
		});
		this.20.Clear();
		this.3.28 = false;
	}

	// Token: 0x060033BA RID: 13242 RVA: 0x0013CD86 File Offset: 0x0013AF86
	internal override void Drain(double 1)
	{
		base.Drain(1 * 0.06);
		this.11();
	}

	// Token: 0x060033BB RID: 13243 RVA: 0x0013CD9F File Offset: 0x0013AF9F
	internal override void ResetToFull()
	{
		base.ResetToFull();
		this.SetHealth(0.0);
	}

	// Token: 0x0400269B RID: 9883
	private bool 19;

	// Token: 0x0400269C RID: 9884
	private List<1433> 20 = new List<1433>();

	// Token: 0x020006D0 RID: 1744
	[Serializable]
	public sealed class 2200
	{
		// Token: 0x0400269D RID: 9885
		public static readonly 2199.2200 instance = new 2199.2200();

		// Token: 0x0400269E RID: 9886
		public static Action<1433> action;

		// Token: 0x0400269F RID: 9887
		public static Action<1433> action2;
	}
}
