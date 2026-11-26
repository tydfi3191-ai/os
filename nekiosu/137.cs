using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

// Token: 0x020000DE RID: 222
[242(1)]
[241(0)]
public struct 137
{
	// Token: 0x060005AB RID: 1451 RVA: 0x0001275A File Offset: 0x0001095A
	public 137(131 1)
	{
		this.jsonContainerType2 = 1;
		this.flag = 137.Method3520(1);
		this.number = -1;
		this.text3 = null;
	}

	// Token: 0x060005AC RID: 1452 RVA: 0x00012780 File Offset: 0x00010980
	internal int Method3518()
	{
		131 <<EMPTY_NAME>> = this.jsonContainerType2;
		if (<<EMPTY_NAME>> == 131.Object)
		{
			return this.text3.Length + 5;
		}
		if (<<EMPTY_NAME>> - 131.Array > 1)
		{
			throw new ArgumentOutOfRangeException("Type");
		}
		return 421.Method3211((ulong)((long)this.number)) + 2;
	}

	// Token: 0x060005AD RID: 1453 RVA: 0x000127C8 File Offset: 0x000109C8
	[242(2)]
	internal void Method3519([241(1)] StringBuilder 1, ref StringWriter 2, ref char[] 3)
	{
		131 4 = this.jsonContainerType2;
		if (4 != 131.Object)
		{
			if (4 - 131.Array > 1)
			{
				return;
			}
			1.Append('[');
			1.Append(this.number);
			1.Append(']');
			return;
		}
		else
		{
			string text = this.text3;
			if (text.IndexOfAny(137.charArray2) != -1)
			{
				1.Append("['");
				if (2 == null)
				{
					2 = new StringWriter(1);
				}
				473.Method4462(2, text, '\'', false, 473.flagArray2, (925)0, null, ref 3);
				1.Append("']");
				return;
			}
			if (1.Length > 0)
			{
				1.Append('.');
			}
			1.Append(text);
			return;
		}
	}

	// Token: 0x060005AE RID: 1454 RVA: 0x0001286E File Offset: 0x00010A6E
	internal static bool Method3520(131 1)
	{
		return 1 == 131.Array || 1 == 131.Constructor;
	}

	// Token: 0x060005AF RID: 1455 RVA: 0x0001287C File Offset: 0x00010A7C
	internal static string Method3521(List<137> 1, 137? 2)
	{
		int num = 0;
		if (1 != null)
		{
			for (int i = 0; i < 1.Count; i++)
			{
				num += 1[i].Method3518();
			}
		}
		if (2 != null)
		{
			num += 2.GetValueOrDefault().Method3518();
		}
		StringBuilder stringBuilder = new StringBuilder(num);
		StringWriter stringWriter = null;
		char[] array = null;
		if (1 != null)
		{
			foreach (137 3 in 1)
			{
				3.Method3519(stringBuilder, ref stringWriter, ref array);
			}
		}
		if (2 != null)
		{
			2.GetValueOrDefault().Method3519(stringBuilder, ref stringWriter, ref array);
		}
		return stringBuilder.ToString();
	}

	// Token: 0x060005B0 RID: 1456 RVA: 0x00012950 File Offset: 0x00010B50
	internal static string Method3522([241(2)] 99 1, string 2, string 3)
	{
		if (!3.EndsWith(Environment.NewLine, StringComparison.Ordinal))
		{
			3 = 3.Trim();
			if (!3.Method6844('.'))
			{
				3 += ".";
			}
			3 += " ";
		}
		3 += "Path '{0}'".Method6825(CultureInfo.InvariantCulture, 2);
		if (1 != null && 1.HasLineInfo())
		{
			3 += ", line {0}, position {1}".Method6825(CultureInfo.InvariantCulture, 1.GetLineNumber(), 1.GetLinePosition());
		}
		3 += ".";
		return 3;
	}

	// Token: 0x04000436 RID: 1078
	private static readonly char[] charArray2 = new char[]
	{
		'.',
		' ',
		'\'',
		'/',
		'"',
		'[',
		']',
		'(',
		')',
		'\t',
		'\n',
		'\r',
		'\f',
		'\b',
		'\\',
		'\u0085',
		'\u2028',
		'\u2029'
	};

	// Token: 0x04000437 RID: 1079
	internal 131 jsonContainerType2;

	// Token: 0x04000438 RID: 1080
	internal int number;

	// Token: 0x04000439 RID: 1081
	[241(2)]
	internal string text3;

	// Token: 0x0400043A RID: 1082
	internal bool flag;
}
