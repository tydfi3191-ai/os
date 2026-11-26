using System;

// Token: 0x02000BD8 RID: 3032
public sealed class 1212<TItem> : 1208<!0>
{
	// Token: 0x06005300 RID: 21248 RVA: 0x00209D24 File Offset: 0x00207F24
	public TItem 1(TItem 1, int 2, bool 3)
	{
		Type type = 1.GetType();
		if (type == typeof(string))
		{
			string text = Convert.ToString(1);
			char[] array = new char[text.Length];
			for (int i = 0; i < text.Length; i++)
			{
				array[i] = (char)((int)text[i] ^ 2);
			}
			return (TItem)((object)Convert.ChangeType(new string(array), type));
		}
		if (type == typeof(int))
		{
			return (TItem)((object)((int)Convert.ChangeType(1, typeof(int)) ^ 2));
		}
		if (type == typeof(double))
		{
			return (TItem)((object)((double)Convert.ChangeType(1, typeof(double)) * (3 ? (1.0 / (double)2) : ((double)2))));
		}
		if (type == typeof(float))
		{
			return (TItem)((object)((float)Convert.ChangeType(1, typeof(float)) * (3 ? (1f / (float)2) : ((float)2))));
		}
		if (type.BaseType == typeof(Enum))
		{
			return (TItem)((object)((int)Convert.ChangeType(1, typeof(int)) ^ 2));
		}
		return (TItem)((object)1.GetType().GetMethod("op_ExclusiveOr").Invoke(1, new object[]
		{
			2
		}));
	}

	// Token: 0x06005301 RID: 21249 RVA: 0x00209ED8 File Offset: 0x002080D8
	public TItem Encrypt(TItem 1, int 2)
	{
		return this.1(1, 2, false);
	}

	// Token: 0x06005302 RID: 21250 RVA: 0x00209EE3 File Offset: 0x002080E3
	public TItem Decrypt(TItem 1, int 2)
	{
		return this.1(1, 2, true);
	}
}
