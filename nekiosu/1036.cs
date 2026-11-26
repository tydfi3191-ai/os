using System;
using System.Runtime.InteropServices;
using System.Security;

// Token: 0x02000CA1 RID: 3233
[ComVisible(false)]
[SuppressUnmanagedCodeSecurity]
public sealed class 1036
{
	// Token: 0x06005645 RID: 22085 RVA: 0x000055AC File Offset: 0x000037AC
	private 1036()
	{
	}

	// Token: 0x06005646 RID: 22086 RVA: 0x0021380C File Offset: 0x00211A0C
	public static bool 1(int 1, 1041 2)
	{
		if (1 == 0 || 2 == null)
		{
			return false;
		}
		bool flag = false;
		996 3 = new 996();
		if (!1025.2(1, 3))
		{
			return flag;
		}
		2.8 = 3;
		1035 4 = (1035)(-1);
		IntPtr intPtr = 1036.2(1, 3, out 4);
		if (intPtr != IntPtr.Zero)
		{
			if (4 <= (1035)256)
			{
				switch (4)
				{
				case (1035)0:
					flag = 1036.3(intPtr, 2);
					break;
				case (1035)1:
					flag = 1036.4(intPtr, 2);
					break;
				case (1035)2:
					flag = 2.3(intPtr, true);
					break;
				case (1035)3:
				case (1035)4:
				case (1035)5:
					break;
				case (1035)6:
					flag = 2.3(intPtr, true);
					break;
				case (1035)7:
					flag = 2.3(intPtr, true);
					break;
				default:
					if (4 == (1035)256)
					{
						flag = 2.3(intPtr, false);
					}
					break;
				}
			}
			else if (4 != (1035)65536)
			{
				if (4 == (1035)69632)
				{
					int num = 0;
					for (;;)
					{
						IntPtr intPtr2 = 1025.BASS_ChannelGetTags(1, (1035)69632 + num);
						if (!(intPtr2 != IntPtr.Zero))
						{
							break;
						}
						flag |= 2.3(intPtr2, false);
						num++;
					}
					if (!flag && 2.4().Length != 0)
					{
						flag = true;
						if (2.4().Length != 0)
						{
							2.19 = 2.4()[0].Trim();
						}
						if (2.4().Length > 1)
						{
							2.5 = 2.4()[1].Trim();
						}
					}
				}
			}
			else
			{
				2.19 = 1025.6(1);
				2.5 = 1025.5(1);
				flag = true;
			}
		}
		2.12 = 1025.BASS_ChannelBytes2Seconds(1, 1025.3(1));
		if (2.6 == 0)
		{
			long num2 = 1025.BASS_StreamGetFilePosition(1, (1008)2);
			2.6 = (int)((double)num2 / (125.0 * 2.12) + 0.5);
		}
		return flag;
	}

	// Token: 0x06005647 RID: 22087 RVA: 0x002139D4 File Offset: 0x00211BD4
	private static IntPtr 2(int 1, 996 2, out 1035 3)
	{
		IntPtr intPtr = IntPtr.Zero;
		3 = (1035)(-1);
		if (1 == 0 || 2 == null)
		{
			return intPtr;
		}
		935 4 = 2.3;
		if ((4 & 935.BASS_CTYPE_STREAM_WAV) > 935.BASS_CTYPE_UNKNOWN)
		{
			4 = 935.BASS_CTYPE_STREAM_WAV;
		}
		if (4 <= 935.BASS_CTYPE_STREAM_MPC)
		{
			if (4 <= 935.BASS_CTYPE_STREAM_WINAMP)
			{
				if (4 <= 935.BASS_CTYPE_STREAM_AIFF)
				{
					if (4 == 935.BASS_CTYPE_MUSIC_MO3)
					{
						goto IL_253;
					}
					switch (4)
					{
					case 935.BASS_CTYPE_STREAM_OGG:
						intPtr = 1025.BASS_ChannelGetTags(1, (1035)2);
						if (!(intPtr == IntPtr.Zero))
						{
							3 = (1035)2;
							return intPtr;
						}
						intPtr = 1025.BASS_ChannelGetTags(1, (1035)6);
						3 = (1035)6;
						return intPtr;
					case 935.BASS_CTYPE_STREAM_MP1:
					case 935.BASS_CTYPE_STREAM_MP2:
					case 935.BASS_CTYPE_STREAM_MP3:
						intPtr = 1025.BASS_ChannelGetTags(1, (1035)1);
						if (!(intPtr == IntPtr.Zero))
						{
							3 = (1035)1;
							return intPtr;
						}
						intPtr = 1025.BASS_ChannelGetTags(1, (1035)0);
						3 = (1035)0;
						return intPtr;
					case 935.BASS_CTYPE_STREAM_AIFF:
						break;
					default:
						goto IL_37C;
					}
				}
				else
				{
					if (4 - 935.BASS_CTYPE_STREAM_WMA <= 1)
					{
						intPtr = 1025.BASS_ChannelGetTags(1, (1035)8);
						3 = (1035)8;
						return intPtr;
					}
					if (4 != 935.BASS_CTYPE_STREAM_WINAMP)
					{
						goto IL_37C;
					}
					intPtr = 1025.BASS_ChannelGetTags(1, (1035)1);
					if (!(intPtr == IntPtr.Zero))
					{
						3 = (1035)1;
						return intPtr;
					}
					intPtr = 1025.BASS_ChannelGetTags(1, (1035)6);
					if (!(intPtr == IntPtr.Zero))
					{
						3 = (1035)6;
						return intPtr;
					}
					intPtr = 1025.BASS_ChannelGetTags(1, (1035)2);
					if (intPtr == IntPtr.Zero)
					{
						intPtr = 1025.BASS_ChannelGetTags(1, (1035)0);
						if (intPtr != IntPtr.Zero)
						{
							3 = (1035)0;
						}
						return intPtr;
					}
					3 = (1035)2;
					return intPtr;
				}
			}
			else if (4 <= 935.BASS_CTYPE_STREAM_OFR)
			{
				if (4 - 935.BASS_CTYPE_STREAM_WV > 3 && 4 != 935.BASS_CTYPE_STREAM_OFR)
				{
					goto IL_37C;
				}
				goto IL_275;
			}
			else
			{
				if (4 != 935.BASS_CTYPE_STREAM_APE && 4 != 935.BASS_CTYPE_STREAM_FLAC && 4 != 935.BASS_CTYPE_STREAM_MPC)
				{
					goto IL_37C;
				}
				goto IL_275;
			}
		}
		else if (4 <= 935.BASS_CTYPE_STREAM_ALAC)
		{
			if (4 <= 935.BASS_CTYPE_STREAM_SPX)
			{
				if (4 - 935.BASS_CTYPE_STREAM_AAC > 1)
				{
					if (4 != 935.BASS_CTYPE_STREAM_SPX)
					{
						goto IL_37C;
					}
					goto IL_275;
				}
			}
			else if (4 != 935.BASS_CTYPE_STREAM_MIDI)
			{
				if (4 != 935.BASS_CTYPE_STREAM_ALAC)
				{
					goto IL_37C;
				}
			}
			else
			{
				intPtr = 1025.BASS_ChannelGetTags(1, (1035)69632);
				if (intPtr == IntPtr.Zero)
				{
					intPtr = 1025.BASS_ChannelGetTags(1, (1035)256);
					3 = (1035)256;
					return intPtr;
				}
				3 = (1035)69632;
				return intPtr;
			}
			intPtr = 1025.BASS_ChannelGetTags(1, (1035)7);
			if (!(intPtr == IntPtr.Zero))
			{
				3 = (1035)7;
				return intPtr;
			}
			intPtr = 1025.BASS_ChannelGetTags(1, (1035)1);
			if (!(intPtr == IntPtr.Zero))
			{
				3 = (1035)1;
				return intPtr;
			}
			intPtr = 1025.BASS_ChannelGetTags(1, (1035)6);
			if (intPtr == IntPtr.Zero)
			{
				intPtr = 1025.BASS_ChannelGetTags(1, (1035)2);
				if (intPtr != IntPtr.Zero)
				{
					3 = (1035)2;
				}
				return intPtr;
			}
			3 = (1035)6;
			return intPtr;
		}
		else if (4 <= 935.BASS_CTYPE_MUSIC_IT)
		{
			if (4 == 935.BASS_CTYPE_STREAM_TTA)
			{
				goto IL_275;
			}
			if (4 - 935.BASS_CTYPE_MUSIC_MOD > 4)
			{
				goto IL_37C;
			}
			goto IL_253;
		}
		else if (4 != 935.BASS_CTYPE_STREAM_WAV && 4 != 935.BASS_CTYPE_STREAM_WAV_PCM && 4 != 935.BASS_CTYPE_STREAM_WAV_FLOAT)
		{
			goto IL_37C;
		}
		intPtr = 1025.BASS_ChannelGetTags(1, (1035)256);
		if (intPtr != IntPtr.Zero)
		{
			3 = (1035)256;
		}
		return intPtr;
		IL_253:
		intPtr = 1025.BASS_ChannelGetTags(1, (1035)65536);
		if (intPtr != IntPtr.Zero)
		{
			3 = (1035)65536;
		}
		return intPtr;
		IL_275:
		intPtr = 1025.BASS_ChannelGetTags(1, (1035)6);
		if (!(intPtr == IntPtr.Zero))
		{
			3 = (1035)6;
			return intPtr;
		}
		intPtr = 1025.BASS_ChannelGetTags(1, (1035)2);
		if (!(intPtr == IntPtr.Zero))
		{
			3 = (1035)2;
			return intPtr;
		}
		intPtr = 1025.BASS_ChannelGetTags(1, (1035)1);
		if (intPtr == IntPtr.Zero)
		{
			intPtr = 1025.BASS_ChannelGetTags(1, (1035)0);
			if (intPtr != IntPtr.Zero)
			{
				3 = (1035)0;
			}
			return intPtr;
		}
		3 = (1035)1;
		return intPtr;
		IL_37C:
		return IntPtr.Zero;
	}

	// Token: 0x06005648 RID: 22088 RVA: 0x00213D64 File Offset: 0x00211F64
	private static bool 3(IntPtr 1, 1041 2)
	{
		if (1 == IntPtr.Zero || 2 == null)
		{
			return false;
		}
		if (Marshal.PtrToStringAnsi(1, 3) != "TAG")
		{
			return false;
		}
		new IntPtr(1.ToInt64() + 3L);
		2.19 = Marshal.PtrToStringAnsi(1, 30).TrimEnd(new char[1]);
		int num = 2.19.IndexOf('\0');
		if (num > 0)
		{
			2.19 = 2.19.Substring(0, num).Trim();
		}
		else if (2.19.Length >= 30)
		{
			2.19 = 2.19.Substring(0, 30).Trim();
		}
		1 = new IntPtr(1.ToInt64() + 30L);
		2.5 = Marshal.PtrToStringAnsi(1, 30).TrimEnd(new char[1]);
		num = 2.5.IndexOf('\0');
		if (num > 0)
		{
			2.5 = 2.5.Substring(0, num).Trim();
		}
		else if (2.5.Length >= 30)
		{
			2.5 = 2.5.Substring(0, 30).Trim();
		}
		1 = new IntPtr(1.ToInt64() + 30L);
		2.3 = Marshal.PtrToStringAnsi(1, 30).TrimEnd(new char[1]);
		num = 2.3.IndexOf('\0');
		if (num > 0)
		{
			2.3 = 2.3.Substring(0, num).Trim();
		}
		else if (2.3.Length >= 30)
		{
			2.3 = 2.3.Substring(0, 30).Trim();
		}
		1 = new IntPtr(1.ToInt64() + 30L);
		2.21 = Marshal.PtrToStringAnsi(1, 4).TrimEnd(new char[1]);
		num = 2.21.IndexOf('\0');
		if (num > 0)
		{
			2.21 = 2.21.Substring(0, num).Trim();
		}
		else if (2.21.Length >= 4)
		{
			2.21 = 2.21.Substring(0, 4).Trim();
		}
		1 = new IntPtr(1.ToInt64() + 4L);
		2.9 = Marshal.PtrToStringAnsi(1, 30).TrimEnd(new char[1]);
		num = 2.9.IndexOf('\0');
		if (num > 0)
		{
			2.9 = 2.9.Substring(0, num).Trim();
		}
		else if (2.9.Length >= 30)
		{
			2.9 = 2.9.Substring(0, 30).Trim();
		}
		1 = new IntPtr(1.ToInt64() + 30L);
		int num2 = (int)Marshal.ReadByte(1);
		try
		{
			2.15 = Enum.GetName(typeof(934), num2);
		}
		catch
		{
			2.15 = 934.Unknown.ToString();
		}
		return true;
	}

	// Token: 0x06005649 RID: 22089 RVA: 0x0021406C File Offset: 0x0021226C
	private static bool 4(IntPtr 1, 1041 2)
	{
		if (1 == IntPtr.Zero || 2 == null)
		{
			return false;
		}
		try
		{
			2.Reset();
			542 3 = new 542(1);
			while (3.Method6856())
			{
				string text5438_ = 3.GetText5438_6854();
				object value5439_ = 3.GetValue5439_6855();
				if (text5438_.Length > 0 && value5439_ is string)
				{
					2.1(string.Format("{0}={1}", text5438_, value5439_));
				}
			}
			3.Method6852();
		}
		catch
		{
			return false;
		}
		return true;
	}
}
