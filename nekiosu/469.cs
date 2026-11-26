using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

// Token: 0x0200013F RID: 319
[241(0)]
[242(1)]
public sealed class 469
{
	// Token: 0x1700008C RID: 140
	// (get) Token: 0x06000AFF RID: 2815 RVA: 0x0002945A File Offset: 0x0002765A
	// (set) Token: 0x06000B00 RID: 2816 RVA: 0x00029462 File Offset: 0x00027662
	[241(new byte[]
	{
		1,
		2,
		1
	})]
	public 431<object, object> RecoveredType06223467
	{
		[return: 241(new byte[]
		{
			1,
			2,
			1
		})]
		get
		{
			return this._recoveredType06223458;
		}
		[param: 241(new byte[]
		{
			1,
			2,
			1
		})]
		private set
		{
			this._recoveredType06223458 = value;
		}
	}

	// Token: 0x1700008D RID: 141
	// (get) Token: 0x06000B01 RID: 2817 RVA: 0x0002946B File Offset: 0x0002766B
	// (set) Token: 0x06000B02 RID: 2818 RVA: 0x00029473 File Offset: 0x00027673
	[241(new byte[]
	{
		1,
		2,
		1
	})]
	public 431<object, object> RecoveredType06223468
	{
		[return: 241(new byte[]
		{
			1,
			2,
			1
		})]
		get
		{
			return this._recoveredType06223459;
		}
		[param: 241(new byte[]
		{
			1,
			2,
			1
		})]
		private set
		{
			this._recoveredType06223459 = value;
		}
	}

	// Token: 0x1700008E RID: 142
	// (get) Token: 0x06000B03 RID: 2819 RVA: 0x0002947C File Offset: 0x0002767C
	// (set) Token: 0x06000B04 RID: 2820 RVA: 0x00029484 File Offset: 0x00027684
	[241(new byte[]
	{
		1,
		2,
		1
	})]
	public 431<object, object> RecoveredType06223469
	{
		[return: 241(new byte[]
		{
			1,
			2,
			1
		})]
		get
		{
			return this._recoveredType06223460;
		}
		[param: 241(new byte[]
		{
			1,
			2,
			1
		})]
		private set
		{
			this._recoveredType06223460 = value;
		}
	}

	// Token: 0x1700008F RID: 143
	// (get) Token: 0x06000B05 RID: 2821 RVA: 0x0002948D File Offset: 0x0002768D
	// (set) Token: 0x06000B06 RID: 2822 RVA: 0x00029495 File Offset: 0x00027695
	[241(new byte[]
	{
		1,
		2,
		1
	})]
	public 431<object, object> RecoveredType06223470
	{
		[return: 241(new byte[]
		{
			1,
			2,
			1
		})]
		get
		{
			return this._recoveredType06223461;
		}
		[param: 241(new byte[]
		{
			1,
			2,
			1
		})]
		private set
		{
			this._recoveredType06223461 = value;
		}
	}

	// Token: 0x17000090 RID: 144
	// (get) Token: 0x06000B07 RID: 2823 RVA: 0x0002949E File Offset: 0x0002769E
	// (set) Token: 0x06000B08 RID: 2824 RVA: 0x000294A6 File Offset: 0x000276A6
	[241(new byte[]
	{
		1,
		2,
		1
	})]
	public 431<object, object> RecoveredType06223471
	{
		[return: 241(new byte[]
		{
			1,
			2,
			1
		})]
		get
		{
			return this._recoveredType06223462;
		}
		[param: 241(new byte[]
		{
			1,
			2,
			1
		})]
		private set
		{
			this._recoveredType06223462 = value;
		}
	}

	// Token: 0x17000091 RID: 145
	// (get) Token: 0x06000B09 RID: 2825 RVA: 0x000294AF File Offset: 0x000276AF
	// (set) Token: 0x06000B0A RID: 2826 RVA: 0x000294B7 File Offset: 0x000276B7
	[241(new byte[]
	{
		1,
		1,
		2
	})]
	public 431<object, object> RecoveredType06223472
	{
		[return: 241(new byte[]
		{
			1,
			1,
			2
		})]
		get
		{
			return this._recoveredType06223466;
		}
		[param: 241(new byte[]
		{
			1,
			1,
			2
		})]
		private set
		{
			this._recoveredType06223466 = value;
		}
	}

	// Token: 0x06000B0B RID: 2827 RVA: 0x000294C0 File Offset: 0x000276C0
	private 469(Assembly 1)
	{
		this.SetAssembly3457_4447(1);
		Type type = 1.GetType("Microsoft.FSharp.Reflection.FSharpType");
		MethodInfo 2 = 469.Method4455(type, "IsUnion", BindingFlags.Static | BindingFlags.Public);
		this.RecoveredType06223467 = 170.GetReflectionDelegateFactory().Method9975<object>(2);
		MethodInfo 3 = 469.Method4455(type, "GetUnionCases", BindingFlags.Static | BindingFlags.Public);
		this.RecoveredType06223468 = 170.GetReflectionDelegateFactory().Method9975<object>(3);
		Type type2 = 1.GetType("Microsoft.FSharp.Reflection.FSharpValue");
		this.RecoveredType06223469 = 469.Method4456(type2, "PreComputeUnionTagReader");
		this.RecoveredType06223470 = 469.Method4456(type2, "PreComputeUnionReader");
		this.RecoveredType06223471 = 469.Method4456(type2, "PreComputeUnionConstructor");
		Type type3 = 1.GetType("Microsoft.FSharp.Reflection.UnionCaseInfo");
		this.SetFunc3464_4451(170.GetReflectionDelegateFactory().Method99792<object>(type3.GetProperty("Name")));
		this.SetFunc3465_4453(170.GetReflectionDelegateFactory().Method99792<object>(type3.GetProperty("Tag")));
		this.SetFunc3463_4449(170.GetReflectionDelegateFactory().Method99792<object>(type3.GetProperty("DeclaringType")));
		this.RecoveredType06223472 = 170.GetReflectionDelegateFactory().Method9975<object>(type3.GetMethod("GetFields"));
		Type type4 = 1.GetType("Microsoft.FSharp.Collections.ListModule");
		this.methodInfo3 = type4.GetMethod("OfSeq");
		this.type5 = 1.GetType("Microsoft.FSharp.Collections.FSharpMap`2");
	}

	// Token: 0x06000B0C RID: 2828 RVA: 0x00029609 File Offset: 0x00027809
	public static 469 GetRecoveredType07893454_4445()
	{
		return 469._recoveredType07893454;
	}

	// Token: 0x06000B0D RID: 2829 RVA: 0x00029610 File Offset: 0x00027810
	public Assembly GetAssembly3457_4446()
	{
		return this.assembly2;
	}

	// Token: 0x06000B0E RID: 2830 RVA: 0x00029618 File Offset: 0x00027818
	private void SetAssembly3457_4447(Assembly 1)
	{
		this.assembly2 = 1;
	}

	// Token: 0x06000B0F RID: 2831 RVA: 0x00029621 File Offset: 0x00027821
	public Func<object, object> GetFunc3463_4448()
	{
		return this.func2;
	}

	// Token: 0x06000B10 RID: 2832 RVA: 0x00029629 File Offset: 0x00027829
	private void SetFunc3463_4449(Func<object, object> 1)
	{
		this.func2 = 1;
	}

	// Token: 0x06000B11 RID: 2833 RVA: 0x00029632 File Offset: 0x00027832
	public Func<object, object> GetFunc3464_4450()
	{
		return this.func3;
	}

	// Token: 0x06000B12 RID: 2834 RVA: 0x0002963A File Offset: 0x0002783A
	private void SetFunc3464_4451(Func<object, object> 1)
	{
		this.func3 = 1;
	}

	// Token: 0x06000B13 RID: 2835 RVA: 0x00029643 File Offset: 0x00027843
	public Func<object, object> GetFunc3465_4452()
	{
		return this.func4;
	}

	// Token: 0x06000B14 RID: 2836 RVA: 0x0002964B File Offset: 0x0002784B
	private void SetFunc3465_4453(Func<object, object> 1)
	{
		this.func4 = 1;
	}

	// Token: 0x06000B15 RID: 2837 RVA: 0x00029654 File Offset: 0x00027854
	public static void Method4454(Assembly 1)
	{
		if (469._recoveredType07893454 != null)
		{
			return;
		}
		object obj = 469.value2;
		lock (obj)
		{
			if (469._recoveredType07893454 == null)
			{
				469._recoveredType07893454 = new 469(1);
			}
		}
	}

	// Token: 0x06000B16 RID: 2838 RVA: 0x000296A8 File Offset: 0x000278A8
	private static MethodInfo Method4455(Type 1, string 2, BindingFlags 3)
	{
		MethodInfo method = 1.GetMethod(2, 3);
		if (method == null && (3 & BindingFlags.NonPublic) != BindingFlags.NonPublic)
		{
			method = 1.GetMethod(2, 3 | BindingFlags.NonPublic);
		}
		return method;
	}

	// Token: 0x06000B17 RID: 2839 RVA: 0x000296DC File Offset: 0x000278DC
	[return: 241(new byte[]
	{
		1,
		2,
		1
	})]
	private static 431<object, object> Method4456(Type 1, string 2)
	{
		469.470 3 = new 469.470();
		MethodInfo methodInfo = 469.Method4455(1, 2, BindingFlags.Static | BindingFlags.Public);
		MethodInfo method = methodInfo.ReturnType.GetMethod("Invoke", BindingFlags.Instance | BindingFlags.Public);
		3._recoveredType06223448 = 170.GetReflectionDelegateFactory().Method9975<object>(methodInfo);
		3._recoveredType06223449 = 170.GetReflectionDelegateFactory().Method9975<object>(method);
		return new 431<object, object>(3.Method4442);
	}

	// Token: 0x06000B18 RID: 2840 RVA: 0x00029738 File Offset: 0x00027938
	public 516<object> Method4457(Type 1)
	{
		MethodInfo 2 = this.methodInfo3.MakeGenericMethod(new Type[]
		{
			1
		});
		return 170.GetReflectionDelegateFactory().Method9974(2);
	}

	// Token: 0x06000B19 RID: 2841 RVA: 0x00029766 File Offset: 0x00027966
	public 516<object> Method4458(Type 1, Type 2)
	{
		return (516<object>)typeof(469).GetMethod("Method4459", BindingFlags.Instance | BindingFlags.Public).MakeGenericMethod(new Type[]
		{
			1,
			2
		}).Invoke(this, null);
	}

	// Token: 0x06000B1A RID: 2842 RVA: 0x000297A0 File Offset: 0x000279A0
	[242(2)]
	[return: 241(1)]
	public 516<object> Method4459<TKey, TValue>()
	{
		469.471<TKey, TValue> <<EMPTY_NAME>> = new 469.471<TKey, TValue>();
		ConstructorInfo constructor = this.type5.MakeGenericType(new Type[]
		{
			typeof(TKey),
			typeof(TValue)
		}).GetConstructor(new Type[]
		{
			typeof(IEnumerable<Tuple<TKey, TValue>>)
		});
		<<EMPTY_NAME>>._recoveredType10453450 = 170.GetReflectionDelegateFactory().Method9974(constructor);
		return new 516<object>(<<EMPTY_NAME>>.Method4443);
	}

	// Token: 0x0400056B RID: 1387
	private static readonly object value2 = new object();

	// Token: 0x0400056C RID: 1388
	[241(2)]
	private static 469 _recoveredType07893454;

	// Token: 0x0400056D RID: 1389
	private MethodInfo methodInfo3;

	// Token: 0x0400056E RID: 1390
	private Type type5;

	// Token: 0x0400056F RID: 1391
	private Assembly assembly2;

	// Token: 0x04000570 RID: 1392
	[241(new byte[]
	{
		1,
		2,
		1
	})]
	private 431<object, object> _recoveredType06223458;

	// Token: 0x04000571 RID: 1393
	[241(new byte[]
	{
		1,
		2,
		1
	})]
	private 431<object, object> _recoveredType06223459;

	// Token: 0x04000572 RID: 1394
	[241(new byte[]
	{
		1,
		2,
		1
	})]
	private 431<object, object> _recoveredType06223460;

	// Token: 0x04000573 RID: 1395
	[241(new byte[]
	{
		1,
		2,
		1
	})]
	private 431<object, object> _recoveredType06223461;

	// Token: 0x04000574 RID: 1396
	[241(new byte[]
	{
		1,
		2,
		1
	})]
	private 431<object, object> _recoveredType06223462;

	// Token: 0x04000575 RID: 1397
	private Func<object, object> func2;

	// Token: 0x04000576 RID: 1398
	private Func<object, object> func3;

	// Token: 0x04000577 RID: 1399
	private Func<object, object> func4;

	// Token: 0x04000578 RID: 1400
	[241(new byte[]
	{
		1,
		1,
		2
	})]
	private 431<object, object> _recoveredType06223466;

	// Token: 0x02000140 RID: 320
	public sealed class 470
	{
		// Token: 0x06000B1C RID: 2844 RVA: 0x00029820 File Offset: 0x00027A20
		internal object Method4442([241(2)] object 1, [241(new byte[]
		{
			1,
			2
		})] object[] 2)
		{
			return new 566(this._recoveredType06223448(1, 2), this._recoveredType06223449);
		}

		// Token: 0x04000579 RID: 1401
		[241(new byte[]
		{
			0,
			2,
			2
		})]
		public 431<object, object> _recoveredType06223448;

		// Token: 0x0400057A RID: 1402
		[241(new byte[]
		{
			0,
			2,
			1
		})]
		public 431<object, object> _recoveredType06223449;
	}

	// Token: 0x02000141 RID: 321
	public sealed class 471<TItem, TItem2>
	{
		// Token: 0x06000B1E RID: 2846 RVA: 0x0002983C File Offset: 0x00027A3C
		internal object Method4443([241(new byte[]
		{
			1,
			2
		})] object[] 1)
		{
			IEnumerable<Tuple<TItem, TItem2>> enumerable = ((IEnumerable<KeyValuePair<TItem, TItem2>>)1[0]).Select(new Func<KeyValuePair<TItem, TItem2>, Tuple<TItem, TItem2>>(469.472<TItem, TItem2>._recoveredType07923451.Method4444));
			return this._recoveredType10453450(new object[]
			{
				enumerable
			});
		}

		// Token: 0x0400057B RID: 1403
		[241(new byte[]
		{
			0,
			1
		})]
		public 516<object> _recoveredType10453450;
	}

	// Token: 0x02000142 RID: 322
	[Serializable]
	public sealed class 472<TItem, TItem2>
	{
		// Token: 0x06000B20 RID: 2848 RVA: 0x0002987C File Offset: 0x00027A7C
		[242(0)]
		internal Tuple<TItem, TItem2> Method4444(KeyValuePair<TItem, TItem2> 1)
		{
			return new Tuple<TItem, TItem2>(1.Key, 1.Value);
		}

		// Token: 0x0400057C RID: 1404
		[241(0)]
		public static readonly 469.472<TItem, TItem2> _recoveredType07923451 = new 469.472<TItem, TItem2>();

		// Token: 0x0400057D RID: 1405
		[241(0)]
		public static Func<KeyValuePair<TItem, TItem2>, Tuple<TItem, TItem2>> _func3452;
	}
}
