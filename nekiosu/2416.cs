using System;

// Token: 0x02000618 RID: 1560
public sealed class 2416 : 2422
{
	// Token: 0x06002F80 RID: 12160 RVA: 0x0010CCBE File Offset: 0x0010AEBE
	internal 2416(2445 1, 2450 2) : base(1, 2)
	{
		base.2((2451)28);
	}

	// Token: 0x06002F81 RID: 12161 RVA: 0x0010CCD0 File Offset: 0x0010AED0
	internal override bool CaptureBackup()
	{
		if (!base.9())
		{
			throw new 2448.2449("Not enough objects to initiate backup data");
		}
		if (base.7())
		{
			base.20();
		}
		2647 <<EMPTY_NAME>> = (2647)this.8[0];
		this.20 = <<EMPTY_NAME>>.7.15;
		this.13 = <<EMPTY_NAME>>.7.3.FindAll(new Predicate<1445>(2416.2417.instance.1));
		this.13.ForEach(new Action<1445>(base.21));
		return true;
	}

	// Token: 0x06002F82 RID: 12162 RVA: 0x0001702D File Offset: 0x0001522D
	internal override bool HasChanged()
	{
		return true;
	}

	// Token: 0x06002F83 RID: 12163 RVA: 0x0010CD60 File Offset: 0x0010AF60
	internal override void Apply(2457 1)
	{
		base.Apply(1);
		2647 2 = (2647)this.8[0];
		2.7.15 = this.20;
		base.18(2);
	}

	// Token: 0x0400224D RID: 8781
	private new float 20;

	// Token: 0x02000619 RID: 1561
	[Serializable]
	public sealed class 2417
	{
		// Token: 0x06002F84 RID: 12164 RVA: 0x000AAB47 File Offset: 0x000A8D47
		internal bool 1(1445 1)
		{
			return 1.14 == 1456.Scale;
		}

		// Token: 0x0400224E RID: 8782
		public static readonly 2416.2417 instance = new 2416.2417();

		// Token: 0x0400224F RID: 8783
		public static Predicate<1445> cachedMatchesKind;
	}
}
