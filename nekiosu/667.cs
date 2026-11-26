using System;
using System.Globalization;
using System.Reflection;
using System.Reflection.Emit;

// Token: 0x02000191 RID: 401
[242(1)]
[241(0)]
public sealed class 667 : 533
{
	// Token: 0x06000D0C RID: 3340 RVA: 0x0002DC54 File Offset: 0x0002BE54
	internal static 667 GetRecoveredType17897850_9972()
	{
		return 667._recoveredType17897850;
	}

	// Token: 0x06000D0D RID: 3341 RVA: 0x0002DC5B File Offset: 0x0002BE5B
	private static DynamicMethod Method9973(string 1, [241(2)] Type 2, Type[] 3, Type 4)
	{
		if (4.Method6704())
		{
			return new DynamicMethod(1, 2, 3, 4.Module, true);
		}
		return new DynamicMethod(1, 2, 3, 4, true);
	}

	// Token: 0x06000D0E RID: 3342 RVA: 0x0002DC80 File Offset: 0x0002BE80
	public override 516<object> Method9974(MethodBase 1)
	{
		DynamicMethod dynamicMethod = 667.Method9973(1.ToString(), typeof(object), new Type[]
		{
			typeof(object[])
		}, 1.DeclaringType);
		ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
		this.Method9976(1, ilgenerator, 0);
		return (516<object>)dynamicMethod.CreateDelegate(typeof(516<object>));
	}

	// Token: 0x06000D0F RID: 3343 RVA: 0x0002DCE0 File Offset: 0x0002BEE0
	[return: 241(new byte[]
	{
		1,
		1,
		2
	})]
	public override 431<T, object> Method9975<[241(2)] T>(MethodBase 1)
	{
		DynamicMethod dynamicMethod = 667.Method9973(1.ToString(), typeof(object), new Type[]
		{
			typeof(object),
			typeof(object[])
		}, 1.DeclaringType);
		ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
		this.Method9976(1, ilgenerator, 1);
		return (431<T, object>)dynamicMethod.CreateDelegate(typeof(431<T, object>));
	}

	// Token: 0x06000D10 RID: 3344 RVA: 0x0002DD4C File Offset: 0x0002BF4C
	private void Method9976(MethodBase 1, ILGenerator 2, int 3)
	{
		ParameterInfo[] parameters = 1.GetParameters();
		Label label = 2.DefineLabel();
		2.Emit(OpCodes.Ldarg, 3);
		2.Emit(OpCodes.Ldlen);
		2.Emit(OpCodes.Ldc_I4, parameters.Length);
		2.Emit(OpCodes.Beq, label);
		2.Emit(OpCodes.Newobj, typeof(TargetParameterCountException).GetConstructor(143.typeArray));
		2.Emit(OpCodes.Throw);
		2.MarkLabel(label);
		if (!1.IsConstructor && !1.IsStatic)
		{
			2.PushInstance(1.DeclaringType);
		}
		LocalBuilder local = 2.DeclareLocal(typeof(IConvertible));
		LocalBuilder local2 = 2.DeclareLocal(typeof(object));
		OpCode opcode = (parameters.Length < 256) ? OpCodes.Ldloca_S : OpCodes.Ldloca;
		OpCode opcode2 = (parameters.Length < 256) ? OpCodes.Ldloc_S : OpCodes.Ldloc;
		for (int i = 0; i < parameters.Length; i++)
		{
			ParameterInfo parameterInfo = parameters[i];
			Type type = parameterInfo.ParameterType;
			if (type.IsByRef)
			{
				type = type.GetElementType();
				LocalBuilder local3 = 2.DeclareLocal(type);
				if (!parameterInfo.IsOut)
				{
					2.PushArrayInstance(3, i);
					if (type.Method6714())
					{
						Label label2 = 2.DefineLabel();
						Label label3 = 2.DefineLabel();
						2.Emit(OpCodes.Brtrue_S, label2);
						2.Emit(opcode, local3);
						2.Emit(OpCodes.Initobj, type);
						2.Emit(OpCodes.Br_S, label3);
						2.MarkLabel(label2);
						2.PushArrayInstance(3, i);
						2.UnboxIfNeeded(type);
						2.Emit(OpCodes.Stloc_S, local3);
						2.MarkLabel(label3);
					}
					else
					{
						2.UnboxIfNeeded(type);
						2.Emit(OpCodes.Stloc_S, local3);
					}
				}
				2.Emit(opcode, local3);
			}
			else if (type.Method6714())
			{
				2.PushArrayInstance(3, i);
				2.Emit(OpCodes.Stloc_S, local2);
				Label label4 = 2.DefineLabel();
				Label label5 = 2.DefineLabel();
				2.Emit(OpCodes.Ldloc_S, local2);
				2.Emit(OpCodes.Brtrue_S, label4);
				LocalBuilder local4 = 2.DeclareLocal(type);
				2.Emit(opcode, local4);
				2.Emit(OpCodes.Initobj, type);
				2.Emit(opcode2, local4);
				2.Emit(OpCodes.Br_S, label5);
				2.MarkLabel(label4);
				if (type.Method6715())
				{
					MethodInfo method = typeof(IConvertible).GetMethod("To" + type.Name, new Type[]
					{
						typeof(IFormatProvider)
					});
					if (method != null)
					{
						Label label6 = 2.DefineLabel();
						2.Emit(OpCodes.Ldloc_S, local2);
						2.Emit(OpCodes.Isinst, type);
						2.Emit(OpCodes.Brtrue_S, label6);
						2.Emit(OpCodes.Ldloc_S, local2);
						2.Emit(OpCodes.Isinst, typeof(IConvertible));
						2.Emit(OpCodes.Stloc_S, local);
						2.Emit(OpCodes.Ldloc_S, local);
						2.Emit(OpCodes.Brfalse_S, label6);
						2.Emit(OpCodes.Ldloc_S, local);
						2.Emit(OpCodes.Ldnull);
						2.Emit(OpCodes.Callvirt, method);
						2.Emit(OpCodes.Br_S, label5);
						2.MarkLabel(label6);
					}
				}
				2.Emit(OpCodes.Ldloc_S, local2);
				2.UnboxIfNeeded(type);
				2.MarkLabel(label5);
			}
			else
			{
				2.PushArrayInstance(3, i);
				2.UnboxIfNeeded(type);
			}
		}
		if (1.IsConstructor)
		{
			2.Emit(OpCodes.Newobj, (ConstructorInfo)1);
		}
		else
		{
			2.CallMethod((MethodInfo)1);
		}
		Type type2 = 1.IsConstructor ? 1.DeclaringType : ((MethodInfo)1).ReturnType;
		if (type2 != typeof(void))
		{
			2.BoxIfNeeded(type2);
		}
		else
		{
			2.Emit(OpCodes.Ldnull);
		}
		2.Return();
	}

	// Token: 0x06000D11 RID: 3345 RVA: 0x0002E158 File Offset: 0x0002C358
	public override Func<T> Method9977<[241(2)] T>(Type 1)
	{
		DynamicMethod dynamicMethod = 667.Method9973("Create" + 1.FullName, typeof(T), 143.typeArray, 1);
		dynamicMethod.InitLocals = true;
		ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
		this.Method9978(1, ilgenerator, typeof(T));
		return (Func<T>)dynamicMethod.CreateDelegate(typeof(Func<T>));
	}

	// Token: 0x06000D12 RID: 3346 RVA: 0x0002E1C0 File Offset: 0x0002C3C0
	private void Method9978(Type 1, ILGenerator 2, Type 3)
	{
		if (1.Method6714())
		{
			2.DeclareLocal(1);
			2.Emit(OpCodes.Ldloc_0);
			if (1 != 3)
			{
				2.Emit(OpCodes.Box, 1);
			}
		}
		else
		{
			ConstructorInfo constructor = 1.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, 143.typeArray, null);
			if (constructor == null)
			{
				throw new ArgumentException("Could not get constructor for {0}.".Method6825(CultureInfo.InvariantCulture, 1));
			}
			2.Emit(OpCodes.Newobj, constructor);
		}
		2.Return();
	}

	// Token: 0x06000D13 RID: 3347 RVA: 0x0002E240 File Offset: 0x0002C440
	[return: 241(new byte[]
	{
		1,
		1,
		2
	})]
	public override Func<T, object> Method99792<[241(2)] T>(PropertyInfo 1)
	{
		DynamicMethod dynamicMethod = 667.Method9973("Get" + 1.Name, typeof(object), new Type[]
		{
			typeof(T)
		}, 1.DeclaringType);
		ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
		this.Method9980(1, ilgenerator);
		return (Func<T, object>)dynamicMethod.CreateDelegate(typeof(Func<T, object>));
	}

	// Token: 0x06000D14 RID: 3348 RVA: 0x0002E2A8 File Offset: 0x0002C4A8
	private void Method9980(PropertyInfo 1, ILGenerator 2)
	{
		MethodInfo getMethod = 1.GetGetMethod(true);
		if (getMethod == null)
		{
			throw new ArgumentException("Property '{0}' does not have a getter.".Method6825(CultureInfo.InvariantCulture, 1.Name));
		}
		if (!getMethod.IsStatic)
		{
			2.PushInstance(1.DeclaringType);
		}
		2.CallMethod(getMethod);
		2.BoxIfNeeded(1.PropertyType);
		2.Return();
	}

	// Token: 0x06000D15 RID: 3349 RVA: 0x0002E310 File Offset: 0x0002C510
	[return: 241(new byte[]
	{
		1,
		1,
		2
	})]
	public override Func<T, object> Method99792<[241(2)] T>(FieldInfo 1)
	{
		if (1.IsLiteral)
		{
			return new Func<T, object>(new 667.668<T>
			{
				_value7849 = 1.GetValue(null)
			}.GetValue7849_9971);
		}
		DynamicMethod dynamicMethod = 667.Method9973("Get" + 1.Name, typeof(T), new Type[]
		{
			typeof(object)
		}, 1.DeclaringType);
		ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
		this.Method9982(1, ilgenerator);
		return (Func<T, object>)dynamicMethod.CreateDelegate(typeof(Func<T, object>));
	}

	// Token: 0x06000D16 RID: 3350 RVA: 0x0002E3A0 File Offset: 0x0002C5A0
	private void Method9982(FieldInfo 1, ILGenerator 2)
	{
		if (!1.IsStatic)
		{
			2.PushInstance(1.DeclaringType);
			2.Emit(OpCodes.Ldfld, 1);
		}
		else
		{
			2.Emit(OpCodes.Ldsfld, 1);
		}
		2.BoxIfNeeded(1.FieldType);
		2.Return();
	}

	// Token: 0x06000D17 RID: 3351 RVA: 0x0002E3F0 File Offset: 0x0002C5F0
	[return: 241(new byte[]
	{
		1,
		1,
		2
	})]
	public override Action<T, object> Method99832<[241(2)] T>(FieldInfo 1)
	{
		DynamicMethod dynamicMethod = 667.Method9973("Set" + 1.Name, null, new Type[]
		{
			typeof(T),
			typeof(object)
		}, 1.DeclaringType);
		ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
		667.Method9984(1, ilgenerator);
		return (Action<T, object>)dynamicMethod.CreateDelegate(typeof(Action<T, object>));
	}

	// Token: 0x06000D18 RID: 3352 RVA: 0x0002E45C File Offset: 0x0002C65C
	internal static void Method9984(FieldInfo 1, ILGenerator 2)
	{
		if (!1.IsStatic)
		{
			2.PushInstance(1.DeclaringType);
		}
		2.Emit(OpCodes.Ldarg_1);
		2.UnboxIfNeeded(1.FieldType);
		if (!1.IsStatic)
		{
			2.Emit(OpCodes.Stfld, 1);
		}
		else
		{
			2.Emit(OpCodes.Stsfld, 1);
		}
		2.Return();
	}

	// Token: 0x06000D19 RID: 3353 RVA: 0x0002E4BC File Offset: 0x0002C6BC
	[return: 241(new byte[]
	{
		1,
		1,
		2
	})]
	public override Action<T, object> Method99832<[241(2)] T>(PropertyInfo 1)
	{
		DynamicMethod dynamicMethod = 667.Method9973("Set" + 1.Name, null, new Type[]
		{
			typeof(T),
			typeof(object)
		}, 1.DeclaringType);
		ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
		667.Method9986(1, ilgenerator);
		return (Action<T, object>)dynamicMethod.CreateDelegate(typeof(Action<T, object>));
	}

	// Token: 0x06000D1A RID: 3354 RVA: 0x0002E528 File Offset: 0x0002C728
	internal static void Method9986(PropertyInfo 1, ILGenerator 2)
	{
		MethodInfo setMethod = 1.GetSetMethod(true);
		if (!setMethod.IsStatic)
		{
			2.PushInstance(1.DeclaringType);
		}
		2.Emit(OpCodes.Ldarg_1);
		2.UnboxIfNeeded(1.PropertyType);
		2.CallMethod(setMethod);
		2.Return();
	}

	// Token: 0x04000662 RID: 1634
	private static readonly 667 _recoveredType17897850 = new 667();

	// Token: 0x02000192 RID: 402
	public sealed class 668<TItem>
	{
		// Token: 0x06000D1D RID: 3357 RVA: 0x0002E581 File Offset: 0x0002C781
		[242(0)]
		[return: 241(2)]
		internal object GetValue7849_9971(TItem 1)
		{
			return this._value7849;
		}

		// Token: 0x04000663 RID: 1635
		[241(0)]
		public object _value7849;
	}
}
