using System;

// Token: 0x02000714 RID: 1812
[276]
public class 2122 : 2039
{
	// Token: 0x06003566 RID: 13670 RVA: 0x0014A522 File Offset: 0x00148722
	internal 2122(bool 1 = true) : base(1)
	{
	}

	// Token: 0x06003567 RID: 13671 RVA: 0x0014A52B File Offset: 0x0014872B
	internal override 2037 CreateHitObjectFactory()
	{
		return new 2121(this);
	}

	// Token: 0x06003568 RID: 13672 RVA: 0x0014A533 File Offset: 0x00148733
	internal override void UpdateTimeWindowObjects()
	{
		base.UpdateTimeWindowObjects();
		if (!2486.8 && 1226.19())
		{
			1226.34();
		}
	}

	// Token: 0x06003569 RID: 13673 RVA: 0x0014A54E File Offset: 0x0014874E
	protected override void ProcessOverdueJudgement(2034 1)
	{
		base.ProcessOverdueJudgement(1);
	}
}
