using System;

// Token: 0x02000AF7 RID: 2807
public sealed class 1472 : 1452
{
	// Token: 0x06004E1C RID: 19996 RVA: 0x001EE898 File Offset: 0x001ECA98
	internal 1472(string 1, float 2, 208 3, 208 4, float 5, bool 6, 198 7, bool 8 = true) : base(1, 2, 3, 4, 5, 6, 7, 8)
	{
		this.49 = 1065.TopLeft;
		this.16 = 0f;
		this.78 = new 210(4f, 4f, 4f, 4f);
		this.41 = (1376)6;
		base.58(new 198(10, 10, 10, 230));
		base.60(new 198(80, 80, 80, byte.MaxValue));
	}

	// Token: 0x06004E1D RID: 19997 RVA: 0x001EE948 File Offset: 0x001ECB48
	internal bool 73()
	{
		return this.94;
	}

	// Token: 0x06004E1E RID: 19998 RVA: 0x001EE950 File Offset: 0x001ECB50
	private new void 74(bool 1)
	{
		this.94 = 1;
	}

	// Token: 0x06004E1F RID: 19999 RVA: 0x001EE959 File Offset: 0x001ECB59
	internal override string GetText()
	{
		return base.GetText();
	}

	// Token: 0x06004E20 RID: 20000 RVA: 0x001EE964 File Offset: 0x001ECB64
	internal override void SetText(string 1)
	{
		this.93 = (!string.IsNullOrEmpty(1) && (1555.34 || 1555.32));
		if (string.IsNullOrEmpty(1) && this.16 > 0f)
		{
			this.101 = true;
			return;
		}
		if (this.GetText() != 1)
		{
			this.101 = false;
			base.SetText(1);
			this.77 = 208.Zero;
			if (this.GetTextSize().X > 400f)
			{
				this.77 = new 208(400f, 0f);
			}
		}
	}

	// Token: 0x06004E21 RID: 20001 RVA: 0x001EE9FC File Offset: 0x001ECBFC
	public override bool Draw()
	{
		return base.Draw();
	}

	// Token: 0x06004E22 RID: 20002 RVA: 0x001EEA04 File Offset: 0x001ECC04
	internal new void 75()
	{
		if (this.99 != (932)1)
		{
			base.FadeIn(this.97, (1046)0, 0);
			this.99 = (932)1;
			this.74(true);
		}
	}

	// Token: 0x06004E23 RID: 20003 RVA: 0x001EEA2B File Offset: 0x001ECC2B
	internal void 76()
	{
		if (this.99 != (932)0)
		{
			base.16(this.98, (1046)0, 0);
			this.99 = (932)0;
			this.74(false);
		}
	}

	// Token: 0x06004E24 RID: 20004 RVA: 0x001EEA54 File Offset: 0x001ECC54
	public override 1069 Update()
	{
		if (this.16 > 0f || this.93)
		{
			base.66(9f - (float)(1662.70.2 - 1024) / 256f);
			208 <<EMPTY_NAME>> = this.GetTextSize() * 1662.70.3();
			208 2 = 1555.21() + <<EMPTY_NAME>> - new 208((float)1662.70.1, (float)1662.70.2) + 1472.96 * 1662.70.3() * 2f;
			208 3 = (1555.21() + 1472.96) / 1662.70.3();
			if (3.X > (float)(1662.70.1 - 120) && <<EMPTY_NAME>>.X < (float)(1662.70.1 - 120))
			{
				3.X -= (<<EMPTY_NAME>>.X + 20f) / 1662.70.3();
			}
			else if (2.X > 0f)
			{
				3.X -= 2.X / 1662.70.3();
			}
			if (3.Y > (float)(1662.70.2 - 80) && <<EMPTY_NAME>>.Y < (float)(1662.70.2 - 80))
			{
				3.Y -= (<<EMPTY_NAME>>.Y + 20f) / 1662.70.3();
			}
			else if (2.Y > 0f)
			{
				3.Y -= 2.Y / 1662.70.3();
			}
			this.17 = 3;
		}
		else
		{
			if (this.101 && this.16 == 0f)
			{
				this.SetText(null);
			}
			this.95 = 0.0;
		}
		if (this.93 && !this.73())
		{
			this.95 += 1662.82;
			if (this.95 > this.100)
			{
				this.75();
			}
		}
		else if (!this.93 && this.73())
		{
			this.76();
		}
		return base.Update();
	}

	// Token: 0x04003A42 RID: 14914
	internal bool 93;

	// Token: 0x04003A43 RID: 14915
	private bool 94;

	// Token: 0x04003A44 RID: 14916
	private double 95;

	// Token: 0x04003A45 RID: 14917
	private static readonly 208 96 = new 208(10f, 10f);

	// Token: 0x04003A46 RID: 14918
	internal int 97 = 200;

	// Token: 0x04003A47 RID: 14919
	internal int 98 = 200;

	// Token: 0x04003A48 RID: 14920
	private 932 99 = (932)2;

	// Token: 0x04003A49 RID: 14921
	internal double 100 = 120.0;

	// Token: 0x04003A4A RID: 14922
	private bool 101;
}
