using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

// Token: 0x020006B9 RID: 1721
[276]
public class 2241 : 1570, IComparable<2241>, ICloneable
{
	// Token: 0x0600333B RID: 13115 RVA: 0x001395EC File Offset: 0x001377EC
	internal 2241()
	{
		this.26 = new List<1840>();
		this.7 = DateTime.UtcNow;
	}

	// Token: 0x0600333C RID: 13116 RVA: 0x00139678 File Offset: 0x00137878
	internal 2241(1262 1, string 2)
	{
		if (1 != null)
		{
			this.10 = 1.23;
		}
		this.40 = 1;
		this.23 = (2 ?? string.Empty);
		this.7 = DateTime.UtcNow;
		this.18 = false;
		this.22 = false;
		this.26 = new List<1840>();
	}

	// Token: 0x0600333D RID: 13117 RVA: 0x00139738 File Offset: 0x00137938
	internal 2241(string 1, 1262 2)
	{
		this.33 = new 1654();
		this.12 = true;
		if (2 != null)
		{
			this.40 = 2;
			this.10 = 2.23;
		}
		this.22 = false;
		this.26 = new List<1840>();
		string[] array = 1.Split(new char[]
		{
			'|'
		});
		int num = 0;
		this.18 = true;
		this.16 = Convert.ToInt64(array[num++]);
		this.23 = array[num++];
		this.33.3(this.23);
		this.SetRawScore(Convert.ToInt32(array[num++]));
		this.13 = (int)Convert.ToUInt16(array[num++]);
		this.3 = Convert.ToUInt16(array[num++]);
		this.1 = Convert.ToUInt16(array[num++]);
		this.2 = Convert.ToUInt16(array[num++]);
		this.6 = Convert.ToUInt16(array[num++]);
		this.5 = Convert.ToUInt16(array[num++]);
		this.4 = Convert.ToUInt16(array[num++]);
		this.22 = (array[num++] == "1");
		this.8 = (2023)Convert.ToInt32(array[num++]);
		this.33.12 = Convert.ToInt32(array[num++]);
		if (array[num].Length > 0)
		{
			this.17 = Convert.ToInt32(array[num]);
		}
		num++;
		try
		{
			this.7 = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds((double)int.Parse(array[num++]));
			if (this.7 < new DateTime(1990, 5, 31))
			{
				this.7 = DateTime.UtcNow;
			}
		}
		catch
		{
			this.7 = DateTime.UtcNow;
		}
		this.12(array[num++] == "1");
	}

	// Token: 0x0600333E RID: 13118 RVA: 0x001399AC File Offset: 0x00137BAC
	internal 2241(2247 1, string 2)
	{
		this.18 = 1.11;
		this.23 = 2;
		this.2 = 1.2;
		this.1 = 1.1;
		this.3 = 1.3;
		this.4 = 1.4;
		this.5 = 1.5;
		this.6 = 1.6;
		this.SetRawScore(1.14);
		this.13 = (int)1.10;
		this.22 = 1.12;
		this.35 = (double)1.8;
		this.36 = 1.7;
		this.8 = 2019.1;
		this.7 = DateTime.UtcNow;
	}

	// Token: 0x0600333F RID: 13119 RVA: 0x00139AD4 File Offset: 0x00137CD4
	internal string 1()
	{
		string text = 2019.15(this.8, false, false);
		if (this.44 != null)
		{
			text = text + " " + this.44.1();
		}
		if (this.43 != null)
		{
			text = (string.IsNullOrEmpty(text) ? "DA" : (text + ",DA"));
		}
		if (this.45)
		{
			text = (string.IsNullOrEmpty(text) ? "NL" : (text + ",NL"));
		}
		if (this.47)
		{
			text = (string.IsNullOrEmpty(text) ? "PR" : (text + ",PR"));
		}
		if (this.52 != null)
		{
			foreach (string text2 in this.52.1())
			{
				text = (string.IsNullOrEmpty(text) ? text2 : (text + "," + text2));
			}
		}
		return text;
	}

	// Token: 0x06003340 RID: 13120 RVA: 0x00139BDC File Offset: 0x00137DDC
	internal string 2()
	{
		string text = this.3();
		if (this.46)
		{
			int num = text.IndexOf("Hidden", StringComparison.Ordinal);
			if (num >= 0)
			{
				text = text.Insert(num + "Hidden".Length, " (approach circles only)");
			}
		}
		return text;
	}

	// Token: 0x06003341 RID: 13121 RVA: 0x00139C24 File Offset: 0x00137E24
	private string 3()
	{
		string str = (this.44 != null) ? (" (" + this.44.1() + ")") : string.Empty;
		if (this.43 == null && !this.45 && !this.47 && this.52 == null)
		{
			return 2019.14(this.8, true) + str;
		}
		string text = 2019.14(this.8, false) + str;
		if (this.43 != null)
		{
			string text2 = this.43.IsEmpty ? "DifficultyAdjust" : ("DifficultyAdjust (" + this.43.1() + ")");
			text = (string.IsNullOrEmpty(text) ? text2 : (text + "," + text2));
		}
		if (this.45)
		{
			text = (string.IsNullOrEmpty(text) ? "NoNotelock" : (text + ",NoNotelock"));
		}
		if (this.47)
		{
			text = (string.IsNullOrEmpty(text) ? "Practice" : (text + ",Practice"));
		}
		if (this.52 != null)
		{
			foreach (string text3 in this.52.2())
			{
				text = (string.IsNullOrEmpty(text) ? text3 : (text + "," + text3));
			}
		}
		return text;
	}

	// Token: 0x06003342 RID: 13122 RVA: 0x0001702D File Offset: 0x0001522D
	internal virtual bool CanSkipUnchangedReplayFrames()
	{
		return true;
	}

	// Token: 0x06003343 RID: 13123 RVA: 0x00139DA4 File Offset: 0x00137FA4
	internal virtual float CalculateAccuracy()
	{
		if (this.GetJudgementCount() <= 0)
		{
			return 1f;
		}
		return (float)(this.3 * 50 + this.1 * 100 + this.2 * 300) / (float)(this.GetJudgementCount() * 300);
	}

	// Token: 0x06003344 RID: 13124 RVA: 0x00139DE4 File Offset: 0x00137FE4
	internal string 4()
	{
		string s = string.Concat(new string[]
		{
			this.13.ToString(),
			"osu",
			this.23,
			this.10,
			this.GetScore().ToString(),
			this.CalculateGrade().ToString(),
			this.7.ToString()
		});
		byte[] array = 1209.2.GetBytes(s);
		MD5 obj = 1209.1;
		string result;
		lock (obj)
		{
			try
			{
				array = 1209.1.ComputeHash(array);
			}
			catch (Exception)
			{
				result = "fail";
				goto IL_F9;
			}
		}
		char[] array2 = new char[array.Length * 2];
		for (int i = 0; i < array.Length; i++)
		{
			array[i].ToString("x2", 1209.3).CopyTo(0, array2, i * 2, 2);
		}
		return new string(array2);
		IL_F9:
		return result;
	}

	// Token: 0x06003345 RID: 13125 RVA: 0x00139F0C File Offset: 0x0013810C
	internal virtual int GetJudgementCount()
	{
		return (int)(this.3 + this.1 + this.2 + this.6);
	}

	// Token: 0x06003346 RID: 13126 RVA: 0x00139F29 File Offset: 0x00138129
	internal virtual int GetSuccessfulJudgementCount()
	{
		return (int)(this.3 + this.1 + this.2);
	}

	// Token: 0x06003347 RID: 13127 RVA: 0x00139F40 File Offset: 0x00138140
	internal string 5()
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (this.26 != null)
		{
			1840 <<EMPTY_NAME>> = new 1840(0, 0f, 0f, 1572.None);
			foreach (1840 2 in this.26)
			{
				stringBuilder.AppendFormat("{0}|{1}|{2}|{3},", new object[]
				{
					2.10 - <<EMPTY_NAME>>.10,
					2.1.ToString(1662.18),
					2.2.ToString(1662.18),
					(int)2.9
				});
				<<EMPTY_NAME>> = 2;
			}
		}
		stringBuilder.AppendFormat("{0}|{1}|{2}|{3},", new object[]
		{
			-12345,
			0,
			0,
			this.38
		});
		return stringBuilder.ToString();
	}

	// Token: 0x06003348 RID: 13128 RVA: 0x0013A054 File Offset: 0x00138254
	internal virtual 2236 CalculateGrade()
	{
		float num = (float)this.2 / (float)this.GetJudgementCount();
		float num2 = (float)this.3 / (float)this.GetJudgementCount();
		if (!this.18)
		{
			return 2236.F;
		}
		if (num == 1f)
		{
			2023 <<EMPTY_NAME>> = this.8;
			2023 2 = 2023.Hidden;
			if ((<<EMPTY_NAME>> & 2) <= 2023.None)
			{
				2023 3 = this.8;
				2 = 2023.Flashlight;
				if ((3 & 2) <= 2023.None)
				{
					return 2236.X;
				}
			}
			return 2236.XH;
		}
		if ((double)num > 0.9 && (double)num2 <= 0.01 && this.6 == 0)
		{
			2023 4 = this.8;
			2023 5 = 2023.Hidden;
			if ((4 & 5) <= 2023.None)
			{
				2023 6 = this.8;
				5 = 2023.Flashlight;
				if ((6 & 5) <= 2023.None)
				{
					return 2236.S;
				}
			}
			return 2236.SH;
		}
		if (((double)num > 0.8 && this.6 == 0) || (double)num > 0.9)
		{
			return 2236.A;
		}
		if (((double)num > 0.7 && this.6 == 0) || (double)num > 0.8)
		{
			return 2236.B;
		}
		if ((double)num > 0.6)
		{
			return 2236.C;
		}
		return 2236.D;
	}

	// Token: 0x06003349 RID: 13129 RVA: 0x0013A165 File Offset: 0x00138365
	internal string 6()
	{
		return this.7().Replace(".osr", ".osg");
	}

	// Token: 0x0600334A RID: 13130 RVA: 0x0013A17C File Offset: 0x0013837C
	internal string 7()
	{
		long num;
		try
		{
			num = this.7.ToFileTimeUtc();
		}
		catch
		{
			num = DateTime.Now.ToFileTimeUtc();
		}
		return Path.Combine(2230.2(), string.Format("{0}-{1}.osr", this.10, num));
	}

	// Token: 0x0600334B RID: 13131 RVA: 0x0013A1D8 File Offset: 0x001383D8
	internal bool 8()
	{
		return File.Exists(this.7());
	}

	// Token: 0x0600334C RID: 13132 RVA: 0x0013A1E5 File Offset: 0x001383E5
	internal virtual int GetScore()
	{
		2153 <<EMPTY_NAME>> = this.39;
		if (<<EMPTY_NAME>> == null)
		{
			return this.31;
		}
		return <<EMPTY_NAME>>.GetScore();
	}

	// Token: 0x0600334D RID: 13133 RVA: 0x0013A1FD File Offset: 0x001383FD
	internal virtual void SetRawScore(int 1)
	{
		this.31 = 1;
	}

	// Token: 0x0600334E RID: 13134 RVA: 0x0013A206 File Offset: 0x00138406
	internal 700 9()
	{
		return this.53;
	}

	// Token: 0x0600334F RID: 13135 RVA: 0x0013A20E File Offset: 0x0013840E
	private void 10(700 1)
	{
		this.53 = 1;
	}

	// Token: 0x06003350 RID: 13136 RVA: 0x0013A217 File Offset: 0x00138417
	internal bool 11()
	{
		return this.54;
	}

	// Token: 0x06003351 RID: 13137 RVA: 0x0013A21F File Offset: 0x0013841F
	private void 12(bool 1)
	{
		this.54 = 1;
	}

	// Token: 0x06003352 RID: 13138 RVA: 0x0013A228 File Offset: 0x00138428
	private string 13()
	{
		return string.Format("{0}:{1}:{2}:{3}:{4}:{5}", new object[]
		{
			this.40.112,
			this.40.107,
			this.40.108,
			this.40.109,
			this.40.113,
			this.42
		});
	}

	// Token: 0x06003353 RID: 13139 RVA: 0x0013A2B0 File Offset: 0x001384B0
	private string 14()
	{
		string s = string.Format("chickenmcnuggets{0}o15{1}{2}smustard{3}{4}uu{5}{6}{7}{8}{9}{10}{11}Q{12}{13}{15}{14:yyMMddHHmmss}{16}{17}", new object[]
		{
			(int)(this.1 + this.2),
			this.3,
			this.4,
			this.5,
			this.6,
			this.10,
			this.13,
			this.22,
			this.23,
			this.GetScore(),
			this.CalculateGrade(),
			(int)this.8,
			this.18,
			(int)this.9,
			this.7.ToUniversalTime(),
			1296.11,
			1662.64,
			this.40.24
		});
		byte[] array = 1209.2.GetBytes(s);
		MD5 obj = 1209.1;
		string text;
		lock (obj)
		{
			try
			{
				array = 1209.1.ComputeHash(array);
			}
			catch (Exception)
			{
				text = "fail";
				goto IL_1BA;
			}
		}
		char[] array2 = new char[array.Length * 2];
		for (int i = 0; i < array.Length; i++)
		{
			array[i].ToString("x2", 1209.3).CopyTo(0, array2, i * 2, 2);
		}
		string text2 = new string(array2);
		IL_1A1:
		if (text2.Length != 32)
		{
			throw new Exception("checksum failure");
		}
		return text2;
		IL_1BA:
		text2 = text;
		goto IL_1A1;
	}

	// Token: 0x06003354 RID: 13140 RVA: 0x0013A498 File Offset: 0x00138698
	public void ReadFrom(1647 1)
	{
		this.15(1, false);
	}

	// Token: 0x06003355 RID: 13141 RVA: 0x0013A4A4 File Offset: 0x001386A4
	public void 15(1647 1, bool 2)
	{
		if (1.BaseStream.Position == 1L)
		{
			this.16(1);
		}
		this.25 = 1.1();
		if (2 || this.34 >= 20140721)
		{
			this.16 = 1.ReadInt64();
		}
		else if (this.34 >= 1296.2)
		{
			this.16 = (long)1.ReadInt32();
		}
		this.ReadExtraReplayData(1);
		if (this.34 >= 30000001 && 1.BaseStream.Position < 1.BaseStream.Length)
		{
			2205.2(1.1(), this);
		}
	}

	// Token: 0x06003356 RID: 13142 RVA: 0x0013A544 File Offset: 0x00138744
	public void 16(1647 1)
	{
		this.18 = true;
		this.34 = 1.ReadInt32();
		this.10 = 1.ReadString();
		this.23 = 1.ReadString();
		1.ReadString();
		this.2 = 1.ReadUInt16();
		this.1 = 1.ReadUInt16();
		this.3 = 1.ReadUInt16();
		this.4 = 1.ReadUInt16();
		this.5 = 1.ReadUInt16();
		this.6 = 1.ReadUInt16();
		this.SetRawScore(1.ReadInt32());
		this.13 = (int)1.ReadUInt16();
		this.22 = 1.ReadBoolean();
		this.8 = (2023)1.ReadInt32();
		this.24 = 1.ReadString();
		this.7 = 1.3();
	}

	// Token: 0x06003357 RID: 13143 RVA: 0x0013A618 File Offset: 0x00138818
	public void WriteTo(1648 1)
	{
		this.17(1, true);
	}

	// Token: 0x06003358 RID: 13144 RVA: 0x0013A624 File Offset: 0x00138824
	internal void 17(1648 1, bool 2)
	{
		if (this.34 == 0 || this.34 >= 30000000)
		{
			this.34 = 1296.11;
		}
		bool flag = this.43 != null || this.44 != null || this.45 || this.52 != null || this.47 || this.50 != 0f || this.46;
		1.Write((byte)this.9);
		1.Write(flag ? 30000001 : this.34);
		1.Write(this.10);
		1.Write(this.23);
		1.Write(this.4());
		1.Write(this.2);
		1.Write(this.1);
		1.Write(this.3);
		1.Write(this.4);
		1.Write(this.5);
		1.Write(this.6);
		1.Write(this.GetScore());
		1.Write((ushort)this.13);
		1.Write(this.22);
		1.Write((int)this.8);
		1.Write(2 ? this.19() : null);
		1.1(this.7);
		1.6(2 ? this.25 : null);
		1.Write(this.16);
		this.WriteExtraReplayData(1);
		if (flag)
		{
			1.6(2205.1(this));
		}
	}

	// Token: 0x06003359 RID: 13145 RVA: 0x0013A7A8 File Offset: 0x001389A8
	public int CompareTo(2241 1)
	{
		int num = 1.GetScore().CompareTo(this.GetScore());
		if (num != 0)
		{
			return num;
		}
		return this.7.CompareTo(1.7);
	}

	// Token: 0x0600335A RID: 13146 RVA: 0x0013A7E0 File Offset: 0x001389E0
	public object Clone()
	{
		return base.MemberwiseClone();
	}

	// Token: 0x0600335B RID: 13147 RVA: 0x0013A7E8 File Offset: 0x001389E8
	internal void 18()
	{
		this.41 = false;
	}

	// Token: 0x0600335C RID: 13148 RVA: 0x0013A7F4 File Offset: 0x001389F4
	internal string 19()
	{
		if (!string.IsNullOrEmpty(this.24))
		{
			return this.24;
		}
		StringBuilder stringBuilder = new StringBuilder();
		float num = 0f;
		if (this.11 == null)
		{
			return null;
		}
		for (int i = 0; i < this.11.Count; i++)
		{
			208 <<EMPTY_NAME>> = this.11[i];
			if (<<EMPTY_NAME>>.X - num > 2000f || i == this.11.Count - 1 || i == 0)
			{
				num = <<EMPTY_NAME>>.X;
				stringBuilder.AppendFormat("{0}|{1},", Math.Round((double)<<EMPTY_NAME>>.X, 2).ToString(1662.18), Math.Round((double)<<EMPTY_NAME>>.Y, 2).ToString(1662.18));
			}
		}
		this.11.Clear();
		this.11 = null;
		this.24 = stringBuilder.ToString();
		return this.24;
	}

	// Token: 0x0600335D RID: 13149 RVA: 0x0013A8E0 File Offset: 0x00138AE0
	internal void 20()
	{
		if (this.9() > (700)0)
		{
			return;
		}
		if (this.39 != null)
		{
			this.8 |= 2023.ScoreV2;
		}
		2228.1(this);
	}

	// Token: 0x0600335E RID: 13150 RVA: 0x0013A918 File Offset: 0x00138B18
	internal void 21()
	{
		if (261.FullyOffline)
		{
			return;
		}
		if (1662.21())
		{
			1621 <<EMPTY_NAME>> = new 1621(string.Format(1296.6 + "/web/osu-getreplay.php?c={0}&m={1}&u={2}&h={3}", new object[]
			{
				this.16,
				(int)this.9,
				1304.189,
				1304.186.1(1643.Hashed)
			}), Array.Empty<object>());
			<<EMPTY_NAME>>.9(new 1621.1622(this.30));
			<<EMPTY_NAME>>.Start();
			return;
		}
		string text = (this.9 == 2147.Taiko) ? "taiko" : ((this.9 == 2147.CatchTheBeat) ? "fruits" : ((this.9 == 2147.OsuMania) ? "mania" : "osu"));
		string text2 = null;
		foreach (1637 2 in 1632.1())
		{
			text2 = ((this.16 > 0L) ? 2.GetReplayUrl(text, this.16) : null);
			if (text2 != null)
			{
				break;
			}
		}
		if (text2 == null)
		{
			1662.89.Schedule(delegate()
			{
				2152 4 = this.55;
				if (4 == null)
				{
					return;
				}
				4(this);
			}, false);
			return;
		}
		1621 3 = new 1621(text2, Array.Empty<object>());
		3.9(new 1621.1622(this.29));
		3.Start();
	}

	// Token: 0x0600335F RID: 13151 RVA: 0x0013AA74 File Offset: 0x00138C74
	internal void 22()
	{
		if (this.25 == null || this.25.Length == 0)
		{
			return;
		}
		if (this.26 == null)
		{
			this.26 = new List<1840>();
		}
		else
		{
			this.26.Clear();
		}
		try
		{
			this.23(new ASCIIEncoding().GetString(182.Decompress(this.25)));
		}
		catch (Exception)
		{
			this.26.Clear();
		}
	}

	// Token: 0x06003360 RID: 13152 RVA: 0x0013AAF0 File Offset: 0x00138CF0
	internal void 23(string 1)
	{
		if (1.Length <= 0)
		{
			return;
		}
		string[] array = 1.Split(new char[]
		{
			','
		});
		1840 2 = (this.26.Count <= 0) ? new 1840(0, 0f, 0f, 1572.None) : this.26[this.26.Count - 1];
		foreach (string text in array)
		{
			if (text.Length != 0)
			{
				string[] array3 = text.Split(new char[]
				{
					'|'
				});
				if (array3.Length >= 4)
				{
					if (array3[0] == "-12345")
					{
						this.38 = int.Parse(array3[3]);
					}
					else
					{
						1572 3 = (1572)Enum.Parse(typeof(1572), array3[3]);
						1840 4 = new 1840(int.Parse(array3[0]) + 2.10, float.Parse(array3[1], 1662.18), float.Parse(array3[2], 1662.18), 3);
						this.26.Add(4);
						2 = 4;
					}
				}
			}
		}
	}

	// Token: 0x06003361 RID: 13153 RVA: 0x0013AC14 File Offset: 0x00138E14
	internal void 24(string 1)
	{
		this.11 = new List<208>();
		if (1.Length <= 0)
		{
			return;
		}
		foreach (string text in 1.Split(new char[]
		{
			','
		}))
		{
			if (text.Length != 0)
			{
				string[] array2 = text.Split(new char[]
				{
					'|'
				});
				this.11.Add(new 208((float)decimal.Parse(array2[0], 1662.18), (float)decimal.Parse(array2[1], 1662.18)));
			}
		}
	}

	// Token: 0x06003362 RID: 13154 RVA: 0x0013ACAA File Offset: 0x00138EAA
	internal void 25()
	{
		this.19();
		if (this.11 != null)
		{
			this.11.Clear();
			this.11 = null;
		}
	}

	// Token: 0x06003363 RID: 13155 RVA: 0x0013ACD0 File Offset: 0x00138ED0
	internal virtual void ResetJudgements(bool 1)
	{
		if (this.39 != null)
		{
			this.39.Reset(1);
		}
		else
		{
			this.SetRawScore(0);
			this.32 = 0.0;
		}
		this.36 = 0;
		this.13 = 0;
		this.6 = 0;
		this.3 = 0;
		this.1 = 0;
		this.2 = 0;
		this.4 = 0;
		this.6 = 0;
		this.5 = 0;
	}

	// Token: 0x06003364 RID: 13156 RVA: 0x0013AD48 File Offset: 0x00138F48
	internal void 26()
	{
		this.26 = null;
		this.25 = null;
		this.24 = null;
	}

	// Token: 0x06003365 RID: 13157 RVA: 0x0013AD60 File Offset: 0x00138F60
	internal void 27()
	{
		if (this.8())
		{
			try
			{
				using (Stream stream = File.Open(this.7(), FileMode.Open, FileAccess.Read, FileShare.Read))
				{
					1647 <<EMPTY_NAME>> = new 1647(stream);
					2241 2 = 2246.Create((2147)<<EMPTY_NAME>>.ReadByte(), null, null, false);
					2.16(<<EMPTY_NAME>>);
					if ((2.8 & 2023.Target) > 2023.None)
					{
						2 = new 2136(2);
					}
					2.15(<<EMPTY_NAME>>, false);
					this.25 = 2.25;
					this.24 = 2.24;
				}
			}
			catch (Exception ex)
			{
				1338.4(ex, "reading a replay file", 1341.Runtime);
			}
		}
	}

	// Token: 0x06003366 RID: 13158 RVA: 0x0013AE18 File Offset: 0x00139018
	internal void 28()
	{
		if (268.SharesStableInstall)
		{
			return;
		}
		File.Delete(this.7());
		File.Delete(this.6());
	}

	// Token: 0x06003367 RID: 13159 RVA: 0x00005ADD File Offset: 0x00003CDD
	protected virtual void ReadExtraReplayData(1647 1)
	{
	}

	// Token: 0x06003368 RID: 13160 RVA: 0x00005ADD File Offset: 0x00003CDD
	protected virtual void WriteExtraReplayData(1648 1)
	{
	}

	// Token: 0x06003369 RID: 13161 RVA: 0x0013AE38 File Offset: 0x00139038
	private void 29(1621 1, Exception 2)
	{
		byte[] frames = null;
		string mismatch = null;
		if (2 == null)
		{
			try
			{
				using (MemoryStream memoryStream = new MemoryStream(1.13()))
				{
					1647 3 = new 1647(memoryStream);
					2241 4 = 2246.Create((2147)3.ReadByte(), null, null, false);
					4.16(3);
					4.ReadFrom(3);
					if (!string.Equals(4.10, this.10, StringComparison.OrdinalIgnoreCase) || 4.2 != this.2 || 4.1 != this.1 || 4.3 != this.3 || 4.6 != this.6 || 4.13 != this.13)
					{
						mismatch = string.Concat(new string[]
						{
							"the mirror sent ",
							4.23,
							"'s replay on beatmap ",
							4.10,
							" for ",
							this.23,
							"'s score ",
							this.16.ToString(),
							" on ",
							this.10
						});
					}
					else
					{
						frames = 4.25;
					}
				}
			}
			catch (Exception)
			{
			}
		}
		1662.89.Schedule(delegate()
		{
			if (frames != null)
			{
				this.25 = frames;
				this.22();
			}
			else if (mismatch != null)
			{
				1338.5("Replay: " + mismatch + "; not used.", 1341.Runtime, (1114)2);
				1763.5("This play's replay is not available: the beatmap mirror has another play's replay under its id.", 198.Orange, 5000, null);
			}
			2152 5 = this.55;
			if (5 == null)
			{
				return;
			}
			5(this);
		}, false);
	}

	// Token: 0x0600336A RID: 13162 RVA: 0x0013AFC8 File Offset: 0x001391C8
	private void 30(1621 1, Exception 2)
	{
		this.25 = 1.13();
		this.22();
		if (this.55 != null)
		{
			this.55(this);
		}
	}

	// Token: 0x0600336B RID: 13163
	[DllImport("kernel32.dll")]
	private static extern bool Wow64EnableWow64FsRedirection(bool 1);

	// Token: 0x0600336C RID: 13164 RVA: 0x0013AFF0 File Offset: 0x001391F0
	private bool 31()
	{
		bool result;
		try
		{
			2241.Wow64EnableWow64FsRedirection(false);
			string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), "System32\\cmd.exe");
			ProcessStartInfo startInfo = new ProcessStartInfo
			{
				FileName = fileName,
				Arguments = "/c bcdedit.exe -set TESTSIGNING OFF",
				UseShellExecute = true,
				Verb = "runas"
			};
			Process process = new Process();
			process.StartInfo = startInfo;
			261.16(process);
			process.WaitForExit();
			result = (process.ExitCode == 0);
		}
		catch
		{
			result = false;
		}
		finally
		{
			try
			{
				2241.Wow64EnableWow64FsRedirection(true);
			}
			catch
			{
			}
		}
		return result;
	}

	// Token: 0x0600336D RID: 13165 RVA: 0x0013B0A0 File Offset: 0x001392A0
	private void 32()
	{
		1763.5("Score submission is disabled. You might have test signing mode enabled. Click on this message to disable test signing mode.", 198.DarkRed, 60000, new 1189(this.37));
	}

	// Token: 0x0600336E RID: 13166 RVA: 0x0013B0C4 File Offset: 0x001392C4
	internal void 33(2152 1)
	{
		2152 2 = this.55;
		2152 3;
		do
		{
			3 = 2;
			2152 value = (2152)Delegate.Combine(3, 1);
			2 = Interlocked.CompareExchange<2152>(ref this.55, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x0600336F RID: 13167 RVA: 0x0013B0FC File Offset: 0x001392FC
	internal void 34(2152 1)
	{
		2152 2 = this.55;
		2152 3;
		do
		{
			3 = 2;
			2152 value = (2152)Delegate.Remove(3, 1);
			2 = Interlocked.CompareExchange<2152>(ref this.55, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x06003370 RID: 13168 RVA: 0x0013B134 File Offset: 0x00139334
	internal void 35(2152 1)
	{
		2152 2 = this.56;
		2152 3;
		do
		{
			3 = 2;
			2152 value = (2152)Delegate.Combine(3, 1);
			2 = Interlocked.CompareExchange<2152>(ref this.56, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x06003371 RID: 13169 RVA: 0x0013B16C File Offset: 0x0013936C
	internal void 36(2152 1)
	{
		2152 2 = this.56;
		2152 3;
		do
		{
			3 = 2;
			2152 value = (2152)Delegate.Remove(3, 1);
			2 = Interlocked.CompareExchange<2152>(ref this.56, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x06003372 RID: 13170 RVA: 0x0013B1A4 File Offset: 0x001393A4
	private void 37()
	{
		1689 <<EMPTY_NAME>> = new 1689("Proceed with disabling test mode?\nNote that you will need to restart your PC to apply changes.", false);
		<<EMPTY_NAME>>.7("Yes", 198.LimeGreen, new EventHandler(this.38), true, false, true);
		<<EMPTY_NAME>>.7("Cancel", 198.OrangeRed, delegate(object 1, EventArgs 2)
		{
		}, true, false, true);
		1662.25(<<EMPTY_NAME>>);
	}

	// Token: 0x06003373 RID: 13171 RVA: 0x0013B214 File Offset: 0x00139414
	private void 38(object 1, EventArgs 2)
	{
		if (this.31())
		{
			1763.2("Test signing mode has been turned off. Please restart your computer to play online.", 7500, (1389)0);
			return;
		}
		1763.2("Could not turn test signing off. Try disabling it manually.", 5000, (1389)0);
	}

	// Token: 0x04002604 RID: 9732
	internal ushort 1;

	// Token: 0x04002605 RID: 9733
	internal ushort 2;

	// Token: 0x04002606 RID: 9734
	internal ushort 3;

	// Token: 0x04002607 RID: 9735
	internal ushort 4;

	// Token: 0x04002608 RID: 9736
	internal ushort 5;

	// Token: 0x04002609 RID: 9737
	internal ushort 6;

	// Token: 0x0400260A RID: 9738
	internal DateTime 7;

	// Token: 0x0400260B RID: 9739
	internal 2685<2023> 8 = 2023.None;

	// Token: 0x0400260C RID: 9740
	internal 2147 9;

	// Token: 0x0400260D RID: 9741
	internal string 10 = string.Empty;

	// Token: 0x0400260E RID: 9742
	internal List<208> 11 = new List<208>();

	// Token: 0x0400260F RID: 9743
	internal bool 12;

	// Token: 0x04002610 RID: 9744
	internal int 13;

	// Token: 0x04002611 RID: 9745
	internal int 14;

	// Token: 0x04002612 RID: 9746
	internal int 15;

	// Token: 0x04002613 RID: 9747
	internal long 16;

	// Token: 0x04002614 RID: 9748
	internal int 17;

	// Token: 0x04002615 RID: 9749
	internal bool 18;

	// Token: 0x04002616 RID: 9750
	internal bool 19;

	// Token: 0x04002617 RID: 9751
	internal int 20;

	// Token: 0x04002618 RID: 9752
	internal int 21;

	// Token: 0x04002619 RID: 9753
	internal bool 22;

	// Token: 0x0400261A RID: 9754
	internal string 23;

	// Token: 0x0400261B RID: 9755
	internal string 24;

	// Token: 0x0400261C RID: 9756
	internal byte[] 25;

	// Token: 0x0400261D RID: 9757
	internal List<1840> 26;

	// Token: 0x0400261E RID: 9758
	internal List<int> 27 = new List<int>();

	// Token: 0x0400261F RID: 9759
	internal List<int> 28 = new List<int>();

	// Token: 0x04002620 RID: 9760
	internal List<bool> 29 = new List<bool>();

	// Token: 0x04002621 RID: 9761
	internal List<2247> 30 = new List<2247>();

	// Token: 0x04002622 RID: 9762
	private int 31;

	// Token: 0x04002623 RID: 9763
	internal double 32;

	// Token: 0x04002624 RID: 9764
	internal 1654 33;

	// Token: 0x04002625 RID: 9765
	internal int 34 = 1296.11;

	// Token: 0x04002626 RID: 9766
	internal double 35;

	// Token: 0x04002627 RID: 9767
	internal ushort 36;

	// Token: 0x04002628 RID: 9768
	internal string 37;

	// Token: 0x04002629 RID: 9769
	internal int 38;

	// Token: 0x0400262A RID: 9770
	internal 2153 39;

	// Token: 0x0400262B RID: 9771
	internal 1262 40;

	// Token: 0x0400262C RID: 9772
	internal bool 41 = true;

	// Token: 0x0400262D RID: 9773
	internal bool 42;

	// Token: 0x0400262E RID: 9774
	internal 1927 43;

	// Token: 0x0400262F RID: 9775
	internal 1940 44;

	// Token: 0x04002630 RID: 9776
	internal bool 45;

	// Token: 0x04002631 RID: 9777
	internal bool 46;

	// Token: 0x04002632 RID: 9778
	internal bool 47;

	// Token: 0x04002633 RID: 9779
	internal int? 48;

	// Token: 0x04002634 RID: 9780
	internal int? 49;

	// Token: 0x04002635 RID: 9781
	internal float 50;

	// Token: 0x04002636 RID: 9782
	internal bool 51;

	// Token: 0x04002637 RID: 9783
	internal 1925 52;

	// Token: 0x04002638 RID: 9784
	private 700 53;

	// Token: 0x04002639 RID: 9785
	private bool 54;

	// Token: 0x0400263A RID: 9786
	private 2152 55;

	// Token: 0x0400263B RID: 9787
	private 2152 56;

	// Token: 0x0400263C RID: 9788
	internal static 2241.2242 57;

	// Token: 0x0400263D RID: 9789
	internal static 2241.2242 58;

	// Token: 0x0400263E RID: 9790
	internal static 2241.2242 59;

	// Token: 0x0400263F RID: 9791
	internal static 2241.2242 60;

	// Token: 0x04002640 RID: 9792
	internal static 2241.2242 61;

	// Token: 0x04002641 RID: 9793
	internal static 2241.2242 62;

	// Token: 0x04002642 RID: 9794
	internal static 2241.2242 63;

	// Token: 0x04002643 RID: 9795
	internal static 2241.2242 64;

	// Token: 0x04002644 RID: 9796
	internal static 2241.2242 65;

	// Token: 0x04002645 RID: 9797
	internal static 2241.2242 66;

	// Token: 0x04002646 RID: 9798
	internal static 2241.2242 67;

	// Token: 0x020006BA RID: 1722
	[276]
	public sealed class 2245
	{
		// Token: 0x06003375 RID: 13173 RVA: 0x0013B252 File Offset: 0x00139452
		internal void 1()
		{
			1662.100.32.SetText(this.1);
		}

		// Token: 0x06003376 RID: 13174 RVA: 0x0013B269 File Offset: 0x00139469
		internal void 2()
		{
			if (1662.100.32.GetText() == this.1)
			{
				1662.100.32.SetText("Submission complete!");
			}
		}

		// Token: 0x04002647 RID: 9799
		public string 1;
	}

	// Token: 0x020006BB RID: 1723
	[276]
	[Serializable]
	public sealed class 2244
	{
		// Token: 0x06003378 RID: 13176 RVA: 0x0013B29B File Offset: 0x0013949B
		internal void 1(HttpWebRequest 1)
		{
			if (1.Headers.Get("Token") == null)
			{
				throw new 2241.2243();
			}
		}

		// Token: 0x04002648 RID: 9800
		public static readonly 2241.2244 Instance = new 2241.2244();

		// Token: 0x04002649 RID: 9801
		public static EventHandler eventHandler;

		// Token: 0x0400264A RID: 9802
		public static Action<HttpWebRequest> action;
	}

	// Token: 0x020006BC RID: 1724
	[276]
	public sealed class 2243 : Exception
	{
	}

	// Token: 0x020006BD RID: 1725
	[276]
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 256)]
	public struct 2242
	{
	}
}
