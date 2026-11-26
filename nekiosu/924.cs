using System;
using System.Globalization;
using System.Runtime.InteropServices;

// Token: 0x020000CE RID: 206
[242(1)]
[ComVisible(false)]
[241(0)]
public sealed class 924 : 214
{
	// Token: 0x1700002E RID: 46
	// (get) Token: 0x06000549 RID: 1353 RVA: 0x00010646 File Offset: 0x0000E846
	// (set) Token: 0x0600054A RID: 1354 RVA: 0x0001064E File Offset: 0x0000E84E
	[241(2)]
	public 136 RecoveredType03732637
	{
		[242(2)]
		get
		{
			return this.jsonNamingStrategyBase2;
		}
		[242(2)]
		set
		{
			this.jsonNamingStrategyBase2 = value;
		}
	}

	// Token: 0x0600054B RID: 1355 RVA: 0x00010657 File Offset: 0x0000E857
	public 924()
	{
	}

	// Token: 0x0600054C RID: 1356 RVA: 0x00010666 File Offset: 0x0000E866
	[Obsolete("StringEnumConverter(bool) is obsolete. Create a converter with StringEnumConverter(NamingStrategy, bool) instead.")]
	public 924(bool 1)
	{
		if (1)
		{
			this.RecoveredType03732637 = new 755();
		}
	}

	// Token: 0x0600054D RID: 1357 RVA: 0x00010683 File Offset: 0x0000E883
	public 924(136 1, bool 2 = true)
	{
		this.RecoveredType03732637 = 1;
		this.SetFlag2636_3312(2);
	}

	// Token: 0x0600054E RID: 1358 RVA: 0x000106A0 File Offset: 0x0000E8A0
	public 924(Type 1)
	{
		756.Method12216(1, "namingStrategyType");
		this.RecoveredType03732637 = 170.CreateNamingStrategyInstance(1, null);
	}

	// Token: 0x0600054F RID: 1359 RVA: 0x000106C7 File Offset: 0x0000E8C7
	public 924(Type 1, object[] 2)
	{
		756.Method12216(1, "namingStrategyType");
		this.RecoveredType03732637 = 170.CreateNamingStrategyInstance(1, 2);
	}

	// Token: 0x06000550 RID: 1360 RVA: 0x000106EE File Offset: 0x0000E8EE
	public 924(Type 1, object[] 2, bool 3)
	{
		756.Method12216(1, "namingStrategyType");
		this.RecoveredType03732637 = 170.CreateNamingStrategyInstance(1, 2);
		this.SetFlag2636_3312(3);
	}

	// Token: 0x06000551 RID: 1361 RVA: 0x0001071C File Offset: 0x0000E91C
	public bool Method3309()
	{
		return this.RecoveredType03732637 is 755;
	}

	// Token: 0x06000552 RID: 1362 RVA: 0x0001072E File Offset: 0x0000E92E
	public void Method3310(bool 1)
	{
		if (1)
		{
			if (!(this.RecoveredType03732637 is 755))
			{
				this.RecoveredType03732637 = new 755();
				return;
			}
		}
		else if (this.RecoveredType03732637 is 755)
		{
			this.RecoveredType03732637 = null;
		}
	}

	// Token: 0x06000553 RID: 1363 RVA: 0x00010760 File Offset: 0x0000E960
	public bool GetFlag2636_3311()
	{
		return this.flag2;
	}

	// Token: 0x06000554 RID: 1364 RVA: 0x00010768 File Offset: 0x0000E968
	public void SetFlag2636_3312(bool 1)
	{
		this.flag2 = 1;
	}

	// Token: 0x06000555 RID: 1365 RVA: 0x00010774 File Offset: 0x0000E974
	public override void WriteJson(173 1, [241(2)] object 2, 158 3)
	{
		if (2 == null)
		{
			1.WriteNull();
			return;
		}
		Enum @enum = (Enum)2;
		string 4;
		if (83.Method5804(@enum.GetType(), 2, this.RecoveredType03732637, out 4))
		{
			1.WriteValue(4);
			return;
		}
		if (!this.GetFlag2636_3311())
		{
			throw 364.Method1687(null, 1.GetContainerPath(), "Integer value {0} is not allowed.".Method6825(CultureInfo.InvariantCulture, @enum.ToString("D")), null);
		}
		1.WriteValue(2);
	}

	// Token: 0x06000556 RID: 1366 RVA: 0x000107E8 File Offset: 0x0000E9E8
	[return: 241(2)]
	public override object ReadJson(139 1, Type 2, [241(2)] object 3, 158 4)
	{
		if (1.GetTokenType() != 216.Null)
		{
			bool flag = 143.IsNullableType(2);
			Type type = flag ? Nullable.GetUnderlyingType(2) : 2;
			try
			{
				if (1.GetTokenType() == 216.String)
				{
					object value = 1.GetValue();
					string text = (value != null) ? value.ToString() : null;
					if (538.Method6824(text) && flag)
					{
						return null;
					}
					return 83.ParseEnum(type, this.RecoveredType03732637, text, !this.GetFlag2636_3311());
				}
				else if (1.GetTokenType() == 216.Integer)
				{
					if (!this.GetFlag2636_3311())
					{
						throw 364.Method1687(1, "Integer value {0} is not allowed.".Method6825(CultureInfo.InvariantCulture, 1.GetValue()));
					}
					return 358.Method1501(1.GetValue(), CultureInfo.InvariantCulture, type);
				}
			}
			catch (Exception 5)
			{
				throw 364.Method1687(1, "Error converting value {0} to type '{1}'.".Method6825(CultureInfo.InvariantCulture, 736.Method11630(1.GetValue()), 2), 5);
			}
			throw 364.Method1687(1, "Unexpected token {0} when parsing enum.".Method6825(CultureInfo.InvariantCulture, 1.GetTokenType()));
		}
		if (!143.IsNullableType(2))
		{
			throw 364.Method1687(1, "Cannot convert null value to {0}.".Method6825(CultureInfo.InvariantCulture, 2));
		}
		return null;
	}

	// Token: 0x06000557 RID: 1367 RVA: 0x0001091C File Offset: 0x0000EB1C
	public override bool CanConvert(Type 1)
	{
		return (143.IsNullableType(1) ? Nullable.GetUnderlyingType(1) : 1).Method6709();
	}

	// Token: 0x04000415 RID: 1045
	[241(2)]
	private 136 jsonNamingStrategyBase2;

	// Token: 0x04000416 RID: 1046
	private bool flag2 = true;
}
