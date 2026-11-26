using System;

// Token: 0x0200061F RID: 1567
public sealed class 2423 : 2425
{
	// Token: 0x06002F9E RID: 12190 RVA: 0x0010D3DD File Offset: 0x0010B5DD
	internal 2423(2445 1, 2450 2) : base(1, 2)
	{
		base.2((2451)32);
	}

	// Token: 0x06002F9F RID: 12191 RVA: 0x0010D3F0 File Offset: 0x0010B5F0
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
		this.18 = <<EMPTY_NAME>>.7.17;
		this.21 = <<EMPTY_NAME>>.7.20;
		this.13 = <<EMPTY_NAME>>.7.3.FindAll(new Predicate<1445>(2423.2424.instance.1));
		this.13.ForEach(new Action<1445>(base.21));
		return true;
	}

	// Token: 0x06002FA0 RID: 12192 RVA: 0x0001702D File Offset: 0x0001522D
	internal override bool HasChanged()
	{
		return true;
	}

	// Token: 0x06002FA1 RID: 12193 RVA: 0x0010D490 File Offset: 0x0010B690
	internal override void Apply(2457 1)
	{
		base.Apply(1);
		2647 2 = (2647)this.8[0];
		2.7.17 = this.18;
		2.7.20 = this.21;
		base.18(2);
	}

	// Token: 0x0400225A RID: 8794
	private new 208 21;

	// Token: 0x02000620 RID: 1568
	[Serializable]
	public sealed class 2424
	{
		// Token: 0x06002FA2 RID: 12194 RVA: 0x0010D4DF File Offset: 0x0010B6DF
		internal bool 1(1445 1)
		{
			return 1.14 == 1456.VectorScale;
		}

		// Token: 0x0400225B RID: 8795
		public static readonly 2423.2424 instance = new 2423.2424();

		// Token: 0x0400225C RID: 8796
		public static Predicate<1445> cachedMatchesKind;
	}
}
