using System;
using System.Reflection;
using System.Reflection.Emit;

// Token: 0x020001FF RID: 511
[241(0)]
[242(1)]
public static class 100
{
	// Token: 0x06001027 RID: 4135 RVA: 0x00037157 File Offset: 0x00035357
	public static void PushInstance(this ILGenerator 1, Type 2)
	{
		1.Emit(OpCodes.Ldarg_0);
		if (2.Method6714())
		{
			1.Emit(OpCodes.Unbox, 2);
			return;
		}
		1.Emit(OpCodes.Castclass, 2);
	}

	// Token: 0x06001028 RID: 4136 RVA: 0x00037185 File Offset: 0x00035385
	public static void PushArrayInstance(this ILGenerator 1, int 2, int 3)
	{
		1.Emit(OpCodes.Ldarg, 2);
		1.Emit(OpCodes.Ldc_I4, 3);
		1.Emit(OpCodes.Ldelem_Ref);
	}

	// Token: 0x06001029 RID: 4137 RVA: 0x000371AA File Offset: 0x000353AA
	public static void BoxIfNeeded(this ILGenerator 1, Type 2)
	{
		if (2.Method6714())
		{
			1.Emit(OpCodes.Box, 2);
			return;
		}
		1.Emit(OpCodes.Castclass, 2);
	}

	// Token: 0x0600102A RID: 4138 RVA: 0x000371CD File Offset: 0x000353CD
	public static void UnboxIfNeeded(this ILGenerator 1, Type 2)
	{
		if (2.Method6714())
		{
			1.Emit(OpCodes.Unbox_Any, 2);
			return;
		}
		1.Emit(OpCodes.Castclass, 2);
	}

	// Token: 0x0600102B RID: 4139 RVA: 0x000371F0 File Offset: 0x000353F0
	public static void CallMethod(this ILGenerator 1, MethodInfo 2)
	{
		if (2.IsFinal || !2.IsVirtual)
		{
			1.Emit(OpCodes.Call, 2);
			return;
		}
		1.Emit(OpCodes.Callvirt, 2);
	}

	// Token: 0x0600102C RID: 4140 RVA: 0x0003721B File Offset: 0x0003541B
	public static void Return(this ILGenerator 1)
	{
		1.Emit(OpCodes.Ret);
	}
}
