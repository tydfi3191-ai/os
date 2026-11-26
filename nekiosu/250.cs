using System;
using System.IO;
using System.Reflection;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;

// Token: 0x020003CA RID: 970
public static class 250
{
	// Token: 0x06001ED7 RID: 7895
	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool SetProcessInformation(IntPtr 1, int 2, ref 250.251 3, int 4);

	// Token: 0x06001ED8 RID: 7896
	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	// Token: 0x06001ED9 RID: 7897 RVA: 0x000784CB File Offset: 0x000766CB
	public static void 1()
	{
		250.2();
		250.4();
	}

	// Token: 0x06001EDA RID: 7898 RVA: 0x000784D8 File Offset: 0x000766D8
	private static void 2()
	{
		try
		{
			if (!250.3(5U))
			{
				250.3(1U);
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06001EDB RID: 7899 RVA: 0x0007850C File Offset: 0x0007670C
	private static bool 3(uint 1)
	{
		250.251 2 = new 250.251
		{
			1 = 1U,
			2 = 1,
			3 = 0U
		};
		return 250.SetProcessInformation(250.GetCurrentProcess(), 4, ref 2, Marshal.SizeOf(typeof(250.251)));
	}

	// Token: 0x06001EDC RID: 7900 RVA: 0x00078558 File Offset: 0x00076758
	private static void 4()
	{
		try
		{
			string text = (268.InstallDirectory != null) ? 268.CacheDirectory : Path.Combine(268.ExecutableDirectory ?? AppDomain.CurrentDomain.BaseDirectory, "Data", "nekiosu");
			Directory.CreateDirectory(text);
			ProfileOptimization.SetProfileRoot(text);
			ProfileOptimization.StartProfile("startup.jitprofile");
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06001EDD RID: 7901 RVA: 0x000785C0 File Offset: 0x000767C0
	internal static void 5(2039 1)
	{
		if (1 == null)
		{
			return;
		}
		if (1662.78 == 1677.Play)
		{
			try
			{
				foreach (string text in 250.4)
				{
					1381[] judgementTextures = 1.GetJudgementTextures(text);
					if (judgementTextures != null && judgementTextures.Length != 0 && judgementTextures[0] != null)
					{
						string[] array2 = new string[]
						{
							"particle50",
							"particle100",
							"particle300"
						};
						for (int j = 0; j < array2.Length; j++)
						{
							1455.2(array2[j], judgementTextures[0].6, null);
						}
					}
				}
				1455.2("lighting", (1416)7, null);
			}
			catch (Exception ex)
			{
				1338.4(ex, "loading the judgement graphics ahead", 1341.Runtime);
			}
		}
		if (Interlocked.Exchange(ref 250.6, 1) == 0)
		{
			ThreadStart start;
			if ((start = 250.<>O.<0>__CompileGameplayCodeSafely) == null)
			{
				start = (250.<>O.<0>__CompileGameplayCodeSafely = new ThreadStart(250.6));
			}
			new Thread(start)
			{
				IsBackground = true,
				Priority = ThreadPriority.BelowNormal,
				Name = "Gameplay code warm-up"
			}.Start();
		}
	}

	// Token: 0x06001EDE RID: 7902 RVA: 0x000786C8 File Offset: 0x000768C8
	private static void 6()
	{
		try
		{
			250.7();
		}
		catch (Exception ex)
		{
			1338.4(ex, "compiling the gameplay code ahead", 1341.Runtime);
		}
	}

	// Token: 0x06001EDF RID: 7903 RVA: 0x000786FC File Offset: 0x000768FC
	private static void 7()
	{
		Type[] types;
		try
		{
			types = typeof(250).Assembly.GetTypes();
		}
		catch (ReflectionTypeLoadException ex)
		{
			types = ex.Types;
		}
		foreach (Type type in types)
		{
			if (!(type == null) && !type.ContainsGenericParameters && !type.IsInterface && (250.9(type.Namespace) || type.IsDefined(typeof(276), false)))
			{
				MethodInfo[] methods = type.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
				for (int j = 0; j < methods.Length; j++)
				{
					250.8(methods[j]);
				}
				ConstructorInfo[] constructors = type.GetConstructors(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
				for (int j = 0; j < constructors.Length; j++)
				{
					250.8(constructors[j]);
				}
			}
		}
	}

	// Token: 0x06001EE0 RID: 7904 RVA: 0x000787DC File Offset: 0x000769DC
	private static void 8(MethodBase 1)
	{
		if (1.IsAbstract || 1.ContainsGenericParameters || (1.MethodImplementationFlags & MethodImplAttributes.InternalCall) != MethodImplAttributes.IL || 1.GetMethodBody() == null)
		{
			return;
		}
		try
		{
			RuntimeHelpers.PrepareMethod(1.MethodHandle);
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06001EE1 RID: 7905 RVA: 0x00078834 File Offset: 0x00076A34
	private static bool 9(string 1)
	{
		if (1 == null)
		{
			return false;
		}
		foreach (string text in 250.5)
		{
			if (1 == text || 1.StartsWith(text + ".", StringComparison.Ordinal))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x04000FD4 RID: 4052
	private const int 1 = 4;

	// Token: 0x04000FD5 RID: 4053
	private const uint 2 = 1U;

	// Token: 0x04000FD6 RID: 4054
	private const uint 3 = 4U;

	// Token: 0x04000FD7 RID: 4055
	private static readonly string[] 4 = new string[]
	{
		"hit0",
		"hit50",
		"hit100",
		"hit100k",
		"hit300",
		"hit300k",
		"hit300g"
	};

	// Token: 0x04000FD8 RID: 4056
	private static readonly string[] 5 = new string[]
	{
		"",
		"",
		"",
		"",
		""
	};

	// Token: 0x04000FD9 RID: 4057
	private static int 6;

	// Token: 0x020003CB RID: 971
	private struct 251
	{
		// Token: 0x04000FDA RID: 4058
		public uint 1;

		// Token: 0x04000FDB RID: 4059
		public uint 2;

		// Token: 0x04000FDC RID: 4060
		public uint 3;
	}

	// Token: 0x020003CC RID: 972
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04000FDD RID: 4061
		public static ThreadStart <0>__CompileGameplayCodeSafely;
	}
}
