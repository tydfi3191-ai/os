using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;

// Token: 0x02000ADB RID: 2779
public class 1452 : 1413
{
	// Token: 0x06004D53 RID: 19795 RVA: 0x001EA67C File Offset: 0x001E887C
	internal 1452(string 1, float 2, 208 3, 208 4, float 5, bool 6, 198 7, bool 8 = true) : base(null, (1376)6, 1065.TopLeft, (1044)0, 3, 5, 6, 7)
	{
		this.SetText(1);
		this.27 = true;
		this.62(198.White);
		this.63((7.R != 0 || 7.G != 0 || 7.B > 0) && 8);
		this.66(2);
		this.75 = (1066)0;
		this.77 = 4;
		this.74 = true;
		if (2 * 1662.70.3() <= 15f)
		{
			this.40 = new bool?(true);
		}
		this.66 = false;
		this.85 = true;
	}

	// Token: 0x06004D54 RID: 19796 RVA: 0x001EA744 File Offset: 0x001E8944
	protected 1452(string 1, 1376 2, 1065 3, 1044 4, 208 5, float 6, bool 7, 198 8) : base(null, 2, 3, 4, 5)
	{
		this.2 = 6;
		this.5 = 7;
		this.6 = 8;
		this.16 = (float)this.6.A / 255f;
	}

	// Token: 0x06004D55 RID: 19797 RVA: 0x001EA7AC File Offset: 0x001E89AC
	public 1452(string 1, float 2, 208 3, float 4, bool 5, 198 6) : this(1, 2, 3, 208.Zero, 4, 5, 6, true)
	{
	}

	// Token: 0x06004D56 RID: 19798 RVA: 0x001EA7D0 File Offset: 0x001E89D0
	internal new void 52(EventHandler 1)
	{
		EventHandler eventHandler = this.76;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, 1);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.76, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06004D57 RID: 19799 RVA: 0x001EA805 File Offset: 0x001E8A05
	internal new bool 53()
	{
		return this.80;
	}

	// Token: 0x06004D58 RID: 19800 RVA: 0x001EA80D File Offset: 0x001E8A0D
	internal new void 54(bool 1)
	{
		if (this.80 != 1)
		{
			this.80 = 1;
			this.88 = true;
		}
	}

	// Token: 0x06004D59 RID: 19801 RVA: 0x001EA826 File Offset: 0x001E8A26
	internal new bool 55()
	{
		return this.81;
	}

	// Token: 0x06004D5A RID: 19802 RVA: 0x001EA82E File Offset: 0x001E8A2E
	internal void 56(bool 1)
	{
		if (this.81 != 1)
		{
			this.81 = 1;
			this.88 = true;
		}
	}

	// Token: 0x06004D5B RID: 19803 RVA: 0x001EA847 File Offset: 0x001E8A47
	internal 198 57()
	{
		return this.82;
	}

	// Token: 0x06004D5C RID: 19804 RVA: 0x001EA84F File Offset: 0x001E8A4F
	internal void 58(198 1)
	{
		if (!(this.82 == 1))
		{
			this.82 = 1;
			this.88 = true;
		}
	}

	// Token: 0x06004D5D RID: 19805 RVA: 0x001EA86D File Offset: 0x001E8A6D
	internal new 198 59()
	{
		return this.83;
	}

	// Token: 0x06004D5E RID: 19806 RVA: 0x001EA875 File Offset: 0x001E8A75
	internal void 60(198 1)
	{
		if (!(this.83 == 1))
		{
			this.83 = 1;
			this.88 = true;
		}
	}

	// Token: 0x06004D5F RID: 19807 RVA: 0x001EA893 File Offset: 0x001E8A93
	internal new 198 61()
	{
		return this.84;
	}

	// Token: 0x06004D60 RID: 19808 RVA: 0x001EA89B File Offset: 0x001E8A9B
	internal new void 62(198 1)
	{
		if (!(this.84 == 1))
		{
			this.84 = 1;
			this.88 = true;
		}
	}

	// Token: 0x06004D61 RID: 19809 RVA: 0x001EA8B9 File Offset: 0x001E8AB9
	internal new void 63(bool 1)
	{
		this.86 = (1 ? ((1067)1) : ((1067)0));
	}

	// Token: 0x06004D62 RID: 19810 RVA: 0x001EA8C8 File Offset: 0x001E8AC8
	internal new void 64(bool 1)
	{
		this.86 = (1 ? ((1067)2) : ((1067)0));
	}

	// Token: 0x06004D63 RID: 19811 RVA: 0x001EA8D7 File Offset: 0x001E8AD7
	internal virtual string GetText()
	{
		return this.87;
	}

	// Token: 0x06004D64 RID: 19812 RVA: 0x001EA8DF File Offset: 0x001E8ADF
	internal virtual void SetText(string 1)
	{
		if (!(this.87 == 1))
		{
			this.88 = true;
			this.87 = 1;
		}
	}

	// Token: 0x06004D65 RID: 19813 RVA: 0x001EA8FD File Offset: 0x001E8AFD
	internal float 65()
	{
		return this.89;
	}

	// Token: 0x06004D66 RID: 19814 RVA: 0x001EA905 File Offset: 0x001E8B05
	internal new void 66(float 1)
	{
		if (this.89 != 1)
		{
			this.88 = true;
			this.89 = 1;
		}
	}

	// Token: 0x06004D67 RID: 19815 RVA: 0x001EA91E File Offset: 0x001E8B1E
	internal new void 67(1068 1)
	{
		if (1 != this.92)
		{
			this.92 = 1;
			this.88 = true;
		}
	}

	// Token: 0x06004D68 RID: 19816 RVA: 0x001EA937 File Offset: 0x001E8B37
	internal new void 68(bool 1)
	{
		this.91 = 1;
		if (base.GetTexture() != null)
		{
			base.GetTexture().10 = true;
			1414.2(this, true);
		}
	}

	// Token: 0x06004D69 RID: 19817 RVA: 0x001EA95C File Offset: 0x001E8B5C
	public override 1433 Clone()
	{
		return new 1452(this.GetText(), this.65(), this.17, this.2, this.5, this.6)
		{
			75 = this.75,
			47 = this.47,
			48 = this.48,
			49 = this.49,
			17 = this.17,
			36 = this.36,
			37 = this.37,
			35 = this.35,
			34 = this.34
		};
	}

	// Token: 0x06004D6A RID: 19818 RVA: 0x001EAA00 File Offset: 0x001E8C00
	internal override 1381 GetTexture()
	{
		if (string.IsNullOrEmpty(this.87) && this.57().A == 0)
		{
			return null;
		}
		if (this.47 != null && !this.47.5() && !this.88 && 1662.70.2 == this.73)
		{
			return this.47;
		}
		return this.RegenerateTexture();
	}

	// Token: 0x06004D6B RID: 19819 RVA: 0x00005BE8 File Offset: 0x00003DE8
	internal override void SetTexture(1381 1)
	{
		throw new NotSupportedException();
	}

	// Token: 0x06004D6C RID: 19820 RVA: 0x001EAA68 File Offset: 0x001E8C68
	internal new List<int> 69(RectangleF[] 1)
	{
		List<int> list = new List<int>();
		list.Add(0);
		if (this.GetText().Length == 0)
		{
			return list;
		}
		float y = 1[0].Y;
		for (int i = 1; i < this.GetText().Length; i++)
		{
			if (1[i].Y > y)
			{
				list.Add(i);
				y = 1[i].Y;
			}
		}
		return list;
	}

	// Token: 0x06004D6D RID: 19821 RVA: 0x001EAAD8 File Offset: 0x001E8CD8
	internal RectangleF[] 70()
	{
		float <<EMPTY_NAME>> = (this.85 ? ((float)1662.70.2 / 768f) : 1f) * this.65();
		if (this.GetText().Length == 0)
		{
			return null;
		}
		208 2 = (this.85 ? 1662.70.3() : 1f) * this.77;
		208 3;
		RectangleF[] array;
		1450.6(this.GetText(), <<EMPTY_NAME>>, 2, this.61(), this.86, this.53(), this.55(), this.90, this.75, this.74, out 3, out array, this.57(), this.59(), this.72, true, true, this.92, 210.GetZero(), 208.Zero, this.47, 0, -1);
		if (this.85)
		{
			for (int i = 0; i < this.GetText().Length; i++)
			{
				RectangleF[] array2 = array;
				int num = i;
				array2[num].X = array2[num].X / 1662.70.3();
				RectangleF[] array3 = array;
				int num2 = i;
				array3[num2].Y = array3[num2].Y / 1662.70.3();
				RectangleF[] array4 = array;
				int num3 = i;
				array4[num3].Width = array4[num3].Width / 1662.70.3();
				RectangleF[] array5 = array;
				int num4 = i;
				array5[num4].Height = array5[num4].Height / 1662.70.3();
			}
			return array;
		}
		for (int j = 0; j < this.GetText().Length; j++)
		{
			RectangleF[] array6 = array;
			int num5 = j;
			array6[num5].X = array6[num5].X * 0.625f;
			RectangleF[] array7 = array;
			int num6 = j;
			array7[num6].Y = array7[num6].Y * 0.625f;
			RectangleF[] array8 = array;
			int num7 = j;
			array8[num7].Width = array8[num7].Width * 0.625f;
			RectangleF[] array9 = array;
			int num8 = j;
			array9[num8].Height = array9[num8].Height * 0.625f;
		}
		return array;
	}

	// Token: 0x06004D6E RID: 19822 RVA: 0x001EACCA File Offset: 0x001E8ECA
	internal new 208 71(int 1, int 2)
	{
		return this.72(1, 2, 208.Zero);
	}

	// Token: 0x06004D6F RID: 19823 RVA: 0x001EACDC File Offset: 0x001E8EDC
	internal 208 72(int 1, int 2, 208 3)
	{
		float 4 = (this.85 ? ((float)1662.70.2 / 768f) : 1f) * this.65();
		if (this.GetText().Length == 0)
		{
			return 208.Zero;
		}
		if (2 == 0)
		{
			return 208.Zero;
		}
		208 5 = (this.85 ? 1662.70.3() : 1f) * 3;
		208 6;
		RectangleF[] array;
		1450.6(this.GetText(), 4, 5, this.61(), this.86, this.53(), this.55(), this.90, this.75, this.74, out 6, out array, this.57(), this.59(), this.72, true, false, this.92, 210.GetZero(), 208.Zero, this.47, 1, 2);
		if (this.85)
		{
			return 6 / 1662.70.3();
		}
		return 6 * 0.625f;
	}

	// Token: 0x06004D70 RID: 19824 RVA: 0x001EADD9 File Offset: 0x001E8FD9
	internal virtual 208 GetTextSize()
	{
		this.GetTexture();
		if (this.85)
		{
			return this.46 / 1662.70.3();
		}
		return this.46 * 0.625f;
	}

	// Token: 0x06004D71 RID: 19825 RVA: 0x001EAE10 File Offset: 0x001E9010
	public override 1069 Update()
	{
		1069 <<EMPTY_NAME>> = base.Update();
		if (<<EMPTY_NAME>> != (1069)0)
		{
			return <<EMPTY_NAME>>;
		}
		if (string.IsNullOrEmpty(this.GetText()) && this.77 == 208.Zero)
		{
			return (1069)1;
		}
		if (this.88)
		{
			this.RegenerateTexture();
			base.Update();
		}
		return <<EMPTY_NAME>>;
	}

	// Token: 0x06004D72 RID: 19826 RVA: 0x001EAE64 File Offset: 0x001E9064
	protected virtual 1381 RegenerateTexture()
	{
		1381 <<EMPTY_NAME>> = this.47;
		this.88 = false;
		if (string.IsNullOrEmpty(this.GetText()) && this.77.X == 0f)
		{
			this.46 = this.77;
			return null;
		}
		this.73 = 1662.70.2;
		float 2 = (this.85 ? ((float)1662.70.2 / 768f) : 1f) * this.65();
		208 3 = (this.85 ? 1662.70.3() : 1f) * this.77;
		210 4 = this.78;
		208 5 = this.79;
		if (4 != 210.GetZero() && this.85)
		{
			4 *= (float)1662.70.2 / 768f;
		}
		if (this.79 != 208.Zero)
		{
			5 *= (float)1662.70.2 / 768f;
		}
		float num = (float)this.72;
		if (num > 0f)
		{
			num *= (float)1662.70.2 / 768f;
		}
		RectangleF[] array;
		this.47 = 1450.6(this.GetText(), 2, 3, this.61(), this.86, this.53(), this.55(), this.90, this.75, this.74, out this.46, out array, this.57(), this.59(), (int)Math.Round((double)num), false, false, this.92, 4, 5, this.47, 0, -1);
		if (<<EMPTY_NAME>> != null && this.47 != <<EMPTY_NAME>>)
		{
			<<EMPTY_NAME>>.Dispose();
		}
		if (this.91)
		{
			if (this.47 != null)
			{
				this.47.10 = true;
			}
			if (<<EMPTY_NAME>> != this.47)
			{
				1414.2(this, true);
			}
		}
		this.35 = (int)Math.Round((double)this.46.X);
		this.34 = (int)Math.Round((double)this.46.Y);
		this.ResetSourceRectangle();
		this.UpdateOriginOffset();
		if (this.76 != null)
		{
			this.76(this, null);
		}
		return this.47;
	}

	// Token: 0x06004D73 RID: 19827 RVA: 0x001EB09C File Offset: 0x001E929C
	public override string ToString()
	{
		return string.Concat(new string[]
		{
			"Text: ",
			this.GetText(),
			" (",
			this.17.X.ToString(),
			",",
			this.17.Y.ToString(),
			") @ ",
			this.89.ToString(),
			"pt ",
			Math.Round((double)(this.16 * 100f), 1).ToString(),
			"%"
		});
	}

	// Token: 0x06004D74 RID: 19828 RVA: 0x001EB142 File Offset: 0x001E9342
	internal override void ReleaseResources(bool 1)
	{
		if (this.91)
		{
			1414.1(this);
		}
		base.ReleaseResources(1);
	}

	// Token: 0x040039A4 RID: 14756
	public int 72 = 1;

	// Token: 0x040039A5 RID: 14757
	private int 73 = 1662.70.2;

	// Token: 0x040039A6 RID: 14758
	internal bool 74;

	// Token: 0x040039A7 RID: 14759
	internal 1066 75;

	// Token: 0x040039A8 RID: 14760
	private EventHandler 76;

	// Token: 0x040039A9 RID: 14761
	internal 208 77;

	// Token: 0x040039AA RID: 14762
	public 210 78;

	// Token: 0x040039AB RID: 14763
	public 208 79;

	// Token: 0x040039AC RID: 14764
	private bool 80;

	// Token: 0x040039AD RID: 14765
	private bool 81;

	// Token: 0x040039AE RID: 14766
	private 198 82;

	// Token: 0x040039AF RID: 14767
	private 198 83;

	// Token: 0x040039B0 RID: 14768
	private 198 84;

	// Token: 0x040039B1 RID: 14769
	internal bool 85;

	// Token: 0x040039B2 RID: 14770
	internal 1067 86;

	// Token: 0x040039B3 RID: 14771
	private string 87;

	// Token: 0x040039B4 RID: 14772
	internal bool 88 = true;

	// Token: 0x040039B5 RID: 14773
	private float 89;

	// Token: 0x040039B6 RID: 14774
	public bool 90;

	// Token: 0x040039B7 RID: 14775
	private bool 91;

	// Token: 0x040039B8 RID: 14776
	private 1068 92;
}
