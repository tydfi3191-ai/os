using System;
using OpenTK;
using OpenTK.Graphics.ES20;

// Token: 0x02000C6B RID: 3179
public sealed class 1063
{
	// Token: 0x060054D2 RID: 21714 RVA: 0x002100F0 File Offset: 0x0020E2F0
	internal void 1()
	{
		if (this.3 != null)
		{
			ActiveUniformType activeUniformType = this.5;
			if (activeUniformType == 5124)
			{
				GL.Uniform1(this.4, (int)this.3);
				return;
			}
			if (activeUniformType == 5126)
			{
				GL.Uniform1(this.4, (float)this.3);
				return;
			}
			switch (activeUniformType)
			{
			case 35664:
			case 35667:
			case 35671:
				GL.Uniform2(this.4, (Vector2)this.3);
				return;
			case 35665:
			case 35668:
			case 35672:
				GL.Uniform3(this.4, (Vector3)this.3);
				return;
			case 35666:
			case 35669:
			case 35673:
				GL.Uniform4(this.4, (Vector4)this.3);
				return;
			case 35670:
				GL.Uniform1(this.4, ((bool)this.3 > false) ? 1 : 0);
				return;
			case 35674:
			{
				Matrix2 matrix = (Matrix2)this.3;
				GL.UniformMatrix2(this.4, false, ref matrix);
				return;
			}
			case 35675:
			{
				Matrix3 matrix2 = (Matrix3)this.3;
				GL.UniformMatrix3(this.4, false, ref matrix2);
				return;
			}
			case 35676:
			{
				Matrix4 matrix3 = (Matrix4)this.3;
				GL.UniformMatrix4(this.4, false, ref matrix3);
				return;
			}
			case 35677:
				break;
			case 35678:
				GL.Uniform1(this.4, (int)this.3);
				break;
			default:
				return;
			}
		}
	}

	// Token: 0x060054D3 RID: 21715 RVA: 0x0021025C File Offset: 0x0020E45C
	internal static Type 2(string 1)
	{
		uint num = 1197.1(1);
		if (num <= 1848654106U)
		{
			if (num <= 1107778746U)
			{
				if (num <= 796142685U)
				{
					if (num != 786039938U)
					{
						if (num == 796142685U && 1 == "Bool")
						{
							return typeof(bool);
						}
					}
					else if (1 == "SamplerCube")
					{
						goto IL_270;
					}
				}
				else if (num != 1023890651U)
				{
					if (num == 1107778746U && 1 == "BoolVec3")
					{
						goto IL_265;
					}
				}
				else if (1 == "BoolVec4")
				{
					goto IL_27B;
				}
			}
			else if (num <= 1283547685U)
			{
				if (num != 1124556365U)
				{
					if (num == 1283547685U && 1 == "Float")
					{
						return typeof(float);
					}
				}
				else if (1 == "BoolVec2")
				{
					goto IL_286;
				}
			}
			else if (num != 1747988392U)
			{
				if (num == 1848654106U && 1 == "IntVec2")
				{
					goto IL_286;
				}
			}
			else if (1 == "IntVec4")
			{
				goto IL_27B;
			}
		}
		else if (num <= 3116524483U)
		{
			if (num <= 2344526489U)
			{
				if (num != 1865431725U)
				{
					if (num == 2344526489U && 1 == "Sampler2D")
					{
						goto IL_270;
					}
				}
				else if (1 == "IntVec3")
				{
					goto IL_265;
				}
			}
			else if (num != 3057391147U)
			{
				if (num == 3116524483U && 1 == "FloatVec4")
				{
					goto IL_27B;
				}
			}
			else if (1 == "FloatMat4")
			{
				return typeof(Matrix4);
			}
		}
		else if (num <= 3158056861U)
		{
			if (num != 3141279242U)
			{
				if (num == 3158056861U && 1 == "FloatMat2")
				{
					return typeof(Matrix2);
				}
			}
			else if (1 == "FloatMat3")
			{
				return typeof(Matrix3);
			}
		}
		else if (num != 3200412578U)
		{
			if (num != 3217190197U)
			{
				if (num == 4168357374U && 1 == "Int")
				{
					return typeof(int);
				}
			}
			else if (1 == "FloatVec2")
			{
				goto IL_286;
			}
		}
		else if (1 == "FloatVec3")
		{
			goto IL_265;
		}
		throw new NotSupportedException(string.Format("Uniform type {0} is not supported.", 1));
		IL_265:
		return typeof(Vector3);
		IL_270:
		return typeof(int);
		IL_27B:
		return typeof(Vector4);
		IL_286:
		return typeof(Vector2);
	}

	// Token: 0x0400431E RID: 17182
	internal string 1;

	// Token: 0x0400431F RID: 17183
	internal Type 2;

	// Token: 0x04004320 RID: 17184
	internal object 3;

	// Token: 0x04004321 RID: 17185
	internal int 4;

	// Token: 0x04004322 RID: 17186
	internal ActiveUniformType 5;
}
