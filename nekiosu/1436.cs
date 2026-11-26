using System;
using System.Collections.Generic;
using System.Drawing;

// Token: 0x02000ACB RID: 2763
public sealed class 1436 : IDisposable
{
	// Token: 0x06004CC0 RID: 19648 RVA: 0x001E6733 File Offset: 0x001E4933
	internal 1436() : this(false)
	{
	}

	// Token: 0x06004CC1 RID: 19649 RVA: 0x001E673C File Offset: 0x001E493C
	internal 1436(bool 1)
	{
		this.6(1, null);
		1662.76(new 1189(this.7));
		List<1436> obj = 1436.3;
		lock (obj)
		{
			1436.39++;
			1436.3.Add(this);
		}
	}

	// Token: 0x06004CC2 RID: 19650 RVA: 0x001E686C File Offset: 0x001E4A6C
	internal bool 1()
	{
		return this.17;
	}

	// Token: 0x06004CC3 RID: 19651 RVA: 0x001E6874 File Offset: 0x001E4A74
	internal void 2(bool 1)
	{
		if (this.17 && !1)
		{
			int count = this.19.Count;
			if (count > 0)
			{
				for (int i = 0; i < count; i++)
				{
					this.21.Enqueue(this.19[i] as 1433);
				}
				this.19.Clear();
			}
		}
		this.17 = 1;
	}

	// Token: 0x06004CC4 RID: 19652 RVA: 0x001E68D8 File Offset: 0x001E4AD8
	internal void 3()
	{
		while (this.21.Count > 0)
		{
			1371 <<EMPTY_NAME>> = this.21.Dequeue();
			if (<<EMPTY_NAME>>.3.Count == 0)
			{
				<<EMPTY_NAME>>.Dispose();
			}
			else
			{
				this.12(<<EMPTY_NAME>>);
			}
		}
	}

	// Token: 0x06004CC5 RID: 19653 RVA: 0x001E691D File Offset: 0x001E4B1D
	internal int 4()
	{
		return this.28.Count + this.19.Count + this.21.Count;
	}

	// Token: 0x06004CC6 RID: 19654 RVA: 0x001E6944 File Offset: 0x001E4B44
	~1436()
	{
		1662.89.Schedule(new 1189(this.45), false);
	}

	// Token: 0x06004CC7 RID: 19655 RVA: 0x001E6984 File Offset: 0x001E4B84
	internal bool 5()
	{
		return this.41;
	}

	// Token: 0x06004CC8 RID: 19656 RVA: 0x001E698C File Offset: 0x001E4B8C
	internal void 6(bool 1, bool? 2)
	{
		this.41 = 1;
		this.25 = (2 ?? (!1));
		this.34 = (1 ? 1436.31 : 1436.32);
	}

	// Token: 0x06004CC9 RID: 19657 RVA: 0x001E69D3 File Offset: 0x001E4BD3
	private void 7()
	{
		if (!this.15)
		{
			this.6(this.41, new bool?(this.25));
		}
	}

	// Token: 0x06004CCA RID: 19658 RVA: 0x001E69F4 File Offset: 0x001E4BF4
	internal void 8()
	{
		List<1436> obj = 1436.3;
		lock (obj)
		{
			1436.3.Remove(this);
			1436.3.Add(this);
		}
	}

	// Token: 0x06004CCB RID: 19659 RVA: 0x001E6A44 File Offset: 0x001E4C44
	public void Dispose()
	{
		this.9(true);
		GC.SuppressFinalize(this);
	}

	// Token: 0x06004CCC RID: 19660 RVA: 0x001E6A54 File Offset: 0x001E4C54
	private void 9(bool 1)
	{
		if (this.42)
		{
			return;
		}
		this.42 = true;
		List<1436> obj = 1436.3;
		lock (obj)
		{
			1436.39--;
			1436.3.Remove(this);
		}
		this.15(true);
		for (int i = 0; i < this.34().Length; i++)
		{
			if (this.34()[i] != null)
			{
				this.34()[i].3();
				this.34()[i] = null;
			}
		}
		1662.77(new 1189(this.7));
	}

	// Token: 0x06004CCD RID: 19661 RVA: 0x001E6B00 File Offset: 0x001E4D00
	private void 10()
	{
		this.23 = null;
	}

	// Token: 0x06004CCE RID: 19662 RVA: 0x001E6B0C File Offset: 0x001E4D0C
	internal void 11(1433 1)
	{
		if (1 == null)
		{
			return;
		}
		2528 2 = 2528.Current;
		if (2 != null)
		{
			2.19(1);
		}
		object obj = 1436.2;
		lock (obj)
		{
			int num = this.28.BinarySearch(1, this.4);
			this.28.Insert((num < 0) ? (~num) : num, 1);
		}
	}

	// Token: 0x06004CCF RID: 19663 RVA: 0x001E6B84 File Offset: 0x001E4D84
	internal void 12(1371 1)
	{
		if (1 == null)
		{
			return;
		}
		2528 2 = 2528.Current;
		if (2 != null)
		{
			2.19(1);
		}
		if (!this.1() || 1.3.Count <= 0)
		{
			object obj = 1436.2;
			lock (obj)
			{
				int num = this.28.BinarySearch(1, this.4);
				this.28.Insert((num < 0) ? (~num) : num, 1);
			}
			return;
		}
		int num2 = this.19.BinarySearch(1);
		if (num2 < 0)
		{
			this.19.Insert(~num2, 1);
			return;
		}
		this.19.Insert(num2, 1);
	}

	// Token: 0x06004CD0 RID: 19664 RVA: 0x001E6C40 File Offset: 0x001E4E40
	internal void 13()
	{
		List<1371> obj = this.28;
		lock (obj)
		{
			this.28.Sort(this.4);
		}
	}

	// Token: 0x06004CD1 RID: 19665 RVA: 0x001E6C8C File Offset: 0x001E4E8C
	internal void 14<T>(IEnumerable<T> 1) where T : 1371
	{
		foreach (T t in 1)
		{
			if (t != null)
			{
				this.12(t);
			}
		}
	}

	// Token: 0x06004CD2 RID: 19666 RVA: 0x001E6CE4 File Offset: 0x001E4EE4
	internal void 15(bool 1)
	{
		this.10();
		object obj = 1436.2;
		lock (obj)
		{
			if (1)
			{
				for (int i = 0; i < this.28.Count; i++)
				{
					this.28[i].Dispose();
				}
			}
			this.28.Clear();
			if (1)
			{
				foreach (1371 2 in this.21)
				{
					((1433)2).Dispose();
				}
			}
			this.21.Clear();
			if (1)
			{
				for (int j = 0; j < this.19.Count; j++)
				{
					this.19[j].Dispose();
				}
			}
			this.19.Clear();
			if (1)
			{
				while (this.20.Count > 0)
				{
					this.20.Pop().Dispose();
				}
			}
			this.20.Clear();
		}
	}

	// Token: 0x06004CD3 RID: 19667 RVA: 0x001E6E14 File Offset: 0x001E5014
	internal List<1371> 16(object 1)
	{
		1436.1438 findByTagClosure = new 1436.1438();
		findByTagClosure.1 = 2;
		object obj = 1436.2;
		List<1371> result;
		lock (obj)
		{
			result = this.28.FindAll((1371 1) => 1.8 != null && 1.8.Equals(findByTagClosure.1));
		}
		return result;
	}

	// Token: 0x06004CD4 RID: 19668 RVA: 0x001E6E84 File Offset: 0x001E5084
	internal List<1371> 17()
	{
		object obj = 1436.2;
		List<1371> result;
		lock (obj)
		{
			List<1371> list = new List<1371>(this.28);
			list.AddRange(this.19);
			list.AddRange(this.21);
			result = list;
		}
		return result;
	}

	// Token: 0x06004CD5 RID: 19669 RVA: 0x001E6EE4 File Offset: 0x001E50E4
	internal List<1371> 18(ICollection<1371> 1)
	{
		object obj = 1436.2;
		List<1371> result;
		lock (obj)
		{
			List<1371> list = this.28.FindAll(new Predicate<1371>(1.Contains));
			this.28.RemoveAll(new Predicate<1371>(1.Contains));
			result = list;
		}
		return result;
	}

	// Token: 0x06004CD6 RID: 19670 RVA: 0x001E6F50 File Offset: 0x001E5150
	internal void 19(object 1)
	{
		1436.1439 removeByTagClosure = new 1436.1439();
		removeByTagClosure.1 = 2;
		object obj = 1436.2;
		lock (obj)
		{
			List<1371> list = this.28.FindAll((1371 1) => 1.8 != null && 1.8.Equals(removeByTagClosure.1));
			list.ForEach(new Action<1371>(1436.1440.spriteLayerCallbacks.2));
			this.20<1371>(list);
		}
	}

	// Token: 0x06004CD7 RID: 19671 RVA: 0x001E6FDC File Offset: 0x001E51DC
	internal void Remove(1371 1)
	{
		if (1 != null)
		{
			object obj = 1436.2;
			lock (obj)
			{
				this.28.Remove(1);
			}
			if (1.27)
			{
				1.Dispose();
			}
			1.19 = false;
		}
	}

	// Token: 0x06004CD8 RID: 19672 RVA: 0x001E703C File Offset: 0x001E523C
	internal void 20<T>(List<T> 1) where T : 1371
	{
		if (1 == null)
		{
			return;
		}
		if (1.Count > 50)
		{
			int num = this.28.BinarySearch(1[0], this.4);
			if (num >= 0)
			{
				int num2 = num + 1.Count - 1;
				if (num2 < this.28.Count && this.28[num2] == 1[1.Count - 1])
				{
					for (int i = num; i < num2; i++)
					{
						if (this.28[i].27)
						{
							this.28[i].Dispose();
						}
					}
					this.28.RemoveRange(num, 1.Count);
					return;
				}
			}
		}
		int count = 1.Count;
		object obj = 1436.2;
		lock (obj)
		{
			for (int j = 0; j < count; j++)
			{
				this.Remove(1[j]);
			}
		}
	}

	// Token: 0x06004CD9 RID: 19673 RVA: 0x001E7154 File Offset: 0x001E5354
	internal bool 21(bool 1, bool 2)
	{
		if (!this.22)
		{
			return false;
		}
		if (1 != this.47)
		{
			return false;
		}
		if (this.5 < 0.01f || this.6)
		{
			return false;
		}
		1433 3 = this.23;
		this.10();
		List<1371> obj = this.28;
		lock (obj)
		{
			for (int i = 0; i < this.28.Count; i++)
			{
				1371 4 = this.28[i];
				if (!4.8())
				{
					if (!2)
					{
						this.24<1371>(4);
					}
					else
					{
						4.SetHovered(false);
					}
				}
			}
		}
		if (this.23 != null)
		{
			this.23.SetHovered(true);
		}
		if (3 != null && 3 != this.23)
		{
			3.SetHovered(false);
		}
		return this.23 != null;
	}

	// Token: 0x06004CDA RID: 19674 RVA: 0x001E723C File Offset: 0x001E543C
	internal bool 22()
	{
		object obj = 1436.2;
		lock (obj)
		{
			if (this.10)
			{
				this.23();
			}
			int num = this.28.Count;
			this.43 = 0;
			if (this.15)
			{
				this.35 = new 1058((float)Math.Floor((double)((float)(this.25 ? 1662.70.4() : 0) + this.34.X * 1662.70.3())), (float)Math.Floor((double)(this.34.Y * 1662.70.3())), (float)Math.Ceiling((double)(this.34.Width * 1662.70.3())), (float)Math.Ceiling((double)(this.34.Height * 1662.70.3())));
			}
			else if (this.25)
			{
				this.35 = new 1058((float)1662.70.4() + 1436.32.X * 1662.70.3(), 1436.32.Y * 1662.70.3(), 1436.32.Width * 1662.70.3(), 1436.32.Height * 1662.70.3());
			}
			else
			{
				this.35 = new 1058(1436.31.X * 1662.70.3(), 1436.31.Y * 1662.70.3(), 1436.31.Width * 1662.70.3(), 1436.31.Height * 1662.70.3());
			}
			this.36 = new 207((int)this.35.X, (int)this.35.Y, (int)Math.Ceiling((double)this.35.Width), (int)Math.Ceiling((double)this.35.Height));
			if (num == 0 && !this.16)
			{
				return false;
			}
			if ((this.5 < 0.01f && (!this.27 || !2528.AnyShownWithoutInterface)) || this.6)
			{
				for (int i = 0; i < num; i++)
				{
					this.28[i].19 = false;
				}
				return false;
			}
			this.12 = 1662.115;
			if (this.38 >= 0f)
			{
				if (this.38 > this.7)
				{
					this.7 = Math.Min(this.38, this.7 + 0.018f * (float)1662.10);
				}
				else if (this.38 < this.7)
				{
					this.7 = Math.Max(this.38, this.7 - 0.018f * (float)1662.10);
				}
			}
			int num2 = 1662.33;
			int num3 = 1226.16;
			if (this.16)
			{
				while (this.21.Count > 0)
				{
					1371 <<EMPTY_NAME>> = this.21.Peek();
					if (<<EMPTY_NAME>>.3.Count > 0 && <<EMPTY_NAME>>.3[0].9 > ((<<EMPTY_NAME>>.1 == (1044)0) ? num2 : num3))
					{
						break;
					}
					if (<<EMPTY_NAME>>.3.Count == 0)
					{
						this.21.Dequeue().Dispose();
					}
					else
					{
						this.12(this.21.Dequeue());
						num++;
					}
				}
			}
			this.39(false);
			try
			{
				207 2 = this.24 ? this.36 : 1379.30();
				1379.27(new Rectangle?(new Rectangle(1379.28.Left + 2.GetLeft(), 1379.28.Top + 1662.70.2 - 2.GetBottom(), 2.Width, 2.Height)));
				if (this.35() != null)
				{
					this.35().Reset();
				}
				for (int j = 0; j < num; j++)
				{
					1371 3 = this.28[j];
					if (!3.8())
					{
						1069 4 = 3.Update();
						if (4 != (1069)0)
						{
							if (4 == (1069)2)
							{
								this.28.RemoveAt(j--);
								num--;
								if (this.16 && 3.1 != (1044)0 && this.44)
								{
									this.20.Push(3);
								}
								else
								{
									3.Dispose();
								}
							}
						}
						else
						{
							if (!3.CanBatch())
							{
								this.40(false);
							}
							if (2 != 3.4())
							{
								this.35().6();
								2 = 3.4();
								1379.27(new Rectangle?(new Rectangle(1379.28.Left + 2.GetLeft(), 1379.28.Top + 1662.70.2 - 2.GetBottom(), 2.Width, 2.Height)));
							}
							3.Draw();
						}
					}
				}
				if (this.46)
				{
					this.36(false);
				}
				this.40(true);
				1379.27(null);
				this.18 = 0;
			}
			catch (Exception ex)
			{
				try
				{
					this.40(true);
				}
				catch
				{
				}
				if (ex is InvalidOperationException)
				{
					int num4 = this.18 + 1;
					this.18 = num4;
					if (num4 <= 1)
					{
						return true;
					}
				}
				throw;
			}
		}
		return true;
	}

	// Token: 0x06004CDB RID: 19675 RVA: 0x001E780C File Offset: 0x001E5A0C
	internal void 23()
	{
		1436.1437 <<EMPTY_NAME>> = new 1436.1437();
		<<EMPTY_NAME>>.1 = this;
		if (this.10)
		{
			if (1662.33 != this.9)
			{
				<<EMPTY_NAME>>.2 = 1662.33 - this.9;
				this.28.FindAll(new Predicate<1371>(1436.1440.spriteLayerCallbacks.2)).ForEach(new Action<1371>(<<EMPTY_NAME>>.1));
			}
			this.10 = false;
		}
	}

	// Token: 0x06004CDC RID: 19676 RVA: 0x001E7880 File Offset: 0x001E5A80
	internal void 24<T>(T 1) where T : 1371
	{
		if (1 != null && 1.19 && !1.8())
		{
			1433 2 = 1 as 1433;
			if (2 != null)
			{
				if (2.10)
				{
					if (1555.1() && (this.23 == null || 2.45 < this.23.45) && 2.ContainsPoint(1555.21(), 0) && (!this.24 || this.35.9(1555.17())))
					{
						if (this.23 != null)
						{
							this.23.SetHovered(false);
						}
						this.23 = 2;
						return;
					}
					if (2.IsHovered())
					{
						2.SetHovered(false);
						return;
					}
				}
				else if (2.IsHovered())
				{
					2.SetHovered(false);
				}
				return;
			}
		}
	}

	// Token: 0x06004CDD RID: 19677 RVA: 0x001D9407 File Offset: 0x001D7607
	internal static int 25(1433 1)
	{
		if (1.1 != (1044)0)
		{
			return 1226.16;
		}
		return 1662.33;
	}

	// Token: 0x06004CDE RID: 19678 RVA: 0x001E794C File Offset: 0x001E5B4C
	internal void 26(List<1371> 1)
	{
		if (1 == null || 1.Count == 0)
		{
			return;
		}
		List<1371> list = new List<1371>(1);
		list.RemoveAll(new Predicate<1371>(1436.1440.spriteLayerCallbacks.3));
		if (this.28.Count == 0)
		{
			this.28.AddRange(list);
			return;
		}
		int num = this.28.BinarySearch(list[list.Count - 1], this.4);
		if (num < 0)
		{
			num = ~num;
		}
		List<1371> range = this.28.GetRange(num, this.28.Count - num);
		this.28.RemoveRange(num, this.28.Count - num);
		this.28.AddRange(list);
		this.28.AddRange(range);
	}

	// Token: 0x06004CDF RID: 19679 RVA: 0x001E7A0F File Offset: 0x001E5C0F
	internal void 27(1058 1)
	{
		this.15 = true;
		this.24 = true;
		this.34 = 1;
	}

	// Token: 0x06004CE0 RID: 19680 RVA: 0x001E7A26 File Offset: 0x001E5C26
	internal static void 28()
	{
		1436.48 = (1436.48 + 1) % 1436.33();
	}

	// Token: 0x06004CE1 RID: 19681 RVA: 0x001E7A3A File Offset: 0x001E5C3A
	internal void 29()
	{
		1662.89.Schedule(new 1189(this.46), true);
	}

	// Token: 0x06004CE2 RID: 19682 RVA: 0x001E7A54 File Offset: 0x001E5C54
	internal static float 30(float 1)
	{
		return 1 % 1999999f / 10000000f;
	}

	// Token: 0x06004CE3 RID: 19683 RVA: 0x001E7A63 File Offset: 0x001E5C63
	internal static float 31(float 1)
	{
		return 0.8f + 1 % 6000000f / 30000000f;
	}

	// Token: 0x06004CE4 RID: 19684 RVA: 0x001E7A78 File Offset: 0x001E5C78
	internal static float 32(float 1)
	{
		return 0.8f - 1 % 6000000f / 10000000f;
	}

	// Token: 0x06004CE5 RID: 19685 RVA: 0x001E7A8D File Offset: 0x001E5C8D
	private static int 33()
	{
		if (!1304.226)
		{
			return 3;
		}
		return 1;
	}

	// Token: 0x06004CE6 RID: 19686 RVA: 0x001E7AA0 File Offset: 0x001E5CA0
	internal 1508<1394>[] 34()
	{
		if (this.49 == null || this.49.Length != 1436.33())
		{
			int num = 0;
			for (;;)
			{
				int num2 = num;
				1508<1394>[] array = this.49;
				if (num2 >= ((array != null) ? array.Length : 0))
				{
					break;
				}
				1508<1394> <<EMPTY_NAME>> = this.49[num];
				if (<<EMPTY_NAME>> != null)
				{
					<<EMPTY_NAME>>.3();
				}
				num++;
			}
			this.49 = new 1508<1394>[1436.33()];
		}
		return this.49;
	}

	// Token: 0x06004CE7 RID: 19687 RVA: 0x001E7B08 File Offset: 0x001E5D08
	internal 1508<1394> 35()
	{
		return this.34()[1436.48];
	}

	// Token: 0x06004CE8 RID: 19688 RVA: 0x001E7B18 File Offset: 0x001E5D18
	internal void 36(bool 1)
	{
		1064 2 = (!1) ? ((1064)1) : ((1064)2);
		if (this.45 != 2 || !this.46)
		{
			this.45 = 2;
			this.39(true);
		}
	}

	// Token: 0x06004CE9 RID: 19689 RVA: 0x001E7B4C File Offset: 0x001E5D4C
	internal void 37()
	{
		this.39(true);
	}

	// Token: 0x06004CEA RID: 19690 RVA: 0x001E7B55 File Offset: 0x001E5D55
	internal void 38()
	{
		this.40(true);
	}

	// Token: 0x06004CEB RID: 19691 RVA: 0x001E7B60 File Offset: 0x001E5D60
	private void 39(bool 1)
	{
		if (this.46 && !1)
		{
			return;
		}
		this.40(false);
		int num = 1052.18(this.28.Count, 1, 100);
		if (this.35() == null || this.35().1() < num)
		{
			for (int i = 0; i < this.34().Length; i++)
			{
				this.34()[i] = new 1375<1394>(num * 2, 500);
			}
		}
		if (this.45 == (1064)2)
		{
			1379.35(770, 1);
		}
		else
		{
			1379.35(770, 771);
		}
		this.46 = true;
		1436.40 = this;
		1450.7 = this.13;
	}

	// Token: 0x06004CEC RID: 19692 RVA: 0x001E7C0F File Offset: 0x001E5E0F
	private void 40(bool 1)
	{
		if (1)
		{
			1436.40 = null;
		}
		if (this.46)
		{
			this.35().6();
			this.46 = false;
			1450.7 = 1f;
		}
	}

	// Token: 0x06004CED RID: 19693 RVA: 0x001E7C40 File Offset: 0x001E5E40
	internal static 1436 41()
	{
		1436 <<EMPTY_NAME>> = null;
		List<1436> obj = 1436.3;
		1436 result;
		lock (obj)
		{
			for (int i = 1436.3.Count - 1; i >= 0; i--)
			{
				1436 2 = 1436.3[i];
				if (2.21(true, <<EMPTY_NAME>> != null))
				{
					<<EMPTY_NAME>> = 2;
				}
			}
			for (int j = 1436.3.Count - 1; j >= 0; j--)
			{
				1436 3 = 1436.3[j];
				if (3.21(false, <<EMPTY_NAME>> != null))
				{
					<<EMPTY_NAME>> = 3;
				}
			}
			result = <<EMPTY_NAME>>;
		}
		return result;
	}

	// Token: 0x06004CEE RID: 19694 RVA: 0x001E7CF0 File Offset: 0x001E5EF0
	internal static void 42()
	{
		List<1436> obj = 1436.3;
		lock (obj)
		{
			1436.3.ForEach(new Action<1436>(1436.1440.spriteLayerCallbacks.4));
		}
		1436.50 = false;
	}

	// Token: 0x06004CEF RID: 19695 RVA: 0x001E7D4C File Offset: 0x001E5F4C
	internal static void 43(bool 1)
	{
		if (!1 || !1436.50)
		{
			1436.50 = true;
			1436 2 = 1436.41();
			if (2 == null)
			{
				return;
			}
			2.44(1);
		}
	}

	// Token: 0x06004CF0 RID: 19696 RVA: 0x001E7D70 File Offset: 0x001E5F70
	private void 44(bool 1)
	{
		if (this.5 == 0f || this.12 < 1662.115 - 1L)
		{
			this.51 = true;
			return;
		}
		1433 2 = this.23;
		this.10();
		int count = this.28.Count;
		if (1 && this.51)
		{
			return;
		}
		for (int i = 0; i < count; i++)
		{
			this.24<1371>(this.28[i]);
		}
		this.51 = true;
		if (2 != null && 2 != this.23)
		{
			2.SetHovered(false);
		}
		if (this.23 != null && this.22 && 1436.1 == null && this.23.10 && this.23.19 && 1555.6() != 199.Pressed)
		{
			if (this.23.1(false))
			{
				1535.70 = true;
			}
			1436.1 = this.23;
		}
	}

	// Token: 0x06004CF1 RID: 19697 RVA: 0x001E7E57 File Offset: 0x001E6057
	private void 45()
	{
		this.9(false);
	}

	// Token: 0x06004CF2 RID: 19698 RVA: 0x001E7E60 File Offset: 0x001E6060
	private void 46()
	{
		1436.1 = null;
		this.51 = false;
		1436.50 = false;
	}

	// Token: 0x04003928 RID: 14632
	internal static 1433 1;

	// Token: 0x04003929 RID: 14633
	internal static readonly object 2 = new object();

	// Token: 0x0400392A RID: 14634
	internal static List<1436> 3 = new List<1436>();

	// Token: 0x0400392B RID: 14635
	private readonly 1370 4 = new 1370();

	// Token: 0x0400392C RID: 14636
	internal float 5 = 1f;

	// Token: 0x0400392D RID: 14637
	internal bool 6;

	// Token: 0x0400392E RID: 14638
	internal float 7;

	// Token: 0x0400392F RID: 14639
	internal float 8;

	// Token: 0x04003930 RID: 14640
	internal int 9 = 1662.33;

	// Token: 0x04003931 RID: 14641
	internal bool 10 = true;

	// Token: 0x04003932 RID: 14642
	internal bool 11;

	// Token: 0x04003933 RID: 14643
	internal long 12;

	// Token: 0x04003934 RID: 14644
	public float 13 = 1f;

	// Token: 0x04003935 RID: 14645
	internal float 14;

	// Token: 0x04003936 RID: 14646
	private bool 15;

	// Token: 0x04003937 RID: 14647
	internal bool 16;

	// Token: 0x04003938 RID: 14648
	private bool 17;

	// Token: 0x04003939 RID: 14649
	private int 18;

	// Token: 0x0400393A RID: 14650
	private readonly List<1371> 19 = new List<1371>();

	// Token: 0x0400393B RID: 14651
	private readonly Stack<1371> 20 = new Stack<1371>();

	// Token: 0x0400393C RID: 14652
	private readonly Queue<1371> 21 = new Queue<1371>();

	// Token: 0x0400393D RID: 14653
	internal bool 22 = true;

	// Token: 0x0400393E RID: 14654
	internal 1433 23;

	// Token: 0x0400393F RID: 14655
	internal bool 24;

	// Token: 0x04003940 RID: 14656
	internal bool 25 = true;

	// Token: 0x04003941 RID: 14657
	internal 2528 26;

	// Token: 0x04003942 RID: 14658
	internal bool 27;

	// Token: 0x04003943 RID: 14659
	internal readonly List<1371> 28 = new List<1371>();

	// Token: 0x04003944 RID: 14660
	internal 208 29 = 208.Zero;

	// Token: 0x04003945 RID: 14661
	internal 208 30 = 208.Zero;

	// Token: 0x04003946 RID: 14662
	internal static 1058 31 = new 1058(0f, 0f, 640f, 480f);

	// Token: 0x04003947 RID: 14663
	internal static 1058 32 = new 1058(0f, 0f, 640f, 480f);

	// Token: 0x04003948 RID: 14664
	internal 208 33 = 208.Zero;

	// Token: 0x04003949 RID: 14665
	internal 1058 34 = new 1058(0f, 0f, 640f, 480f);

	// Token: 0x0400394A RID: 14666
	internal 1058 35;

	// Token: 0x0400394B RID: 14667
	internal 207 36;

	// Token: 0x0400394C RID: 14668
	internal bool 37;

	// Token: 0x0400394D RID: 14669
	internal float 38 = -1f;

	// Token: 0x0400394E RID: 14670
	internal static int 39;

	// Token: 0x0400394F RID: 14671
	internal static 1436 40;

	// Token: 0x04003950 RID: 14672
	private bool 41;

	// Token: 0x04003951 RID: 14673
	public bool 42;

	// Token: 0x04003952 RID: 14674
	internal int 43;

	// Token: 0x04003953 RID: 14675
	internal bool 44;

	// Token: 0x04003954 RID: 14676
	private 1064 45;

	// Token: 0x04003955 RID: 14677
	private bool 46;

	// Token: 0x04003956 RID: 14678
	internal bool 47;

	// Token: 0x04003957 RID: 14679
	private static int 48;

	// Token: 0x04003958 RID: 14680
	private 1508<1394>[] 49;

	// Token: 0x04003959 RID: 14681
	private static bool 50;

	// Token: 0x0400395A RID: 14682
	private bool 51;

	// Token: 0x02000ACC RID: 2764
	public sealed class 1438
	{
		// Token: 0x0400395B RID: 14683
		public object 1;
	}

	// Token: 0x02000ACD RID: 2765
	[Serializable]
	public sealed class 1440
	{
		// Token: 0x06004CF5 RID: 19701 RVA: 0x001E7ED5 File Offset: 0x001E60D5
		internal void 1(1371 1)
		{
			1.Dispose();
		}

		// Token: 0x06004CF6 RID: 19702 RVA: 0x001E7EDD File Offset: 0x001E60DD
		internal bool 2(1371 1)
		{
			return 1.1 == (1044)0;
		}

		// Token: 0x06004CF7 RID: 19703 RVA: 0x001E2532 File Offset: 0x001E0732
		internal bool 3(1371 1)
		{
			return 1 == null;
		}

		// Token: 0x06004CF8 RID: 19704 RVA: 0x001E7EE8 File Offset: 0x001E60E8
		internal void 4(1436 1)
		{
			1.29();
		}

		// Token: 0x0400395C RID: 14684
		public static readonly 1436.1440 spriteLayerCallbacks = new 1436.1440();

		// Token: 0x0400395D RID: 14685
		public static Action<1371> action;

		// Token: 0x0400395E RID: 14686
		public static Predicate<1371> predicate;

		// Token: 0x0400395F RID: 14687
		public static Predicate<1371> predicate2;

		// Token: 0x04003960 RID: 14688
		public static Action<1436> action2;
	}

	// Token: 0x02000ACE RID: 2766
	public sealed class 1439
	{
		// Token: 0x04003961 RID: 14689
		public object 1;
	}

	// Token: 0x02000ACF RID: 2767
	public sealed class 1437
	{
		// Token: 0x06004CFC RID: 19708 RVA: 0x001E7EFC File Offset: 0x001E60FC
		internal void 1(1371 1)
		{
			1.3.ForEach(new Action<1445>(this.2));
		}

		// Token: 0x06004CFD RID: 19709 RVA: 0x001E7F18 File Offset: 0x001E6118
		internal void 2(1445 1)
		{
			if (1.9 - this.1.9 <= 5000)
			{
				1.9 += this.2;
				1.10 += this.2;
			}
		}

		// Token: 0x04003962 RID: 14690
		public 1436 1;

		// Token: 0x04003963 RID: 14691
		public int 2;

		// Token: 0x04003964 RID: 14692
		public Action<1445> 3;
	}
}
