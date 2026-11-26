using System;
using System.Collections.Generic;
using System.Drawing;
using OpenTK.Graphics.ES20;

// Token: 0x02000819 RID: 2073
[276]
public abstract class 2054 : 2049, 1054, IDisposable
{
	// Token: 0x06003C48 RID: 15432 RVA: 0x0017EE14 File Offset: 0x0017D014
	public 2054()
	{
		this.1();
	}

	// Token: 0x06003C49 RID: 15433 RVA: 0x0017EE8C File Offset: 0x0017D08C
	internal void 1()
	{
		if (!this.11)
		{
			this.5 = 6;
			this.3 = 4;
			this.1 = 6;
			this.6 = 26;
			this.4 = 24;
			this.2 = 72;
			this.6();
			this.11 = true;
		}
		if (!this.12)
		{
			this.5();
			this.12 = true;
		}
	}

	// Token: 0x06003C4A RID: 15434 RVA: 0x0017EEF0 File Offset: 0x0017D0F0
	public List<198> GetComboColours()
	{
		return this.13;
	}

	// Token: 0x06003C4B RID: 15435 RVA: 0x0017EEF8 File Offset: 0x0017D0F8
	public void SetComboColours(List<198> 1)
	{
		if (1.Count != this.13.Count)
		{
			this.13 = new List<198>(1);
			if (this.12)
			{
				this.2();
			}
			return;
		}
		int i = 0;
		while (i < 1.Count)
		{
			if (1[i] != this.13[i])
			{
				this.13 = new List<198>(1);
				if (this.12)
				{
					this.2();
					return;
				}
				break;
			}
			else
			{
				i++;
			}
		}
	}

	// Token: 0x06003C4C RID: 15436 RVA: 0x0017EF79 File Offset: 0x0017D179
	public 198 GetFallbackColour()
	{
		return this.14;
	}

	// Token: 0x06003C4D RID: 15437 RVA: 0x0017EF81 File Offset: 0x0017D181
	public void SetFallbackColour(198 1)
	{
		if (!(this.14 == 1))
		{
			this.14 = 1;
			if (this.12)
			{
				this.3();
			}
		}
	}

	// Token: 0x06003C4E RID: 15438 RVA: 0x0017EFA6 File Offset: 0x0017D1A6
	public 198 GetDefaultColour()
	{
		return this.15;
	}

	// Token: 0x06003C4F RID: 15439 RVA: 0x0017EFAE File Offset: 0x0017D1AE
	public void SetDefaultColour(198 1)
	{
		if (!(this.15 == 1))
		{
			this.15 = 1;
			if (this.12)
			{
				this.4();
			}
		}
	}

	// Token: 0x06003C50 RID: 15440 RVA: 0x0017EFD3 File Offset: 0x0017D1D3
	public 198 GetBorderColour()
	{
		return this.16;
	}

	// Token: 0x06003C51 RID: 15441 RVA: 0x0017EFDB File Offset: 0x0017D1DB
	public void SetBorderColour(198 1)
	{
		if (!(this.16 == 1))
		{
			this.16 = 1;
			if (this.12)
			{
				this.5();
			}
		}
	}

	// Token: 0x06003C52 RID: 15442 RVA: 0x0017F000 File Offset: 0x0017D200
	public float GetBodyWidth()
	{
		return this.17;
	}

	// Token: 0x06003C53 RID: 15443 RVA: 0x0017F008 File Offset: 0x0017D208
	public void SetBodyWidth(float 1)
	{
		if (this.17 != 1)
		{
			this.17 = 1;
			if (this.12)
			{
				this.5();
			}
		}
	}

	// Token: 0x06003C54 RID: 15444 RVA: 0x0017F028 File Offset: 0x0017D228
	public void SetColours(List<198> 1, 198 2, 198 3, 198 4, float 5)
	{
		if (this.16 != 4 || this.17 != 5)
		{
			this.13 = new List<198>(1);
			this.14 = 2;
			this.15 = 3;
			this.16 = 4;
			this.17 = 5;
			if (this.12)
			{
				this.5();
				return;
			}
		}
		else
		{
			this.SetComboColours(1);
			this.SetFallbackColour(2);
			this.SetDefaultColour(3);
		}
	}

	// Token: 0x06003C55 RID: 15445 RVA: 0x0001702D File Offset: 0x0001522D
	public bool IsSliderBody()
	{
		return true;
	}

	// Token: 0x06003C56 RID: 15446 RVA: 0x0017F09C File Offset: 0x0017D29C
	private void 2()
	{
		int count = this.13.Count;
		if (count == 0)
		{
			this.7 = new 1454[1];
			this.7[0] = this.CreateTexture(198.TransparentBlack, this.16);
			return;
		}
		if (this.7 != null)
		{
			foreach (1454 <<EMPTY_NAME>> in this.7)
			{
				if (<<EMPTY_NAME>> != null)
				{
					<<EMPTY_NAME>>.Dispose();
				}
			}
		}
		this.7 = new 1454[count];
		for (int j = 0; j < count; j++)
		{
			this.7[j] = this.CreateTexture(this.13[j], this.16);
		}
	}

	// Token: 0x06003C57 RID: 15447 RVA: 0x0017F141 File Offset: 0x0017D341
	private void 3()
	{
		if (this.9 != null)
		{
			this.9.Dispose();
		}
		this.9 = this.CreateTexture(this.14, this.16);
	}

	// Token: 0x06003C58 RID: 15448 RVA: 0x0017F16E File Offset: 0x0017D36E
	private void 4()
	{
		if (this.8 != null)
		{
			this.8.Dispose();
		}
		this.8 = this.CreateTexture(this.15, this.16);
	}

	// Token: 0x06003C59 RID: 15449 RVA: 0x0017F19B File Offset: 0x0017D39B
	private void 5()
	{
		this.2();
		this.3();
		this.4();
	}

	// Token: 0x06003C5A RID: 15450
	protected abstract 1454 CreateTexture(198 1, 198 2);

	// Token: 0x06003C5B RID: 15451
	protected abstract Size GetTextureSize();

	// Token: 0x06003C5C RID: 15452 RVA: 0x0017F1B0 File Offset: 0x0017D3B0
	private void 6()
	{
		this.10 = new 209[this.6 - 1];
		float num = 0.1308997f;
		this.10[0] = new 209(0f, -1f, 0f);
		for (int i = 1; i < 24; i++)
		{
			float num2 = (float)i * num;
			this.10[i] = new 209((float)Math.Sin((double)num2), 0f - (float)Math.Cos((double)num2), 0f);
		}
		this.10[24] = new 209(0f, 1f, 0f);
	}

	// Token: 0x06003C5D RID: 15453 RVA: 0x0017F258 File Offset: 0x0017D458
	public void DrawPath(1051 1, float 2, 198 3)
	{
		this.DrawPath(new List<1051>(1)
		{
			1
		}, null, 2, 3);
	}

	// Token: 0x06003C5E RID: 15454 RVA: 0x0017F27D File Offset: 0x0017D47D
	public void DrawPath(List<1051> 1, 1051 2, float 3, 198 4)
	{
		this.DrawPath(1, 2, 3, 4, this.16);
	}

	// Token: 0x06003C5F RID: 15455 RVA: 0x0017F290 File Offset: 0x0017D490
	public void DrawPath(List<1051> 1, 1051 2, float 3, 198 4, 198 5)
	{
		1454 6 = this.CreateTexture(4, 5);
		this.9(1, 3, 6, 2);
		6.Dispose();
	}

	// Token: 0x06003C60 RID: 15456 RVA: 0x0017F2B8 File Offset: 0x0017D4B8
	public void DrawPath(List<1051> 1, 1051 2, float 3, int 4)
	{
		if (4 == -2)
		{
			this.9(1, 3, this.9, 2);
			return;
		}
		if (4 == -1)
		{
			this.9(1, 3, this.8, 2);
			return;
		}
		if (4 >= this.7.Length || 4 < 0)
		{
			this.9(1, 3, this.8, 2);
			return;
		}
		this.9(1, 3, this.7[4], 2);
	}

	// Token: 0x06003C61 RID: 15457 RVA: 0x0017F323 File Offset: 0x0017D523
	public void DrawPath(List<1051> 1, 1051 2, float 3, int 4, 198 5)
	{
		this.DrawPath(1, 2, 3, this.13[4], 5);
	}

	// Token: 0x06003C62 RID: 15458 RVA: 0x0017F340 File Offset: 0x0017D540
	private void 7(202 1)
	{
		this.18.5(new 1395
		{
			Position = 209.Transform(new 209(-0.0003f, -1f, 0f), 1),
			TexturePosition = new 208(0f, 0f),
			Colour = 198.White
		});
		this.18.5(new 1395
		{
			Position = 209.Transform(new 209(1.0003f, -1f, 0f), 1),
			TexturePosition = new 208(0f, 0f),
			Colour = 198.White
		});
		209 position = 209.Transform(new 209(1.0003f, 0.0001f, 1f), 1);
		209 position2 = 209.Transform(new 209(-0.0003f, 0.0001f, 1f), 1);
		for (int i = 0; i < 2; i++)
		{
			this.18.5(new 1395
			{
				Position = position,
				TexturePosition = new 208(1f - 1f / (float)this.GetTextureSize().Width, 0f),
				Colour = 198.White
			});
			this.18.5(new 1395
			{
				Position = position2,
				TexturePosition = new 208(1f - 1f / (float)this.GetTextureSize().Width, 0f),
				Colour = 198.White
			});
		}
		this.18.5(new 1395
		{
			Position = 209.Transform(new 209(-0.0003f, 1f, 0f), 1),
			TexturePosition = new 208(0f, 0f),
			Colour = 198.White
		});
		this.18.5(new 1395
		{
			Position = 209.Transform(new 209(1.0003f, 1f, 0f), 1),
			TexturePosition = new 208(0f, 0f),
			Colour = 198.White
		});
	}

	// Token: 0x06003C63 RID: 15459 RVA: 0x0017F59C File Offset: 0x0017D79C
	private void 8(int 1, 202 2)
	{
		if (1 != 0)
		{
			209 position = 209.Transform(new 209(0f, 0f, 1f), 2);
			209 position2 = 209.Transform(this.10[0], 2);
			for (int i = 0; i <= 1 - 1; i++)
			{
				this.19.5(new 1395
				{
					Position = position,
					TexturePosition = new 208(1f - 1f / (float)this.GetTextureSize().Width, 0f),
					Colour = 198.White
				});
				this.19.5(new 1395
				{
					Position = position2,
					TexturePosition = new 208(0f, 0f),
					Colour = 198.White
				});
				position2 = 209.Transform(this.10[i + 1], 2);
				this.19.5(new 1395
				{
					Position = position2,
					TexturePosition = new 208(0f, 0f),
					Colour = 198.White
				});
			}
		}
	}

	// Token: 0x06003C64 RID: 15460 RVA: 0x0017F6D8 File Offset: 0x0017D8D8
	private void 9(List<1051> 1, float 2, 1454 3, 1051 4)
	{
		GL.Disable(2884);
		GL.Disable(3042);
		GL.Enable(2929);
		GL.DepthMask(true);
		GL.DepthFunc(515);
		GL.Clear(256);
		1379.23.3();
		1379.33(3.GetTextureId());
		GL.TexParameter(3553, 10241, 9729);
		GL.TexParameter(3553, 10240, 9729);
		int count = 1.Count;
		for (int i = 1; i < count; i++)
		{
			this.10(4, 1[i - 1], 1[i], 2);
			4 = 1[i - 1];
		}
		this.10(4, 1[count - 1], null, 2);
		this.18.6();
		this.19.6();
		1379.23.4();
		GL.Disable(2929);
		GL.DepthMask(false);
		GL.Enable(3042);
	}

	// Token: 0x06003C65 RID: 15461 RVA: 0x0017F7E0 File Offset: 0x0017D9E0
	private void 10(1051 1, 1051 2, 1051 3, float 4)
	{
		202 5 = new 202(2.1(), 0f, 0f, 0f, 0f, 4, 0f, 0f, 0f, 0f, 1f, 0f, 0f, 0f, 0f, 1f) * 2.6();
		this.7(5);
		bool flag;
		int val;
		if (3 == null)
		{
			flag = false;
			val = this.4;
		}
		else
		{
			float num = 3.2() - 2.2();
			if ((double)num > 3.141592653589793)
			{
				num -= 6.2831855f;
			}
			if ((double)num < -3.141592653589793)
			{
				num += 6.2831855f;
			}
			if (num < 0f)
			{
				flag = true;
				val = (int)Math.Ceiling((double)((0f - num) * 24f) / 3.141592653589793 + 0.0);
			}
			else if (num > 0f)
			{
				flag = false;
				val = (int)Math.Ceiling((double)(num * 24f) / 3.141592653589793 + 0.0);
			}
			else
			{
				flag = false;
				val = 0;
			}
		}
		val = Math.Min(val, this.4);
		5 = ((!flag) ? (new 202(4, 0f, 0f, 0f, 0f, 4, 0f, 0f, 0f, 0f, 1f, 0f, 0f, 0f, 0f, 1f) * 2.7()) : (new 202(4, 0f, 0f, 0f, 0f, 0f - 4, 0f, 0f, 0f, 0f, 1f, 0f, 0f, 0f, 0f, 1f) * 2.7()));
		this.8(val, 5);
		bool flag2 = false;
		if (1 == null)
		{
			flag2 = true;
		}
		else if (2.1 != 1.2)
		{
			flag2 = true;
		}
		if (flag2)
		{
			5 = new 202(0f - 4, 0f, 0f, 0f, 0f, 0f - 4, 0f, 0f, 0f, 0f, 1f, 0f, 0f, 0f, 0f, 1f) * 2.6();
			this.8(this.4, 5);
		}
	}

	// Token: 0x06003C66 RID: 15462 RVA: 0x0017FA7C File Offset: 0x0017DC7C
	~2054()
	{
		this.DisposeCore(false);
	}

	// Token: 0x06003C67 RID: 15463 RVA: 0x0017FAAC File Offset: 0x0017DCAC
	public void Dispose()
	{
		this.DisposeCore(true);
		GC.SuppressFinalize(this);
	}

	// Token: 0x06003C68 RID: 15464 RVA: 0x0017FABC File Offset: 0x0017DCBC
	protected virtual void DisposeCore(bool 1)
	{
		if (1 && this.7 != null)
		{
			foreach (1454 2 in this.7)
			{
				this.11(2);
			}
			this.11(this.8);
			this.11(this.9);
		}
	}

	// Token: 0x06003C69 RID: 15465 RVA: 0x0017FB0C File Offset: 0x0017DD0C
	private void 11(IDisposable 1)
	{
		if (1 != null)
		{
			1.Dispose();
		}
	}

	// Token: 0x04002C7B RID: 11387
	private int 1;

	// Token: 0x04002C7C RID: 11388
	private int 2;

	// Token: 0x04002C7D RID: 11389
	private int 3;

	// Token: 0x04002C7E RID: 11390
	private int 4;

	// Token: 0x04002C7F RID: 11391
	private int 5;

	// Token: 0x04002C80 RID: 11392
	private int 6;

	// Token: 0x04002C81 RID: 11393
	protected 1454[] 7;

	// Token: 0x04002C82 RID: 11394
	protected 1454 8;

	// Token: 0x04002C83 RID: 11395
	protected 1454 9;

	// Token: 0x04002C84 RID: 11396
	private 209[] 10;

	// Token: 0x04002C85 RID: 11397
	private bool 11;

	// Token: 0x04002C86 RID: 11398
	private bool 12;

	// Token: 0x04002C87 RID: 11399
	private List<198> 13 = new List<198>();

	// Token: 0x04002C88 RID: 11400
	private 198 14 = 198.Gray;

	// Token: 0x04002C89 RID: 11401
	private 198 15 = 198.Gray;

	// Token: 0x04002C8A RID: 11402
	private 198 16 = 198.White;

	// Token: 0x04002C8B RID: 11403
	private float 17 = 64f;

	// Token: 0x04002C8C RID: 11404
	private 1375<1395> 18 = new 1375<1395>(200, 10);

	// Token: 0x04002C8D RID: 11405
	private 1407<1395> 19 = new 1407<1395>(7200, 10, 4);
}
