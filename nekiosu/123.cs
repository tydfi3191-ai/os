using System;
using System.Runtime.InteropServices;

// Token: 0x020000ED RID: 237
[ComVisible(false)]
[242(1)]
[241(0)]
public sealed class 123 : 139, 99
{
	// Token: 0x17000074 RID: 116
	// (get) Token: 0x06000817 RID: 2071 RVA: 0x0001BC54 File Offset: 0x00019E54
	[241(2)]
	public 226 JToken6023
	{
		[242(2)]
		get
		{
			return this.jToken4;
		}
	}

	// Token: 0x06000818 RID: 2072 RVA: 0x0001BC5C File Offset: 0x00019E5C
	public 123(226 1)
	{
		756.Method12216(1, "token");
		this.jToken2 = 1;
	}

	// Token: 0x06000819 RID: 2073 RVA: 0x0001BC76 File Offset: 0x00019E76
	public 123(226 1, string 2) : this(1)
	{
		this.text2 = 2;
	}

	// Token: 0x0600081A RID: 2074 RVA: 0x0001BC88 File Offset: 0x00019E88
	public override bool Read()
	{
		if (base.GetReaderState() != 139.140.Start)
		{
			if (this.jToken4 == null)
			{
				return false;
			}
			111 <<EMPTY_NAME>> = this.jToken4 as 111;
			if (<<EMPTY_NAME>> != null && this.jToken3 != <<EMPTY_NAME>>)
			{
				return this.Method7735(<<EMPTY_NAME>>);
			}
			return this.Method7732(this.jToken4);
		}
		else
		{
			if (this.jToken4 == this.jToken2)
			{
				return false;
			}
			this.jToken4 = this.jToken2;
			this.Method7737(this.jToken4);
			return true;
		}
	}

	// Token: 0x0600081B RID: 2075 RVA: 0x0001BD00 File Offset: 0x00019F00
	private bool Method7732(226 1)
	{
		if (1 == this.jToken2)
		{
			return this.Method7733();
		}
		226 next = 1.Next;
		if (next != null && next != 1 && 1 != 1.Parent.Last)
		{
			this.jToken4 = next;
			this.Method7737(this.jToken4);
			return true;
		}
		if (1.Parent == null)
		{
			return this.Method7733();
		}
		return this.Method7736(1.Parent);
	}

	// Token: 0x0600081C RID: 2076 RVA: 0x0001BD69 File Offset: 0x00019F69
	private bool Method7733()
	{
		this.jToken4 = null;
		base.SetToken(216.None);
		return false;
	}

	// Token: 0x0600081D RID: 2077 RVA: 0x0001BD7C File Offset: 0x00019F7C
	private 216? Method7734(111 1)
	{
		216? result;
		switch (1.Type)
		{
		case 705.Object:
			result = new 216?(216.EndObject);
			break;
		case 705.Array:
			result = new 216?(216.EndArray);
			break;
		case 705.Constructor:
			result = new 216?(216.EndConstructor);
			break;
		case 705.Property:
			result = null;
			break;
		default:
			throw 736.Method11629("Type", 1.Type, "Unexpected JContainer type.");
		}
		return result;
	}

	// Token: 0x0600081E RID: 2078 RVA: 0x0001BDF0 File Offset: 0x00019FF0
	private bool Method7735(111 1)
	{
		226 first = 1.First;
		if (first == null)
		{
			return this.Method7736(1);
		}
		this.Method7737(first);
		this.jToken4 = first;
		this.jToken3 = 1;
		return true;
	}

	// Token: 0x0600081F RID: 2079 RVA: 0x0001BE28 File Offset: 0x0001A028
	private bool Method7736(111 1)
	{
		216? 2 = this.Method7734(1);
		if (2 != null)
		{
			base.SetToken(2.GetValueOrDefault());
			this.jToken4 = 1;
			this.jToken3 = 1;
			return true;
		}
		return this.Method7732(1);
	}

	// Token: 0x06000820 RID: 2080 RVA: 0x0001BE6C File Offset: 0x0001A06C
	private void Method7737(226 1)
	{
		switch (1.Type)
		{
		case 705.Object:
			base.SetToken(216.StartObject);
			return;
		case 705.Array:
			base.SetToken(216.StartArray);
			return;
		case 705.Constructor:
			base.SetToken(216.StartConstructor, ((110)1).Name);
			return;
		case 705.Property:
			base.SetToken(216.PropertyName, ((222)1).Name);
			return;
		case 705.Comment:
			base.SetToken(216.Comment, ((233)1).Value);
			return;
		case 705.Integer:
			base.SetToken(216.Integer, ((233)1).Value);
			return;
		case 705.Float:
			base.SetToken(216.Float, ((233)1).Value);
			return;
		case 705.String:
			base.SetToken(216.String, ((233)1).Value);
			return;
		case 705.Boolean:
			base.SetToken(216.Boolean, ((233)1).Value);
			return;
		case 705.Null:
			base.SetToken(216.Null, ((233)1).Value);
			return;
		case 705.Undefined:
			base.SetToken(216.Undefined, ((233)1).Value);
			return;
		case 705.Date:
		{
			object obj = ((233)1).Value;
			if (obj is DateTime)
			{
				DateTime 2 = (DateTime)obj;
				obj = 382.Method2108(2, base.GetDateTimeZoneHandling());
			}
			base.SetToken(216.Date, obj);
			return;
		}
		case 705.Raw:
			base.SetToken(216.Raw, ((233)1).Value);
			return;
		case 705.Bytes:
			base.SetToken(216.Bytes, ((233)1).Value);
			return;
		case 705.Guid:
			base.SetToken(216.String, this.Method7738(((233)1).Value));
			return;
		case 705.Uri:
		{
			object value = ((233)1).Value;
			216 3 = 216.String;
			Uri uri = value as Uri;
			base.SetToken(3, (uri != null) ? uri.OriginalString : this.Method7738(value));
			return;
		}
		case 705.TimeSpan:
			base.SetToken(216.String, this.Method7738(((233)1).Value));
			return;
		default:
			throw 736.Method11629("Type", 1.Type, "Unexpected JTokenType.");
		}
	}

	// Token: 0x06000821 RID: 2081 RVA: 0x0001C06D File Offset: 0x0001A26D
	[242(2)]
	private string Method7738(object 1)
	{
		if (1 == null)
		{
			return null;
		}
		return 1.ToString();
	}

	// Token: 0x06000822 RID: 2082 RVA: 0x0001C07A File Offset: 0x0001A27A
	private bool Method7739()
	{
		if (base.GetReaderState() == 139.140.Start)
		{
			return false;
		}
		226 <<EMPTY_NAME>> = this.jToken4;
		return <<EMPTY_NAME>> != null && ((99)<<EMPTY_NAME>>).HasLineInfo();
	}

	// Token: 0x06000823 RID: 2083 RVA: 0x0001C097 File Offset: 0x0001A297
	bool 99.HasLineInfo()
	{
		return this.Method7739();
	}

	// Token: 0x06000824 RID: 2084 RVA: 0x0001C09F File Offset: 0x0001A29F
	private int Method7741()
	{
		if (base.GetReaderState() == 139.140.Start)
		{
			return 0;
		}
		226 <<EMPTY_NAME>> = this.jToken4;
		if (<<EMPTY_NAME>> == null)
		{
			return 0;
		}
		return ((99)<<EMPTY_NAME>>).GetLineNumber();
	}

	// Token: 0x06000825 RID: 2085 RVA: 0x0001C0BC File Offset: 0x0001A2BC
	int 99.GetLineNumber()
	{
		return this.Method7741();
	}

	// Token: 0x06000826 RID: 2086 RVA: 0x0001C0C4 File Offset: 0x0001A2C4
	private int Method7743()
	{
		if (base.GetReaderState() == 139.140.Start)
		{
			return 0;
		}
		226 <<EMPTY_NAME>> = this.jToken4;
		if (<<EMPTY_NAME>> == null)
		{
			return 0;
		}
		return ((99)<<EMPTY_NAME>>).GetLinePosition();
	}

	// Token: 0x06000827 RID: 2087 RVA: 0x0001C0E1 File Offset: 0x0001A2E1
	int 99.GetLinePosition()
	{
		return this.Method7743();
	}

	// Token: 0x06000828 RID: 2088 RVA: 0x0001C0EC File Offset: 0x0001A2EC
	public string Method7745()
	{
		string text = base.Path;
		if (this.text2 == null)
		{
			this.text2 = this.jToken2.Path;
		}
		if (!538.Method6824(this.text2))
		{
			if (538.Method6824(text))
			{
				return this.text2;
			}
			text = ((!text.Method6843('[')) ? (this.text2 + "." + text) : (this.text2 + text));
		}
		return text;
	}

	// Token: 0x040004AE RID: 1198
	private readonly 226 jToken2;

	// Token: 0x040004AF RID: 1199
	[241(2)]
	private string text2;

	// Token: 0x040004B0 RID: 1200
	[241(2)]
	private 226 jToken3;

	// Token: 0x040004B1 RID: 1201
	[241(2)]
	private 226 jToken4;
}
