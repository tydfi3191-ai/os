using System;

// Token: 0x02000656 RID: 1622
[AttributeUsage(AttributeTargets.Assembly, Inherited = false, AllowMultiple = false)]
[Serializable]
public sealed class 2252 : Attribute
{
	// Token: 0x17000271 RID: 625
	// (get) Token: 0x06003171 RID: 12657 RVA: 0x00127989 File Offset: 0x00125B89
	// (set) Token: 0x06003172 RID: 12658 RVA: 0x00127991 File Offset: 0x00125B91
	public string RulesetName { get; private set; }

	// Token: 0x17000272 RID: 626
	// (get) Token: 0x06003173 RID: 12659 RVA: 0x0012799A File Offset: 0x00125B9A
	// (set) Token: 0x06003174 RID: 12660 RVA: 0x001279A2 File Offset: 0x00125BA2
	public string EntryType { get; private set; }

	// Token: 0x06003175 RID: 12661 RVA: 0x001279AB File Offset: 0x00125BAB
	public 2252(string 1, string 2)
	{
		this.1(1);
		this.2(2);
	}

	// Token: 0x06003176 RID: 12662 RVA: 0x001279C1 File Offset: 0x00125BC1
	private void 1(string 1)
	{
		this.RulesetName = 1;
	}

	// Token: 0x06003177 RID: 12663 RVA: 0x001279CA File Offset: 0x00125BCA
	private void 2(string 1)
	{
		this.EntryType = 1;
	}
}
