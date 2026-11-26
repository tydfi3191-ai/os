using System;
using System.Collections.Generic;

// Token: 0x020005E4 RID: 1508
public sealed class 2458
{
	// Token: 0x06002E70 RID: 11888 RVA: 0x001072A4 File Offset: 0x001054A4
	internal 2458(2263 1)
	{
		this.2 = new List<2458.2459>();
		this.3 = new Stack<2458.2459>();
		this.1 = 1;
		this.10();
		this.14 = new bool[5];
	}

	// Token: 0x06002E71 RID: 11889 RVA: 0x001072F4 File Offset: 0x001054F4
	private void 1(bool 1)
	{
		if (1 != this.10)
		{
			this.10 = 1;
			1184 2 = this.8;
			if (2 == null)
			{
				return;
			}
			2(1);
		}
	}

	// Token: 0x06002E72 RID: 11890 RVA: 0x00107317 File Offset: 0x00105517
	private void 2(bool 1)
	{
		if (1 != this.11)
		{
			this.11 = 1;
			1184 2 = this.9;
			if (2 == null)
			{
				return;
			}
			2(1);
		}
	}

	// Token: 0x06002E73 RID: 11891 RVA: 0x0010733A File Offset: 0x0010553A
	private bool 3()
	{
		return this.currentHandler != null && this.currentHandler.6 && !this.18 && !this.7();
	}

	// Token: 0x06002E74 RID: 11892 RVA: 0x00107364 File Offset: 0x00105564
	internal void 4(bool 1)
	{
		this.15 = 1;
		if (this.currentHandler != null)
		{
			this.currentHandler.6(this.15);
		}
	}

	// Token: 0x06002E75 RID: 11893 RVA: 0x00107386 File Offset: 0x00105586
	public bool 5()
	{
		return this.19;
	}

	// Token: 0x06002E76 RID: 11894 RVA: 0x0010738E File Offset: 0x0010558E
	private void 6(bool 1)
	{
		this.19 = 1;
	}

	// Token: 0x06002E77 RID: 11895 RVA: 0x00107397 File Offset: 0x00105597
	public bool 7()
	{
		return this.20;
	}

	// Token: 0x06002E78 RID: 11896 RVA: 0x0010739F File Offset: 0x0010559F
	private void 8(bool 1)
	{
		this.20 = 1;
	}

	// Token: 0x06002E79 RID: 11897 RVA: 0x001073A8 File Offset: 0x001055A8
	internal 2452 9()
	{
		if (this.currentHandler != null)
		{
			return this.currentHandler.3();
		}
		return (2452)5;
	}

	// Token: 0x06002E7A RID: 11898 RVA: 0x001073BF File Offset: 0x001055BF
	internal void 10()
	{
		if (this.1 != null)
		{
			this.6 = this.1.7;
			this.7 = this.1.6;
		}
	}

	// Token: 0x06002E7B RID: 11899 RVA: 0x001073EC File Offset: 0x001055EC
	internal void 11(2452 1, bool 2)
	{
		if (this.4 != null)
		{
			2453 3 = this.currentHandler;
			if (3 == null || 3.3() != 1)
			{
				3 = this.4.3(1);
			}
			if (3 != null)
			{
				3.6 = 2;
			}
		}
	}

	// Token: 0x06002E7C RID: 11900 RVA: 0x0010742C File Offset: 0x0010562C
	private void 12(2452 1)
	{
		if (1 != (2452)5 && this.4 != null)
		{
			this.currentHandler = this.4.3(1);
			if (this.currentHandler == null)
			{
				this.currentHandler = this.4.1(1);
				return;
			}
			this.currentHandler.8(this.currentHandler.2());
		}
	}

	// Token: 0x06002E7D RID: 11901 RVA: 0x00107488 File Offset: 0x00105688
	internal void 13(2451 1, 2450 2)
	{
		this.14(this.9(), 1, 2);
	}

	// Token: 0x06002E7E RID: 11902 RVA: 0x00107498 File Offset: 0x00105698
	internal void 14(2452 1, 2451 2, 2450 3)
	{
		if (!this.18 && !this.7() && this.5() && 1 != (2452)5)
		{
			if (this.currentHandler == null || this.currentHandler.3() != 1)
			{
				this.12(1);
			}
			if (this.currentHandler.6)
			{
				this.currentHandler.6(this.15);
				this.currentHandler.BeginAction(2, 3);
			}
		}
	}

	// Token: 0x06002E7F RID: 11903 RVA: 0x00107509 File Offset: 0x00105709
	internal void 15(2452 1, 2451 2, bool? 3)
	{
		this.16(1, 2, (2450)0, 3);
	}

	// Token: 0x06002E80 RID: 11904 RVA: 0x00107515 File Offset: 0x00105715
	internal void 16(2452 1, 2451 2, 2450 3, bool? 4)
	{
		this.19(1, 4);
		this.13(2, 3);
	}

	// Token: 0x06002E81 RID: 11905 RVA: 0x00107528 File Offset: 0x00105728
	internal void 17<T>(2452 1, 2451 2, List<T> 3)
	{
		this.15(1, 2, null);
		this.24<T>(3, false);
	}

	// Token: 0x06002E82 RID: 11906 RVA: 0x00107550 File Offset: 0x00105750
	internal void 18(2452 1, 2451 2, object 3)
	{
		this.15(1, 2, null);
		this.23(3, false);
	}

	// Token: 0x06002E83 RID: 11907 RVA: 0x00107578 File Offset: 0x00105778
	internal void 19(2452 1, bool? 2)
	{
		if (this.18 || this.7())
		{
			return;
		}
		this.30();
		if (1 != this.9() || !this.5())
		{
			this.6(true);
			if (2 != null)
			{
				this.4(2.Value);
			}
			this.12(1);
		}
	}

	// Token: 0x06002E84 RID: 11908 RVA: 0x001075D4 File Offset: 0x001057D4
	internal void 20(bool 1, bool 2)
	{
		if (!this.17 || this.16 || !this.5() || this.4 == null)
		{
			return;
		}
		this.6(this.16 = false);
		try
		{
			if (1)
			{
				if (2)
				{
					this.4.10();
					if (this.4.5())
					{
						this.Undo();
					}
				}
				this.31();
			}
			else
			{
				this.4.10();
				if (!this.4.5())
				{
					this.31();
				}
			}
			if (this.2.Count > 100)
			{
				while (this.2.Count > 100)
				{
					this.2.RemoveAt(0);
					this.5--;
				}
			}
		}
		catch (Exception ex)
		{
			1619.1(new 1618(ex)
			{
				1 = "undo states"
			});
		}
	}

	// Token: 0x06002E85 RID: 11909 RVA: 0x001076C4 File Offset: 0x001058C4
	internal void 21<T>(List<T> 1)
	{
		if (this.3())
		{
			this.currentHandler.12<T>(1);
		}
	}

	// Token: 0x06002E86 RID: 11910 RVA: 0x001076DA File Offset: 0x001058DA
	internal void 22(object 1)
	{
		if (this.3())
		{
			this.currentHandler.11(1);
		}
	}

	// Token: 0x06002E87 RID: 11911 RVA: 0x001076F0 File Offset: 0x001058F0
	internal void 23(object 1, bool 2)
	{
		this.25(1, (2450)0, 2);
	}

	// Token: 0x06002E88 RID: 11912 RVA: 0x001076FB File Offset: 0x001058FB
	internal void 24<T>(List<T> 1, bool 2)
	{
		this.26<T>(1, (2450)0, 2);
	}

	// Token: 0x06002E89 RID: 11913 RVA: 0x00107708 File Offset: 0x00105908
	internal void 25(object 1, 2450 2, bool 3)
	{
		if (!this.3())
		{
			return;
		}
		try
		{
			if (3)
			{
				this.currentHandler.ReplaceObjects(1, 2);
			}
			else
			{
				this.currentHandler.RecordObjects(1, 2);
			}
		}
		catch
		{
		}
	}

	// Token: 0x06002E8A RID: 11914 RVA: 0x00107754 File Offset: 0x00105954
	internal void 26<T>(List<T> 1, 2450 2, bool 3)
	{
		if (!this.3())
		{
			return;
		}
		try
		{
			if (3)
			{
				this.currentHandler.ReplaceObjects<T>(1, 2);
			}
			else
			{
				this.currentHandler.RecordObjects<T>(1, 2);
			}
		}
		catch
		{
		}
	}

	// Token: 0x06002E8B RID: 11915 RVA: 0x001077A0 File Offset: 0x001059A0
	internal void 27()
	{
		if (this.3())
		{
			this.currentHandler.MarkCurrentComplete();
		}
	}

	// Token: 0x06002E8C RID: 11916 RVA: 0x001077B8 File Offset: 0x001059B8
	internal void 28(2123 1, int 2)
	{
		if (this.3() && this.9() == (2452)0 && 1 != null)
		{
			2440 3 = (2440)this.currentHandler;
			2440.2443 4 = new 2440.2443(1, 2);
			3.23(4, true);
		}
	}

	// Token: 0x06002E8D RID: 11917 RVA: 0x001077F2 File Offset: 0x001059F2
	internal void 29(2064 1)
	{
		if (this.3() && this.9() == (2452)0)
		{
			((2440)this.currentHandler).RecordObjects(1, (2450)0);
		}
	}

	// Token: 0x06002E8E RID: 11918 RVA: 0x0010781C File Offset: 0x00105A1C
	private void 30()
	{
		if (!this.18 && !this.5() && (this.4 == null || this.4.6()))
		{
			this.12 = this.13;
			this.13 = true;
			if (this.11 && this.5 >= 0)
			{
				this.32();
				this.2.RemoveRange(this.5, this.2.Count - this.5);
			}
			this.4 = new 2458.2459(this);
			this.5 = this.2.Count;
			this.2.Add(this.4);
			this.1(true);
			this.2(false);
		}
	}

	// Token: 0x06002E8F RID: 11919 RVA: 0x001078E0 File Offset: 0x00105AE0
	private void 31()
	{
		if (this.4 == null || this.2.Count == 0)
		{
			return;
		}
		this.6(false);
		if (!this.12)
		{
			this.13 = false;
		}
		this.5 = this.2.IndexOf(this.4);
		this.2.Remove(this.4);
		this.4 = null;
		this.currentHandler = null;
		if (this.2.Count > 0)
		{
			if (this.5 >= this.2.Count)
			{
				this.5 = this.2.Count - 1;
			}
		}
		else
		{
			this.5 = -1;
		}
		this.33();
		if (this.5 < 0)
		{
			this.1(false);
			this.2(false);
			return;
		}
		this.4 = this.2[this.5];
		if (this.4.7())
		{
			this.1(true);
			this.2(this.5 < this.2.Count - 1);
			return;
		}
		this.1(this.5 > 0);
		this.2(true);
	}

	// Token: 0x06002E90 RID: 11920 RVA: 0x00107A08 File Offset: 0x00105C08
	private void 32()
	{
		if (this.5 >= 0 && this.2.Count != 0)
		{
			this.3.Clear();
			int num = this.2.Count - 1;
			while (this.5 <= num)
			{
				this.3.Push(this.2[num]);
				num--;
			}
		}
	}

	// Token: 0x06002E91 RID: 11921 RVA: 0x00107A6C File Offset: 0x00105C6C
	private void 33()
	{
		int num = this.5 + 1;
		if (num < this.2.Count)
		{
			this.2.RemoveRange(num, this.2.Count - num);
		}
		while (this.3.Count > 0)
		{
			this.2.Add(this.3.Pop());
		}
		if (this.2.Count > 0 && this.5 < 0)
		{
			this.5 = 0;
		}
		this.2(this.5 >= 0 && this.5 < this.2.Count);
	}

	// Token: 0x06002E92 RID: 11922 RVA: 0x00107B12 File Offset: 0x00105D12
	internal void 34()
	{
		this.2.Clear();
		this.3.Clear();
		this.1(false);
		this.2(false);
	}

	// Token: 0x06002E93 RID: 11923 RVA: 0x00107B38 File Offset: 0x00105D38
	internal void Undo()
	{
		try
		{
			if (1662.78 == 1677.Edit)
			{
				if (this.1.26 == 2335.Compose)
				{
					this.1.74.7(false);
					if (this.1.74.40 || this.1.74.67())
					{
						this.1.85 = true;
						this.1.87 = true;
					}
				}
				this.1.16(true);
			}
			if (this.5())
			{
				this.16 = false;
				this.17 = true;
				this.20(false, false);
			}
			if (this.5 < 0 || this.5 >= this.2.Count)
			{
				return;
			}
			this.4 = this.2[this.5];
			if (!this.4.7())
			{
				if (this.5 - 1 < 0)
				{
					return;
				}
				this.5--;
				this.4 = this.2[this.5];
			}
			this.8(true);
			2458.2459 <<EMPTY_NAME>> = this.4;
			if (<<EMPTY_NAME>> != null)
			{
				<<EMPTY_NAME>>.9(true);
			}
			this.1(this.5 > 0);
			this.2(true);
		}
		catch (Exception ex)
		{
			1338.4(ex, "Fatal error when saving undo state", 1341.Runtime);
		}
		this.8(false);
	}

	// Token: 0x06002E94 RID: 11924 RVA: 0x00107CAC File Offset: 0x00105EAC
	internal void Redo()
	{
		if (this.5 < 0 || this.5 >= this.2.Count)
		{
			return;
		}
		if (1662.78 == 1677.Edit)
		{
			this.1.12(true);
		}
		if (this.5())
		{
			this.16 = false;
			this.17 = true;
			this.20(false, false);
		}
		this.4 = this.2[this.5];
		if (this.4.7())
		{
			if (this.5 + 1 >= this.2.Count)
			{
				return;
			}
			this.5++;
			this.4 = this.2[this.5];
		}
		this.8(true);
		2458.2459 <<EMPTY_NAME>> = this.4;
		if (<<EMPTY_NAME>> != null)
		{
			<<EMPTY_NAME>>.9(false);
		}
		this.1(true);
		this.2(this.5 < this.2.Count - 1);
		this.8(false);
	}

	// Token: 0x040021F0 RID: 8688
	internal 2263 1;

	// Token: 0x040021F1 RID: 8689
	private List<2458.2459> 2;

	// Token: 0x040021F2 RID: 8690
	private Stack<2458.2459> 3;

	// Token: 0x040021F3 RID: 8691
	private 2458.2459 4;

	// Token: 0x040021F4 RID: 8692
	private 2453 currentHandler;

	// Token: 0x040021F5 RID: 8693
	private int 5 = -1;

	// Token: 0x040021F6 RID: 8694
	internal 2039 6;

	// Token: 0x040021F7 RID: 8695
	internal 2648 7;

	// Token: 0x040021F8 RID: 8696
	public 1184 8;

	// Token: 0x040021F9 RID: 8697
	public 1184 9;

	// Token: 0x040021FA RID: 8698
	private bool 10;

	// Token: 0x040021FB RID: 8699
	private bool 11;

	// Token: 0x040021FC RID: 8700
	private bool 12;

	// Token: 0x040021FD RID: 8701
	internal bool 13;

	// Token: 0x040021FE RID: 8702
	private bool[] 14;

	// Token: 0x040021FF RID: 8703
	private bool 15;

	// Token: 0x04002200 RID: 8704
	internal bool 16;

	// Token: 0x04002201 RID: 8705
	internal bool 17 = true;

	// Token: 0x04002202 RID: 8706
	internal bool 18;

	// Token: 0x04002203 RID: 8707
	private bool 19;

	// Token: 0x04002204 RID: 8708
	private bool 20;

	// Token: 0x020005E5 RID: 1509
	public sealed class 2459
	{
		// Token: 0x06002E95 RID: 11925 RVA: 0x00107DA9 File Offset: 0x00105FA9
		internal 2459(2458 1)
		{
			this.1 = 1;
			this.1.currentHandler = null;
			this.1.6(false);
			this.2 = new List<2453>();
		}

		// Token: 0x06002E96 RID: 11926 RVA: 0x00107DDB File Offset: 0x00105FDB
		internal 2453 1(2452 1)
		{
			if (this.1.14[(int)1])
			{
				return null;
			}
			this.2.Add(2453.Create(1, this.1));
			return this.2[this.8() - 1];
		}

		// Token: 0x06002E97 RID: 11927 RVA: 0x00107E18 File Offset: 0x00106018
		internal void 2(2452 1)
		{
			this.2.Remove(this.3(1));
		}

		// Token: 0x06002E98 RID: 11928 RVA: 0x00107E30 File Offset: 0x00106030
		internal 2453 3(2452 1)
		{
			2458.2459.2460 categoryMatcherForFind = new 2458.2459.2460();
			categoryMatcherForFind.1 = 2;
			return this.2.Find((2453 1) => 1.3() == categoryMatcherForFind.1);
		}

		// Token: 0x06002E99 RID: 11929 RVA: 0x00107E71 File Offset: 0x00106071
		internal 2453 4(int 1)
		{
			if (this.2.Count <= 1)
			{
				return null;
			}
			return this.2[1];
		}

		// Token: 0x06002E9A RID: 11930 RVA: 0x00107E8F File Offset: 0x0010608F
		internal bool 5()
		{
			return this.2.Count > 0;
		}

		// Token: 0x06002E9B RID: 11931 RVA: 0x00107E9F File Offset: 0x0010609F
		internal bool 6()
		{
			return this.2.Find(new Predicate<2453>(2458.2459.2461.instance.1)) != null;
		}

		// Token: 0x06002E9C RID: 11932 RVA: 0x00107EBF File Offset: 0x001060BF
		internal bool 7()
		{
			return this.2.Find((2453 1) => 1.16(true) > 0) != null;
		}

		// Token: 0x06002E9D RID: 11933 RVA: 0x00107EEE File Offset: 0x001060EE
		internal int 8()
		{
			return this.2.Count;
		}

		// Token: 0x06002E9E RID: 11934 RVA: 0x00107EFC File Offset: 0x001060FC
		internal void 9(bool 1)
		{
			foreach (2453 2 in this.2)
			{
				if (!this.1.14[(int)2.3()])
				{
					1189 3 = (!1) ? new 1189(2.22) : new 1189(2.21);
					try
					{
						3();
					}
					catch (Exception)
					{
					}
				}
			}
		}

		// Token: 0x06002E9F RID: 11935 RVA: 0x00107F94 File Offset: 0x00106194
		internal int 10()
		{
			int num = 0;
			int num2 = 0;
			for (2453 <<EMPTY_NAME>> = this.4(num); <<EMPTY_NAME>> != null; <<EMPTY_NAME>> = this.4(num))
			{
				<<EMPTY_NAME>>.20();
				if (!<<EMPTY_NAME>>.17())
				{
					num2++;
					this.2(<<EMPTY_NAME>>.3());
				}
				else
				{
					num++;
				}
			}
			return num2;
		}

		// Token: 0x04002205 RID: 8709
		internal 2458 1;

		// Token: 0x04002206 RID: 8710
		private List<2453> 2;

		// Token: 0x020005E6 RID: 1510
		[Serializable]
		public sealed class 2461
		{
			// Token: 0x06002EA0 RID: 11936 RVA: 0x00107FDF File Offset: 0x001061DF
			internal bool 1(2453 1)
			{
				return 1.17();
			}

			// Token: 0x04002207 RID: 8711
			public static readonly 2458.2459.2461 instance = new 2458.2459.2461();

			// Token: 0x04002208 RID: 8712
			public static Predicate<2453> cachedHasHistory;

			// Token: 0x04002209 RID: 8713
			public static Predicate<2453> cachedHasUndoEntries;
		}

		// Token: 0x020005E7 RID: 1511
		public sealed class 2460
		{
			// Token: 0x0400220A RID: 8714
			public 2452 1;
		}
	}
}
