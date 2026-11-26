using System;

// Token: 0x02000616 RID: 1558
public sealed class 2414 : 2422
{
	// Token: 0x06002F79 RID: 12153 RVA: 0x0010CBD1 File Offset: 0x0010ADD1
	internal 2414(2445 1, 2450 2) : base(1, 2)
	{
		base.2((2451)25);
	}

	// Token: 0x06002F7A RID: 12154 RVA: 0x0010CBE4 File Offset: 0x0010ADE4
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
		this.20 = <<EMPTY_NAME>>.7.14;
		this.13 = <<EMPTY_NAME>>.7.3.FindAll(new Predicate<1445>(2414.2415.instance.1));
		this.13.ForEach(new Action<1445>(base.21));
		return true;
	}

	// Token: 0x06002F7B RID: 12155 RVA: 0x0001702D File Offset: 0x0001522D
	internal override bool HasChanged()
	{
		return true;
	}

	// Token: 0x06002F7C RID: 12156 RVA: 0x0010CC74 File Offset: 0x0010AE74
	internal override void Apply(2457 1)
	{
		base.Apply(1);
		2647 2 = (2647)this.8[0];
		2.7.14 = this.20;
		base.18(2);
	}

	// Token: 0x0400224A RID: 8778
	private new float 20;

	// Token: 0x02000617 RID: 1559
	[Serializable]
	public sealed class 2415
	{
		// Token: 0x06002F7D RID: 12157 RVA: 0x000DD489 File Offset: 0x000DB689
		internal bool 1(1445 1)
		{
			return 1.14 == 1456.Rotation;
		}

		// Token: 0x0400224B RID: 8779
		public static readonly 2414.2415 instance = new 2414.2415();

		// Token: 0x0400224C RID: 8780
		public static Predicate<1445> cachedMatchesKind;
	}
}
