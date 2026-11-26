using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Threading;

// Token: 0x020003BA RID: 954
[242(1)]
[ComVisible(false)]
[241(0)]
public abstract class 226 : 411<226>, IEnumerable<226>, IEnumerable, 99, ICloneable, IDynamicMetaObjectProvider
{
	// Token: 0x170001FC RID: 508
	// (get) Token: 0x06001D8A RID: 7562 RVA: 0x000743B1 File Offset: 0x000725B1
	public static 786 EqualityComparer
	{
		get
		{
			if (226._recoveredType234810892 == null)
			{
				226._recoveredType234810892 = new 786();
			}
			return 226._recoveredType234810892;
		}
	}

	// Token: 0x170001FD RID: 509
	// (get) Token: 0x06001D8B RID: 7563 RVA: 0x000743C9 File Offset: 0x000725C9
	// (set) Token: 0x06001D8C RID: 7564 RVA: 0x000743D1 File Offset: 0x000725D1
	[241(2)]
	public 111 Parent
	{
		[DebuggerStepThrough]
		[242(2)]
		get
		{
			return this.jContainer3;
		}
		[242(2)]
		internal set
		{
			this.jContainer3 = value;
		}
	}

	// Token: 0x170001FE RID: 510
	// (get) Token: 0x06001D8D RID: 7565 RVA: 0x000743DC File Offset: 0x000725DC
	public 226 Root
	{
		get
		{
			111 parent = this.Parent;
			if (parent == null)
			{
				return this;
			}
			while (parent.Parent != null)
			{
				parent = parent.Parent;
			}
			return parent;
		}
	}

	// Token: 0x170001FF RID: 511
	// (get) Token: 0x06001D8E RID: 7566
	public abstract 705 Type { get; }

	// Token: 0x17000200 RID: 512
	// (get) Token: 0x06001D8F RID: 7567
	public abstract bool HasValues { get; }

	// Token: 0x17000201 RID: 513
	// (get) Token: 0x06001D90 RID: 7568 RVA: 0x00074405 File Offset: 0x00072605
	// (set) Token: 0x06001D91 RID: 7569 RVA: 0x0007440D File Offset: 0x0007260D
	[241(2)]
	public 226 Next
	{
		[242(2)]
		get
		{
			return this.jToken6;
		}
		[242(2)]
		internal set
		{
			this.jToken6 = value;
		}
	}

	// Token: 0x17000202 RID: 514
	// (get) Token: 0x06001D92 RID: 7570 RVA: 0x00074416 File Offset: 0x00072616
	// (set) Token: 0x06001D93 RID: 7571 RVA: 0x0007441E File Offset: 0x0007261E
	[241(2)]
	public 226 Previous
	{
		[242(2)]
		get
		{
			return this.jToken5;
		}
		[242(2)]
		internal set
		{
			this.jToken5 = value;
		}
	}

	// Token: 0x17000203 RID: 515
	// (get) Token: 0x06001D94 RID: 7572 RVA: 0x00074428 File Offset: 0x00072628
	public string Path
	{
		get
		{
			if (this.Parent == null)
			{
				return string.Empty;
			}
			List<137> list = new List<137>();
			226 <<EMPTY_NAME>> = null;
			for (226 2 = this; 2 != null; 2 = 2.Parent)
			{
				705 type = 2.Type;
				if (type - 705.Array > 1)
				{
					if (type == 705.Property)
					{
						222 3 = (222)2;
						List<137> list2 = list;
						137 item = new 137(131.Object)
						{
							text3 = 3.Name
						};
						list2.Add(item);
					}
				}
				else if (<<EMPTY_NAME>> != null)
				{
					int number = ((IList<226>)2).IndexOf(<<EMPTY_NAME>>);
					List<137> list3 = list;
					137 item = new 137(131.Array)
					{
						number = number
					};
					list3.Add(item);
				}
				<<EMPTY_NAME>> = 2;
			}
			list.Method3177<137>();
			return 137.Method3521(list, null);
		}
	}

	// Token: 0x17000204 RID: 516
	[241(2)]
	public virtual 226 this[object 1]
	{
		[return: 241(2)]
		get
		{
			throw new InvalidOperationException("Cannot access child value on {0}.".Method6825(CultureInfo.InvariantCulture, base.GetType()));
		}
		[param: 241(2)]
		set
		{
			throw new InvalidOperationException("Cannot set child value on {0}.".Method6825(CultureInfo.InvariantCulture, base.GetType()));
		}
	}

	// Token: 0x17000205 RID: 517
	// (get) Token: 0x06001D97 RID: 7575 RVA: 0x000744D4 File Offset: 0x000726D4
	[241(2)]
	public virtual 226 First
	{
		[242(2)]
		get
		{
			throw new InvalidOperationException("Cannot access child value on {0}.".Method6825(CultureInfo.InvariantCulture, base.GetType()));
		}
	}

	// Token: 0x17000206 RID: 518
	// (get) Token: 0x06001D98 RID: 7576 RVA: 0x000744D4 File Offset: 0x000726D4
	[241(2)]
	public virtual 226 Last
	{
		[242(2)]
		get
		{
			throw new InvalidOperationException("Cannot access child value on {0}.".Method6825(CultureInfo.InvariantCulture, base.GetType()));
		}
	}

	// Token: 0x06001D99 RID: 7577 RVA: 0x000055AC File Offset: 0x000037AC
	internal 226()
	{
	}

	// Token: 0x06001D9A RID: 7578
	internal abstract 226 Method14299([241(2)] 479 1);

	// Token: 0x06001D9B RID: 7579
	internal abstract bool Method14356(226 1);

	// Token: 0x06001D9C RID: 7580 RVA: 0x0007450C File Offset: 0x0007270C
	[242(2)]
	public static bool DeepEquals(226 1, 226 2)
	{
		return 1 == 2 || (1 != null && 2 != null && 1.Method14356(2));
	}

	// Token: 0x06001D9D RID: 7581 RVA: 0x00074524 File Offset: 0x00072724
	[242(2)]
	public void AddAfterSelf(object 1)
	{
		if (this.jContainer3 == null)
		{
			throw new InvalidOperationException("The parent is missing.");
		}
		int num = this.jContainer3.Method14291(this);
		this.jContainer3.Method7260(num + 1, 1, false, true);
	}

	// Token: 0x06001D9E RID: 7582 RVA: 0x00074564 File Offset: 0x00072764
	[242(2)]
	public void AddBeforeSelf(object 1)
	{
		if (this.jContainer3 == null)
		{
			throw new InvalidOperationException("The parent is missing.");
		}
		int 2 = this.jContainer3.Method14291(this);
		this.jContainer3.Method7260(2, 1, false, true);
	}

	// Token: 0x06001D9F RID: 7583 RVA: 0x000745A1 File Offset: 0x000727A1
	public IEnumerable<226> Ancestors()
	{
		return this.Method14332(false);
	}

	// Token: 0x06001DA0 RID: 7584 RVA: 0x000745AA File Offset: 0x000727AA
	public IEnumerable<226> AncestorsAndSelf()
	{
		return this.Method14332(true);
	}

	// Token: 0x06001DA1 RID: 7585 RVA: 0x000745B3 File Offset: 0x000727B3
	internal IEnumerable<226> Method14332(bool 1)
	{
		return new 226.232(-2)
		{
			jToken3 = this,
			flag2 = 1
		};
	}

	// Token: 0x06001DA2 RID: 7586 RVA: 0x000745CA File Offset: 0x000727CA
	public IEnumerable<226> AfterSelf()
	{
		return new 226.228(-2)
		{
			jToken3 = this
		};
	}

	// Token: 0x06001DA3 RID: 7587 RVA: 0x000745DA File Offset: 0x000727DA
	public IEnumerable<226> BeforeSelf()
	{
		return new 226.231(-2)
		{
			jToken3 = this
		};
	}

	// Token: 0x06001DA4 RID: 7588 RVA: 0x000745EC File Offset: 0x000727EC
	[242(2)]
	public virtual T Value<T>([241(1)] object 1)
	{
		226 2 = this[1];
		if (2 != null)
		{
			return 2.Method5762<226, T>();
		}
		return default(T);
	}

	// Token: 0x06001DA5 RID: 7589 RVA: 0x00074614 File Offset: 0x00072814
	[return: 241(new byte[]
	{
		0,
		1
	})]
	public virtual 787<226> Children()
	{
		return 787<226>._recoveredType235310041;
	}

	// Token: 0x06001DA6 RID: 7590 RVA: 0x0007461B File Offset: 0x0007281B
	[242(0)]
	[return: 241(new byte[]
	{
		0,
		1
	})]
	public 787<T> Children<T>() where T : 226
	{
		return new 787<T>(this.Children().OfType<T>());
	}

	// Token: 0x06001DA7 RID: 7591 RVA: 0x000744D4 File Offset: 0x000726D4
	[242(2)]
	[return: 241(new byte[]
	{
		1,
		2
	})]
	public virtual IEnumerable<T> Values<T>()
	{
		throw new InvalidOperationException("Cannot access child value on {0}.".Method6825(CultureInfo.InvariantCulture, base.GetType()));
	}

	// Token: 0x06001DA8 RID: 7592 RVA: 0x00074632 File Offset: 0x00072832
	public void Remove()
	{
		if (this.jContainer3 == null)
		{
			throw new InvalidOperationException("The parent is missing.");
		}
		this.jContainer3.Method14289(this);
	}

	// Token: 0x06001DA9 RID: 7593 RVA: 0x00074654 File Offset: 0x00072854
	public void Replace(226 1)
	{
		if (this.jContainer3 == null)
		{
			throw new InvalidOperationException("The parent is missing.");
		}
		this.jContainer3.Method7251(this, 1);
	}

	// Token: 0x06001DAA RID: 7594
	public abstract void WriteTo(173 1, params 214[] 2);

	// Token: 0x06001DAB RID: 7595 RVA: 0x00074676 File Offset: 0x00072876
	public override string ToString()
	{
		return this.ToString((95)1, Array.Empty<214>());
	}

	// Token: 0x06001DAC RID: 7596 RVA: 0x00074684 File Offset: 0x00072884
	public string ToString(95 1, params 214[] 2)
	{
		StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture);
		string result;
		try
		{
			168 3 = new 168(stringWriter);
			3.SetFormatting(1);
			this.WriteTo(3, 2);
			result = stringWriter.ToString();
		}
		finally
		{
			((IDisposable)stringWriter).Dispose();
		}
		return result;
	}

	// Token: 0x06001DAD RID: 7597 RVA: 0x000746D4 File Offset: 0x000728D4
	[return: 241(2)]
	private static 233 Method14333(226 1)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("#=zUkSU2UA=");
		}
		222 2 = 1 as 222;
		if (2 != null)
		{
			1 = 2.Value;
		}
		return 1 as 233;
	}

	// Token: 0x06001DAE RID: 7598 RVA: 0x00074708 File Offset: 0x00072908
	private static string Method14334(226 1)
	{
		756.Method12216(1, "token");
		222 2 = 1 as 222;
		if (2 != null)
		{
			1 = 2.Value;
		}
		return 1.Type.ToString();
	}

	// Token: 0x06001DAF RID: 7599 RVA: 0x00074746 File Offset: 0x00072946
	private static bool Method14335(226 1, 705[] 2, bool 3)
	{
		return Array.IndexOf<705>(2, 1.Type) != -1 || (3 && (1.Type == 705.Null || 1.Type == 705.Undefined));
	}

	// Token: 0x06001DB0 RID: 7600 RVA: 0x00074774 File Offset: 0x00072974
	public static explicit operator bool(226 1)
	{
		233 2 = 226.Method14333(1);
		if (2 == null || !226.Method14335(2, 226._recoveredType1971Array10897, false))
		{
			throw new ArgumentException("Can not convert {0} to Boolean.".Method6825(CultureInfo.InvariantCulture, 226.Method14334(1)));
		}
		object value = 2.Value;
		if (value is BigInteger)
		{
			BigInteger value2 = (BigInteger)value;
			return Convert.ToBoolean((int)value2);
		}
		return Convert.ToBoolean(2.Value, CultureInfo.InvariantCulture);
	}

	// Token: 0x06001DB1 RID: 7601 RVA: 0x000747E8 File Offset: 0x000729E8
	public static explicit operator DateTimeOffset(226 1)
	{
		233 2 = 226.Method14333(1);
		if (2 == null || !226.Method14335(2, 226._recoveredType1971Array10905, false))
		{
			throw new ArgumentException("Can not convert {0} to DateTimeOffset.".Method6825(CultureInfo.InvariantCulture, 226.Method14334(1)));
		}
		object value = 2.Value;
		if (value is DateTimeOffset)
		{
			return (DateTimeOffset)value;
		}
		string text = 2.Value as string;
		if (text != null)
		{
			return DateTimeOffset.Parse(text, CultureInfo.InvariantCulture);
		}
		return new DateTimeOffset(Convert.ToDateTime(2.Value, CultureInfo.InvariantCulture));
	}

	// Token: 0x06001DB2 RID: 7602 RVA: 0x00074870 File Offset: 0x00072A70
	[242(2)]
	public static explicit operator bool?(226 1)
	{
		if (1 == null)
		{
			return null;
		}
		233 2 = 226.Method14333(1);
		if (2 == null || !226.Method14335(2, 226._recoveredType1971Array10897, true))
		{
			throw new ArgumentException("Can not convert {0} to Boolean.".Method6825(CultureInfo.InvariantCulture, 226.Method14334(1)));
		}
		object value = 2.Value;
		if (value is BigInteger)
		{
			BigInteger value2 = (BigInteger)value;
			return new bool?(Convert.ToBoolean((int)value2));
		}
		if (2.Value == null)
		{
			return null;
		}
		return new bool?(Convert.ToBoolean(2.Value, CultureInfo.InvariantCulture));
	}

	// Token: 0x06001DB3 RID: 7603 RVA: 0x0007490C File Offset: 0x00072B0C
	public static explicit operator long(226 1)
	{
		233 2 = 226.Method14333(1);
		if (2 == null || !226.Method14335(2, 226._recoveredType1971Array10898, false))
		{
			throw new ArgumentException("Can not convert {0} to Int64.".Method6825(CultureInfo.InvariantCulture, 226.Method14334(1)));
		}
		object value = 2.Value;
		if (value is BigInteger)
		{
			BigInteger value2 = (BigInteger)value;
			return (long)value2;
		}
		return Convert.ToInt64(2.Value, CultureInfo.InvariantCulture);
	}

	// Token: 0x06001DB4 RID: 7604 RVA: 0x0007497C File Offset: 0x00072B7C
	[242(2)]
	public static explicit operator DateTime?(226 1)
	{
		if (1 == null)
		{
			return null;
		}
		233 2 = 226.Method14333(1);
		if (2 == null || !226.Method14335(2, 226._recoveredType1971Array10905, true))
		{
			throw new ArgumentException("Can not convert {0} to DateTime.".Method6825(CultureInfo.InvariantCulture, 226.Method14334(1)));
		}
		object value = 2.Value;
		if (value is DateTimeOffset)
		{
			return new DateTime?(((DateTimeOffset)value).DateTime);
		}
		if (2.Value == null)
		{
			return null;
		}
		return new DateTime?(Convert.ToDateTime(2.Value, CultureInfo.InvariantCulture));
	}

	// Token: 0x06001DB5 RID: 7605 RVA: 0x00074A14 File Offset: 0x00072C14
	[242(2)]
	public static explicit operator DateTimeOffset?(226 1)
	{
		if (1 == null)
		{
			return null;
		}
		233 2 = 226.Method14333(1);
		if (2 == null || !226.Method14335(2, 226._recoveredType1971Array10905, true))
		{
			throw new ArgumentException("Can not convert {0} to DateTimeOffset.".Method6825(CultureInfo.InvariantCulture, 226.Method14334(1)));
		}
		if (2.Value == null)
		{
			return null;
		}
		object value = 2.Value;
		if (value is DateTimeOffset)
		{
			return new DateTimeOffset?((DateTimeOffset)value);
		}
		string text = 2.Value as string;
		if (text != null)
		{
			return new DateTimeOffset?(DateTimeOffset.Parse(text, CultureInfo.InvariantCulture));
		}
		return new DateTimeOffset?(new DateTimeOffset(Convert.ToDateTime(2.Value, CultureInfo.InvariantCulture)));
	}

	// Token: 0x06001DB6 RID: 7606 RVA: 0x00074AC8 File Offset: 0x00072CC8
	[242(2)]
	public static explicit operator decimal?(226 1)
	{
		if (1 == null)
		{
			return null;
		}
		233 2 = 226.Method14333(1);
		if (2 == null || !226.Method14335(2, 226._recoveredType1971Array10898, true))
		{
			throw new ArgumentException("Can not convert {0} to Decimal.".Method6825(CultureInfo.InvariantCulture, 226.Method14334(1)));
		}
		object value = 2.Value;
		if (value is BigInteger)
		{
			BigInteger value2 = (BigInteger)value;
			return new decimal?((decimal)value2);
		}
		if (2.Value == null)
		{
			return null;
		}
		return new decimal?(Convert.ToDecimal(2.Value, CultureInfo.InvariantCulture));
	}

	// Token: 0x06001DB7 RID: 7607 RVA: 0x00074B60 File Offset: 0x00072D60
	[242(2)]
	public static explicit operator double?(226 1)
	{
		if (1 == null)
		{
			return null;
		}
		233 2 = 226.Method14333(1);
		if (2 == null || !226.Method14335(2, 226._recoveredType1971Array10898, true))
		{
			throw new ArgumentException("Can not convert {0} to Double.".Method6825(CultureInfo.InvariantCulture, 226.Method14334(1)));
		}
		object value = 2.Value;
		if (value is BigInteger)
		{
			BigInteger value2 = (BigInteger)value;
			return new double?((double)value2);
		}
		if (2.Value == null)
		{
			return null;
		}
		return new double?(Convert.ToDouble(2.Value, CultureInfo.InvariantCulture));
	}

	// Token: 0x06001DB8 RID: 7608 RVA: 0x00074BF8 File Offset: 0x00072DF8
	[242(2)]
	public static explicit operator char?(226 1)
	{
		if (1 == null)
		{
			return null;
		}
		233 2 = 226.Method14333(1);
		if (2 == null || !226.Method14335(2, 226._recoveredType1971Array10904, true))
		{
			throw new ArgumentException("Can not convert {0} to Char.".Method6825(CultureInfo.InvariantCulture, 226.Method14334(1)));
		}
		object value = 2.Value;
		if (value is BigInteger)
		{
			BigInteger value2 = (BigInteger)value;
			return new char?((char)((ushort)value2));
		}
		if (2.Value == null)
		{
			return null;
		}
		return new char?(Convert.ToChar(2.Value, CultureInfo.InvariantCulture));
	}

	// Token: 0x06001DB9 RID: 7609 RVA: 0x00074C90 File Offset: 0x00072E90
	public static explicit operator int(226 1)
	{
		233 2 = 226.Method14333(1);
		if (2 == null || !226.Method14335(2, 226._recoveredType1971Array10898, false))
		{
			throw new ArgumentException("Can not convert {0} to Int32.".Method6825(CultureInfo.InvariantCulture, 226.Method14334(1)));
		}
		object value = 2.Value;
		if (value is BigInteger)
		{
			BigInteger value2 = (BigInteger)value;
			return (int)value2;
		}
		return Convert.ToInt32(2.Value, CultureInfo.InvariantCulture);
	}

	// Token: 0x06001DBA RID: 7610 RVA: 0x00074D00 File Offset: 0x00072F00
	public static explicit operator short(226 1)
	{
		233 2 = 226.Method14333(1);
		if (2 == null || !226.Method14335(2, 226._recoveredType1971Array10898, false))
		{
			throw new ArgumentException("Can not convert {0} to Int16.".Method6825(CultureInfo.InvariantCulture, 226.Method14334(1)));
		}
		object value = 2.Value;
		if (value is BigInteger)
		{
			BigInteger value2 = (BigInteger)value;
			return (short)value2;
		}
		return Convert.ToInt16(2.Value, CultureInfo.InvariantCulture);
	}

	// Token: 0x06001DBB RID: 7611 RVA: 0x00074D70 File Offset: 0x00072F70
	[CLSCompliant(false)]
	public static explicit operator ushort(226 1)
	{
		233 2 = 226.Method14333(1);
		if (2 == null || !226.Method14335(2, 226._recoveredType1971Array10898, false))
		{
			throw new ArgumentException("Can not convert {0} to UInt16.".Method6825(CultureInfo.InvariantCulture, 226.Method14334(1)));
		}
		object value = 2.Value;
		if (value is BigInteger)
		{
			BigInteger value2 = (BigInteger)value;
			return (ushort)value2;
		}
		return Convert.ToUInt16(2.Value, CultureInfo.InvariantCulture);
	}

	// Token: 0x06001DBC RID: 7612 RVA: 0x00074DE0 File Offset: 0x00072FE0
	[CLSCompliant(false)]
	public static explicit operator char(226 1)
	{
		233 2 = 226.Method14333(1);
		if (2 == null || !226.Method14335(2, 226._recoveredType1971Array10904, false))
		{
			throw new ArgumentException("Can not convert {0} to Char.".Method6825(CultureInfo.InvariantCulture, 226.Method14334(1)));
		}
		object value = 2.Value;
		if (value is BigInteger)
		{
			BigInteger value2 = (BigInteger)value;
			return (char)((ushort)value2);
		}
		return Convert.ToChar(2.Value, CultureInfo.InvariantCulture);
	}

	// Token: 0x06001DBD RID: 7613 RVA: 0x00074E50 File Offset: 0x00073050
	public static explicit operator byte(226 1)
	{
		233 2 = 226.Method14333(1);
		if (2 == null || !226.Method14335(2, 226._recoveredType1971Array10898, false))
		{
			throw new ArgumentException("Can not convert {0} to Byte.".Method6825(CultureInfo.InvariantCulture, 226.Method14334(1)));
		}
		object value = 2.Value;
		if (value is BigInteger)
		{
			BigInteger value2 = (BigInteger)value;
			return (byte)value2;
		}
		return Convert.ToByte(2.Value, CultureInfo.InvariantCulture);
	}

	// Token: 0x06001DBE RID: 7614 RVA: 0x00074EC0 File Offset: 0x000730C0
	[CLSCompliant(false)]
	public static explicit operator sbyte(226 1)
	{
		233 2 = 226.Method14333(1);
		if (2 == null || !226.Method14335(2, 226._recoveredType1971Array10898, false))
		{
			throw new ArgumentException("Can not convert {0} to SByte.".Method6825(CultureInfo.InvariantCulture, 226.Method14334(1)));
		}
		object value = 2.Value;
		if (value is BigInteger)
		{
			BigInteger value2 = (BigInteger)value;
			return (sbyte)value2;
		}
		return Convert.ToSByte(2.Value, CultureInfo.InvariantCulture);
	}

	// Token: 0x06001DBF RID: 7615 RVA: 0x00074F30 File Offset: 0x00073130
	[242(2)]
	public static explicit operator int?(226 1)
	{
		if (1 == null)
		{
			return null;
		}
		233 2 = 226.Method14333(1);
		if (2 == null || !226.Method14335(2, 226._recoveredType1971Array10898, true))
		{
			throw new ArgumentException("Can not convert {0} to Int32.".Method6825(CultureInfo.InvariantCulture, 226.Method14334(1)));
		}
		object value = 2.Value;
		if (value is BigInteger)
		{
			BigInteger value2 = (BigInteger)value;
			return new int?((int)value2);
		}
		if (2.Value == null)
		{
			return null;
		}
		return new int?(Convert.ToInt32(2.Value, CultureInfo.InvariantCulture));
	}

	// Token: 0x06001DC0 RID: 7616 RVA: 0x00074FC8 File Offset: 0x000731C8
	[242(2)]
	public static explicit operator short?(226 1)
	{
		if (1 == null)
		{
			return null;
		}
		233 2 = 226.Method14333(1);
		if (2 == null || !226.Method14335(2, 226._recoveredType1971Array10898, true))
		{
			throw new ArgumentException("Can not convert {0} to Int16.".Method6825(CultureInfo.InvariantCulture, 226.Method14334(1)));
		}
		object value = 2.Value;
		if (value is BigInteger)
		{
			BigInteger value2 = (BigInteger)value;
			return new short?((short)value2);
		}
		if (2.Value == null)
		{
			return null;
		}
		return new short?(Convert.ToInt16(2.Value, CultureInfo.InvariantCulture));
	}

	// Token: 0x06001DC1 RID: 7617 RVA: 0x00075060 File Offset: 0x00073260
	[242(2)]
	[CLSCompliant(false)]
	public static explicit operator ushort?(226 1)
	{
		if (1 == null)
		{
			return null;
		}
		233 2 = 226.Method14333(1);
		if (2 == null || !226.Method14335(2, 226._recoveredType1971Array10898, true))
		{
			throw new ArgumentException("Can not convert {0} to UInt16.".Method6825(CultureInfo.InvariantCulture, 226.Method14334(1)));
		}
		object value = 2.Value;
		if (value is BigInteger)
		{
			BigInteger value2 = (BigInteger)value;
			return new ushort?((ushort)value2);
		}
		if (2.Value == null)
		{
			return null;
		}
		return new ushort?(Convert.ToUInt16(2.Value, CultureInfo.InvariantCulture));
	}

	// Token: 0x06001DC2 RID: 7618 RVA: 0x000750F8 File Offset: 0x000732F8
	[242(2)]
	public static explicit operator byte?(226 1)
	{
		if (1 == null)
		{
			return null;
		}
		233 2 = 226.Method14333(1);
		if (2 == null || !226.Method14335(2, 226._recoveredType1971Array10898, true))
		{
			throw new ArgumentException("Can not convert {0} to Byte.".Method6825(CultureInfo.InvariantCulture, 226.Method14334(1)));
		}
		object value = 2.Value;
		if (value is BigInteger)
		{
			BigInteger value2 = (BigInteger)value;
			return new byte?((byte)value2);
		}
		if (2.Value == null)
		{
			return null;
		}
		return new byte?(Convert.ToByte(2.Value, CultureInfo.InvariantCulture));
	}

	// Token: 0x06001DC3 RID: 7619 RVA: 0x00075190 File Offset: 0x00073390
	[CLSCompliant(false)]
	[242(2)]
	public static explicit operator sbyte?(226 1)
	{
		if (1 == null)
		{
			return null;
		}
		233 2 = 226.Method14333(1);
		if (2 == null || !226.Method14335(2, 226._recoveredType1971Array10898, true))
		{
			throw new ArgumentException("Can not convert {0} to SByte.".Method6825(CultureInfo.InvariantCulture, 226.Method14334(1)));
		}
		object value = 2.Value;
		if (value is BigInteger)
		{
			BigInteger value2 = (BigInteger)value;
			return new sbyte?((sbyte)value2);
		}
		if (2.Value == null)
		{
			return null;
		}
		return new sbyte?(Convert.ToSByte(2.Value, CultureInfo.InvariantCulture));
	}

	// Token: 0x06001DC4 RID: 7620 RVA: 0x00075228 File Offset: 0x00073428
	public static explicit operator DateTime(226 1)
	{
		233 2 = 226.Method14333(1);
		if (2 == null || !226.Method14335(2, 226._recoveredType1971Array10905, false))
		{
			throw new ArgumentException("Can not convert {0} to DateTime.".Method6825(CultureInfo.InvariantCulture, 226.Method14334(1)));
		}
		object value = 2.Value;
		if (value is DateTimeOffset)
		{
			return ((DateTimeOffset)value).DateTime;
		}
		return Convert.ToDateTime(2.Value, CultureInfo.InvariantCulture);
	}

	// Token: 0x06001DC5 RID: 7621 RVA: 0x00075298 File Offset: 0x00073498
	[242(2)]
	public static explicit operator long?(226 1)
	{
		if (1 == null)
		{
			return null;
		}
		233 2 = 226.Method14333(1);
		if (2 == null || !226.Method14335(2, 226._recoveredType1971Array10898, true))
		{
			throw new ArgumentException("Can not convert {0} to Int64.".Method6825(CultureInfo.InvariantCulture, 226.Method14334(1)));
		}
		object value = 2.Value;
		if (value is BigInteger)
		{
			BigInteger value2 = (BigInteger)value;
			return new long?((long)value2);
		}
		if (2.Value == null)
		{
			return null;
		}
		return new long?(Convert.ToInt64(2.Value, CultureInfo.InvariantCulture));
	}

	// Token: 0x06001DC6 RID: 7622 RVA: 0x00075330 File Offset: 0x00073530
	[242(2)]
	public static explicit operator float?(226 1)
	{
		if (1 == null)
		{
			return null;
		}
		233 2 = 226.Method14333(1);
		if (2 == null || !226.Method14335(2, 226._recoveredType1971Array10898, true))
		{
			throw new ArgumentException("Can not convert {0} to Single.".Method6825(CultureInfo.InvariantCulture, 226.Method14334(1)));
		}
		object value = 2.Value;
		if (value is BigInteger)
		{
			BigInteger value2 = (BigInteger)value;
			return new float?((float)value2);
		}
		if (2.Value == null)
		{
			return null;
		}
		return new float?(Convert.ToSingle(2.Value, CultureInfo.InvariantCulture));
	}

	// Token: 0x06001DC7 RID: 7623 RVA: 0x000753C8 File Offset: 0x000735C8
	public static explicit operator decimal(226 1)
	{
		233 2 = 226.Method14333(1);
		if (2 == null || !226.Method14335(2, 226._recoveredType1971Array10898, false))
		{
			throw new ArgumentException("Can not convert {0} to Decimal.".Method6825(CultureInfo.InvariantCulture, 226.Method14334(1)));
		}
		object value = 2.Value;
		if (value is BigInteger)
		{
			BigInteger value2 = (BigInteger)value;
			return (decimal)value2;
		}
		return Convert.ToDecimal(2.Value, CultureInfo.InvariantCulture);
	}

	// Token: 0x06001DC8 RID: 7624 RVA: 0x00075438 File Offset: 0x00073638
	[CLSCompliant(false)]
	[242(2)]
	public static explicit operator uint?(226 1)
	{
		if (1 == null)
		{
			return null;
		}
		233 2 = 226.Method14333(1);
		if (2 == null || !226.Method14335(2, 226._recoveredType1971Array10898, true))
		{
			throw new ArgumentException("Can not convert {0} to UInt32.".Method6825(CultureInfo.InvariantCulture, 226.Method14334(1)));
		}
		object value = 2.Value;
		if (value is BigInteger)
		{
			BigInteger value2 = (BigInteger)value;
			return new uint?((uint)value2);
		}
		if (2.Value == null)
		{
			return null;
		}
		return new uint?(Convert.ToUInt32(2.Value, CultureInfo.InvariantCulture));
	}

	// Token: 0x06001DC9 RID: 7625 RVA: 0x000754D0 File Offset: 0x000736D0
	[CLSCompliant(false)]
	[242(2)]
	public static explicit operator ulong?(226 1)
	{
		if (1 == null)
		{
			return null;
		}
		233 2 = 226.Method14333(1);
		if (2 == null || !226.Method14335(2, 226._recoveredType1971Array10898, true))
		{
			throw new ArgumentException("Can not convert {0} to UInt64.".Method6825(CultureInfo.InvariantCulture, 226.Method14334(1)));
		}
		object value = 2.Value;
		if (value is BigInteger)
		{
			BigInteger value2 = (BigInteger)value;
			return new ulong?((ulong)value2);
		}
		if (2.Value == null)
		{
			return null;
		}
		return new ulong?(Convert.ToUInt64(2.Value, CultureInfo.InvariantCulture));
	}

	// Token: 0x06001DCA RID: 7626 RVA: 0x00075568 File Offset: 0x00073768
	public static explicit operator double(226 1)
	{
		233 2 = 226.Method14333(1);
		if (2 == null || !226.Method14335(2, 226._recoveredType1971Array10898, false))
		{
			throw new ArgumentException("Can not convert {0} to Double.".Method6825(CultureInfo.InvariantCulture, 226.Method14334(1)));
		}
		object value = 2.Value;
		if (value is BigInteger)
		{
			BigInteger value2 = (BigInteger)value;
			return (double)value2;
		}
		return Convert.ToDouble(2.Value, CultureInfo.InvariantCulture);
	}

	// Token: 0x06001DCB RID: 7627 RVA: 0x000755D8 File Offset: 0x000737D8
	public static explicit operator float(226 1)
	{
		233 2 = 226.Method14333(1);
		if (2 == null || !226.Method14335(2, 226._recoveredType1971Array10898, false))
		{
			throw new ArgumentException("Can not convert {0} to Single.".Method6825(CultureInfo.InvariantCulture, 226.Method14334(1)));
		}
		object value = 2.Value;
		if (value is BigInteger)
		{
			BigInteger value2 = (BigInteger)value;
			return (float)value2;
		}
		return Convert.ToSingle(2.Value, CultureInfo.InvariantCulture);
	}

	// Token: 0x06001DCC RID: 7628 RVA: 0x00075648 File Offset: 0x00073848
	[242(2)]
	public static explicit operator string(226 1)
	{
		if (1 == null)
		{
			return null;
		}
		233 2 = 226.Method14333(1);
		if (2 == null || !226.Method14335(2, 226._recoveredType1971Array10900, true))
		{
			throw new ArgumentException("Can not convert {0} to String.".Method6825(CultureInfo.InvariantCulture, 226.Method14334(1)));
		}
		if (2.Value == null)
		{
			return null;
		}
		byte[] array = 2.Value as byte[];
		if (array != null)
		{
			return Convert.ToBase64String(array);
		}
		object value = 2.Value;
		if (value is BigInteger)
		{
			return ((BigInteger)value).ToString(CultureInfo.InvariantCulture);
		}
		return Convert.ToString(2.Value, CultureInfo.InvariantCulture);
	}

	// Token: 0x06001DCD RID: 7629 RVA: 0x000756E0 File Offset: 0x000738E0
	[CLSCompliant(false)]
	public static explicit operator uint(226 1)
	{
		233 2 = 226.Method14333(1);
		if (2 == null || !226.Method14335(2, 226._recoveredType1971Array10898, false))
		{
			throw new ArgumentException("Can not convert {0} to UInt32.".Method6825(CultureInfo.InvariantCulture, 226.Method14334(1)));
		}
		object value = 2.Value;
		if (value is BigInteger)
		{
			BigInteger value2 = (BigInteger)value;
			return (uint)value2;
		}
		return Convert.ToUInt32(2.Value, CultureInfo.InvariantCulture);
	}

	// Token: 0x06001DCE RID: 7630 RVA: 0x00075750 File Offset: 0x00073950
	[CLSCompliant(false)]
	public static explicit operator ulong(226 1)
	{
		233 2 = 226.Method14333(1);
		if (2 == null || !226.Method14335(2, 226._recoveredType1971Array10898, false))
		{
			throw new ArgumentException("Can not convert {0} to UInt64.".Method6825(CultureInfo.InvariantCulture, 226.Method14334(1)));
		}
		object value = 2.Value;
		if (value is BigInteger)
		{
			BigInteger value2 = (BigInteger)value;
			return (ulong)value2;
		}
		return Convert.ToUInt64(2.Value, CultureInfo.InvariantCulture);
	}

	// Token: 0x06001DCF RID: 7631 RVA: 0x000757C0 File Offset: 0x000739C0
	[242(2)]
	public static explicit operator byte[](226 1)
	{
		if (1 == null)
		{
			return null;
		}
		233 2 = 226.Method14333(1);
		if (2 == null || !226.Method14335(2, 226._recoveredType1971Array10906, false))
		{
			throw new ArgumentException("Can not convert {0} to byte array.".Method6825(CultureInfo.InvariantCulture, 226.Method14334(1)));
		}
		if (2.Value is string)
		{
			return Convert.FromBase64String(Convert.ToString(2.Value, CultureInfo.InvariantCulture));
		}
		object value = 2.Value;
		if (value is BigInteger)
		{
			return ((BigInteger)value).ToByteArray();
		}
		byte[] array = 2.Value as byte[];
		if (array != null)
		{
			return array;
		}
		throw new ArgumentException("Can not convert {0} to byte array.".Method6825(CultureInfo.InvariantCulture, 226.Method14334(1)));
	}

	// Token: 0x06001DD0 RID: 7632 RVA: 0x00075874 File Offset: 0x00073A74
	public static explicit operator Guid(226 1)
	{
		233 2 = 226.Method14333(1);
		if (2 == null || !226.Method14335(2, 226._recoveredType1971Array10901, false))
		{
			throw new ArgumentException("Can not convert {0} to Guid.".Method6825(CultureInfo.InvariantCulture, 226.Method14334(1)));
		}
		byte[] array = 2.Value as byte[];
		if (array != null)
		{
			return new Guid(array);
		}
		object value = 2.Value;
		if (value is Guid)
		{
			return (Guid)value;
		}
		return new Guid(Convert.ToString(2.Value, CultureInfo.InvariantCulture));
	}

	// Token: 0x06001DD1 RID: 7633 RVA: 0x000758F8 File Offset: 0x00073AF8
	[242(2)]
	public static explicit operator Guid?(226 1)
	{
		if (1 == null)
		{
			return null;
		}
		233 2 = 226.Method14333(1);
		if (2 == null || !226.Method14335(2, 226._recoveredType1971Array10901, true))
		{
			throw new ArgumentException("Can not convert {0} to Guid.".Method6825(CultureInfo.InvariantCulture, 226.Method14334(1)));
		}
		if (2.Value == null)
		{
			return null;
		}
		byte[] array = 2.Value as byte[];
		if (array != null)
		{
			return new Guid?(new Guid(array));
		}
		object value = 2.Value;
		Guid value2;
		if (value is Guid)
		{
			Guid guid = (Guid)value;
			value2 = guid;
		}
		else
		{
			value2 = new Guid(Convert.ToString(2.Value, CultureInfo.InvariantCulture));
		}
		return new Guid?(value2);
	}

	// Token: 0x06001DD2 RID: 7634 RVA: 0x000759AC File Offset: 0x00073BAC
	public static explicit operator TimeSpan(226 1)
	{
		233 2 = 226.Method14333(1);
		if (2 == null || !226.Method14335(2, 226._recoveredType1971Array10902, false))
		{
			throw new ArgumentException("Can not convert {0} to TimeSpan.".Method6825(CultureInfo.InvariantCulture, 226.Method14334(1)));
		}
		object value = 2.Value;
		if (value is TimeSpan)
		{
			return (TimeSpan)value;
		}
		return 358.Method1494(Convert.ToString(2.Value, CultureInfo.InvariantCulture));
	}

	// Token: 0x06001DD3 RID: 7635 RVA: 0x00075A18 File Offset: 0x00073C18
	[242(2)]
	public static explicit operator TimeSpan?(226 1)
	{
		if (1 == null)
		{
			return null;
		}
		233 2 = 226.Method14333(1);
		if (2 == null || !226.Method14335(2, 226._recoveredType1971Array10902, true))
		{
			throw new ArgumentException("Can not convert {0} to TimeSpan.".Method6825(CultureInfo.InvariantCulture, 226.Method14334(1)));
		}
		if (2.Value == null)
		{
			return null;
		}
		object value = 2.Value;
		TimeSpan value2;
		if (value is TimeSpan)
		{
			TimeSpan timeSpan = (TimeSpan)value;
			value2 = timeSpan;
		}
		else
		{
			value2 = 358.Method1494(Convert.ToString(2.Value, CultureInfo.InvariantCulture));
		}
		return new TimeSpan?(value2);
	}

	// Token: 0x06001DD4 RID: 7636 RVA: 0x00075AAC File Offset: 0x00073CAC
	[242(2)]
	public static explicit operator Uri(226 1)
	{
		if (1 == null)
		{
			return null;
		}
		233 2 = 226.Method14333(1);
		if (2 == null || !226.Method14335(2, 226._recoveredType1971Array10903, true))
		{
			throw new ArgumentException("Can not convert {0} to Uri.".Method6825(CultureInfo.InvariantCulture, 226.Method14334(1)));
		}
		if (2.Value == null)
		{
			return null;
		}
		Uri uri = 2.Value as Uri;
		if (uri == null)
		{
			return new Uri(Convert.ToString(2.Value, CultureInfo.InvariantCulture));
		}
		return uri;
	}

	// Token: 0x06001DD5 RID: 7637 RVA: 0x00075B24 File Offset: 0x00073D24
	private static BigInteger Method14336(226 1)
	{
		233 2 = 226.Method14333(1);
		if (2 == null || !226.Method14335(2, 226._recoveredType1971Array10899, false))
		{
			throw new ArgumentException("Can not convert {0} to BigInteger.".Method6825(CultureInfo.InvariantCulture, 226.Method14334(1)));
		}
		return 358.Method1496(2.Value);
	}

	// Token: 0x06001DD6 RID: 7638 RVA: 0x00075B70 File Offset: 0x00073D70
	private static BigInteger? Method14337(226 1)
	{
		233 2 = 226.Method14333(1);
		if (2 == null || !226.Method14335(2, 226._recoveredType1971Array10899, true))
		{
			throw new ArgumentException("Can not convert {0} to BigInteger.".Method6825(CultureInfo.InvariantCulture, 226.Method14334(1)));
		}
		if (2.Value == null)
		{
			return null;
		}
		return new BigInteger?(358.Method1496(2.Value));
	}

	// Token: 0x06001DD7 RID: 7639 RVA: 0x00075BD2 File Offset: 0x00073DD2
	public static implicit operator 226(bool 1)
	{
		return new 233(1);
	}

	// Token: 0x06001DD8 RID: 7640 RVA: 0x00075BDA File Offset: 0x00073DDA
	public static implicit operator 226(DateTimeOffset 1)
	{
		return new 233(1);
	}

	// Token: 0x06001DD9 RID: 7641 RVA: 0x00075BE2 File Offset: 0x00073DE2
	public static implicit operator 226(byte 1)
	{
		return new 233((long)((ulong)1));
	}

	// Token: 0x06001DDA RID: 7642 RVA: 0x00075BEB File Offset: 0x00073DEB
	public static implicit operator 226(byte? 1)
	{
		return new 233(1);
	}

	// Token: 0x06001DDB RID: 7643 RVA: 0x00075BF8 File Offset: 0x00073DF8
	[CLSCompliant(false)]
	public static implicit operator 226(sbyte 1)
	{
		return new 233((long)1);
	}

	// Token: 0x06001DDC RID: 7644 RVA: 0x00075C01 File Offset: 0x00073E01
	[CLSCompliant(false)]
	public static implicit operator 226(sbyte? 1)
	{
		return new 233(1);
	}

	// Token: 0x06001DDD RID: 7645 RVA: 0x00075C0E File Offset: 0x00073E0E
	public static implicit operator 226(bool? 1)
	{
		return new 233(1);
	}

	// Token: 0x06001DDE RID: 7646 RVA: 0x00075C1B File Offset: 0x00073E1B
	public static implicit operator 226(long 1)
	{
		return new 233(1);
	}

	// Token: 0x06001DDF RID: 7647 RVA: 0x00075C23 File Offset: 0x00073E23
	public static implicit operator 226(DateTime? 1)
	{
		return new 233(1);
	}

	// Token: 0x06001DE0 RID: 7648 RVA: 0x00075C30 File Offset: 0x00073E30
	public static implicit operator 226(DateTimeOffset? 1)
	{
		return new 233(1);
	}

	// Token: 0x06001DE1 RID: 7649 RVA: 0x00075C3D File Offset: 0x00073E3D
	public static implicit operator 226(decimal? 1)
	{
		return new 233(1);
	}

	// Token: 0x06001DE2 RID: 7650 RVA: 0x00075C4A File Offset: 0x00073E4A
	public static implicit operator 226(double? 1)
	{
		return new 233(1);
	}

	// Token: 0x06001DE3 RID: 7651 RVA: 0x00075BF8 File Offset: 0x00073DF8
	[CLSCompliant(false)]
	public static implicit operator 226(short 1)
	{
		return new 233((long)1);
	}

	// Token: 0x06001DE4 RID: 7652 RVA: 0x00075BE2 File Offset: 0x00073DE2
	[CLSCompliant(false)]
	public static implicit operator 226(ushort 1)
	{
		return new 233((long)((ulong)1));
	}

	// Token: 0x06001DE5 RID: 7653 RVA: 0x00075BF8 File Offset: 0x00073DF8
	public static implicit operator 226(int 1)
	{
		return new 233((long)1);
	}

	// Token: 0x06001DE6 RID: 7654 RVA: 0x00075C57 File Offset: 0x00073E57
	public static implicit operator 226(int? 1)
	{
		return new 233(1);
	}

	// Token: 0x06001DE7 RID: 7655 RVA: 0x00075C64 File Offset: 0x00073E64
	public static implicit operator 226(DateTime 1)
	{
		return new 233(1);
	}

	// Token: 0x06001DE8 RID: 7656 RVA: 0x00075C6C File Offset: 0x00073E6C
	public static implicit operator 226(long? 1)
	{
		return new 233(1);
	}

	// Token: 0x06001DE9 RID: 7657 RVA: 0x00075C79 File Offset: 0x00073E79
	public static implicit operator 226(float? 1)
	{
		return new 233(1);
	}

	// Token: 0x06001DEA RID: 7658 RVA: 0x00075C86 File Offset: 0x00073E86
	public static implicit operator 226(decimal 1)
	{
		return new 233(1);
	}

	// Token: 0x06001DEB RID: 7659 RVA: 0x00075C8E File Offset: 0x00073E8E
	[CLSCompliant(false)]
	public static implicit operator 226(short? 1)
	{
		return new 233(1);
	}

	// Token: 0x06001DEC RID: 7660 RVA: 0x00075C9B File Offset: 0x00073E9B
	[CLSCompliant(false)]
	public static implicit operator 226(ushort? 1)
	{
		return new 233(1);
	}

	// Token: 0x06001DED RID: 7661 RVA: 0x00075CA8 File Offset: 0x00073EA8
	[CLSCompliant(false)]
	public static implicit operator 226(uint? 1)
	{
		return new 233(1);
	}

	// Token: 0x06001DEE RID: 7662 RVA: 0x00075CB5 File Offset: 0x00073EB5
	[CLSCompliant(false)]
	public static implicit operator 226(ulong? 1)
	{
		return new 233(1);
	}

	// Token: 0x06001DEF RID: 7663 RVA: 0x00075CC2 File Offset: 0x00073EC2
	public static implicit operator 226(double 1)
	{
		return new 233(1);
	}

	// Token: 0x06001DF0 RID: 7664 RVA: 0x00075CCA File Offset: 0x00073ECA
	public static implicit operator 226(float 1)
	{
		return new 233(1);
	}

	// Token: 0x06001DF1 RID: 7665 RVA: 0x00075CD2 File Offset: 0x00073ED2
	public static implicit operator 226([241(2)] string 1)
	{
		return new 233(1);
	}

	// Token: 0x06001DF2 RID: 7666 RVA: 0x00075BE2 File Offset: 0x00073DE2
	[CLSCompliant(false)]
	public static implicit operator 226(uint 1)
	{
		return new 233((long)((ulong)1));
	}

	// Token: 0x06001DF3 RID: 7667 RVA: 0x00075CDA File Offset: 0x00073EDA
	[CLSCompliant(false)]
	public static implicit operator 226(ulong 1)
	{
		return new 233(1);
	}

	// Token: 0x06001DF4 RID: 7668 RVA: 0x00075CE2 File Offset: 0x00073EE2
	public static implicit operator 226(byte[] 1)
	{
		return new 233(1);
	}

	// Token: 0x06001DF5 RID: 7669 RVA: 0x00075CEA File Offset: 0x00073EEA
	public static implicit operator 226([241(2)] Uri 1)
	{
		return new 233(1);
	}

	// Token: 0x06001DF6 RID: 7670 RVA: 0x00075CF2 File Offset: 0x00073EF2
	public static implicit operator 226(TimeSpan 1)
	{
		return new 233(1);
	}

	// Token: 0x06001DF7 RID: 7671 RVA: 0x00075CFA File Offset: 0x00073EFA
	public static implicit operator 226(TimeSpan? 1)
	{
		return new 233(1);
	}

	// Token: 0x06001DF8 RID: 7672 RVA: 0x00075D07 File Offset: 0x00073F07
	public static implicit operator 226(Guid 1)
	{
		return new 233(1);
	}

	// Token: 0x06001DF9 RID: 7673 RVA: 0x00075D0F File Offset: 0x00073F0F
	public static implicit operator 226(Guid? 1)
	{
		return new 233(1);
	}

	// Token: 0x06001DFA RID: 7674 RVA: 0x00075D1C File Offset: 0x00073F1C
	private IEnumerator Method14338()
	{
		return ((IEnumerable<226>)this).GetEnumerator();
	}

	// Token: 0x06001DFB RID: 7675 RVA: 0x00075D24 File Offset: 0x00073F24
	IEnumerator IEnumerable.GetEnumerator()
	{
		return this.Method14338();
	}

	// Token: 0x06001DFC RID: 7676 RVA: 0x00075D2C File Offset: 0x00073F2C
	private IEnumerator<226> Method14339()
	{
		return this.Children().GetEnumerator();
	}

	// Token: 0x06001DFD RID: 7677 RVA: 0x00075D47 File Offset: 0x00073F47
	IEnumerator<226> IEnumerable<226>.GetEnumerator()
	{
		return this.Method14339();
	}

	// Token: 0x06001DFE RID: 7678
	internal abstract int Method14364();

	// Token: 0x06001DFF RID: 7679 RVA: 0x00075D4F File Offset: 0x00073F4F
	private 411<226> Method14341(object 1)
	{
		return this[1];
	}

	// Token: 0x17000207 RID: 519
	411<226> 411<226>.this[object 1]
	{
		get
		{
			return this.Method14341(1);
		}
	}

	// Token: 0x06001E01 RID: 7681 RVA: 0x00075D61 File Offset: 0x00073F61
	public 139 CreateReader()
	{
		return new 123(this);
	}

	// Token: 0x06001E02 RID: 7682 RVA: 0x00075D6C File Offset: 0x00073F6C
	internal static 226 Method14342(object 1, 158 2)
	{
		756.Method12216(1, "o");
		756.Method12216(2, "jsonSerializer");
		124 3 = new 124();
		226 result;
		try
		{
			2.Method3848(3, 1);
			result = 3.Method11875();
		}
		finally
		{
			((IDisposable)3).Dispose();
		}
		return result;
	}

	// Token: 0x06001E03 RID: 7683 RVA: 0x00075DC0 File Offset: 0x00073FC0
	public static 226 FromObject(object 1)
	{
		return 226.Method14342(1, 158.Method3835());
	}

	// Token: 0x06001E04 RID: 7684 RVA: 0x00075DCD File Offset: 0x00073FCD
	public static 226 FromObject(object 1, 158 2)
	{
		return 226.Method14342(1, 2);
	}

	// Token: 0x06001E05 RID: 7685 RVA: 0x00075DD6 File Offset: 0x00073FD6
	[242(2)]
	public T ToObject<T>()
	{
		return (T)((object)this.ToObject(typeof(T)));
	}

	// Token: 0x06001E06 RID: 7686 RVA: 0x00075DF0 File Offset: 0x00073FF0
	[return: 241(2)]
	public object ToObject(Type 1)
	{
		if (77.DefaultSettings == null)
		{
			bool flag;
			723 2 = 358.Method1490(1, out flag);
			if (flag)
			{
				if (this.Type == 705.String)
				{
					try
					{
						return this.ToObject(1, 158.Method3835());
					}
					catch (Exception innerException)
					{
						Type type = 1.Method6709() ? 1 : Nullable.GetUnderlyingType(1);
						throw new ArgumentException("Could not convert '{0}' to {1}.".Method6825(CultureInfo.InvariantCulture, (string)this, type.Name), innerException);
					}
				}
				if (this.Type == 705.Integer)
				{
					return Enum.ToObject(1.Method6709() ? 1 : Nullable.GetUnderlyingType(1), ((233)this).Value);
				}
			}
			switch (2)
			{
			case 723.Char:
				return (char)this;
			case 723.CharNullable:
				return (char?)this;
			case 723.Boolean:
				return (bool)this;
			case 723.BooleanNullable:
				return (bool?)this;
			case 723.SByte:
				return (sbyte)this;
			case 723.SByteNullable:
				return (sbyte?)this;
			case 723.Int16:
				return (short)this;
			case 723.Int16Nullable:
				return (short?)this;
			case 723.UInt16:
				return (ushort)this;
			case 723.UInt16Nullable:
				return (ushort?)this;
			case 723.Int32:
				return (int)this;
			case 723.Int32Nullable:
				return (int?)this;
			case 723.Byte:
				return (byte)this;
			case 723.ByteNullable:
				return (byte?)this;
			case 723.UInt32:
				return (uint)this;
			case 723.UInt32Nullable:
				return (uint?)this;
			case 723.Int64:
				return (long)this;
			case 723.Int64Nullable:
				return (long?)this;
			case 723.UInt64:
				return (ulong)this;
			case 723.UInt64Nullable:
				return (ulong?)this;
			case 723.Single:
				return (float)this;
			case 723.SingleNullable:
				return (float?)this;
			case 723.Double:
				return (double)this;
			case 723.DoubleNullable:
				return (double?)this;
			case 723.DateTime:
				return (DateTime)this;
			case 723.DateTimeNullable:
				return (DateTime?)this;
			case 723.DateTimeOffset:
				return (DateTimeOffset)this;
			case 723.DateTimeOffsetNullable:
				return (DateTimeOffset?)this;
			case 723.Decimal:
				return (decimal)this;
			case 723.DecimalNullable:
				return (decimal?)this;
			case 723.Guid:
				return (Guid)this;
			case 723.GuidNullable:
				return (Guid?)this;
			case 723.TimeSpan:
				return (TimeSpan)this;
			case 723.TimeSpanNullable:
				return (TimeSpan?)this;
			case 723.BigInteger:
				return 226.Method14336(this);
			case 723.BigIntegerNullable:
				return 226.Method14337(this);
			case 723.Uri:
				return (Uri)this;
			case 723.String:
				return (string)this;
			}
		}
		return this.ToObject(1, 158.Method3835());
	}

	// Token: 0x06001E07 RID: 7687 RVA: 0x00076114 File Offset: 0x00074314
	[242(2)]
	public T ToObject<T>([241(1)] 158 1)
	{
		return (T)((object)this.ToObject(typeof(T), 1));
	}

	// Token: 0x06001E08 RID: 7688 RVA: 0x0007612C File Offset: 0x0007432C
	[242(2)]
	public object ToObject(Type 1, [241(1)] 158 2)
	{
		756.Method12216(2, "jsonSerializer");
		123 3 = new 123(this);
		object result;
		try
		{
			366 4 = 2 as 366;
			if (4 != null)
			{
				CultureInfo cultureInfo;
				49? 5;
				48? 6;
				94? 7;
				int? num;
				string text;
				4.jsonSerializer.Method3846(3, out cultureInfo, out 5, out 6, out 7, out num, out text);
			}
			result = 2.Method3841(3, 1);
		}
		finally
		{
			((IDisposable)3).Dispose();
		}
		return result;
	}

	// Token: 0x06001E09 RID: 7689 RVA: 0x00076194 File Offset: 0x00074394
	public static 226 ReadFrom(139 1)
	{
		return 226.ReadFrom(1, null);
	}

	// Token: 0x06001E0A RID: 7690 RVA: 0x000761A0 File Offset: 0x000743A0
	public static 226 ReadFrom(139 1, [241(2)] 554 2)
	{
		756.Method12216(1, "reader");
		if (!((1.GetTokenType() == 216.None) ? ((2 != null && 2.GetRecoveredType15785743_7441() == (611)0) ? 1.Method2846() : 1.Read()) : (1.GetTokenType() != 216.Comment || 2 == null || 2.GetRecoveredType15785743_7441() != (611)0 || 1.Method2846())))
		{
			throw 141.Method12886(1, "Error reading JToken from JsonReader.");
		}
		99 3 = 1 as 99;
		switch (1.GetTokenType())
		{
		case 216.StartObject:
			return 217.Load(1, 2);
		case 216.StartArray:
			return 109.Method1939(1, 2);
		case 216.StartConstructor:
			return 110.Method1287(1, 2);
		case 216.PropertyName:
			return 222.Load(1, 2);
		case 216.Comment:
		{
			233 4 = 233.CreateComment(1.GetValue().ToString());
			4.Method14343(3, 2);
			return 4;
		}
		case 216.Integer:
		case 216.Float:
		case 216.String:
		case 216.Boolean:
		case 216.Date:
		case 216.Bytes:
		{
			233 5 = new 233(1.GetValue());
			5.Method14343(3, 2);
			return 5;
		}
		case 216.Null:
		{
			233 6 = 233.CreateNull();
			6.Method14343(3, 2);
			return 6;
		}
		case 216.Undefined:
		{
			233 7 = 233.CreateUndefined();
			7.Method14343(3, 2);
			return 7;
		}
		}
		throw 141.Method12886(1, "Error reading JToken from JsonReader. Unexpected token: {0}".Method6825(CultureInfo.InvariantCulture, 1.GetTokenType()));
	}

	// Token: 0x06001E0B RID: 7691 RVA: 0x000762EB File Offset: 0x000744EB
	public static 226 Parse(string 1)
	{
		return 226.Parse(1, null);
	}

	// Token: 0x06001E0C RID: 7692 RVA: 0x000762F4 File Offset: 0x000744F4
	public static 226 Parse(string 1, [241(2)] 554 2)
	{
		139 3 = new 167(new StringReader(1));
		226 result;
		try
		{
			226 4 = 226.Load(3, 2);
			while (3.Read())
			{
			}
			result = 4;
		}
		finally
		{
			((IDisposable)3).Dispose();
		}
		return result;
	}

	// Token: 0x06001E0D RID: 7693 RVA: 0x0007633C File Offset: 0x0007453C
	public static 226 Load(139 1, [241(2)] 554 2)
	{
		return 226.ReadFrom(1, 2);
	}

	// Token: 0x06001E0E RID: 7694 RVA: 0x00076345 File Offset: 0x00074545
	public static 226 Load(139 1)
	{
		return 226.Load(1, null);
	}

	// Token: 0x06001E0F RID: 7695 RVA: 0x0007634E File Offset: 0x0007454E
	[242(2)]
	internal void Method14343(99 1, 554 2)
	{
		if ((2 == null || 2.GetRecoveredType20645744_7443() == (725)1) && 1 != null && 1.HasLineInfo())
		{
			this.Method14343(1.GetLineNumber(), 1.GetLinePosition());
		}
	}

	// Token: 0x06001E10 RID: 7696 RVA: 0x00076379 File Offset: 0x00074579
	internal void Method14343(int 1, int 2)
	{
		this.AddAnnotation(new 226.230(1, 2));
	}

	// Token: 0x06001E11 RID: 7697 RVA: 0x00076388 File Offset: 0x00074588
	private bool Method14345()
	{
		return this.Annotation<226.230>() != null;
	}

	// Token: 0x06001E12 RID: 7698 RVA: 0x00076393 File Offset: 0x00074593
	bool 99.HasLineInfo()
	{
		return this.Method14345();
	}

	// Token: 0x06001E13 RID: 7699 RVA: 0x0007639B File Offset: 0x0007459B
	private int Method14347()
	{
		226.230 <<EMPTY_NAME>> = this.Annotation<226.230>();
		if (<<EMPTY_NAME>> == null)
		{
			return 0;
		}
		return <<EMPTY_NAME>>.number3;
	}

	// Token: 0x06001E14 RID: 7700 RVA: 0x000763AE File Offset: 0x000745AE
	int 99.GetLineNumber()
	{
		return this.Method14347();
	}

	// Token: 0x06001E15 RID: 7701 RVA: 0x000763B6 File Offset: 0x000745B6
	private int Method14349()
	{
		226.230 <<EMPTY_NAME>> = this.Annotation<226.230>();
		if (<<EMPTY_NAME>> == null)
		{
			return 0;
		}
		return <<EMPTY_NAME>>.number4;
	}

	// Token: 0x06001E16 RID: 7702 RVA: 0x000763C9 File Offset: 0x000745C9
	int 99.GetLinePosition()
	{
		return this.Method14349();
	}

	// Token: 0x06001E17 RID: 7703 RVA: 0x000763D1 File Offset: 0x000745D1
	[return: 241(2)]
	public 226 SelectToken(string 1)
	{
		return this.SelectToken(1, null);
	}

	// Token: 0x06001E18 RID: 7704 RVA: 0x000763DC File Offset: 0x000745DC
	[return: 241(2)]
	public 226 SelectToken(string 1, bool 2)
	{
		object obj;
		if (!2)
		{
			obj = null;
		}
		else
		{
			obj = new 541();
			((541)obj).SetFlag5433_6847(true);
		}
		541 3 = (541)obj;
		return this.SelectToken(1, 3);
	}

	// Token: 0x06001E19 RID: 7705 RVA: 0x00076414 File Offset: 0x00074614
	[242(2)]
	public 226 SelectToken([241(1)] string 1, 541 2)
	{
		113 3 = new 113(1);
		226 4 = null;
		foreach (226 5 in 3.Method12272(this, this, 2))
		{
			if (4 != null)
			{
				throw new 134("Path returned multiple tokens.");
			}
			4 = 5;
		}
		return 4;
	}

	// Token: 0x06001E1A RID: 7706 RVA: 0x00076474 File Offset: 0x00074674
	public IEnumerable<226> SelectTokens(string 1)
	{
		return this.SelectTokens(1, null);
	}

	// Token: 0x06001E1B RID: 7707 RVA: 0x00076480 File Offset: 0x00074680
	public IEnumerable<226> SelectTokens(string 1, bool 2)
	{
		object obj;
		if (!2)
		{
			obj = null;
		}
		else
		{
			obj = new 541();
			((541)obj).SetFlag5433_6847(true);
		}
		541 3 = (541)obj;
		return this.SelectTokens(1, 3);
	}

	// Token: 0x06001E1C RID: 7708 RVA: 0x000764B5 File Offset: 0x000746B5
	public IEnumerable<226> SelectTokens(string 1, [241(2)] 541 2)
	{
		return new 113(1).Method12272(this, this, 2);
	}

	// Token: 0x06001E1D RID: 7709 RVA: 0x000764C5 File Offset: 0x000746C5
	protected virtual DynamicMetaObject GetMetaObject(Expression 1)
	{
		return new 640<226>(1, this, new 625<226>());
	}

	// Token: 0x06001E1E RID: 7710 RVA: 0x000764D3 File Offset: 0x000746D3
	private DynamicMetaObject Method14351(Expression 1)
	{
		return this.GetMetaObject(1);
	}

	// Token: 0x06001E1F RID: 7711 RVA: 0x000764DC File Offset: 0x000746DC
	DynamicMetaObject IDynamicMetaObjectProvider.GetMetaObject(Expression 1)
	{
		return this.Method14351(1);
	}

	// Token: 0x06001E20 RID: 7712 RVA: 0x000764E5 File Offset: 0x000746E5
	private object Method14352()
	{
		return this.DeepClone();
	}

	// Token: 0x06001E21 RID: 7713 RVA: 0x000764ED File Offset: 0x000746ED
	object ICloneable.Clone()
	{
		return this.Method14352();
	}

	// Token: 0x06001E22 RID: 7714 RVA: 0x000764F5 File Offset: 0x000746F5
	public 226 DeepClone()
	{
		return this.Method14299(null);
	}

	// Token: 0x06001E23 RID: 7715 RVA: 0x000764FE File Offset: 0x000746FE
	public 226 DeepClone(479 1)
	{
		return this.Method14299(1);
	}

	// Token: 0x06001E24 RID: 7716 RVA: 0x00076508 File Offset: 0x00074708
	public void AddAnnotation(object 1)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("annotation");
		}
		if (this.value7 == null)
		{
			object[] array;
			if (1 is object[])
			{
				(array = new object[1])[0] = 1;
			}
			else
			{
				array = 1;
			}
			this.value7 = array;
			return;
		}
		object[] array2 = this.value7 as object[];
		if (array2 == null)
		{
			this.value7 = new object[]
			{
				this.value7,
				1
			};
			return;
		}
		int num = 0;
		while (num < array2.Length && array2[num] != null)
		{
			num++;
		}
		if (num == array2.Length)
		{
			Array.Resize<object>(ref array2, num * 2);
			this.value7 = array2;
		}
		array2[num] = 1;
	}

	// Token: 0x06001E25 RID: 7717 RVA: 0x000765A0 File Offset: 0x000747A0
	[return: 241(2)]
	public T Annotation<T>() where T : class
	{
		if (this.value7 != null)
		{
			object[] array = this.value7 as object[];
			if (array == null)
			{
				return this.value7 as T;
			}
			foreach (object obj in array)
			{
				if (obj == null)
				{
					break;
				}
				T t = obj as T;
				if (t != null)
				{
					return t;
				}
			}
		}
		return default(T);
	}

	// Token: 0x06001E26 RID: 7718 RVA: 0x00076610 File Offset: 0x00074810
	[return: 241(2)]
	public object Annotation(Type 1)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("type");
		}
		if (this.value7 != null)
		{
			object[] array = this.value7 as object[];
			if (array == null)
			{
				if (1.IsInstanceOfType(this.value7))
				{
					return this.value7;
				}
			}
			else
			{
				foreach (object obj in array)
				{
					if (obj == null)
					{
						break;
					}
					if (1.IsInstanceOfType(obj))
					{
						return obj;
					}
				}
			}
		}
		return null;
	}

	// Token: 0x06001E27 RID: 7719 RVA: 0x00076680 File Offset: 0x00074880
	public IEnumerable<T> Annotations<T>() where T : class
	{
		return new 226.229<T>(-2)
		{
			_jToken10875 = this
		};
	}

	// Token: 0x06001E28 RID: 7720 RVA: 0x00076690 File Offset: 0x00074890
	public IEnumerable<object> Annotations(Type 1)
	{
		return new 226.227(-2)
		{
			jToken2 = this,
			type2 = 1
		};
	}

	// Token: 0x06001E29 RID: 7721 RVA: 0x000766A8 File Offset: 0x000748A8
	public void RemoveAnnotations<T>() where T : class
	{
		if (this.value7 == null)
		{
			return;
		}
		object[] array = this.value7 as object[];
		if (array == null)
		{
			if (this.value7 is T)
			{
				this.value7 = null;
			}
			return;
		}
		int i = 0;
		int j = 0;
		while (i < array.Length)
		{
			object obj = array[i];
			if (obj == null)
			{
				break;
			}
			if (!(obj is T))
			{
				array[j++] = obj;
			}
			i++;
		}
		if (j != 0)
		{
			while (j < i)
			{
				array[j++] = null;
			}
			return;
		}
		this.value7 = null;
	}

	// Token: 0x06001E2A RID: 7722 RVA: 0x00076724 File Offset: 0x00074924
	public void RemoveAnnotations(Type 1)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("type");
		}
		if (this.value7 == null)
		{
			return;
		}
		object[] array = this.value7 as object[];
		if (array == null)
		{
			if (1.IsInstanceOfType(this.value7))
			{
				this.value7 = null;
			}
			return;
		}
		int i = 0;
		int j = 0;
		while (i < array.Length)
		{
			object obj = array[i];
			if (obj == null)
			{
				break;
			}
			if (!1.IsInstanceOfType(obj))
			{
				array[j++] = obj;
			}
			i++;
		}
		if (j != 0)
		{
			while (j < i)
			{
				array[j++] = null;
			}
			return;
		}
		this.value7 = null;
	}

	// Token: 0x06001E2B RID: 7723 RVA: 0x000767B4 File Offset: 0x000749B4
	internal void Method14353(226 1, 226 2)
	{
		object[] array = 2.value7 as object[];
		if (array != null)
		{
			1.value7 = array.ToArray<object>();
			return;
		}
		1.value7 = 2.value7;
	}

	// Token: 0x04000EA9 RID: 3753
	[241(2)]
	private static 786 _recoveredType234810892;

	// Token: 0x04000EAA RID: 3754
	[241(2)]
	private 111 jContainer3;

	// Token: 0x04000EAB RID: 3755
	[241(2)]
	private 226 jToken5;

	// Token: 0x04000EAC RID: 3756
	[241(2)]
	private 226 jToken6;

	// Token: 0x04000EAD RID: 3757
	[241(2)]
	private object value7;

	// Token: 0x04000EAE RID: 3758
	private static readonly 705[] _recoveredType1971Array10897 = new 705[]
	{
		705.Integer,
		705.Float,
		705.String,
		705.Comment,
		705.Raw,
		705.Boolean
	};

	// Token: 0x04000EAF RID: 3759
	private static readonly 705[] _recoveredType1971Array10898 = new 705[]
	{
		705.Integer,
		705.Float,
		705.String,
		705.Comment,
		705.Raw,
		705.Boolean
	};

	// Token: 0x04000EB0 RID: 3760
	private static readonly 705[] _recoveredType1971Array10899 = new 705[]
	{
		705.Integer,
		705.Float,
		705.String,
		705.Comment,
		705.Raw,
		705.Boolean,
		705.Bytes
	};

	// Token: 0x04000EB1 RID: 3761
	private static readonly 705[] _recoveredType1971Array10900 = new 705[]
	{
		705.Date,
		705.Integer,
		705.Float,
		705.String,
		705.Comment,
		705.Raw,
		705.Boolean,
		705.Bytes,
		705.Guid,
		705.TimeSpan,
		705.Uri
	};

	// Token: 0x04000EB2 RID: 3762
	private static readonly 705[] _recoveredType1971Array10901 = new 705[]
	{
		705.String,
		705.Comment,
		705.Raw,
		705.Guid,
		705.Bytes
	};

	// Token: 0x04000EB3 RID: 3763
	private static readonly 705[] _recoveredType1971Array10902 = new 705[]
	{
		705.String,
		705.Comment,
		705.Raw,
		705.TimeSpan
	};

	// Token: 0x04000EB4 RID: 3764
	private static readonly 705[] _recoveredType1971Array10903 = new 705[]
	{
		705.String,
		705.Comment,
		705.Raw,
		705.Uri
	};

	// Token: 0x04000EB5 RID: 3765
	private static readonly 705[] _recoveredType1971Array10904 = new 705[]
	{
		705.Integer,
		705.Float,
		705.String,
		705.Comment,
		705.Raw
	};

	// Token: 0x04000EB6 RID: 3766
	private static readonly 705[] _recoveredType1971Array10905 = new 705[]
	{
		705.Date,
		705.String,
		705.Comment,
		705.Raw
	};

	// Token: 0x04000EB7 RID: 3767
	private static readonly 705[] _recoveredType1971Array10906 = new 705[]
	{
		705.Bytes,
		705.String,
		705.Comment,
		705.Raw,
		705.Integer
	};

	// Token: 0x020003BB RID: 955
	public sealed class 227 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06001E2D RID: 7725 RVA: 0x000768D6 File Offset: 0x00074AD6
		[DebuggerHidden]
		public 227(int 1)
		{
			this.number2 = 1;
			this.number3 = Thread.CurrentThread.ManagedThreadId;
		}

		// Token: 0x06001E2E RID: 7726 RVA: 0x00005ADD File Offset: 0x00003CDD
		[DebuggerHidden]
		private void Method14300()
		{
		}

		// Token: 0x06001E2F RID: 7727 RVA: 0x000768F5 File Offset: 0x00074AF5
		void IDisposable.Dispose()
		{
			this.Method14300();
		}

		// Token: 0x06001E30 RID: 7728 RVA: 0x00076900 File Offset: 0x00074B00
		private bool MoveNext()
		{
			int num = this.number2;
			226 <<EMPTY_NAME>> = this.jToken2;
			switch (num)
			{
			case 0:
			{
				this.number2 = -1;
				if (this.type == null)
				{
					throw new ArgumentNullException("type");
				}
				if (<<EMPTY_NAME>>.value7 == null)
				{
					return false;
				}
				object value = <<EMPTY_NAME>>.value7;
				this.valueArray = (value as object[]);
				if (this.valueArray != null)
				{
					this.number4 = 0;
					goto IL_BA;
				}
				if (!this.type.IsInstanceOfType(<<EMPTY_NAME>>.value7))
				{
					return false;
				}
				this.value2 = <<EMPTY_NAME>>.value7;
				this.number2 = 2;
				return true;
			}
			case 1:
				this.number2 = -1;
				break;
			case 2:
				this.number2 = -1;
				return false;
			default:
				return false;
			}
			IL_AC:
			this.number4++;
			IL_BA:
			if (this.number4 < this.valueArray.Length)
			{
				object obj = this.valueArray[this.number4];
				if (obj != null)
				{
					if (this.type.IsInstanceOfType(obj))
					{
						this.value2 = obj;
						this.number2 = 1;
						return true;
					}
					goto IL_AC;
				}
			}
			return false;
		}

		// Token: 0x06001E31 RID: 7729 RVA: 0x00076A07 File Offset: 0x00074C07
		bool IEnumerator.MoveNext()
		{
			return this.MoveNext();
		}

		// Token: 0x06001E32 RID: 7730 RVA: 0x00076A0F File Offset: 0x00074C0F
		[DebuggerHidden]
		private object GetValue10860_14301()
		{
			return this.value2;
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06001E33 RID: 7731 RVA: 0x00076A17 File Offset: 0x00074C17
		object IEnumerator<object>.Current
		{
			get
			{
				return this.GetValue10860_14301();
			}
		}

		// Token: 0x06001E34 RID: 7732 RVA: 0x00005BE8 File Offset: 0x00003DE8
		[DebuggerHidden]
		private void Method14302()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001E35 RID: 7733 RVA: 0x00076A1F File Offset: 0x00074C1F
		void IEnumerator.Reset()
		{
			this.Method14302();
		}

		// Token: 0x06001E36 RID: 7734 RVA: 0x00076A0F File Offset: 0x00074C0F
		[DebuggerHidden]
		[return: 241(0)]
		private object GetValue10860_14303()
		{
			return this.value2;
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06001E37 RID: 7735 RVA: 0x00076A27 File Offset: 0x00074C27
		object IEnumerator.Current
		{
			get
			{
				return this.GetValue10860_14303();
			}
		}

		// Token: 0x06001E38 RID: 7736 RVA: 0x00076A30 File Offset: 0x00074C30
		[DebuggerHidden]
		[return: 241(0)]
		private IEnumerator<object> Method14304()
		{
			226.227 <<EMPTY_NAME>>;
			if (this.number2 == -2 && this.number3 == Thread.CurrentThread.ManagedThreadId)
			{
				this.number2 = 0;
				<<EMPTY_NAME>> = this;
			}
			else
			{
				<<EMPTY_NAME>> = new 226.227(0);
				<<EMPTY_NAME>>.jToken2 = this.jToken2;
			}
			<<EMPTY_NAME>>.type = this.type2;
			return <<EMPTY_NAME>>;
		}

		// Token: 0x06001E39 RID: 7737 RVA: 0x00076A84 File Offset: 0x00074C84
		IEnumerator<object> IEnumerable<object>.GetEnumerator()
		{
			return this.Method14304();
		}

		// Token: 0x06001E3A RID: 7738 RVA: 0x00076A84 File Offset: 0x00074C84
		[DebuggerHidden]
		[return: 241(0)]
		private IEnumerator Method14305()
		{
			return this.Method14304();
		}

		// Token: 0x06001E3B RID: 7739 RVA: 0x00076A8C File Offset: 0x00074C8C
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.Method14305();
		}

		// Token: 0x04000EB8 RID: 3768
		private int number2;

		// Token: 0x04000EB9 RID: 3769
		private object value2;

		// Token: 0x04000EBA RID: 3770
		private int number3;

		// Token: 0x04000EBB RID: 3771
		[241(0)]
		private Type type;

		// Token: 0x04000EBC RID: 3772
		[241(0)]
		public Type type2;

		// Token: 0x04000EBD RID: 3773
		[241(0)]
		public 226 jToken2;

		// Token: 0x04000EBE RID: 3774
		[241(new byte[]
		{
			0,
			1
		})]
		private object[] valueArray;

		// Token: 0x04000EBF RID: 3775
		private int number4;
	}

	// Token: 0x020003BC RID: 956
	public sealed class 228 : IEnumerable<226>, IEnumerable, IEnumerator<226>, IDisposable, IEnumerator
	{
		// Token: 0x06001E3C RID: 7740 RVA: 0x00076A94 File Offset: 0x00074C94
		[DebuggerHidden]
		public 228(int 1)
		{
			this.number2 = 1;
			this.number3 = Thread.CurrentThread.ManagedThreadId;
		}

		// Token: 0x06001E3D RID: 7741 RVA: 0x00005ADD File Offset: 0x00003CDD
		[DebuggerHidden]
		private void Method14306()
		{
		}

		// Token: 0x06001E3E RID: 7742 RVA: 0x00076AB3 File Offset: 0x00074CB3
		void IDisposable.Dispose()
		{
			this.Method14306();
		}

		// Token: 0x06001E3F RID: 7743 RVA: 0x00076ABC File Offset: 0x00074CBC
		private bool MoveNext()
		{
			int num = this.number2;
			226 <<EMPTY_NAME>> = this.jToken3;
			if (num != 0)
			{
				if (num != 1)
				{
					return false;
				}
				this.number2 = -1;
				this.jToken4 = this.jToken4.Next;
			}
			else
			{
				this.number2 = -1;
				if (<<EMPTY_NAME>>.Parent == null)
				{
					return false;
				}
				this.jToken4 = <<EMPTY_NAME>>.Next;
			}
			if (this.jToken4 != null)
			{
				this.jToken2 = this.jToken4;
				this.number2 = 1;
				return true;
			}
			this.jToken4 = null;
			return false;
		}

		// Token: 0x06001E40 RID: 7744 RVA: 0x00076B3C File Offset: 0x00074D3C
		bool IEnumerator.MoveNext()
		{
			return this.MoveNext();
		}

		// Token: 0x06001E41 RID: 7745 RVA: 0x00076B44 File Offset: 0x00074D44
		[DebuggerHidden]
		private 226 GetJToken10868_14307()
		{
			return this.jToken2;
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06001E42 RID: 7746 RVA: 0x00076B4C File Offset: 0x00074D4C
		226 IEnumerator<226>.Current
		{
			get
			{
				return this.GetJToken10868_14307();
			}
		}

		// Token: 0x06001E43 RID: 7747 RVA: 0x00005BE8 File Offset: 0x00003DE8
		[DebuggerHidden]
		private void Method14308()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001E44 RID: 7748 RVA: 0x00076B54 File Offset: 0x00074D54
		void IEnumerator.Reset()
		{
			this.Method14308();
		}

		// Token: 0x06001E45 RID: 7749 RVA: 0x00076B44 File Offset: 0x00074D44
		[DebuggerHidden]
		[return: 241(0)]
		private object GetJToken10868_14309()
		{
			return this.jToken2;
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06001E46 RID: 7750 RVA: 0x00076B5C File Offset: 0x00074D5C
		object IEnumerator.Current
		{
			get
			{
				return this.GetJToken10868_14309();
			}
		}

		// Token: 0x06001E47 RID: 7751 RVA: 0x00076B64 File Offset: 0x00074D64
		[DebuggerHidden]
		[return: 241(0)]
		private IEnumerator<226> Method14310()
		{
			226.228 <<EMPTY_NAME>>;
			if (this.number2 == -2 && this.number3 == Thread.CurrentThread.ManagedThreadId)
			{
				this.number2 = 0;
				<<EMPTY_NAME>> = this;
			}
			else
			{
				<<EMPTY_NAME>> = new 226.228(0);
				<<EMPTY_NAME>>.jToken3 = this.jToken3;
			}
			return <<EMPTY_NAME>>;
		}

		// Token: 0x06001E48 RID: 7752 RVA: 0x00076BAC File Offset: 0x00074DAC
		IEnumerator<226> IEnumerable<226>.GetEnumerator()
		{
			return this.Method14310();
		}

		// Token: 0x06001E49 RID: 7753 RVA: 0x00076BAC File Offset: 0x00074DAC
		[DebuggerHidden]
		[return: 241(0)]
		private IEnumerator Method14311()
		{
			return this.Method14310();
		}

		// Token: 0x06001E4A RID: 7754 RVA: 0x00076BB4 File Offset: 0x00074DB4
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.Method14311();
		}

		// Token: 0x04000EC0 RID: 3776
		private int number2;

		// Token: 0x04000EC1 RID: 3777
		private 226 jToken2;

		// Token: 0x04000EC2 RID: 3778
		private int number3;

		// Token: 0x04000EC3 RID: 3779
		[241(0)]
		public 226 jToken3;

		// Token: 0x04000EC4 RID: 3780
		[241(0)]
		private 226 jToken4;
	}

	// Token: 0x020003BD RID: 957
	public sealed class 229<TItem> : IEnumerable<!0>, IEnumerable, IEnumerator<!0>, IDisposable, IEnumerator where TItem : class
	{
		// Token: 0x06001E4B RID: 7755 RVA: 0x00076BBC File Offset: 0x00074DBC
		[DebuggerHidden]
		public 229(int 1)
		{
			this._number10872 = 1;
			this._number10874 = Thread.CurrentThread.ManagedThreadId;
		}

		// Token: 0x06001E4C RID: 7756 RVA: 0x00005ADD File Offset: 0x00003CDD
		[DebuggerHidden]
		private void Method14312()
		{
		}

		// Token: 0x06001E4D RID: 7757 RVA: 0x00076BDB File Offset: 0x00074DDB
		void IDisposable.Dispose()
		{
			this.Method14312();
		}

		// Token: 0x06001E4E RID: 7758 RVA: 0x00076BE4 File Offset: 0x00074DE4
		private bool MoveNext()
		{
			int number = this._number10872;
			226 jToken = this._jToken10875;
			switch (number)
			{
			case 0:
			{
				this._number10872 = -1;
				if (jToken.value7 == null)
				{
					return false;
				}
				object value = jToken.value7;
				this._valueArray10876 = (value as object[]);
				if (this._valueArray10876 != null)
				{
					this._number10877 = 0;
				}
				else
				{
					TItem titem = jToken.value7 as TItem;
					if (titem == null)
					{
						return false;
					}
					this._item10873 = titem;
					this._number10872 = 2;
					return true;
				}
				break;
			}
			case 1:
				this._number10872 = -1;
				goto IL_E1;
			case 2:
				this._number10872 = -1;
				return false;
			default:
				return false;
			}
			IL_94:
			if (this._number10877 < this._valueArray10876.Length)
			{
				object obj = this._valueArray10876[this._number10877];
				if (obj != null)
				{
					TItem titem2 = obj as TItem;
					if (titem2 != null)
					{
						this._item10873 = titem2;
						this._number10872 = 1;
						return true;
					}
					goto IL_E1;
				}
			}
			return false;
			IL_E1:
			this._number10877++;
			goto IL_94;
		}

		// Token: 0x06001E4F RID: 7759 RVA: 0x00076CE1 File Offset: 0x00074EE1
		bool IEnumerator.MoveNext()
		{
			return this.MoveNext();
		}

		// Token: 0x06001E50 RID: 7760 RVA: 0x00076CE9 File Offset: 0x00074EE9
		[DebuggerHidden]
		private TItem GetItem10873_14313()
		{
			return this._item10873;
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06001E51 RID: 7761 RVA: 0x00076CF1 File Offset: 0x00074EF1
		TItem IEnumerator<!0>.Current
		{
			get
			{
				return this.GetItem10873_14313();
			}
		}

		// Token: 0x06001E52 RID: 7762 RVA: 0x00005BE8 File Offset: 0x00003DE8
		[DebuggerHidden]
		private void Method14314()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001E53 RID: 7763 RVA: 0x00076CF9 File Offset: 0x00074EF9
		void IEnumerator.Reset()
		{
			this.Method14314();
		}

		// Token: 0x06001E54 RID: 7764 RVA: 0x00076D01 File Offset: 0x00074F01
		[DebuggerHidden]
		[return: 241(0)]
		private object GetItem10873_14315()
		{
			return this._item10873;
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06001E55 RID: 7765 RVA: 0x00076D0E File Offset: 0x00074F0E
		object IEnumerator.Current
		{
			get
			{
				return this.GetItem10873_14315();
			}
		}

		// Token: 0x06001E56 RID: 7766 RVA: 0x00076D18 File Offset: 0x00074F18
		[DebuggerHidden]
		[return: 241(0)]
		private IEnumerator<TItem> Method14316()
		{
			226.229<TItem> <<EMPTY_NAME>>;
			if (this._number10872 == -2 && this._number10874 == Thread.CurrentThread.ManagedThreadId)
			{
				this._number10872 = 0;
				<<EMPTY_NAME>> = this;
			}
			else
			{
				<<EMPTY_NAME>> = new 226.229<TItem>(0);
				<<EMPTY_NAME>>._jToken10875 = this._jToken10875;
			}
			return <<EMPTY_NAME>>;
		}

		// Token: 0x06001E57 RID: 7767 RVA: 0x00076D60 File Offset: 0x00074F60
		IEnumerator<TItem> IEnumerable<!0>.GetEnumerator()
		{
			return this.Method14316();
		}

		// Token: 0x06001E58 RID: 7768 RVA: 0x00076D60 File Offset: 0x00074F60
		[DebuggerHidden]
		[return: 241(0)]
		private IEnumerator Method14317()
		{
			return this.Method14316();
		}

		// Token: 0x06001E59 RID: 7769 RVA: 0x00076D68 File Offset: 0x00074F68
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.Method14317();
		}

		// Token: 0x04000EC5 RID: 3781
		private int _number10872;

		// Token: 0x04000EC6 RID: 3782
		private TItem _item10873;

		// Token: 0x04000EC7 RID: 3783
		private int _number10874;

		// Token: 0x04000EC8 RID: 3784
		[241(0)]
		public 226 _jToken10875;

		// Token: 0x04000EC9 RID: 3785
		[241(new byte[]
		{
			0,
			1
		})]
		private object[] _valueArray10876;

		// Token: 0x04000ECA RID: 3786
		private int _number10877;
	}

	// Token: 0x020003BE RID: 958
	[242(0)]
	public sealed class 230
	{
		// Token: 0x06001E5A RID: 7770 RVA: 0x00076D70 File Offset: 0x00074F70
		public 230(int 1, int 2)
		{
			this.number3 = 1;
			this.number4 = 2;
		}

		// Token: 0x04000ECB RID: 3787
		internal readonly int number3;

		// Token: 0x04000ECC RID: 3788
		internal readonly int number4;
	}

	// Token: 0x020003BF RID: 959
	public sealed class 231 : IEnumerable<226>, IEnumerable, IEnumerator<226>, IDisposable, IEnumerator
	{
		// Token: 0x06001E5B RID: 7771 RVA: 0x00076D86 File Offset: 0x00074F86
		[DebuggerHidden]
		public 231(int 1)
		{
			this.number2 = 1;
			this.number3 = Thread.CurrentThread.ManagedThreadId;
		}

		// Token: 0x06001E5C RID: 7772 RVA: 0x00005ADD File Offset: 0x00003CDD
		[DebuggerHidden]
		private void Method14318()
		{
		}

		// Token: 0x06001E5D RID: 7773 RVA: 0x00076DA5 File Offset: 0x00074FA5
		void IDisposable.Dispose()
		{
			this.Method14318();
		}

		// Token: 0x06001E5E RID: 7774 RVA: 0x00076DB0 File Offset: 0x00074FB0
		private bool MoveNext()
		{
			int num = this.number2;
			226 <<EMPTY_NAME>> = this.jToken3;
			if (num != 0)
			{
				if (num != 1)
				{
					return false;
				}
				this.number2 = -1;
				this.jToken4 = this.jToken4.Next;
			}
			else
			{
				this.number2 = -1;
				if (<<EMPTY_NAME>>.Parent == null)
				{
					return false;
				}
				this.jToken4 = <<EMPTY_NAME>>.Parent.First;
			}
			if (this.jToken4 != <<EMPTY_NAME>> && this.jToken4 != null)
			{
				this.jToken2 = this.jToken4;
				this.number2 = 1;
				return true;
			}
			this.jToken4 = null;
			return false;
		}

		// Token: 0x06001E5F RID: 7775 RVA: 0x00076E3E File Offset: 0x0007503E
		bool IEnumerator.MoveNext()
		{
			return this.MoveNext();
		}

		// Token: 0x06001E60 RID: 7776 RVA: 0x00076E46 File Offset: 0x00075046
		[DebuggerHidden]
		private 226 GetJToken10881_14319()
		{
			return this.jToken2;
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06001E61 RID: 7777 RVA: 0x00076E4E File Offset: 0x0007504E
		226 IEnumerator<226>.Current
		{
			get
			{
				return this.GetJToken10881_14319();
			}
		}

		// Token: 0x06001E62 RID: 7778 RVA: 0x00005BE8 File Offset: 0x00003DE8
		[DebuggerHidden]
		private void Method14320()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001E63 RID: 7779 RVA: 0x00076E56 File Offset: 0x00075056
		void IEnumerator.Reset()
		{
			this.Method14320();
		}

		// Token: 0x06001E64 RID: 7780 RVA: 0x00076E46 File Offset: 0x00075046
		[DebuggerHidden]
		[return: 241(0)]
		private object GetJToken10881_14321()
		{
			return this.jToken2;
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06001E65 RID: 7781 RVA: 0x00076E5E File Offset: 0x0007505E
		object IEnumerator.Current
		{
			get
			{
				return this.GetJToken10881_14321();
			}
		}

		// Token: 0x06001E66 RID: 7782 RVA: 0x00076E68 File Offset: 0x00075068
		[DebuggerHidden]
		[return: 241(0)]
		private IEnumerator<226> Method14322()
		{
			226.231 <<EMPTY_NAME>>;
			if (this.number2 == -2 && this.number3 == Thread.CurrentThread.ManagedThreadId)
			{
				this.number2 = 0;
				<<EMPTY_NAME>> = this;
			}
			else
			{
				<<EMPTY_NAME>> = new 226.231(0);
				<<EMPTY_NAME>>.jToken3 = this.jToken3;
			}
			return <<EMPTY_NAME>>;
		}

		// Token: 0x06001E67 RID: 7783 RVA: 0x00076EB0 File Offset: 0x000750B0
		IEnumerator<226> IEnumerable<226>.GetEnumerator()
		{
			return this.Method14322();
		}

		// Token: 0x06001E68 RID: 7784 RVA: 0x00076EB0 File Offset: 0x000750B0
		[DebuggerHidden]
		[return: 241(0)]
		private IEnumerator Method14323()
		{
			return this.Method14322();
		}

		// Token: 0x06001E69 RID: 7785 RVA: 0x00076EB8 File Offset: 0x000750B8
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.Method14323();
		}

		// Token: 0x04000ECD RID: 3789
		private int number2;

		// Token: 0x04000ECE RID: 3790
		private 226 jToken2;

		// Token: 0x04000ECF RID: 3791
		private int number3;

		// Token: 0x04000ED0 RID: 3792
		[241(0)]
		public 226 jToken3;

		// Token: 0x04000ED1 RID: 3793
		[241(0)]
		private 226 jToken4;
	}

	// Token: 0x020003C0 RID: 960
	public sealed class 232 : IEnumerable<226>, IEnumerable, IEnumerator<226>, IDisposable, IEnumerator
	{
		// Token: 0x06001E6A RID: 7786 RVA: 0x00076EC0 File Offset: 0x000750C0
		[DebuggerHidden]
		public 232(int 1)
		{
			this.number2 = 1;
			this.number3 = Thread.CurrentThread.ManagedThreadId;
		}

		// Token: 0x06001E6B RID: 7787 RVA: 0x00005ADD File Offset: 0x00003CDD
		[DebuggerHidden]
		private void Method14324()
		{
		}

		// Token: 0x06001E6C RID: 7788 RVA: 0x00076EDF File Offset: 0x000750DF
		void IDisposable.Dispose()
		{
			this.Method14324();
		}

		// Token: 0x06001E6D RID: 7789 RVA: 0x00076EE8 File Offset: 0x000750E8
		private bool MoveNext()
		{
			int num = this.number2;
			226 <<EMPTY_NAME>> = this.jToken3;
			if (num != 0)
			{
				if (num != 1)
				{
					return false;
				}
				this.number2 = -1;
				this.jToken4 = this.jToken4.Parent;
			}
			else
			{
				this.number2 = -1;
				this.jToken4 = (this.flag ? <<EMPTY_NAME>> : <<EMPTY_NAME>>.Parent);
			}
			if (this.jToken4 != null)
			{
				this.jToken2 = this.jToken4;
				this.number2 = 1;
				return true;
			}
			this.jToken4 = null;
			return false;
		}

		// Token: 0x06001E6E RID: 7790 RVA: 0x00076F69 File Offset: 0x00075169
		bool IEnumerator.MoveNext()
		{
			return this.MoveNext();
		}

		// Token: 0x06001E6F RID: 7791 RVA: 0x00076F71 File Offset: 0x00075171
		[DebuggerHidden]
		private 226 GetJToken10886_14325()
		{
			return this.jToken2;
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06001E70 RID: 7792 RVA: 0x00076F79 File Offset: 0x00075179
		226 IEnumerator<226>.Current
		{
			get
			{
				return this.GetJToken10886_14325();
			}
		}

		// Token: 0x06001E71 RID: 7793 RVA: 0x00005BE8 File Offset: 0x00003DE8
		[DebuggerHidden]
		private void Method14326()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001E72 RID: 7794 RVA: 0x00076F81 File Offset: 0x00075181
		void IEnumerator.Reset()
		{
			this.Method14326();
		}

		// Token: 0x06001E73 RID: 7795 RVA: 0x00076F71 File Offset: 0x00075171
		[DebuggerHidden]
		[return: 241(0)]
		private object GetJToken10886_14327()
		{
			return this.jToken2;
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06001E74 RID: 7796 RVA: 0x00076F89 File Offset: 0x00075189
		object IEnumerator.Current
		{
			get
			{
				return this.GetJToken10886_14327();
			}
		}

		// Token: 0x06001E75 RID: 7797 RVA: 0x00076F94 File Offset: 0x00075194
		[DebuggerHidden]
		[return: 241(0)]
		private IEnumerator<226> Method14328()
		{
			226.232 <<EMPTY_NAME>>;
			if (this.number2 == -2 && this.number3 == Thread.CurrentThread.ManagedThreadId)
			{
				this.number2 = 0;
				<<EMPTY_NAME>> = this;
			}
			else
			{
				<<EMPTY_NAME>> = new 226.232(0);
				<<EMPTY_NAME>>.jToken3 = this.jToken3;
			}
			<<EMPTY_NAME>>.flag = this.flag2;
			return <<EMPTY_NAME>>;
		}

		// Token: 0x06001E76 RID: 7798 RVA: 0x00076FE8 File Offset: 0x000751E8
		IEnumerator<226> IEnumerable<226>.GetEnumerator()
		{
			return this.Method14328();
		}

		// Token: 0x06001E77 RID: 7799 RVA: 0x00076FE8 File Offset: 0x000751E8
		[DebuggerHidden]
		[return: 241(0)]
		private IEnumerator Method14329()
		{
			return this.Method14328();
		}

		// Token: 0x06001E78 RID: 7800 RVA: 0x00076FF0 File Offset: 0x000751F0
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.Method14329();
		}

		// Token: 0x04000ED2 RID: 3794
		private int number2;

		// Token: 0x04000ED3 RID: 3795
		private 226 jToken2;

		// Token: 0x04000ED4 RID: 3796
		private int number3;

		// Token: 0x04000ED5 RID: 3797
		private bool flag;

		// Token: 0x04000ED6 RID: 3798
		public bool flag2;

		// Token: 0x04000ED7 RID: 3799
		[241(0)]
		public 226 jToken3;

		// Token: 0x04000ED8 RID: 3800
		[241(0)]
		private 226 jToken4;
	}
}
