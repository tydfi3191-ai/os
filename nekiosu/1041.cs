using System;
using System.Collections;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

// Token: 0x02000CA6 RID: 3238
[ComVisible(false)]
[SuppressUnmanagedCodeSecurity]
public sealed class 1041
{
	// Token: 0x0600565E RID: 22110 RVA: 0x00214DF4 File Offset: 0x00212FF4
	public 1041()
	{
		this.19 = string.Empty;
		this.5 = string.Empty;
		this.3 = string.Empty;
		this.4 = string.Empty;
		this.21 = string.Empty;
		this.9 = string.Empty;
		this.15 = string.Empty;
		this.20 = string.Empty;
		this.11 = string.Empty;
		this.13 = string.Empty;
		this.10 = string.Empty;
		this.18 = string.Empty;
		this.7 = string.Empty;
		this.14 = string.Empty;
		this.17 = new ArrayList();
		this.16 = new ArrayList();
		this.8 = new 996();
	}

	// Token: 0x0600565F RID: 22111 RVA: 0x00214EC4 File Offset: 0x002130C4
	public 1041(string 1)
	{
		this.19 = string.Empty;
		this.5 = string.Empty;
		this.3 = string.Empty;
		this.4 = string.Empty;
		this.21 = string.Empty;
		this.9 = string.Empty;
		this.15 = string.Empty;
		this.20 = string.Empty;
		this.11 = string.Empty;
		this.13 = string.Empty;
		this.10 = string.Empty;
		this.18 = string.Empty;
		this.7 = string.Empty;
		this.14 = string.Empty;
		this.17 = new ArrayList();
		this.16 = new ArrayList();
		this.8 = new 996();
		this.14 = 1;
		this.19 = Path.GetFileNameWithoutExtension(1);
	}

	// Token: 0x06005660 RID: 22112 RVA: 0x00214FA8 File Offset: 0x002131A8
	public 1041(string 1, bool 2)
	{
		this.19 = string.Empty;
		this.5 = string.Empty;
		this.3 = string.Empty;
		this.4 = string.Empty;
		this.21 = string.Empty;
		this.9 = string.Empty;
		this.15 = string.Empty;
		this.20 = string.Empty;
		this.11 = string.Empty;
		this.13 = string.Empty;
		this.10 = string.Empty;
		this.18 = string.Empty;
		this.7 = string.Empty;
		this.14 = string.Empty;
		this.17 = new ArrayList();
		this.16 = new ArrayList();
		this.8 = new 996();
		this.14 = 1;
		if (2)
		{
			this.19 = Path.GetFileNameWithoutExtension(1);
		}
	}

	// Token: 0x06005661 RID: 22113 RVA: 0x0021508C File Offset: 0x0021328C
	internal bool 1(string 1)
	{
		if (1 == null)
		{
			return false;
		}
		bool result = false;
		string text = string.Empty;
		string[] array = 1.Trim().Split(new char[]
		{
			'=',
			':'
		}, 2);
		if (array.Length != 2)
		{
			if (!this.16.Contains(1) && 1 != string.Empty)
			{
				this.16.Add(1);
			}
			return result;
		}
		if (this.2(array[0].Trim()) != null)
		{
			this.2++;
			array[0] = array[0].Trim() + this.2.ToString();
		}
		try
		{
			this.16.Add(array[0].Trim() + "=" + array[1].Trim());
		}
		catch
		{
		}
		string text2 = array[0].ToLower().Trim();
		uint num = 299.Method0301(text2);
		if (num <= 2472024882U)
		{
			if (num <= 1333443158U)
			{
				if (num <= 772060872U)
				{
					if (num <= 455929684U)
					{
						if (num <= 231034112U)
						{
							if (num != 192097854U)
							{
								if (num == 231034112U && text2 == "inam")
								{
									goto IL_D6A;
								}
							}
							else if (text2 == "streamurl")
							{
								text = array[1].Trim(new char[]
								{
									'\'',
									'"'
								});
								if (text != string.Empty)
								{
									this.9 = text;
									result = true;
								}
								return result;
							}
						}
						else if (num != 330216824U)
						{
							if (num != 355560749U)
							{
								if (num == 455929684U && text2 == "talb")
								{
									goto IL_10CD;
								}
							}
							else if (text2 == "beatsperminute")
							{
								goto IL_1033;
							}
						}
						else if (text2 == "tempo")
						{
							goto IL_1033;
						}
					}
					else if (num <= 572804318U)
					{
						if (num != 532403852U)
						{
							if (num == 572804318U && text2 == "artist")
							{
								goto IL_E04;
							}
						}
						else if (text2 == "icy-url")
						{
							text = array[1].Trim();
							if (text != string.Empty)
							{
								this.9 = text;
								result = true;
							}
							return result;
						}
					}
					else if (num != 577722853U)
					{
						if (num != 737799129U)
						{
							if (num == 772060872U && text2 == "encodedby")
							{
								goto IL_10EE;
							}
						}
						else if (text2 == "tyer")
						{
							goto IL_D49;
						}
					}
					else if (text2 == "ignr")
					{
						goto IL_E25;
					}
				}
				else if (num <= 879019937U)
				{
					if (num <= 837046592U)
					{
						if (num != 812657147U)
						{
							if (num == 837046592U && text2 == "ieng")
							{
								goto IL_DE3;
							}
						}
						else if (text2 == "tdrl")
						{
							goto IL_D49;
						}
					}
					else if (num != 840467959U)
					{
						if (num != 841388516U)
						{
							if (num == 879019937U && text2 == "remixer")
							{
								goto IL_108B;
							}
						}
						else if (text2 == "tit2")
						{
							goto IL_D6A;
						}
					}
					else if (text2 == "tcop")
					{
						goto IL_FF1;
					}
				}
				else if (num <= 890800816U)
				{
					if (num != 879704937U)
					{
						if (num == 890800816U && text2 == "tcom")
						{
							goto IL_DE3;
						}
					}
					else if (text2 == "description")
					{
						goto IL_DAC;
					}
				}
				else if (num != 941133673U)
				{
					if (num != 1205918082U)
					{
						if (num == 1333443158U && text2 == "author")
						{
							goto IL_E04;
						}
					}
					else if (text2 == "tpub")
					{
						goto IL_D8B;
					}
				}
				else if (text2 == "tcon")
				{
					goto IL_E25;
				}
			}
			else if (num <= 1986820544U)
			{
				if (num <= 1694181484U)
				{
					if (num <= 1366625991U)
					{
						if (num != 1333525265U)
						{
							if (num == 1366625991U && text2 == "tool")
							{
								goto IL_10EE;
							}
						}
						else if (text2 == "trck")
						{
							goto IL_10AC;
						}
					}
					else if (num != 1483081738U)
					{
						if (num != 1575106246U)
						{
							if (num == 1694181484U && text2 == "album")
							{
								goto IL_10CD;
							}
						}
						else if (text2 == "bpm")
						{
							goto IL_1033;
						}
					}
					else if (text2 == "iprd")
					{
						goto IL_10CD;
					}
				}
				else if (num <= 1738982494U)
				{
					if (num != 1733853966U)
					{
						if (num == 1738982494U && text2 == "comment")
						{
							goto IL_DAC;
						}
					}
					else if (text2 == "icy-genre")
					{
						goto IL_1012;
					}
				}
				else if (num != 1881263816U)
				{
					if (num != 1931596673U)
					{
						if (num == 1986820544U && text2 == "genre")
						{
							goto IL_1012;
						}
					}
					else if (text2 == "tp2")
					{
						goto IL_108B;
					}
				}
				else if (text2 == "tp1")
				{
					goto IL_E04;
				}
			}
			else if (num <= 2318775059U)
			{
				if (num <= 2183777184U)
				{
					if (num != 2067622972U)
					{
						if (num == 2183777184U && text2 == "icy-name")
						{
							goto IL_10CD;
						}
					}
					else if (text2 == "track")
					{
						goto IL_10AC;
					}
				}
				else if (num != 2228000106U)
				{
					if (num != 2233903452U)
					{
						if (num == 2318775059U && text2 == "composer")
						{
							goto IL_DE3;
						}
					}
					else if (text2 == "tracknum")
					{
						goto IL_10AC;
					}
				}
				else if (text2 == "writer")
				{
					goto IL_DE3;
				}
			}
			else if (num <= 2421692025U)
			{
				if (num != 2349015378U)
				{
					if (num != 2390354663U)
					{
						if (num == 2421692025U && text2 == "isrf")
						{
							goto IL_10EE;
						}
					}
					else if (text2 == "wm/provider")
					{
						goto IL_FF1;
					}
				}
				else if (text2 == "wm/albumartist")
				{
					goto IL_108B;
				}
			}
			else if (num != 2434060901U)
			{
				if (num != 2453864966U)
				{
					if (num == 2472024882U && text2 == "isrc")
					{
						goto IL_D8B;
					}
				}
				else if (text2 == "wm/beatsperminute")
				{
					goto IL_1033;
				}
			}
			else if (text2 == "wm/albumtitle")
			{
				goto IL_10CD;
			}
		}
		else if (num <= 3171021908U)
		{
			if (num <= 2678536424U)
			{
				if (num <= 2585629624U)
				{
					if (num <= 2550397100U)
					{
						if (num != 2482856090U)
						{
							if (num == 2550397100U && text2 == "tda")
							{
								goto IL_D49;
							}
						}
						else if (text2 == "wm/publisher")
						{
							goto IL_D8B;
						}
					}
					else if (num != 2553523123U)
					{
						if (num != 2556802313U)
						{
							if (num == 2585629624U && text2 == "trk")
							{
								goto IL_10AC;
							}
						}
						else if (text2 == "title")
						{
							goto IL_D6A;
						}
					}
					else if (text2 == "itch")
					{
						goto IL_10EE;
					}
				}
				else if (num <= 2616374743U)
				{
					if (num != 2592838589U)
					{
						if (num == 2616374743U && text2 == "tcm")
						{
							goto IL_DE3;
						}
					}
					else if (text2 == "wm/author")
					{
						goto IL_E04;
					}
				}
				else if (num != 2649929981U)
				{
					if (num != 2667001790U)
					{
						if (num == 2678536424U && text2 == "orchestra")
						{
							goto IL_108B;
						}
					}
					else if (text2 == "tal")
					{
						goto IL_10CD;
					}
				}
				else if (text2 == "tco")
				{
					goto IL_E25;
				}
			}
			else if (num <= 2821943313U)
			{
				if (num <= 2712905244U)
				{
					if (num != 2700262838U)
					{
						if (num == 2712905244U && text2 == "tbpm")
						{
							goto IL_1033;
						}
					}
					else if (text2 == "tcr")
					{
						goto IL_FF1;
					}
				}
				else if (num != 2736922385U)
				{
					if (num != 2767520409U)
					{
						if (num == 2821943313U && text2 == "tye")
						{
							goto IL_D49;
						}
					}
					else if (text2 == "tbp")
					{
						goto IL_1033;
					}
				}
				else if (text2 == "tpb")
				{
					goto IL_D8B;
				}
			}
			else if (num <= 3075725865U)
			{
				if (num != 2923983231U)
				{
					if (num != 2927578396U)
					{
						if (num == 3075725865U && text2 == "wm/encodedby")
						{
							goto IL_10EE;
						}
					}
					else if (text2 == "year")
					{
						goto IL_D49;
					}
				}
				else if (text2 == "publisher")
				{
					goto IL_D8B;
				}
			}
			else if (num != 3104697662U)
			{
				if (num != 3162467117U)
				{
					if (num == 3171021908U && text2 == "ten")
					{
						goto IL_10EE;
					}
				}
				else if (text2 == "isbj")
				{
					goto IL_108B;
				}
			}
			else if (text2 == "copyright")
			{
				goto IL_FF1;
			}
		}
		else
		{
			if (num <= 3609456715U)
			{
				if (num <= 3445080013U)
				{
					if (num <= 3239277205U)
					{
						if (num != 3238484687U)
						{
							if (num == 3239277205U && text2 == "tenc")
							{
								goto IL_10EE;
							}
							return result;
						}
						else
						{
							if (text2 == "albumartist")
							{
								goto IL_108B;
							}
							return result;
						}
					}
					else if (num != 3347325063U)
					{
						if (num != 3437799904U)
						{
							if (num == 3445080013U && text2 == "tracknumber")
							{
								goto IL_10AC;
							}
							return result;
						}
						else
						{
							if (text2 == "wm/composer")
							{
								goto IL_DE3;
							}
							return result;
						}
					}
					else
					{
						if (!(text2 == "currentbitrate"))
						{
							return result;
						}
						text = array[1].Trim();
						if (!(text != string.Empty))
						{
							return result;
						}
						try
						{
							this.6 = int.Parse(text) / 1000;
							return result;
						}
						catch
						{
							return result;
						}
					}
				}
				if (num <= 3522494505U)
				{
					if (num != 3483336282U)
					{
						if (num != 3522494505U || !(text2 == "streamtitle"))
						{
							return result;
						}
						text = array[1].Trim(new char[]
						{
							'\'',
							'"'
						});
						if (!(text != string.Empty))
						{
							return result;
						}
						int num2 = text.IndexOf(" - ");
						if (num2 <= 0 || num2 + 3 >= text.Length)
						{
							this.19 = text;
						}
						else
						{
							this.5 = text.Substring(0, num2).Trim();
							this.19 = text.Substring(num2 + 3).Trim();
						}
						return true;
					}
					else
					{
						if (text2 == "ensemble")
						{
							goto IL_108B;
						}
						return result;
					}
				}
				else if (num != 3543308881U)
				{
					if (num != 3564297305U)
					{
						if (num != 3609456715U || !(text2 == "icy-br"))
						{
							return result;
						}
						text = array[1].Trim();
						if (!(text != string.Empty))
						{
							return result;
						}
						try
						{
							this.6 = int.Parse(text);
							return true;
						}
						catch
						{
							return result;
						}
					}
					if (text2 == "date")
					{
						goto IL_D49;
					}
					return result;
				}
				else
				{
					if (text2 == "wm/genre")
					{
						goto IL_1012;
					}
					return result;
				}
				bool result2;
				return result2;
			}
			if (num <= 3969640727U)
			{
				if (num <= 3730857219U)
				{
					if (num != 3694889220U)
					{
						if (num == 3730857219U && text2 == "icrd")
						{
							goto IL_D49;
						}
					}
					else if (text2 == "icmt")
					{
						goto IL_DAC;
					}
				}
				else if (num != 3829404362U)
				{
					if (num != 3945499333U)
					{
						if (num == 3969640727U && text2 == "wm/year")
						{
							goto IL_D49;
						}
					}
					else if (text2 == "tt2")
					{
						goto IL_D6A;
					}
				}
				else if (text2 == "icop")
				{
					goto IL_FF1;
				}
			}
			else if (num <= 4114788297U)
			{
				if (num != 4002128452U)
				{
					if (num != 4052603614U)
					{
						if (num == 4114788297U && text2 == "comm")
						{
							goto IL_DAC;
						}
					}
					else if (text2 == "com")
					{
						goto IL_DAC;
					}
				}
				else if (text2 == "wm/tracknumber")
				{
					goto IL_10AC;
				}
			}
			else if (num != 4139338383U)
			{
				if (num != 4156116002U)
				{
					if (num == 4185316089U && text2 == "iart")
					{
						goto IL_E04;
					}
				}
				else if (text2 == "tpe2")
				{
					goto IL_108B;
				}
			}
			else if (text2 == "tpe1")
			{
				goto IL_E04;
			}
		}
		return result;
		IL_D49:
		text = array[1].Trim();
		if (text != string.Empty)
		{
			this.21 = text;
			result = true;
		}
		return result;
		IL_D6A:
		text = array[1].Trim();
		if (text != string.Empty)
		{
			this.19 = text;
			result = true;
		}
		return result;
		IL_D8B:
		text = array[1].Trim();
		if (text != string.Empty)
		{
			this.18 = text;
			result = true;
		}
		return result;
		IL_DAC:
		text = array[1].Trim();
		if (text != string.Empty && this.1 == 0)
		{
			this.9 = text;
			result = true;
			this.1++;
		}
		return result;
		IL_DE3:
		text = array[1].Trim();
		if (text != string.Empty)
		{
			this.10 = text;
			result = true;
		}
		return result;
		IL_E04:
		text = array[1].Trim();
		if (text != string.Empty)
		{
			this.5 = text;
			result = true;
		}
		return result;
		IL_E25:
		text = array[1].Trim();
		if (!(text != string.Empty))
		{
			return result;
		}
		string[] array2 = text.Split(new char[1]);
		if (array2 == null || array2.Length == 0)
		{
			this.15 = text;
		}
		else
		{
			for (int i = 0; i < array2.Length; i++)
			{
				string text3 = array2[i].Trim();
				if (!(text3 == "RX") && !(text3 == "(RX)"))
				{
					if (!(text3 == "CR") && !(text3 == "(CR)"))
					{
						if (text3.IndexOf('(') < text3.LastIndexOf(')') && text3.Length > 2)
						{
							int num3 = text3.IndexOf('(');
							int num4 = text3.LastIndexOf(')');
							text = text3.Substring(num3 + 1, num4 - num3 - 1);
							try
							{
								array2[i] = Enum.GetName(typeof(934), int.Parse(text));
								if (array2[i] == null)
								{
									array2[i] = text3;
								}
								goto IL_FCC;
							}
							catch
							{
								array2[i] = text3;
								goto IL_FCC;
							}
						}
						array2[i] = text3;
						if (text3.Length >= 4)
						{
							goto IL_FCC;
						}
						bool flag = true;
						text2 = text3;
						for (int j = 0; j < text2.Length; j++)
						{
							if (!char.IsNumber(text2[j]))
							{
								flag = false;
								break;
							}
						}
						if (!flag)
						{
							goto IL_FCC;
						}
						try
						{
							array2[i] = Enum.GetName(typeof(934), int.Parse(text3));
							if (array2[i] == null)
							{
								array2[i] = text3;
							}
							goto IL_FCC;
						}
						catch
						{
							goto IL_FCC;
						}
					}
					array2[i] = "Cover";
				}
				else
				{
					array2[i] = "Remix";
				}
				IL_FCC:;
			}
			this.15 = string.Join(", ", array2);
		}
		return true;
		IL_FF1:
		text = array[1].Trim();
		if (text != string.Empty)
		{
			this.11 = text;
			result = true;
		}
		return result;
		IL_1012:
		text = array[1].Trim();
		if (text != string.Empty)
		{
			this.15 = text;
			result = true;
		}
		return result;
		IL_1033:
		text = array[1].Trim();
		if (!(text != string.Empty))
		{
			return result;
		}
		if (text.ToUpper().EndsWith("BPM"))
		{
			text = text.Substring(0, text.Length - 3).Trim().Trim(new char[]
			{
				'0'
			});
		}
		this.7 = text;
		return true;
		IL_108B:
		text = array[1].Trim();
		if (text != string.Empty)
		{
			this.4 = text;
			result = true;
		}
		return result;
		IL_10AC:
		text = array[1].Trim();
		if (text != string.Empty)
		{
			this.20 = text;
			result = true;
		}
		return result;
		IL_10CD:
		text = array[1].Trim();
		if (text != string.Empty)
		{
			this.3 = text;
			result = true;
		}
		return result;
		IL_10EE:
		text = array[1].Trim();
		if (text != string.Empty)
		{
			this.13 = text;
			result = true;
		}
		return result;
	}

	// Token: 0x06005662 RID: 22114 RVA: 0x002161EC File Offset: 0x002143EC
	public string 2(string 1)
	{
		if (1 != null)
		{
			try
			{
				foreach (object obj in this.16)
				{
					string text = (string)obj;
					if (text.StartsWith(1))
					{
						string[] array = text.Split(new char[]
						{
							'=',
							':'
						}, 2);
						if (array.Length == 2)
						{
							return array[1].Trim();
						}
					}
				}
				return null;
			}
			catch
			{
			}
		}
		return null;
	}

	// Token: 0x06005663 RID: 22115 RVA: 0x0021628C File Offset: 0x0021448C
	internal void Reset()
	{
		this.2 = 0;
		this.1 = 0;
		this.16.Clear();
	}

	// Token: 0x06005664 RID: 22116 RVA: 0x002162A8 File Offset: 0x002144A8
	public override string ToString()
	{
		string text = this.5;
		if (text == string.Empty)
		{
			text = this.4;
		}
		if (text == string.Empty && this.19 != string.Empty)
		{
			return this.19;
		}
		if (text != string.Empty && this.19 == string.Empty)
		{
			return text;
		}
		if (text != string.Empty && this.19 != string.Empty)
		{
			return string.Format("{0} - {1}", text, this.19);
		}
		return Path.GetFileNameWithoutExtension(this.14);
	}

	// Token: 0x06005665 RID: 22117 RVA: 0x00216354 File Offset: 0x00214554
	public bool 3(IntPtr 1, bool 2)
	{
		if (1 == IntPtr.Zero)
		{
			return false;
		}
		bool flag = false;
		this.Reset();
		bool flag2 = true;
		int num = 0;
		IntPtr intPtr = 1;
		UTF8Encoding utf8Encoding = new UTF8Encoding();
		while (flag2)
		{
			string text;
			if (2)
			{
				intPtr = new IntPtr(intPtr.ToInt64() + (long)num);
				text = Marshal.PtrToStringAnsi(intPtr);
				byte[] array = new byte[text.Length];
				Marshal.Copy(intPtr, array, 0, text.Length);
				num = text.Length + 1;
				text = utf8Encoding.GetString(array);
			}
			else
			{
				text = Marshal.PtrToStringAnsi(new IntPtr(intPtr.ToInt64() + (long)num));
				num += text.Length + 1;
			}
			if (text.Length != 0)
			{
				string[] array2 = text.Split(new char[]
				{
					';'
				});
				if (array2.Length != 0)
				{
					foreach (string text2 in array2)
					{
						flag |= this.1(text2.Trim());
					}
				}
				if (text.StartsWith("StreamTitle"))
				{
					flag2 = false;
				}
			}
			else
			{
				flag2 = false;
			}
		}
		return flag;
	}

	// Token: 0x06005666 RID: 22118 RVA: 0x00216463 File Offset: 0x00214663
	public string[] 4()
	{
		return (string[])this.16.ToArray(typeof(string));
	}

	// Token: 0x040043B6 RID: 17334
	private int 1;

	// Token: 0x040043B7 RID: 17335
	private int 2;

	// Token: 0x040043B8 RID: 17336
	public string 3;

	// Token: 0x040043B9 RID: 17337
	public string 4;

	// Token: 0x040043BA RID: 17338
	public string 5;

	// Token: 0x040043BB RID: 17339
	public int 6;

	// Token: 0x040043BC RID: 17340
	public string 7;

	// Token: 0x040043BD RID: 17341
	public 996 8;

	// Token: 0x040043BE RID: 17342
	public string 9;

	// Token: 0x040043BF RID: 17343
	public string 10;

	// Token: 0x040043C0 RID: 17344
	public string 11;

	// Token: 0x040043C1 RID: 17345
	public double 12;

	// Token: 0x040043C2 RID: 17346
	public string 13;

	// Token: 0x040043C3 RID: 17347
	public string 14;

	// Token: 0x040043C4 RID: 17348
	public string 15;

	// Token: 0x040043C5 RID: 17349
	private ArrayList 16;

	// Token: 0x040043C6 RID: 17350
	private ArrayList 17;

	// Token: 0x040043C7 RID: 17351
	public string 18;

	// Token: 0x040043C8 RID: 17352
	public string 19;

	// Token: 0x040043C9 RID: 17353
	public string 20;

	// Token: 0x040043CA RID: 17354
	public string 21;
}
