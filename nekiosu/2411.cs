using System;

// Token: 0x02000613 RID: 1555
public sealed class 2411 : 2425
{
	// Token: 0x06002F6E RID: 12142 RVA: 0x0010CA20 File Offset: 0x0010AC20
	internal 2411(2445 1, 2450 2) : base(1, 2)
	{
		base.2((2451)1);
	}

	// Token: 0x06002F6F RID: 12143 RVA: 0x0010CA34 File Offset: 0x0010AC34
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
		this.13 = <<EMPTY_NAME>>.7.3.FindAll(new Predicate<1445>(2411.2412.instance.1));
		this.13.ForEach(new Action<1445>(base.21));
		return true;
	}

	// Token: 0x06002F70 RID: 12144 RVA: 0x0010AB93 File Offset: 0x00108D93
	internal override bool HasChanged()
	{
		return this.8.Count > 0;
	}

	// Token: 0x06002F71 RID: 12145 RVA: 0x0010CAC4 File Offset: 0x0010ACC4
	internal override void Apply(2457 1)
	{
		base.Apply(1);
		2647 2 = (2647)this.8[0];
		2.7.17 = this.18;
		base.18(2);
	}

	// Token: 0x02000614 RID: 1556
	[Serializable]
	public sealed class 2412
	{
		// Token: 0x06002F72 RID: 12146 RVA: 0x000BA3D9 File Offset: 0x000B85D9
		internal bool 1(1445 1)
		{
			return 1.14 == 1456.Movement;
		}

		// Token: 0x04002247 RID: 8775
		public static readonly 2411.2412 instance = new 2411.2412();

		// Token: 0x04002248 RID: 8776
		public static Predicate<1445> cachedMatchesKind;
	}
}
