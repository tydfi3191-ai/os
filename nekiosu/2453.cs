using System;
using System.Collections.Generic;

// Token: 0x020005DF RID: 1503
public abstract class 2453
{
	// Token: 0x06002E48 RID: 11848 RVA: 0x00106834 File Offset: 0x00104A34
	private 2448 1()
	{
		if (this.2 != null && this.2.Count > 0)
		{
			return this.2[this.2.Count - 1];
		}
		return null;
	}

	// Token: 0x06002E49 RID: 11849 RVA: 0x00106866 File Offset: 0x00104A66
	internal 2451 2()
	{
		if (this.1() != null)
		{
			return this.1().1();
		}
		return (2451)36;
	}

	// Token: 0x06002E4A RID: 11850 RVA: 0x0010687E File Offset: 0x00104A7E
	public 2452 3()
	{
		return this.3;
	}

	// Token: 0x06002E4B RID: 11851 RVA: 0x00106886 File Offset: 0x00104A86
	protected void 4(2452 1)
	{
		this.3 = 1;
	}

	// Token: 0x06002E4C RID: 11852 RVA: 0x0010688F File Offset: 0x00104A8F
	internal bool 5()
	{
		return this.4;
	}

	// Token: 0x06002E4D RID: 11853 RVA: 0x00106897 File Offset: 0x00104A97
	internal void 6(bool 1)
	{
		this.4 = 1;
		this.5 = false;
		if (!this.4)
		{
			this.10.Clear();
		}
	}

	// Token: 0x06002E4E RID: 11854 RVA: 0x001068BC File Offset: 0x00104ABC
	internal static 2453 Create(2452 1, 2458 2)
	{
		2453 result;
		switch (1)
		{
		case (2452)0:
			result = new 2440(2);
			break;
		case (2452)1:
			result = new 2447(2);
			break;
		case (2452)2:
			result = new 2445(2);
			break;
		case (2452)3:
			result = new 2439(2);
			break;
		case (2452)4:
			result = new 2444(2);
			break;
		default:
			result = null;
			break;
		}
		return result;
	}

	// Token: 0x06002E4F RID: 11855
	internal abstract 2448 CreateAction(2451 1, 2450 2);

	// Token: 0x06002E50 RID: 11856 RVA: 0x00106918 File Offset: 0x00104B18
	protected void 7(2452 1, 2458 2)
	{
		this.4(1);
		this.1 = 2;
		this.2 = new List<2448>();
		this.7 = new List<2451>();
		this.8 = new List<2451>();
		this.9 = new List<2451>();
		this.10 = new List<2451>();
		this.11 = new Stack<2453.2455>();
		this.12 = new Stack<2453.2455>();
		this.6(false);
	}

	// Token: 0x06002E51 RID: 11857 RVA: 0x00106987 File Offset: 0x00104B87
	internal void 8(2451 1)
	{
		if (this.18(1))
		{
			this.currentAction = this.13(1);
		}
	}

	// Token: 0x06002E52 RID: 11858 RVA: 0x001069A0 File Offset: 0x00104BA0
	internal virtual void BeginAction(2451 1, 2450 2)
	{
		try
		{
			this.10(1);
			if (this.currentAction == null)
			{
				this.9(this.CreateAction(1, 2));
			}
			if (this.5() && !this.10.Contains(1))
			{
				if (this.5)
				{
					this.6(false);
				}
				else
				{
					this.10.Add(1);
				}
			}
		}
		catch (Exception ex)
		{
			1763.5("An error has occurred while setting state delegates.", 198.YellowGreen, 1000, null);
			1619.1(new 1618(ex)
			{
				1 = "undo states"
			});
		}
	}

	// Token: 0x06002E53 RID: 11859 RVA: 0x00106A3C File Offset: 0x00104C3C
	private void 9(2448 1)
	{
		if (1 != null && 1.1() != (2451)36)
		{
			this.7.Add(1.1());
			this.9.Add(1.1());
			this.2.Add(1);
			this.11.Push(new 2453.2455(new 2453.2456(1.Apply)));
			this.12.Clear();
			this.currentAction = 1;
		}
	}

	// Token: 0x06002E54 RID: 11860 RVA: 0x00106AB4 File Offset: 0x00104CB4
	private void 10(2451 1)
	{
		if (this.18(1))
		{
			if (this.currentAction == null || this.currentAction.1() != 1)
			{
				this.currentAction = this.13(1);
			}
			if (this.currentAction == null)
			{
				throw new NullReferenceException("Action reference missing");
			}
		}
		else
		{
			this.currentAction = null;
		}
	}

	// Token: 0x06002E55 RID: 11861 RVA: 0x00106B08 File Offset: 0x00104D08
	internal virtual void RecordObjects<T>(List<T> 1, 2450 2)
	{
		if (this.5())
		{
			foreach (2451 3 in this.10)
			{
				this.8(3);
				this.currentAction.RecordObjects<T>(1, 2);
				if (this.currentAction.5())
				{
					this.9.Remove(this.currentAction.1());
				}
			}
			this.5 = true;
			return;
		}
		if (this.currentAction != null)
		{
			this.currentAction.RecordObjects<T>(1, 2);
			if (this.currentAction.5())
			{
				this.9.Remove(this.currentAction.1());
			}
		}
	}

	// Token: 0x06002E56 RID: 11862 RVA: 0x00106BD8 File Offset: 0x00104DD8
	internal virtual void RecordObjects(object 1, 2450 2)
	{
		if (this.5())
		{
			foreach (2451 3 in this.10)
			{
				this.8(3);
				this.currentAction.RecordObjects(1, 2);
				if (this.currentAction.5())
				{
					this.9.Remove(this.currentAction.1());
				}
			}
			this.5 = true;
			return;
		}
		if (this.currentAction != null)
		{
			this.currentAction.RecordObjects(1, 2);
			if (this.currentAction.5())
			{
				this.9.Remove(this.currentAction.1());
			}
		}
	}

	// Token: 0x06002E57 RID: 11863 RVA: 0x00106CA8 File Offset: 0x00104EA8
	internal void 11(object 1)
	{
		this.6(false);
		while (this.9.Count > 0)
		{
			this.currentAction = this.13(this.9[0]);
			this.RecordObjects(1, (2450)0);
			if (!this.currentAction.5())
			{
				this.9.Remove(this.currentAction.1());
			}
		}
	}

	// Token: 0x06002E58 RID: 11864 RVA: 0x00106D10 File Offset: 0x00104F10
	internal void 12<T>(List<T> 1)
	{
		this.6(false);
		while (this.9.Count > 0)
		{
			this.currentAction = this.13(this.9[0]);
			this.RecordObjects<T>(1, (2450)0);
			if (!this.currentAction.5())
			{
				this.9.Remove(this.currentAction.1());
			}
		}
	}

	// Token: 0x06002E59 RID: 11865 RVA: 0x00106D78 File Offset: 0x00104F78
	internal virtual void ReplaceObjects<T>(List<T> 1, 2450 2)
	{
		if (this.currentAction != null)
		{
			this.currentAction.ReplaceObjects<T>(1, 2);
			if (this.currentAction.5())
			{
				this.9.Remove(this.currentAction.1());
			}
		}
	}

	// Token: 0x06002E5A RID: 11866 RVA: 0x00106DB3 File Offset: 0x00104FB3
	internal virtual void ReplaceObjects(object 1, 2450 2)
	{
		if (this.currentAction != null)
		{
			this.currentAction.ReplaceObjects(1, 2);
			if (this.currentAction.5())
			{
				this.9.Remove(this.currentAction.1());
			}
		}
	}

	// Token: 0x06002E5B RID: 11867 RVA: 0x00106DEE File Offset: 0x00104FEE
	internal virtual void MarkCurrentComplete()
	{
		if (this.currentAction != null)
		{
			this.currentAction.MarkComplete();
			if (this.currentAction.5())
			{
				this.9.Remove(this.currentAction.1());
			}
		}
	}

	// Token: 0x06002E5C RID: 11868 RVA: 0x00106E28 File Offset: 0x00105028
	internal 2448 13(2451 1)
	{
		2453.2454 2 = new 2453.2454();
		2.1 = 1;
		return this.2.Find(new Predicate<2448>(2.1));
	}

	// Token: 0x06002E5D RID: 11869 RVA: 0x00106E59 File Offset: 0x00105059
	internal 2448 14(int 1)
	{
		if (1 >= 0 && 1 < this.2.Count)
		{
			return this.2[1];
		}
		return null;
	}

	// Token: 0x06002E5E RID: 11870 RVA: 0x00106E7B File Offset: 0x0010507B
	internal int 15(2451 1, bool 2)
	{
		if (2)
		{
			return this.8.IndexOf(1);
		}
		return this.7.IndexOf(1);
	}

	// Token: 0x06002E5F RID: 11871 RVA: 0x00106E99 File Offset: 0x00105099
	internal int 16(bool 1)
	{
		if (!1)
		{
			return this.12.Count;
		}
		return this.11.Count;
	}

	// Token: 0x06002E60 RID: 11872 RVA: 0x00106EB5 File Offset: 0x001050B5
	internal bool 17()
	{
		return this.11.Count > 0 || this.12.Count > 0;
	}

	// Token: 0x06002E61 RID: 11873 RVA: 0x00106ED5 File Offset: 0x001050D5
	internal bool 18(2451 1)
	{
		return this.7.Contains(1);
	}

	// Token: 0x06002E62 RID: 11874 RVA: 0x00106EE4 File Offset: 0x001050E4
	internal void 19()
	{
		if (this.currentAction == null)
		{
			return;
		}
		2448 <<EMPTY_NAME>> = this.currentAction;
		try
		{
			this.9.Remove(<<EMPTY_NAME>>.1());
			int num = this.15(<<EMPTY_NAME>>.1(), true);
			if (<<EMPTY_NAME>> == this.1())
			{
				int i = this.7.Count - 1;
				int count = this.7.Count;
				int count2 = this.11.Count;
				if (count == count2)
				{
					this.11.Pop();
				}
				else
				{
					this.12.Pop();
				}
				this.7.RemoveAt(i);
				if (num >= 0)
				{
					this.8.RemoveAt(num);
				}
			}
			else
			{
				int i = this.7.IndexOf(<<EMPTY_NAME>>.1());
				if (i < 0)
				{
					return;
				}
				this.7.RemoveAt(i);
				if (num >= 0)
				{
					this.8.RemoveAt(num);
				}
				int count3 = this.11.Count;
				Stack<2453.2455> stack = new Stack<2453.2455>();
				if (i < count3)
				{
					i++;
					while (this.11.Count > i)
					{
						stack.Push(this.11.Pop());
					}
					this.11.Pop();
					while (stack.Count > 0)
					{
						this.11.Push(stack.Pop());
					}
				}
				else
				{
					for (i -= count3; i > 0; i--)
					{
						stack.Push(this.12.Pop());
					}
					this.12.Pop();
					while (stack.Count > 0)
					{
						this.12.Push(stack.Pop());
					}
				}
			}
			<<EMPTY_NAME>>.Release();
		}
		catch (Exception ex)
		{
			1619.1(new 1618(ex)
			{
				1 = "undo states"
			});
		}
	}

	// Token: 0x06002E63 RID: 11875 RVA: 0x001070BC File Offset: 0x001052BC
	internal void 20()
	{
		int num = this.7.Count - 1;
		int num2 = 0;
		for (2448 <<EMPTY_NAME>> = this.1(); <<EMPTY_NAME>> != null; <<EMPTY_NAME>> = this.14(num))
		{
			if (this.9.Contains(<<EMPTY_NAME>>.1()) || !<<EMPTY_NAME>>.HasChanged())
			{
				num2++;
				this.currentAction = <<EMPTY_NAME>>;
				this.19();
			}
			num--;
		}
	}

	// Token: 0x06002E64 RID: 11876 RVA: 0x00107120 File Offset: 0x00105320
	internal void 21()
	{
		while (this.11.Count > 0)
		{
			2453.2455 <<EMPTY_NAME>> = this.11.Pop();
			<<EMPTY_NAME>>.Undo();
			this.12.Push(<<EMPTY_NAME>>);
		}
	}

	// Token: 0x06002E65 RID: 11877 RVA: 0x0010715C File Offset: 0x0010535C
	internal void 22()
	{
		while (this.12.Count > 0)
		{
			2453.2455 <<EMPTY_NAME>> = this.12.Pop();
			<<EMPTY_NAME>>.Redo();
			this.11.Push(<<EMPTY_NAME>>);
		}
	}

	// Token: 0x040021DF RID: 8671
	internal 2458 1;

	// Token: 0x040021E0 RID: 8672
	internal List<2448> 2;

	// Token: 0x040021E1 RID: 8673
	protected 2448 currentAction;

	// Token: 0x040021E2 RID: 8674
	private 2452 3;

	// Token: 0x040021E3 RID: 8675
	private bool 4;

	// Token: 0x040021E4 RID: 8676
	protected bool 5;

	// Token: 0x040021E5 RID: 8677
	internal bool 6 = true;

	// Token: 0x040021E6 RID: 8678
	internal List<2451> 7;

	// Token: 0x040021E7 RID: 8679
	internal List<2451> 8;

	// Token: 0x040021E8 RID: 8680
	internal List<2451> 9;

	// Token: 0x040021E9 RID: 8681
	internal List<2451> 10;

	// Token: 0x040021EA RID: 8682
	private Stack<2453.2455> 11;

	// Token: 0x040021EB RID: 8683
	private Stack<2453.2455> 12;

	// Token: 0x020005E0 RID: 1504
	// (Invoke) Token: 0x06002E68 RID: 11880
	public delegate void 2456(2457 1);

	// Token: 0x020005E1 RID: 1505
	public sealed class 2455
	{
		// Token: 0x06002E6B RID: 11883 RVA: 0x001071A6 File Offset: 0x001053A6
		internal 2455(2453.2456 1)
		{
			if (1 == null)
			{
				throw new ArgumentNullException("Error while setting action state");
			}
			this.2 = 1;
			this.1 = (2457)2;
		}

		// Token: 0x06002E6C RID: 11884 RVA: 0x001071CC File Offset: 0x001053CC
		internal void Undo()
		{
			if (this.1 == (2457)1)
			{
				throw new Exception("Redo must be called before Undo can be called");
			}
			this.1 = (2457)1;
			try
			{
				this.2(this.1);
			}
			catch (Exception ex)
			{
				1619.1(new 1618(ex)
				{
					1 = "undo states"
				});
			}
		}

		// Token: 0x06002E6D RID: 11885 RVA: 0x00107230 File Offset: 0x00105430
		internal void Redo()
		{
			if (this.1 == (2457)2)
			{
				throw new Exception("Undo must be called before Redo can be called");
			}
			this.1 = (2457)2;
			try
			{
				this.2(this.1);
			}
			catch (Exception ex)
			{
				1619.1(new 1618(ex)
				{
					1 = "undo states"
				});
			}
		}

		// Token: 0x040021EC RID: 8684
		private 2457 1;

		// Token: 0x040021ED RID: 8685
		private 2453.2456 2;
	}

	// Token: 0x020005E2 RID: 1506
	public sealed class 2454
	{
		// Token: 0x06002E6E RID: 11886 RVA: 0x00107294 File Offset: 0x00105494
		internal bool 1(2448 1)
		{
			return 1.1() == this.1;
		}

		// Token: 0x040021EE RID: 8686
		public 2451 1;
	}
}
