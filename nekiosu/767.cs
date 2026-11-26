using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

// Token: 0x020001BF RID: 447
public sealed class 767
{
	// Token: 0x06000E45 RID: 3653 RVA: 0x00030630 File Offset: 0x0002E830
	public 767(529 1)
	{
		this.readOnlyCollection = new ReadOnlyCollection<529>(new 529[]
		{
			1
		});
		this.dictionary = new Dictionary<string, 767>();
		this.dictionary2 = new Dictionary<string, 767>();
		this.list = new List<767>();
		this.text2 = 767.Method12370(this.GetReadOnlyCollection9657_12361());
	}

	// Token: 0x06000E46 RID: 3654 RVA: 0x0003068C File Offset: 0x0002E88C
	private 767(767 1, 529 2)
	{
		this.readOnlyCollection = new ReadOnlyCollection<529>(1.GetReadOnlyCollection9657_12361().Union(new 529[]
		{
			2
		}).ToList<529>());
		this.dictionary = new Dictionary<string, 767>(1.GetDictionary9658_12362());
		this.dictionary2 = new Dictionary<string, 767>(1.GetDictionary9659_12363());
		this.list = new List<767>(1.GetList9660_12364());
		this.SetRecoveredType22679661_12366(1.GetRecoveredType22679661_12365());
		this.SetRecoveredType22679662_12368(1.GetRecoveredType22679662_12367());
		this.text2 = 767.Method12370(this.GetReadOnlyCollection9657_12361());
	}

	// Token: 0x06000E47 RID: 3655 RVA: 0x00030720 File Offset: 0x0002E920
	public string GetText9656_12360()
	{
		return this.text2;
	}

	// Token: 0x06000E48 RID: 3656 RVA: 0x00030728 File Offset: 0x0002E928
	public ReadOnlyCollection<529> GetReadOnlyCollection9657_12361()
	{
		return this.readOnlyCollection;
	}

	// Token: 0x06000E49 RID: 3657 RVA: 0x00030730 File Offset: 0x0002E930
	public Dictionary<string, 767> GetDictionary9658_12362()
	{
		return this.dictionary;
	}

	// Token: 0x06000E4A RID: 3658 RVA: 0x00030738 File Offset: 0x0002E938
	public Dictionary<string, 767> GetDictionary9659_12363()
	{
		return this.dictionary2;
	}

	// Token: 0x06000E4B RID: 3659 RVA: 0x00030740 File Offset: 0x0002E940
	public List<767> GetList9660_12364()
	{
		return this.list;
	}

	// Token: 0x06000E4C RID: 3660 RVA: 0x00030748 File Offset: 0x0002E948
	public 767 GetRecoveredType22679661_12365()
	{
		return this._recoveredType22679661;
	}

	// Token: 0x06000E4D RID: 3661 RVA: 0x00030750 File Offset: 0x0002E950
	public void SetRecoveredType22679661_12366(767 1)
	{
		this._recoveredType22679661 = 1;
	}

	// Token: 0x06000E4E RID: 3662 RVA: 0x00030759 File Offset: 0x0002E959
	public 767 GetRecoveredType22679662_12367()
	{
		return this._recoveredType22679662;
	}

	// Token: 0x06000E4F RID: 3663 RVA: 0x00030761 File Offset: 0x0002E961
	public void SetRecoveredType22679662_12368(767 1)
	{
		this._recoveredType22679662 = 1;
	}

	// Token: 0x06000E50 RID: 3664 RVA: 0x0003076A File Offset: 0x0002E96A
	public 767 Method12369(529 1)
	{
		return new 767(this, 1);
	}

	// Token: 0x06000E51 RID: 3665 RVA: 0x00030773 File Offset: 0x0002E973
	public static string Method12370(IEnumerable<529> 1)
	{
		return string.Join("-", 1.Select(new Func<529, string>(767.768.instance.Method12358)).OrderBy(new Func<string, string>(767.768.instance.Method12359), StringComparer.Ordinal));
	}

	// Token: 0x040006F9 RID: 1785
	private readonly string text2;

	// Token: 0x040006FA RID: 1786
	private readonly ReadOnlyCollection<529> readOnlyCollection;

	// Token: 0x040006FB RID: 1787
	private readonly Dictionary<string, 767> dictionary;

	// Token: 0x040006FC RID: 1788
	private readonly Dictionary<string, 767> dictionary2;

	// Token: 0x040006FD RID: 1789
	private readonly List<767> list;

	// Token: 0x040006FE RID: 1790
	private 767 _recoveredType22679661;

	// Token: 0x040006FF RID: 1791
	private 767 _recoveredType22679662;

	// Token: 0x020001C0 RID: 448
	[Serializable]
	public sealed class 768
	{
		// Token: 0x06000E52 RID: 3666 RVA: 0x000307AF File Offset: 0x0002E9AF
		internal string Method12358(529 1)
		{
			return 1.GetText5125_6438();
		}

		// Token: 0x06000E53 RID: 3667 RVA: 0x00022391 File Offset: 0x00020591
		internal string Method12359(string 1)
		{
			return 1;
		}

		// Token: 0x04000700 RID: 1792
		public static readonly 767.768 instance = new 767.768();

		// Token: 0x04000701 RID: 1793
		public static Func<529, string> func;

		// Token: 0x04000702 RID: 1794
		public static Func<string, string> func2;
	}
}
