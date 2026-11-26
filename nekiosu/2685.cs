using System;
using System.Collections.Generic;

// Token: 0x02000441 RID: 1089
public sealed class 2685<TItem>
{
	// Token: 0x060021D5 RID: 8661 RVA: 0x000920DA File Offset: 0x000902DA
	public 2685(TItem 1)
	{
		this.2(1);
	}

	// Token: 0x060021D6 RID: 8662 RVA: 0x00092115 File Offset: 0x00090315
	public 2685() : this(new object[0])
	{
	}

	// Token: 0x060021D7 RID: 8663 RVA: 0x00092124 File Offset: 0x00090324
	public 2685(params object[] 1)
	{
		Type typeFromHandle = typeof(TItem);
		List<Type> list = new List<Type>();
		if (1.Length != 0)
		{
			foreach (object obj in 1)
			{
				list.Add(obj.GetType());
			}
		}
		else
		{
			list = null;
		}
		TItem titem = (TItem)((object)typeFromHandle.GetConstructor(list.ToArray()).Invoke(1));
		this.2 = titem;
	}

	// Token: 0x060021D8 RID: 8664 RVA: 0x000921C4 File Offset: 0x000903C4
	protected override void Finalize()
	{
		try
		{
			1677 <<EMPTY_NAME>> = 1662.78;
			if (!this.6)
			{
				1662.89.2(new 1189(2685<TItem>.2686.instance.1), 1000, false);
			}
		}
		finally
		{
			base.Finalize();
		}
	}

	// Token: 0x060021D9 RID: 8665 RVA: 0x0009221C File Offset: 0x0009041C
	public TItem 1()
	{
		return this.4.Decrypt(this.2, this.3);
	}

	// Token: 0x060021DA RID: 8666 RVA: 0x00092235 File Offset: 0x00090435
	public void 2(TItem 1)
	{
		this.3 = (int)2685<TItem>.1.2();
		this.2 = this.4.Encrypt(1, this.3);
		this.5++;
	}

	// Token: 0x060021DB RID: 8667 RVA: 0x0009226D File Offset: 0x0009046D
	public static implicit operator TItem(2685<TItem> 1)
	{
		return 1.1();
	}

	// Token: 0x060021DC RID: 8668 RVA: 0x00092275 File Offset: 0x00090475
	public static implicit operator 2685<TItem>(TItem 1)
	{
		return new 2685<TItem>(1);
	}

	// Token: 0x060021DD RID: 8669 RVA: 0x00092280 File Offset: 0x00090480
	public override string ToString()
	{
		TItem titem = this.1();
		return titem.ToString();
	}

	// Token: 0x04001730 RID: 5936
	public static 1193 1 = new 1193();

	// Token: 0x04001731 RID: 5937
	private TItem 2;

	// Token: 0x04001732 RID: 5938
	private int 3 = 2685<TItem>.1.Next(int.MinValue, int.MaxValue);

	// Token: 0x04001733 RID: 5939
	private 1208<TItem> 4 = new 1212<TItem>();

	// Token: 0x04001734 RID: 5940
	internal int 5;

	// Token: 0x04001735 RID: 5941
	internal bool 6 = true;

	// Token: 0x02000442 RID: 1090
	[Serializable]
	public sealed class 2686
	{
		// Token: 0x060021DF RID: 8671 RVA: 0x000922AD File Offset: 0x000904AD
		internal void 1()
		{
			Environment.Exit(-1);
		}

		// Token: 0x04001736 RID: 5942
		public static readonly 2685<TItem>.2686 instance = new 2685<TItem>.2686();

		// Token: 0x04001737 RID: 5943
		public static 1189 _recoveredType06566971;
	}
}
