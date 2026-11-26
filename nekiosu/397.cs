using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;

// Token: 0x0200011A RID: 282
[241(0)]
[242(1)]
public sealed class 397 : 533
{
	// Token: 0x06000A44 RID: 2628 RVA: 0x0002725F File Offset: 0x0002545F
	internal static 533 GetRecoveredType04551976_2510()
	{
		return 397._recoveredType04551976;
	}

	// Token: 0x06000A45 RID: 2629 RVA: 0x00027268 File Offset: 0x00025468
	public override 516<object> Method9974(MethodBase 1)
	{
		756.Method12216(1, "method");
		Type typeFromHandle = typeof(object);
		ParameterExpression parameterExpression = Expression.Parameter(typeof(object[]), "args");
		Expression body = this.Method2513(1, typeFromHandle, null, parameterExpression);
		return (516<object>)Expression.Lambda(typeof(516<object>), body, new ParameterExpression[]
		{
			parameterExpression
		}).Compile();
	}

	// Token: 0x06000A46 RID: 2630 RVA: 0x000272D0 File Offset: 0x000254D0
	[return: 241(new byte[]
	{
		1,
		1,
		2
	})]
	public override 431<T, object> Method9975<[241(2)] T>(MethodBase 1)
	{
		756.Method12216(1, "method");
		Type typeFromHandle = typeof(object);
		ParameterExpression parameterExpression = Expression.Parameter(typeFromHandle, "target");
		ParameterExpression parameterExpression2 = Expression.Parameter(typeof(object[]), "args");
		Expression body = this.Method2513(1, typeFromHandle, parameterExpression, parameterExpression2);
		return (431<T, object>)Expression.Lambda(typeof(431<T, object>), body, new ParameterExpression[]
		{
			parameterExpression,
			parameterExpression2
		}).Compile();
	}

	// Token: 0x06000A47 RID: 2631 RVA: 0x00027348 File Offset: 0x00025548
	private Expression Method2513(MethodBase 1, Type 2, [241(2)] ParameterExpression 3, ParameterExpression 4)
	{
		ParameterInfo[] parameters = 1.GetParameters();
		Expression[] array;
		IList<397.398> list;
		if (parameters.Length == 0)
		{
			array = 418.GetItemArray2540_3182<Expression>();
			list = 418.GetItemArray2540_3182<397.398>();
		}
		else
		{
			array = new Expression[parameters.Length];
			list = new List<397.398>();
			for (int i = 0; i < parameters.Length; i++)
			{
				ParameterInfo parameterInfo = parameters[i];
				Type type = parameterInfo.ParameterType;
				bool flag = false;
				if (type.IsByRef)
				{
					type = type.GetElementType();
					flag = true;
				}
				Expression index = Expression.Constant(i);
				Expression 5 = Expression.ArrayIndex(4, index);
				Expression expression = this.Method2519(5, type, !flag);
				if (flag)
				{
					ParameterExpression parameterExpression = Expression.Variable(type);
					list.Add(new 397.398(expression, parameterExpression, parameterInfo.IsOut));
					expression = parameterExpression;
				}
				array[i] = expression;
			}
		}
		Expression expression2 = 1.IsConstructor ? Expression.New((ConstructorInfo)1, array) : ((!1.IsStatic) ? Expression.Call(this.Method2519(3, 1.DeclaringType, false), (MethodInfo)1, array) : Expression.Call((MethodInfo)1, array));
		MethodInfo methodInfo = 1 as MethodInfo;
		expression2 = ((methodInfo == null) ? this.Method2519(expression2, 2, false) : ((!(methodInfo.ReturnType != typeof(void))) ? Expression.Block(expression2, Expression.Constant(null)) : this.Method2519(expression2, 2, false)));
		if (list.Count > 0)
		{
			IList<ParameterExpression> list2 = new List<ParameterExpression>();
			IList<Expression> list3 = new List<Expression>();
			foreach (397.398 6 in list)
			{
				if (!6.flag2)
				{
					list3.Add(Expression.Assign(6.parameterExpression2, 6.expression2));
				}
				list2.Add(6.parameterExpression2);
			}
			list3.Add(expression2);
			expression2 = Expression.Block(list2, list3);
		}
		return expression2;
	}

	// Token: 0x06000A48 RID: 2632 RVA: 0x0002753C File Offset: 0x0002573C
	public override Func<T> Method9977<[241(2)] T>(Type 1)
	{
		397.399<T> CS_0024_003C_003E8__locals6 = new 397.399<T>();
		CS_0024_003C_003E8__locals6._type1975 = 1;
		756.Method12216(CS_0024_003C_003E8__locals6._type1975, "type");
		if (CS_0024_003C_003E8__locals6._type1975.Method6712())
		{
			return () => (T)((object)Activator.CreateInstance(CS_0024_003C_003E8__locals6._type1975));
		}
		Func<T> result;
		try
		{
			Type typeFromHandle = typeof(T);
			Expression expression = Expression.New(CS_0024_003C_003E8__locals6._type1975);
			expression = this.Method2519(expression, typeFromHandle, false);
			result = (Func<T>)Expression.Lambda(typeof(Func<T>), expression, Array.Empty<ParameterExpression>()).Compile();
		}
		catch
		{
			result = new Func<T>(CS_0024_003C_003E8__locals6.Method2509);
		}
		return result;
	}

	// Token: 0x06000A49 RID: 2633 RVA: 0x0002760C File Offset: 0x0002580C
	[return: 241(new byte[]
	{
		1,
		1,
		2
	})]
	public override Func<T, object> Method99792<[241(2)] T>(PropertyInfo 1)
	{
		756.Method12216(1, "propertyInfo");
		Type typeFromHandle = typeof(T);
		Type typeFromHandle2 = typeof(object);
		ParameterExpression parameterExpression = Expression.Parameter(typeFromHandle, "instance");
		MethodInfo getMethod = 1.GetGetMethod(true);
		if (getMethod == null)
		{
			throw new ArgumentException("Property does not have a getter.");
		}
		Expression expression = (!getMethod.IsStatic) ? Expression.MakeMemberAccess(this.Method2519(parameterExpression, 1.DeclaringType, false), 1) : Expression.MakeMemberAccess(null, 1);
		expression = this.Method2519(expression, typeFromHandle2, false);
		return (Func<T, object>)Expression.Lambda(typeof(Func<T, object>), expression, new ParameterExpression[]
		{
			parameterExpression
		}).Compile();
	}

	// Token: 0x06000A4A RID: 2634 RVA: 0x000276B4 File Offset: 0x000258B4
	[return: 241(new byte[]
	{
		1,
		1,
		2
	})]
	public override Func<T, object> Method99792<[241(2)] T>(FieldInfo 1)
	{
		756.Method12216(1, "fieldInfo");
		ParameterExpression parameterExpression = Expression.Parameter(typeof(T), "source");
		Expression expression = (!1.IsStatic) ? Expression.Field(this.Method2519(parameterExpression, 1.DeclaringType, false), 1) : Expression.Field(null, 1);
		expression = this.Method2519(expression, typeof(object), false);
		return Expression.Lambda<Func<T, object>>(expression, new ParameterExpression[]
		{
			parameterExpression
		}).Compile();
	}

	// Token: 0x06000A4B RID: 2635 RVA: 0x00027730 File Offset: 0x00025930
	[return: 241(new byte[]
	{
		1,
		1,
		2
	})]
	public override Action<T, object> Method99832<[241(2)] T>(FieldInfo 1)
	{
		756.Method12216(1, "fieldInfo");
		if (1.DeclaringType.Method6714() || 1.IsInitOnly)
		{
			return 460.GetRecoveredType07673403_4375().Method99832<T>(1);
		}
		ParameterExpression parameterExpression = Expression.Parameter(typeof(T), "source");
		ParameterExpression parameterExpression2 = Expression.Parameter(typeof(object), "value");
		Expression expression = (!1.IsStatic) ? Expression.Field(this.Method2519(parameterExpression, 1.DeclaringType, false), 1) : Expression.Field(null, 1);
		Expression right = this.Method2519(parameterExpression2, expression.Type, false);
		BinaryExpression body = Expression.Assign(expression, right);
		return (Action<T, object>)Expression.Lambda(typeof(Action<T, object>), body, new ParameterExpression[]
		{
			parameterExpression,
			parameterExpression2
		}).Compile();
	}

	// Token: 0x06000A4C RID: 2636 RVA: 0x000277FC File Offset: 0x000259FC
	[return: 241(new byte[]
	{
		1,
		1,
		2
	})]
	public override Action<T, object> Method99832<[241(2)] T>(PropertyInfo 1)
	{
		756.Method12216(1, "propertyInfo");
		if (1.DeclaringType.Method6714())
		{
			return 460.GetRecoveredType07673403_4375().Method99832<T>(1);
		}
		Type typeFromHandle = typeof(T);
		Type typeFromHandle2 = typeof(object);
		ParameterExpression parameterExpression = Expression.Parameter(typeFromHandle, "instance");
		ParameterExpression parameterExpression2 = Expression.Parameter(typeFromHandle2, "value");
		Expression expression = this.Method2519(parameterExpression2, 1.PropertyType, false);
		MethodInfo setMethod = 1.GetSetMethod(true);
		if (setMethod == null)
		{
			throw new ArgumentException("Property does not have a setter.");
		}
		Expression body = (!setMethod.IsStatic) ? Expression.Call(this.Method2519(parameterExpression, 1.DeclaringType, false), setMethod, new Expression[]
		{
			expression
		}) : Expression.Call(setMethod, expression);
		return (Action<T, object>)Expression.Lambda(typeof(Action<T, object>), body, new ParameterExpression[]
		{
			parameterExpression,
			parameterExpression2
		}).Compile();
	}

	// Token: 0x06000A4D RID: 2637 RVA: 0x000278E4 File Offset: 0x00025AE4
	private Expression Method2519(Expression 1, Type 2, bool 3)
	{
		Type type = 1.Type;
		if (type == 2 || (!type.Method6714() && 2.IsAssignableFrom(type)))
		{
			return 1;
		}
		if (2.Method6714())
		{
			Expression expression = Expression.Unbox(1, 2);
			if (3 && 2.Method6715())
			{
				MethodInfo method = typeof(Convert).GetMethod("To" + 2.Name, new Type[]
				{
					typeof(object)
				});
				if (method != null)
				{
					expression = Expression.Condition(Expression.TypeIs(1, 2), expression, Expression.Call(method, 1));
				}
			}
			return Expression.Condition(Expression.Equal(1, Expression.Constant(null, typeof(object))), Expression.Default(2), expression);
		}
		return Expression.Convert(1, 2);
	}

	// Token: 0x04000517 RID: 1303
	private static readonly 397 _recoveredType04551976 = new 397();

	// Token: 0x0200011B RID: 283
	[241(0)]
	public sealed class 398
	{
		// Token: 0x06000A50 RID: 2640 RVA: 0x000279C1 File Offset: 0x00025BC1
		public 398(Expression 1, ParameterExpression 2, bool 3)
		{
			this.expression2 = 1;
			this.parameterExpression2 = 2;
			this.flag2 = 3;
		}

		// Token: 0x04000518 RID: 1304
		public Expression expression2;

		// Token: 0x04000519 RID: 1305
		public ParameterExpression parameterExpression2;

		// Token: 0x0400051A RID: 1306
		public bool flag2;
	}

	// Token: 0x0200011C RID: 284
	public sealed class 399<TItem>
	{
		// Token: 0x06000A51 RID: 2641 RVA: 0x000279DE File Offset: 0x00025BDE
		[242(0)]
		internal TItem Method2508()
		{
			return (TItem)((object)Activator.CreateInstance(this._type1975));
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x000279DE File Offset: 0x00025BDE
		[242(0)]
		internal TItem Method2509()
		{
			return (TItem)((object)Activator.CreateInstance(this._type1975));
		}

		// Token: 0x0400051B RID: 1307
		[241(0)]
		public Type _type1975;
	}
}
