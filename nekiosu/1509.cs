using System;
using System.Reflection;
using OpenTK.Graphics;
using OpenTK.Graphics.ES20;

// Token: 0x02000AE3 RID: 2787
public abstract class 1509<TItem> : IDisposable where TItem : struct, IEquatable<!0>
{
	// Token: 0x06004DB0 RID: 19888 RVA: 0x001EC6FE File Offset: 0x001EA8FE
	public 1509(int 1, BufferUsageHint 2)
	{
		this.4 = 2;
		1379.21(GraphicsContext.CurrentContext);
		GL.GenBuffers(1, ref this.2);
		this.3 = 1379.BufferContextGeneration;
		this.2(1);
	}

	// Token: 0x06004DB1 RID: 19889 RVA: 0x001EC738 File Offset: 0x001EA938
	~1509()
	{
		this.1(false);
	}

	// Token: 0x06004DB2 RID: 19890 RVA: 0x001EC768 File Offset: 0x001EA968
	public void Dispose()
	{
		this.1(true);
		GC.SuppressFinalize(this);
	}

	// Token: 0x06004DB3 RID: 19891 RVA: 0x001EC778 File Offset: 0x001EA978
	protected void 1(bool 1)
	{
		if (this.7)
		{
			return;
		}
		this.7 = true;
		int buffer = this.2;
		int generation = this.3;
		this.2 = 0;
		if (1662.89 != null)
		{
			1662.89.Schedule(delegate()
			{
				1379.23(buffer, generation);
			}, false);
		}
	}

	// Token: 0x06004DB4 RID: 19892 RVA: 0x001EC7DC File Offset: 0x001EA9DC
	public void 2(int 1)
	{
		if (this.7)
		{
			throw new ObjectDisposedException(base.GetType().Name);
		}
		TItem[] array = this.1;
		this.1 = new TItem[1];
		if (array != null)
		{
			int num = 0;
			while (num < array.Length && num < this.1.Length)
			{
				this.1[num] = array[num];
				num++;
			}
		}
		this.3();
		if (1379.32(34962, this.2))
		{
			1509<TItem>.6();
		}
		GL.BufferData(34962, (IntPtr)(this.1.Length * 1509<TItem>.5), IntPtr.Zero, this.4);
	}

	// Token: 0x06004DB5 RID: 19893 RVA: 0x001EC88E File Offset: 0x001EAA8E
	public virtual void BindVertexBuffer(bool 1)
	{
		if (this.7)
		{
			throw new ObjectDisposedException(base.GetType().Name);
		}
		this.3();
		if (1379.32(34962, this.2))
		{
			1509<TItem>.6();
		}
	}

	// Token: 0x06004DB6 RID: 19894 RVA: 0x001EC8CC File Offset: 0x001EAACC
	private void 3()
	{
		if (this.3 == 1379.BufferContextGeneration)
		{
			return;
		}
		GL.GenBuffers(1, ref this.2);
		this.3 = 1379.BufferContextGeneration;
		1379.32(34962, this.2);
		1509<TItem>.6();
		GL.BufferData<TItem>(34962, (IntPtr)(this.1.Length * 1509<TItem>.5), this.1, this.4);
	}

	// Token: 0x06004DB7 RID: 19895 RVA: 0x00005ADD File Offset: 0x00003CDD
	public virtual void UnbindVertexBuffer()
	{
	}

	// Token: 0x06004DB8 RID: 19896 RVA: 0x00022391 File Offset: 0x00020591
	protected virtual int GetIndexCount(int 1)
	{
		return 1;
	}

	// Token: 0x06004DB9 RID: 19897 RVA: 0x00022391 File Offset: 0x00020591
	protected virtual int GetIndexOffset(int 1)
	{
		return 1;
	}

	// Token: 0x06004DBA RID: 19898
	protected abstract BeginMode GetBeginMode8401_10799();

	// Token: 0x06004DBB RID: 19899 RVA: 0x001EC942 File Offset: 0x001EAB42
	public void 4()
	{
		this.5(0, this.1.Length);
	}

	// Token: 0x06004DBC RID: 19900 RVA: 0x001EC954 File Offset: 0x001EAB54
	public void 5(int 1, int 2)
	{
		if (1 < 0 || 2 < 1 || 2 > this.1.Length)
		{
			throw new ArgumentOutOfRangeException("endIndex");
		}
		this.BindVertexBuffer(true);
		int num = 2 - 1;
		GL.DrawElements(this.GetBeginMode8401_10799(), this.GetIndexCount(num), 5123, this.GetIndexOffset(1) * 2);
		this.UnbindVertexBuffer();
	}

	// Token: 0x06004DBD RID: 19901 RVA: 0x001EC9B0 File Offset: 0x001EABB0
	public void 6()
	{
		this.7(0, this.1.Length);
	}

	// Token: 0x06004DBE RID: 19902 RVA: 0x001EC9C4 File Offset: 0x001EABC4
	public void 7(int 1, int 2)
	{
		if (1 < 0 || 2 < 1 || 2 > this.1.Length)
		{
			throw new ArgumentOutOfRangeException("endIndex");
		}
		if (1 == 2)
		{
			return;
		}
		this.BindVertexBuffer(false);
		int num = 2 - 1;
		GL.BufferSubData<TItem>(34962, (IntPtr)(1 * 1509<TItem>.5), (IntPtr)(num * 1509<TItem>.5), ref this.1[1]);
		this.UnbindVertexBuffer();
	}

	// Token: 0x040039F0 RID: 14832
	internal TItem[] 1;

	// Token: 0x040039F1 RID: 14833
	private int 2;

	// Token: 0x040039F2 RID: 14834
	private int 3;

	// Token: 0x040039F3 RID: 14835
	private BufferUsageHint 4;

	// Token: 0x040039F4 RID: 14836
	private static readonly int 5 = (int)typeof(TItem).GetField("Stride", BindingFlags.Static | BindingFlags.Public).GetValue(null);

	// Token: 0x040039F5 RID: 14837
	private static readonly Action 6 = (Action)Delegate.CreateDelegate(typeof(Action), null, typeof(TItem).GetMethod("Bind", BindingFlags.Static | BindingFlags.Public));

	// Token: 0x040039F6 RID: 14838
	protected bool 7;
}
