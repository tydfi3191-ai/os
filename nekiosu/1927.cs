using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x02000835 RID: 2101
public sealed class 1927
{
	// Token: 0x06003D10 RID: 15632 RVA: 0x00181CAF File Offset: 0x0017FEAF
	public 1927(IDictionary<1928, float> 1, bool 2)
	{
		this.1 = new Dictionary<1928, float>(1);
		this.ExtendedLimits = 2;
	}

	// Token: 0x170002C6 RID: 710
	// (get) Token: 0x06003D11 RID: 15633 RVA: 0x00181CCA File Offset: 0x0017FECA
	public bool ExtendedLimits { get; }

	// Token: 0x170002C7 RID: 711
	// (get) Token: 0x06003D12 RID: 15634 RVA: 0x00181CD2 File Offset: 0x0017FED2
	public bool IsEmpty
	{
		get
		{
			return this.1.Count == 0;
		}
	}

	// Token: 0x06003D13 RID: 15635 RVA: 0x00181CE4 File Offset: 0x0017FEE4
	public float? Get(1928 1)
	{
		float value;
		if (!this.1.TryGetValue(1, out value))
		{
			return null;
		}
		return new float?(value);
	}

	// Token: 0x06003D14 RID: 15636 RVA: 0x00181D14 File Offset: 0x0017FF14
	public float Apply(1928 1, float 2)
	{
		float result;
		if (!this.1.TryGetValue(1, out result))
		{
			return 2;
		}
		return result;
	}

	// Token: 0x06003D15 RID: 15637 RVA: 0x00181D34 File Offset: 0x0017FF34
	public string 1()
	{
		return string.Join(", ", from 1 in this.1
		orderby 1.Key
		select 1926.16(1.Key) + " " + 1926.2(1.Key, 1.Value));
	}

	// Token: 0x04002D06 RID: 11526
	private readonly Dictionary<1928, float> 1;
}
