using System;
using System.Reflection;

// Token: 0x02000134 RID: 308
[242(1)]
[241(0)]
public sealed class 460 : 533
{
	// Token: 0x06000ADE RID: 2782 RVA: 0x00029110 File Offset: 0x00027310
	internal static 533 GetRecoveredType07673403_4375()
	{
		return 460._recoveredType07673403;
	}

	// Token: 0x06000ADF RID: 2783 RVA: 0x00029118 File Offset: 0x00027318
	public override 516<object> Method9974(MethodBase 1)
	{
		460.467 2 = new 460.467();
		2.methodBase = 1;
		756.Method12216(2.methodBase, "method");
		2.constructorInfo = (2.methodBase as ConstructorInfo);
		if (2.constructorInfo != null)
		{
			return new 516<object>(2.Method4373);
		}
		return new 516<object>(2.Method4374);
	}

	// Token: 0x06000AE0 RID: 2784 RVA: 0x00029174 File Offset: 0x00027374
	[return: 241(new byte[]
	{
		1,
		1,
		2
	})]
	public override 431<T, object> Method9975<[241(2)] T>(MethodBase 1)
	{
		460.463<T> 2 = new 460.463<T>();
		2._methodBase3397 = 1;
		756.Method12216(2._methodBase3397, "method");
		2._constructorInfo3396 = (2._methodBase3397 as ConstructorInfo);
		if (2._constructorInfo3396 != null)
		{
			return new 431<T, object>(2.Method4368);
		}
		return new 431<T, object>(2.Method4369);
	}

	// Token: 0x06000AE1 RID: 2785 RVA: 0x000291D0 File Offset: 0x000273D0
	public override Func<T> Method9977<[241(2)] T>(Type 1)
	{
		460.462<T> CS_0024_003C_003E8__locals9 = new 460.462<T>();
		CS_0024_003C_003E8__locals9._type3394 = 1;
		756.Method12216(CS_0024_003C_003E8__locals9._type3394, "type");
		if (CS_0024_003C_003E8__locals9._type3394.Method6714())
		{
			return () => (T)((object)Activator.CreateInstance(CS_0024_003C_003E8__locals9._type3394));
		}
		CS_0024_003C_003E8__locals9._constructorInfo3395 = 143.Method3888(CS_0024_003C_003E8__locals9._type3394, true);
		if (CS_0024_003C_003E8__locals9._constructorInfo3395 == null)
		{
			throw new InvalidOperationException("Unable to find default constructor for " + CS_0024_003C_003E8__locals9._type3394.FullName);
		}
		return new Func<T>(CS_0024_003C_003E8__locals9.Method4367);
	}

	// Token: 0x06000AE2 RID: 2786 RVA: 0x0002928E File Offset: 0x0002748E
	[return: 241(new byte[]
	{
		1,
		1,
		2
	})]
	public override Func<T, object> Method99792<[241(2)] T>(PropertyInfo 1)
	{
		460.464<T> obj = new 460.464<T>
		{
			_propertyInfo3398 = 2
		};
		756.Method12216(obj._propertyInfo3398, "propertyInfo");
		return (T 1) => obj._propertyInfo3398.GetValue(1, null);
	}

	// Token: 0x06000AE3 RID: 2787 RVA: 0x000292C7 File Offset: 0x000274C7
	[return: 241(new byte[]
	{
		1,
		1,
		2
	})]
	public override Func<T, object> Method99792<[241(2)] T>(FieldInfo 1)
	{
		460.465<T> obj = new 460.465<T>
		{
			_fieldInfo3399 = 2
		};
		756.Method12216(obj._fieldInfo3399, "fieldInfo");
		return (T 1) => obj._fieldInfo3399.GetValue(1);
	}

	// Token: 0x06000AE4 RID: 2788 RVA: 0x00029300 File Offset: 0x00027500
	[return: 241(new byte[]
	{
		1,
		1,
		2
	})]
	public override Action<T, object> Method99832<[241(2)] T>(FieldInfo 1)
	{
		460.461<T> 2 = new 460.461<T>();
		2._fieldInfo3393 = 1;
		756.Method12216(2._fieldInfo3393, "fieldInfo");
		return new Action<T, object>(2.Method4365);
	}

	// Token: 0x06000AE5 RID: 2789 RVA: 0x00029329 File Offset: 0x00027529
	[return: 241(new byte[]
	{
		1,
		1,
		2
	})]
	public override Action<T, object> Method99832<[241(2)] T>(PropertyInfo 1)
	{
		460.466<T> 2 = new 460.466<T>();
		2._propertyInfo3400 = 1;
		756.Method12216(2._propertyInfo3400, "propertyInfo");
		return new Action<T, object>(2.Method4372);
	}

	// Token: 0x0400055D RID: 1373
	private static readonly 460 _recoveredType07673403 = new 460();

	// Token: 0x02000135 RID: 309
	public sealed class 461<TItem>
	{
		// Token: 0x06000AE8 RID: 2792 RVA: 0x0002935E File Offset: 0x0002755E
		[242(0)]
		internal void Method4365(TItem 1, [241(2)] object 2)
		{
			this._fieldInfo3393.SetValue(1, 2);
		}

		// Token: 0x0400055E RID: 1374
		[241(0)]
		public FieldInfo _fieldInfo3393;
	}

	// Token: 0x02000136 RID: 310
	public sealed class 462<TItem>
	{
		// Token: 0x06000AEA RID: 2794 RVA: 0x00029372 File Offset: 0x00027572
		[242(0)]
		internal TItem Method4366()
		{
			return (TItem)((object)Activator.CreateInstance(this._type3394));
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x00029384 File Offset: 0x00027584
		[242(0)]
		internal TItem Method4367()
		{
			return (TItem)((object)this._constructorInfo3395.Invoke(null));
		}

		// Token: 0x0400055F RID: 1375
		[241(0)]
		public Type _type3394;

		// Token: 0x04000560 RID: 1376
		[241(0)]
		public ConstructorInfo _constructorInfo3395;
	}

	// Token: 0x02000137 RID: 311
	public sealed class 463<TItem>
	{
		// Token: 0x06000AED RID: 2797 RVA: 0x00029397 File Offset: 0x00027597
		[242(0)]
		[return: 241(2)]
		internal object Method4368(TItem 1, [241(new byte[]
		{
			1,
			2
		})] object[] 2)
		{
			return this._constructorInfo3396.Invoke(2);
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x000293A5 File Offset: 0x000275A5
		[242(0)]
		[return: 241(2)]
		internal object Method4369(TItem 1, [241(new byte[]
		{
			1,
			2
		})] object[] 2)
		{
			return this._methodBase3397.Invoke(1, 2);
		}

		// Token: 0x04000561 RID: 1377
		[241(0)]
		public ConstructorInfo _constructorInfo3396;

		// Token: 0x04000562 RID: 1378
		[241(0)]
		public MethodBase _methodBase3397;
	}

	// Token: 0x02000138 RID: 312
	public sealed class 464<TItem>
	{
		// Token: 0x06000AF0 RID: 2800 RVA: 0x000293B9 File Offset: 0x000275B9
		[242(0)]
		[return: 241(2)]
		internal object Method4370(TItem 1)
		{
			return this._propertyInfo3398.GetValue(1, null);
		}

		// Token: 0x04000563 RID: 1379
		[241(0)]
		public PropertyInfo _propertyInfo3398;
	}

	// Token: 0x02000139 RID: 313
	public sealed class 465<TItem>
	{
		// Token: 0x06000AF2 RID: 2802 RVA: 0x000293CD File Offset: 0x000275CD
		[242(0)]
		[return: 241(2)]
		internal object Method4371(TItem 1)
		{
			return this._fieldInfo3399.GetValue(1);
		}

		// Token: 0x04000564 RID: 1380
		[241(0)]
		public FieldInfo _fieldInfo3399;
	}

	// Token: 0x0200013A RID: 314
	public sealed class 466<TItem>
	{
		// Token: 0x06000AF4 RID: 2804 RVA: 0x000293E0 File Offset: 0x000275E0
		[242(0)]
		internal void Method4372(TItem 1, [241(2)] object 2)
		{
			this._propertyInfo3400.SetValue(1, 2, null);
		}

		// Token: 0x04000565 RID: 1381
		[241(0)]
		public PropertyInfo _propertyInfo3400;
	}

	// Token: 0x0200013B RID: 315
	public sealed class 467
	{
		// Token: 0x06000AF6 RID: 2806 RVA: 0x000293F5 File Offset: 0x000275F5
		internal object Method4373([241(new byte[]
		{
			1,
			2
		})] object[] 1)
		{
			return this.constructorInfo.Invoke(1);
		}

		// Token: 0x06000AF7 RID: 2807 RVA: 0x00029403 File Offset: 0x00027603
		internal object Method4374([241(new byte[]
		{
			1,
			2
		})] object[] 1)
		{
			return this.methodBase.Invoke(null, 1);
		}

		// Token: 0x04000566 RID: 1382
		[241(0)]
		public ConstructorInfo constructorInfo;

		// Token: 0x04000567 RID: 1383
		[241(0)]
		public MethodBase methodBase;
	}
}
