using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using osu_ui;

// Token: 0x02000AD9 RID: 2777
public static class 1450
{
	// Token: 0x06004D42 RID: 19778 RVA: 0x001E935D File Offset: 0x001E755D
	private static bool 1(char 1)
	{
		return (1 >= '぀' && 1 <= 'ゟ') || (1 >= '゠' && 1 <= 'ヿ');
	}

	// Token: 0x06004D43 RID: 19779 RVA: 0x001E9388 File Offset: 0x001E7588
	private static bool 2(char 1)
	{
		return (1 >= '가' && 1 <= '힯') || (1 >= 'ᄀ' && 1 <= 'ᇿ') || (1 >= '㄰' && 1 <= '㆏') || (1 >= '㈀' && 1 <= '㋿') || (1 >= 'ꥠ' && 1 <= '꥿') || (1 >= 'ힰ' && 1 <= '퟿');
	}

	// Token: 0x06004D44 RID: 19780 RVA: 0x001E93FC File Offset: 0x001E75FC
	private static bool 3(char 1)
	{
		return (1 >= '一' && 1 <= '鿿') || (1 >= '㐀' && 1 <= '䷿') || ((int)1 >= 131072 && (int)1 <= 173791) || (1 >= '豈' && 1 <= '﫿') || ((int)1 >= 194560 && (int)1 <= 195103);
	}

	// Token: 0x06004D45 RID: 19781 RVA: 0x001E9460 File Offset: 0x001E7660
	private static bool 4(char 1)
	{
		return (1 >= 'Ѐ' && 1 <= 'ӿ') || (1 >= 'Ԁ' && 1 <= 'ԯ') || (1 >= 'ⷠ' && 1 <= 'ⷿ') || (1 >= 'Ꙁ' && 1 <= 'ꚟ');
	}

	// Token: 0x06004D46 RID: 19782 RVA: 0x001E94B4 File Offset: 0x001E76B4
	private static 1450.1451 5(string 1)
	{
		bool flag = false;
		foreach (char c in 1)
		{
			if (1450.1(c))
			{
				return (1450.1451)1;
			}
			if (1450.2(c))
			{
				return (1450.1451)2;
			}
			if (1450.4(c))
			{
				return (1450.1451)3;
			}
			flag |= 1450.3(c);
		}
		if (!flag)
		{
			return (1450.1451)0;
		}
		return (1450.1451)4;
	}

	// Token: 0x06004D47 RID: 19783 RVA: 0x001E950C File Offset: 0x001E770C
	internal static 1381 6(string 1, float 2, 208 3, 198 4, 1067 5, bool 6, bool 7, bool 8, 1066 9, bool 10, out 208 11, out RectangleF[] 12, 198 13, 198 14, int 15, bool 16, bool 17, 1068 18, 210 19, 208 20, 1381 21, int 22, int 23)
	{
		12 = null;
		if (1 == null)
		{
			11 = 208.Zero;
			return null;
		}
		if (1304.223)
		{
			11 = new 208((float)1.Length * 2, 2);
			return null;
		}
		object obj = 1450.3;
		1381 result;
		lock (obj)
		{
			try
			{
				using (Graphics graphics = Graphics.FromHwnd(IntPtr.Zero))
				{
					StringFormat stringFormat = new StringFormat();
					try
					{
						if (1450.6 == 0f)
						{
							1450.6 = 96f / graphics.DpiX;
						}
						2 *= 1450.6;
						1662.43.6(1056.NativeText);
						graphics.TextRenderingHint = TextRenderingHint.AntiAlias;
						string text = 1450.13(18);
						if (text.StartsWith("Aller"))
						{
							string text2 = 1450.10(1);
							if (text2 != null)
							{
								text = text2;
							}
						}
						if (22 != 0 || 23 > 0)
						{
							1 = 1.Substring(22, 23);
						}
						else if (23 == -1)
						{
							23 = 1.Length;
						}
						if (2 < 20f && text.EndsWith(" Light"))
						{
							text = text.Replace(" Light", string.Empty);
						}
						FontStyle fontStyle = FontStyle.Regular;
						if (6)
						{
							if (text.EndsWith(" Light"))
							{
								text = text.Replace(" Light", string.Empty);
							}
							fontStyle |= FontStyle.Bold;
						}
						if (7)
						{
							fontStyle |= FontStyle.Italic;
						}
						if (8)
						{
							fontStyle |= FontStyle.Underline;
						}
						switch (9)
						{
						case (1066)0:
						case (1066)1:
							stringFormat.Alignment = StringAlignment.Near;
							break;
						case (1066)2:
							stringFormat.Alignment = StringAlignment.Center;
							break;
						case (1066)3:
							stringFormat.Alignment = StringAlignment.Far;
							break;
						}
						if (!1181.1() && text.StartsWith("Aller"))
						{
							for (char c = '0'; c <= '9'; c += '\u0001')
							{
								1 = 1.Replace(c, c + '');
							}
						}
						Font font = 1450.12(text, 2 * 1450.7, fontStyle);
						if (1450.7 != 1f)
						{
							3 *= 1450.7;
						}
						SizeF sizeF;
						try
						{
							if (1.Length == 0)
							{
								1 = " ";
							}
							sizeF = ((3 != 208.Zero) ? graphics.MeasureString(1, font, new SizeF(3.X, 3.Y), stringFormat) : graphics.MeasureString(1, font));
						}
						catch (InvalidOperationException)
						{
							11 = 208.Zero;
							return null;
						}
						int num = (int)(sizeF.Width + 1f);
						int num2 = (int)(sizeF.Height + 1f);
						if (3.Y != 0f)
						{
							num2 = (int)3.Y;
						}
						if (3.X != 0f && (9 != (1066)0 || 13.A > 0))
						{
							num = (int)3.X;
						}
						if (20 != 208.Zero && 3 == 208.Zero)
						{
							num += (int)(20.X * 2f);
							num2 += (int)(20.Y * 2f);
						}
						11 = new 208((float)num, (float)num2);
						float num3 = Math.Max(0.5f, Math.Min(1f, 2 * 1450.7 / 14f));
						if (17)
						{
							12 = new RectangleF[1.Length];
							int num4 = 1.Length / 32 + 1;
							for (int i = 0; i < num4; i++)
							{
								int num5 = i * 32;
								int num6 = Math.Min(1.Length - num5, 32);
								CharacterRange[] array = new CharacterRange[num6];
								for (int j = 0; j < num6; j++)
								{
									array[j] = new CharacterRange(j + num5, 1);
								}
								stringFormat.SetMeasurableCharacterRanges(array);
								Region[] array2 = graphics.MeasureCharacterRanges(1, font, new RectangleF(20.X, 20.Y, (3.X == 0f) ? float.PositiveInfinity : 3.X, (3.Y == 0f) ? float.PositiveInfinity : 3.Y), stringFormat);
								for (int k = 0; k < num6; k++)
								{
									Region region = array2[k];
									12[k + num5] = region.GetBounds(graphics);
								}
							}
						}
						if (16)
						{
							int num7 = 0;
							int num8 = 0;
							int num9 = 0;
							while (num9 < 1.Length && 1[num9++] == ' ')
							{
								num7++;
							}
							int num10 = 1.Length - 1;
							while (num10 >= num9 && 1[num10--] == ' ')
							{
								num8++;
							}
							if (num7 == 1.Length)
							{
								num8 += num7;
							}
							11 = new 208((float)num + (float)num8 * 5.145f * 2 / 12f, (float)num2);
							result = null;
						}
						else
						{
							Bitmap bitmap = new Bitmap(num, num2, PixelFormat.Format32bppArgb);
							try
							{
								using (Graphics graphics2 = Graphics.FromImage(bitmap))
								{
									graphics2.TextRenderingHint = graphics.TextRenderingHint;
									graphics2.SmoothingMode = SmoothingMode.HighQuality;
									graphics2.InterpolationMode = InterpolationMode.HighQualityBicubic;
									if (13.A > 0)
									{
										if (19 != 210.GetZero())
										{
											1450.7(graphics2, new Rectangle(0, 0, num, num2), new SolidBrush(1052.4(13)), 19);
											if (15 > 0)
											{
												1450.8(graphics2, new Rectangle(0, 0, num - (int)Math.Ceiling((double)((float)15 / 2f)), num2 - (int)Math.Ceiling((double)((float)15 / 2f))), new Pen(1052.4(14), (float)15), 19);
											}
										}
										else
										{
											graphics2.Clear(1052.4(13));
											if (15 > 0)
											{
												graphics2.DrawRectangle(new Pen(1052.4(14), (float)15), new Rectangle(15 / 2, 15 / 2, num - 15, num2 - 15));
											}
										}
									}
									else
									{
										graphics2.Clear(Color.FromArgb(1, (int)4.R, (int)4.G, (int)4.B));
									}
									Brush brush = new SolidBrush(1052.4(4));
									try
									{
										if (3 != 208.Zero)
										{
											3.X -= 20.X * 2f;
											3.Y -= 20.Y * 2f;
											if (5 != (1067)1)
											{
												if (5 == (1067)2)
												{
													Brush brush2 = 1450.2;
													if (13.A == 0 && 15 == 1 && 14.A > 0)
													{
														brush2 = new SolidBrush(1052.4(14));
													}
													graphics2.DrawString(1, font, brush2, new RectangleF(20.X + num3, 20.Y + num3, 3.X, 3.Y), stringFormat);
													graphics2.DrawString(1, font, brush2, new RectangleF(20.X + num3, 20.Y - num3, 3.X, 3.Y), stringFormat);
													graphics2.DrawString(1, font, brush2, new RectangleF(20.X - num3, 20.Y + num3, 3.X, 3.Y), stringFormat);
													graphics2.DrawString(1, font, brush2, new RectangleF(20.X - num3, 20.Y - num3, 3.X, 3.Y), stringFormat);
												}
											}
											else
											{
												graphics2.DrawString(1, font, 1450.1, new RectangleF(20.X - num3, num3 + 20.Y, 3.X, 3.Y), stringFormat);
												graphics2.DrawString(1, font, 1450.1, new RectangleF(20.X + num3, num3 + 20.Y, 3.X, 3.Y), stringFormat);
											}
											graphics2.DrawString(1, font, brush, new RectangleF(20.X, 20.Y, 3.X, 3.Y), stringFormat);
										}
										else
										{
											if (5 != (1067)1)
											{
												if (5 == (1067)2)
												{
													Brush brush3 = 1450.2;
													if (13.A == 0 && 15 == 1 && 14.A > 0)
													{
														brush3 = new SolidBrush(1052.4(14));
													}
													graphics2.DrawString(1, font, brush3, 20.X + num3, 20.Y + num3);
													graphics2.DrawString(1, font, brush3, 20.X - num3, 20.Y + num3);
													graphics2.DrawString(1, font, brush3, 20.X + num3, 20.Y - num3);
													graphics2.DrawString(1, font, brush3, 20.X - num3, 20.Y - num3);
												}
											}
											else
											{
												graphics2.DrawString(1, font, 1450.1, 20.X - num3, 20.Y + num3);
												graphics2.DrawString(1, font, 1450.1, 20.X + num3, 20.Y + num3);
											}
											graphics2.DrawString(1, font, brush, 20.X, 20.Y);
										}
									}
									finally
									{
										((IDisposable)brush).Dispose();
									}
									21 = 1381.15(bitmap, null);
									21.11 = true;
									result = 21;
								}
							}
							finally
							{
								((IDisposable)bitmap).Dispose();
							}
						}
					}
					finally
					{
						((IDisposable)stringFormat).Dispose();
					}
				}
			}
			catch (Exception)
			{
				11 = 208.Zero;
				result = null;
			}
		}
		return result;
	}

	// Token: 0x06004D48 RID: 19784 RVA: 0x001E9F24 File Offset: 0x001E8124
	private static void 7(Graphics 1, Rectangle 2, Brush 3, 210 4)
	{
		using (GraphicsPath graphicsPath = 1450.9(2, 4))
		{
			1.FillPath(3, graphicsPath);
		}
	}

	// Token: 0x06004D49 RID: 19785 RVA: 0x001E9F60 File Offset: 0x001E8160
	private static void 8(Graphics 1, Rectangle 2, Pen 3, 210 4)
	{
		using (GraphicsPath graphicsPath = 1450.9(2, 4))
		{
			1.DrawPath(3, graphicsPath);
		}
	}

	// Token: 0x06004D4A RID: 19786 RVA: 0x001E9F9C File Offset: 0x001E819C
	private static GraphicsPath 9(Rectangle 1, 210 2)
	{
		GraphicsPath graphicsPath = new GraphicsPath();
		int num = (int)(2.W * 2f);
		graphicsPath.AddLine(1.Left + num, 1.Top, 1.Right - num, 1.Top);
		if (num > 0)
		{
			graphicsPath.AddArc(Rectangle.FromLTRB(1.Right - num, 1.Top, 1.Right, 1.Top + num), -90f, 90f);
		}
		num = (int)(2.X * 2f);
		graphicsPath.AddLine(1.Right, 1.Top + num, 1.Right, 1.Bottom - num);
		if (num > 0)
		{
			graphicsPath.AddArc(Rectangle.FromLTRB(1.Right - num, 1.Bottom - num, 1.Right, 1.Bottom), 0f, 90f);
		}
		num = (int)(2.Y * 2f);
		graphicsPath.AddLine(1.Right - num, 1.Bottom, 1.Left + num, 1.Bottom);
		if (num > 0)
		{
			graphicsPath.AddArc(Rectangle.FromLTRB(1.Left, 1.Bottom - num, 1.Left + num, 1.Bottom), 90f, 90f);
		}
		num = (int)(2.Z * 2f);
		graphicsPath.AddLine(1.Left, 1.Bottom - num, 1.Left, 1.Top + num);
		if (num > 0)
		{
			graphicsPath.AddArc(Rectangle.FromLTRB(1.Left, 1.Top, 1.Left + num, 1.Top + num), 180f, 90f);
		}
		graphicsPath.CloseFigure();
		return graphicsPath;
	}

	// Token: 0x06004D4B RID: 19787 RVA: 0x001EA16C File Offset: 0x001E836C
	private static string 10(string 1)
	{
		switch (1450.5(1))
		{
		case (1450.1451)1:
			return "Meiryo";
		case (1450.1451)2:
			return "Malgun Gothic";
		case (1450.1451)3:
			return "Tahoma";
		case (1450.1451)4:
		{
			string a = 1304.4;
			if (a == "zh-CHS")
			{
				return "Microsoft Yahei";
			}
			if (a == "zh-CHT")
			{
				return "Microsoft JhengHei";
			}
			if (a == "ja")
			{
				return "Meiryo";
			}
			if (!(a == "ko"))
			{
				return "Segoe UI";
			}
			return "Malgun Gothic";
		}
		default:
			return null;
		}
	}

	// Token: 0x06004D4C RID: 19788 RVA: 0x001EA20C File Offset: 0x001E840C
	internal static void 11()
	{
		foreach (Font font in 1450.5.Values)
		{
			font.Dispose();
		}
		1450.5.Clear();
	}

	// Token: 0x06004D4D RID: 19789 RVA: 0x001EA26C File Offset: 0x001E846C
	private static Font 12(string 1, float 2, FontStyle 3)
	{
		if (1.StartsWith("skin-"))
		{
			1 = 1.Replace("skin-", string.Empty);
			Font font = 2630.14(2, FontStyle.Regular);
			if (font != null)
			{
				return font;
			}
		}
		string str = 1;
		string str2 = 2.ToString();
		int num = (int)3;
		string key = str + str2 + num.ToString();
		Font font2;
		if (1450.5.TryGetValue(key, out font2))
		{
			return font2;
		}
		FontFamily fontFamily = 1450.16(1, 3);
		font2 = ((fontFamily == null) ? new Font(1, 2, 3) : new Font(fontFamily, 2, 3));
		return 1450.5[key] = font2;
	}

	// Token: 0x06004D4E RID: 19790 RVA: 0x001EA304 File Offset: 0x001E8504
	internal static string 13(1068 1)
	{
		string result;
		switch (1)
		{
		case (1068)1:
			result = "Aller";
			break;
		case (1068)2:
			result = "Tahoma";
			break;
		case (1068)3:
			result = "FontAwesome";
			break;
		case (1068)4:
			result = "Exo 2.0";
			break;
		case (1068)5:
			result = "Exo 2.0 Black";
			break;
		case (1068)6:
			result = "Exo 2.0 Extra Bold";
			break;
		case (1068)7:
			result = "Exo 2.0 Extra Light";
			break;
		case (1068)8:
			result = "Exo 2.0 Light";
			break;
		case (1068)9:
			result = "Exo 2.0 Medium";
			break;
		case (1068)10:
			result = "Exo 2.0 Semi Bold";
			break;
		case (1068)11:
			result = "Exo 2.0 Thin";
			break;
		case (1068)12:
			result = "skin-taiko";
			break;
		default:
			result = "Aller Light";
			break;
		}
		return result;
	}

	// Token: 0x06004D4F RID: 19791 RVA: 0x001EA3B4 File Offset: 0x001E85B4
	internal static void 14()
	{
		1450.15("FontAwesome", FontStyle.Regular);
		1450.15("Aller", FontStyle.Regular);
		1450.15("Aller_Lt", FontStyle.Regular);
		1450.15("Aller_Bd", FontStyle.Bold);
		1450.15("Exo2.0-Regular", FontStyle.Regular);
		1450.15("Exo2.0-Italic", FontStyle.Italic);
		1450.15("Exo2.0-Bold", FontStyle.Bold);
		1450.15("Exo2.0-BoldItalic", FontStyle.Bold | FontStyle.Italic);
		1450.15("Exo2.0-Black", FontStyle.Regular);
		1450.15("Exo2.0-BlackItalic", FontStyle.Italic);
		1450.15("Exo2.0-ExtraBold", FontStyle.Regular);
		1450.15("Exo2.0-ExtraBoldItalic", FontStyle.Italic);
		1450.15("Exo2.0-ExtraLight", FontStyle.Regular);
		1450.15("Exo2.0-ExtraLightItalic", FontStyle.Italic);
		1450.15("Exo2.0-Light", FontStyle.Regular);
		1450.15("Exo2.0-LightItalic", FontStyle.Italic);
		1450.15("Exo2.0-Medium", FontStyle.Regular);
		1450.15("Exo2.0-MediumItalic", FontStyle.Italic);
		1450.15("Exo2.0-SemiBold", FontStyle.Regular);
		1450.15("Exo2.0-SemiBoldItalic", FontStyle.Italic);
		1450.15("Exo2.0-Thin", FontStyle.Regular);
		1450.15("Exo2.0-ThinItalic", FontStyle.Italic);
	}

	// Token: 0x06004D50 RID: 19792 RVA: 0x001EA4B4 File Offset: 0x001E86B4
	private static void 15(string 1, FontStyle 2)
	{
		if (1.StartsWith("res:"))
		{
			1 = 1.Replace("res:", string.Empty);
		}
		PrivateFontCollection privateFontCollection = new PrivateFontCollection();
		try
		{
			byte[] array = (byte[])ResourcesStore.ResourceManager.GetObject(1);
			if (array != null && array.Length != 0)
			{
				GCHandle gchandle = GCHandle.Alloc(array, GCHandleType.Pinned);
				IntPtr memory = gchandle.AddrOfPinnedObject();
				privateFontCollection.AddMemoryFont(memory, array.Length);
				gchandle.Free();
			}
		}
		catch
		{
		}
		if (privateFontCollection.Families.Length != 0)
		{
			1047 item = new 1047
			{
				1 = privateFontCollection.Families[0],
				2 = 2
			};
			1450.4.Add(item);
		}
	}

	// Token: 0x06004D51 RID: 19793 RVA: 0x001EA56C File Offset: 0x001E876C
	private static FontFamily 16(string 1, FontStyle 2)
	{
		if (1.StartsWith("res:"))
		{
			1 = 1.Replace("res:", string.Empty);
		}
		FontFamily fontFamily = null;
		FontStyle fontStyle = FontStyle.Regular;
		foreach (1047 3 in 1450.4)
		{
			if (3.1.Name == 1 && (fontFamily == null || (3.2 & 2) > fontStyle))
			{
				fontFamily = 3.1;
				fontStyle = (3.2 & 2);
			}
		}
		return fontFamily;
	}

	// Token: 0x0400399C RID: 14748
	private static readonly Brush 1 = new SolidBrush(Color.FromArgb(100, 0, 0, 0));

	// Token: 0x0400399D RID: 14749
	private static readonly Brush 2 = new SolidBrush(Color.FromArgb(160, 20, 20, 20));

	// Token: 0x0400399E RID: 14750
	private static object 3 = new object();

	// Token: 0x0400399F RID: 14751
	private static List<1047> 4 = new List<1047>();

	// Token: 0x040039A0 RID: 14752
	private static Dictionary<string, Font> 5 = new Dictionary<string, Font>();

	// Token: 0x040039A1 RID: 14753
	private static float 6 = 0f;

	// Token: 0x040039A2 RID: 14754
	internal static float 7 = 1f;

	// Token: 0x02000ADA RID: 2778
	public enum 1451
	{

	}
}
