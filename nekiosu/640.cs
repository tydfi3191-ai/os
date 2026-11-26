using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;

// Token: 0x02000179 RID: 377
[241(0)]
[242(1)]
public sealed class 640<[241(2)] TItem> : DynamicMetaObject
{
	// Token: 0x06000C7E RID: 3198 RVA: 0x0002CB60 File Offset: 0x0002AD60
	internal 640(Expression 1, TItem 2, 625<TItem> 3) : base(1, BindingRestrictions.Empty, 2)
	{
		this._recoveredType16067540 = 3;
	}

	// Token: 0x06000C7F RID: 3199 RVA: 0x0002CB7B File Offset: 0x0002AD7B
	private bool Method9573(string 1)
	{
		return 143.IsMethodOverridden(this._recoveredType16067540.GetType(), typeof(625<TItem>), 1);
	}

	// Token: 0x06000C80 RID: 3200 RVA: 0x0002CB98 File Offset: 0x0002AD98
	public override DynamicMetaObject BindGetMember(GetMemberBinder 1)
	{
		640<TItem>.653 2 = new 640<TItem>.653();
		2._getMemberBinder7533 = 1;
		2._recoveredType16987534 = this;
		if (!this.Method9573("TryGetMember"))
		{
			return base.BindGetMember(2._getMemberBinder7533);
		}
		return this.Method9579("TryGetMember", 2._getMemberBinder7533, 640<TItem>.Method9574(), new 640<TItem>.649(2.Method9570), null);
	}

	// Token: 0x06000C81 RID: 3201 RVA: 0x0002CBF8 File Offset: 0x0002ADF8
	public override DynamicMetaObject BindSetMember(SetMemberBinder 1, DynamicMetaObject 2)
	{
		640<TItem>.651 3 = new 640<TItem>.651();
		3._setMemberBinder7527 = 1;
		3._recoveredType16987528 = this;
		3._dynamicMetaObject7529 = 2;
		if (!this.Method9573("TrySetMember"))
		{
			return base.BindSetMember(3._setMemberBinder7527, 3._dynamicMetaObject7529);
		}
		return this.Method9581("TrySetMember", 3._setMemberBinder7527, 640<TItem>.Method9575(new DynamicMetaObject[]
		{
			3._dynamicMetaObject7529
		}), new 640<TItem>.649(3.Method9567));
	}

	// Token: 0x06000C82 RID: 3202 RVA: 0x0002CC74 File Offset: 0x0002AE74
	public override DynamicMetaObject BindDeleteMember(DeleteMemberBinder 1)
	{
		640<TItem>.646 2 = new 640<TItem>.646();
		2._deleteMemberBinder7520 = 1;
		2._recoveredType16987521 = this;
		if (!this.Method9573("TryDeleteMember"))
		{
			return base.BindDeleteMember(2._deleteMemberBinder7520);
		}
		return this.Method9582("TryDeleteMember", 2._deleteMemberBinder7520, 640<TItem>.Method9574(), new 640<TItem>.649(2.Method9564));
	}

	// Token: 0x06000C83 RID: 3203 RVA: 0x0002CCD4 File Offset: 0x0002AED4
	public override DynamicMetaObject BindConvert(ConvertBinder 1)
	{
		640<TItem>.655 2 = new 640<TItem>.655();
		2._convertBinder7538 = 1;
		2._recoveredType16987539 = this;
		if (!this.Method9573("TryConvert"))
		{
			return base.BindConvert(2._convertBinder7538);
		}
		return this.Method9579("TryConvert", 2._convertBinder7538, 640<TItem>.Method9574(), new 640<TItem>.649(2.Method9572), null);
	}

	// Token: 0x06000C84 RID: 3204 RVA: 0x0002CD34 File Offset: 0x0002AF34
	public override DynamicMetaObject BindInvokeMember(InvokeMemberBinder 1, DynamicMetaObject[] 2)
	{
		640<TItem>.652 3 = new 640<TItem>.652();
		3._invokeMemberBinder7530 = 1;
		3._recoveredType16987531 = this;
		3._dynamicMetaObjectArray7532 = 2;
		if (!this.Method9573("TryInvokeMember"))
		{
			return base.BindInvokeMember(3._invokeMemberBinder7530, 3._dynamicMetaObjectArray7532);
		}
		640<TItem>.649 4 = new 640<TItem>.649(3.Method9568);
		return this.Method9580("TryInvokeMember", 3._invokeMemberBinder7530, 640<TItem>.Method9576(3._dynamicMetaObjectArray7532), this.Method9580("TryGetMember", new 640<TItem>.647(3._invokeMemberBinder7530), 640<TItem>.Method9574(), 4(null), new 640<TItem>.649(3.Method9569)), null);
	}

	// Token: 0x06000C85 RID: 3205 RVA: 0x0002CDD4 File Offset: 0x0002AFD4
	public override DynamicMetaObject BindCreateInstance(CreateInstanceBinder 1, DynamicMetaObject[] 2)
	{
		640<TItem>.641 CS_0024_003C_003E8__locals10 = new 640<TItem>.641();
		CS_0024_003C_003E8__locals10._createInstanceBinder7505 = 3;
		CS_0024_003C_003E8__locals10._recoveredType16987506 = this;
		CS_0024_003C_003E8__locals10._dynamicMetaObjectArray7507 = 2;
		if (!this.Method9573("TryCreateInstance"))
		{
			return base.BindCreateInstance(CS_0024_003C_003E8__locals10._createInstanceBinder7505, CS_0024_003C_003E8__locals10._dynamicMetaObjectArray7507);
		}
		return this.Method9579("TryCreateInstance", CS_0024_003C_003E8__locals10._createInstanceBinder7505, 640<TItem>.Method9576(CS_0024_003C_003E8__locals10._dynamicMetaObjectArray7507), ([241(2)] DynamicMetaObject 1) => CS_0024_003C_003E8__locals10._createInstanceBinder7505.FallbackCreateInstance(CS_0024_003C_003E8__locals10._recoveredType16987506, CS_0024_003C_003E8__locals10._dynamicMetaObjectArray7507, 1), null);
	}

	// Token: 0x06000C86 RID: 3206 RVA: 0x0002CE74 File Offset: 0x0002B074
	public override DynamicMetaObject BindInvoke(InvokeBinder 1, DynamicMetaObject[] 2)
	{
		640<TItem>.642 3 = new 640<TItem>.642();
		3._invokeBinder7508 = 1;
		3._recoveredType16987509 = this;
		3._dynamicMetaObjectArray7510 = 2;
		if (!this.Method9573("TryInvoke"))
		{
			return base.BindInvoke(3._invokeBinder7508, 3._dynamicMetaObjectArray7510);
		}
		return this.Method9579("TryInvoke", 3._invokeBinder7508, 640<TItem>.Method9576(3._dynamicMetaObjectArray7510), new 640<TItem>.649(3.Method9560), null);
	}

	// Token: 0x06000C87 RID: 3207 RVA: 0x0002CEE8 File Offset: 0x0002B0E8
	public override DynamicMetaObject BindBinaryOperation(BinaryOperationBinder 1, DynamicMetaObject 2)
	{
		640<TItem>.645 3 = new 640<TItem>.645();
		3._binaryOperationBinder7517 = 1;
		3._recoveredType16987518 = this;
		3._dynamicMetaObject7519 = 2;
		if (!this.Method9573("TryBinaryOperation"))
		{
			return base.BindBinaryOperation(3._binaryOperationBinder7517, 3._dynamicMetaObject7519);
		}
		return this.Method9579("TryBinaryOperation", 3._binaryOperationBinder7517, 640<TItem>.Method9575(new DynamicMetaObject[]
		{
			3._dynamicMetaObject7519
		}), new 640<TItem>.649(3.Method9563), null);
	}

	// Token: 0x06000C88 RID: 3208 RVA: 0x0002CF64 File Offset: 0x0002B164
	public override DynamicMetaObject BindUnaryOperation(UnaryOperationBinder 1)
	{
		640<TItem>.648 CS_0024_003C_003E8__locals6 = new 640<TItem>.648();
		CS_0024_003C_003E8__locals6._unaryOperationBinder7522 = 2;
		CS_0024_003C_003E8__locals6._recoveredType16987523 = this;
		if (!this.Method9573("TryUnaryOperation"))
		{
			return base.BindUnaryOperation(CS_0024_003C_003E8__locals6._unaryOperationBinder7522);
		}
		return this.Method9579("TryUnaryOperation", CS_0024_003C_003E8__locals6._unaryOperationBinder7522, 640<TItem>.Method9574(), ([241(2)] DynamicMetaObject 1) => CS_0024_003C_003E8__locals6._unaryOperationBinder7522.FallbackUnaryOperation(CS_0024_003C_003E8__locals6._recoveredType16987523, 1), null);
	}

	// Token: 0x06000C89 RID: 3209 RVA: 0x0002CFE4 File Offset: 0x0002B1E4
	public override DynamicMetaObject BindGetIndex(GetIndexBinder 1, DynamicMetaObject[] 2)
	{
		640<TItem>.650 3 = new 640<TItem>.650();
		3._getIndexBinder7524 = 1;
		3._recoveredType16987525 = this;
		3._dynamicMetaObjectArray7526 = 2;
		if (!this.Method9573("TryGetIndex"))
		{
			return base.BindGetIndex(3._getIndexBinder7524, 3._dynamicMetaObjectArray7526);
		}
		return this.Method9579("TryGetIndex", 3._getIndexBinder7524, 640<TItem>.Method9576(3._dynamicMetaObjectArray7526), new 640<TItem>.649(3.Method9566), null);
	}

	// Token: 0x06000C8A RID: 3210 RVA: 0x0002D058 File Offset: 0x0002B258
	public override DynamicMetaObject BindSetIndex(SetIndexBinder 1, DynamicMetaObject[] 2, DynamicMetaObject 3)
	{
		640<TItem>.643 4 = new 640<TItem>.643();
		4._setIndexBinder7511 = 1;
		4._recoveredType16987512 = this;
		4._dynamicMetaObjectArray7513 = 2;
		4._dynamicMetaObject7514 = 3;
		if (!this.Method9573("TrySetIndex"))
		{
			return base.BindSetIndex(4._setIndexBinder7511, 4._dynamicMetaObjectArray7513, 4._dynamicMetaObject7514);
		}
		return this.Method9581("TrySetIndex", 4._setIndexBinder7511, 640<TItem>.Method9576(4._dynamicMetaObjectArray7513, 4._dynamicMetaObject7514), new 640<TItem>.649(4.Method9561));
	}

	// Token: 0x06000C8B RID: 3211 RVA: 0x0002D0DC File Offset: 0x0002B2DC
	public override DynamicMetaObject BindDeleteIndex(DeleteIndexBinder 1, DynamicMetaObject[] 2)
	{
		640<TItem>.654 3 = new 640<TItem>.654();
		3._deleteIndexBinder7535 = 1;
		3._recoveredType16987536 = this;
		3._dynamicMetaObjectArray7537 = 2;
		if (!this.Method9573("TryDeleteIndex"))
		{
			return base.BindDeleteIndex(3._deleteIndexBinder7535, 3._dynamicMetaObjectArray7537);
		}
		return this.Method9582("TryDeleteIndex", 3._deleteIndexBinder7535, 640<TItem>.Method9576(3._dynamicMetaObjectArray7537), new 640<TItem>.649(3.Method9571));
	}

	// Token: 0x06000C8C RID: 3212 RVA: 0x0002D14C File Offset: 0x0002B34C
	private static Expression[] Method9574()
	{
		return 418.GetItemArray2540_3182<Expression>();
	}

	// Token: 0x06000C8D RID: 3213 RVA: 0x0002D153 File Offset: 0x0002B353
	private static IEnumerable<Expression> Method9575(DynamicMetaObject[] 1)
	{
		return 2.Select(delegate(DynamicMetaObject 1)
		{
			Expression expression = 1.Expression;
			if (expression.Type.Method6714())
			{
				return Expression.Convert(expression, typeof(object));
			}
			return expression;
		});
	}

	// Token: 0x06000C8E RID: 3214 RVA: 0x0002D17C File Offset: 0x0002B37C
	private static Expression[] Method9576(DynamicMetaObject[] 1)
	{
		return new NewArrayExpression[]
		{
			Expression.NewArrayInit(typeof(object), 640<TItem>.Method9575(1))
		};
	}

	// Token: 0x06000C8F RID: 3215 RVA: 0x0002D1AC File Offset: 0x0002B3AC
	private static Expression[] Method9576(DynamicMetaObject[] 1, DynamicMetaObject 2)
	{
		Expression expression = 2.Expression;
		return new Expression[]
		{
			Expression.NewArrayInit(typeof(object), 640<TItem>.Method9575(1)),
			expression.Type.Method6714() ? Expression.Convert(expression, typeof(object)) : expression
		};
	}

	// Token: 0x06000C90 RID: 3216 RVA: 0x0002D204 File Offset: 0x0002B404
	private static ConstantExpression Method9578(DynamicMetaObjectBinder 1)
	{
		Type type = 1.GetType();
		while (!type.Method6713())
		{
			type = type.Method6707();
		}
		return Expression.Constant(1, type);
	}

	// Token: 0x06000C91 RID: 3217 RVA: 0x0002D230 File Offset: 0x0002B430
	private DynamicMetaObject Method9579(string 1, DynamicMetaObjectBinder 2, IEnumerable<Expression> 3, [241(new byte[]
	{
		1,
		0
	})] 640<TItem>.649 4, [241(new byte[]
	{
		2,
		0
	})] 640<TItem>.649 5)
	{
		DynamicMetaObject 6 = 4(null);
		return this.Method9580(1, 2, 3, 6, 5);
	}

	// Token: 0x06000C92 RID: 3218 RVA: 0x0002D254 File Offset: 0x0002B454
	private DynamicMetaObject Method9580(string 1, DynamicMetaObjectBinder 2, IEnumerable<Expression> 3, DynamicMetaObject 4, [241(new byte[]
	{
		2,
		0
	})] 640<TItem>.649 5)
	{
		ParameterExpression parameterExpression = Expression.Parameter(typeof(object), null);
		IList<Expression> list = new List<Expression>();
		list.Add(Expression.Convert(base.Expression, typeof(TItem)));
		list.Add(640<TItem>.Method9578(2));
		list.Method3166(3);
		list.Add(parameterExpression);
		DynamicMetaObject dynamicMetaObject = new DynamicMetaObject(parameterExpression, BindingRestrictions.Empty);
		if (2.ReturnType != typeof(object))
		{
			dynamicMetaObject = new DynamicMetaObject(Expression.Convert(dynamicMetaObject.Expression, 2.ReturnType), dynamicMetaObject.Restrictions);
		}
		if (5 != null)
		{
			dynamicMetaObject = 5(dynamicMetaObject);
		}
		return new DynamicMetaObject(Expression.Block(new ParameterExpression[]
		{
			parameterExpression
		}, new Expression[]
		{
			Expression.Condition(Expression.Call(Expression.Constant(this._recoveredType16067540), typeof(625<TItem>).GetMethod(1), list), dynamicMetaObject.Expression, 4.Expression, 2.ReturnType)
		}), this.Method9583().Merge(dynamicMetaObject.Restrictions).Merge(4.Restrictions));
	}

	// Token: 0x06000C93 RID: 3219 RVA: 0x0002D370 File Offset: 0x0002B570
	private DynamicMetaObject Method9581(string 1, DynamicMetaObjectBinder 2, IEnumerable<Expression> 3, [241(new byte[]
	{
		1,
		0
	})] 640<TItem>.649 4)
	{
		DynamicMetaObject dynamicMetaObject = 4(null);
		ParameterExpression parameterExpression = Expression.Parameter(typeof(object), null);
		IList<Expression> list = new List<Expression>();
		list.Add(Expression.Convert(base.Expression, typeof(TItem)));
		list.Add(640<TItem>.Method9578(2));
		list.Method3166(3);
		list[list.Count - 1] = Expression.Assign(parameterExpression, list[list.Count - 1]);
		return new DynamicMetaObject(Expression.Block(new ParameterExpression[]
		{
			parameterExpression
		}, new Expression[]
		{
			Expression.Condition(Expression.Call(Expression.Constant(this._recoveredType16067540), typeof(625<TItem>).GetMethod(1), list), parameterExpression, dynamicMetaObject.Expression, typeof(object))
		}), this.Method9583().Merge(dynamicMetaObject.Restrictions));
	}

	// Token: 0x06000C94 RID: 3220 RVA: 0x0002D454 File Offset: 0x0002B654
	private DynamicMetaObject Method9582(string 1, DynamicMetaObjectBinder 2, Expression[] 3, [241(new byte[]
	{
		1,
		0
	})] 640<TItem>.649 4)
	{
		DynamicMetaObject dynamicMetaObject = 4(null);
		IList<Expression> list = new List<Expression>();
		list.Add(Expression.Convert(base.Expression, typeof(TItem)));
		list.Add(640<TItem>.Method9578(2));
		list.Method3166(3);
		return new DynamicMetaObject(Expression.Condition(Expression.Call(Expression.Constant(this._recoveredType16067540), typeof(625<TItem>).GetMethod(1), list), Expression.Empty(), dynamicMetaObject.Expression, typeof(void)), this.Method9583().Merge(dynamicMetaObject.Restrictions));
	}

	// Token: 0x06000C95 RID: 3221 RVA: 0x0002D4EF File Offset: 0x0002B6EF
	private BindingRestrictions Method9583()
	{
		if (base.Value != null || !base.HasValue)
		{
			return BindingRestrictions.GetTypeRestriction(base.Expression, base.LimitType);
		}
		return BindingRestrictions.GetInstanceRestriction(base.Expression, null);
	}

	// Token: 0x06000C96 RID: 3222 RVA: 0x0002D51F File Offset: 0x0002B71F
	public override IEnumerable<string> GetDynamicMemberNames()
	{
		return this._recoveredType16067540.Method14252((TItem)((object)base.Value));
	}

	// Token: 0x04000616 RID: 1558
	private readonly 625<TItem> _recoveredType16067540;

	// Token: 0x0200017A RID: 378
	public sealed class 641
	{
		// Token: 0x06000C97 RID: 3223 RVA: 0x0002D537 File Offset: 0x0002B737
		internal DynamicMetaObject Method9559([241(2)] DynamicMetaObject 1)
		{
			return this._createInstanceBinder7505.FallbackCreateInstance(this._recoveredType16987506, this._dynamicMetaObjectArray7507, 1);
		}

		// Token: 0x04000617 RID: 1559
		[241(0)]
		public CreateInstanceBinder _createInstanceBinder7505;

		// Token: 0x04000618 RID: 1560
		[241(0)]
		public 640<TItem> _recoveredType16987506;

		// Token: 0x04000619 RID: 1561
		[241(new byte[]
		{
			0,
			1
		})]
		public DynamicMetaObject[] _dynamicMetaObjectArray7507;
	}

	// Token: 0x0200017B RID: 379
	public sealed class 642
	{
		// Token: 0x06000C99 RID: 3225 RVA: 0x0002D551 File Offset: 0x0002B751
		internal DynamicMetaObject Method9560([241(2)] DynamicMetaObject 1)
		{
			return this._invokeBinder7508.FallbackInvoke(this._recoveredType16987509, this._dynamicMetaObjectArray7510, 1);
		}

		// Token: 0x0400061A RID: 1562
		[241(0)]
		public InvokeBinder _invokeBinder7508;

		// Token: 0x0400061B RID: 1563
		[241(0)]
		public 640<TItem> _recoveredType16987509;

		// Token: 0x0400061C RID: 1564
		[241(new byte[]
		{
			0,
			1
		})]
		public DynamicMetaObject[] _dynamicMetaObjectArray7510;
	}

	// Token: 0x0200017C RID: 380
	public sealed class 643
	{
		// Token: 0x06000C9B RID: 3227 RVA: 0x0002D56B File Offset: 0x0002B76B
		internal DynamicMetaObject Method9561([241(2)] DynamicMetaObject 1)
		{
			return this._setIndexBinder7511.FallbackSetIndex(this._recoveredType16987512, this._dynamicMetaObjectArray7513, this._dynamicMetaObject7514, 1);
		}

		// Token: 0x0400061D RID: 1565
		[241(0)]
		public SetIndexBinder _setIndexBinder7511;

		// Token: 0x0400061E RID: 1566
		[241(0)]
		public 640<TItem> _recoveredType16987512;

		// Token: 0x0400061F RID: 1567
		[241(new byte[]
		{
			0,
			1
		})]
		public DynamicMetaObject[] _dynamicMetaObjectArray7513;

		// Token: 0x04000620 RID: 1568
		[241(0)]
		public DynamicMetaObject _dynamicMetaObject7514;
	}

	// Token: 0x0200017D RID: 381
	[Serializable]
	public sealed class 644
	{
		// Token: 0x06000C9D RID: 3229 RVA: 0x0002D58C File Offset: 0x0002B78C
		[242(0)]
		internal Expression Method9562(DynamicMetaObject 1)
		{
			Expression expression = 1.Expression;
			if (!expression.Type.Method6714())
			{
				return expression;
			}
			return Expression.Convert(expression, typeof(object));
		}

		// Token: 0x04000621 RID: 1569
		[241(0)]
		public static readonly 640<TItem>.644 _recoveredType17027515 = new 640<TItem>.644();

		// Token: 0x04000622 RID: 1570
		[241(0)]
		public static Func<DynamicMetaObject, Expression> _func7516;
	}

	// Token: 0x0200017E RID: 382
	public sealed class 645
	{
		// Token: 0x06000CA0 RID: 3232 RVA: 0x0002D5CB File Offset: 0x0002B7CB
		internal DynamicMetaObject Method9563([241(2)] DynamicMetaObject 1)
		{
			return this._binaryOperationBinder7517.FallbackBinaryOperation(this._recoveredType16987518, this._dynamicMetaObject7519, 1);
		}

		// Token: 0x04000623 RID: 1571
		[241(0)]
		public BinaryOperationBinder _binaryOperationBinder7517;

		// Token: 0x04000624 RID: 1572
		[241(0)]
		public 640<TItem> _recoveredType16987518;

		// Token: 0x04000625 RID: 1573
		[241(0)]
		public DynamicMetaObject _dynamicMetaObject7519;
	}

	// Token: 0x0200017F RID: 383
	public sealed class 646
	{
		// Token: 0x06000CA2 RID: 3234 RVA: 0x0002D5E5 File Offset: 0x0002B7E5
		internal DynamicMetaObject Method9564([241(2)] DynamicMetaObject 1)
		{
			return this._deleteMemberBinder7520.FallbackDeleteMember(this._recoveredType16987521, 1);
		}

		// Token: 0x04000626 RID: 1574
		[241(0)]
		public DeleteMemberBinder _deleteMemberBinder7520;

		// Token: 0x04000627 RID: 1575
		[241(0)]
		public 640<TItem> _recoveredType16987521;
	}

	// Token: 0x02000180 RID: 384
	[241(0)]
	public sealed class 647 : GetMemberBinder
	{
		// Token: 0x06000CA4 RID: 3236 RVA: 0x0002D5F9 File Offset: 0x0002B7F9
		internal 647(InvokeMemberBinder 1) : base(1.Name, 1.IgnoreCase)
		{
		}

		// Token: 0x06000CA5 RID: 3237 RVA: 0x00005BE8 File Offset: 0x00003DE8
		public override DynamicMetaObject FallbackGetMember(DynamicMetaObject 1, [241(2)] DynamicMetaObject 2)
		{
			throw new NotSupportedException();
		}
	}

	// Token: 0x02000181 RID: 385
	public sealed class 648
	{
		// Token: 0x06000CA6 RID: 3238 RVA: 0x0002D60D File Offset: 0x0002B80D
		internal DynamicMetaObject Method9565([241(2)] DynamicMetaObject 1)
		{
			return this._unaryOperationBinder7522.FallbackUnaryOperation(this._recoveredType16987523, 1);
		}

		// Token: 0x04000628 RID: 1576
		[241(0)]
		public UnaryOperationBinder _unaryOperationBinder7522;

		// Token: 0x04000629 RID: 1577
		[241(0)]
		public 640<TItem> _recoveredType16987523;
	}

	// Token: 0x02000182 RID: 386
	// (Invoke) Token: 0x06000CA9 RID: 3241
	[242(0)]
	public delegate DynamicMetaObject 649([241(2)] DynamicMetaObject 1);

	// Token: 0x02000183 RID: 387
	public sealed class 650
	{
		// Token: 0x06000CAC RID: 3244 RVA: 0x0002D621 File Offset: 0x0002B821
		internal DynamicMetaObject Method9566([241(2)] DynamicMetaObject 1)
		{
			return this._getIndexBinder7524.FallbackGetIndex(this._recoveredType16987525, this._dynamicMetaObjectArray7526, 1);
		}

		// Token: 0x0400062A RID: 1578
		[241(0)]
		public GetIndexBinder _getIndexBinder7524;

		// Token: 0x0400062B RID: 1579
		[241(0)]
		public 640<TItem> _recoveredType16987525;

		// Token: 0x0400062C RID: 1580
		[241(new byte[]
		{
			0,
			1
		})]
		public DynamicMetaObject[] _dynamicMetaObjectArray7526;
	}

	// Token: 0x02000184 RID: 388
	public sealed class 651
	{
		// Token: 0x06000CAE RID: 3246 RVA: 0x0002D63B File Offset: 0x0002B83B
		internal DynamicMetaObject Method9567([241(2)] DynamicMetaObject 1)
		{
			return this._setMemberBinder7527.FallbackSetMember(this._recoveredType16987528, this._dynamicMetaObject7529, 1);
		}

		// Token: 0x0400062D RID: 1581
		[241(0)]
		public SetMemberBinder _setMemberBinder7527;

		// Token: 0x0400062E RID: 1582
		[241(0)]
		public 640<TItem> _recoveredType16987528;

		// Token: 0x0400062F RID: 1583
		[241(0)]
		public DynamicMetaObject _dynamicMetaObject7529;
	}

	// Token: 0x02000185 RID: 389
	public sealed class 652
	{
		// Token: 0x06000CB0 RID: 3248 RVA: 0x0002D655 File Offset: 0x0002B855
		internal DynamicMetaObject Method9568([241(2)] DynamicMetaObject 1)
		{
			return this._invokeMemberBinder7530.FallbackInvokeMember(this._recoveredType16987531, this._dynamicMetaObjectArray7532, 1);
		}

		// Token: 0x06000CB1 RID: 3249 RVA: 0x0002D66F File Offset: 0x0002B86F
		internal DynamicMetaObject Method9569([241(2)] DynamicMetaObject 1)
		{
			return this._invokeMemberBinder7530.FallbackInvoke(1, this._dynamicMetaObjectArray7532, null);
		}

		// Token: 0x04000630 RID: 1584
		[241(0)]
		public InvokeMemberBinder _invokeMemberBinder7530;

		// Token: 0x04000631 RID: 1585
		[241(0)]
		public 640<TItem> _recoveredType16987531;

		// Token: 0x04000632 RID: 1586
		[241(new byte[]
		{
			0,
			1
		})]
		public DynamicMetaObject[] _dynamicMetaObjectArray7532;
	}

	// Token: 0x02000186 RID: 390
	public sealed class 653
	{
		// Token: 0x06000CB3 RID: 3251 RVA: 0x0002D684 File Offset: 0x0002B884
		internal DynamicMetaObject Method9570([241(2)] DynamicMetaObject 1)
		{
			return this._getMemberBinder7533.FallbackGetMember(this._recoveredType16987534, 1);
		}

		// Token: 0x04000633 RID: 1587
		[241(0)]
		public GetMemberBinder _getMemberBinder7533;

		// Token: 0x04000634 RID: 1588
		[241(0)]
		public 640<TItem> _recoveredType16987534;
	}

	// Token: 0x02000187 RID: 391
	public sealed class 654
	{
		// Token: 0x06000CB5 RID: 3253 RVA: 0x0002D698 File Offset: 0x0002B898
		internal DynamicMetaObject Method9571([241(2)] DynamicMetaObject 1)
		{
			return this._deleteIndexBinder7535.FallbackDeleteIndex(this._recoveredType16987536, this._dynamicMetaObjectArray7537, 1);
		}

		// Token: 0x04000635 RID: 1589
		[241(0)]
		public DeleteIndexBinder _deleteIndexBinder7535;

		// Token: 0x04000636 RID: 1590
		[241(0)]
		public 640<TItem> _recoveredType16987536;

		// Token: 0x04000637 RID: 1591
		[241(new byte[]
		{
			0,
			1
		})]
		public DynamicMetaObject[] _dynamicMetaObjectArray7537;
	}

	// Token: 0x02000188 RID: 392
	public sealed class 655
	{
		// Token: 0x06000CB7 RID: 3255 RVA: 0x0002D6B2 File Offset: 0x0002B8B2
		internal DynamicMetaObject Method9572([241(2)] DynamicMetaObject 1)
		{
			return this._convertBinder7538.FallbackConvert(this._recoveredType16987539, 1);
		}

		// Token: 0x04000638 RID: 1592
		[241(0)]
		public ConvertBinder _convertBinder7538;

		// Token: 0x04000639 RID: 1593
		[241(0)]
		public 640<TItem> _recoveredType16987539;
	}
}
