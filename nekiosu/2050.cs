using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using OpenTK.Graphics.ES20;

// Token: 0x02000811 RID: 2065
[276]
internal sealed class 2050 : IDisposable
{
	// Token: 0x06003C1A RID: 15386 RVA: 0x0017DDD8 File Offset: 0x0017BFD8
	internal 2050(2039 1)
	{
		this.8 = 1;
	}

	// Token: 0x06003C1B RID: 15387 RVA: 0x0017DE25 File Offset: 0x0017C025
	internal void 1()
	{
		this.9 = true;
		this.10 = false;
	}

	// Token: 0x06003C1C RID: 15388 RVA: 0x0017DE35 File Offset: 0x0017C035
	internal void Refresh()
	{
		if (!this.10)
		{
			return;
		}
		this.29 = true;
		this.14(this.16);
	}

	// Token: 0x06003C1D RID: 15389 RVA: 0x0017DE54 File Offset: 0x0017C054
	internal void 2()
	{
		if (!1379.19 || 1662.12 || this.8.39 == null)
		{
			return;
		}
		int num = 1226.16;
		if (this.9)
		{
			this.5(num);
		}
		if (!this.10)
		{
			return;
		}
		if (1662.70.1 != this.19 || 1662.70.2 != this.20)
		{
			this.11();
			this.28 = false;
			this.14(this.16);
		}
		this.9(num);
		bool flag = num < this.18 - 1000 || num > this.18 + 1000;
		if (flag || (!this.28 && num + 5000 >= this.3()))
		{
			int num2 = this.4(num + 10000, 0);
			if (flag || num2 != this.16)
			{
				this.10(num2);
				this.28 = false;
				this.29 = false;
				this.14(this.16);
			}
		}
		this.18 = num;
		if (flag || 2486.189)
		{
			return;
		}
		if (!this.28)
		{
			this.16(2500, 12);
			if (this.27 && this.24 == this.16)
			{
				this.15();
				this.14(this.4(this.3() + 5000, this.16));
			}
		}
		else if (this.29)
		{
			this.16(2500, 12);
			if (this.27 && this.24 == this.16)
			{
				this.29 = false;
				this.15();
				this.14(this.4(this.3() + 5000, this.16));
			}
		}
		else if (this.16 < this.11.Count && num + 5000 >= this.3() && this.24 > this.16)
		{
			while (!this.27)
			{
				this.16(2500, 12);
			}
			this.10(this.24);
			this.15();
			this.14(this.4(this.3() + 5000, this.16));
		}
		else
		{
			this.16(500, 4);
		}
		this.17(num);
	}

	// Token: 0x06003C1E RID: 15390 RVA: 0x0017E0B0 File Offset: 0x0017C2B0
	private int 3()
	{
		if (this.16 >= this.11.Count)
		{
			return int.MaxValue;
		}
		return this.11[this.16].1;
	}

	// Token: 0x06003C1F RID: 15391 RVA: 0x0017E0E4 File Offset: 0x0017C2E4
	private int 4(int 1, int 2)
	{
		int i = Math.Max(0, 2);
		int num = this.11.Count;
		while (i < num)
		{
			int num2 = (i + num) / 2;
			if (this.11[num2].1 < 1)
			{
				i = num2 + 1;
			}
			else
			{
				num = num2;
			}
		}
		return i;
	}

	// Token: 0x06003C20 RID: 15392 RVA: 0x0017E130 File Offset: 0x0017C330
	private void 5(int 1)
	{
		this.9 = false;
		1436 2 = this.8.39;
		this.11 = this.8.34;
		if (this.11 == null)
		{
			return;
		}
		this.12.Clear();
		this.13.Clear();
		for (int i = 0; i < this.11.Count; i++)
		{
			foreach (1433 3 in this.11[i].30)
			{
				if (3 != null)
				{
					this.12[3] = i;
				}
			}
		}
		this.17 = this.4(1 + 10000, 0);
		this.16 = this.17;
		this.7(2);
		List<1371> list = new List<1371>();
		List<1371> obj = 2.28;
		lock (obj)
		{
			foreach (1371 4 in 2.28)
			{
				int num;
				if (this.12.TryGetValue(4, out num))
				{
					if (num >= this.16)
					{
						this.13.Add(4);
					}
				}
				else if (4.3.Count > 0 && 2050.8(4) > 1 + 1000)
				{
					list.Add(4);
				}
			}
			HashSet<1371> hashSet = new HashSet<1371>(this.13);
			hashSet.UnionWith(list);
			2.28.RemoveAll(new Predicate<1371>(hashSet.Contains));
		}
		IEnumerable<1371> source = list;
		Func<1371, int> keySelector;
		if ((keySelector = 2050.<>O.<0>__FirstStart) == null)
		{
			keySelector = (2050.<>O.<0>__FirstStart = new Func<1371, int>(2050.8));
		}
		this.14 = source.OrderBy(keySelector).ToList<1371>();
		this.15 = 0;
		this.23 = new 2050.2052();
		2.12(this.23);
		this.11();
		this.28 = false;
		this.14(this.16);
		this.18 = 1;
		this.10 = true;
	}

	// Token: 0x06003C21 RID: 15393 RVA: 0x0017E37C File Offset: 0x0017C57C
	private void 6(int 1)
	{
		foreach (1433 2 in this.11[1].30)
		{
			if (2 != null && this.12.ContainsKey(2))
			{
				this.8.39.12(2);
			}
		}
	}

	// Token: 0x06003C22 RID: 15394 RVA: 0x0017E3F8 File Offset: 0x0017C5F8
	private void 7(1436 1)
	{
		bool flag = false;
		foreach (2034 2 in this.11)
		{
			2129 3 = 2 as 2129;
			if (3 != null)
			{
				float num = 1436.32((float)3.1) - 1436.30((float)3.1);
				foreach (1433 4 in 3.30)
				{
					if (4 != null && this.30.Add(4))
					{
						4.2 += num;
						flag = true;
					}
				}
			}
		}
		if (!flag)
		{
			return;
		}
		List<1371> obj = 5.28;
		lock (obj)
		{
			List<1371> collection = (from 1 in 5.28
			orderby 1.2
			select 1).ToList<1371>();
			5.28.Clear();
			5.28.AddRange(collection);
		}
	}

	// Token: 0x06003C23 RID: 15395 RVA: 0x0017E548 File Offset: 0x0017C748
	private static int 8(1371 1)
	{
		int num = int.MaxValue;
		foreach (1445 2 in 1.3)
		{
			num = Math.Min(num, 2.9);
		}
		return num;
	}

	// Token: 0x06003C24 RID: 15396 RVA: 0x0017E5A8 File Offset: 0x0017C7A8
	private void 9(int 1)
	{
		while (this.15 < this.14.Count && 2050.8(this.14[this.15]) <= 1 + 1000)
		{
			this.8.39.12(this.14[this.15]);
			this.15++;
		}
	}

	// Token: 0x06003C25 RID: 15397 RVA: 0x0017E618 File Offset: 0x0017C818
	private void 10(int 1)
	{
		1 = Math.Max(this.17, Math.Min(this.11.Count, 1));
		1436 2 = this.8.39;
		if (1 > this.16)
		{
			for (int i = this.16; i < 1; i++)
			{
				this.6(i);
			}
		}
		else if (1 < this.16)
		{
			HashSet<1371> hashSet = new HashSet<1371>();
			for (int j = 1; j < this.16; j++)
			{
				foreach (1433 3 in this.11[j].30)
				{
					if (3 != null)
					{
						hashSet.Add(3);
					}
				}
			}
			List<1371> obj = 2.28;
			lock (obj)
			{
				2.28.RemoveAll(new Predicate<1371>(hashSet.Contains));
			}
		}
		this.16 = 1;
	}

	// Token: 0x06003C26 RID: 15398 RVA: 0x0017E740 File Offset: 0x0017C940
	private void 11()
	{
		2050.2051 <<EMPTY_NAME>> = this.21;
		if (<<EMPTY_NAME>> != null)
		{
			<<EMPTY_NAME>>.1();
		}
		2050.2051 2 = this.22;
		if (2 != null)
		{
			2.1();
		}
		this.19 = 1662.70.1;
		this.20 = 1662.70.2;
		this.21 = this.12();
		this.22 = this.12();
		this.23.SetTexture(null);
	}

	// Token: 0x06003C27 RID: 15399 RVA: 0x0017E7B4 File Offset: 0x0017C9B4
	private 2050.2051 12()
	{
		int num = 1454.1(this.19);
		int num2 = 1454.1(this.20);
		1402 <<EMPTY_NAME>> = new 1402(num, num2);
		<<EMPTY_NAME>>.UploadPixels(new byte[0], 0, 6408);
		<<EMPTY_NAME>>.FlushPendingUpload();
		int num3 = 2050.13();
		int num4 = GL.GenFramebuffer();
		GL.BindFramebuffer(36160, num4);
		GL.FramebufferTexture2D(36160, 36064, 3553, <<EMPTY_NAME>>.GetTextureId(), 0);
		1379.33(0);
		GL.BindFramebuffer(36160, num3);
		return new 2050.2051
		{
			1 = <<EMPTY_NAME>>,
			2 = new 1381(<<EMPTY_NAME>>, null),
			3 = num4
		};
	}

	// Token: 0x06003C28 RID: 15400 RVA: 0x0017E85C File Offset: 0x0017CA5C
	private static int 13()
	{
		int result;
		GL.GetInteger(36006, ref result);
		return result;
	}

	// Token: 0x06003C29 RID: 15401 RVA: 0x0017E876 File Offset: 0x0017CA76
	private void 14(int 1)
	{
		this.24 = Math.Min(this.11.Count, 1);
		this.25 = 0;
		this.26 = false;
		this.27 = false;
	}

	// Token: 0x06003C2A RID: 15402 RVA: 0x0017E8A4 File Offset: 0x0017CAA4
	private void 15()
	{
		2050.2051 <<EMPTY_NAME>> = this.22;
		this.22 = this.21;
		this.21 = <<EMPTY_NAME>>;
		this.23.SetTexture(this.21.2);
		this.28 = true;
		this.24 = -1;
	}

	// Token: 0x06003C2B RID: 15403 RVA: 0x0017E8F0 File Offset: 0x0017CAF0
	private void 16(int 1, int 2)
	{
		if (this.24 < 0 || this.27)
		{
			return;
		}
		List<1371> list = new List<1371>();
		List<2123> list2 = new List<2123>();
		int num = 0;
		int num2 = this.25;
		while (num2 < this.13.Count && list.Count < 1 && list2.Count < 2 && num < 40000)
		{
			1371 3 = this.13[num2];
			int num3;
			if (!3.8() && this.12.TryGetValue(3, out num3) && num3 >= this.24)
			{
				list.Add(3);
				2123 4 = this.11[num3] as 2123;
				if (4 != null && 4.53 == 3)
				{
					list2.Add(4);
				}
			}
			num2++;
			num++;
		}
		2123.91 = true;
		try
		{
			foreach (2123 5 in list2)
			{
				5.PrepareRendering();
			}
		}
		finally
		{
			2123.91 = false;
		}
		Rectangle value = 1379.28;
		Rectangle value2 = 1379.29;
		int num4 = 2050.13();
		GL.BindFramebuffer(36160, this.22.3);
		int width_ = this.22.1.GetWidth_10758();
		int height_ = this.22.1.GetHeight_10756();
		1379.28(new Rectangle?(new Rectangle(0, 0, width_, height_)));
		1379.29(new Rectangle?(new Rectangle(0, height_, width_, -height_)));
		1379.27(null);
		if (!this.26)
		{
			GL.ClearColor(0f, 0f, 0f, 0f);
			GL.Clear(16384);
			this.26 = true;
		}
		1436 6 = this.8.39;
		float num5 = 6.7;
		float num6 = 6.5;
		6.7 = 0f;
		6.5 = 1f;
		6.37();
		GL.BlendFuncSeparate(770, 771, 1, 771);
		try
		{
			foreach (1371 7 in list)
			{
				if (7.Update() == (1069)0)
				{
					7.Draw();
				}
			}
		}
		finally
		{
			6.7 = num5;
			6.5 = num6;
			6.38();
			1379.34();
			GL.BindFramebuffer(36160, num4);
			1379.28(new Rectangle?(value));
			1379.29(new Rectangle?(value2));
			1379.27(null);
		}
		foreach (2123 8 in list2)
		{
			8.36();
			8.35();
		}
		this.25 = num2;
		if (num2 >= this.13.Count)
		{
			this.27 = true;
		}
	}

	// Token: 0x06003C2C RID: 15404 RVA: 0x0017EC28 File Offset: 0x0017CE28
	private void 17(int 1)
	{
		int num = this.4(1 - 2000, 0);
		while (num < this.16 && num < this.11.Count)
		{
			2034 2 = this.11[num];
			if (2.38 && !this.8.36.Contains(2))
			{
				2.PrepareRendering();
			}
			num++;
		}
	}

	// Token: 0x06003C2D RID: 15405 RVA: 0x0017EC8F File Offset: 0x0017CE8F
	public void Dispose()
	{
		2050.2051 <<EMPTY_NAME>> = this.21;
		if (<<EMPTY_NAME>> != null)
		{
			<<EMPTY_NAME>>.1();
		}
		2050.2051 2 = this.22;
		if (2 != null)
		{
			2.1();
		}
		this.21 = null;
		this.22 = null;
		this.10 = false;
	}

	// Token: 0x04002C55 RID: 11349
	private const int 1 = 5000;

	// Token: 0x04002C56 RID: 11350
	private const int 2 = 500;

	// Token: 0x04002C57 RID: 11351
	private const int 3 = 2500;

	// Token: 0x04002C58 RID: 11352
	private const int 4 = 4;

	// Token: 0x04002C59 RID: 11353
	private const int 5 = 12;

	// Token: 0x04002C5A RID: 11354
	private const int 6 = 40000;

	// Token: 0x04002C5B RID: 11355
	private const float 7 = 0.2f;

	// Token: 0x04002C5C RID: 11356
	private readonly 2039 8;

	// Token: 0x04002C5D RID: 11357
	private bool 9;

	// Token: 0x04002C5E RID: 11358
	private bool 10;

	// Token: 0x04002C5F RID: 11359
	private List<2034> 11;

	// Token: 0x04002C60 RID: 11360
	private readonly Dictionary<1371, int> 12 = new Dictionary<1371, int>();

	// Token: 0x04002C61 RID: 11361
	private readonly List<1371> 13 = new List<1371>();

	// Token: 0x04002C62 RID: 11362
	private List<1371> 14 = new List<1371>();

	// Token: 0x04002C63 RID: 11363
	private int 15;

	// Token: 0x04002C64 RID: 11364
	private int 16;

	// Token: 0x04002C65 RID: 11365
	private int 17;

	// Token: 0x04002C66 RID: 11366
	private int 18;

	// Token: 0x04002C67 RID: 11367
	private int 19;

	// Token: 0x04002C68 RID: 11368
	private int 20;

	// Token: 0x04002C69 RID: 11369
	private 2050.2051 21;

	// Token: 0x04002C6A RID: 11370
	private 2050.2051 22;

	// Token: 0x04002C6B RID: 11371
	private 2050.2052 23;

	// Token: 0x04002C6C RID: 11372
	private int 24 = -1;

	// Token: 0x04002C6D RID: 11373
	private int 25;

	// Token: 0x04002C6E RID: 11374
	private bool 26;

	// Token: 0x04002C6F RID: 11375
	private bool 27;

	// Token: 0x04002C70 RID: 11376
	private bool 28;

	// Token: 0x04002C71 RID: 11377
	private bool 29;

	// Token: 0x04002C72 RID: 11378
	private readonly HashSet<1371> 30 = new HashSet<1371>();

	// Token: 0x02000812 RID: 2066
	[276]
	private sealed class 2051
	{
		// Token: 0x06003C2E RID: 15406 RVA: 0x0017ECC8 File Offset: 0x0017CEC8
		internal void 1()
		{
			if (this.3 != -1)
			{
				int id = this.3;
				1662.89.Schedule(delegate()
				{
					GL.DeleteFramebuffer(id);
				}, false);
			}
			this.3 = -1;
			1381 <<EMPTY_NAME>> = this.2;
			if (<<EMPTY_NAME>> != null)
			{
				<<EMPTY_NAME>>.Dispose();
			}
			this.2 = null;
			this.1 = null;
		}

		// Token: 0x04002C73 RID: 11379
		internal 1402 1;

		// Token: 0x04002C74 RID: 11380
		internal 1381 2;

		// Token: 0x04002C75 RID: 11381
		internal int 3 = -1;
	}

	// Token: 0x02000814 RID: 2068
	[276]
	private sealed class 2052 : 1433
	{
		// Token: 0x06003C32 RID: 15410 RVA: 0x0017ED4C File Offset: 0x0017CF4C
		internal 2052() : base(null, (1376)5, 1065.TopLeft, (1044)0, 208.Zero, 0.2f, true, 198.White, null)
		{
			this.27 = false;
		}

		// Token: 0x06003C33 RID: 15411 RVA: 0x0017ED7C File Offset: 0x0017CF7C
		public override bool Draw()
		{
			if (this.GetTexture() == null || 1436.40 == null)
			{
				return false;
			}
			1436.40.36(false);
			1436.40.35().6();
			1379.35(1, 771);
			bool result = base.Draw();
			1436.40.35().6();
			1379.35(770, 771);
			return result;
		}
	}

	// Token: 0x02000815 RID: 2069
	[CompilerGenerated]
	[276]
	private static class <>O
	{
		// Token: 0x04002C77 RID: 11383
		public static Func<1371, int> <0>__FirstStart;
	}
}
