using System;
using System.Collections.Generic;
using System.Threading;

// Token: 0x020008B6 RID: 2230
public class 1779 : IComparable<1779>, IDisposable
{
	// Token: 0x06003FCB RID: 16331 RVA: 0x0018B28C File Offset: 0x0018948C
	public 1779()
	{
		this.3 = new 1433(1779.4, (1376)6, 1065.TopLeft, (1044)0, new 208(-5f, -5f))
		{
			15 = 1.6f,
			20 = new 208(2f, 0f),
			5 = true,
			28 = true,
			16 = 0f,
			6 = 198.White
		};
		this.3.10 = true;
		this.3.11 = true;
		this.3.3(new EventHandler(this.16));
		this.1.12(this.3);
		this.1();
	}

	// Token: 0x06003FCC RID: 16332 RVA: 0x0001702D File Offset: 0x0001522D
	internal virtual bool IsDefaultValue()
	{
		return true;
	}

	// Token: 0x06003FCD RID: 16333 RVA: 0x0018B37E File Offset: 0x0018957E
	protected void 1()
	{
		if (this.IsDefaultValue())
		{
			this.3.16(100, (1046)0, 0);
			return;
		}
		this.3.FadeIn(100, (1046)0, 0);
	}

	// Token: 0x06003FCE RID: 16334 RVA: 0x00005ADD File Offset: 0x00003CDD
	protected virtual void ResetToDefault()
	{
	}

	// Token: 0x06003FCF RID: 16335 RVA: 0x0018B3A7 File Offset: 0x001895A7
	internal 208 2()
	{
		return this.5;
	}

	// Token: 0x06003FD0 RID: 16336 RVA: 0x0018B3AF File Offset: 0x001895AF
	internal void 3(208 1)
	{
		if (!(1 == this.5))
		{
			float y = this.5.Y;
			this.5 = 1;
			if (y != this.5.Y)
			{
				this.7();
			}
		}
	}

	// Token: 0x06003FD1 RID: 16337 RVA: 0x0018B3E4 File Offset: 0x001895E4
	internal float 4()
	{
		return this.6;
	}

	// Token: 0x06003FD2 RID: 16338 RVA: 0x0018B3EC File Offset: 0x001895EC
	internal void 5(float 1)
	{
		if (1 != this.6)
		{
			this.6 = 1;
			this.7();
		}
	}

	// Token: 0x06003FD3 RID: 16339 RVA: 0x0018B404 File Offset: 0x00189604
	internal void 6(EventHandler 1)
	{
		EventHandler eventHandler = this.8;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, 1);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.8, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06003FD4 RID: 16340 RVA: 0x0018B43C File Offset: 0x0018963C
	protected void 7()
	{
		this.3.20.Y = this.2().Y + 10f;
		this.3.17.Y = -5f;
		if (this.8 != null)
		{
			this.8(this, null);
		}
	}

	// Token: 0x06003FD5 RID: 16341 RVA: 0x0018B494 File Offset: 0x00189694
	internal bool 8()
	{
		return this.9;
	}

	// Token: 0x06003FD6 RID: 16342 RVA: 0x0018B49C File Offset: 0x0018969C
	internal void 9(bool 1)
	{
		this.9 = 1;
		if (this.11 == null)
		{
			return;
		}
		foreach (1779 2 in this.11)
		{
			2.9(this.9);
		}
	}

	// Token: 0x06003FD7 RID: 16343 RVA: 0x0018B4FC File Offset: 0x001896FC
	internal virtual IEnumerable<1779> GetChildren()
	{
		return this.11;
	}

	// Token: 0x06003FD8 RID: 16344 RVA: 0x0018B504 File Offset: 0x00189704
	internal virtual void SetChildren(IEnumerable<1779> 1)
	{
		this.11 = 1;
		if (this.11 == null)
		{
			return;
		}
		foreach (1779 2 in this.11)
		{
			2.10 = this;
			if (this.8())
			{
				2.9(true);
			}
		}
	}

	// Token: 0x06003FD9 RID: 16345 RVA: 0x0018B570 File Offset: 0x00189770
	protected void 10(string 1)
	{
		this.7.Add(1.ToLower());
	}

	// Token: 0x06003FDA RID: 16346 RVA: 0x0018B584 File Offset: 0x00189784
	public bool 11(string 1)
	{
		if (1.Length == 0)
		{
			return true;
		}
		1 = 1.ToLower();
		using (List<string>.Enumerator enumerator = this.7.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.Contains(1))
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06003FDB RID: 16347 RVA: 0x0000FF75 File Offset: 0x0000E175
	private int 12(1779 1)
	{
		return 0;
	}

	// Token: 0x06003FDC RID: 16348 RVA: 0x0018B5F0 File Offset: 0x001897F0
	int IComparable<1779>.CompareTo(1779 1)
	{
		return this.12(1);
	}

	// Token: 0x06003FDD RID: 16349 RVA: 0x0018B5FC File Offset: 0x001897FC
	internal void Show(bool 1)
	{
		if (1 && this.GetChildren() != null)
		{
			foreach (1779 2 in this.GetChildren())
			{
				2.Show(false);
			}
		}
		this.1.6 = false;
		this.1();
	}

	// Token: 0x06003FDE RID: 16350 RVA: 0x0018B664 File Offset: 0x00189864
	internal void Hide()
	{
		this.1.6 = true;
	}

	// Token: 0x06003FDF RID: 16351 RVA: 0x0018B672 File Offset: 0x00189872
	internal 1371 13()
	{
		return this.1.28.Find(new Predicate<1371>(this.17));
	}

	// Token: 0x06003FE0 RID: 16352 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal virtual void OnLayoutUpdated()
	{
	}

	// Token: 0x06003FE1 RID: 16353 RVA: 0x0000FF75 File Offset: 0x0000E175
	internal virtual bool IsHeader()
	{
		return false;
	}

	// Token: 0x06003FE2 RID: 16354 RVA: 0x0018B690 File Offset: 0x00189890
	public IEnumerable<1779> 14()
	{
		List<1779> list = new List<1779>();
		if (this.GetChildren() != null)
		{
			foreach (1779 <<EMPTY_NAME>> in this.GetChildren())
			{
				list.Add(<<EMPTY_NAME>>);
				list.AddRange(<<EMPTY_NAME>>.14());
			}
		}
		return list;
	}

	// Token: 0x06003FE3 RID: 16355 RVA: 0x0018B6F8 File Offset: 0x001898F8
	public virtual void Dispose()
	{
		this.1.Dispose();
		foreach (1779 <<EMPTY_NAME>> in this.14())
		{
			<<EMPTY_NAME>>.Dispose();
		}
	}

	// Token: 0x06003FE4 RID: 16356 RVA: 0x0000FF75 File Offset: 0x0000E175
	internal virtual int GetSpacingBefore()
	{
		return 0;
	}

	// Token: 0x06003FE5 RID: 16357 RVA: 0x0018B750 File Offset: 0x00189950
	public string 15()
	{
		1433 <<EMPTY_NAME>> = this.1.28.FindLast(new Predicate<1371>(1779.1780.optionItemCallbacks.1)) as 1433;
		if (<<EMPTY_NAME>> != null)
		{
			return <<EMPTY_NAME>>.52;
		}
		return null;
	}

	// Token: 0x06003FE6 RID: 16358 RVA: 0x0018B78E File Offset: 0x0018998E
	private void 16(object 1, EventArgs 2)
	{
		this.ResetToDefault();
	}

	// Token: 0x06003FE7 RID: 16359 RVA: 0x0018B796 File Offset: 0x00189996
	private bool 17(1371 1)
	{
		return 1 != this.3 && 1.10;
	}

	// Token: 0x04002EA7 RID: 11943
	internal 1436 1 = new 1436(true)
	{
		24 = true
	};

	// Token: 0x04002EA8 RID: 11944
	internal float 2;

	// Token: 0x04002EA9 RID: 11945
	private 1433 3;

	// Token: 0x04002EAA RID: 11946
	private static 1381 4 = 1381.17(new byte[]
	{
		byte.MaxValue,
		186,
		0,
		byte.MaxValue,
		byte.MaxValue,
		186,
		0,
		160,
		byte.MaxValue,
		186,
		0,
		120,
		byte.MaxValue,
		186,
		0,
		80,
		byte.MaxValue,
		186,
		0,
		40,
		byte.MaxValue,
		186,
		0,
		5
	}, 6, 1);

	// Token: 0x04002EAB RID: 11947
	private 208 5 = new 208(244f, 13.125f);

	// Token: 0x04002EAC RID: 11948
	private float 6;

	// Token: 0x04002EAD RID: 11949
	internal List<string> 7 = new List<string>();

	// Token: 0x04002EAE RID: 11950
	private EventHandler 8;

	// Token: 0x04002EAF RID: 11951
	private bool 9;

	// Token: 0x04002EB0 RID: 11952
	public 1779 10;

	// Token: 0x04002EB1 RID: 11953
	private IEnumerable<1779> 11;

	// Token: 0x04002EB2 RID: 11954
	internal bool 12;

	// Token: 0x020008B7 RID: 2231
	[Serializable]
	public sealed class 1780
	{
		// Token: 0x06003FE9 RID: 16361 RVA: 0x0018B7CC File Offset: 0x001899CC
		internal bool 1(1371 1)
		{
			1433 2 = 1 as 1433;
			return 2 != null && !string.IsNullOrEmpty(2.52);
		}

		// Token: 0x04002EB3 RID: 11955
		public static readonly 1779.1780 optionItemCallbacks = new 1779.1780();

		// Token: 0x04002EB4 RID: 11956
		public static Predicate<1371> predicate;
	}
}
