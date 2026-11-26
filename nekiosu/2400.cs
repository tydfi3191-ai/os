using System;

// Token: 0x02000608 RID: 1544
public sealed class 2400 : 2402
{
	// Token: 0x06002F43 RID: 12099 RVA: 0x0010B9AA File Offset: 0x00109BAA
	internal 2400(2445 1, 2450 2) : base(1, 2)
	{
		base.2((2451)29);
	}

	// Token: 0x06002F44 RID: 12100 RVA: 0x0010B9BC File Offset: 0x00109BBC
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
		this.20 = <<EMPTY_NAME>>.7.6;
		this.13 = <<EMPTY_NAME>>.7.3.FindAll(new Predicate<1445>(2400.2401.instance.1));
		this.13.ForEach(delegate(1445 1)
		{
			this.16.Add(1.9);
			this.17.Add(1.10);
			this.18.Add(1.3);
			this.19.Add(1.7);
		});
		return true;
	}

	// Token: 0x06002F45 RID: 12101 RVA: 0x0001702D File Offset: 0x0001522D
	internal override bool HasChanged()
	{
		return true;
	}

	// Token: 0x06002F46 RID: 12102 RVA: 0x0010BA4C File Offset: 0x00109C4C
	internal override void Apply(2457 1)
	{
		base.Apply(1);
		2647 2 = (2647)this.8[0];
		2.7.6 = this.20;
		base.18(2);
	}

	// Token: 0x04002237 RID: 8759
	private new 198 20;

	// Token: 0x02000609 RID: 1545
	[Serializable]
	public sealed class 2401
	{
		// Token: 0x06002F48 RID: 12104 RVA: 0x000CB7EB File Offset: 0x000C99EB
		internal bool 1(1445 1)
		{
			return 1.14 == 1456.Colour;
		}

		// Token: 0x04002238 RID: 8760
		public static readonly 2400.2401 instance = new 2400.2401();

		// Token: 0x04002239 RID: 8761
		public static Predicate<1445> cachedMatchesKind;
	}
}
