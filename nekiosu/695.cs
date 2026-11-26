using System;
using System.Runtime.InteropServices;

// Token: 0x020000F8 RID: 248
[241(0)]
[242(1)]
[ComVisible(false)]
public abstract class 695<[241(2)] TItem> : 214
{
	// Token: 0x1700007A RID: 122
	// (get) Token: 0x0600087C RID: 2172 RVA: 0x0000FF75 File Offset: 0x0000E175
	public override bool CanWrite
	{
		get
		{
			return false;
		}
	}

	// Token: 0x0600087D RID: 2173 RVA: 0x0001CE3D File Offset: 0x0001B03D
	public override void WriteJson(173 1, [241(2)] object 2, 158 3)
	{
		throw new NotSupportedException("CustomCreationConverter should only be used while deserializing.");
	}

	// Token: 0x0600087E RID: 2174 RVA: 0x0001CE4C File Offset: 0x0001B04C
	[return: 241(2)]
	public override object ReadJson(139 1, Type 2, [241(2)] object 3, 158 4)
	{
		if (1.GetTokenType() == 216.Null)
		{
			return null;
		}
		TItem titem = this.Method10430(2);
		if (titem == null)
		{
			throw new 364("No object created.");
		}
		4.Method3838(1, titem);
		return titem;
	}

	// Token: 0x0600087F RID: 2175
	public abstract TItem Method10430(Type 1);

	// Token: 0x06000880 RID: 2176 RVA: 0x0001CBF3 File Offset: 0x0001ADF3
	public override bool CanConvert(Type 1)
	{
		return typeof(TItem).IsAssignableFrom(1);
	}
}
