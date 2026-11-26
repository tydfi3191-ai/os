using System;
using System.Globalization;
using System.Runtime.InteropServices;

// Token: 0x020000F3 RID: 243
[241(0)]
[242(1)]
[ComVisible(false)]
public abstract class 414<[241(2)] TItem> : 214
{
	// Token: 0x06000863 RID: 2147 RVA: 0x0001CB34 File Offset: 0x0001AD34
	public sealed override void WriteJson(173 1, [241(2)] object 2, 158 3)
	{
		if (!((2 != null) ? (2 is TItem) : 143.IsNullable(typeof(TItem))))
		{
			throw new 364("Converter cannot write specified value to JSON. {0} is required.".Method6825(CultureInfo.InvariantCulture, typeof(TItem)));
		}
		this.WriteJson(1, (TItem)((object)2), 3);
	}

	// Token: 0x06000864 RID: 2148
	public abstract void WriteJson(173 1, [241(2)] TItem 2, 158 3);

	// Token: 0x06000865 RID: 2149 RVA: 0x0001CB90 File Offset: 0x0001AD90
	[return: 241(2)]
	public sealed override object ReadJson(139 1, Type 2, [241(2)] object 3, 158 4)
	{
		bool flag = 3 == null;
		if (!flag && !(3 is TItem))
		{
			throw new 364("Converter cannot read JSON with the specified existing value. {0} is required.".Method6825(CultureInfo.InvariantCulture, typeof(TItem)));
		}
		return this.Method3143(1, 2, flag ? default(TItem) : ((TItem)((object)3)), !flag, 4);
	}

	// Token: 0x06000866 RID: 2150
	[return: 241(2)]
	public abstract TItem Method3143(139 1, Type 2, [241(2)] TItem 3, bool 4, 158 5);

	// Token: 0x06000867 RID: 2151 RVA: 0x0001CBF3 File Offset: 0x0001ADF3
	public sealed override bool CanConvert(Type 1)
	{
		return typeof(TItem).IsAssignableFrom(1);
	}
}
