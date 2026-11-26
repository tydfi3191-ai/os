using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using OpenTK.Graphics.ES20;
using osu_ui;

// Token: 0x02000C68 RID: 3176
public sealed class 1061 : IDisposable
{
	// Token: 0x060054C7 RID: 21703 RVA: 0x0020FE44 File Offset: 0x0020E044
	internal 1061(string 1, byte[] 2, ShaderType 3)
	{
		this.2 = 4;
		this.5 = 3;
		this.7.Add(this.1(2));
		this.7.RemoveAll((string 1) => string.IsNullOrEmpty(1));
		if (this.7.Count != 0)
		{
			this.3 = true;
		}
	}

	// Token: 0x060054C8 RID: 21704 RVA: 0x0020FEE4 File Offset: 0x0020E0E4
	private string 1(byte[] 1)
	{
		if (1 == null)
		{
			return null;
		}
		MemoryStream memoryStream = new MemoryStream(1);
		string result;
		try
		{
			StreamReader streamReader = new StreamReader(memoryStream);
			try
			{
				string text = string.Empty;
				while (streamReader.Peek() != -1)
				{
					string text2 = streamReader.ReadLine();
					Match match = this.8.Match(text2);
					if (match.Success)
					{
						string text3 = match.Groups[1].Value.Trim();
						this.7.Add(this.1(ResourcesStore.ResourceManager.GetObject(text3.Replace('.', '_')) as byte[]));
					}
					else
					{
						text = text + "\n" + text2;
					}
				}
				result = text;
			}
			finally
			{
				((IDisposable)streamReader).Dispose();
			}
		}
		finally
		{
			((IDisposable)memoryStream).Dispose();
		}
		return result;
	}

	// Token: 0x060054C9 RID: 21705 RVA: 0x0020FFB8 File Offset: 0x0020E1B8
	internal bool 2()
	{
		if (!this.3)
		{
			return false;
		}
		if (this.6 == -1)
		{
			this.6 = GL.CreateShader(this.5);
		}
		int[] array = new int[this.7.Count];
		for (int i = 0; i < this.7.Count; i++)
		{
			array[i] = this.7[i].Length;
		}
		GL.ShaderSource(this, this.7.Count, this.7.ToArray(), array);
		GL.CompileShader(this);
		int num = 0;
		GL.GetShader(this, 35713, ref num);
		this.4 = (num == 1);
		GL.GetShaderInfoLog(this);
		if (!this.4)
		{
			this.3(true);
		}
		return this.4;
	}

	// Token: 0x060054CA RID: 21706 RVA: 0x00210090 File Offset: 0x0020E290
	public static implicit operator int(1061 1)
	{
		return 1.6;
	}

	// Token: 0x060054CB RID: 21707 RVA: 0x00210098 File Offset: 0x0020E298
	public void Dispose()
	{
		this.3(true);
		GC.SuppressFinalize(this);
	}

	// Token: 0x060054CC RID: 21708 RVA: 0x002100A7 File Offset: 0x0020E2A7
	protected void 3(bool 1)
	{
		if (1 && this.6 != -1)
		{
			GL.DeleteShader(this);
			this.4 = false;
			this.6 = -1;
		}
	}

	// Token: 0x04004312 RID: 17170
	internal StringBuilder 1 = new StringBuilder();

	// Token: 0x04004313 RID: 17171
	internal string 2;

	// Token: 0x04004314 RID: 17172
	internal bool 3;

	// Token: 0x04004315 RID: 17173
	internal bool 4;

	// Token: 0x04004316 RID: 17174
	internal ShaderType 5;

	// Token: 0x04004317 RID: 17175
	private int 6 = -1;

	// Token: 0x04004318 RID: 17176
	private List<string> 7 = new List<string>();

	// Token: 0x04004319 RID: 17177
	private Regex 8 = new Regex("^\\s*#\\s*include\\s+[\"<](.*)[\">]");

	// Token: 0x02000C69 RID: 3177
	[Serializable]
	public sealed class 1062
	{
		// Token: 0x0400431A RID: 17178
		public static readonly 1061.1062 instance = new 1061.1062();

		// Token: 0x0400431B RID: 17179
		public static Predicate<string> predicate;
	}
}
