using System;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x020001EE RID: 494
[242(1)]
[ComVisible(false)]
[241(0)]
public sealed class 390 : 130
{
	// Token: 0x170000CE RID: 206
	// (get) Token: 0x06000FAE RID: 4014 RVA: 0x00035B0D File Offset: 0x00033D0D
	// (set) Token: 0x06000FAF RID: 4015 RVA: 0x00035B15 File Offset: 0x00033D15
	[241(new byte[]
	{
		2,
		1,
		1
	})]
	public Func<string, string> Func1574
	{
		[return: 241(new byte[]
		{
			2,
			1,
			1
		})]
		get
		{
			return this.func2;
		}
		[param: 241(new byte[]
		{
			2,
			1,
			1
		})]
		set
		{
			this.func2 = value;
		}
	}

	// Token: 0x06000FB0 RID: 4016 RVA: 0x00035B20 File Offset: 0x00033D20
	public 390(Type 1)
	{
		Func<string, CallSite<Func<CallSite, object, object>>> 2;
		if ((2 = 390.<>O.<0>__Method2299) == null)
		{
			2 = (390.<>O.<0>__Method2299 = new Func<string, CallSite<Func<CallSite, object, object>>>(390.Method2299));
		}
		this._recoveredType08381572 = new 482<string, CallSite<Func<CallSite, object, object>>>(2);
		Func<string, CallSite<Func<CallSite, object, object, object>>> 3;
		if ((3 = 390.<>O.<1>__Method2300) == null)
		{
			3 = (390.<>O.<1>__Method2300 = new Func<string, CallSite<Func<CallSite, object, object, object>>>(390.Method2300));
		}
		this._recoveredType08381573 = new 482<string, CallSite<Func<CallSite, object, object, object>>>(3);
		base..ctor(1);
		this._recoveredType17440783 = (659)6;
		this._recoveredType17661570 = new 663(base.GetUnderlyingType());
	}

	// Token: 0x06000FB1 RID: 4017 RVA: 0x00035B98 File Offset: 0x00033D98
	public 663 GetRecoveredType17661570_2298()
	{
		return this._recoveredType17661570;
	}

	// Token: 0x06000FB2 RID: 4018 RVA: 0x00035BA0 File Offset: 0x00033DA0
	private static CallSite<Func<CallSite, object, object>> Method2299(string 1)
	{
		return CallSite<Func<CallSite, object, object>>.Create(new 490((GetMemberBinder)59.60.CreateGetMemberBinder(1, typeof(59))));
	}

	// Token: 0x06000FB3 RID: 4019 RVA: 0x00035BC1 File Offset: 0x00033DC1
	[return: 241(new byte[]
	{
		1,
		1,
		1,
		1,
		2,
		1
	})]
	private static CallSite<Func<CallSite, object, object, object>> Method2300(string 1)
	{
		return CallSite<Func<CallSite, object, object, object>>.Create(new 385((SetMemberBinder)59.60.CreateSetMemberBinder(1, typeof(59))));
	}

	// Token: 0x06000FB4 RID: 4020 RVA: 0x00035BE4 File Offset: 0x00033DE4
	internal bool Method2301(IDynamicMetaObjectProvider 1, string 2, [241(2)] out object 3)
	{
		756.Method12216(1, "dynamicProvider");
		CallSite<Func<CallSite, object, object>> callSite = this._recoveredType08381572.Method4701(2);
		object obj = callSite.Target(callSite, 1);
		if (obj != 429.value)
		{
			3 = obj;
			return true;
		}
		3 = null;
		return false;
	}

	// Token: 0x06000FB5 RID: 4021 RVA: 0x00035C28 File Offset: 0x00033E28
	internal bool Method2302(IDynamicMetaObjectProvider 1, string 2, [241(2)] object 3)
	{
		756.Method12216(1, "dynamicProvider");
		CallSite<Func<CallSite, object, object, object>> callSite = this._recoveredType08381573.Method4701(2);
		return callSite.Target(callSite, 1, 3) != 429.value;
	}

	// Token: 0x04000795 RID: 1941
	private readonly 663 _recoveredType17661570;

	// Token: 0x04000796 RID: 1942
	[241(new byte[]
	{
		2,
		1,
		1
	})]
	private Func<string, string> func2;

	// Token: 0x04000797 RID: 1943
	private readonly 482<string, CallSite<Func<CallSite, object, object>>> _recoveredType08381572;

	// Token: 0x04000798 RID: 1944
	[241(new byte[]
	{
		1,
		1,
		1,
		1,
		1,
		1,
		2,
		1
	})]
	private readonly 482<string, CallSite<Func<CallSite, object, object, object>>> _recoveredType08381573;

	// Token: 0x020001EF RID: 495
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04000799 RID: 1945
		public static Func<string, CallSite<Func<CallSite, object, object>>> <0>__Method2299;

		// Token: 0x0400079A RID: 1946
		public static Func<string, CallSite<Func<CallSite, object, object, object>>> <1>__Method2300;
	}
}
