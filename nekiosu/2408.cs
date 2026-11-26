using System;

// Token: 0x02000610 RID: 1552
public sealed class 2408 : 2422
{
	// Token: 0x06002F63 RID: 12131 RVA: 0x0010C868 File Offset: 0x0010AA68
	internal 2408(2445 1, 2450 2) : base(1, 2)
	{
		base.2((2451)27);
	}

	// Token: 0x06002F64 RID: 12132 RVA: 0x0010C87C File Offset: 0x0010AA7C
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
		this.20 = <<EMPTY_NAME>>.7.16;
		this.13 = <<EMPTY_NAME>>.7.3.FindAll(new Predicate<1445>(2408.2409.instance.1));
		this.13.ForEach(new Action<1445>(base.21));
		return true;
	}

	// Token: 0x06002F65 RID: 12133 RVA: 0x0001702D File Offset: 0x0001522D
	internal override bool HasChanged()
	{
		return true;
	}

	// Token: 0x06002F66 RID: 12134 RVA: 0x0010C90C File Offset: 0x0010AB0C
	internal override void Apply(2457 1)
	{
		base.Apply(1);
		2647 2 = (2647)this.8[0];
		2.7.16 = this.20;
		base.18(2);
	}

	// Token: 0x04002242 RID: 8770
	private new float 20;

	// Token: 0x02000611 RID: 1553
	[Serializable]
	public sealed class 2409
	{
		// Token: 0x06002F67 RID: 12135 RVA: 0x000CAAF9 File Offset: 0x000C8CF9
		internal bool 1(1445 1)
		{
			return 1.14 == 1456.Fade;
		}

		// Token: 0x04002243 RID: 8771
		public static readonly 2408.2409 instance = new 2408.2409();

		// Token: 0x04002244 RID: 8772
		public static Predicate<1445> cachedMatchesKind;
	}
}
