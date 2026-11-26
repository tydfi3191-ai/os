using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;

// Token: 0x020000E9 RID: 233
[242(1)]
[241(0)]
[ComVisible(false)]
public sealed class 110 : 111
{
	// Token: 0x17000058 RID: 88
	// (get) Token: 0x0600074E RID: 1870 RVA: 0x00019398 File Offset: 0x00017598
	protected override IList<226> ChildrenTokens
	{
		get
		{
			return this.list;
		}
	}

	// Token: 0x17000059 RID: 89
	// (get) Token: 0x0600074F RID: 1871 RVA: 0x000193A0 File Offset: 0x000175A0
	// (set) Token: 0x06000750 RID: 1872 RVA: 0x000193A8 File Offset: 0x000175A8
	[241(2)]
	public string Name
	{
		[242(2)]
		get
		{
			return this.text2;
		}
		[242(2)]
		set
		{
			this.text2 = value;
		}
	}

	// Token: 0x1700005A RID: 90
	// (get) Token: 0x06000751 RID: 1873 RVA: 0x000193B1 File Offset: 0x000175B1
	public override 705 Type
	{
		get
		{
			return 705.Constructor;
		}
	}

	// Token: 0x1700005B RID: 91
	[241(2)]
	public override 226 this[object 1]
	{
		[return: 241(2)]
		get
		{
			756.Method12216(1, "key");
			if (1 is int)
			{
				int 2 = (int)1;
				return this.Method14287(2);
			}
			throw new ArgumentException("Accessed JConstructor values with invalid key value: {0}. Argument position index expected.".Method6825(CultureInfo.InvariantCulture, 736.Method11630(1)));
		}
		[param: 241(2)]
		set
		{
			756.Method12216(1, "key");
			if (1 is int)
			{
				int 2 = (int)1;
				this.Method14288(2, value);
				return;
			}
			throw new ArgumentException("Set JConstructor values with invalid key value: {0}. Argument position index expected.".Method6825(CultureInfo.InvariantCulture, 736.Method11630(1)));
		}
	}

	// Token: 0x06000754 RID: 1876 RVA: 0x0001944C File Offset: 0x0001764C
	public 110()
	{
	}

	// Token: 0x06000755 RID: 1877 RVA: 0x0001945F File Offset: 0x0001765F
	public 110(110 1) : base(1, null)
	{
		this.text2 = 1.Name;
	}

	// Token: 0x06000756 RID: 1878 RVA: 0x00019480 File Offset: 0x00017680
	internal 110(110 1, [241(2)] 479 2) : base(1, 2)
	{
		this.text2 = 1.Name;
	}

	// Token: 0x06000757 RID: 1879 RVA: 0x000194A1 File Offset: 0x000176A1
	public 110(string 1, params object[] 2) : this(1, 2)
	{
	}

	// Token: 0x06000758 RID: 1880 RVA: 0x000194AB File Offset: 0x000176AB
	public 110(string 1, object 2) : this(1)
	{
		this.Method7256(2);
	}

	// Token: 0x06000759 RID: 1881 RVA: 0x000194BB File Offset: 0x000176BB
	public 110(string 1)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("#=zcC_miSk=");
		}
		if (1.Length == 0)
		{
			throw new ArgumentException("Constructor name cannot be empty.", "#=zcC_miSk=");
		}
		this.text2 = 1;
	}

	// Token: 0x0600075A RID: 1882 RVA: 0x000194FB File Offset: 0x000176FB
	[242(2)]
	internal override int Method14291(226 1)
	{
		if (1 == null)
		{
			return -1;
		}
		return this.list.Method3176(1);
	}

	// Token: 0x0600075B RID: 1883 RVA: 0x00019510 File Offset: 0x00017710
	internal override void Method14294(object 1, [241(2)] 793 2)
	{
		110 3 = 1 as 110;
		if (3 != null)
		{
			if (3.Name != null)
			{
				this.Name = 3.Name;
			}
			111.Method7313(this, 3, 2);
		}
	}

	// Token: 0x0600075C RID: 1884 RVA: 0x00019544 File Offset: 0x00017744
	internal override bool Method14356(226 1)
	{
		110 2 = 1 as 110;
		return 2 != null && this.text2 == 2.Name && base.Method7238(2);
	}

	// Token: 0x0600075D RID: 1885 RVA: 0x00019577 File Offset: 0x00017777
	internal override 226 Method14299([241(2)] 479 1 = null)
	{
		return new 110(this, 1);
	}

	// Token: 0x0600075E RID: 1886 RVA: 0x00019580 File Offset: 0x00017780
	public override void WriteTo(173 1, params 214[] 2)
	{
		1.WriteStartConstructor(this.text2);
		int count = this.list.Count;
		for (int i = 0; i < count; i++)
		{
			this.list[i].WriteTo(1, 2);
		}
		1.WriteEndConstructor();
	}

	// Token: 0x0600075F RID: 1887 RVA: 0x000195CA File Offset: 0x000177CA
	internal override int Method14364()
	{
		string text = this.text2;
		return ((text != null) ? text.GetHashCode() : 0) ^ base.Method7272();
	}

	// Token: 0x06000760 RID: 1888 RVA: 0x000195E5 File Offset: 0x000177E5
	public static 110 Method1287(139 1)
	{
		return 110.Method1287(1, null);
	}

	// Token: 0x06000761 RID: 1889 RVA: 0x000195F0 File Offset: 0x000177F0
	public static 110 Method1287(139 1, [241(2)] 554 2)
	{
		if (1.GetTokenType() == 216.None && !1.Read())
		{
			throw 141.Method12886(1, "Error reading JConstructor from JsonReader.");
		}
		1.Method2847();
		if (1.GetTokenType() != 216.StartConstructor)
		{
			throw 141.Method12886(1, "Error reading JConstructor from JsonReader. Current JsonReader item is not a constructor: {0}".Method6825(CultureInfo.InvariantCulture, 1.GetTokenType()));
		}
		110 3 = new 110((string)1.GetValue());
		3.Method14343(1 as 99, 2);
		3.Method7269(1, 2);
		return 3;
	}

	// Token: 0x0400049A RID: 1178
	[241(2)]
	private string text2;

	// Token: 0x0400049B RID: 1179
	private readonly List<226> list = new List<226>();
}
