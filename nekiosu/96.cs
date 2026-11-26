using System;
using System.Collections.Generic;
using OpenTK.Graphics;
using OpenTK.Graphics.ES20;

// Token: 0x0200037F RID: 895
internal static class 96
{
	// Token: 0x06001A9E RID: 6814 RVA: 0x000641F4 File Offset: 0x000623F4
	internal static object Run()
	{
		1379 <<EMPTY_NAME>> = 1662.11.1();
		IGraphicsContext graphicsContext = <<EMPTY_NAME>>.15();
		if ((<<EMPTY_NAME>>.17() & 4) != null)
		{
			throw new InvalidOperationException("The nonshared desktop-context test requires the desktop GL backend.");
		}
		GraphicsContext graphicsContext2 = null;
		1411<1398> 2 = null;
		1392<1398> 3 = null;
		object result;
		try
		{
			graphicsContext2 = 96.NewContext(<<EMPTY_NAME>>);
			2 = new 1411<1398>(1, 35048);
			3 = new 1392<1398>(3, 4, 35048);
			2.1[0] = 96.Vertex(-1f, -1f);
			2.1[1] = 96.Vertex(1f, -1f);
			2.1[2] = 96.Vertex(1f, 1f);
			2.1[3] = 96.Vertex(-1f, 1f);
			3.1[0] = 96.Vertex(-1f, -1f);
			3.1[1] = 96.Vertex(1f, -1f);
			3.1[2] = 96.Vertex(0f, 1f);
			2.6();
			3.6();
			int bufferContextGeneration = 1379.BufferContextGeneration;
			graphicsContext2.Dispose();
			graphicsContext2 = null;
			graphicsContext2 = 96.NewContext(<<EMPTY_NAME>>);
			int bufferContextGeneration2 = 1379.BufferContextGeneration;
			96.Require(bufferContextGeneration2 > bufferContextGeneration, "Fresh context did not advance buffer generation.");
			int num = 96.Program();
			try
			{
				GL.UseProgram(num);
				GL.Disable(3089);
				GL.Disable(3042);
				GL.Disable(2929);
				GL.Viewport(0, 0, 8, 8);
				object value = 96.DrawAndCheck(2, 4, 6, "quad-after-context-loss");
				object value2 = 96.DrawAndCheck(3, 3, 3, "sequential-after-context-loss");
				GL.BindBuffer(34962, 0);
				GL.BindBuffer(34963, 0);
				1379.31();
				object value3 = 96.DrawAndCheck(2, 4, 6, "quad-after-external-unbind");
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				dictionary["firstGeneration"] = bufferContextGeneration;
				dictionary["secondGeneration"] = bufferContextGeneration2;
				dictionary["quadEvidence"] = value;
				dictionary["triangleEvidence"] = value2;
				dictionary["bindingEvidence"] = value3;
				result = dictionary;
			}
			finally
			{
				GL.DeleteProgram(num);
			}
		}
		finally
		{
			if (2 != null)
			{
				2.Dispose();
			}
			if (3 != null)
			{
				3.Dispose();
			}
			if (graphicsContext2 != null)
			{
				graphicsContext2.Dispose();
			}
			graphicsContext.MakeCurrent(<<EMPTY_NAME>>.18());
			((IGraphicsContextInternal)graphicsContext).LoadAll();
			1379.21(graphicsContext);
			1379.22();
		}
		return result;
	}

	// Token: 0x06001A9F RID: 6815 RVA: 0x000644A0 File Offset: 0x000626A0
	private static GraphicsContext NewContext(1379 1)
	{
		GraphicsContext graphicsContext = new GraphicsContext(1.16(), 1.18(), null, 2, 0, 0);
		GraphicsContext result;
		try
		{
			graphicsContext.MakeCurrent(1.18());
			graphicsContext.LoadAll();
			1379.21(graphicsContext);
			96.Require(GL.GetError() == 0, "GL context initialisation returned an error.");
			result = graphicsContext;
		}
		catch
		{
			graphicsContext.Dispose();
			throw;
		}
		return result;
	}

	// Token: 0x06001AA0 RID: 6816 RVA: 0x0006450C File Offset: 0x0006270C
	private static 1398 Vertex(float 1, float 2)
	{
		return new 1398
		{
			Position = new 208(1, 2),
			Colour = 198.Red
		};
	}

	// Token: 0x06001AA1 RID: 6817 RVA: 0x0006453C File Offset: 0x0006273C
	private static object DrawAndCheck(1509<1398> 1, int 2, int 3, string 4)
	{
		GL.ClearColor(0f, 0f, 0f, 1f);
		GL.Clear(16384);
		1.BindVertexBuffer(true);
		int integer = GL.GetInteger(34964);
		int integer2 = GL.GetInteger(34965);
		int num;
		GL.GetBufferParameter(34962, 34660, ref num);
		int num2;
		GL.GetBufferParameter(34963, 34660, ref num2);
		int num3;
		GL.GetVertexAttrib(0, 34338, ref num3);
		int num4;
		GL.GetVertexAttrib(1, 34338, ref num4);
		96.Require(integer != 0 && integer2 != 0 && GL.IsBuffer(integer) && GL.IsBuffer(integer2), 4 + ": unbound/invalid GPU buffers.");
		96.Require(num == 2 * 1398.Stride && num2 >= 3 * 2, 4 + ": missing buffer data.");
		96.Require(num3 == 1 && num4 == 1, 4 + ": disabled vertex attributes.");
		1.5(0, 2);
		byte[] array = new byte[4];
		GL.ReadPixels<byte>(4, 3, 1, 1, 6408, 5121, array);
		ErrorCode error = GL.GetError();
		96.Require(error == 0, 4 + ": " + error.ToString());
		96.Require(array[0] > 220 && array[1] < 20 && array[2] < 20, 4 + ": retained red vertices were not drawn.");
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary["stage"] = 4;
		dictionary["vertexId"] = integer;
		dictionary["indexId"] = integer2;
		dictionary["vertexBytes"] = num;
		dictionary["indexBytes"] = num2;
		dictionary["positionEnabled"] = num3;
		dictionary["colourEnabled"] = num4;
		dictionary["pixel"] = new object[]
		{
			array[0],
			array[1],
			array[2],
			array[3]
		};
		dictionary["error"] = error.ToString();
		return dictionary;
	}

	// Token: 0x06001AA2 RID: 6818 RVA: 0x0006478C File Offset: 0x0006298C
	private static int Program()
	{
		int num = 96.Shader(35633, "#version 120\nattribute vec2 position; attribute vec4 colour; varying vec4 v_colour; void main(){gl_Position=vec4(position,0.0,1.0);v_colour=colour;}");
		int num2 = 96.Shader(35632, "#version 120\nvarying vec4 v_colour; void main(){gl_FragColor=v_colour;}");
		int num3 = GL.CreateProgram();
		GL.AttachShader(num3, num);
		GL.AttachShader(num3, num2);
		GL.BindAttribLocation(num3, 0, "position");
		GL.BindAttribLocation(num3, 1, "colour");
		GL.LinkProgram(num3);
		int num4;
		GL.GetProgram(num3, 35714, ref num4);
		GL.DeleteShader(num);
		GL.DeleteShader(num2);
		96.Require(num4 == 1, "Regression shader link failed.");
		return num3;
	}

	// Token: 0x06001AA3 RID: 6819 RVA: 0x00064814 File Offset: 0x00062A14
	private static int Shader(ShaderType 1, string 2)
	{
		int num = GL.CreateShader(1);
		GL.ShaderSource(num, 1, new string[]
		{
			2
		}, new int[]
		{
			2.Length
		});
		GL.CompileShader(num);
		int num2;
		GL.GetShader(num, 35713, ref num2);
		96.Require(num2 == 1, "Regression shader compilation failed.");
		return num;
	}

	// Token: 0x06001AA4 RID: 6820 RVA: 0x0006486A File Offset: 0x00062A6A
	private static void Require(bool 1, string 2)
	{
		if (!1)
		{
			throw new InvalidOperationException(2);
		}
	}
}
