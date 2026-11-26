using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

// Token: 0x02000989 RID: 2441
[ComVisible(false)]
public sealed class 1647 : BinaryReader
{
	// Token: 0x0600448D RID: 17549 RVA: 0x001B0A54 File Offset: 0x001AEC54
	public 1647(Stream 1) : base(1, Encoding.UTF8)
	{
		this.1 = 1;
	}

	// Token: 0x0600448E RID: 17550 RVA: 0x001B0A69 File Offset: 0x001AEC69
	public override string ReadString()
	{
		if (this.ReadByte() == 0)
		{
			return null;
		}
		return base.ReadString();
	}

	// Token: 0x0600448F RID: 17551 RVA: 0x001B0A7C File Offset: 0x001AEC7C
	public byte[] 1()
	{
		int num = this.ReadInt32();
		if (num > 0)
		{
			return this.ReadBytes(num);
		}
		if (num < 0)
		{
			return null;
		}
		return new byte[0];
	}

	// Token: 0x06004490 RID: 17552 RVA: 0x001B0AA8 File Offset: 0x001AECA8
	public char[] 2()
	{
		int num = this.ReadInt32();
		if (num > 0)
		{
			return this.ReadChars(num);
		}
		if (num < 0)
		{
			return null;
		}
		return new char[0];
	}

	// Token: 0x06004491 RID: 17553 RVA: 0x001B0AD4 File Offset: 0x001AECD4
	public DateTime 3()
	{
		long num = this.ReadInt64();
		if (num < 0L)
		{
			throw new AbandonedMutexException("oops");
		}
		return new DateTime(num, DateTimeKind.Utc);
	}

	// Token: 0x06004492 RID: 17554 RVA: 0x001B0AF4 File Offset: 0x001AECF4
	public IList<T> 4<T>(bool 1) where T : 1570, new()
	{
		int num = this.ReadInt32();
		if (num < 0)
		{
			return null;
		}
		IList<T> list = new List<T>(num);
		1647 2 = new 1647(this.BaseStream);
		int i = 0;
		while (i < num)
		{
			T item = Activator.CreateInstance<T>();
			try
			{
				item.ReadFrom(2);
			}
			catch (Exception)
			{
				if (1)
				{
					goto IL_4B;
				}
				throw;
			}
			goto IL_43;
			IL_4B:
			i++;
			continue;
			IL_43:
			list.Add(item);
			goto IL_4B;
		}
		return list;
	}

	// Token: 0x06004493 RID: 17555 RVA: 0x001B0B68 File Offset: 0x001AED68
	public IDictionary<T, U> 5<T, U>()
	{
		int num = this.ReadInt32();
		if (num < 0)
		{
			return null;
		}
		IDictionary<T, U> dictionary = new Dictionary<T, U>();
		for (int i = 0; i < num; i++)
		{
			dictionary[(T)((object)this.6())] = (U)((object)this.6());
		}
		return dictionary;
	}

	// Token: 0x06004494 RID: 17556 RVA: 0x001B0BB4 File Offset: 0x001AEDB4
	public object 6()
	{
		object result;
		switch (this.ReadByte())
		{
		case 1:
			result = this.ReadBoolean();
			break;
		case 2:
			result = this.ReadByte();
			break;
		case 3:
			result = this.ReadUInt16();
			break;
		case 4:
			result = this.ReadUInt32();
			break;
		case 5:
			result = this.ReadUInt64();
			break;
		case 6:
			result = this.ReadSByte();
			break;
		case 7:
			result = this.ReadInt16();
			break;
		case 8:
			result = this.ReadInt32();
			break;
		case 9:
			result = this.ReadInt64();
			break;
		case 10:
			result = this.ReadChar();
			break;
		case 11:
			result = base.ReadString();
			break;
		case 12:
			result = this.ReadSingle();
			break;
		case 13:
			result = this.ReadDouble();
			break;
		case 14:
			result = this.ReadDecimal();
			break;
		case 15:
			result = this.3();
			break;
		case 16:
			result = this.1();
			break;
		case 17:
			result = this.2();
			break;
		case 18:
			throw new InvalidDataException("Deserialization of arbitrary type is not supported.");
		default:
			result = null;
			break;
		}
		return result;
	}

	// Token: 0x0400327A RID: 12922
	private Stream 1;
}
