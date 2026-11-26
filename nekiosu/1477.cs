using System;
using System.Collections.Generic;

// Token: 0x02000AFC RID: 2812
public sealed class 1477 : 2535
{
	// Token: 0x06004E30 RID: 20016 RVA: 0x001EEF68 File Offset: 0x001ED168
	internal 1477(1333 1) : base(true)
	{
		this.3();
		1662.76(new 1189(this.3));
		this.4 = 1;
	}

	// Token: 0x06004E31 RID: 20017 RVA: 0x001EEFD8 File Offset: 0x001ED1D8
	private new int 1()
	{
		return this.7 / 800;
	}

	// Token: 0x06004E32 RID: 20018 RVA: 0x001EEFE6 File Offset: 0x001ED1E6
	private int 2()
	{
		return this.7 % 800;
	}

	// Token: 0x06004E33 RID: 20019 RVA: 0x001EEFF4 File Offset: 0x001ED1F4
	internal void 3()
	{
		this.1.15(true);
		this.8.Clear();
		this.1.12(new 1452("0ms", 18f / 1662.70.3(), new 208(0f, 100f / 1662.70.3()), 1f, true, 198.White)
		{
			66 = false,
			41 = (1376)6,
			49 = 1065.BottomLeft
		});
		1452 <<EMPTY_NAME>> = new 1452(20f.ToString() + "ms", 18f / 1662.70.3(), new 208(0f, 0f), 1f, true, 198.White)
		{
			66 = false,
			41 = (1376)6,
			49 = 1065.TopLeft
		};
		this.1.12(<<EMPTY_NAME>>);
		<<EMPTY_NAME>>.GetTextSize();
		float num = <<EMPTY_NAME>>.46.X;
		foreach (object obj in Enum.GetValues(typeof(1335)))
		{
			1335 2 = (1335)obj;
			if (2 < 1335.Empty)
			{
				<<EMPTY_NAME>> = new 1452(2.ToString(), 27f / 1662.70.3(), new 208(num / 1662.70.3(), 0f), 1f, true, this.5(2))
				{
					16 = 0f,
					66 = false,
					41 = (1376)6,
					49 = 1065.TopLeft
				};
				this.8.Add(<<EMPTY_NAME>>);
				<<EMPTY_NAME>>.GetTextSize();
				num += <<EMPTY_NAME>>.46.X;
			}
		}
		this.1.14<1433>(this.8);
		1304.173.SubscribeChanged(new EventHandler(this.7));
		for (int i = 0; i < this.5.Length; i++)
		{
			this.5[i] = new 1433(new 1381(800, 100), (1376)6, 1065.TopLeft, (1044)0, new 208(0f, 0f))
			{
				2 = 0f,
				5 = true,
				66 = false
			};
			this.1.12(this.5[i]);
		}
		this.1.27(new 1058((float)(1662.70.1 - 800), (float)(1662.70.2 - 100 + 1), 801f, 100f) / 1662.70.3());
		for (int j = 0; j < 800 * this.5.Length; j++)
		{
			this.7 = j;
			1433 3 = this.5[this.1()];
			this.6(1335.Empty, 100);
			((1402)3.GetTexture().gpuTexture).12(this.6, new 207(this.2(), 0, 1, 100), 0, 6408);
			3.GetTexture().gpuTexture.FlushPendingUpload();
		}
	}

	// Token: 0x06004E34 RID: 20020 RVA: 0x001EF338 File Offset: 0x001ED538
	internal void 4(198 1, float 2)
	{
		1433 3 = new 1433(1662.34, (1376)6, 1065.TopLeft, (1044)0, new 208(799f / 1662.70.3(), 0f), 0.1f + 2, true, 1, null)
		{
			66 = false,
			20 = new 208(3f, 3f)
		};
		this.9.Add(3);
		this.1.12(3);
	}

	// Token: 0x06004E35 RID: 20021 RVA: 0x001EF3AC File Offset: 0x001ED5AC
	internal override void Update()
	{
		base.Update();
		if (1549.1)
		{
			this.8.ForEach(new Action<1433>(1477.1478.spriteAlphaActions.1));
			return;
		}
		this.8.ForEach(new Action<1433>(1477.1478.spriteAlphaActions.2));
		for (int i = 0; i < this.11.Length; i++)
		{
			int num = GC.CollectionCount(i);
			if (this.11[i] != num)
			{
				this.11[i] = num;
				this.4(1477.10[i], (float)i);
			}
		}
		1433 <<EMPTY_NAME>> = this.5[this.1()];
		int 2 = 100;
		for (int j = 0; j <= 7; j++)
		{
			2 = this.6((1335)j, 2);
		}
		((1402)<<EMPTY_NAME>>.GetTexture().gpuTexture).12(this.6, new 207(this.2(), 0, 1, 100), 0, 6408);
		<<EMPTY_NAME>>.GetTexture().gpuTexture.FlushPendingUpload();
		this.5[this.1()].20((float)(800 - this.2()) / 1662.70.3(), 0, (1046)0);
		this.5[(this.1() + 1) % this.5.Length].20((float)(-(float)this.2()) / 1662.70.3(), 0, (1046)0);
		this.7 = (this.7 + 1) % (this.5.Length * 800);
		for (int k = 0; k < this.9.Count; k++)
		{
			1433 3 = this.9[k];
			1433 4 = 3;
			4.17.X = 4.17.X - 1f / 1662.70.3();
			if (3.17.X < -2f)
			{
				3.5 = false;
				3.16(0, (1046)0, 0);
				this.9.RemoveAt(k--);
			}
		}
	}

	// Token: 0x06004E36 RID: 20022 RVA: 0x001EF5A8 File Offset: 0x001ED7A8
	private 198 5(1335 1)
	{
		switch (1)
		{
		case 1335.Draw:
			return 198.BlueViolet;
		case 1335.SwapBuffer:
			return 198.Red;
		case 1335.BetweenFrames:
			return 198.GhostWhite;
		case 1335.Sleep:
			return 198.DarkBlue;
		case 1335.Scheduler:
			return 198.HotPink;
		case 1335.Empty:
			return new 198(50, 40, 40, 180);
		}
		return 198.YellowGreen;
	}

	// Token: 0x06004E37 RID: 20023 RVA: 0x001EF620 File Offset: 0x001ED820
	private int 6(1335 1, int 2)
	{
		double num = 0.0;
		int num2;
		if (1 == 1335.Empty)
		{
			num2 = 2;
		}
		else
		{
			if (!this.4.4.TryGetValue(1, out num))
			{
				return 2;
			}
			num2 = (int)(num * 5.0);
		}
		198 3 = this.5(1);
		int num3 = 2 - 1;
		while (num3 >= 0 && num2-- != 0)
		{
			int num4 = num3 * 4;
			this.6[num4] = 3.R;
			this.6[num4 + 1] = 3.G;
			this.6[num4 + 2] = 3.B;
			this.6[num4 + 3] = ((1 == 1335.Empty) ? ((byte)((float)3.A * (1f - (float)(num3 * 4 / 100) / 8f))) : 3.A);
			2--;
			num3--;
		}
		return 2;
	}

	// Token: 0x06004E38 RID: 20024 RVA: 0x001EF6F1 File Offset: 0x001ED8F1
	private void 7(object 1, EventArgs 2)
	{
		this.1.5 = (1304.173 > false);
	}

	// Token: 0x04003A50 RID: 14928
	private static 208 3 = new 208(0f, 0f);

	// Token: 0x04003A51 RID: 14929
	private 1333 4;

	// Token: 0x04003A52 RID: 14930
	private 1433[] 5 = new 1433[2];

	// Token: 0x04003A53 RID: 14931
	private byte[] 6 = new byte[400];

	// Token: 0x04003A54 RID: 14932
	private int 7;

	// Token: 0x04003A55 RID: 14933
	private List<1433> 8 = new List<1433>();

	// Token: 0x04003A56 RID: 14934
	private List<1433> 9 = new List<1433>();

	// Token: 0x04003A57 RID: 14935
	private static 198[] 10 = new 198[]
	{
		198.Green,
		198.Yellow,
		198.Red
	};

	// Token: 0x04003A58 RID: 14936
	private int[] 11 = new int[3];

	// Token: 0x02000AFD RID: 2813
	[Serializable]
	public sealed class 1478
	{
		// Token: 0x06004E3A RID: 20026 RVA: 0x001EF75C File Offset: 0x001ED95C
		internal void 1(1433 1)
		{
			1.16 = 1f;
		}

		// Token: 0x06004E3B RID: 20027 RVA: 0x00188354 File Offset: 0x00186554
		internal void 2(1433 1)
		{
			1.16 = 0f;
		}

		// Token: 0x04003A59 RID: 14937
		public static readonly 1477.1478 spriteAlphaActions = new 1477.1478();

		// Token: 0x04003A5A RID: 14938
		public static Action<1433> action;

		// Token: 0x04003A5B RID: 14939
		public static Action<1433> action2;
	}
}
