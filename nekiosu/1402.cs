using System;
using System.Runtime.InteropServices;
using OpenTK.Graphics.ES20;

// Token: 0x02000AA3 RID: 2723
public sealed class 1402 : 1454
{
	// Token: 0x06004B87 RID: 19335 RVA: 0x001DE987 File Offset: 0x001DCB87
	public 1402(int 1, int 2)
	{
		this.SetWidth_10759(1);
		this.SetHeight_10757(2);
	}

	// Token: 0x06004B88 RID: 19336 RVA: 0x001DE99D File Offset: 0x001DCB9D
	public override int GetHeight_10756()
	{
		return this.9;
	}

	// Token: 0x06004B89 RID: 19337 RVA: 0x001DE9A5 File Offset: 0x001DCBA5
	public override void SetHeight_10757(int 1)
	{
		this.9 = 1;
	}

	// Token: 0x06004B8A RID: 19338 RVA: 0x001DE9AE File Offset: 0x001DCBAE
	public override int GetWidth_10758()
	{
		return this.10;
	}

	// Token: 0x06004B8B RID: 19339 RVA: 0x001DE9B6 File Offset: 0x001DCBB6
	public override void SetWidth_10759(int 1)
	{
		this.10 = 1;
	}

	// Token: 0x06004B8C RID: 19340 RVA: 0x001DE9BF File Offset: 0x001DCBBF
	public override bool HasContent()
	{
		return this.14 > 0 || this.18 != null;
	}

	// Token: 0x06004B8D RID: 19341 RVA: 0x001DE9D5 File Offset: 0x001DCBD5
	public override int GetTextureId()
	{
		if (this.18 != null)
		{
			this.FlushPendingUpload();
		}
		return this.14;
	}

	// Token: 0x06004B8E RID: 19342 RVA: 0x001DE9EC File Offset: 0x001DCBEC
	public static void 8()
	{
		1402.19 = new 1375<1394>(1, 100);
	}

	// Token: 0x06004B8F RID: 19343 RVA: 0x001DE9FB File Offset: 0x001DCBFB
	protected override void DisposeCore(bool 1)
	{
		base.DisposeCore(1);
		this.9();
	}

	// Token: 0x06004B90 RID: 19344 RVA: 0x001DEA0C File Offset: 0x001DCC0C
	private void 9()
	{
		1402.1403 textureDeleter = new 1402.1403();
		lock (this)
		{
			if (this.18 != null)
			{
				1454.7(this.18);
			}
			this.18 = null;
		}
		textureDeleter.1 = this.14;
		1479 <<EMPTY_NAME>> = 1662.13();
		if (textureDeleter.1 <= 0 || <<EMPTY_NAME>> == null || <<EMPTY_NAME>>.IsDisposed)
		{
			return;
		}
		1662.89.Schedule(delegate()
		{
			try
			{
				1662.43.6(1056.TextureUnload);
				GL.DeleteTextures(1, new int[]
				{
					textureDeleter.1
				});
			}
			catch
			{
			}
		}, true);
		this.14 = 0;
	}

	// Token: 0x06004B91 RID: 19345 RVA: 0x001DEABC File Offset: 0x001DCCBC
	private static void 10(ref 208 1, float 2, float 3)
	{
		float x = 1.X;
		1.X = 1.X * 3 - 1.Y * 2;
		1.Y = x * 2 + 1.Y * 3;
	}

	// Token: 0x06004B92 RID: 19346 RVA: 0x001DEAFC File Offset: 0x001DCCFC
	public override void Draw(208 1, 208 2, 198 3, 208 4, float 5, 207? 6, 1508<1394> 7 = null)
	{
		if (this.TryBind())
		{
			207 8 = (6 == null) ? new 207(0, 0, this.GetWidth_10758(), this.GetHeight_10756()) : 6.Value;
			float num = (float)8.Height * Math.Abs(4.Y);
			float num2 = (float)8.Width * Math.Abs(4.X);
			208 9 = new 208(2.X * num2 / (float)8.Width, 2.Y * num / (float)8.Height);
			208 10 = new 208(0f, 0f);
			208 11 = new 208(num2, 0f);
			208 12 = new 208(0f, num);
			208 13 = new 208(num2, num);
			10 -= 9;
			11 -= 9;
			12 -= 9;
			13 -= 9;
			if (5 != 0f)
			{
				float 14 = (float)Math.Sin((double)5);
				float 15 = (float)Math.Cos((double)5);
				1402.10(ref 10, 14, 15);
				1402.10(ref 11, 14, 15);
				1402.10(ref 12, 14, 15);
				1402.10(ref 13, 14, 15);
			}
			10 += 1;
			11 += 1;
			12 += 1;
			13 += 1;
			1058 16 = new 1058((float)8.X / (float)this.8, (float)8.Y / (float)this.7, (float)8.Width / (float)this.8, (float)8.Height / (float)this.7);
			if (4.Y < 0f)
			{
				16.Y = 16.5();
				16.Height = 0f - 16.Height;
			}
			if (4.X < 0f)
			{
				16.X = 16.4();
				16.Width = 0f - 16.Width;
			}
			if (7 == null)
			{
				7 = 1402.19;
			}
			7.5(new 1394
			{
				Position = 12,
				TexturePosition = new 208(16.2(), 16.5()),
				Colour = 3
			});
			7.5(new 1394
			{
				Position = 13,
				TexturePosition = new 208(16.4(), 16.5()),
				Colour = 3
			});
			7.5(new 1394
			{
				Position = 11,
				TexturePosition = new 208(16.4(), 16.3()),
				Colour = 3
			});
			7.5(new 1394
			{
				Position = 10,
				TexturePosition = new 208(16.2(), 16.3()),
				Colour = 3
			});
		}
	}

	// Token: 0x06004B93 RID: 19347 RVA: 0x001DEDF8 File Offset: 0x001DCFF8
	private void 11()
	{
		this.13 = this.2;
		GL.TexParameter(3553, 10242, this.13);
		GL.TexParameter(3553, 10243, this.13);
	}

	// Token: 0x06004B94 RID: 19348 RVA: 0x001DEE30 File Offset: 0x001DD030
	public void 12(byte[] 1, 207 2, int 3, PixelFormat 4)
	{
		lock (this)
		{
			if (this.18 != null)
			{
				1454.7(this.18);
			}
			this.16 = 4;
			this.15 = 3;
			this.17 = 2;
			this.18 = 1;
			this.1 = false;
			base.2();
		}
	}

	// Token: 0x06004B95 RID: 19349 RVA: 0x001DEEA4 File Offset: 0x001DD0A4
	public override void UploadPixels(byte[] 1, int 2 = 0, PixelFormat 3 = 6408)
	{
		this.12(1, new 207(0, 0, this.10, this.9), 2, 3);
	}

	// Token: 0x06004B96 RID: 19350 RVA: 0x001DEEC2 File Offset: 0x001DD0C2
	public override bool TryBind()
	{
		this.FlushPendingUpload();
		if (this.14 <= 0)
		{
			return false;
		}
		if (this.1)
		{
			return false;
		}
		1379.33(this.14);
		if (this.13 != this.2)
		{
			this.11();
		}
		return true;
	}

	// Token: 0x06004B97 RID: 19351 RVA: 0x001DEF00 File Offset: 0x001DD100
	public override bool FlushPendingUpload()
	{
		if (1304.222)
		{
			return false;
		}
		if (this.3)
		{
			return false;
		}
		bool result;
		lock (this)
		{
			if (this.18 == null)
			{
				result = false;
			}
			else
			{
				GCHandle? gchandle;
				IntPtr intPtr;
				if (this.18.Length == 0)
				{
					gchandle = null;
					intPtr = IntPtr.Zero;
				}
				else
				{
					gchandle = new GCHandle?(GCHandle.Alloc(this.18, GCHandleType.Pinned));
					intPtr = gchandle.Value.AddrOfPinnedObject();
				}
				try
				{
					if (this.15 > 0)
					{
						result = false;
					}
					else
					{
						if (this.14 <= 0 || this.11 < this.10 || this.12 < this.9)
						{
							1662.43.6(1056.TextureGen);
							this.11 = this.10;
							this.12 = this.9;
							this.8 = 1454.1(this.10);
							this.7 = 1454.1(this.9);
							if (this.14 <= 0)
							{
								int[] array = new int[1];
								GL.GenTextures(1, array);
								this.14 = array[0];
								1379.33(this.14);
								GL.TexParameter(3553, 10241, 9729);
								GL.TexParameter(3553, 10240, 9729);
								this.11();
							}
							else
							{
								1379.33(this.14);
							}
							if ((this.8 == this.17.Width && this.7 == this.17.Height) || intPtr == IntPtr.Zero)
							{
								GL.TexImage2D(3553, this.15, 6408, this.8, this.7, 0, this.16, 5121, intPtr);
							}
							else
							{
								if (1402.20.Length < this.8 * this.7 * 4)
								{
									1402.20 = new byte[this.8 * this.7 * 4];
								}
								GCHandle gchandle2 = GCHandle.Alloc(1402.20, GCHandleType.Pinned);
								GL.TexImage2D(3553, this.15, 6408, this.8, this.7, 0, this.16, 5121, gchandle2.AddrOfPinnedObject());
								gchandle2.Free();
								GL.TexSubImage2D(3553, this.15, this.17.X, this.17.Y, this.17.Width, this.17.Height, this.16, 5121, intPtr);
							}
						}
						else if (intPtr != IntPtr.Zero)
						{
							1662.43.6(1056.TextureUpload);
							1379.33(this.14);
							GL.TexSubImage2D(3553, this.15, this.17.X, this.17.Y, this.17.Width, this.17.Height, this.16, 5121, intPtr);
						}
						result = true;
					}
				}
				finally
				{
					if (gchandle != null)
					{
						gchandle.Value.Free();
					}
					if (this.18 != null)
					{
						1454.7(this.18);
					}
					this.18 = null;
				}
			}
		}
		return result;
	}

	// Token: 0x0400384B RID: 14411
	private new int 7;

	// Token: 0x0400384C RID: 14412
	private int 8;

	// Token: 0x0400384D RID: 14413
	private int 9;

	// Token: 0x0400384E RID: 14414
	private int 10;

	// Token: 0x0400384F RID: 14415
	private int 11;

	// Token: 0x04003850 RID: 14416
	private int 12;

	// Token: 0x04003851 RID: 14417
	private TextureWrapMode 13;

	// Token: 0x04003852 RID: 14418
	private int 14;

	// Token: 0x04003853 RID: 14419
	private int 15;

	// Token: 0x04003854 RID: 14420
	private PixelFormat 16;

	// Token: 0x04003855 RID: 14421
	private 207 17;

	// Token: 0x04003856 RID: 14422
	private byte[] 18;

	// Token: 0x04003857 RID: 14423
	private static 1508<1394> 19;

	// Token: 0x04003858 RID: 14424
	private static byte[] 20 = new byte[0];

	// Token: 0x02000AA4 RID: 2724
	public sealed class 1403
	{
		// Token: 0x04003859 RID: 14425
		public int 1;
	}
}
