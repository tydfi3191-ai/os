using System;
using System.Collections;
using System.Collections.Generic;

// Token: 0x020005DA RID: 1498
public abstract class 2448
{
	// Token: 0x06002E26 RID: 11814 RVA: 0x00106400 File Offset: 0x00104600
	internal 2448(2453 1, 2450 2 = (2450)0)
	{
		if (1 == null)
		{
			throw new ArgumentNullException();
		}
		this.6(false);
		this.3 = 1;
		this.4 = 1.1;
		this.4(2);
		this.CreateLists();
	}

	// Token: 0x06002E27 RID: 11815 RVA: 0x0010644E File Offset: 0x0010464E
	public 2451 1()
	{
		return this.1;
	}

	// Token: 0x06002E28 RID: 11816 RVA: 0x00106458 File Offset: 0x00104658
	protected void 2(2451 1)
	{
		if (1 != (2451)8)
		{
			if (1 != (2451)9)
			{
				this.7 = this.8;
			}
			else
			{
				this.7 = this.10;
			}
		}
		else
		{
			this.7 = this.9;
		}
		this.6 = this.7;
		this.1 = 1;
	}

	// Token: 0x06002E29 RID: 11817 RVA: 0x001064AB File Offset: 0x001046AB
	public 2450 3()
	{
		return this.2;
	}

	// Token: 0x06002E2A RID: 11818 RVA: 0x001064B3 File Offset: 0x001046B3
	protected void 4(2450 1)
	{
		this.2 = 1;
	}

	// Token: 0x06002E2B RID: 11819 RVA: 0x001064BC File Offset: 0x001046BC
	public bool 5()
	{
		return this.5;
	}

	// Token: 0x06002E2C RID: 11820 RVA: 0x001064C4 File Offset: 0x001046C4
	protected void 6(bool 1)
	{
		this.5 = 1;
	}

	// Token: 0x06002E2D RID: 11821 RVA: 0x0001702D File Offset: 0x0001522D
	protected virtual bool UsesObjectLists()
	{
		return true;
	}

	// Token: 0x06002E2E RID: 11822 RVA: 0x001064CD File Offset: 0x001046CD
	protected bool 7()
	{
		return this.UsesObjectLists() && (this.6 == null || this.6.Count == this.12);
	}

	// Token: 0x06002E2F RID: 11823 RVA: 0x001064F6 File Offset: 0x001046F6
	protected int 8()
	{
		if (!this.UsesObjectLists() || this.6 == null)
		{
			return -1;
		}
		return this.6.Count - this.12;
	}

	// Token: 0x06002E30 RID: 11824 RVA: 0x0010651C File Offset: 0x0010471C
	protected bool 9()
	{
		return this.12 > 0 && this.12 <= this.6.Count;
	}

	// Token: 0x06002E31 RID: 11825 RVA: 0x0010653F File Offset: 0x0010473F
	protected bool 10()
	{
		return !this.UsesObjectLists() || (this.9() && this.6 == this.7);
	}

	// Token: 0x06002E32 RID: 11826 RVA: 0x0000FF75 File Offset: 0x0000E175
	protected virtual bool SelectsListByFlags()
	{
		return false;
	}

	// Token: 0x06002E33 RID: 11827
	internal abstract bool CaptureBackup();

	// Token: 0x06002E34 RID: 11828
	internal abstract bool HasChanged();

	// Token: 0x06002E35 RID: 11829
	internal abstract void Apply(2457 1);

	// Token: 0x06002E36 RID: 11830 RVA: 0x00106563 File Offset: 0x00104763
	internal virtual void CreateLists()
	{
		this.8 = new List<object>();
		this.9 = new List<object>();
		this.10 = new List<object>();
	}

	// Token: 0x06002E37 RID: 11831 RVA: 0x00106586 File Offset: 0x00104786
	internal virtual void RecordObjects<T>(List<T> 1, 2450 2)
	{
		this.14(2);
		this.AddObjects<T>(1);
		this.11(true);
	}

	// Token: 0x06002E38 RID: 11832 RVA: 0x0010659D File Offset: 0x0010479D
	internal virtual void RecordObjects(object 1, 2450 2)
	{
		this.14(2);
		this.AddObject(1);
		this.11(true);
	}

	// Token: 0x06002E39 RID: 11833 RVA: 0x001065B4 File Offset: 0x001047B4
	internal virtual void ReplaceObjects<T>(List<T> 1, 2450 2)
	{
		this.14(2);
		this.ReplaceTargetObjects<T>(1);
		this.11(true);
	}

	// Token: 0x06002E3A RID: 11834 RVA: 0x001065CB File Offset: 0x001047CB
	internal virtual void ReplaceObjects(object 1, 2450 2)
	{
		this.14(2);
		this.ReplaceTargetObjects(1);
		this.11(true);
	}

	// Token: 0x06002E3B RID: 11835 RVA: 0x001065E2 File Offset: 0x001047E2
	internal virtual void MarkComplete()
	{
		this.12 = this.6.Count;
		this.11(false);
	}

	// Token: 0x06002E3C RID: 11836 RVA: 0x001065FC File Offset: 0x001047FC
	protected void 11(bool 1)
	{
		if (this.10())
		{
			this.6(true);
			this.CaptureBackup();
		}
		this.12 = 0;
		if (1)
		{
			this.6 = this.7;
		}
	}

	// Token: 0x06002E3D RID: 11837 RVA: 0x0010662C File Offset: 0x0010482C
	internal virtual void Release()
	{
		this.6(false);
		if (this.UsesObjectLists())
		{
			this.11.Add(this.9);
			this.11.Add(this.10);
			this.11.Add(this.8);
		}
		177.ClearLists(this.11);
		this.11.Clear();
	}

	// Token: 0x06002E3E RID: 11838 RVA: 0x00106694 File Offset: 0x00104894
	protected virtual void AddObject(object 1)
	{
		if (this.6.Contains(1))
		{
			return;
		}
		if (this.1() != (2451)8)
		{
			2448 2 = this.3.13((2451)8);
			if (2 != null)
			{
				if (this.1() == (2451)9)
				{
					if (2.6.Remove(1))
					{
						return;
					}
				}
				else if (2.12(1))
				{
					return;
				}
			}
		}
		this.12++;
		this.6.Add(1);
	}

	// Token: 0x06002E3F RID: 11839 RVA: 0x00106708 File Offset: 0x00104908
	protected virtual void AddObjects<T>(List<T> 1)
	{
		if (1 == null)
		{
			return;
		}
		this.12 = 0;
		foreach (T t in 1)
		{
			this.AddObject(t);
		}
	}

	// Token: 0x06002E40 RID: 11840 RVA: 0x00106768 File Offset: 0x00104968
	protected virtual void ReplaceTargetObjects(object 1)
	{
		this.6.Clear();
		this.AddObject(1);
	}

	// Token: 0x06002E41 RID: 11841 RVA: 0x0010677C File Offset: 0x0010497C
	protected virtual void ReplaceTargetObjects<T>(List<T> 1)
	{
		this.6.Clear();
		this.AddObjects<T>(1);
	}

	// Token: 0x06002E42 RID: 11842 RVA: 0x00106790 File Offset: 0x00104990
	internal bool 12(object 1)
	{
		return this.UsesObjectLists() && this.6 != null && this.6.Contains(1);
	}

	// Token: 0x06002E43 RID: 11843 RVA: 0x001067B0 File Offset: 0x001049B0
	internal bool 13(2450 1)
	{
		if (1 == (2450)0)
		{
			return this.3() == (2450)0;
		}
		return (this.3() & 1) > (2450)0;
	}

	// Token: 0x06002E44 RID: 11844 RVA: 0x001067CA File Offset: 0x001049CA
	internal void Undo()
	{
		this.Apply((2457)1);
	}

	// Token: 0x06002E45 RID: 11845 RVA: 0x001067D3 File Offset: 0x001049D3
	internal void Redo()
	{
		this.Apply((2457)2);
	}

	// Token: 0x06002E46 RID: 11846 RVA: 0x001067DC File Offset: 0x001049DC
	private void 14(2450 1)
	{
		if (this.SelectsListByFlags())
		{
			if ((1 & (2450)32768) > (2450)0)
			{
				this.6 = this.9;
			}
			else if ((1 & (2450)65536) > (2450)0)
			{
				this.6 = this.10;
			}
			else
			{
				this.6 = this.7;
			}
			this.12 = 0;
		}
	}

	// Token: 0x040021D0 RID: 8656
	private 2451 1;

	// Token: 0x040021D1 RID: 8657
	private 2450 2;

	// Token: 0x040021D2 RID: 8658
	protected 2453 3;

	// Token: 0x040021D3 RID: 8659
	protected 2458 4;

	// Token: 0x040021D4 RID: 8660
	private bool 5;

	// Token: 0x040021D5 RID: 8661
	private List<object> 6;

	// Token: 0x040021D6 RID: 8662
	protected List<object> 7;

	// Token: 0x040021D7 RID: 8663
	protected List<object> 8;

	// Token: 0x040021D8 RID: 8664
	protected List<object> 9;

	// Token: 0x040021D9 RID: 8665
	protected List<object> 10;

	// Token: 0x040021DA RID: 8666
	protected List<IList> 11 = new List<IList>();

	// Token: 0x040021DB RID: 8667
	protected int 12;

	// Token: 0x020005DB RID: 1499
	public sealed class 2449 : Exception
	{
		// Token: 0x06002E47 RID: 11847 RVA: 0x0001272B File Offset: 0x0001092B
		internal 2449(string 1 = "Not enough objects to initiate backup data") : base(1)
		{
		}
	}
}
