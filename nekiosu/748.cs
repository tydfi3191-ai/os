using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

// Token: 0x020001B8 RID: 440
[ComVisible(false)]
[242(1)]
[241(0)]
public sealed class 748 : 65
{
	// Token: 0x06000E14 RID: 3604 RVA: 0x0002FF70 File Offset: 0x0002E170
	public 748()
	{
		755 <<EMPTY_NAME>> = new 755();
		<<EMPTY_NAME>>.SetProcessDictionaryKeys(true);
		<<EMPTY_NAME>>.SetOverrideSpecifiedNames(true);
		base.NamingStrategy = <<EMPTY_NAME>>;
	}

	// Token: 0x06000E15 RID: 3605 RVA: 0x0002FFA0 File Offset: 0x0002E1A0
	public override 902 ResolveContract(Type 1)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("type");
		}
		558<Type, Type> key = new 558<Type, Type>(base.GetType(), 1);
		Dictionary<558<Type, Type>, 902> dictionary = 748.dictionary2;
		902 2;
		if (dictionary == null || !dictionary.TryGetValue(key, out 2))
		{
			2 = this.CreateContract(1);
			object obj = 748.value2;
			lock (obj)
			{
				dictionary = 748.dictionary2;
				Dictionary<558<Type, Type>, 902> dictionary2 = (dictionary != null) ? new Dictionary<558<Type, Type>, 902>(dictionary) : new Dictionary<558<Type, Type>, 902>();
				dictionary2[key] = 2;
				748.dictionary2 = dictionary2;
			}
		}
		return 2;
	}

	// Token: 0x06000E16 RID: 3606 RVA: 0x00030040 File Offset: 0x0002E240
	internal override 587 GetNameTable()
	{
		return 748._recoveredType13979486;
	}

	// Token: 0x040006DF RID: 1759
	private static readonly object value2 = new object();

	// Token: 0x040006E0 RID: 1760
	private static readonly 587 _recoveredType13979486 = new 587();

	// Token: 0x040006E1 RID: 1761
	[241(new byte[]
	{
		2,
		0,
		1,
		1,
		1
	})]
	private static Dictionary<558<Type, Type>, 902> dictionary2;
}
