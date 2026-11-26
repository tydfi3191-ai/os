using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

// Token: 0x0200098A RID: 2442
[ComVisible(false)]
public sealed class 1648 : BinaryWriter
{
	// Token: 0x06004495 RID: 17557 RVA: 0x001B0D1F File Offset: 0x001AEF1F
	public 1648(Stream 1) : base(1, Encoding.UTF8)
	{
	}

	// Token: 0x06004496 RID: 17558 RVA: 0x001B0D2D File Offset: 0x001AEF2D
	public override void Write(string 1)
	{
		if (1 == null)
		{
			this.Write(0);
			return;
		}
		this.Write(11);
		base.Write(1);
	}

	// Token: 0x06004497 RID: 17559 RVA: 0x001B0D4C File Offset: 0x001AEF4C
	public override void Write(byte[] 1)
	{
		if (1 == null)
		{
			this.Write(-1);
			return;
		}
		int num = 1.Length;
		this.Write(num);
		if (num > 0)
		{
			base.Write(1);
		}
	}

	// Token: 0x06004498 RID: 17560 RVA: 0x001B0D7C File Offset: 0x001AEF7C
	public override void Write(char[] 1)
	{
		if (1 == null)
		{
			this.Write(-1);
			return;
		}
		int num = 1.Length;
		this.Write(num);
		if (num > 0)
		{
			base.Write(1);
		}
	}

	// Token: 0x06004499 RID: 17561 RVA: 0x001B0DAC File Offset: 0x001AEFAC
	public void 1(DateTime 1)
	{
		this.Write(1.ToUniversalTime().Ticks);
	}

	// Token: 0x0600449A RID: 17562 RVA: 0x001B0DD0 File Offset: 0x001AEFD0
	public void 2<T>(List<T> 1) where T : 1570
	{
		if (1 == null)
		{
			this.Write(-1);
			return;
		}
		int count = 1.Count;
		this.Write(count);
		for (int i = 0; i < count; i++)
		{
			T t = 1[i];
			t.WriteTo(this);
		}
	}

	// Token: 0x0600449B RID: 17563 RVA: 0x001B0E18 File Offset: 0x001AF018
	public void 3<T, U>(IDictionary<T, U> 1)
	{
		if (1 == null)
		{
			this.Write(-1);
			return;
		}
		this.Write(1.Count);
		foreach (KeyValuePair<T, U> keyValuePair in 1)
		{
			this.4(keyValuePair.Key);
			this.4(keyValuePair.Value);
		}
	}

	// Token: 0x0600449C RID: 17564 RVA: 0x001B0E94 File Offset: 0x001AF094
	public void 4(object 1)
	{
		if (1 == null)
		{
			this.Write(0);
			return;
		}
		string name = 1.GetType().Name;
		uint num = 299.Method0301(name);
		if (num <= 2386971688U)
		{
			if (num <= 765439473U)
			{
				if (num <= 679076413U)
				{
					if (num != 423635464U)
					{
						if (num == 679076413U)
						{
							if (name == "Char")
							{
								this.Write(10);
								base.Write((char)1);
								return;
							}
						}
					}
					else if (name == "SByte")
					{
						this.Write(6);
						this.Write((sbyte)1);
						return;
					}
				}
				else if (num != 697196164U)
				{
					if (num == 765439473U)
					{
						if (name == "Int16")
						{
							this.Write(7);
							this.Write((short)1);
							return;
						}
					}
				}
				else if (name == "Int64")
				{
					this.Write(9);
					this.Write((long)1);
					return;
				}
			}
			else if (num <= 1324880019U)
			{
				if (num != 1323747186U)
				{
					if (num == 1324880019U)
					{
						if (name == "UInt64")
						{
							this.Write(5);
							this.Write((ulong)1);
							return;
						}
					}
				}
				else if (name == "UInt16")
				{
					this.Write(3);
					this.Write((ushort)1);
					return;
				}
			}
			else if (num != 1615808600U)
			{
				if (num == 2386971688U)
				{
					if (name == "Double")
					{
						this.Write(13);
						this.Write((double)1);
						return;
					}
				}
			}
			else if (name == "String")
			{
				this.Write(11);
				base.Write((string)1);
				return;
			}
		}
		else if (num <= 2779444460U)
		{
			if (num <= 2642490659U)
			{
				if (num != 2615964816U)
				{
					if (num == 2642490659U)
					{
						if (name == "Byte[]")
						{
							this.Write(16);
							base.Write((byte[])1);
							return;
						}
					}
				}
				else if (name == "DateTime")
				{
					this.Write(15);
					this.1((DateTime)1);
					return;
				}
			}
			else if (num != 2711245919U)
			{
				if (num == 2779444460U)
				{
					if (name == "Decimal")
					{
						this.Write(14);
						this.Write((decimal)1);
						return;
					}
				}
			}
			else if (name == "Int32")
			{
				this.Write(8);
				this.Write((int)1);
				return;
			}
		}
		else if (num <= 3538687084U)
		{
			if (num != 3409549631U)
			{
				if (num == 3538687084U)
				{
					if (name == "UInt32")
					{
						this.Write(4);
						this.Write((uint)1);
						return;
					}
				}
			}
			else if (name == "Byte")
			{
				this.Write(2);
				this.Write((byte)1);
				return;
			}
		}
		else if (num != 3585005533U)
		{
			if (num != 3969205087U)
			{
				if (num == 4051133705U)
				{
					if (name == "Single")
					{
						this.Write(12);
						this.Write((float)1);
						return;
					}
				}
			}
			else if (name == "Boolean")
			{
				this.Write(1);
				this.Write((bool)1);
				return;
			}
		}
		else if (name == "Char[]")
		{
			this.Write(17);
			base.Write((char[])1);
			return;
		}
		throw new InvalidDataException("Serialization of arbitrary type is not supported.");
	}

	// Token: 0x0600449D RID: 17565 RVA: 0x001B1242 File Offset: 0x001AF442
	public void 5(byte[] 1)
	{
		base.Write(1);
	}

	// Token: 0x0600449E RID: 17566 RVA: 0x001B124C File Offset: 0x001AF44C
	public void 6(byte[] 1)
	{
		if (1 == null)
		{
			this.Write(-1);
			return;
		}
		int num = 1.Length;
		this.Write(num);
		if (num > 0)
		{
			base.Write(1);
		}
	}

	// Token: 0x0600449F RID: 17567 RVA: 0x001B127A File Offset: 0x001AF47A
	internal void 7(string 1)
	{
		this.5(Encoding.UTF8.GetBytes(1));
	}
}
