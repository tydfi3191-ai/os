using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;

// Token: 0x02000166 RID: 358
[241(0)]
[242(1)]
public sealed class 580
{
	// Token: 0x1700009A RID: 154
	// (get) Token: 0x06000C2A RID: 3114 RVA: 0x0002BFF3 File Offset: 0x0002A1F3
	[241(new byte[]
	{
		2,
		1
	})]
	public 516<object> RecoveredType10456129
	{
		[return: 241(new byte[]
		{
			2,
			1
		})]
		get
		{
			return this._recoveredType10456127;
		}
	}

	// Token: 0x06000C2B RID: 3115 RVA: 0x0002BFFB File Offset: 0x0002A1FB
	private 580([241(new byte[]
	{
		2,
		1
	})] 516<object> 1)
	{
		this.iDictionary = new Dictionary<string, 689>();
		this._recoveredType10456127 = 1;
	}

	// Token: 0x06000C2C RID: 3116 RVA: 0x0002C015 File Offset: 0x0002A215
	public IDictionary<string, 689> GetIDictionary6128_7911()
	{
		return this.iDictionary;
	}

	// Token: 0x06000C2D RID: 3117 RVA: 0x0002C01D File Offset: 0x0002A21D
	[return: 241(2)]
	public object Method7912(object 1, string 2)
	{
		return this.GetIDictionary6128_7911()[2].Func8083(1);
	}

	// Token: 0x06000C2E RID: 3118 RVA: 0x0002C036 File Offset: 0x0002A236
	public void Method7913(object 1, string 2, [241(2)] object 3)
	{
		this.GetIDictionary6128_7911()[2].Action8084(1, 3);
	}

	// Token: 0x06000C2F RID: 3119 RVA: 0x0002C050 File Offset: 0x0002A250
	public Type Method7914(string 1)
	{
		return this.GetIDictionary6128_7911()[1].GetType8080_10336();
	}

	// Token: 0x06000C30 RID: 3120 RVA: 0x0002C063 File Offset: 0x0002A263
	public static 580 Method7915(Type 1, string[] 2)
	{
		return 580.Method7915(1, null, 2);
	}

	// Token: 0x06000C31 RID: 3121 RVA: 0x0002C070 File Offset: 0x0002A270
	public static 580 Method7915(Type 1, [241(2)] MethodBase 2, string[] 3)
	{
		533 reflectionDelegateFactory = 170.GetReflectionDelegateFactory();
		516<object> 4 = null;
		if (2 != null)
		{
			4 = reflectionDelegateFactory.Method9974(2);
		}
		else if (143.HasDefaultConstructor(1, false))
		{
			4 = new 516<object>(new 580.582
			{
				func = reflectionDelegateFactory.Method9977<object>(1)
			}.Method7909);
		}
		580 5 = new 580(4);
		int i = 0;
		while (i < 3.Length)
		{
			string text = 3[i];
			MemberInfo[] member = 1.GetMember(text, BindingFlags.Instance | BindingFlags.Public);
			if (member.Length != 1)
			{
				throw new ArgumentException("Expected a single member with the name '{0}'.".Method6825(CultureInfo.InvariantCulture, text));
			}
			MemberInfo memberInfo = member.Single<MemberInfo>();
			689 6 = new 689();
			MemberTypes memberTypes = memberInfo.Method6702();
			if (memberTypes == MemberTypes.Field)
			{
				goto IL_AA;
			}
			if (memberTypes != MemberTypes.Method)
			{
				if (memberTypes == MemberTypes.Property)
				{
					goto IL_AA;
				}
				throw new ArgumentException("Unexpected member type '{0}' for member '{1}'.".Method6825(CultureInfo.InvariantCulture, memberInfo.Method6702(), memberInfo.Name));
			}
			else
			{
				MethodInfo methodInfo = (MethodInfo)memberInfo;
				if (methodInfo.IsPublic)
				{
					ParameterInfo[] parameters = methodInfo.GetParameters();
					if (parameters.Length == 0 && methodInfo.ReturnType != typeof(void))
					{
						6.Func8083 = new Func<object, object>(new 580.583
						{
							_recoveredType06226126 = reflectionDelegateFactory.Method9975<object>(methodInfo)
						}.Method7910);
					}
					else if (parameters.Length == 1 && methodInfo.ReturnType == typeof(void))
					{
						6.Action8084 = new Action<object, object>(new 580.581
						{
							_recoveredType06226124 = reflectionDelegateFactory.Method9975<object>(methodInfo)
						}.Method7908);
					}
				}
			}
			IL_1BF:
			6.SetType8080_10337(143.GetMemberUnderlyingType(memberInfo));
			5.GetIDictionary6128_7911()[text] = 6;
			i++;
			continue;
			IL_AA:
			if (143.CanReadMemberValue(memberInfo, false))
			{
				6.Func8083 = reflectionDelegateFactory.Method99792<object>(memberInfo);
			}
			if (143.CanSetMemberValue(memberInfo, false, false))
			{
				6.Action8084 = reflectionDelegateFactory.Method99832<object>(memberInfo);
				goto IL_1BF;
			}
			goto IL_1BF;
		}
		return 5;
	}

	// Token: 0x040005F7 RID: 1527
	[241(new byte[]
	{
		2,
		1
	})]
	private readonly 516<object> _recoveredType10456127;

	// Token: 0x040005F8 RID: 1528
	private readonly IDictionary<string, 689> iDictionary;

	// Token: 0x02000167 RID: 359
	public sealed class 581
	{
		// Token: 0x06000C32 RID: 3122 RVA: 0x0002C26A File Offset: 0x0002A46A
		internal void Method7908(object 1, [241(2)] object 2)
		{
			this._recoveredType06226124(1, new object[]
			{
				2
			});
		}

		// Token: 0x040005F9 RID: 1529
		[241(new byte[]
		{
			0,
			1,
			2
		})]
		public 431<object, object> _recoveredType06226124;
	}

	// Token: 0x02000168 RID: 360
	public sealed class 582
	{
		// Token: 0x06000C34 RID: 3124 RVA: 0x0002C283 File Offset: 0x0002A483
		internal object Method7909([241(new byte[]
		{
			1,
			2
		})] object[] 1)
		{
			return this.func();
		}

		// Token: 0x040005FA RID: 1530
		[241(new byte[]
		{
			0,
			1
		})]
		public Func<object> func;
	}

	// Token: 0x02000169 RID: 361
	public sealed class 583
	{
		// Token: 0x06000C36 RID: 3126 RVA: 0x0002C290 File Offset: 0x0002A490
		[return: 241(2)]
		internal object Method7910(object 1)
		{
			return this._recoveredType06226126(1, Array.Empty<object>());
		}

		// Token: 0x040005FB RID: 1531
		[241(new byte[]
		{
			0,
			1,
			2
		})]
		public 431<object, object> _recoveredType06226126;
	}
}
