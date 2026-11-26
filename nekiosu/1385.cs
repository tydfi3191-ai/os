using System;
using System.Runtime.CompilerServices;
using System.Text;

// Token: 0x02000A96 RID: 2710
internal static class 1385
{
	// Token: 0x06004B22 RID: 19234 RVA: 0x001DC46D File Offset: 0x001DA66D
	private static bool 1()
	{
		return !1385.4 && 1662.78 == 1677.Play && 1379.19 && !2513.IsOpen && Math.Abs(1383.1() - 1.0) > 0.005;
	}

	// Token: 0x06004B23 RID: 19235 RVA: 0x001DC4B0 File Offset: 0x001DA6B0
	private static bool 2()
	{
		bool result;
		try
		{
			1415 <<EMPTY_NAME>> = 1385.2;
			if (<<EMPTY_NAME>> != null)
			{
				<<EMPTY_NAME>>.Dispose();
			}
			1385.2 = new 1415(1662.70.1, 1662.70.2, null);
			if (1385.3 == null)
			{
				1385.3 = 1425.5(1510.Texture2D, "Gamma", Encoding.UTF8.GetBytes("#ifdef GL_ES\n    precision mediump float;\n#endif\n\nvarying vec4 v_Colour;\nvarying vec2 v_TexCoord;\n\nuniform sampler2D m_Sampler;\nuniform float gamma;\n\nvoid main(void)\n{\n    vec4 colour = texture2D(m_Sampler, v_TexCoord);\n    gl_FragColor = vec4(pow(colour.rgb, vec3(1.0 / gamma)), 1.0);\n}\n"));
				if (!1385.3.3)
				{
					throw new InvalidOperationException("the gamma shader did not link");
				}
			}
			1189 2;
			if ((2 = 1385.<>O.<0>__OnResized) == null)
			{
				2 = (1385.<>O.<0>__OnResized = new 1189(1385.3));
			}
			1662.77(2);
			1189 3;
			if ((3 = 1385.<>O.<0>__OnResized) == null)
			{
				3 = (1385.<>O.<0>__OnResized = new 1189(1385.3));
			}
			1662.76(3);
			result = true;
		}
		catch (Exception ex)
		{
			1385.4 = true;
			1338.4(ex, "setting up gameplay gamma", 1341.Runtime);
			result = false;
		}
		return result;
	}

	// Token: 0x06004B24 RID: 19236 RVA: 0x001DC59C File Offset: 0x001DA79C
	private static void 3()
	{
		if (1385.2 != null)
		{
			1385.2();
		}
	}

	// Token: 0x06004B25 RID: 19237 RVA: 0x001DC5AB File Offset: 0x001DA7AB
	internal static void 4()
	{
		if (!1385.1() || (1385.2 == null && !1385.2()))
		{
			return;
		}
		1385.2.10();
		1385.5 = true;
	}

	// Token: 0x06004B26 RID: 19238 RVA: 0x001DC5D4 File Offset: 0x001DA7D4
	internal static void Apply()
	{
		if (!1385.5)
		{
			return;
		}
		1385.5 = false;
		1385.2.11();
		try
		{
			1379.35(1, 0);
			1385.3.3();
			1385.3.1["gamma"] = (float)Math.Max(0.1, Math.Min(3.0, 1383.1()));
			1385.2.5().Draw(208.Zero, 208.Zero, 198.White, new 208(1f, -1f), 0f, null, null);
			1385.3.4();
		}
		catch (Exception ex)
		{
			1385.4 = true;
			1338.4(ex, "drawing gameplay gamma", 1341.Runtime);
		}
		finally
		{
			1379.35(770, 771);
		}
	}

	// Token: 0x0400380F RID: 14351
	private const string 1 = "#ifdef GL_ES\n    precision mediump float;\n#endif\n\nvarying vec4 v_Colour;\nvarying vec2 v_TexCoord;\n\nuniform sampler2D m_Sampler;\nuniform float gamma;\n\nvoid main(void)\n{\n    vec4 colour = texture2D(m_Sampler, v_TexCoord);\n    gl_FragColor = vec4(pow(colour.rgb, vec3(1.0 / gamma)), 1.0);\n}\n";

	// Token: 0x04003810 RID: 14352
	private static 1415 2;

	// Token: 0x04003811 RID: 14353
	private static 1426 3;

	// Token: 0x04003812 RID: 14354
	private static bool 4;

	// Token: 0x04003813 RID: 14355
	private static bool 5;

	// Token: 0x02000A97 RID: 2711
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04003814 RID: 14356
		public static 1189 <0>__OnResized;
	}
}
