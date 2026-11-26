using System;
using System.Linq.Expressions;

// Token: 0x02000251 RID: 593
[242(1)]
[241(0)]
public sealed class 429 : ExpressionVisitor
{
	// Token: 0x0600120E RID: 4622 RVA: 0x00041D63 File Offset: 0x0003FF63
	protected override Expression VisitConditional(ConditionalExpression 1)
	{
		if (1.IfFalse.NodeType == ExpressionType.Throw)
		{
			return Expression.Condition(1.Test, 1.IfTrue, Expression.Constant(429.value));
		}
		return base.VisitConditional(1);
	}

	// Token: 0x040008DC RID: 2268
	internal static readonly object value = new object();
}
