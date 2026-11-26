using System;

// Token: 0x0200019C RID: 412
[241(0)]
[242(2)]
public sealed class 689
{
	// Token: 0x170000B7 RID: 183
	// (get) Token: 0x06000D81 RID: 3457 RVA: 0x0002EEE4 File Offset: 0x0002D0E4
	// (set) Token: 0x06000D82 RID: 3458 RVA: 0x0002EEEC File Offset: 0x0002D0EC
	[241(new byte[]
	{
		2,
		1,
		2
	})]
	public Func<object, object> Func8083
	{
		[return: 241(new byte[]
		{
			2,
			1,
			2
		})]
		get
		{
			return this.func;
		}
		[param: 241(new byte[]
		{
			2,
			1,
			2
		})]
		set
		{
			this.func = value;
		}
	}

	// Token: 0x170000B8 RID: 184
	// (get) Token: 0x06000D83 RID: 3459 RVA: 0x0002EEF5 File Offset: 0x0002D0F5
	// (set) Token: 0x06000D84 RID: 3460 RVA: 0x0002EEFD File Offset: 0x0002D0FD
	[241(new byte[]
	{
		2,
		1,
		2
	})]
	public Action<object, object> Action8084
	{
		[return: 241(new byte[]
		{
			2,
			1,
			2
		})]
		get
		{
			return this.action;
		}
		[param: 241(new byte[]
		{
			2,
			1,
			2
		})]
		set
		{
			this.action = value;
		}
	}

	// Token: 0x06000D85 RID: 3461 RVA: 0x0002EF06 File Offset: 0x0002D106
	public Type GetType8080_10336()
	{
		return this.type2;
	}

	// Token: 0x06000D86 RID: 3462 RVA: 0x0002EF0E File Offset: 0x0002D10E
	public void SetType8080_10337(Type 1)
	{
		this.type2 = 1;
	}

	// Token: 0x04000674 RID: 1652
	private Type type2;

	// Token: 0x04000675 RID: 1653
	[241(new byte[]
	{
		2,
		1,
		2
	})]
	private Func<object, object> func;

	// Token: 0x04000676 RID: 1654
	[241(new byte[]
	{
		2,
		1,
		2
	})]
	private Action<object, object> action;
}
