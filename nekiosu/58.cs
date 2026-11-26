using System;

// Token: 0x02000353 RID: 851
[AttributeUsage(AttributeTargets.All, Inherited = false)]
public sealed class 58 : Attribute
{
	// Token: 0x06001A7A RID: 6778 RVA: 0x00063FE7 File Offset: 0x000621E7
	public 58(bool 1)
	{
		this.parameterValue = 1;
	}

	// Token: 0x06001A7B RID: 6779 RVA: 0x00063FF6 File Offset: 0x000621F6
	public bool GetParameterValue()
	{
		return this.parameterValue;
	}

	// Token: 0x04000C9F RID: 3231
	private readonly bool parameterValue;
}
