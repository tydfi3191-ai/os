using System;
using System.Collections.Generic;

// Token: 0x020008C9 RID: 2249
public sealed class 1791 : 1779
{
	// Token: 0x06004088 RID: 16520 RVA: 0x00190F0C File Offset: 0x0018F10C
	public 1791()
	{
		1433 <<EMPTY_NAME>> = new 1433(null, 208.Zero, (1416)7, 1065.Centre, (1376)6);
		<<EMPTY_NAME>>.10 = true;
		<<EMPTY_NAME>>.3(new EventHandler(this.21));
		this.1.12(<<EMPTY_NAME>>);
		this.20();
		base.3(new 208(244f, this.13));
		2630.2(new 1189(this.18));
	}

	// Token: 0x06004089 RID: 16521 RVA: 0x0019105E File Offset: 0x0018F25E
	public override void Dispose()
	{
		2630.3(new 1189(this.18));
		base.Dispose();
	}

	// Token: 0x0600408A RID: 16522 RVA: 0x00191077 File Offset: 0x0018F277
	private void 18()
	{
		this.20();
	}

	// Token: 0x0600408B RID: 16523 RVA: 0x0019107F File Offset: 0x0018F27F
	private void 19()
	{
		this.15 = (this.15 + 1) % this.16.Length;
		this.20();
	}

	// Token: 0x0600408C RID: 16524 RVA: 0x001910A0 File Offset: 0x0018F2A0
	private void 20()
	{
		foreach (1433 <<EMPTY_NAME>> in this.14)
		{
			<<EMPTY_NAME>>.16(100, (1046)0, 0);
			<<EMPTY_NAME>>.5 = false;
		}
		this.14.Clear();
		int num = this.16[this.15].Length;
		for (int i = 0; i < num; i++)
		{
			1791.1792 rowScale = new 1791.1792();
			rowScale.1 = 1f;
			List<1433> list = new List<1433>();
			float num2 = 0f;
			foreach (string text in this.16[this.15][i].Split(new char[]
			{
				'|'
			}))
			{
				198 white = 198.White;
				string text2 = text;
				if (text2.IndexOf('(') > 0)
				{
					int num3 = text2.IndexOf('(');
					text2 = text2.Remove(num3);
					string[] array2 = text.Substring(num3 + 1).TrimEnd(new char[]
					{
						')'
					}).Split(new char[]
					{
						','
					});
					white = new 198(byte.Parse(array2[0]), byte.Parse(array2[1]), byte.Parse(array2[2]));
				}
				text2 = text2.Replace("{default}", 2630.5.FontHitCircle);
				text2 = text2.Replace("{score}", 2630.5.FontScore);
				1433 2 = new 1433(text2, new 208((float)((i + 1) * 244 / (num + 1)), this.13 / 2f), (1416)3, 1065.Centre, (1376)6);
				float num4 = num2;
				num2 = num4 + 1f;
				2.2 = num4 / 100f;
				2.6 = white;
				1433 3 = 2;
				rowScale.1 = Math.Min(rowScale.1, Math.Min((float)(244 / (num + 1)) / ((float)3.35 / 1.6f), this.13 / ((float)3.34 / 1.6f)));
				list.Add(3);
				3.15(50);
			}
			list.ForEach(delegate(1433 1)
			{
				1.15 = rowScale.1;
			});
			this.14.AddRange(list);
			this.1.14<1433>(list);
		}
	}

	// Token: 0x0600408D RID: 16525 RVA: 0x0019131C File Offset: 0x0018F51C
	private void 21(object 1, EventArgs 2)
	{
		this.19();
	}

	// Token: 0x04002F32 RID: 12082
	private new float 13 = 80f;

	// Token: 0x04002F33 RID: 12083
	private new List<1433> 14 = new List<1433>();

	// Token: 0x04002F34 RID: 12084
	private new int 15;

	// Token: 0x04002F35 RID: 12085
	private string[][] 16 = new string[][]
	{
		new string[]
		{
			"hitcircle(0,78,155)|hitcircleoverlay|{default}-1",
			"hit50",
			"hit100",
			"hit300"
		},
		new string[]
		{
			"hit0",
			"hit100k",
			"hit300g"
		},
		new string[]
		{
			"{default}-0",
			"{default}-1",
			"{default}-2",
			"{default}-3",
			"{default}-4",
			"{default}-5"
		},
		new string[]
		{
			"{score}-0",
			"{score}-1",
			"{score}-2",
			"{score}-3",
			"{score}-4",
			"{score}-5"
		}
	};

	// Token: 0x020008CA RID: 2250
	public sealed class 1792
	{
		// Token: 0x04002F36 RID: 12086
		public float 1;
	}
}
