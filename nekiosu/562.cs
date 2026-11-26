using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

// Token: 0x02000160 RID: 352
[241(0)]
[242(1)]
public sealed class 562 : 781
{
	// Token: 0x06000C0E RID: 3086 RVA: 0x0002B90C File Offset: 0x00029B0C
	public 562(696 1, object 2, [241(2)] object 3) : base(1)
	{
		this.value3 = 2;
		this.value4 = 3;
	}

	// Token: 0x06000C0F RID: 3087 RVA: 0x0002B924 File Offset: 0x00029B24
	private IEnumerable<226> Method7746(226 1, 226 2, [241(2)] object 3)
	{
		226 4 = 3 as 226;
		if (4 != null)
		{
			return new 226[]
			{
				4
			};
		}
		List<368> list = 3 as List<368>;
		if (list != null)
		{
			return 113.Method12272(list, 1, 2, null);
		}
		return 418.GetItemArray2540_3182<226>();
	}

	// Token: 0x06000C10 RID: 3088 RVA: 0x0002B960 File Offset: 0x00029B60
	public override bool Method12763(226 1, 226 2, [241(2)] 541 3)
	{
		if (this._recoveredType19089989 == (696)3)
		{
			return this.Method7746(1, 2, this.value3).Any<226>();
		}
		using (IEnumerator<226> enumerator = this.Method7746(1, 2, this.value3).GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				IEnumerable<226> enumerable = this.Method7746(1, 2, this.value4);
				ICollection<226> collection = (enumerable as ICollection<226>) ?? enumerable.ToList<226>();
				do
				{
					226 4 = enumerator.Current;
					foreach (226 5 in collection)
					{
						if (this.Method7748(4, 5, 3))
						{
							return true;
						}
					}
				}
				while (enumerator.MoveNext());
			}
		}
		return false;
	}

	// Token: 0x06000C11 RID: 3089 RVA: 0x0002BA3C File Offset: 0x00029C3C
	private bool Method7748(226 1, 226 2, [241(2)] 541 3)
	{
		233 4 = 1 as 233;
		if (4 != null)
		{
			233 5 = 2 as 233;
			if (5 != null)
			{
				switch (this._recoveredType19089989)
				{
				case (696)1:
					if (562.Method7750(4, 5))
					{
						return true;
					}
					return false;
				case (696)2:
					if (!562.Method7750(4, 5))
					{
						return true;
					}
					return false;
				case (696)3:
					return true;
				case (696)4:
					if (4.CompareTo(5) < 0)
					{
						return true;
					}
					return false;
				case (696)5:
					if (4.CompareTo(5) <= 0)
					{
						return true;
					}
					return false;
				case (696)6:
					if (4.CompareTo(5) > 0)
					{
						return true;
					}
					return false;
				case (696)7:
					if (4.CompareTo(5) >= 0)
					{
						return true;
					}
					return false;
				case (696)8:
				case (696)9:
					return false;
				case (696)10:
					if (562.Method7749(4, 5, 3))
					{
						return true;
					}
					return false;
				case (696)11:
					if (562.Method7751(4, 5))
					{
						return true;
					}
					return false;
				case (696)12:
					if (!562.Method7751(4, 5))
					{
						return true;
					}
					return false;
				default:
					return false;
				}
			}
		}
		if (this._recoveredType19089989 - (696)2 <= 1)
		{
			return true;
		}
		return false;
	}

	// Token: 0x06000C12 RID: 3090 RVA: 0x0002BB1C File Offset: 0x00029D1C
	private static bool Method7749(233 1, 233 2, [241(2)] 541 3)
	{
		if (1.Type != 705.String || 2.Type != 705.String)
		{
			return false;
		}
		string text = (string)2.Value;
		int num = text.LastIndexOf('/');
		string pattern = text.Substring(1, num - 1);
		string 4 = text.Substring(num + 1);
		return Regex.IsMatch((string)1.Value, pattern, 736.Method11635(4));
	}

	// Token: 0x06000C13 RID: 3091 RVA: 0x0002BB7C File Offset: 0x00029D7C
	internal static bool Method7750(233 1, 233 2)
	{
		if (1.Equals(2))
		{
			return true;
		}
		if ((1.Type == 705.Integer && 2.Type == 705.Float) || (1.Type == 705.Float && 2.Type == 705.Integer))
		{
			return 233.Method14358(1.Type, 1.Value, 2.Value) == 0;
		}
		if (2.Type != 705.String)
		{
			return false;
		}
		string b = (string)2.Value;
		string a;
		switch (1.Type)
		{
		case 705.Date:
			using (StringWriter stringWriter = 538.Method6831(64))
			{
				object value = 1.Value;
				if (value is DateTimeOffset)
				{
					DateTimeOffset 3 = (DateTimeOffset)value;
					382.Method2136(stringWriter, 3, (47)0, null, CultureInfo.InvariantCulture);
				}
				else
				{
					382.Method2131(stringWriter, (DateTime)1.Value, (47)0, null, CultureInfo.InvariantCulture);
				}
				a = stringWriter.ToString();
				goto IL_122;
			}
			break;
		case 705.Raw:
			return false;
		case 705.Bytes:
			break;
		case 705.Guid:
		case 705.TimeSpan:
			a = 1.Value.ToString();
			goto IL_122;
		case 705.Uri:
			a = ((Uri)1.Value).OriginalString;
			goto IL_122;
		default:
			return false;
		}
		a = Convert.ToBase64String((byte[])1.Value);
		IL_122:
		return string.Equals(a, b, StringComparison.Ordinal);
	}

	// Token: 0x06000C14 RID: 3092 RVA: 0x0002BCC4 File Offset: 0x00029EC4
	internal static bool Method7751(233 1, 233 2)
	{
		if ((1.Type == 705.Integer && 2.Type == 705.Float) || (1.Type == 705.Float && 2.Type == 705.Integer))
		{
			return 233.Method14358(1.Type, 1.Value, 2.Value) == 0;
		}
		return 1.Type == 2.Type && 1.Equals(2);
	}

	// Token: 0x040005EE RID: 1518
	public readonly object value3;

	// Token: 0x040005EF RID: 1519
	[241(2)]
	public readonly object value4;
}
