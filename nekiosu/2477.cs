using System;

// Token: 0x0200055D RID: 1373
public sealed class 2477 : 1239
{
	// Token: 0x06002A29 RID: 10793 RVA: 0x000DD7B0 File Offset: 0x000DB9B0
	public override void Initialize()
	{
		this.11 = new float[this.10];
		base.Initialize();
		new 1400();
		this.8 = 1455.2("menu-snow", (1416)2, null);
		if (this.8 == null)
		{
			switch (2486.14())
			{
			case 2147.Taiko:
				this.8 = 1455.2("mode-taiko-small", (1416)1, null);
				break;
			case 2147.CatchTheBeat:
				this.8 = 1455.2("mode-fruits-small", (1416)1, null);
				break;
			case 2147.OsuMania:
				this.8 = 1455.2("mode-mania-small", (1416)1, null);
				break;
			default:
				this.8 = 1455.2("mode-osu-small", (1416)1, null);
				break;
			}
		}
		this.9 = new 1433(this.8, 1065.Centre, 208.Zero, 1f, true, 198.White);
		this.9.49 = 1065.Centre;
		this.9.28 = true;
		this.9.5 = true;
	}

	// Token: 0x06002A2A RID: 10794 RVA: 0x000DD8A4 File Offset: 0x000DBAA4
	protected override void Dispose(bool 1)
	{
		this.7.Dispose();
		base.Dispose(1);
	}

	// Token: 0x06002A2B RID: 10795 RVA: 0x000DD8B8 File Offset: 0x000DBAB8
	public override void Draw()
	{
		this.7.22();
		base.Draw();
	}

	// Token: 0x06002A2C RID: 10796 RVA: 0x000DD8CC File Offset: 0x000DBACC
	public override void Update()
	{
		if (1662.23)
		{
			if (this.7.28.Count > 0)
			{
				2477.2478 <<EMPTY_NAME>> = new 2477.2478();
				<<EMPTY_NAME>>.2 = this;
				<<EMPTY_NAME>>.1 = 1535.6 / 1662.70.3();
				if (this.12 != 208.Zero && this.12 != <<EMPTY_NAME>>.1)
				{
					this.7.28.ForEach(new Action<1371>(<<EMPTY_NAME>>.1));
				}
				this.12 = <<EMPTY_NAME>>.1;
				for (int i = 0; i < this.10; i++)
				{
					if (this.11[i] > 0f && this.11[i] < (float)1662.70.2())
					{
						this.11[i] += 0.05f;
					}
				}
			}
			if (1304.170.1())
			{
				int 2 = 0;
				try
				{
					2 = 1219.10(1226.31.2());
				}
				catch
				{
				}
				int num = 1019.8(2);
				int num2 = 1019.7(2);
				float num3 = 1226.63() ? 0.5f : (Math.Min(0.5f, Math.Max(0.1f, (float)(num + num2 - 30000) / 35536f)) * 0.4f);
				if (1196.3() > (double)(1f - num3))
				{
					1433 3 = this.9.Clone();
					3.17 = new 208(1196.6((float)1662.70.1()), -50f);
					3.16 = 1196.6(0.7f);
					3.15 = 1196.7(0.1f, 0.6f);
					3.9 = 1196.2(-500, 500);
					3.8 = 1196.2(-2, 2);
					this.7.12(3);
				}
			}
		}
		this.7.28.ForEach(delegate(1371 1)
		{
			1433 4 = 1 as 1433;
			if (1.5)
			{
				bool flag = 1.17.X >= 0f && 1.17.X < (float)1662.70.1();
				int num4 = (int)Math.Min((float)(this.10 - 1), Math.Max(0f, 1.17.X / 1f));
				float num5 = flag ? this.11[num4] : 0f;
				float num6 = 1.17.Y + 1.15 * ((float)4.34 / 1.6f / 2f);
				if (num6 >= (float)1662.70.2() || (num5 > 0f && num5 <= num6))
				{
					1.8 = 0;
					1.9 = 0;
					1.5 = false;
					1.16(60000, (1046)0, 0);
					if (!flag)
					{
						return;
					}
					this.11[num4] = 1.17.Y + 1.15 * ((float)4.34 / 1.6f / 4f);
				}
				if (1.9 != 0 || (int)1.8 != 0)
				{
					1.9 += (int)1.8;
					1.17.X = 1.17.X + (float)1.9 / 5000f * (float)1662.10;
					1.17.Y = 1.17.Y + (float)1662.10;
					1.14 += (float)1.9 / 10000f * (float)1662.10 * 0.4f;
				}
			}
		});
		base.Update();
	}

	// Token: 0x04001EDB RID: 7899
	private 1436 7 = new 1436(true)
	{
		22 = false
	};

	// Token: 0x04001EDC RID: 7900
	private 1381 8;

	// Token: 0x04001EDD RID: 7901
	private 1433 9;

	// Token: 0x04001EDE RID: 7902
	private int 10 = 1662.70.1() + 1;

	// Token: 0x04001EDF RID: 7903
	private float[] 11;

	// Token: 0x04001EE0 RID: 7904
	private 208 12;

	// Token: 0x04001EE1 RID: 7905
	private float 13;

	// Token: 0x0200055E RID: 1374
	public sealed class 2478
	{
		// Token: 0x06002A2F RID: 10799 RVA: 0x000DDCDC File Offset: 0x000DBEDC
		internal void 1(1371 1)
		{
			if (1.5)
			{
				1.9 += (int)((this.1.X - this.2.12.X) * 10f);
			}
		}

		// Token: 0x04001EE2 RID: 7906
		public 208 1;

		// Token: 0x04001EE3 RID: 7907
		public 2477 2;
	}
}
