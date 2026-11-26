using System;
using System.Collections.Generic;

// Token: 0x02000911 RID: 2321
public sealed class 1686
{
	// Token: 0x06004201 RID: 16897 RVA: 0x00199F34 File Offset: 0x00198134
	internal 1686(string 1)
	{
		this.4(1);
		this.18 = 1272.5();
	}

	// Token: 0x06004202 RID: 16898 RVA: 0x00199F63 File Offset: 0x00198163
	private bool 1()
	{
		return this.10;
	}

	// Token: 0x06004203 RID: 16899 RVA: 0x00199F6B File Offset: 0x0019816B
	private void 2(bool 1)
	{
		this.10 = 1;
		this.13();
	}

	// Token: 0x06004204 RID: 16900 RVA: 0x00199F7A File Offset: 0x0019817A
	internal string 3()
	{
		return this.11;
	}

	// Token: 0x06004205 RID: 16901 RVA: 0x00199F82 File Offset: 0x00198182
	internal void 4(string 1)
	{
		this.11 = 1;
		if (this.12 == null)
		{
			this.12 = this.3();
		}
	}

	// Token: 0x06004206 RID: 16902 RVA: 0x00199FA0 File Offset: 0x001981A0
	internal bool 5(208 1)
	{
		this.17 = 1;
		bool flag = this.13 == null;
		if (flag)
		{
			this.6();
		}
		else
		{
			208 2 = this.13[0].7;
			foreach (1433 3 in this.13)
			{
				208 4 = this.17 + (3.7 - 2);
				3.19(4, 500, (1046)1);
			}
		}
		this.13();
		return flag;
	}

	// Token: 0x06004207 RID: 16903 RVA: 0x0019A04C File Offset: 0x0019824C
	private void 6()
	{
		this.7();
		this.8();
		this.11();
	}

	// Token: 0x06004208 RID: 16904 RVA: 0x0019A060 File Offset: 0x00198260
	private void 7()
	{
		if (this.13 != null)
		{
			return;
		}
		this.13 = new List<1433>();
		List<string> list = 1297.3(this.3());
		if (list == null)
		{
			return;
		}
		int count = list.Count;
		int num = 0;
		for (int i = count - 1; i >= 0; i--)
		{
			if (1272.8(list[i]) == null)
			{
				num++;
			}
		}
		this.14 = count - num;
	}

	// Token: 0x06004209 RID: 16905 RVA: 0x0019A0C4 File Offset: 0x001982C4
	private void 8()
	{
		if (this.4 != null)
		{
			return;
		}
		this.4 = new 1448(string.Empty, 12f, this.17, 448f, 0.95f, false);
		this.4.1.6 = new 198(200, 200, 200);
		this.4.11 = true;
		this.4.14 = 11f + 2f * this.1.Y;
		this.4.3 = 198.Yellow;
		this.4.1.58(198.Black);
		this.4.1.72 = 1;
		this.4.1.3(delegate(object 1, EventArgs 2)
		{
			this.15 = true;
			this.13();
			1684.16(this);
		});
		this.4.4(delegate(1448 1, bool 2)
		{
			if (this.1())
			{
				if (this.3().Length > 25)
				{
					this.4(this.3().Substring(0, 25));
					this.4.SetText(this.3().Substring(0, 25));
				}
				if (this.4.GetText().Length > 25)
				{
					this.4.SetText(this.4.GetText().Substring(0, 25));
				}
			}
		});
		this.4.3(new 1448.1449(this.10));
		this.4.1.35(new EventHandler(this.18));
		this.4.1.37(new EventHandler(this.19));
		this.13.AddRange(this.4.2);
	}

	// Token: 0x0600420A RID: 16906 RVA: 0x0019A220 File Offset: 0x00198420
	internal void 9()
	{
		1448 <<EMPTY_NAME>> = this.4;
		if (<<EMPTY_NAME>> == null)
		{
			return;
		}
		<<EMPTY_NAME>>.Dispose();
	}

	// Token: 0x0600420B RID: 16907 RVA: 0x0019A234 File Offset: 0x00198434
	private void 10(1448 1, bool 2)
	{
		if (this.1())
		{
			if (this.4.GetText().Length == 0)
			{
				this.4((this.12.Length > 25) ? this.12.Substring(0, 25) : this.12);
				this.12(this.12, this.3());
				this.12 = this.3();
				this.4.SetText(this.3());
			}
			else
			{
				this.12(this.12, this.4.GetText());
				this.12 = this.4.GetText();
				this.4(this.4.GetText());
			}
			this.2(false);
			this.13();
			1684.16(this);
		}
	}

	// Token: 0x0600420C RID: 16908 RVA: 0x0019A306 File Offset: 0x00198506
	private void OnClick(object 1, EventArgs 2)
	{
		this.15 = true;
		this.13();
		1684.16(this);
	}

	// Token: 0x0600420D RID: 16909 RVA: 0x0019A31C File Offset: 0x0019851C
	private void 11()
	{
		if (this.5 == null)
		{
			this.5 = new 1452(1568.1(2679.General_Rename), 10f, this.17 + this.1, 0.96f, true, 198.White);
			this.5.10 = true;
			this.5.3(delegate(object 1, EventArgs 2)
			{
				this.2(!this.1());
			});
			this.5.75 = (1066)2;
			this.5.77 = new 208(35f, 11f);
			this.5.6 = 1686.3;
			this.5.58(198.Orange);
			this.5.72 = 2;
			this.5.60(198.Orange);
			this.13.Add(this.5);
			this.1 += new 208(10f + this.5.77.X, 0f);
		}
		if (this.7 == null)
		{
			this.7 = new 1452("+Set", 10f, this.17 + this.1, 0.96f, true, 198.White);
			this.7.10 = true;
			this.7.3(new EventHandler(this.16));
			this.7.52 = 1568.1(2679.CollectionSprites_AddSetToCollection);
			this.7.75 = (1066)2;
			this.7.77 = new 208(30f, 11f);
			this.7.58(198.Green);
			this.7.72 = 2;
			this.7.60(198.YellowGreen);
			this.13.Add(this.7);
			this.1 += new 208(5f + this.7.77.X, 0f);
		}
		if (this.6 == null)
		{
			this.6 = new 1452("+", 10f, this.17 + this.1, 0.96f, true, 198.White);
			this.6.10 = true;
			this.6.3(new EventHandler(this.16));
			this.6.52 = 1568.1(2679.CollectionSprites_AddToCollection);
			this.6.75 = (1066)2;
			this.6.77 = new 208(20f, 11f);
			this.6.58(198.Green);
			this.6.72 = 2;
			this.6.60(198.YellowGreen);
			this.13.Add(this.6);
			this.1 += new 208(5f + this.6.77.X, 0f);
		}
		if (this.9 == null)
		{
			this.9 = new 1452("-Set", 10f, this.17 + this.1, 0.96f, true, 198.White);
			this.9.10 = true;
			this.9.3(new EventHandler(this.15));
			this.9.52 = 1568.1(2679.CollectionSprites_RemoveSetFromCollection);
			this.9.75 = (1066)2;
			this.9.77 = new 208(30f, 11f);
			this.9.58(198.OrangeRed);
			this.9.72 = 2;
			this.9.60(198.DarkOrange);
			this.13.Add(this.9);
			this.1 += new 208(5f + this.9.77.X, 0f);
		}
		if (this.8 == null)
		{
			this.8 = new 1452("-", 10f, this.17 + this.1, 0.96f, true, 198.White);
			this.8.10 = true;
			this.8.3(new EventHandler(this.15));
			this.8.52 = 1568.1(2679.CollectionSprites_RemoveFromCollection);
			this.8.75 = (1066)2;
			this.8.77 = new 208(20f, 11f);
			this.8.58(198.OrangeRed);
			this.8.72 = 2;
			this.8.60(198.DarkOrange);
			this.13.Add(this.8);
		}
	}

	// Token: 0x0600420E RID: 16910 RVA: 0x0019A820 File Offset: 0x00198A20
	private void 12(string 1, string 2)
	{
		List<string> list = 1297.3(1);
		1297.10(1);
		1297.8(2);
		if (list != null)
		{
			for (int i = 0; i < list.Count; i++)
			{
				1297.9(2, list[i]);
			}
		}
	}

	// Token: 0x0600420F RID: 16911 RVA: 0x0019A864 File Offset: 0x00198A64
	internal void 13()
	{
		if (!this.1())
		{
			this.4.18(false);
			this.4.11 = true;
			try
			{
				this.16 = 1297.3(this.12).Contains(1272.5().23);
			}
			catch
			{
				return;
			}
			this.4.1.60(this.16 ? 198.YellowGreen : 198.White);
			string arg = this.3();
			if (this.3().Length > 40)
			{
				arg = this.3().Substring(0, 40) + "...";
			}
			this.4.SetText(string.Format("{0} ({1})", arg, this.14));
			if (this.15 != this.4.1.53())
			{
				this.4.1.54(this.15);
				this.4.1.88 = true;
			}
			this.6.6 = (this.7.6 = (this.16 ? 1686.2 : 1686.3));
			this.8.6 = (this.9.6 = (this.16 ? 1686.3 : 1686.2));
			return;
		}
		this.4.1.60(198.Yellow);
		this.4.SetText(this.3());
		this.4.11 = false;
		this.4.17(false);
	}

	// Token: 0x06004210 RID: 16912 RVA: 0x0019AA18 File Offset: 0x00198C18
	internal void 14()
	{
		this.15 = false;
		this.2(false);
	}

	// Token: 0x06004211 RID: 16913 RVA: 0x0019AA28 File Offset: 0x00198C28
	private void 15(object 1, EventArgs 2)
	{
		if (this.1())
		{
			this.2(false);
		}
		this.17(true, 1 == this.9);
	}

	// Token: 0x06004212 RID: 16914 RVA: 0x0019AA49 File Offset: 0x00198C49
	private void 16(object 1, EventArgs 2)
	{
		if (this.1())
		{
			this.2(false);
		}
		this.17(false, 1 == this.7);
	}

	// Token: 0x06004213 RID: 16915 RVA: 0x0019AA6C File Offset: 0x00198C6C
	private void 17(bool 1, bool 2)
	{
		bool flag = false;
		if (2)
		{
			using (List<1262>.Enumerator enumerator = 1272.3.FindAll(new Predicate<1262>(this.20)).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					1262 3 = enumerator.Current;
					if (1)
					{
						if (1297.11(this.3(), 3.23))
						{
							this.14--;
							flag = true;
						}
					}
					else if (1297.9(this.3(), 3.23))
					{
						this.14++;
						flag = true;
					}
				}
				goto IL_E7;
			}
		}
		if (1)
		{
			if (1297.11(this.3(), this.18.23))
			{
				this.14--;
				flag = true;
			}
		}
		else if (1297.9(this.3(), this.18.23))
		{
			this.14++;
			flag = true;
		}
		IL_E7:
		if (flag)
		{
			1763.2(string.Format(1 ? 1568.1(2679.CollectionSprites_Removed) : 1568.1(2679.CollectionSprites_Added), 2 ? this.18.81 : this.18.50, this.3()), 1500, (1389)0);
			this.13();
		}
	}

	// Token: 0x06004214 RID: 16916 RVA: 0x0019ABC4 File Offset: 0x00198DC4
	private void 18(object 1, EventArgs 2)
	{
		if (this.4.1.19 && this.4.1.16 == 1f)
		{
			this.4.1.6 = 198.White;
		}
	}

	// Token: 0x06004215 RID: 16917 RVA: 0x0019AC04 File Offset: 0x00198E04
	private void 19(object 1, EventArgs 2)
	{
		if (this.4.1.19 && this.4.1.16 == 1f)
		{
			this.4.1.6 = new 198(200, 200, 200);
		}
	}

	// Token: 0x06004216 RID: 16918 RVA: 0x0019AC5E File Offset: 0x00198E5E
	private bool 20(1262 1)
	{
		return 1.37 == this.18.37;
	}

	// Token: 0x0400302E RID: 12334
	private 208 1 = new 208(280f, 2f);

	// Token: 0x0400302F RID: 12335
	internal static 198 2 = new 198(150, 150, 150);

	// Token: 0x04003030 RID: 12336
	internal static 198 3 = new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue);

	// Token: 0x04003031 RID: 12337
	private 1448 4;

	// Token: 0x04003032 RID: 12338
	private 1452 5;

	// Token: 0x04003033 RID: 12339
	private 1452 6;

	// Token: 0x04003034 RID: 12340
	private 1452 7;

	// Token: 0x04003035 RID: 12341
	private 1452 8;

	// Token: 0x04003036 RID: 12342
	private 1452 9;

	// Token: 0x04003037 RID: 12343
	private bool 10;

	// Token: 0x04003038 RID: 12344
	private string 11;

	// Token: 0x04003039 RID: 12345
	private string 12;

	// Token: 0x0400303A RID: 12346
	internal List<1433> 13;

	// Token: 0x0400303B RID: 12347
	internal int 14;

	// Token: 0x0400303C RID: 12348
	internal bool 15;

	// Token: 0x0400303D RID: 12349
	private bool 16;

	// Token: 0x0400303E RID: 12350
	private 208 17;

	// Token: 0x0400303F RID: 12351
	private readonly 1262 18;
}
