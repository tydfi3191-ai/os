using System;
using System.Collections.Generic;
using System.IO;

// Token: 0x02000596 RID: 1430
public sealed class 2296 : 2254
{
	// Token: 0x06002BF3 RID: 11251 RVA: 0x0001905A File Offset: 0x0001725A
	public override 2277 _0005_2005_2000_200A_2003_2005_2004_2004_2005_2003_2000()
	{
		return 2277.Design;
	}

	// Token: 0x06002BF4 RID: 11252 RVA: 0x000F0E25 File Offset: 0x000EF025
	protected override void _000E_2000_2004_2001_2006_2006_2000_2005_2007_2009_2007_2000_2005_200B_200A_2004_2007_2002_2003_2001_2003_2005_200A_2007_200B(2046 1)
	{
		this.1();
	}

	// Token: 0x06002BF5 RID: 11253 RVA: 0x000F0E30 File Offset: 0x000EF030
	protected new void 1()
	{
		2648 <<EMPTY_NAME>> = 2263.4.6;
		if (<<EMPTY_NAME>>.4 == null)
		{
			this.1.Add(new 2278(-1, (2341)2, 1568.1(2679.AIDesign_NoBackgroundImage), -1, () => 2263.4.6.4 != null));
		}
		else if (<<EMPTY_NAME>>.4.7 != null)
		{
			int 2 = <<EMPTY_NAME>>.4.7.39;
			int 3 = <<EMPTY_NAME>>.4.7.38;
			if (2 > 2560 || 3 > 1440)
			{
				this.1.Add(new 2278((2341)1, 1568.1(2679.AIDesign_BackgroundTooLarge)));
			}
		}
		if (<<EMPTY_NAME>>.30.Count > 0)
		{
			foreach (1447 4 in <<EMPTY_NAME>>.30)
			{
				if (4.39 > 1280 && 4.38 > 720)
				{
					this.1.Add(new 2278((2341)1, 1568.1(2679.AIDesign_VideoDimensionsTooLargeWidescreen)));
				}
				else if (4.39 > 1024 && 4.38 > 768)
				{
					this.1.Add(new 2278((2341)1, 1568.1(2679.AIDesign_VideoDimensionsTooLarge)));
				}
			}
		}
		if (!1272.5().106)
		{
			if (<<EMPTY_NAME>>.14.FindAll((2647 1) => 1.1 - 1.8 < 100 && 1.10 != 2635.Sample).Count > 5)
			{
				this.1.Add(new 2278((2341)1, 1568.1(2679.AIDesign_EpilepsyWarning)));
			}
		}
		this.2();
	}

	// Token: 0x06002BF6 RID: 11254 RVA: 0x000F1004 File Offset: 0x000EF204
	private void 2()
	{
		string[] files = Directory.GetFiles(1272.5().44(), "*", SearchOption.AllDirectories);
		Dictionary<string, bool> dictionary = new Dictionary<string, bool>(files.Length);
		foreach (string <<EMPTY_NAME>> in files)
		{
			if (2672.24(<<EMPTY_NAME>>) == (2670)12)
			{
				string text = 2672.17(2672.33(<<EMPTY_NAME>>, 1272.5().44()));
				string key = text.ToLower();
				dictionary[key] = true;
				int num = 1;
				string text2 = text;
				if (text2.Contains("@2x"))
				{
					num = 2;
					text2 = text2.Replace("@2x", string.Empty);
				}
				string a = text2.ToLower();
				if (a == "hitcircle" || a == "hitcircleoverlay" || a == "approachcircle" || a == "reversearrow")
				{
					1381 2 = 1455.2(text, (1416)4, null);
					if (2 != null && (2.3() != 128 * num || 2.4() != 128 * num))
					{
						this.3(text, 128 * num);
					}
				}
			}
		}
		2648 3 = 2263.4.6;
		for (int j = 0; j < 3.26.Length; j++)
		{
			for (int k = 0; k < 3.26[j].Count; k++)
			{
				string 4 = 3.26[j][k].3;
				string text3 = 4.ToLower();
				if (!dictionary.ContainsKey(text3))
				{
					if (1272.5().88)
					{
						if (1455.2(4, (1416)5, null) != null)
						{
							goto IL_1F0;
						}
						if (1455.5(4, (1416)5, false) != null)
						{
							goto IL_1F0;
						}
					}
					else
					{
						int num2 = 4.LastIndexOf('.');
						if (num2 >= 0 && dictionary.ContainsKey(text3.Insert(num2, "0")) && dictionary.ContainsKey(text3.Insert(num2, "1")))
						{
							goto IL_1F0;
						}
					}
					dictionary[text3] = true;
					this.1.Add(new 2278((2341)2, 1568.1(2679.AIDesign_FileMissing) + 4));
				}
				IL_1F0:;
			}
		}
	}

	// Token: 0x06002BF7 RID: 11255 RVA: 0x000F1231 File Offset: 0x000EF431
	private void 3(string 1, int 2)
	{
		this.1.Add(new 2278((2341)2, string.Format(1568.1(2679.AIDesign_IncorrectDimensions), 1, 2)));
	}

	// Token: 0x02000597 RID: 1431
	[Serializable]
	public sealed class 2297
	{
		// Token: 0x04002033 RID: 8243
		public static readonly 2296.2297 instance = new 2296.2297();

		// Token: 0x04002034 RID: 8244
		public static 2340 _recoveredType244410098;

		// Token: 0x04002035 RID: 8245
		public static Predicate<2647> flashingEventPredicate;
	}
}
