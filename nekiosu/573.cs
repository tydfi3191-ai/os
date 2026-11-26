using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

// Token: 0x02000248 RID: 584
[241(0)]
[242(1)]
public static class 573
{
	// Token: 0x060011F0 RID: 4592 RVA: 0x000415EC File Offset: 0x0003F7EC
	internal static bool Method7896(Type 1, Type 2, [239(true)] [241(2)] out Type 3, [239(true)] [241(new byte[]
	{
		2,
		1
	})] out 516<object> 4)
	{
		if (8.Method6705())
		{
			573.575 5 = new 573.575();
			Type genericTypeDefinition = 8.GetGenericTypeDefinition();
			5.text = genericTypeDefinition.FullName;
			573.576 6 = 573.iList.FirstOrDefault(new Func<573.576, bool>(5.Method7886));
			if (6 != null)
			{
				Type type = genericTypeDefinition.Method6708().GetType(6.GetText6106_7891());
				Type type2 = genericTypeDefinition.Method6708().GetType(6.GetText6107_7893());
				if (type != null && type2 != null)
				{
					MethodInfo methodInfo = type2.GetMethods().FirstOrDefault((MethodInfo 1) => 1.Name == "CreateRange" && 1.GetParameters().Length == 1);
					if (methodInfo != null)
					{
						3 = type.MakeGenericType(new Type[]
						{
							2
						});
						MethodInfo 7 = methodInfo.MakeGenericMethod(new Type[]
						{
							2
						});
						4 = 170.GetReflectionDelegateFactory().Method9974(7);
						return true;
					}
				}
			}
		}
		3 = null;
		4 = null;
		return false;
	}

	// Token: 0x060011F1 RID: 4593 RVA: 0x000416E8 File Offset: 0x0003F8E8
	internal static bool Method7897(Type 1, Type 2, Type 3, [239(true)] [241(2)] out Type 4, [241(new byte[]
	{
		2,
		1
	})] [239(true)] out 516<object> 5)
	{
		if (9.Method6705())
		{
			573.577 6 = new 573.577();
			Type genericTypeDefinition = 9.GetGenericTypeDefinition();
			6.text = genericTypeDefinition.FullName;
			573.576 7 = 573.iList2.FirstOrDefault(new Func<573.576, bool>(6.Method7895));
			if (7 != null)
			{
				Type type = genericTypeDefinition.Method6708().GetType(7.GetText6106_7891());
				Type type2 = genericTypeDefinition.Method6708().GetType(7.GetText6107_7893());
				if (type != null && type2 != null)
				{
					MethodInfo methodInfo = type2.GetMethods().FirstOrDefault(delegate(MethodInfo 1)
					{
						ParameterInfo[] parameters = 1.GetParameters();
						return 1.Name == "CreateRange" && parameters.Length == 1 && parameters[0].ParameterType.Method6705() && parameters[0].ParameterType.GetGenericTypeDefinition() == typeof(IEnumerable<>);
					});
					if (methodInfo != null)
					{
						4 = type.MakeGenericType(new Type[]
						{
							2,
							3
						});
						MethodInfo 8 = methodInfo.MakeGenericMethod(new Type[]
						{
							2,
							3
						});
						5 = 170.GetReflectionDelegateFactory().Method9974(8);
						return true;
					}
				}
			}
		}
		4 = null;
		5 = null;
		return false;
	}

	// Token: 0x040008C9 RID: 2249
	private static readonly IList<573.576> iList = new List<573.576>
	{
		new 573.576("System.Collections.Immutable.IImmutableList`1", "System.Collections.Immutable.ImmutableList`1", "System.Collections.Immutable.ImmutableList"),
		new 573.576("System.Collections.Immutable.ImmutableList`1", "System.Collections.Immutable.ImmutableList`1", "System.Collections.Immutable.ImmutableList"),
		new 573.576("System.Collections.Immutable.IImmutableQueue`1", "System.Collections.Immutable.ImmutableQueue`1", "System.Collections.Immutable.ImmutableQueue"),
		new 573.576("System.Collections.Immutable.ImmutableQueue`1", "System.Collections.Immutable.ImmutableQueue`1", "System.Collections.Immutable.ImmutableQueue"),
		new 573.576("System.Collections.Immutable.IImmutableStack`1", "System.Collections.Immutable.ImmutableStack`1", "System.Collections.Immutable.ImmutableStack"),
		new 573.576("System.Collections.Immutable.ImmutableStack`1", "System.Collections.Immutable.ImmutableStack`1", "System.Collections.Immutable.ImmutableStack"),
		new 573.576("System.Collections.Immutable.IImmutableSet`1", "System.Collections.Immutable.ImmutableHashSet`1", "System.Collections.Immutable.ImmutableHashSet"),
		new 573.576("System.Collections.Immutable.ImmutableSortedSet`1", "System.Collections.Immutable.ImmutableSortedSet`1", "System.Collections.Immutable.ImmutableSortedSet"),
		new 573.576("System.Collections.Immutable.ImmutableHashSet`1", "System.Collections.Immutable.ImmutableHashSet`1", "System.Collections.Immutable.ImmutableHashSet"),
		new 573.576("System.Collections.Immutable.ImmutableArray`1", "System.Collections.Immutable.ImmutableArray`1", "System.Collections.Immutable.ImmutableArray")
	};

	// Token: 0x040008CA RID: 2250
	private static readonly IList<573.576> iList2 = new List<573.576>
	{
		new 573.576("System.Collections.Immutable.IImmutableDictionary`2", "System.Collections.Immutable.ImmutableDictionary`2", "System.Collections.Immutable.ImmutableDictionary"),
		new 573.576("System.Collections.Immutable.ImmutableSortedDictionary`2", "System.Collections.Immutable.ImmutableSortedDictionary`2", "System.Collections.Immutable.ImmutableSortedDictionary"),
		new 573.576("System.Collections.Immutable.ImmutableDictionary`2", "System.Collections.Immutable.ImmutableDictionary`2", "System.Collections.Immutable.ImmutableDictionary")
	};

	// Token: 0x02000249 RID: 585
	public sealed class 575
	{
		// Token: 0x060011F3 RID: 4595 RVA: 0x0004195F File Offset: 0x0003FB5F
		[242(0)]
		internal bool Method7886(573.576 1)
		{
			return 1.GetText6105_7889() == this.text;
		}

		// Token: 0x040008CB RID: 2251
		[241(0)]
		public string text;
	}

	// Token: 0x0200024A RID: 586
	[Serializable]
	public sealed class 574
	{
		// Token: 0x060011F5 RID: 4597 RVA: 0x00041972 File Offset: 0x0003FB72
		[242(0)]
		internal bool Method7887(MethodInfo 1)
		{
			return 1.Name == "CreateRange" && 1.GetParameters().Length == 1;
		}

		// Token: 0x060011F6 RID: 4598 RVA: 0x00041994 File Offset: 0x0003FB94
		[242(0)]
		internal bool Method7888(MethodInfo 1)
		{
			ParameterInfo[] parameters = 1.GetParameters();
			return 1.Name == "CreateRange" && parameters.Length == 1 && parameters[0].ParameterType.Method6705() && parameters[0].ParameterType.GetGenericTypeDefinition() == typeof(IEnumerable<>);
		}

		// Token: 0x040008CC RID: 2252
		[241(0)]
		public static readonly 573.574 instance = new 573.574();

		// Token: 0x040008CD RID: 2253
		[241(0)]
		public static Func<MethodInfo, bool> func;

		// Token: 0x040008CE RID: 2254
		[241(0)]
		public static Func<MethodInfo, bool> func2;
	}

	// Token: 0x0200024B RID: 587
	[241(0)]
	public sealed class 576
	{
		// Token: 0x060011F9 RID: 4601 RVA: 0x000419F9 File Offset: 0x0003FBF9
		public 576(string 1, string 2, string 3)
		{
			this.SetText6105_7890(1);
			this.SetText6106_7892(2);
			this.SetText6107_7894(3);
		}

		// Token: 0x060011FA RID: 4602 RVA: 0x00041A16 File Offset: 0x0003FC16
		public string GetText6105_7889()
		{
			return this.text4;
		}

		// Token: 0x060011FB RID: 4603 RVA: 0x00041A1E File Offset: 0x0003FC1E
		public void SetText6105_7890(string 1)
		{
			this.text4 = 1;
		}

		// Token: 0x060011FC RID: 4604 RVA: 0x00041A27 File Offset: 0x0003FC27
		public string GetText6106_7891()
		{
			return this.text5;
		}

		// Token: 0x060011FD RID: 4605 RVA: 0x00041A2F File Offset: 0x0003FC2F
		public void SetText6106_7892(string 1)
		{
			this.text5 = 1;
		}

		// Token: 0x060011FE RID: 4606 RVA: 0x00041A38 File Offset: 0x0003FC38
		public string GetText6107_7893()
		{
			return this.text6;
		}

		// Token: 0x060011FF RID: 4607 RVA: 0x00041A40 File Offset: 0x0003FC40
		public void SetText6107_7894(string 1)
		{
			this.text6 = 1;
		}

		// Token: 0x040008CF RID: 2255
		private string text4;

		// Token: 0x040008D0 RID: 2256
		private string text5;

		// Token: 0x040008D1 RID: 2257
		private string text6;
	}

	// Token: 0x0200024C RID: 588
	public sealed class 577
	{
		// Token: 0x06001200 RID: 4608 RVA: 0x00041A49 File Offset: 0x0003FC49
		[242(0)]
		internal bool Method7895(573.576 1)
		{
			return 1.GetText6105_7889() == this.text;
		}

		// Token: 0x040008D2 RID: 2258
		[241(0)]
		public string text;
	}
}
