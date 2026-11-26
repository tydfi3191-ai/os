using System;
using System.Linq;

// Token: 0x02000847 RID: 2119
public sealed class 1888 : 1898
{
	// Token: 0x06003D89 RID: 15753 RVA: 0x00183C77 File Offset: 0x00181E77
	public 1888(params 2023[] 1)
	{
		this.1 = 1.Select(new Func<2023, 1898>(1888.1889.instance.1)).ToArray<1898>();
	}

	// Token: 0x06003D8A RID: 15754 RVA: 0x00183CA0 File Offset: 0x00181EA0
	public 1888(params 1898[] 1)
	{
		this.1 = 1;
	}

	// Token: 0x06003D8B RID: 15755 RVA: 0x00183CAF File Offset: 0x00181EAF
	public 1898[] 1()
	{
		return this.1;
	}

	// Token: 0x06003D8C RID: 15756 RVA: 0x00183CB7 File Offset: 0x00181EB7
	public override int GetHashCode()
	{
		return new 1924<Type, 1898[]>(base.GetType(), this.1()).GetHashCode();
	}

	// Token: 0x04002D36 RID: 11574
	private readonly 1898[] 1;

	// Token: 0x02000848 RID: 2120
	[Serializable]
	public sealed class 1889
	{
		// Token: 0x06003D8D RID: 15757 RVA: 0x00183CCF File Offset: 0x00181ECF
		internal 1898 1(2023 1)
		{
			return new 1913(1);
		}

		// Token: 0x04002D37 RID: 11575
		public static readonly 1888.1889 instance = new 1888.1889();

		// Token: 0x04002D38 RID: 11576
		public static Func<2023, 1898> func;
	}
}
