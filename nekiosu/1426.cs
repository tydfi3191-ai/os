using System;
using System.Collections.Generic;
using System.Text;
using OpenTK.Graphics.ES20;

// Token: 0x02000ABE RID: 2750
public sealed class 1426 : IDisposable
{
	// Token: 0x06004C4D RID: 19533 RVA: 0x001E20AC File Offset: 0x001E02AC
	internal 1426(string 1)
	{
		this.5 = 1;
		this.1 = new 2676(this);
	}

	// Token: 0x06004C4E RID: 19534 RVA: 0x001E20D9 File Offset: 0x001E02D9
	internal 1426(string 1, List<1061> 2) : this(1)
	{
		this.2(2);
	}

	// Token: 0x06004C4F RID: 19535 RVA: 0x001E20EC File Offset: 0x001E02EC
	~1426()
	{
		1662.89.Schedule(delegate()
		{
			this.1(false);
		}, false);
	}

	// Token: 0x06004C50 RID: 19536 RVA: 0x001E212C File Offset: 0x001E032C
	public void Dispose()
	{
		this.1(true);
		GC.SuppressFinalize(this);
	}

	// Token: 0x06004C51 RID: 19537 RVA: 0x001E213B File Offset: 0x001E033B
	protected void 1(bool 1)
	{
		if (this.3)
		{
			this.4();
			GL.DeleteProgram(this);
			this.3 = false;
			this.6 = -1;
			1426.9.Remove(this);
		}
	}

	// Token: 0x06004C52 RID: 19538 RVA: 0x001E2170 File Offset: 0x001E0370
	internal void 2(List<1061> 1)
	{
		1.RemoveAll(new Predicate<1061>(1426.1427.instance.1));
		this.1.4();
		this.2.Clear();
		if (this.6 != -1)
		{
			this.1(true);
		}
		if (1.Count == 0)
		{
			return;
		}
		this.6 = GL.CreateProgram();
		for (int i = 0; i < 1.Count; i++)
		{
			GL.AttachShader(this, 1[i]);
		}
		GL.BindAttribLocation(this, 0, "m_Position");
		GL.BindAttribLocation(this, 1, "m_Colour");
		GL.BindAttribLocation(this, 2, "m_TexCoord");
		GL.BindAttribLocation(this, 3, "m_Time");
		GL.BindAttribLocation(this, 4, "m_Direction");
		GL.LinkProgram(this);
		int num = 0;
		GL.GetProgram(this, 35714, ref num);
		string programInfoLog = GL.GetProgramInfoLog(this);
		this.2.AppendLine(string.Format("----------------------{0}", this.5));
		this.2.AppendLine(string.Format("Linked: {0}", num == 1));
		if (num == 0)
		{
			this.2.AppendLine("Log:");
			this.2.AppendLine(programInfoLog);
		}
		for (int j = 0; j < 1.Count; j++)
		{
			GL.DetachShader(this, 1[j]);
		}
		this.3 = (num == 1);
		if (!this.3)
		{
			return;
		}
		int num2 = 0;
		GL.GetProgram(this, 35718, ref num2);
		for (int k = 0; k < num2; k++)
		{
			int num3 = 0;
			int num4 = 0;
			StringBuilder stringBuilder = new StringBuilder(100);
			ActiveUniformType activeUniformType;
			GL.GetActiveUniform(this, k, 100, ref num4, ref num3, ref activeUniformType, stringBuilder);
			this.1.5(new 1063
			{
				1 = stringBuilder.ToString(),
				4 = GL.GetUniformLocation(this, stringBuilder.ToString()),
				2 = 1063.2(activeUniformType.ToString()),
				5 = activeUniformType
			});
		}
		foreach (KeyValuePair<string, object> keyValuePair in 1426.10)
		{
			if (this.1.6(keyValuePair.Key))
			{
				this.1[keyValuePair.Key] = keyValuePair.Value;
			}
		}
		1426.9.Add(this);
	}

	// Token: 0x06004C53 RID: 19539 RVA: 0x001E2430 File Offset: 0x001E0630
	internal void 3()
	{
		if (!this.4 && this.3)
		{
			GL.UseProgram(this);
			this.7 = 1426.8;
			1426.8 = this;
			this.1.3();
			this.4 = true;
		}
	}

	// Token: 0x06004C54 RID: 19540 RVA: 0x001E2480 File Offset: 0x001E0680
	internal void 4()
	{
		if (this.4)
		{
			GL.UseProgram(this.7);
			1426.8 = this.7;
			this.4 = false;
		}
	}

	// Token: 0x06004C55 RID: 19541 RVA: 0x001E24A8 File Offset: 0x001E06A8
	public static void 5(string 1, object 2)
	{
		1426.10[1] = 2;
		for (int i = 0; i < 1426.9.Count; i++)
		{
			if (1426.9[i].1.6(1))
			{
				1426.9[i].1[1] = 2;
			}
		}
	}

	// Token: 0x06004C56 RID: 19542 RVA: 0x001E2505 File Offset: 0x001E0705
	public static implicit operator int(1426 1)
	{
		return 1.6;
	}

	// Token: 0x040038C5 RID: 14533
	internal 2676 1;

	// Token: 0x040038C6 RID: 14534
	internal StringBuilder 2 = new StringBuilder();

	// Token: 0x040038C7 RID: 14535
	internal bool 3;

	// Token: 0x040038C8 RID: 14536
	internal bool 4;

	// Token: 0x040038C9 RID: 14537
	private string 5;

	// Token: 0x040038CA RID: 14538
	private int 6 = -1;

	// Token: 0x040038CB RID: 14539
	private int 7;

	// Token: 0x040038CC RID: 14540
	private static int 8 = 0;

	// Token: 0x040038CD RID: 14541
	private static List<1426> 9 = new List<1426>();

	// Token: 0x040038CE RID: 14542
	private static Dictionary<string, object> 10 = new Dictionary<string, object>();

	// Token: 0x02000ABF RID: 2751
	[Serializable]
	public sealed class 1427
	{
		// Token: 0x06004C59 RID: 19545 RVA: 0x001E2532 File Offset: 0x001E0732
		internal bool 1(1061 1)
		{
			return 1 == null;
		}

		// Token: 0x040038CF RID: 14543
		public static readonly 1426.1427 instance = new 1426.1427();

		// Token: 0x040038D0 RID: 14544
		public static Predicate<1061> predicate;
	}
}
