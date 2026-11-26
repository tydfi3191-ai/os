using System;
using System.Runtime.CompilerServices;

// Token: 0x02000287 RID: 647
public abstract class 970 : 103
{
	// Token: 0x060013F5 RID: 5109 RVA: 0x00045B7E File Offset: 0x00043D7E
	public 970()
	{
		this.SetFlag2902_3661(true);
	}

	// Token: 0x060013F6 RID: 5110 RVA: 0x00045B98 File Offset: 0x00043D98
	public string GetName()
	{
		return this.name;
	}

	// Token: 0x060013F7 RID: 5111 RVA: 0x00045BA0 File Offset: 0x00043DA0
	public void SetName(string 1)
	{
		this.name = 1;
	}

	// Token: 0x060013F8 RID: 5112
	public abstract int GetNumber6509_8337();

	// Token: 0x060013F9 RID: 5113
	public abstract void Method8338(int 1);

	// Token: 0x060013FA RID: 5114
	public abstract int Method8340();

	// Token: 0x060013FB RID: 5115
	public abstract int GetNumber6512_8339();

	// Token: 0x060013FC RID: 5116
	public abstract object[] Method8341();

	// Token: 0x060013FD RID: 5117
	public abstract 555 GetRecoveredType12856513_8342();

	// Token: 0x060013FE RID: 5118
	public abstract void Method8343();

	// Token: 0x060013FF RID: 5119
	public abstract void Method8344(bool 1);

	// Token: 0x06001400 RID: 5120
	public abstract bool Method8345(int 1);

	// Token: 0x06001401 RID: 5121
	[CompilerGenerated]
	public abstract void Method8346(530 1);

	// Token: 0x06001402 RID: 5122
	[CompilerGenerated]
	public abstract void Method8347(530 1);

	// Token: 0x06001403 RID: 5123
	internal abstract void Enqueue(802 1);

	// Token: 0x06001404 RID: 5124 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal virtual void OnBeforeEnqueue()
	{
	}

	// Token: 0x06001405 RID: 5125 RVA: 0x00045BA9 File Offset: 0x00043DA9
	public virtual void Method8344()
	{
		this.Method8344(false);
	}

	// Token: 0x06001406 RID: 5126 RVA: 0x00045BB2 File Offset: 0x00043DB2
	public void Method8345()
	{
		this.Method8345(-1);
	}

	// Token: 0x06001407 RID: 5127 RVA: 0x00045BBC File Offset: 0x00043DBC
	public bool Method8345(TimeSpan 1)
	{
		return this.Method8345((int)1.TotalMilliseconds);
	}

	// Token: 0x06001408 RID: 5128 RVA: 0x00045BCC File Offset: 0x00043DCC
	[CompilerGenerated]
	public bool GetFlag2902_3660()
	{
		return this.flag4;
	}

	// Token: 0x06001409 RID: 5129 RVA: 0x00045BD4 File Offset: 0x00043DD4
	protected void SetFlag2902_3661(bool 1)
	{
		this.flag4 = 1;
	}

	// Token: 0x0600140A RID: 5130 RVA: 0x00045BE0 File Offset: 0x00043DE0
	public 373 Method36622(454 1)
	{
		802 2 = 968.Method8759(this, this.GetRecoveredType12856513_8342(), 1);
		this.Enqueue(2);
		return 2.GetRecoveredType244710407_13468();
	}

	// Token: 0x0600140B RID: 5131 RVA: 0x00045C08 File Offset: 0x00043E08
	public 373 Method36622(454 1, 639 2)
	{
		this.OnBeforeEnqueue();
		802 3 = 968.Method8759(this, this.GetRecoveredType12856513_8342(), 1, 2);
		this.Enqueue(3);
		return 3.GetRecoveredType244710407_13468();
	}

	// Token: 0x0600140C RID: 5132 RVA: 0x00045C38 File Offset: 0x00043E38
	public 373 Method36622(969 1, 454 2)
	{
		this.OnBeforeEnqueue();
		802 3 = 968.Method8759(this, this.GetRecoveredType12856513_8342(), 1, 2);
		this.Enqueue(3);
		return 3.GetRecoveredType244710407_13468();
	}

	// Token: 0x0600140D RID: 5133 RVA: 0x00045C68 File Offset: 0x00043E68
	public 373 Method36622(454 1, object 2)
	{
		802 3 = 968.Method8759(this, this.GetRecoveredType12856513_8342(), 1, 2);
		this.Enqueue(3);
		return 3.GetRecoveredType244710407_13468();
	}

	// Token: 0x0600140E RID: 5134 RVA: 0x00045C94 File Offset: 0x00043E94
	public 373 Method36622(454 1, object 2, 639 3)
	{
		this.OnBeforeEnqueue();
		802 4 = 968.Method8759(this, this.GetRecoveredType12856513_8342(), 1, 2, 3);
		this.Enqueue(4);
		return 4.GetRecoveredType244710407_13468();
	}

	// Token: 0x0600140F RID: 5135 RVA: 0x00045CC4 File Offset: 0x00043EC4
	public 373 Method36622(969 1, 454 2, object 3)
	{
		this.OnBeforeEnqueue();
		802 4 = 968.Method8759(this, this.GetRecoveredType12856513_8342(), 1, 2, 3);
		this.Enqueue(4);
		return 4.GetRecoveredType244710407_13468();
	}

	// Token: 0x06001410 RID: 5136 RVA: 0x00045CF4 File Offset: 0x00043EF4
	public 373 Method36622(454 1, object 2, 675 3)
	{
		this.OnBeforeEnqueue();
		802 4 = 968.Method8759(this, this.GetRecoveredType12856513_8342(), 1, 2, 3);
		this.Enqueue(4);
		return 4.GetRecoveredType244710407_13468();
	}

	// Token: 0x06001411 RID: 5137 RVA: 0x00045D24 File Offset: 0x00043F24
	public 373 Method36622(454 1, object 2, 675 3, 639 4)
	{
		this.OnBeforeEnqueue();
		802 5 = 968.Method8759(this, this.GetRecoveredType12856513_8342(), 1, 2, 3, 4);
		this.Enqueue(5);
		return 5.GetRecoveredType244710407_13468();
	}

	// Token: 0x06001412 RID: 5138 RVA: 0x00045D58 File Offset: 0x00043F58
	public 373 Method36622(454 1, object 2, 675 3, 567 4)
	{
		this.OnBeforeEnqueue();
		802 5 = 968.Method8759(this, this.GetRecoveredType12856513_8342(), 1, 2, 3, 4);
		this.Enqueue(5);
		return 5.GetRecoveredType244710407_13468();
	}

	// Token: 0x06001413 RID: 5139 RVA: 0x00045D8C File Offset: 0x00043F8C
	public 373 Method36622(454 1, object 2, 675 3, 567 4, 639 5)
	{
		this.OnBeforeEnqueue();
		802 6 = 968.Method8759(this, this.GetRecoveredType12856513_8342(), 1, 2, 3, 4, 5);
		this.Enqueue(6);
		return 6.GetRecoveredType244710407_13468();
	}

	// Token: 0x06001414 RID: 5140 RVA: 0x00045DC0 File Offset: 0x00043FC0
	public 373 Method36622(Action 1, 639 2 = (639)2)
	{
		970.971 actionClosure = new 970.971();
		actionClosure.action = 4;
		this.OnBeforeEnqueue();
		802 3 = 968.Method8759(this, this.GetRecoveredType12856513_8342(), delegate(object 1)
		{
			actionClosure.action();
			return null;
		}, 2);
		this.Enqueue(3);
		return 3.GetRecoveredType244710407_13468();
	}

	// Token: 0x06001415 RID: 5141 RVA: 0x00045E18 File Offset: 0x00044018
	public 373 Method36622<T>(Action<T> 1, T 2, 639 3 = (639)2)
	{
		970.977<T> CS_0024_003C_003E8__locals5 = new 970.977<T>();
		CS_0024_003C_003E8__locals5._action2891 = 7;
		CS_0024_003C_003E8__locals5._item2892 = 2;
		this.OnBeforeEnqueue();
		555 recoveredType12856513_ = this.GetRecoveredType12856513_8342();
		454 4 = delegate(object 1)
		{
			CS_0024_003C_003E8__locals5._action2891(CS_0024_003C_003E8__locals5._item2892);
			return null;
		};
		object[] 5;
		if (this.GetRecoveredType12856513_8342().GetFlag5794_7502())
		{
			(5 = new object[1])[0] = CS_0024_003C_003E8__locals5._item2892;
		}
		else
		{
			5 = null;
		}
		802 6 = 968.Method8759(this, recoveredType12856513_, 4, 5, 3);
		this.Enqueue(6);
		return 6.GetRecoveredType244710407_13468();
	}

	// Token: 0x06001416 RID: 5142 RVA: 0x00045EA4 File Offset: 0x000440A4
	public 373 Method36622<T1, T2>(Action<T1, T2> 1, T1 2, T2 3, 639 4 = (639)2)
	{
		970.979<T1, T2> CS_0024_003C_003E8__locals8 = new 970.979<T1, T2>();
		CS_0024_003C_003E8__locals8._action2895 = 8;
		CS_0024_003C_003E8__locals8._item2896 = 2;
		CS_0024_003C_003E8__locals8._item2897 = 3;
		this.OnBeforeEnqueue();
		555 recoveredType12856513_ = this.GetRecoveredType12856513_8342();
		454 5 = delegate(object 1)
		{
			CS_0024_003C_003E8__locals8._action2895(CS_0024_003C_003E8__locals8._item2896, CS_0024_003C_003E8__locals8._item2897);
			return null;
		};
		object 6;
		if (this.GetRecoveredType12856513_8342().GetFlag5794_7502())
		{
			object[] array = new object[2];
			array[0] = CS_0024_003C_003E8__locals8._item2896;
			6 = array;
			array[1] = CS_0024_003C_003E8__locals8._item2897;
		}
		else
		{
			6 = null;
		}
		802 7 = 968.Method8759(this, recoveredType12856513_, 5, 6, 4);
		this.Enqueue(7);
		return 7.GetRecoveredType244710407_13468();
	}

	// Token: 0x06001417 RID: 5143 RVA: 0x00045F50 File Offset: 0x00044150
	public 373 Method36622<T1, T2, T3>(Action<T1, T2, T3> 1, T1 2, T2 3, T3 4, 639 5 = (639)2)
	{
		970.975<T1, T2, T3> CS_0024_003C_003E8__locals11 = new 970.975<T1, T2, T3>();
		CS_0024_003C_003E8__locals11._action2883 = 9;
		CS_0024_003C_003E8__locals11._item2884 = 2;
		CS_0024_003C_003E8__locals11._item2885 = 3;
		CS_0024_003C_003E8__locals11._item2886 = 4;
		this.OnBeforeEnqueue();
		555 recoveredType12856513_ = this.GetRecoveredType12856513_8342();
		454 6 = delegate(object 1)
		{
			CS_0024_003C_003E8__locals11._action2883(CS_0024_003C_003E8__locals11._item2884, CS_0024_003C_003E8__locals11._item2885, CS_0024_003C_003E8__locals11._item2886);
			return null;
		};
		object 7;
		if (this.GetRecoveredType12856513_8342().GetFlag5794_7502())
		{
			object[] array = new object[3];
			array[0] = CS_0024_003C_003E8__locals11._item2884;
			array[1] = CS_0024_003C_003E8__locals11._item2885;
			7 = array;
			array[2] = CS_0024_003C_003E8__locals11._item2886;
		}
		else
		{
			7 = null;
		}
		802 8 = 968.Method8759(this, recoveredType12856513_, 6, 7, 5);
		this.Enqueue(8);
		return 8.GetRecoveredType244710407_13468();
	}

	// Token: 0x06001418 RID: 5144 RVA: 0x0004601C File Offset: 0x0004421C
	public 373 Method36622<T1, T2, T3, T4>(Action<T1, T2, T3, T4> 1, T1 2, T2 3, T3 4, T4 5, 639 6 = (639)2)
	{
		970.973<T1, T2, T3, T4> CS_0024_003C_003E8__locals14 = new 970.973<T1, T2, T3, T4>();
		CS_0024_003C_003E8__locals14._action2876 = 10;
		CS_0024_003C_003E8__locals14._item2877 = 2;
		CS_0024_003C_003E8__locals14._item2878 = 3;
		CS_0024_003C_003E8__locals14._item2879 = 4;
		CS_0024_003C_003E8__locals14._item2880 = 5;
		this.OnBeforeEnqueue();
		555 recoveredType12856513_ = this.GetRecoveredType12856513_8342();
		454 7 = delegate(object 1)
		{
			CS_0024_003C_003E8__locals14._action2876(CS_0024_003C_003E8__locals14._item2877, CS_0024_003C_003E8__locals14._item2878, CS_0024_003C_003E8__locals14._item2879, CS_0024_003C_003E8__locals14._item2880);
			return null;
		};
		object 8;
		if (this.GetRecoveredType12856513_8342().GetFlag5794_7502())
		{
			object[] array = new object[4];
			array[0] = CS_0024_003C_003E8__locals14._item2877;
			array[1] = CS_0024_003C_003E8__locals14._item2878;
			array[2] = CS_0024_003C_003E8__locals14._item2879;
			8 = array;
			array[3] = CS_0024_003C_003E8__locals14._item2880;
		}
		else
		{
			8 = null;
		}
		802 9 = 968.Method8759(this, recoveredType12856513_, 7, 8, 6);
		this.Enqueue(9);
		return 9.GetRecoveredType244710407_13468();
	}

	// Token: 0x06001419 RID: 5145 RVA: 0x00046108 File Offset: 0x00044308
	public 486<TResult> Method36622<TResult>(Func<TResult> 1, 639 2 = (639)2)
	{
		970.978<TResult> actionClosure = new 970.978<TResult>();
		actionClosure._func2894 = 4;
		this.OnBeforeEnqueue();
		802 3 = 968.Method8759(this, this.GetRecoveredType12856513_8342(), (object 1) => actionClosure._func2894(), 2);
		this.Enqueue(3);
		return new 384<TResult>(3.GetRecoveredType244710407_13468());
	}

	// Token: 0x0600141A RID: 5146 RVA: 0x00046164 File Offset: 0x00044364
	public 486<TResult> Method36622<T, TResult>(Func<T, TResult> 1, T 2, 639 3 = (639)2)
	{
		970.974<T, TResult> CS_0024_003C_003E8__locals5 = new 970.974<T, TResult>();
		CS_0024_003C_003E8__locals5._func2881 = 7;
		CS_0024_003C_003E8__locals5._item2882 = 2;
		this.OnBeforeEnqueue();
		555 recoveredType12856513_ = this.GetRecoveredType12856513_8342();
		454 4 = (object 1) => CS_0024_003C_003E8__locals5._func2881(CS_0024_003C_003E8__locals5._item2882);
		object[] 5;
		if (this.GetRecoveredType12856513_8342().GetFlag5794_7502())
		{
			(5 = new object[1])[0] = CS_0024_003C_003E8__locals5._item2882;
		}
		else
		{
			5 = null;
		}
		802 6 = 968.Method8759(this, recoveredType12856513_, 4, 5, 3);
		this.Enqueue(6);
		return new 384<TResult>(6.GetRecoveredType244710407_13468());
	}

	// Token: 0x0600141B RID: 5147 RVA: 0x000461F8 File Offset: 0x000443F8
	public 486<TResult> Method36622<T1, T2, TResult>(Func<T1, T2, TResult> 1, T1 2, T2 3, 639 4 = (639)2)
	{
		970.980<T1, T2, TResult> CS_0024_003C_003E8__locals8 = new 970.980<T1, T2, TResult>();
		CS_0024_003C_003E8__locals8._func2898 = 8;
		CS_0024_003C_003E8__locals8._item2899 = 2;
		CS_0024_003C_003E8__locals8._item2900 = 3;
		this.OnBeforeEnqueue();
		555 recoveredType12856513_ = this.GetRecoveredType12856513_8342();
		454 5 = (object 1) => CS_0024_003C_003E8__locals8._func2898(CS_0024_003C_003E8__locals8._item2899, CS_0024_003C_003E8__locals8._item2900);
		object 6;
		if (this.GetRecoveredType12856513_8342().GetFlag5794_7502())
		{
			object[] array = new object[2];
			array[0] = CS_0024_003C_003E8__locals8._item2899;
			6 = array;
			array[1] = CS_0024_003C_003E8__locals8._item2900;
		}
		else
		{
			6 = null;
		}
		802 7 = 968.Method8759(this, recoveredType12856513_, 5, 6, 4);
		this.Enqueue(7);
		return new 384<TResult>(7.GetRecoveredType244710407_13468());
	}

	// Token: 0x0600141C RID: 5148 RVA: 0x000462AC File Offset: 0x000444AC
	public 486<TResult> Method36622<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> 1, T1 2, T2 3, T3 4, 639 5 = (639)2)
	{
		970.976<T1, T2, T3, TResult> CS_0024_003C_003E8__locals11 = new 970.976<T1, T2, T3, TResult>();
		CS_0024_003C_003E8__locals11._func2887 = 9;
		CS_0024_003C_003E8__locals11._item2888 = 2;
		CS_0024_003C_003E8__locals11._item2889 = 3;
		CS_0024_003C_003E8__locals11._item2890 = 4;
		this.OnBeforeEnqueue();
		555 recoveredType12856513_ = this.GetRecoveredType12856513_8342();
		454 6 = (object 1) => CS_0024_003C_003E8__locals11._func2887(CS_0024_003C_003E8__locals11._item2888, CS_0024_003C_003E8__locals11._item2889, CS_0024_003C_003E8__locals11._item2890);
		object 7;
		if (this.GetRecoveredType12856513_8342().GetFlag5794_7502())
		{
			object[] array = new object[3];
			array[0] = CS_0024_003C_003E8__locals11._item2888;
			array[1] = CS_0024_003C_003E8__locals11._item2889;
			7 = array;
			array[2] = CS_0024_003C_003E8__locals11._item2890;
		}
		else
		{
			7 = null;
		}
		802 8 = 968.Method8759(this, recoveredType12856513_, 6, 7, 5);
		this.Enqueue(8);
		return new 384<TResult>(8.GetRecoveredType244710407_13468());
	}

	// Token: 0x0600141D RID: 5149 RVA: 0x00046380 File Offset: 0x00044580
	public 486<TResult> Method36622<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> 1, T1 2, T2 3, T3 4, T4 5, 639 6 = (639)2)
	{
		970.972<T1, T2, T3, T4, TResult> CS_0024_003C_003E8__locals14 = new 970.972<T1, T2, T3, T4, TResult>();
		CS_0024_003C_003E8__locals14._func2871 = 10;
		CS_0024_003C_003E8__locals14._item2872 = 2;
		CS_0024_003C_003E8__locals14._item2873 = 3;
		CS_0024_003C_003E8__locals14._item2874 = 4;
		CS_0024_003C_003E8__locals14._item2875 = 5;
		this.OnBeforeEnqueue();
		555 recoveredType12856513_ = this.GetRecoveredType12856513_8342();
		454 7 = (object 1) => CS_0024_003C_003E8__locals14._func2871(CS_0024_003C_003E8__locals14._item2872, CS_0024_003C_003E8__locals14._item2873, CS_0024_003C_003E8__locals14._item2874, CS_0024_003C_003E8__locals14._item2875);
		object 8;
		if (this.GetRecoveredType12856513_8342().GetFlag5794_7502())
		{
			object[] array = new object[4];
			array[0] = CS_0024_003C_003E8__locals14._item2872;
			array[1] = CS_0024_003C_003E8__locals14._item2873;
			array[2] = CS_0024_003C_003E8__locals14._item2874;
			8 = array;
			array[3] = CS_0024_003C_003E8__locals14._item2875;
		}
		else
		{
			8 = null;
		}
		802 9 = 968.Method8759(this, recoveredType12856513_, 7, 8, 6);
		this.Enqueue(9);
		return new 384<TResult>(9.GetRecoveredType244710407_13468());
	}

	// Token: 0x0400095E RID: 2398
	private string name = "WorkItemsGroupBase";

	// Token: 0x0400095F RID: 2399
	private bool flag4;

	// Token: 0x02000288 RID: 648
	public sealed class 972<TItem, TItem2, TItem3, TItem4, TItem5>
	{
		// Token: 0x0600141E RID: 5150 RVA: 0x00046471 File Offset: 0x00044671
		internal object Method3632(object 1)
		{
			return this._func2871(this._item2872, this._item2873, this._item2874, this._item2875);
		}

		// Token: 0x04000960 RID: 2400
		public Func<TItem, TItem2, TItem3, TItem4, TItem5> _func2871;

		// Token: 0x04000961 RID: 2401
		public TItem _item2872;

		// Token: 0x04000962 RID: 2402
		public TItem2 _item2873;

		// Token: 0x04000963 RID: 2403
		public TItem3 _item2874;

		// Token: 0x04000964 RID: 2404
		public TItem4 _item2875;
	}

	// Token: 0x02000289 RID: 649
	public sealed class 973<TItem, TItem2, TItem3, TItem4>
	{
		// Token: 0x06001420 RID: 5152 RVA: 0x0004649B File Offset: 0x0004469B
		internal object Method3633(object 1)
		{
			this._action2876(this._item2877, this._item2878, this._item2879, this._item2880);
			return null;
		}

		// Token: 0x04000965 RID: 2405
		public Action<TItem, TItem2, TItem3, TItem4> _action2876;

		// Token: 0x04000966 RID: 2406
		public TItem _item2877;

		// Token: 0x04000967 RID: 2407
		public TItem2 _item2878;

		// Token: 0x04000968 RID: 2408
		public TItem3 _item2879;

		// Token: 0x04000969 RID: 2409
		public TItem4 _item2880;
	}

	// Token: 0x0200028A RID: 650
	public sealed class 974<TItem, TItem2>
	{
		// Token: 0x06001422 RID: 5154 RVA: 0x000464C1 File Offset: 0x000446C1
		internal object Method3634(object 1)
		{
			return this._func2881(this._item2882);
		}

		// Token: 0x0400096A RID: 2410
		public Func<TItem, TItem2> _func2881;

		// Token: 0x0400096B RID: 2411
		public TItem _item2882;
	}

	// Token: 0x0200028B RID: 651
	public sealed class 975<TItem, TItem2, TItem3>
	{
		// Token: 0x06001424 RID: 5156 RVA: 0x000464D9 File Offset: 0x000446D9
		internal object Method3635(object 1)
		{
			this._action2883(this._item2884, this._item2885, this._item2886);
			return null;
		}

		// Token: 0x0400096C RID: 2412
		public Action<TItem, TItem2, TItem3> _action2883;

		// Token: 0x0400096D RID: 2413
		public TItem _item2884;

		// Token: 0x0400096E RID: 2414
		public TItem2 _item2885;

		// Token: 0x0400096F RID: 2415
		public TItem3 _item2886;
	}

	// Token: 0x0200028C RID: 652
	public sealed class 976<TItem, TItem2, TItem3, TItem4>
	{
		// Token: 0x06001426 RID: 5158 RVA: 0x000464F9 File Offset: 0x000446F9
		internal object Method3636(object 1)
		{
			return this._func2887(this._item2888, this._item2889, this._item2890);
		}

		// Token: 0x04000970 RID: 2416
		public Func<TItem, TItem2, TItem3, TItem4> _func2887;

		// Token: 0x04000971 RID: 2417
		public TItem _item2888;

		// Token: 0x04000972 RID: 2418
		public TItem2 _item2889;

		// Token: 0x04000973 RID: 2419
		public TItem3 _item2890;
	}

	// Token: 0x0200028D RID: 653
	public sealed class 977<TItem>
	{
		// Token: 0x06001428 RID: 5160 RVA: 0x0004651D File Offset: 0x0004471D
		internal object Method3637(object 1)
		{
			this._action2891(this._item2892);
			return null;
		}

		// Token: 0x04000974 RID: 2420
		public Action<TItem> _action2891;

		// Token: 0x04000975 RID: 2421
		public TItem _item2892;
	}

	// Token: 0x0200028E RID: 654
	public sealed class 971
	{
		// Token: 0x0600142A RID: 5162 RVA: 0x00046531 File Offset: 0x00044731
		internal object InvokeAction(object 1)
		{
			this.action();
			return null;
		}

		// Token: 0x04000976 RID: 2422
		public Action action;
	}

	// Token: 0x0200028F RID: 655
	public sealed class 978<TItem>
	{
		// Token: 0x0600142C RID: 5164 RVA: 0x0004653F File Offset: 0x0004473F
		internal object Method3639(object 1)
		{
			return this._func2894();
		}

		// Token: 0x04000977 RID: 2423
		public Func<TItem> _func2894;
	}

	// Token: 0x02000290 RID: 656
	public sealed class 979<TItem, TItem2>
	{
		// Token: 0x0600142E RID: 5166 RVA: 0x00046551 File Offset: 0x00044751
		internal object Method3640(object 1)
		{
			this._action2895(this._item2896, this._item2897);
			return null;
		}

		// Token: 0x04000978 RID: 2424
		public Action<TItem, TItem2> _action2895;

		// Token: 0x04000979 RID: 2425
		public TItem _item2896;

		// Token: 0x0400097A RID: 2426
		public TItem2 _item2897;
	}

	// Token: 0x02000291 RID: 657
	public sealed class 980<TItem, TItem2, TItem3>
	{
		// Token: 0x06001430 RID: 5168 RVA: 0x0004656B File Offset: 0x0004476B
		internal object Method3641(object 1)
		{
			return this._func2898(this._item2899, this._item2900);
		}

		// Token: 0x0400097B RID: 2427
		public Func<TItem, TItem2, TItem3> _func2898;

		// Token: 0x0400097C RID: 2428
		public TItem _item2899;

		// Token: 0x0400097D RID: 2429
		public TItem2 _item2900;
	}
}
