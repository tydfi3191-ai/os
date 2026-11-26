using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Runtime.InteropServices;

// Token: 0x0200018E RID: 398
[242(1)]
[ComVisible(false)]
[241(new byte[]
{
	0,
	1,
	1
})]
public sealed class 663 : KeyedCollection<string, 666>
{
	// Token: 0x06000CC3 RID: 3267 RVA: 0x0002D786 File Offset: 0x0002B986
	public 663(Type 1) : base(StringComparer.Ordinal)
	{
		756.Method12216(1, "type");
		this.type2 = 1;
		this.list = (List<666>)base.Items;
	}

	// Token: 0x06000CC4 RID: 3268 RVA: 0x00022389 File Offset: 0x00020589
	protected override string GetKeyForItem(666 1)
	{
		return 1.GetText7760_9879();
	}

	// Token: 0x06000CC5 RID: 3269 RVA: 0x0002D7B8 File Offset: 0x0002B9B8
	public void Method9818(666 1)
	{
		if (base.Contains(1.GetText7760_9879()))
		{
			if (1.GetFlag7770_9897())
			{
				return;
			}
			666 2 = base[1.GetText7760_9879()];
			bool flag = true;
			if (2.GetFlag7770_9897())
			{
				base.Remove(2);
				flag = false;
			}
			else if (1.GetType7764_9881() != null && 2.GetType7764_9881() != null)
			{
				if (1.GetType7764_9881().IsSubclassOf(2.GetType7764_9881()) || (2.GetType7764_9881().Method6704() && 1.GetType7764_9881().Method6718(2.GetType7764_9881())))
				{
					base.Remove(2);
					flag = false;
				}
				if (2.GetType7764_9881().IsSubclassOf(1.GetType7764_9881()) || (1.GetType7764_9881().Method6704() && 2.GetType7764_9881().Method6718(1.GetType7764_9881())) || (this.type2.Method6718(2.GetType7764_9881()) && this.type2.Method6718(1.GetType7764_9881())))
				{
					return;
				}
			}
			if (flag)
			{
				throw new 364("A member with the name '{0}' already exists on '{1}'. Use the JsonPropertyAttribute to specify another name.".Method6825(CultureInfo.InvariantCulture, 1.GetText7760_9879(), this.type2));
			}
		}
		base.Add(1);
	}

	// Token: 0x06000CC6 RID: 3270 RVA: 0x0002D8EC File Offset: 0x0002BAEC
	[return: 241(2)]
	public 666 Method9819(string 1)
	{
		666 2 = this.Method9821(1, StringComparison.Ordinal);
		if (2 == null)
		{
			2 = this.Method9821(1, StringComparison.OrdinalIgnoreCase);
		}
		return 2;
	}

	// Token: 0x06000CC7 RID: 3271 RVA: 0x0002D90F File Offset: 0x0002BB0F
	private bool Method9820(string 1, [239(true)] [241(2)] out 666 2)
	{
		if (base.Dictionary == null)
		{
			2 = null;
			return false;
		}
		return base.Dictionary.TryGetValue(1, out 2);
	}

	// Token: 0x06000CC8 RID: 3272 RVA: 0x0002D92C File Offset: 0x0002BB2C
	[return: 241(2)]
	public 666 Method9821(string 1, StringComparison 2)
	{
		if (2 != StringComparison.Ordinal)
		{
			for (int i = 0; i < this.list.Count; i++)
			{
				666 3 = this.list[i];
				if (string.Equals(1, 3.GetText7760_9879(), 2))
				{
					return 3;
				}
			}
			return null;
		}
		666 result;
		if (this.Method9820(1, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x04000640 RID: 1600
	private readonly Type type2;

	// Token: 0x04000641 RID: 1601
	private readonly List<666> list;
}
