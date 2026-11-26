using System;

// Token: 0x02000569 RID: 1385
public sealed class 2468 : IDisposable
{
	// Token: 0x06002A60 RID: 10848 RVA: 0x000DED58 File Offset: 0x000DCF58
	public 2468(string 1)
	{
		this.1 = new 1452(string.Empty, 14f, new 208((float)(1662.70.1() / 2), 240f), 1f, true, 198.White);
		this.1.49 = 1065.Centre;
		this.3.12(new 1433(1455.2("beatmapimport-top", (1416)1, null), (1376)7, 1065.TopCentre, (1044)0, 208.Zero)
		{
			5 = true
		});
		if (1662.70.1() > 860)
		{
			this.3.12(new 1433(1455.2("beatmapimport-top", (1416)1, null), (1376)7, 1065.TopCentre, (1044)0, 208.Zero)
			{
				5 = true,
				2 = 0.9f,
				20 = new 208(2f, 1f)
			});
		}
		this.5 = 2468.1(new 198(byte.MaxValue, 96, 171));
		this.5.15(2000);
		1433 2 = this.5;
		2.17.Y = 2.17.Y + 70f;
		this.3.12(this.5);
		this.3(1);
	}

	// Token: 0x06002A61 RID: 10849 RVA: 0x000DEEB4 File Offset: 0x000DD0B4
	public static 1433 1(198 1)
	{
		return new 1433(1455.2("beatmapimport-spinner", (1416)1, null), (1376)10, 1065.Centre, (1044)0, 208.Zero, 1f, true, 1, null)
		{
			3 = 
			{
				new 1445(1456.Rotation, 0f, 6.2831855f, 1662.33, 1662.33 + 1500, (1046)0)
				{
					17 = true
				},
				new 1445(1456.Scale, 0.5f, 1.3f, 1662.33, 1662.33 + 200, (1046)1),
				new 1445(1456.Scale, 1.3f, 0.9f, 1662.33 + 200, 1662.33 + 400, (1046)2),
				new 1445(1456.Scale, 0.9f, 1f, 1662.33 + 400, 1662.33 + 500, (1046)1)
			}
		};
	}

	// Token: 0x06002A62 RID: 10850 RVA: 0x000DEFA6 File Offset: 0x000DD1A6
	public void Dispose()
	{
		this.2(true);
	}

	// Token: 0x06002A63 RID: 10851 RVA: 0x000DEFAF File Offset: 0x000DD1AF
	protected void 2(bool 1)
	{
		this.2.Dispose();
		this.3.Dispose();
	}

	// Token: 0x06002A64 RID: 10852 RVA: 0x000DEFC8 File Offset: 0x000DD1C8
	public void 3(string 1)
	{
		2468.2469 2 = new 2468.2469();
		2.1 = this;
		2.2 = 1;
		if (this.4)
		{
			this.4 = false;
			1662.89.Schedule(new 1189(2.1), false);
		}
	}

	// Token: 0x06002A65 RID: 10853 RVA: 0x000DF010 File Offset: 0x000DD210
	public void 4()
	{
		this.2.22();
		this.3.22();
		this.4 = true;
	}

	// Token: 0x04001F05 RID: 7941
	private 1452 1;

	// Token: 0x04001F06 RID: 7942
	private 1436 2 = new 1436(true);

	// Token: 0x04001F07 RID: 7943
	private 1436 3 = new 1436(true);

	// Token: 0x04001F08 RID: 7944
	private bool 4 = true;

	// Token: 0x04001F09 RID: 7945
	private 1433 5;

	// Token: 0x0200056A RID: 1386
	public sealed class 2469
	{
		// Token: 0x06002A66 RID: 10854 RVA: 0x000DF034 File Offset: 0x000DD234
		internal void 1()
		{
			1452 <<EMPTY_NAME>> = (1452)this.1.1.Clone();
			<<EMPTY_NAME>>.SetText(this.2);
			this.1.2.12(<<EMPTY_NAME>>);
			foreach (1371 2 in this.1.2.28)
			{
				1433 3 = (1433)2;
				if (3.17.Y < 0f)
				{
					3.3.Clear();
					3.5 = false;
				}
				else if ((double)3.16 > 0.01)
				{
					3.22(new 208(0f, -20f), 500, (1046)0);
					3.16(10000, (1046)0, 0);
					3.5 = false;
				}
			}
		}

		// Token: 0x04001F0A RID: 7946
		public 2468 1;

		// Token: 0x04001F0B RID: 7947
		public string 2;
	}
}
