using System;
using System.Collections.Generic;

// Token: 0x02000A71 RID: 2673
public sealed class 1353 : 1452
{
	// Token: 0x06004A1F RID: 18975 RVA: 0x001D5D20 File Offset: 0x001D3F20
	internal 1353(string 1, string 2, float 3, 1376 4, 1065 5, 1044 6, 208 7, float 8, bool 9, 198 10, bool 11 = true, 1416 12 = (1416)7) : base(null, 4, 5, 6, 7, 8, 9, 10)
	{
		this.SetText(1);
		this.99 = 12;
		this.47 = null;
		this.97 = 2;
		this.98 = 2 + "-";
		this.100 = 3;
		this.101 = 1353.73(2, 12);
		if (11)
		{
			for (int i = 0; i < 10; i++)
			{
				1455.2(this.98 + i.ToString(), 12, this.101);
			}
			1455.2(this.98 + "dot", 12, this.101);
			1455.2(this.98 + "comma", 12, this.101);
			1455.2(this.98 + "percent", 12, this.101);
		}
	}

	// Token: 0x06004A20 RID: 18976 RVA: 0x001D5E44 File Offset: 0x001D4044
	private static 1453 73(string 1, 1416 2)
	{
		if (!1353.93.ContainsKey(2))
		{
			1353.93[2] = new Dictionary<string, 1453>();
		}
		Dictionary<string, 1453> dictionary = 1353.93[2];
		if (dictionary.ContainsKey(1))
		{
			return dictionary[1];
		}
		return dictionary[1] = new 1453(512, 512);
	}

	// Token: 0x06004A21 RID: 18977 RVA: 0x001D5EA4 File Offset: 0x001D40A4
	internal override 208 GetTextSize()
	{
		if (this.88)
		{
			this.RegenerateTexture();
		}
		return this.46;
	}

	// Token: 0x06004A22 RID: 18978 RVA: 0x001D5EBC File Offset: 0x001D40BC
	public override 1069 Update()
	{
		1069 <<EMPTY_NAME>> = base.Update();
		if (<<EMPTY_NAME>> != (1069)0)
		{
			return <<EMPTY_NAME>>;
		}
		if (this.88)
		{
			this.RegenerateTexture();
		}
		return <<EMPTY_NAME>>;
	}

	// Token: 0x06004A23 RID: 18979 RVA: 0x00009D1A File Offset: 0x00007F1A
	internal override 1381 GetTexture()
	{
		return null;
	}

	// Token: 0x06004A24 RID: 18980 RVA: 0x00053ADC File Offset: 0x00051CDC
	internal override void SetTexture(1381 1)
	{
		throw new NotImplementedException();
	}

	// Token: 0x06004A25 RID: 18981 RVA: 0x001D5EE8 File Offset: 0x001D40E8
	protected override 1381 RegenerateTexture()
	{
		this.88 = false;
		this.95.Clear();
		this.94.Clear();
		float num = 0f;
		float num2 = 0f;
		string text = this.GetText();
		int num3 = (text != null) ? text.Length : 0;
		int i = 0;
		while (i < num3)
		{
			num -= ((this.96 || i == 0) ? 0f : this.100);
			float num4 = num;
			char c = text[i];
			bool flag = true;
			1381 <<EMPTY_NAME>>;
			if (c <= '/')
			{
				if (c != ' ')
				{
					if (c == '%')
					{
						<<EMPTY_NAME>> = 1455.2(this.98 + "percent", this.99, this.101);
						goto IL_279;
					}
					switch (c)
					{
					case '+':
						<<EMPTY_NAME>> = 1455.2(this.98 + "hz", this.99, this.101);
						goto IL_279;
					case ',':
						<<EMPTY_NAME>> = 1455.2(this.98 + "comma", this.99, this.101);
						goto IL_279;
					case '-':
						goto IL_251;
					case '.':
						<<EMPTY_NAME>> = 1455.2(this.98 + "dot", this.99, this.101);
						goto IL_279;
					case '/':
						<<EMPTY_NAME>> = 1455.2(this.98 + "slash", this.99, this.101);
						goto IL_279;
					default:
						goto IL_251;
					}
				}
			}
			else if (c <= '=')
			{
				if (c == ':')
				{
					<<EMPTY_NAME>> = 1455.2(this.98 + "colon", this.99, this.101);
					goto IL_279;
				}
				if (c != '=')
				{
					goto IL_251;
				}
				<<EMPTY_NAME>> = 1455.2(this.98 + "ms", this.99, this.101);
				goto IL_279;
			}
			else
			{
				if (c == '\\')
				{
					<<EMPTY_NAME>> = 1455.2(this.98 + "fps", this.99, this.101);
					goto IL_279;
				}
				if (c != '')
				{
					goto IL_251;
				}
				<<EMPTY_NAME>> = 1455.2(this.98 + "pp", this.99, this.101);
				goto IL_279;
			}
			IL_374:
			i++;
			continue;
			IL_279:
			if (<<EMPTY_NAME>> == null)
			{
				goto IL_374;
			}
			if (c == ' ')
			{
				if (this.103 < 0)
				{
					1381 2 = 1455.2(this.98 + "5", this.99, this.101);
					this.102 = ((2 != null) ? 2.3() : 40);
					1381 3 = 1455.2(this.98 + "dot", this.99, this.101);
					this.103 = ((3 != null) ? 3.3() : 40);
				}
				num += (float)this.103;
				goto IL_374;
			}
			if (!this.96 || flag)
			{
				num += (float)<<EMPTY_NAME>>.3();
			}
			if (this.96)
			{
				this.94.Add(new 208(num - num4, 0f));
			}
			else
			{
				this.94.Add(new 208(num4, 0f));
			}
			this.95.Add(<<EMPTY_NAME>>);
			if (num2 == 0f)
			{
				num2 = (float)<<EMPTY_NAME>>.4();
				goto IL_374;
			}
			goto IL_374;
			IL_251:
			<<EMPTY_NAME>> = 1455.2(this.98 + c.ToString(), this.99, this.101);
			flag = false;
			goto IL_279;
		}
		if (this.96)
		{
			if (this.103 < 0)
			{
				1381 4 = 1455.2(this.98 + "5", this.99, this.101);
				this.102 = ((4 != null) ? 4.3() : 40);
				1381 5 = 1455.2(this.98 + "dot", this.99, this.101);
				this.103 = ((5 != null) ? 5.3() : 40);
			}
			num = 0f;
			for (int j = 0; j < this.94.Count; j++)
			{
				float x = this.94[j].X;
				if (x == 0f)
				{
					this.94[j] = new 208(num + (float)Math.Max(0, (this.102 - this.95[j].3()) / 2), 0f);
					num += (float)this.102 - this.100;
				}
				else
				{
					this.94[j] = new 208(num, 0f);
					num += x - this.100;
				}
			}
		}
		float 6 = num;
		this.46 = new 208(6, num2);
		this.ResetSourceRectangle();
		this.UpdateOriginOffset();
		return null;
	}

	// Token: 0x06004A26 RID: 18982 RVA: 0x001D63C8 File Offset: 0x001D45C8
	public override bool Draw()
	{
		if (!base.Draw())
		{
			return false;
		}
		bool flag = this.67 != 0f || this.62.X < 0f || this.62.Y < 0f;
		208 <<EMPTY_NAME>> = new 208(this.50.X + this.64.X, this.50.Y + this.64.Y);
		float num = base.31();
		float num2 = (float)Math.Cos((double)num);
		float num3 = (float)Math.Sin((double)num);
		for (int i = 0; i < this.94.Count; i++)
		{
			1381 2 = this.95[i];
			if (i == 0 && 2.resolutionScale != 1)
			{
				this.62 *= 1f / (float)2.resolutionScale;
			}
			if (flag)
			{
				208 3 = new 208(this.94[i].X * this.63 - this.64.X, -this.64.Y);
				3.X *= ((this.62.X < 0f) ? -1f : 1f);
				3.Y *= ((this.62.Y < 0f) ? -1f : 1f);
				this.31 = <<EMPTY_NAME>> + new 208(3.X * num2 - 3.Y * num3, 3.X * num3 + 3.Y * num2);
				1454 gpuTexture = 2.gpuTexture;
				if (gpuTexture != null)
				{
					gpuTexture.Draw(this.31, 208.Zero, this.30, this.62, num, null, 1436.40.35());
				}
			}
			else
			{
				this.31 = new 208(this.94[i].X * this.63 + this.50.X, this.50.Y);
				1454 gpuTexture2 = 2.gpuTexture;
				if (gpuTexture2 != null)
				{
					gpuTexture2.Draw(this.31, 208.Zero, this.30, this.62, this.14, null, 1436.40.35());
				}
			}
		}
		return true;
	}

	// Token: 0x06004A27 RID: 18983 RVA: 0x001D664C File Offset: 0x001D484C
	internal override void ResetSourceRectangle()
	{
		this.35 = (this.39 = (int)Math.Round((double)this.46.X));
		this.34 = (this.38 = (int)Math.Round((double)this.46.Y));
		this.37 = 0;
		this.36 = 0;
	}

	// Token: 0x04003732 RID: 14130
	private static Dictionary<1416, Dictionary<string, 1453>> 93 = new Dictionary<1416, Dictionary<string, 1453>>();

	// Token: 0x04003733 RID: 14131
	internal List<208> 94 = new List<208>();

	// Token: 0x04003734 RID: 14132
	internal List<1381> 95 = new List<1381>();

	// Token: 0x04003735 RID: 14133
	internal bool 96;

	// Token: 0x04003736 RID: 14134
	internal string 97 = "default";

	// Token: 0x04003737 RID: 14135
	internal string 98;

	// Token: 0x04003738 RID: 14136
	private 1416 99;

	// Token: 0x04003739 RID: 14137
	internal float 100;

	// Token: 0x0400373A RID: 14138
	private 1453 101;

	// Token: 0x0400373B RID: 14139
	private int 102 = -1;

	// Token: 0x0400373C RID: 14140
	private int 103 = -1;
}
