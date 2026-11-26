using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;

// Token: 0x02000089 RID: 137
public static class 102
{
	// Token: 0x060002DD RID: 733 RVA: 0x000092AC File Offset: 0x000074AC
	public static void InitializeOpCodeTables()
	{
		102.singleByteOpCodes = new OpCode[256];
		102.doubleByteOpCodes = new OpCode[256];
		foreach (FieldInfo fieldInfo in typeof(OpCodes).GetFields())
		{
			if (fieldInfo.FieldType == typeof(OpCode))
			{
				OpCode opCode = (OpCode)fieldInfo.GetValue(null);
				ushort num = (ushort)opCode.Value;
				if (num < 256)
				{
					102.singleByteOpCodes[(int)num] = opCode;
				}
				else
				{
					if ((num & 65280) != 65024)
					{
						throw new Exception("Invalid OpCode.");
					}
					102.doubleByteOpCodes[(int)(num & 255)] = opCode;
				}
			}
		}
	}

	// Token: 0x060002DE RID: 734 RVA: 0x00009370 File Offset: 0x00007570
	public static string NormalizeTypeName(string 1)
	{
		string result = 1;
		if (!(1 == "System.string") && !(1 == "System.String") && !(1 == "String"))
		{
			if (1 == "System.Int32" || 1 == "Int" || 1 == "Int32")
			{
				result = "int";
			}
		}
		else
		{
			result = "string";
		}
		return result;
	}

	// Token: 0x0400033F RID: 831
	public static Dictionary<int, object> dictionary = new Dictionary<int, object>();

	// Token: 0x04000340 RID: 832
	public static OpCode[] doubleByteOpCodes;

	// Token: 0x04000341 RID: 833
	public static OpCode[] singleByteOpCodes;

	// Token: 0x04000342 RID: 834
	public static Module[] moduleArray = null;
}
