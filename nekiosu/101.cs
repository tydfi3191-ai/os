using System;
using System.Reflection;
using System.Reflection.Emit;

// Token: 0x02000088 RID: 136
public sealed class 101
{
	// Token: 0x060002D2 RID: 722 RVA: 0x00008EF9 File Offset: 0x000070F9
	public OpCode GetOpCode()
	{
		return this.instructionOpCode;
	}

	// Token: 0x060002D3 RID: 723 RVA: 0x00008F01 File Offset: 0x00007101
	public void SetOpCode(OpCode 1)
	{
		this.instructionOpCode = 1;
	}

	// Token: 0x060002D4 RID: 724 RVA: 0x00008F0A File Offset: 0x0000710A
	public object GetOperand()
	{
		return this.operand;
	}

	// Token: 0x060002D5 RID: 725 RVA: 0x00008F12 File Offset: 0x00007112
	public void SetOperand(object 1)
	{
		this.operand = 1;
	}

	// Token: 0x060002D6 RID: 726 RVA: 0x00008F1B File Offset: 0x0000711B
	public byte[] GetRawBytes()
	{
		return this.rawBytes;
	}

	// Token: 0x060002D7 RID: 727 RVA: 0x00008F23 File Offset: 0x00007123
	public void SetRawBytes(byte[] 1)
	{
		this.rawBytes = 1;
	}

	// Token: 0x060002D8 RID: 728 RVA: 0x00008F2C File Offset: 0x0000712C
	public int GetOffset()
	{
		return this.offset;
	}

	// Token: 0x060002D9 RID: 729 RVA: 0x00008F34 File Offset: 0x00007134
	public void SetOffset(int 1)
	{
		this.offset = 1;
	}

	// Token: 0x060002DA RID: 730 RVA: 0x00008F40 File Offset: 0x00007140
	public string FormatInstruction()
	{
		string text = string.Empty;
		string str = text;
		string str2 = this.FormatOffset((long)this.offset);
		string str3 = " : ";
		OpCode opCode = this.instructionOpCode;
		text = str + str2 + str3 + opCode.ToString();
		if (this.operand != null)
		{
			switch (this.instructionOpCode.OperandType)
			{
			case OperandType.InlineBrTarget:
			case OperandType.ShortInlineBrTarget:
				break;
			case OperandType.InlineField:
			{
				FieldInfo fieldInfo = (FieldInfo)this.operand;
				return string.Concat(new string[]
				{
					text,
					" ",
					102.NormalizeTypeName(fieldInfo.FieldType.ToString()),
					" ",
					102.NormalizeTypeName(fieldInfo.ReflectedType.ToString()),
					"::",
					fieldInfo.Name
				});
			}
			case OperandType.InlineI:
			case OperandType.InlineI8:
			case OperandType.InlineR:
			case OperandType.ShortInlineI:
			case OperandType.ShortInlineR:
				return text + this.operand.ToString();
			case OperandType.InlineMethod:
				try
				{
					MethodInfo methodInfo = (MethodInfo)this.operand;
					text += " ";
					if (!methodInfo.IsStatic)
					{
						text += "instance ";
					}
					return string.Concat(new string[]
					{
						text,
						102.NormalizeTypeName(methodInfo.ReturnType.ToString()),
						" ",
						102.NormalizeTypeName(methodInfo.ReflectedType.ToString()),
						"::",
						methodInfo.Name,
						"()"
					});
				}
				catch
				{
					try
					{
						ConstructorInfo constructorInfo = (ConstructorInfo)this.operand;
						text += " ";
						if (!constructorInfo.IsStatic)
						{
							text += "instance ";
						}
						text = string.Concat(new string[]
						{
							text,
							"void ",
							102.NormalizeTypeName(constructorInfo.ReflectedType.ToString()),
							"::",
							constructorInfo.Name,
							"()"
						});
					}
					catch
					{
					}
					return text;
				}
				break;
			case OperandType.InlineNone:
			case OperandType.InlinePhi:
			case (OperandType)8:
			case OperandType.InlineSig:
			case OperandType.InlineSwitch:
			case OperandType.InlineVar:
				goto IL_301;
			case OperandType.InlineString:
				return (!(this.operand.ToString() == "\r\n")) ? (text + " \"" + this.operand.ToString() + "\"") : (text + " \"\\r\\n\"");
			case OperandType.InlineTok:
				return (!(this.operand is Type)) ? (text + "not supported") : (text + ((Type)this.operand).FullName);
			case OperandType.InlineType:
				return text + " " + 102.NormalizeTypeName(this.operand.ToString());
			case OperandType.ShortInlineVar:
				return text + this.operand.ToString();
			default:
				goto IL_301;
			}
			return text + " " + this.FormatOffset((long)((int)this.operand));
			IL_301:
			text += "not supported";
		}
		return text;
	}

	// Token: 0x060002DB RID: 731 RVA: 0x00009278 File Offset: 0x00007478
	private string FormatOffset(long 1)
	{
		string text = 1.ToString();
		int num = 0;
		while (text.Length < 4)
		{
			text = "0" + text;
			num++;
		}
		return text;
	}

	// Token: 0x0400033B RID: 827
	private OpCode instructionOpCode;

	// Token: 0x0400033C RID: 828
	private object operand;

	// Token: 0x0400033D RID: 829
	private byte[] rawBytes;

	// Token: 0x0400033E RID: 830
	private int offset;
}
