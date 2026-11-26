using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;

// Token: 0x020000E6 RID: 230
[ComVisible(false)]
[242(1)]
[241(0)]
public abstract class 173 : IDisposable
{
	// Token: 0x17000052 RID: 82
	// (get) Token: 0x060006B6 RID: 1718 RVA: 0x00017B9E File Offset: 0x00015D9E
	// (set) Token: 0x060006B7 RID: 1719 RVA: 0x00017BA6 File Offset: 0x00015DA6
	[241(2)]
	public string DateFormatString
	{
		[242(2)]
		get
		{
			return this.text3;
		}
		[242(2)]
		set
		{
			this.text3 = value;
		}
	}

	// Token: 0x060006B8 RID: 1720 RVA: 0x00017BB0 File Offset: 0x00015DB0
	static 173()
	{
		173._recoveredType1272ArrayArray5701 = 173.Method7314();
	}

	// Token: 0x060006B9 RID: 1721 RVA: 0x00017C7A File Offset: 0x00015E7A
	protected 173()
	{
		this.writerState2 = 173.174.Start;
		this.formatting2 = (95)0;
		this.dateTimeZoneHandling2 = (49)3;
		this.SetCloseOutput(true);
		this.SetAutoCompleteOnClose(true);
	}

	// Token: 0x060006BA RID: 1722 RVA: 0x00017CA8 File Offset: 0x00015EA8
	internal static 173.174[][] Method7314()
	{
		List<173.174[]> list = 173._recoveredType1272ArrayArray5702.ToList<173.174[]>();
		173.174[] item = 173._recoveredType1272ArrayArray5702[0];
		173.174[] item2 = 173._recoveredType1272ArrayArray5702[7];
		foreach (ulong num in 83.GetEnumValuesAndNames(typeof(216)).numberArray2)
		{
			if (list.Count <= (int)num)
			{
				216 <<EMPTY_NAME>> = (216)num;
				if (<<EMPTY_NAME>> - 216.Integer <= 5 || <<EMPTY_NAME>> - 216.Date <= 1)
				{
					list.Add(item2);
				}
				else
				{
					list.Add(item);
				}
			}
		}
		return list.ToArray();
	}

	// Token: 0x060006BB RID: 1723 RVA: 0x00017D32 File Offset: 0x00015F32
	public bool GetCloseOutput()
	{
		return this.flag4;
	}

	// Token: 0x060006BC RID: 1724 RVA: 0x00017D3A File Offset: 0x00015F3A
	public void SetCloseOutput(bool 1)
	{
		this.flag4 = 1;
	}

	// Token: 0x060006BD RID: 1725 RVA: 0x00017D43 File Offset: 0x00015F43
	public bool GetAutoCompleteOnClose()
	{
		return this.flag5;
	}

	// Token: 0x060006BE RID: 1726 RVA: 0x00017D4B File Offset: 0x00015F4B
	public void SetAutoCompleteOnClose(bool 1)
	{
		this.flag5 = 1;
	}

	// Token: 0x060006BF RID: 1727 RVA: 0x00017D54 File Offset: 0x00015F54
	protected internal int GetTop()
	{
		List<137> list = this.list2;
		int num = (list != null) ? list.Count : 0;
		if (this.GetRecoveredType24302792_7339() != 131.None)
		{
			num++;
		}
		return num;
	}

	// Token: 0x060006C0 RID: 1728 RVA: 0x00017D84 File Offset: 0x00015F84
	public 983 GetWriteState()
	{
		switch (this.writerState2)
		{
		case 173.174.Start:
			return (983)6;
		case 173.174.Property:
			return (983)5;
		case 173.174.ObjectStart:
		case 173.174.Object:
			return (983)2;
		case 173.174.ArrayStart:
		case 173.174.Array:
			return (983)3;
		case 173.174.ConstructorStart:
		case 173.174.Constructor:
			return (983)4;
		case 173.174.Closed:
			return (983)1;
		case 173.174.Error:
			return (983)0;
		default:
			throw 763.Method12341(this, "Invalid state: " + this.writerState2.ToString(), null);
		}
	}

	// Token: 0x060006C1 RID: 1729 RVA: 0x00017DF8 File Offset: 0x00015FF8
	internal string GetContainerPath()
	{
		if (this.jsonPosition.jsonContainerType2 == 131.None || this.list2 == null)
		{
			return string.Empty;
		}
		return 137.Method3521(this.list2, null);
	}

	// Token: 0x060006C2 RID: 1730 RVA: 0x00017E34 File Offset: 0x00016034
	public string GetPath()
	{
		if (this.jsonPosition.jsonContainerType2 == 131.None)
		{
			return string.Empty;
		}
		137? <<EMPTY_NAME>> = (this.writerState2 != 173.174.ArrayStart && this.writerState2 != 173.174.ConstructorStart && this.writerState2 != 173.174.ObjectStart) ? new 137?(this.jsonPosition) : null;
		return 137.Method3521(this.list2, <<EMPTY_NAME>>);
	}

	// Token: 0x060006C3 RID: 1731 RVA: 0x00017E92 File Offset: 0x00016092
	public 95 GetFormatting()
	{
		return this.formatting2;
	}

	// Token: 0x060006C4 RID: 1732 RVA: 0x00017E9A File Offset: 0x0001609A
	public void SetFormatting(95 1)
	{
		if (1 < (95)0 || 1 > (95)1)
		{
			throw new ArgumentOutOfRangeException("value");
		}
		this.formatting2 = 1;
	}

	// Token: 0x060006C5 RID: 1733 RVA: 0x00017EB6 File Offset: 0x000160B6
	public 47 GetDateFormatHandling()
	{
		return this.dateFormatHandling2;
	}

	// Token: 0x060006C6 RID: 1734 RVA: 0x00017EBE File Offset: 0x000160BE
	public void SetDateFormatHandling(47 1)
	{
		if (1 < (47)0 || 1 > (47)1)
		{
			throw new ArgumentOutOfRangeException("value");
		}
		this.dateFormatHandling2 = 1;
	}

	// Token: 0x060006C7 RID: 1735 RVA: 0x00017EDA File Offset: 0x000160DA
	public 49 GetDateTimeZoneHandling()
	{
		return this.dateTimeZoneHandling2;
	}

	// Token: 0x060006C8 RID: 1736 RVA: 0x00017EE2 File Offset: 0x000160E2
	public void SetDateTimeZoneHandling(49 1)
	{
		if (1 < (49)0 || 1 > (49)3)
		{
			throw new ArgumentOutOfRangeException("value");
		}
		this.dateTimeZoneHandling2 = 1;
	}

	// Token: 0x060006C9 RID: 1737 RVA: 0x00017EFE File Offset: 0x000160FE
	public 925 GetStringEscapeHandling()
	{
		return this.stringEscapeHandling2;
	}

	// Token: 0x060006CA RID: 1738 RVA: 0x00017F06 File Offset: 0x00016106
	public void SetStringEscapeHandling(925 1)
	{
		if (1 < (925)0 || 1 > (925)2)
		{
			throw new ArgumentOutOfRangeException("value");
		}
		this.stringEscapeHandling2 = 1;
		this.Method2961();
	}

	// Token: 0x060006CB RID: 1739 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal virtual void Method2961()
	{
	}

	// Token: 0x060006CC RID: 1740 RVA: 0x00017F28 File Offset: 0x00016128
	public 93 GetFloatFormatHandling()
	{
		return this.floatFormatHandling2;
	}

	// Token: 0x060006CD RID: 1741 RVA: 0x00017F30 File Offset: 0x00016130
	public void SetFloatFormatHandling(93 1)
	{
		if (1 < (93)0 || 1 > (93)2)
		{
			throw new ArgumentOutOfRangeException("value");
		}
		this.floatFormatHandling2 = 1;
	}

	// Token: 0x060006CE RID: 1742 RVA: 0x00017F4C File Offset: 0x0001614C
	public CultureInfo GetCulture()
	{
		return this.cultureInfo2 ?? CultureInfo.InvariantCulture;
	}

	// Token: 0x060006CF RID: 1743 RVA: 0x00017F5D File Offset: 0x0001615D
	public void SetCulture(CultureInfo 1)
	{
		this.cultureInfo2 = 1;
	}

	// Token: 0x060006D0 RID: 1744 RVA: 0x00017F66 File Offset: 0x00016166
	internal void Method7336()
	{
		if (this.jsonPosition.flag)
		{
			this.jsonPosition.number = this.jsonPosition.number + 1;
		}
	}

	// Token: 0x060006D1 RID: 1745 RVA: 0x00017F85 File Offset: 0x00016185
	private void Method7337(131 1)
	{
		if (this.jsonPosition.jsonContainerType2 != 131.None)
		{
			if (this.list2 == null)
			{
				this.list2 = new List<137>();
			}
			this.list2.Add(this.jsonPosition);
		}
		this.jsonPosition = new 137(1);
	}

	// Token: 0x060006D2 RID: 1746 RVA: 0x00017FC4 File Offset: 0x000161C4
	private 131 Method7338()
	{
		ref 137 ptr = this.jsonPosition;
		if (this.list2 != null && this.list2.Count > 0)
		{
			this.jsonPosition = this.list2[this.list2.Count - 1];
			this.list2.RemoveAt(this.list2.Count - 1);
		}
		else
		{
			this.jsonPosition = default(137);
		}
		return ptr.jsonContainerType2;
	}

	// Token: 0x060006D3 RID: 1747 RVA: 0x00018036 File Offset: 0x00016236
	private 131 GetRecoveredType24302792_7339()
	{
		return this.jsonPosition.jsonContainerType2;
	}

	// Token: 0x060006D4 RID: 1748
	public abstract void Flush();

	// Token: 0x060006D5 RID: 1749 RVA: 0x00018043 File Offset: 0x00016243
	public virtual void Close()
	{
		if (this.GetAutoCompleteOnClose())
		{
			this.Method7361();
		}
	}

	// Token: 0x060006D6 RID: 1750 RVA: 0x00018053 File Offset: 0x00016253
	public virtual void WriteStartObject()
	{
		this.Method7424(216.StartObject, 131.Object);
	}

	// Token: 0x060006D7 RID: 1751 RVA: 0x0001805D File Offset: 0x0001625D
	public virtual void WriteEndObject()
	{
		this.Method7421(131.Object);
	}

	// Token: 0x060006D8 RID: 1752 RVA: 0x00018066 File Offset: 0x00016266
	public virtual void WriteStartArray()
	{
		this.Method7424(216.StartArray, 131.Array);
	}

	// Token: 0x060006D9 RID: 1753 RVA: 0x00018070 File Offset: 0x00016270
	public virtual void WriteEndArray()
	{
		this.Method7421(131.Array);
	}

	// Token: 0x060006DA RID: 1754 RVA: 0x00018079 File Offset: 0x00016279
	public virtual void WriteStartConstructor(string 1)
	{
		this.Method7424(216.StartConstructor, 131.Constructor);
	}

	// Token: 0x060006DB RID: 1755 RVA: 0x00018083 File Offset: 0x00016283
	public virtual void WriteEndConstructor()
	{
		this.Method7421(131.Constructor);
	}

	// Token: 0x060006DC RID: 1756 RVA: 0x0001808C File Offset: 0x0001628C
	public virtual void WritePropertyName(string 1)
	{
		this.Method7422(1);
	}

	// Token: 0x060006DD RID: 1757 RVA: 0x00018095 File Offset: 0x00016295
	public virtual void WritePropertyName(string 1, bool 2)
	{
		this.WritePropertyName(1);
	}

	// Token: 0x060006DE RID: 1758 RVA: 0x0001809E File Offset: 0x0001629E
	public virtual void WriteEnd()
	{
		this.WriteEnd(this.GetRecoveredType24302792_7339());
	}

	// Token: 0x060006DF RID: 1759 RVA: 0x000180AC File Offset: 0x000162AC
	public void WriteToken(139 1)
	{
		this.WriteToken(1, true);
	}

	// Token: 0x060006E0 RID: 1760 RVA: 0x000180B6 File Offset: 0x000162B6
	public void WriteToken(139 1, bool 2)
	{
		756.Method12216(1, "reader");
		this.WriteToken(1, 2, true, true);
	}

	// Token: 0x060006E1 RID: 1761 RVA: 0x000180D0 File Offset: 0x000162D0
	[242(2)]
	public void WriteToken(216 1, object 2)
	{
		switch (1)
		{
		case 216.None:
			return;
		case 216.StartObject:
			this.WriteStartObject();
			return;
		case 216.StartArray:
			this.WriteStartArray();
			return;
		case 216.StartConstructor:
			756.Method12216(2, "value");
			this.WriteStartConstructor(2.ToString());
			return;
		case 216.PropertyName:
			756.Method12216(2, "value");
			this.WritePropertyName(2.ToString());
			return;
		case 216.Comment:
			this.WriteComment((2 != null) ? 2.ToString() : null);
			return;
		case 216.Raw:
			this.WriteRawValue((2 != null) ? 2.ToString() : null);
			return;
		case 216.Integer:
			756.Method12216(2, "value");
			if (2 is BigInteger)
			{
				BigInteger bigInteger = (BigInteger)2;
				this.WriteValue(bigInteger);
				return;
			}
			this.WriteValue(Convert.ToInt64(2, CultureInfo.InvariantCulture));
			return;
		case 216.Float:
			756.Method12216(2, "value");
			if (2 is decimal)
			{
				decimal 3 = (decimal)2;
				this.WriteValue(3);
				return;
			}
			if (2 is double)
			{
				double 4 = (double)2;
				this.WriteValue(4);
				return;
			}
			if (2 is float)
			{
				float 5 = (float)2;
				this.WriteValue(5);
				return;
			}
			this.WriteValue(Convert.ToDouble(2, CultureInfo.InvariantCulture));
			return;
		case 216.String:
			this.WriteValue((2 != null) ? 2.ToString() : null);
			return;
		case 216.Boolean:
			756.Method12216(2, "value");
			this.WriteValue(Convert.ToBoolean(2, CultureInfo.InvariantCulture));
			return;
		case 216.Null:
			this.WriteNull();
			return;
		case 216.Undefined:
			this.WriteUndefined();
			return;
		case 216.EndObject:
			this.WriteEndObject();
			return;
		case 216.EndArray:
			this.WriteEndArray();
			return;
		case 216.EndConstructor:
			this.WriteEndConstructor();
			return;
		case 216.Date:
			756.Method12216(2, "value");
			if (2 is DateTimeOffset)
			{
				DateTimeOffset 6 = (DateTimeOffset)2;
				this.WriteValue(6);
				return;
			}
			this.WriteValue(Convert.ToDateTime(2, CultureInfo.InvariantCulture));
			return;
		case 216.Bytes:
			756.Method12216(2, "value");
			if (2 is Guid)
			{
				Guid 7 = (Guid)2;
				this.WriteValue(7);
				return;
			}
			this.WriteValue((byte[])2);
			return;
		default:
			throw 736.Method11629("token", 1, "Unexpected token type.");
		}
	}

	// Token: 0x060006E2 RID: 1762 RVA: 0x000182FF File Offset: 0x000164FF
	public void WriteToken(216 1)
	{
		this.WriteToken(1, null);
	}

	// Token: 0x060006E3 RID: 1763 RVA: 0x0001830C File Offset: 0x0001650C
	internal virtual void WriteToken(139 1, bool 2, bool 3, bool 4)
	{
		int num = this.Method7357(1);
		for (;;)
		{
			if (!3 || 1.GetTokenType() != 216.StartConstructor)
			{
				goto IL_3C;
			}
			object value = 1.GetValue();
			if (!string.Equals((value != null) ? value.ToString() : null, "Date", StringComparison.Ordinal))
			{
				goto IL_3C;
			}
			this.Method7359(1);
			IL_5B:
			if (num - 1 >= 1.GetDepth() - ((169.IsEndToken(1.GetTokenType()) > false) ? 1 : 0) || !2 || !1.Read())
			{
				break;
			}
			continue;
			IL_3C:
			if (4 || 1.GetTokenType() != 216.Comment)
			{
				this.WriteToken(1.GetTokenType(), 1.GetValue());
				goto IL_5B;
			}
			goto IL_5B;
		}
		if (this.Method7356(1, 2, num))
		{
			throw 763.Method12341(this, "Unexpected end when reading token.", null);
		}
	}

	// Token: 0x060006E4 RID: 1764 RVA: 0x000183B4 File Offset: 0x000165B4
	private bool Method7356(139 1, bool 2, int 3)
	{
		int num = this.Method7358(1);
		return 3 < num || (2 && 3 == num && 169.IsStartToken(1.GetTokenType()));
	}

	// Token: 0x060006E5 RID: 1765 RVA: 0x000183E4 File Offset: 0x000165E4
	private int Method7357(139 1)
	{
		216 tokenType = 1.GetTokenType();
		if (tokenType == 216.None)
		{
			return -1;
		}
		if (!169.IsStartToken(tokenType))
		{
			return 1.GetDepth() + 1;
		}
		return 1.GetDepth();
	}

	// Token: 0x060006E6 RID: 1766 RVA: 0x00018414 File Offset: 0x00016614
	private int Method7358(139 1)
	{
		216 tokenType = 1.GetTokenType();
		if (tokenType == 216.None)
		{
			return -1;
		}
		if (!169.IsEndToken(tokenType))
		{
			return 1.GetDepth();
		}
		return 1.GetDepth() - 1;
	}

	// Token: 0x060006E7 RID: 1767 RVA: 0x00018444 File Offset: 0x00016644
	private void Method7359(139 1)
	{
		DateTime 2;
		string 3;
		if (!473.Method4465(1, out 2, out 3))
		{
			throw 763.Method12341(this, 3, null);
		}
		this.WriteValue(2);
	}

	// Token: 0x060006E8 RID: 1768 RVA: 0x00018470 File Offset: 0x00016670
	private void WriteEnd(131 1)
	{
		switch (1)
		{
		case 131.Object:
			this.WriteEndObject();
			return;
		case 131.Array:
			this.WriteEndArray();
			return;
		case 131.Constructor:
			this.WriteEndConstructor();
			return;
		default:
			throw 763.Method12341(this, "Unexpected type when writing end: " + 1.ToString(), null);
		}
	}

	// Token: 0x060006E9 RID: 1769 RVA: 0x000184C6 File Offset: 0x000166C6
	private void Method7361()
	{
		while (this.GetTop() > 0)
		{
			this.WriteEnd();
		}
	}

	// Token: 0x060006EA RID: 1770 RVA: 0x000184DC File Offset: 0x000166DC
	private 216 Method7362(131 1)
	{
		216 result;
		switch (1)
		{
		case 131.Object:
			result = 216.EndObject;
			break;
		case 131.Array:
			result = 216.EndArray;
			break;
		case 131.Constructor:
			result = 216.EndConstructor;
			break;
		default:
			throw 763.Method12341(this, "No close token for type: " + 1.ToString(), null);
		}
		return result;
	}

	// Token: 0x060006EB RID: 1771 RVA: 0x00018530 File Offset: 0x00016730
	private void Method7363(131 1)
	{
		int num = this.Method7364(1);
		for (int i = 0; i < num; i++)
		{
			216 2 = this.Method7362(this.Method7338());
			if (this.writerState2 == 173.174.Property)
			{
				this.WriteNull();
			}
			if (this.formatting2 == (95)1 && this.writerState2 != 173.174.ObjectStart && this.writerState2 != 173.174.ArrayStart)
			{
				this.Method2963();
			}
			this.WriteEnd(2);
			this.Method7365();
		}
	}

	// Token: 0x060006EC RID: 1772 RVA: 0x0001859C File Offset: 0x0001679C
	private int Method7364(131 1)
	{
		int num = 0;
		if (this.jsonPosition.jsonContainerType2 == 1)
		{
			num = 1;
		}
		else
		{
			int num2 = this.GetTop() - 2;
			for (int i = num2; i >= 0; i--)
			{
				int index = num2 - i;
				if (this.list2[index].jsonContainerType2 == 1)
				{
					num = i + 2;
					break;
				}
			}
		}
		if (num == 0)
		{
			throw 763.Method12341(this, "No token to close.", null);
		}
		return num;
	}

	// Token: 0x060006ED RID: 1773 RVA: 0x00018604 File Offset: 0x00016804
	private void Method7365()
	{
		131 recoveredType24302792_ = this.GetRecoveredType24302792_7339();
		switch (recoveredType24302792_)
		{
		case 131.None:
			this.writerState2 = 173.174.Start;
			return;
		case 131.Object:
			this.writerState2 = 173.174.Object;
			return;
		case 131.Array:
			this.writerState2 = 173.174.Array;
			return;
		case 131.Constructor:
			this.writerState2 = 173.174.Array;
			return;
		default:
			throw 763.Method12341(this, "Unknown JsonType: " + recoveredType24302792_.ToString(), null);
		}
	}

	// Token: 0x060006EE RID: 1774 RVA: 0x00005ADD File Offset: 0x00003CDD
	protected virtual void WriteEnd(216 1)
	{
	}

	// Token: 0x060006EF RID: 1775 RVA: 0x00005ADD File Offset: 0x00003CDD
	protected virtual void Method2963()
	{
	}

	// Token: 0x060006F0 RID: 1776 RVA: 0x00005ADD File Offset: 0x00003CDD
	protected virtual void Method2965()
	{
	}

	// Token: 0x060006F1 RID: 1777 RVA: 0x00005ADD File Offset: 0x00003CDD
	protected virtual void Method2966()
	{
	}

	// Token: 0x060006F2 RID: 1778 RVA: 0x00018670 File Offset: 0x00016870
	internal void Method7370(216 1)
	{
		173.174 2 = 173._recoveredType1272ArrayArray5701[(int)1][(int)this.writerState2];
		if (2 == 173.174.Error)
		{
			throw 763.Method12341(this, "Token {0} in state {1} would result in an invalid JSON object.".Method6825(CultureInfo.InvariantCulture, 1.ToString(), this.writerState2.ToString()), null);
		}
		if ((this.writerState2 == 173.174.Object || this.writerState2 == 173.174.Array || this.writerState2 == 173.174.Constructor) && 1 != 216.Comment)
		{
			this.Method2965();
		}
		if (this.formatting2 == (95)1)
		{
			if (this.writerState2 == 173.174.Property)
			{
				this.Method2966();
			}
			if (this.writerState2 == 173.174.Array || this.writerState2 == 173.174.ArrayStart || this.writerState2 == 173.174.Constructor || this.writerState2 == 173.174.ConstructorStart || (1 == 216.PropertyName && this.writerState2 != 173.174.Start))
			{
				this.Method2963();
			}
		}
		this.writerState2 = 2;
	}

	// Token: 0x060006F3 RID: 1779 RVA: 0x00018740 File Offset: 0x00016940
	public virtual void WriteNull()
	{
		this.Method7425(216.Null);
	}

	// Token: 0x060006F4 RID: 1780 RVA: 0x0001874A File Offset: 0x0001694A
	public virtual void WriteUndefined()
	{
		this.Method7425(216.Undefined);
	}

	// Token: 0x060006F5 RID: 1781 RVA: 0x00018754 File Offset: 0x00016954
	[242(2)]
	public virtual void WriteRaw(string 1)
	{
		this.Method7423();
	}

	// Token: 0x060006F6 RID: 1782 RVA: 0x0001875C File Offset: 0x0001695C
	[242(2)]
	public virtual void WriteRawValue(string 1)
	{
		this.Method7336();
		this.Method7370(216.Undefined);
		this.WriteRaw(1);
	}

	// Token: 0x060006F7 RID: 1783 RVA: 0x00018773 File Offset: 0x00016973
	[242(2)]
	public virtual void WriteValue(string 1)
	{
		this.Method7425(216.String);
	}

	// Token: 0x060006F8 RID: 1784 RVA: 0x0001877D File Offset: 0x0001697D
	public virtual void WriteValue(int 1)
	{
		this.Method7425(216.Integer);
	}

	// Token: 0x060006F9 RID: 1785 RVA: 0x0001877D File Offset: 0x0001697D
	[CLSCompliant(false)]
	public virtual void WriteValue(uint 1)
	{
		this.Method7425(216.Integer);
	}

	// Token: 0x060006FA RID: 1786 RVA: 0x0001877D File Offset: 0x0001697D
	public virtual void WriteValue(long 1)
	{
		this.Method7425(216.Integer);
	}

	// Token: 0x060006FB RID: 1787 RVA: 0x0001877D File Offset: 0x0001697D
	[CLSCompliant(false)]
	public virtual void WriteValue(ulong 1)
	{
		this.Method7425(216.Integer);
	}

	// Token: 0x060006FC RID: 1788 RVA: 0x00018786 File Offset: 0x00016986
	public virtual void WriteValue(float 1)
	{
		this.Method7425(216.Float);
	}

	// Token: 0x060006FD RID: 1789 RVA: 0x00018786 File Offset: 0x00016986
	public virtual void WriteValue(double 1)
	{
		this.Method7425(216.Float);
	}

	// Token: 0x060006FE RID: 1790 RVA: 0x0001878F File Offset: 0x0001698F
	public virtual void WriteValue(bool 1)
	{
		this.Method7425(216.Boolean);
	}

	// Token: 0x060006FF RID: 1791 RVA: 0x0001877D File Offset: 0x0001697D
	public virtual void WriteValue(short 1)
	{
		this.Method7425(216.Integer);
	}

	// Token: 0x06000700 RID: 1792 RVA: 0x0001877D File Offset: 0x0001697D
	[CLSCompliant(false)]
	public virtual void WriteValue(ushort 1)
	{
		this.Method7425(216.Integer);
	}

	// Token: 0x06000701 RID: 1793 RVA: 0x00018773 File Offset: 0x00016973
	public virtual void WriteValue(char 1)
	{
		this.Method7425(216.String);
	}

	// Token: 0x06000702 RID: 1794 RVA: 0x0001877D File Offset: 0x0001697D
	public virtual void WriteValue(byte 1)
	{
		this.Method7425(216.Integer);
	}

	// Token: 0x06000703 RID: 1795 RVA: 0x0001877D File Offset: 0x0001697D
	[CLSCompliant(false)]
	public virtual void WriteValue(sbyte 1)
	{
		this.Method7425(216.Integer);
	}

	// Token: 0x06000704 RID: 1796 RVA: 0x00018786 File Offset: 0x00016986
	public virtual void WriteValue(decimal 1)
	{
		this.Method7425(216.Float);
	}

	// Token: 0x06000705 RID: 1797 RVA: 0x00018799 File Offset: 0x00016999
	public virtual void WriteValue(DateTime 1)
	{
		this.Method7425(216.Date);
	}

	// Token: 0x06000706 RID: 1798 RVA: 0x00018799 File Offset: 0x00016999
	public virtual void WriteValue(DateTimeOffset 1)
	{
		this.Method7425(216.Date);
	}

	// Token: 0x06000707 RID: 1799 RVA: 0x00018773 File Offset: 0x00016973
	public virtual void WriteValue(Guid 1)
	{
		this.Method7425(216.String);
	}

	// Token: 0x06000708 RID: 1800 RVA: 0x00018773 File Offset: 0x00016973
	public virtual void WriteValue(TimeSpan 1)
	{
		this.Method7425(216.String);
	}

	// Token: 0x06000709 RID: 1801 RVA: 0x000187A3 File Offset: 0x000169A3
	public virtual void WriteValue(int? 1)
	{
		if (1 == null)
		{
			this.WriteNull();
			return;
		}
		this.WriteValue(1.GetValueOrDefault());
	}

	// Token: 0x0600070A RID: 1802 RVA: 0x000187C2 File Offset: 0x000169C2
	[CLSCompliant(false)]
	public virtual void WriteValue(uint? 1)
	{
		if (1 == null)
		{
			this.WriteNull();
			return;
		}
		this.WriteValue(1.GetValueOrDefault());
	}

	// Token: 0x0600070B RID: 1803 RVA: 0x000187E1 File Offset: 0x000169E1
	public virtual void WriteValue(long? 1)
	{
		if (1 == null)
		{
			this.WriteNull();
			return;
		}
		this.WriteValue(1.GetValueOrDefault());
	}

	// Token: 0x0600070C RID: 1804 RVA: 0x00018800 File Offset: 0x00016A00
	[CLSCompliant(false)]
	public virtual void WriteValue(ulong? 1)
	{
		if (1 == null)
		{
			this.WriteNull();
			return;
		}
		this.WriteValue(1.GetValueOrDefault());
	}

	// Token: 0x0600070D RID: 1805 RVA: 0x0001881F File Offset: 0x00016A1F
	public virtual void WriteValue(float? 1)
	{
		if (1 == null)
		{
			this.WriteNull();
			return;
		}
		this.WriteValue(1.GetValueOrDefault());
	}

	// Token: 0x0600070E RID: 1806 RVA: 0x0001883E File Offset: 0x00016A3E
	public virtual void WriteValue(double? 1)
	{
		if (1 == null)
		{
			this.WriteNull();
			return;
		}
		this.WriteValue(1.GetValueOrDefault());
	}

	// Token: 0x0600070F RID: 1807 RVA: 0x0001885D File Offset: 0x00016A5D
	public virtual void WriteValue(bool? 1)
	{
		if (1 == null)
		{
			this.WriteNull();
			return;
		}
		this.WriteValue(1.GetValueOrDefault());
	}

	// Token: 0x06000710 RID: 1808 RVA: 0x0001887C File Offset: 0x00016A7C
	public virtual void WriteValue(short? 1)
	{
		if (1 == null)
		{
			this.WriteNull();
			return;
		}
		this.WriteValue(1.GetValueOrDefault());
	}

	// Token: 0x06000711 RID: 1809 RVA: 0x0001889B File Offset: 0x00016A9B
	[CLSCompliant(false)]
	public virtual void WriteValue(ushort? 1)
	{
		if (1 == null)
		{
			this.WriteNull();
			return;
		}
		this.WriteValue(1.GetValueOrDefault());
	}

	// Token: 0x06000712 RID: 1810 RVA: 0x000188BA File Offset: 0x00016ABA
	public virtual void WriteValue(char? 1)
	{
		if (1 == null)
		{
			this.WriteNull();
			return;
		}
		this.WriteValue(1.GetValueOrDefault());
	}

	// Token: 0x06000713 RID: 1811 RVA: 0x000188D9 File Offset: 0x00016AD9
	public virtual void WriteValue(byte? 1)
	{
		if (1 == null)
		{
			this.WriteNull();
			return;
		}
		this.WriteValue(1.GetValueOrDefault());
	}

	// Token: 0x06000714 RID: 1812 RVA: 0x000188F8 File Offset: 0x00016AF8
	[CLSCompliant(false)]
	public virtual void WriteValue(sbyte? 1)
	{
		if (1 == null)
		{
			this.WriteNull();
			return;
		}
		this.WriteValue(1.GetValueOrDefault());
	}

	// Token: 0x06000715 RID: 1813 RVA: 0x00018917 File Offset: 0x00016B17
	public virtual void WriteValue(decimal? 1)
	{
		if (1 == null)
		{
			this.WriteNull();
			return;
		}
		this.WriteValue(1.GetValueOrDefault());
	}

	// Token: 0x06000716 RID: 1814 RVA: 0x00018936 File Offset: 0x00016B36
	public virtual void WriteValue(DateTime? 1)
	{
		if (1 == null)
		{
			this.WriteNull();
			return;
		}
		this.WriteValue(1.GetValueOrDefault());
	}

	// Token: 0x06000717 RID: 1815 RVA: 0x00018955 File Offset: 0x00016B55
	public virtual void WriteValue(DateTimeOffset? 1)
	{
		if (1 == null)
		{
			this.WriteNull();
			return;
		}
		this.WriteValue(1.GetValueOrDefault());
	}

	// Token: 0x06000718 RID: 1816 RVA: 0x00018974 File Offset: 0x00016B74
	public virtual void WriteValue(Guid? 1)
	{
		if (1 == null)
		{
			this.WriteNull();
			return;
		}
		this.WriteValue(1.GetValueOrDefault());
	}

	// Token: 0x06000719 RID: 1817 RVA: 0x00018993 File Offset: 0x00016B93
	public virtual void WriteValue(TimeSpan? 1)
	{
		if (1 == null)
		{
			this.WriteNull();
			return;
		}
		this.WriteValue(1.GetValueOrDefault());
	}

	// Token: 0x0600071A RID: 1818 RVA: 0x000189B2 File Offset: 0x00016BB2
	[242(2)]
	public virtual void WriteValue(byte[] 1)
	{
		if (1 == null)
		{
			this.WriteNull();
			return;
		}
		this.Method7425(216.Bytes);
	}

	// Token: 0x0600071B RID: 1819 RVA: 0x000189C6 File Offset: 0x00016BC6
	[242(2)]
	public virtual void WriteValue(Uri 1)
	{
		if (1 == null)
		{
			this.WriteNull();
			return;
		}
		this.Method7425(216.String);
	}

	// Token: 0x0600071C RID: 1820 RVA: 0x000189E0 File Offset: 0x00016BE0
	[242(2)]
	public virtual void WriteValue(object 1)
	{
		if (1 == null)
		{
			this.WriteNull();
			return;
		}
		if (1 is BigInteger)
		{
			throw 173.Method7419(this, 1);
		}
		173.WriteValue(this, 358.Method1490(1.GetType()), 1);
	}

	// Token: 0x0600071D RID: 1821 RVA: 0x00018A0E File Offset: 0x00016C0E
	[242(2)]
	public virtual void WriteComment(string 1)
	{
		this.Method7427();
	}

	// Token: 0x0600071E RID: 1822 RVA: 0x00018A16 File Offset: 0x00016C16
	public virtual void WriteWhitespace(string 1)
	{
		this.Method7426(1);
	}

	// Token: 0x0600071F RID: 1823 RVA: 0x00018A1F File Offset: 0x00016C1F
	private void Method7415()
	{
		this.Method7416(true);
		GC.SuppressFinalize(this);
	}

	// Token: 0x06000720 RID: 1824 RVA: 0x00018A2E File Offset: 0x00016C2E
	void IDisposable.Dispose()
	{
		this.Method7415();
	}

	// Token: 0x06000721 RID: 1825 RVA: 0x00018A36 File Offset: 0x00016C36
	protected virtual void Method7416(bool 1)
	{
		if (this.writerState2 != 173.174.Closed && 1)
		{
			this.Close();
		}
	}

	// Token: 0x06000722 RID: 1826 RVA: 0x00018A50 File Offset: 0x00016C50
	internal static void WriteValue(173 1, 723 2, object 3)
	{
		for (;;)
		{
			switch (2)
			{
			case 723.Char:
				goto IL_AD;
			case 723.CharNullable:
				goto IL_BA;
			case 723.Boolean:
				goto IL_DA;
			case 723.BooleanNullable:
				goto IL_E7;
			case 723.SByte:
				goto IL_107;
			case 723.SByteNullable:
				goto IL_114;
			case 723.Int16:
				goto IL_134;
			case 723.Int16Nullable:
				goto IL_141;
			case 723.UInt16:
				goto IL_162;
			case 723.UInt16Nullable:
				goto IL_16F;
			case 723.Int32:
				goto IL_190;
			case 723.Int32Nullable:
				goto IL_19D;
			case 723.Byte:
				goto IL_1BE;
			case 723.ByteNullable:
				goto IL_1CB;
			case 723.UInt32:
				goto IL_1EC;
			case 723.UInt32Nullable:
				goto IL_1F9;
			case 723.Int64:
				goto IL_21A;
			case 723.Int64Nullable:
				goto IL_227;
			case 723.UInt64:
				goto IL_248;
			case 723.UInt64Nullable:
				goto IL_255;
			case 723.Single:
				goto IL_276;
			case 723.SingleNullable:
				goto IL_283;
			case 723.Double:
				goto IL_2A4;
			case 723.DoubleNullable:
				goto IL_2B1;
			case 723.DateTime:
				goto IL_2D2;
			case 723.DateTimeNullable:
				goto IL_2DF;
			case 723.DateTimeOffset:
				goto IL_300;
			case 723.DateTimeOffsetNullable:
				goto IL_30D;
			case 723.Decimal:
				goto IL_32E;
			case 723.DecimalNullable:
				goto IL_33B;
			case 723.Guid:
				goto IL_35C;
			case 723.GuidNullable:
				goto IL_369;
			case 723.TimeSpan:
				goto IL_38A;
			case 723.TimeSpanNullable:
				goto IL_397;
			case 723.BigInteger:
				goto IL_3B8;
			case 723.BigIntegerNullable:
				goto IL_3CA;
			case 723.Uri:
				goto IL_3F0;
			case 723.String:
				goto IL_3FD;
			case 723.Bytes:
				goto IL_40A;
			case 723.DBNull:
				goto IL_417;
			default:
			{
				IConvertible convertible = 3 as IConvertible;
				if (convertible == null)
				{
					goto IL_437;
				}
				173.Method7418(convertible, out 2, out 3);
				break;
			}
			}
		}
		IL_AD:
		1.WriteValue((char)3);
		return;
		IL_BA:
		1.WriteValue((3 == null) ? null : new char?((char)3));
		return;
		IL_DA:
		1.WriteValue((bool)3);
		return;
		IL_E7:
		1.WriteValue((3 == null) ? null : new bool?((bool)3));
		return;
		IL_107:
		1.WriteValue((sbyte)3);
		return;
		IL_114:
		1.WriteValue((3 == null) ? null : new sbyte?((sbyte)3));
		return;
		IL_134:
		1.WriteValue((short)3);
		return;
		IL_141:
		1.WriteValue((3 == null) ? null : new short?((short)3));
		return;
		IL_162:
		1.WriteValue((ushort)3);
		return;
		IL_16F:
		1.WriteValue((3 == null) ? null : new ushort?((ushort)3));
		return;
		IL_190:
		1.WriteValue((int)3);
		return;
		IL_19D:
		1.WriteValue((3 == null) ? null : new int?((int)3));
		return;
		IL_1BE:
		1.WriteValue((byte)3);
		return;
		IL_1CB:
		1.WriteValue((3 == null) ? null : new byte?((byte)3));
		return;
		IL_1EC:
		1.WriteValue((uint)3);
		return;
		IL_1F9:
		1.WriteValue((3 == null) ? null : new uint?((uint)3));
		return;
		IL_21A:
		1.WriteValue((long)3);
		return;
		IL_227:
		1.WriteValue((3 == null) ? null : new long?((long)3));
		return;
		IL_248:
		1.WriteValue((ulong)3);
		return;
		IL_255:
		1.WriteValue((3 == null) ? null : new ulong?((ulong)3));
		return;
		IL_276:
		1.WriteValue((float)3);
		return;
		IL_283:
		1.WriteValue((3 == null) ? null : new float?((float)3));
		return;
		IL_2A4:
		1.WriteValue((double)3);
		return;
		IL_2B1:
		1.WriteValue((3 == null) ? null : new double?((double)3));
		return;
		IL_2D2:
		1.WriteValue((DateTime)3);
		return;
		IL_2DF:
		1.WriteValue((3 == null) ? null : new DateTime?((DateTime)3));
		return;
		IL_300:
		1.WriteValue((DateTimeOffset)3);
		return;
		IL_30D:
		1.WriteValue((3 == null) ? null : new DateTimeOffset?((DateTimeOffset)3));
		return;
		IL_32E:
		1.WriteValue((decimal)3);
		return;
		IL_33B:
		1.WriteValue((3 == null) ? null : new decimal?((decimal)3));
		return;
		IL_35C:
		1.WriteValue((Guid)3);
		return;
		IL_369:
		1.WriteValue((3 == null) ? null : new Guid?((Guid)3));
		return;
		IL_38A:
		1.WriteValue((TimeSpan)3);
		return;
		IL_397:
		1.WriteValue((3 == null) ? null : new TimeSpan?((TimeSpan)3));
		return;
		IL_3B8:
		1.WriteValue((BigInteger)3);
		return;
		IL_3CA:
		1.WriteValue((3 == null) ? null : new BigInteger?((BigInteger)3));
		return;
		IL_3F0:
		1.WriteValue((Uri)3);
		return;
		IL_3FD:
		1.WriteValue((string)3);
		return;
		IL_40A:
		1.WriteValue((byte[])3);
		return;
		IL_417:
		1.WriteNull();
		return;
		IL_437:
		if (3 == null)
		{
			1.WriteNull();
			return;
		}
		throw 173.Method7419(1, 3);
	}

	// Token: 0x06000723 RID: 1827 RVA: 0x00018EA8 File Offset: 0x000170A8
	private static void Method7418(IConvertible 1, out 723 2, out object 3)
	{
		697 4 = 358.Method1492(1);
		2 = ((4.GetRecoveredType20618318_10685() == 723.Object) ? 723.String : 4.GetRecoveredType20618318_10685());
		Type conversionType = (4.GetRecoveredType20618318_10685() == 723.Object) ? typeof(string) : 4.GetType8317_10684();
		3 = 1.ToType(conversionType, CultureInfo.InvariantCulture);
	}

	// Token: 0x06000724 RID: 1828 RVA: 0x00018EFB File Offset: 0x000170FB
	private static 763 Method7419(173 1, object 2)
	{
		return 763.Method12341(1, "Unsupported type: {0}. Use the JsonSerializer class to get the object's JSON representation.".Method6825(CultureInfo.InvariantCulture, 2.GetType()), null);
	}

	// Token: 0x06000725 RID: 1829 RVA: 0x00018F1C File Offset: 0x0001711C
	protected void Method7420(216 1, object 2)
	{
		switch (1)
		{
		case 216.StartObject:
			this.Method7424(1, 131.Object);
			return;
		case 216.StartArray:
			this.Method7424(1, 131.Array);
			return;
		case 216.StartConstructor:
			this.Method7424(1, 131.Constructor);
			return;
		case 216.PropertyName:
		{
			string text = 2 as string;
			if (text == null)
			{
				throw new ArgumentException("A name is required when setting property name state.", "#=zUkSU2UA=");
			}
			this.Method7422(text);
			return;
		}
		case 216.Comment:
			this.Method7427();
			return;
		case 216.Raw:
			this.Method7423();
			return;
		case 216.Integer:
		case 216.Float:
		case 216.String:
		case 216.Boolean:
		case 216.Null:
		case 216.Undefined:
		case 216.Date:
		case 216.Bytes:
			this.Method7425(1);
			return;
		case 216.EndObject:
			this.Method7421(131.Object);
			return;
		case 216.EndArray:
			this.Method7421(131.Array);
			return;
		case 216.EndConstructor:
			this.Method7421(131.Constructor);
			return;
		default:
			throw new ArgumentOutOfRangeException("#=zYsNdI_Q=");
		}
	}

	// Token: 0x06000726 RID: 1830 RVA: 0x00018FEC File Offset: 0x000171EC
	internal void Method7421(131 1)
	{
		this.Method7363(1);
	}

	// Token: 0x06000727 RID: 1831 RVA: 0x00018FF5 File Offset: 0x000171F5
	internal void Method7422(string 1)
	{
		this.jsonPosition.text3 = 1;
		this.Method7370(216.PropertyName);
	}

	// Token: 0x06000728 RID: 1832 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal void Method7423()
	{
	}

	// Token: 0x06000729 RID: 1833 RVA: 0x0001900A File Offset: 0x0001720A
	internal void Method7424(216 1, 131 2)
	{
		this.Method7336();
		this.Method7370(1);
		this.Method7337(2);
	}

	// Token: 0x0600072A RID: 1834 RVA: 0x00019020 File Offset: 0x00017220
	internal void Method7425(216 1)
	{
		this.Method7336();
		this.Method7370(1);
	}

	// Token: 0x0600072B RID: 1835 RVA: 0x0001902F File Offset: 0x0001722F
	internal void Method7426(string 1)
	{
		if (1 != null && !538.Method6830(1))
		{
			throw 763.Method12341(this, "Only white space characters should be used.", null);
		}
	}

	// Token: 0x0600072C RID: 1836 RVA: 0x00019049 File Offset: 0x00017249
	internal void Method7427()
	{
		this.Method7370(216.Comment);
	}

	// Token: 0x04000480 RID: 1152
	private static readonly 173.174[][] _recoveredType1272ArrayArray5701;

	// Token: 0x04000481 RID: 1153
	internal static readonly 173.174[][] _recoveredType1272ArrayArray5702 = new 173.174[][]
	{
		new 173.174[]
		{
			173.174.Error,
			173.174.Error,
			173.174.Error,
			173.174.Error,
			173.174.Error,
			173.174.Error,
			173.174.Error,
			173.174.Error,
			173.174.Error,
			173.174.Error
		},
		new 173.174[]
		{
			173.174.ObjectStart,
			173.174.ObjectStart,
			173.174.Error,
			173.174.Error,
			173.174.ObjectStart,
			173.174.ObjectStart,
			173.174.ObjectStart,
			173.174.ObjectStart,
			173.174.Error,
			173.174.Error
		},
		new 173.174[]
		{
			173.174.ArrayStart,
			173.174.ArrayStart,
			173.174.Error,
			173.174.Error,
			173.174.ArrayStart,
			173.174.ArrayStart,
			173.174.ArrayStart,
			173.174.ArrayStart,
			173.174.Error,
			173.174.Error
		},
		new 173.174[]
		{
			173.174.ConstructorStart,
			173.174.ConstructorStart,
			173.174.Error,
			173.174.Error,
			173.174.ConstructorStart,
			173.174.ConstructorStart,
			173.174.ConstructorStart,
			173.174.ConstructorStart,
			173.174.Error,
			173.174.Error
		},
		new 173.174[]
		{
			173.174.Property,
			173.174.Error,
			173.174.Property,
			173.174.Property,
			173.174.Error,
			173.174.Error,
			173.174.Error,
			173.174.Error,
			173.174.Error,
			173.174.Error
		},
		new 173.174[]
		{
			173.174.Start,
			173.174.Property,
			173.174.ObjectStart,
			173.174.Object,
			173.174.ArrayStart,
			173.174.Array,
			173.174.Constructor,
			173.174.Constructor,
			173.174.Error,
			173.174.Error
		},
		new 173.174[]
		{
			173.174.Start,
			173.174.Property,
			173.174.ObjectStart,
			173.174.Object,
			173.174.ArrayStart,
			173.174.Array,
			173.174.Constructor,
			173.174.Constructor,
			173.174.Error,
			173.174.Error
		},
		new 173.174[]
		{
			173.174.Start,
			173.174.Object,
			173.174.Error,
			173.174.Error,
			173.174.Array,
			173.174.Array,
			173.174.Constructor,
			173.174.Constructor,
			173.174.Error,
			173.174.Error
		}
	};

	// Token: 0x04000482 RID: 1154
	[241(2)]
	private List<137> list2;

	// Token: 0x04000483 RID: 1155
	private 137 jsonPosition;

	// Token: 0x04000484 RID: 1156
	private 173.174 writerState2;

	// Token: 0x04000485 RID: 1157
	private 95 formatting2;

	// Token: 0x04000486 RID: 1158
	private bool flag4;

	// Token: 0x04000487 RID: 1159
	private bool flag5;

	// Token: 0x04000488 RID: 1160
	private 47 dateFormatHandling2;

	// Token: 0x04000489 RID: 1161
	private 49 dateTimeZoneHandling2;

	// Token: 0x0400048A RID: 1162
	private 925 stringEscapeHandling2;

	// Token: 0x0400048B RID: 1163
	private 93 floatFormatHandling2;

	// Token: 0x0400048C RID: 1164
	[241(2)]
	private string text3;

	// Token: 0x0400048D RID: 1165
	[241(2)]
	private CultureInfo cultureInfo2;

	// Token: 0x020000E7 RID: 231
	[242(0)]
	public enum 174
	{
		// Token: 0x0400048F RID: 1167
		Start,
		// Token: 0x04000490 RID: 1168
		Property,
		// Token: 0x04000491 RID: 1169
		ObjectStart,
		// Token: 0x04000492 RID: 1170
		Object,
		// Token: 0x04000493 RID: 1171
		ArrayStart,
		// Token: 0x04000494 RID: 1172
		Array,
		// Token: 0x04000495 RID: 1173
		ConstructorStart,
		// Token: 0x04000496 RID: 1174
		Constructor,
		// Token: 0x04000497 RID: 1175
		Closed,
		// Token: 0x04000498 RID: 1176
		Error
	}
}
