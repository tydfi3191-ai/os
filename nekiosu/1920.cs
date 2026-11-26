using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x0200085C RID: 2140
public abstract class 1920 : 1891
{
	// Token: 0x06003E0A RID: 15882 RVA: 0x001852EE File Offset: 0x001834EE
	protected 1920(1262 1) : base(1)
	{
	}

	// Token: 0x06003E0B RID: 15883 RVA: 0x001852F8 File Offset: 0x001834F8
	protected void 15(List<1896> 1, 1914[] 2)
	{
		1923 3 = this.12;
		if (3 == null || this.3 == null || this.3.Count == 0)
		{
			return;
		}
		3.1.Clear();
		3.2.Clear();
		3.1.AddRange(from 1 in 4
		select 1.5 * this.4);
		3.2.AddRange(from 1 in 2
		select 1.2().ToArray<double>());
		3.3 = (double)this.3.Min((2034 1) => 1.1);
		3.4 = (double)this.3.Max((2034 1) => 1.2);
		3.5 = this.4;
	}

	// Token: 0x06003E0C RID: 15884 RVA: 0x001853F6 File Offset: 0x001835F6
	protected virtual int GetSectionLength()
	{
		return 400;
	}

	// Token: 0x06003E0D RID: 15885 RVA: 0x00053ADC File Offset: 0x00051CDC
	protected override bool Method1820()
	{
		throw new NotImplementedException();
	}

	// Token: 0x06003E0E RID: 15886 RVA: 0x00185400 File Offset: 0x00183600
	protected 1890 16()
	{
		1914[] array = this.CreateSkills(this.2.22);
		if (!44.ListHasItems<2034>(this.3))
		{
			return this.CreateDifficultyAttributes(array);
		}
		List<1896> list = this.SortObjects(this.CreateDifficultyHitObjects()).ToList<1896>();
		double num = (double)this.GetSectionLength() * this.4;
		Math.Ceiling((double)this.3.First<2034>().1 / num);
		foreach (1896 <<EMPTY_NAME>> in list)
		{
			1914[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i].1(<<EMPTY_NAME>>);
			}
			this.OnObjectProcessed(<<EMPTY_NAME>>, array);
		}
		this.15(list, array);
		return this.CreateDifficultyAttributes(array);
	}

	// Token: 0x06003E0F RID: 15887 RVA: 0x001854E8 File Offset: 0x001836E8
	protected virtual IEnumerable<1896> SortObjects(IEnumerable<1896> 1)
	{
		return 1.OrderBy(new Func<1896, int>(1920.1921.instance.1));
	}

	// Token: 0x06003E10 RID: 15888 RVA: 0x00005ADD File Offset: 0x00003CDD
	protected virtual void OnObjectProcessed(1896 1, 1914[] 2)
	{
	}

	// Token: 0x06003E11 RID: 15889
	protected abstract 1890 CreateDifficultyAttributes(1914[] 1);

	// Token: 0x06003E12 RID: 15890
	protected abstract IEnumerable<1896> CreateDifficultyHitObjects();

	// Token: 0x06003E13 RID: 15891
	protected abstract 1914[] CreateSkills(2023 1);

	// Token: 0x04002D7B RID: 11643
	internal new 1923 12;

	// Token: 0x0200085D RID: 2141
	[Serializable]
	public sealed class 1921
	{
		// Token: 0x06003E15 RID: 15893 RVA: 0x0018550F File Offset: 0x0018370F
		internal int 1(1896 1)
		{
			return 1.2.1;
		}

		// Token: 0x04002D7C RID: 11644
		public static readonly 1920.1921 instance = new 1920.1921();

		// Token: 0x04002D7D RID: 11645
		public static Func<1896, int> func;
	}
}
