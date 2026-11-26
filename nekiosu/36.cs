using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Runtime.InteropServices;

// Token: 0x020000C1 RID: 193
[241(0)]
[242(1)]
[ComVisible(false)]
public sealed class 36 : 214
{
	// Token: 0x06000510 RID: 1296 RVA: 0x0000F388 File Offset: 0x0000D588
	public override void WriteJson(173 1, [241(2)] object 2, 158 3)
	{
		if (2 == null)
		{
			1.WriteNull();
			return;
		}
		byte[] 4 = this.Method5640(2);
		1.WriteValue(4);
	}

	// Token: 0x06000511 RID: 1297 RVA: 0x0000F3B0 File Offset: 0x0000D5B0
	private byte[] Method5640(object 1)
	{
		if (1.GetType().FullName == "System.Data.Linq.Binary")
		{
			36.Method5641(1.GetType());
			return (byte[])36._recoveredType13754491.Method7912(1, "ToArray");
		}
		if (1 is SqlBinary)
		{
			return ((SqlBinary)1).Value;
		}
		throw new 364("Unexpected value type when writing binary: {0}".Method6825(CultureInfo.InvariantCulture, 1.GetType()));
	}

	// Token: 0x06000512 RID: 1298 RVA: 0x0000F426 File Offset: 0x0000D626
	private static void Method5641(Type 1)
	{
		if (36._recoveredType13754491 == null)
		{
			36._recoveredType13754491 = 580.Method7915(1, 1.GetConstructor(new Type[]
			{
				typeof(byte[])
			}), new string[]
			{
				"ToArray"
			});
		}
	}

	// Token: 0x06000513 RID: 1299 RVA: 0x0000F464 File Offset: 0x0000D664
	[return: 241(2)]
	public override object ReadJson(139 1, Type 2, [241(2)] object 3, 158 4)
	{
		if (1.GetTokenType() == 216.Null)
		{
			if (!143.IsNullable(2))
			{
				throw 364.Method1687(1, "Cannot convert null value to {0}.".Method6825(CultureInfo.InvariantCulture, 2));
			}
			return null;
		}
		else
		{
			byte[] array;
			if (1.GetTokenType() == 216.StartArray)
			{
				array = this.Method5642(1);
			}
			else
			{
				if (1.GetTokenType() != 216.String)
				{
					throw 364.Method1687(1, "Unexpected token parsing binary. Expected String or StartArray, got {0}.".Method6825(CultureInfo.InvariantCulture, 1.GetTokenType()));
				}
				array = Convert.FromBase64String(1.GetValue().ToString());
			}
			Type type = 143.IsNullableType(2) ? Nullable.GetUnderlyingType(2) : 2;
			if (type.FullName == "System.Data.Linq.Binary")
			{
				36.Method5641(type);
				return 36._recoveredType13754491.RecoveredType10456129(new object[]
				{
					array
				});
			}
			if (type == typeof(SqlBinary))
			{
				return new SqlBinary(array);
			}
			throw 364.Method1687(1, "Unexpected object type when writing binary: {0}".Method6825(CultureInfo.InvariantCulture, 2));
		}
	}

	// Token: 0x06000514 RID: 1300 RVA: 0x0000F564 File Offset: 0x0000D764
	private byte[] Method5642(139 1)
	{
		List<byte> list = new List<byte>();
		while (1.Read())
		{
			216 tokenType = 1.GetTokenType();
			if (tokenType != 216.Comment)
			{
				if (tokenType != 216.Integer)
				{
					if (tokenType != 216.EndArray)
					{
						throw 364.Method1687(1, "Unexpected token when reading bytes: {0}".Method6825(CultureInfo.InvariantCulture, 1.GetTokenType()));
					}
					return list.ToArray();
				}
				else
				{
					list.Add(Convert.ToByte(1.GetValue(), CultureInfo.InvariantCulture));
				}
			}
		}
		throw 364.Method1687(1, "Unexpected end when reading bytes.");
	}

	// Token: 0x06000515 RID: 1301 RVA: 0x0000F5E2 File Offset: 0x0000D7E2
	public override bool CanConvert(Type 1)
	{
		return 1.FullName == "System.Data.Linq.Binary" || (1 == typeof(SqlBinary) || 1 == typeof(SqlBinary?));
	}

	// Token: 0x04000402 RID: 1026
	[241(2)]
	private static 580 _recoveredType13754491;
}
