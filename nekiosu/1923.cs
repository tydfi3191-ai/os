using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x0200085F RID: 2143
internal sealed class 1923
{
	// Token: 0x06003E1D RID: 15901 RVA: 0x00185544 File Offset: 0x00183744
	internal static double[] 1(1890 1, int 2)
	{
		double[] array = new double[2];
		2092 3 = 5 as 2092;
		if (3 == null)
		{
			2170 4 = 5 as 2170;
			if (4 == null)
			{
				for (int i = 0; i < 2; i++)
				{
					array[i] = 1.0;
				}
			}
			else
			{
				1923.Set(array, 0, 4.4);
				1923.Set(array, 1, 4.5);
				1923.Set(array, 2, 4.6);
				1923.Set(array, 3, 4.7);
			}
		}
		else
		{
			1923.Set(array, 0, 3.5);
			1923.Set(array, 1, 3.7);
			if (3.9 != null)
			{
				1923.Set(array, 3, 3.9.Value);
			}
		}
		if (array.All((double 1) => 1 <= 0.0))
		{
			for (int j = 0; j < 2; j++)
			{
				array[j] = 1.0;
			}
		}
		return array;
	}

	// Token: 0x06003E1E RID: 15902 RVA: 0x0018563C File Offset: 0x0018383C
	private static void Set(double[] 1, int 2, double 3)
	{
		if (2 < 1.Length && !double.IsNaN(3) && !double.IsInfinity(3))
		{
			1[2] = Math.Max(0.0, 3);
		}
	}

	// Token: 0x06003E1F RID: 15903 RVA: 0x00185668 File Offset: 0x00183868
	internal 1922 2(double[] 1)
	{
		if (this.1.Count == 0 || this.2.Count == 0)
		{
			return null;
		}
		double num = 400.0 * this.5;
		double num2 = this.1[0];
		int num3 = Math.Max(1, (int)((this.1[this.1.Count - 1] - num2) / num) + 1);
		double[] array = new double[num3];
		double[][] array2 = new double[this.2.Count][];
		for (int i = 0; i < this.2.Count; i++)
		{
			array2[i] = new double[num3];
			double[] array3 = this.2[i];
			int num4 = 0;
			while (num4 < array3.Length && num4 < this.1.Count)
			{
				int num5 = Math.Min(num3 - 1, Math.Max(0, (int)((this.1[num4] - num2) / num)));
				if (array3[num4] > array2[i][num5] && !double.IsNaN(array3[num4]))
				{
					array2[i][num5] = array3[num4];
				}
				num4++;
			}
		}
		for (int j = 0; j < num3; j++)
		{
			double num6 = 0.0;
			for (int k = 0; k < this.2.Count; k++)
			{
				double num7 = array2[k].Max();
				double num8 = (k < 1.Length) ? 1[k] : 0.0;
				if (num7 > 0.0 && num8 > 0.0)
				{
					num6 += Math.Pow(num8 * Math.Sqrt(array2[k][j] / num7), 1.1);
				}
			}
			array[j] = Math.Pow(num6, 0.9090909090909091);
		}
		return new 1922
		{
			1 = array,
			2 = num2,
			3 = this.1[this.1.Count - 1],
			4 = Math.Min(this.3, num2),
			5 = Math.Max(this.4, this.1[this.1.Count - 1])
		};
	}

	// Token: 0x04002D82 RID: 11650
	public readonly List<double> 1 = new List<double>();

	// Token: 0x04002D83 RID: 11651
	public readonly List<double[]> 2 = new List<double[]>();

	// Token: 0x04002D84 RID: 11652
	public double 3;

	// Token: 0x04002D85 RID: 11653
	public double 4;

	// Token: 0x04002D86 RID: 11654
	public double 5 = 1.0;
}
