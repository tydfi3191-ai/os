using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

// Token: 0x02000581 RID: 1409
public sealed class 2272
{
	// Token: 0x06002BA5 RID: 11173 RVA: 0x000EE544 File Offset: 0x000EC744
	internal 2272(2263 1)
	{
		this.1 = 1;
		this.2 = (1.7 as 2028);
		this.3 = 1.6;
		this.9 = new Dictionary<string, string>();
		this.10 = new Dictionary<string, double>();
		this.11 = new Dictionary<string, bool>();
		this.12 = new Dictionary<string, bool>();
		this.13 = new List<2274>();
		this.15 = new List<string>();
		this.14 = new 2072[10];
	}

	// Token: 0x06002BA6 RID: 11174 RVA: 0x000EE5E8 File Offset: 0x000EC7E8
	public void Reset()
	{
		this.9.Clear();
		this.10.Clear();
		this.11.Clear();
		this.12.Clear();
		this.13.Clear();
		this.15.Clear();
	}

	// Token: 0x06002BA7 RID: 11175 RVA: 0x000EE638 File Offset: 0x000EC838
	internal bool 1(string 1, string 2)
	{
		1 = 2672.17(1);
		this.16 = Path.GetDirectoryName(1);
		1272.5().2 = 1f;
		try
		{
			FileStream fileStream = new FileStream(1, FileMode.Open);
			try
			{
				StreamReader streamReader = new StreamReader(fileStream, Encoding.GetEncoding(2));
				try
				{
					while (!streamReader.EndOfStream)
					{
						string text = streamReader.ReadLine();
						if (text.IndexOf('#') >= 0)
						{
							text = text.Substring(1);
							if (text.IndexOf(':') > 0)
							{
								string[] array = text.Split(new char[]
								{
									':'
								});
								if (array.Length == 2)
								{
									array[0] = array[0].Trim();
									array[1] = array[1].Trim();
									if (array[0].Length == 5)
									{
										if (!this.7(array))
										{
											this.15.Add(text);
											continue;
										}
										continue;
									}
								}
							}
							int num = text.IndexOf(' ');
							if (num > 0)
							{
								string[] array2 = new string[]
								{
									text.Substring(0, num).Trim().ToUpper(),
									text.Substring(num).Trim()
								};
								if (array2[0].StartsWith("BPM") && array2[0].Length == 5)
								{
									string key = array2[0].Substring(3, 2);
									this.10.Add(key, double.Parse(array2[1], 1662.18));
								}
								else if (array2[0].StartsWith("WAV") && array2[0].Length == 5)
								{
									string key2 = array2[0].Substring(3, 2);
									this.9.Add(key2, this.3(array2[1]));
								}
								else
								{
									string a = array2[0];
									uint num2 = 1197.1(a);
									if (num2 <= 1448407380U)
									{
										if (num2 <= 572932585U)
										{
											if (num2 != 564828971U)
											{
												if (num2 == 572932585U)
												{
													if (a == "TITLE" && this.7)
													{
														1272.5().10 = array2[1];
														1272.5().11 = array2[1];
													}
												}
											}
											else if (a == "STAGEFILE" && this.6)
											{
												1272.5().22 = array2[1];
												this.4(array2[1]);
											}
										}
										else if (num2 != 1256569747U)
										{
											if (num2 == 1448407380U)
											{
												if (a == "LNOBJ")
												{
													this.17 = array2[1];
												}
											}
										}
										else if (a == "PLAYLEVEL" && this.7)
										{
											1272.5().89 = "Lv." + array2[1];
										}
									}
									else if (num2 <= 2727826214U)
									{
										if (num2 != 1999365726U)
										{
											if (num2 == 2727826214U)
											{
												if (a == "BPM")
												{
													2274 3 = new 2274();
													3.4 = double.Parse(array2[1], 1662.18);
													this.13.Add(3);
												}
											}
										}
										else if (a == "ARTIST" && this.7)
										{
											1272.5().7 = array2[1];
											1272.5().8 = array2[1];
										}
									}
									else if (num2 != 2851012967U)
									{
										if (num2 != 3175681408U)
										{
											if (num2 == 4156219207U)
											{
												if (a == "LNTYPE")
												{
													this.18 = int.Parse(array2[1], 1662.18);
												}
											}
										}
										else if (a == "PLAYER" && int.Parse(array2[1]) != 1)
										{
											MessageBox.Show("Can not convert 2 player style bms file.");
											return false;
										}
									}
									else if (a == "RANK" && this.7)
									{
										int num3 = int.Parse(array2[1], 1662.18);
										1272.5().3 = (float)((byte)Math.Max(4, Math.Min(9, 9 - num3 * 2)));
										1272.5().4 = 1272.5().3;
									}
								}
							}
						}
					}
				}
				finally
				{
					((IDisposable)streamReader).Dispose();
				}
			}
			finally
			{
				((IDisposable)fileStream).Dispose();
			}
			this.13.Sort();
			this.2();
			byte b = (byte)Math.Round((double)1272.5().2);
			if ((b == 6 || b == 8) && !1272.5().91)
			{
				1272.5().2 = (float)(b - 1);
			}
			this.8 = !1272.5().91;
			for (int i = 0; i < this.15.Count; i++)
			{
				string[] array3 = this.15[i].Split(new char[]
				{
					':'
				});
				if (array3.Length == 2)
				{
					array3[0] = array3[0].Trim();
					array3[1] = array3[1].Trim();
					if (array3[0].Length == 5)
					{
						this.9(array3);
					}
				}
			}
			for (int j = 0; j < this.14.Length; j++)
			{
				if (this.14[j] != null)
				{
					throw new Exception("Something wrong with the bms");
				}
			}
			List<1259> list = new List<1259>(this.13.Count);
			for (int k = 0; k < this.13.Count; k++)
			{
				2274 4 = this.13[k];
				1259 item = new 1259((double)((int)4.3), 4.5 ? (60000.0 / 4.4) : -100.0, (1257)(4.6 * 4.0), 1254.None, 1253.Default, 70, 4.5, (1258)0);
				list.Add(item);
			}
			1226.82(list);
			if (!this.4)
			{
				foreach (KeyValuePair<string, bool> keyValuePair in this.11)
				{
					this.4(keyValuePair.Key);
				}
			}
			if (!this.5)
			{
				foreach (KeyValuePair<string, bool> keyValuePair2 in this.12)
				{
					this.4(keyValuePair2.Key);
				}
			}
		}
		catch (Exception)
		{
			MessageBox.Show("Convert failed");
			return false;
		}
		return true;
	}

	// Token: 0x06002BA8 RID: 11176 RVA: 0x000EED50 File Offset: 0x000ECF50
	private void 2()
	{
		2274 <<EMPTY_NAME>> = this.13[0].Clone();
		for (int i = 0; i < this.13.Count; i++)
		{
			2274 2 = this.13[i];
			2.3 = ((double)2.1 + 2.2 - ((double)<<EMPTY_NAME>>.1 + <<EMPTY_NAME>>.2)) * (240000.0 / <<EMPTY_NAME>>.4) * <<EMPTY_NAME>>.6 + <<EMPTY_NAME>>.3;
			<<EMPTY_NAME>>.3 = 2.3;
			<<EMPTY_NAME>>.1 = 2.1;
			<<EMPTY_NAME>>.2 = 2.2;
			if (2.4 != -1.0)
			{
				<<EMPTY_NAME>>.4 = 2.4;
			}
			else
			{
				2.4 = <<EMPTY_NAME>>.4;
			}
			if (2.6 != <<EMPTY_NAME>>.6)
			{
				<<EMPTY_NAME>>.6 = 2.6;
			}
		}
	}

	// Token: 0x06002BA9 RID: 11177 RVA: 0x000EEE44 File Offset: 0x000ED044
	private string 3(string 1)
	{
		if (Regex.IsMatch(1, "\\.(mp3|wav|ogg)$"))
		{
			return 1;
		}
		string text = ".ogg";
		for (int i = 0; i < 3; i++)
		{
			if (i != 1)
			{
				if (i == 2)
				{
					text = ".mp3";
				}
			}
			else
			{
				text = ".wav";
			}
			if (File.Exists(this.16 + 1 + text))
			{
				return 1 + text;
			}
		}
		return string.Empty;
	}

	// Token: 0x06002BAA RID: 11178 RVA: 0x000EEEAC File Offset: 0x000ED0AC
	private void 4(string 1)
	{
		string text = Path.Combine(this.16, 1);
		string text2 = Path.Combine(1272.5().44(), 1);
		if (!File.Exists(text2) && File.Exists(text))
		{
			File.Copy(text, text2, true);
		}
	}

	// Token: 0x06002BAB RID: 11179 RVA: 0x000EEEEF File Offset: 0x000ED0EF
	private int[] 5(string 1)
	{
		return new int[]
		{
			int.Parse(1.Substring(0, 3)),
			int.Parse(1.Substring(3, 2))
		};
	}

	// Token: 0x06002BAC RID: 11180 RVA: 0x000EEF18 File Offset: 0x000ED118
	private List<string> 6(string 1)
	{
		int i = 0;
		List<string> list = new List<string>(1.Length / 2);
		while (i < 1.Length - 1)
		{
			list.Add(1.Substring(i, 2));
			i += 2;
		}
		return list;
	}

	// Token: 0x06002BAD RID: 11181 RVA: 0x000EEF58 File Offset: 0x000ED158
	private bool 7(string[] 1)
	{
		int[] array = this.5(7[0]);
		List<string> list = this.6(7[1]);
		int num = array[1];
		switch (num)
		{
		case 2:
		{
			2272.2273 measureEventFinder = new 2272.2273();
			measureEventFinder.1 = array[0];
			2274 2 = this.13.Find((2274 1) => 1.1 == measureEventFinder.1 && 1.2 == 0.0 && !1.5);
			if (2 == null)
			{
				2274 3 = new 2274();
				3.6 = double.Parse(7[1], 1662.18);
				3.1 = measureEventFinder.1;
				3.2 = 0.0;
				3.5 = false;
				this.13.Add(3);
			}
			else
			{
				2.6 = double.Parse(7[1], 1662.18);
			}
			2274 4 = new 2274();
			4.1 = measureEventFinder.1 + 1;
			4.2 = 0.0;
			4.5 = false;
			this.13.Add(4);
			return true;
		}
		case 3:
			for (int i = 0; i < list.Count; i++)
			{
				if (!(list[i] == "00"))
				{
					2274 5 = new 2274();
					5.1 = array[0];
					5.2 = (double)i / (double)list.Count;
					5.4 = (double)Convert.ToInt32(list[i], 16);
					this.13.Add(5);
				}
			}
			return true;
		case 4:
		case 5:
		case 6:
		case 7:
		case 9:
		case 10:
		case 17:
			break;
		case 8:
			for (int j = 0; j < list.Count; j++)
			{
				double num2;
				if (!(list[j] == "00") && this.10.TryGetValue(list[j], out num2))
				{
					2274 6 = new 2274();
					6.1 = array[0];
					6.2 = (double)j / (double)list.Count;
					6.4 = num2;
					this.13.Add(6);
				}
			}
			return true;
		case 11:
		case 12:
		case 13:
		case 14:
		case 15:
		case 16:
		case 18:
		case 19:
		{
			int num3 = (array[1] != 16) ? ((array[1] < 16) ? (array[1] - 10) : (array[1] - 12)) : 0;
			if ((double)num3 >= Math.Round((double)1272.5().2))
			{
				1272.5().2 = (float)((byte)(num3 + 1));
			}
			if (num3 == 0)
			{
				1272.5().91 = true;
			}
			return false;
		}
		default:
			if (num - 51 <= 5 || num - 58 <= 1)
			{
				int num4 = (array[1] != 56) ? ((array[1] < 56) ? (array[1] - 50) : (array[1] - 52)) : 0;
				if ((double)num4 >= Math.Round((double)1272.5().2))
				{
					1272.5().2 = (float)((byte)(num4 + 1));
				}
				if (num4 == 0)
				{
					1272.5().91 = true;
				}
				return false;
			}
			break;
		}
		return false;
	}

	// Token: 0x06002BAE RID: 11182 RVA: 0x000EF268 File Offset: 0x000ED468
	private double 8(int 1, double 2)
	{
		2274 3 = new 2274();
		3.1 = 1;
		3.2 = 2;
		int num = this.13.BinarySearch(3);
		if (num < 0)
		{
			num = ~num;
		}
		if (num > this.13.Count)
		{
			num = this.13.Count;
		}
		2274 4 = this.13[(num != 0) ? (num - 1) : 0];
		return ((double)3.1 + 3.2 - ((double)4.1 + 4.2)) * (240000.0 / 4.4) * 4.6 + 4.3;
	}

	// Token: 0x06002BAF RID: 11183 RVA: 0x000EF308 File Offset: 0x000ED508
	private void 9(string[] 1)
	{
		int[] array = this.5(1[0]);
		List<string> list = this.6(1[1]);
		int num = array[1];
		if (num <= 16)
		{
			if (num != 1)
			{
				if (num - 11 > 5)
				{
					return;
				}
			}
			else
			{
				if (!this.5)
				{
					for (int i = 0; i < list.Count; i++)
					{
						string key;
						if (!(list[i] == "00") && this.9.TryGetValue(list[i], out key))
						{
							2654 2 = new 2654(-1, key, (int)this.8(array[0], (double)i / (double)list.Count), 2645.Background, 70);
							2.11 = true;
							this.3.9(2);
							this.12[key] = true;
						}
					}
					return;
				}
				return;
			}
		}
		else if (num - 18 > 1)
		{
			if (num - 51 > 5 && num - 58 > 1)
			{
				return;
			}
			if (this.18 == 1)
			{
				for (int j = 0; j < list.Count; j++)
				{
					if (!(list[j] == "00"))
					{
						int num2 = (array[1] != 56) ? ((array[1] < 56) ? (array[1] - 50) : (array[1] - 52)) : 0;
						if (this.8)
						{
							num2--;
						}
						if (this.14[num2] != null)
						{
							this.14[num2].2 = (int)this.8(array[0], (double)j / (double)list.Count);
							this.14[num2] = null;
						}
						else
						{
							2048 3 = new 2048(this.2, new 208((float)this.10(num2), 192f), (int)this.8(array[0], (double)j / (double)list.Count), false, false, false, false, 0);
							string empty = string.Empty;
							if (this.9.TryGetValue(list[j], out empty) && !this.4)
							{
								this.11[empty] = true;
								3.33 = empty;
							}
							else
							{
								3.34 = 1;
							}
							this.2.AddHitObject(3, true, true);
							this.14[num2] = 3;
						}
					}
				}
				return;
			}
			return;
		}
		for (int k = 0; k < list.Count; k++)
		{
			if (!(list[k] == "00"))
			{
				int num3 = (array[1] != 16) ? ((array[1] < 16) ? (array[1] - 10) : (array[1] - 12)) : 0;
				if (this.8)
				{
					num3--;
				}
				if (this.18 == 2 && list[k] == this.17 && this.14[num3] != null)
				{
					this.14[num3].2 = (int)this.8(array[0], (double)k / (double)list.Count);
					this.14[num3].3 = 2047.Hold;
					this.14[num3] = null;
				}
				else
				{
					2033 4 = new 2033(this.2, new 208((float)this.10(num3), 192f), (int)this.8(array[0], (double)k / (double)list.Count), false, false, false, false, 0);
					string empty2 = string.Empty;
					if (this.9.TryGetValue(list[k], out empty2) && !this.4)
					{
						this.11[empty2] = true;
						4.33 = empty2;
					}
					else
					{
						4.34 = 1;
					}
					this.2.AddHitObject(4, true, true);
					if (this.18 == 2)
					{
						this.14[num3] = 4;
					}
				}
			}
		}
	}

	// Token: 0x06002BB0 RID: 11184 RVA: 0x000EF6A4 File Offset: 0x000ED8A4
	private int 10(int 1)
	{
		int num = (int)Math.Round((double)1272.5().2);
		return (int)(((1 >= num) ? ((float)1 - 0.5f) : (0.5f + (float)1)) * (512f / (float)num));
	}

	// Token: 0x04001FEB RID: 8171
	private 2263 1;

	// Token: 0x04001FEC RID: 8172
	private 2028 2;

	// Token: 0x04001FED RID: 8173
	private 2648 3;

	// Token: 0x04001FEE RID: 8174
	internal bool 4;

	// Token: 0x04001FEF RID: 8175
	internal bool 5;

	// Token: 0x04001FF0 RID: 8176
	internal bool 6;

	// Token: 0x04001FF1 RID: 8177
	internal bool 7;

	// Token: 0x04001FF2 RID: 8178
	internal bool 8;

	// Token: 0x04001FF3 RID: 8179
	private Dictionary<string, string> 9;

	// Token: 0x04001FF4 RID: 8180
	private Dictionary<string, double> 10;

	// Token: 0x04001FF5 RID: 8181
	private Dictionary<string, bool> 11;

	// Token: 0x04001FF6 RID: 8182
	private Dictionary<string, bool> 12;

	// Token: 0x04001FF7 RID: 8183
	private List<2274> 13;

	// Token: 0x04001FF8 RID: 8184
	private 2072[] 14;

	// Token: 0x04001FF9 RID: 8185
	private List<string> 15;

	// Token: 0x04001FFA RID: 8186
	private string 16 = string.Empty;

	// Token: 0x04001FFB RID: 8187
	private string 17 = string.Empty;

	// Token: 0x04001FFC RID: 8188
	private int 18 = 1;

	// Token: 0x02000582 RID: 1410
	public sealed class 2273
	{
		// Token: 0x04001FFD RID: 8189
		public int 1;
	}
}
