using System;

// Token: 0x02000359 RID: 857
[AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
public sealed class 239 : Attribute
{
	// Token: 0x06001A81 RID: 6785 RVA: 0x00063FFE File Offset: 0x000621FE
	public 239(bool 1)
	{
		this.returnValue = 1;
	}

	// Token: 0x06001A82 RID: 6786 RVA: 0x0006400D File Offset: 0x0006220D
	public bool GetReturnValue()
	{
		return this.returnValue;
	}

	// Token: 0x04000CA0 RID: 3232
	private readonly bool returnValue;
}
