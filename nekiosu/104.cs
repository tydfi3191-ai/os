using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;

// Token: 0x0200022D RID: 557
public sealed class 104
{
	// Token: 0x0600113F RID: 4415 RVA: 0x0003DC68 File Offset: 0x0003BE68
	public 104(MethodBase 1)
	{
		this.sourceMethod = 1;
		byte[] array = (1.GetMethodBody() != null) ? 1.GetMethodBody().GetILAsByteArray() : null;
		if (array != null)
		{
			this.ilBytes = array;
			this.DecodeInstructions(1.Module);
		}
	}

	// Token: 0x06001140 RID: 4416 RVA: 0x0003DCB4 File Offset: 0x0003BEB4
	private int ReadInt16(byte[] 1, ref int 2)
	{
		byte[] array = this.ilBytes;
		int num = 2;
		2 = num + 1;
		int num2 = array[num];
		byte[] array2 = this.ilBytes;
		num = 2;
		2 = num + 1;
		return num2 | array2[num] << 8;
	}

	// Token: 0x06001141 RID: 4417 RVA: 0x0003DCE4 File Offset: 0x0003BEE4
	private ushort ReadUInt16(byte[] 1, ref int 2)
	{
		byte[] array = this.ilBytes;
		int num = 2;
		2 = num + 1;
		ushort num2 = array[num];
		byte[] array2 = this.ilBytes;
		num = 2;
		2 = num + 1;
		return num2 | array2[num] << 8;
	}

	// Token: 0x06001142 RID: 4418 RVA: 0x0003DD18 File Offset: 0x0003BF18
	private int ReadInt32(byte[] 1, ref int 2)
	{
		byte[] array = this.ilBytes;
		int num = 2;
		2 = num + 1;
		int num2 = array[num];
		byte[] array2 = this.ilBytes;
		num = 2;
		2 = num + 1;
		int num3 = num2 | array2[num] << 8;
		byte[] array3 = this.ilBytes;
		num = 2;
		2 = num + 1;
		int num4 = num3 | array3[num] << 16;
		byte[] array4 = this.ilBytes;
		num = 2;
		2 = num + 1;
		return num4 | array4[num] << 24;
	}

	// Token: 0x06001143 RID: 4419 RVA: 0x0003DD70 File Offset: 0x0003BF70
	private ulong ReadUInt64(byte[] 1, ref int 2)
	{
		byte[] array = this.ilBytes;
		int num = 2;
		2 = num + 1;
		long num2 = array[num];
		byte[] array2 = this.ilBytes;
		num = 2;
		2 = num + 1;
		long num3 = num2 | array2[num] << 8;
		byte[] array3 = this.ilBytes;
		num = 2;
		2 = num + 1;
		long num4 = num3 | array3[num] << 16;
		byte[] array4 = this.ilBytes;
		num = 2;
		2 = num + 1;
		long num5 = num4 | array4[num] << 24;
		byte[] array5 = this.ilBytes;
		num = 2;
		2 = num + 1;
		long num6 = num5 | array5[num];
		byte[] array6 = this.ilBytes;
		num = 2;
		2 = num + 1;
		long num7 = num6 | array6[num] << 8;
		byte[] array7 = this.ilBytes;
		num = 2;
		2 = num + 1;
		long num8 = num7 | array7[num] << 16;
		byte[] array8 = this.ilBytes;
		num = 2;
		2 = num + 1;
		return (ulong)(num8 | array8[num] << 24);
	}

	// Token: 0x06001144 RID: 4420 RVA: 0x0003DE18 File Offset: 0x0003C018
	private double ReadDouble(byte[] 1, ref int 2)
	{
		byte[] array = this.ilBytes;
		int num = 2;
		2 = num + 1;
		double num2 = array[num];
		byte[] array2 = this.ilBytes;
		num = 2;
		2 = num + 1;
		double num3 = num2 | array2[num] << 8;
		byte[] array3 = this.ilBytes;
		num = 2;
		2 = num + 1;
		double num4 = num3 | array3[num] << 16;
		byte[] array4 = this.ilBytes;
		num = 2;
		2 = num + 1;
		double num5 = num4 | array4[num] << 24;
		byte[] array5 = this.ilBytes;
		num = 2;
		2 = num + 1;
		double num6 = num5 | array5[num];
		byte[] array6 = this.ilBytes;
		num = 2;
		2 = num + 1;
		double num7 = num6 | array6[num] << 8;
		byte[] array7 = this.ilBytes;
		num = 2;
		2 = num + 1;
		double num8 = num7 | array7[num] << 16;
		byte[] array8 = this.ilBytes;
		num = 2;
		2 = num + 1;
		return num8 | array8[num] << 24;
	}

	// Token: 0x06001145 RID: 4421 RVA: 0x0003DEC0 File Offset: 0x0003C0C0
	private sbyte ReadSByte(byte[] 1, ref int 2)
	{
		byte[] array = this.ilBytes;
		int num = 2;
		2 = num + 1;
		return array[num];
	}

	// Token: 0x06001146 RID: 4422 RVA: 0x0003DEE0 File Offset: 0x0003C0E0
	private byte ReadByte(byte[] 1, ref int 2)
	{
		byte[] array = this.ilBytes;
		int num = 2;
		2 = num + 1;
		return array[num];
	}

	// Token: 0x06001147 RID: 4423 RVA: 0x0003DF00 File Offset: 0x0003C100
	private float ReadSingle(byte[] 1, ref int 2)
	{
		byte[] array = this.ilBytes;
		int num = 2;
		2 = num + 1;
		float num2 = array[num];
		byte[] array2 = this.ilBytes;
		num = 2;
		2 = num + 1;
		float num3 = num2 | array2[num] << 8;
		byte[] array3 = this.ilBytes;
		num = 2;
		2 = num + 1;
		float num4 = num3 | array3[num] << 16;
		byte[] array4 = this.ilBytes;
		num = 2;
		2 = num + 1;
		return num4 | array4[num] << 24;
	}

	// Token: 0x06001148 RID: 4424 RVA: 0x0003DF5C File Offset: 0x0003C15C
	private void DecodeInstructions(Module 1)
	{
		byte[] array = this.ilBytes;
		int i = 0;
		this.list = new List<101>();
		while (i < array.Length)
		{
			101 2 = new 101();
			OpCode opCode = OpCodes.Nop;
			ushort num = (ushort)array[i++];
			if (num != 254)
			{
				opCode = 102.singleByteOpCodes[(int)num];
			}
			else
			{
				num = (ushort)array[i++];
				opCode = 102.doubleByteOpCodes[(int)num];
				num |= 65024;
			}
			2.SetOpCode(opCode);
			2.SetOffset(i - 1);
			int num2 = 0;
			switch (opCode.OperandType)
			{
			case OperandType.InlineBrTarget:
				num2 = this.ReadInt32(array, ref i);
				num2 += i;
				2.SetOperand(num2);
				break;
			case OperandType.InlineField:
				num2 = this.ReadInt32(array, ref i);
				if (this.sourceMethod is ConstructorInfo)
				{
					2.SetOperand(1.ResolveField(num2, this.sourceMethod.DeclaringType.GetGenericArguments(), null));
				}
				else
				{
					2.SetOperand(1.ResolveField(num2, this.sourceMethod.DeclaringType.GetGenericArguments(), this.sourceMethod.GetGenericArguments()));
				}
				break;
			case OperandType.InlineI:
				2.SetOperand(this.ReadInt32(array, ref i));
				break;
			case OperandType.InlineI8:
				2.SetOperand(this.ReadUInt64(array, ref i));
				break;
			case OperandType.InlineMethod:
				num2 = this.ReadInt32(array, ref i);
				try
				{
					if (this.sourceMethod is ConstructorInfo)
					{
						2.SetOperand(1.ResolveMethod(num2, this.sourceMethod.DeclaringType.GetGenericArguments(), null));
					}
					else
					{
						2.SetOperand(1.ResolveMethod(num2, this.sourceMethod.DeclaringType.GetGenericArguments(), this.sourceMethod.GetGenericArguments()));
					}
					break;
				}
				catch
				{
					if (this.sourceMethod is ConstructorInfo)
					{
						2.SetOperand(1.ResolveMember(num2, this.sourceMethod.DeclaringType.GetGenericArguments(), null));
					}
					else
					{
						2.SetOperand(1.ResolveMember(num2, this.sourceMethod.DeclaringType.GetGenericArguments(), this.sourceMethod.GetGenericArguments()));
					}
					break;
				}
				goto IL_22C;
			case OperandType.InlineNone:
				2.SetOperand(null);
				break;
			case OperandType.InlinePhi:
			case (OperandType)8:
				goto IL_481;
			case OperandType.InlineR:
				2.SetOperand(this.ReadDouble(array, ref i));
				break;
			case OperandType.InlineSig:
				goto IL_22C;
			case OperandType.InlineString:
				num2 = this.ReadInt32(array, ref i);
				2.SetOperand(1.ResolveString(num2));
				break;
			case OperandType.InlineSwitch:
			{
				int num3 = this.ReadInt32(array, ref i);
				int[] array2 = new int[num3];
				for (int j = 0; j < num3; j++)
				{
					array2[j] = this.ReadInt32(array, ref i);
				}
				int[] array3 = new int[num3];
				for (int k = 0; k < num3; k++)
				{
					array3[k] = i + array2[k];
				}
				break;
			}
			case OperandType.InlineTok:
				num2 = this.ReadInt32(array, ref i);
				try
				{
					if (this.sourceMethod is ConstructorInfo)
					{
						2.SetOperand(1.ResolveType(num2, this.sourceMethod.DeclaringType.GetGenericArguments(), null));
					}
					else
					{
						2.SetOperand(1.ResolveType(num2, this.sourceMethod.DeclaringType.GetGenericArguments(), this.sourceMethod.GetGenericArguments()));
					}
					break;
				}
				catch
				{
					break;
				}
				goto IL_2B7;
			case OperandType.InlineType:
				goto IL_2B7;
			case OperandType.InlineVar:
				2.SetOperand(this.ReadUInt16(array, ref i));
				break;
			case OperandType.ShortInlineBrTarget:
				2.SetOperand((int)this.ReadSByte(array, ref i) + i);
				break;
			case OperandType.ShortInlineI:
				2.SetOperand(this.ReadSByte(array, ref i));
				break;
			case OperandType.ShortInlineR:
				2.SetOperand(this.ReadSingle(array, ref i));
				break;
			case OperandType.ShortInlineVar:
				2.SetOperand(this.ReadByte(array, ref i));
				break;
			default:
				goto IL_481;
			}
			IL_48C:
			this.list.Add(2);
			continue;
			IL_22C:
			num2 = this.ReadInt32(array, ref i);
			2.SetOperand(1.ResolveSignature(num2));
			goto IL_48C;
			IL_2B7:
			num2 = this.ReadInt32(array, ref i);
			if (this.sourceMethod is MethodInfo)
			{
				2.SetOperand(1.ResolveType(num2, this.sourceMethod.DeclaringType.GetGenericArguments(), this.sourceMethod.GetGenericArguments()));
				goto IL_48C;
			}
			if (this.sourceMethod is ConstructorInfo)
			{
				2.SetOperand(1.ResolveType(num2, this.sourceMethod.DeclaringType.GetGenericArguments(), null));
				goto IL_48C;
			}
			2.SetOperand(1.ResolveType(num2));
			goto IL_48C;
			IL_481:
			throw new Exception("Unknown operand type.");
		}
	}

	// Token: 0x06001149 RID: 4425 RVA: 0x0003E428 File Offset: 0x0003C628
	public object ResolveTypeFromAssemblies(Module 1, int 2)
	{
		AssemblyName[] array = 459.Method4364(1.Assembly);
		for (int i = 0; i < array.Length; i++)
		{
			Module[] modules = Assembly.Load(array[i]).GetModules();
			for (int j = 0; j < modules.Length; j++)
			{
				try
				{
					return modules[j].ResolveType(2);
				}
				catch
				{
				}
			}
		}
		return null;
	}

	// Token: 0x0600114A RID: 4426 RVA: 0x0003E490 File Offset: 0x0003C690
	public string GetDisassembly()
	{
		string text = string.Empty;
		if (this.list != null)
		{
			for (int i = 0; i < this.list.Count; i++)
			{
				text = text + this.list[i].FormatInstruction() + "\n";
			}
		}
		return text;
	}

	// Token: 0x040008A4 RID: 2212
	public List<101> list;

	// Token: 0x040008A5 RID: 2213
	protected byte[] ilBytes;

	// Token: 0x040008A6 RID: 2214
	private MethodBase sourceMethod;
}
