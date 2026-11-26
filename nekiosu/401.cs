using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x0200011F RID: 287
public sealed class 401
{
	// Token: 0x06000A5C RID: 2652 RVA: 0x00027A5A File Offset: 0x00025C5A
	public 78 Method2538(529 1)
	{
		this._recoveredType10661992 = new 517();
		this._recoveredType22671994 = this.Method2539(null, 1);
		this.dictionary = new Dictionary<767, 78>();
		return this.Method2545(this._recoveredType22671994);
	}

	// Token: 0x06000A5D RID: 2653 RVA: 0x00027A8C File Offset: 0x00025C8C
	public 767 Method2539(767 1, 529 2)
	{
		string key;
		if (1 != null)
		{
			if (1.GetReadOnlyCollection9657_12361().Contains(2))
			{
				return 1;
			}
			key = 767.Method12370(1.GetReadOnlyCollection9657_12361().Union(new 529[]
			{
				2
			}));
		}
		else
		{
			key = 767.Method12370(new 529[]
			{
				2
			});
		}
		if (this._recoveredType10661992.Contains(key))
		{
			return this._recoveredType10661992[key];
		}
		767 3 = (1 != null) ? 1.Method12369(2) : new 767(2);
		this._recoveredType10661992.Add(3);
		this.Method2540(2.GetIDictionary5114_6416(), 3.GetDictionary9658_12362());
		this.Method2540(2.GetIDictionary5116_6420(), 3.GetDictionary9659_12363());
		if (2.GetIList5109_6406() != null)
		{
			for (int i = 0; i < 2.GetIList5109_6406().Count; i++)
			{
				this.Method2542(3, i, 2.GetIList5109_6406()[i]);
			}
		}
		if (2.GetRecoveredType11435111_6410() != null)
		{
			this.Method2544(3, 2.GetRecoveredType11435111_6410());
		}
		if (2.GetRecoveredType11435115_6418() != null)
		{
			this.Method2543(3, 2.GetRecoveredType11435115_6418());
		}
		if (2.GetIList5122_6432() != null)
		{
			foreach (529 4 in 2.GetIList5122_6432())
			{
				3 = this.Method2539(3, 4);
			}
		}
		return 3;
	}

	// Token: 0x06000A5E RID: 2654 RVA: 0x00027BE0 File Offset: 0x00025DE0
	public void Method2540(IDictionary<string, 529> 1, IDictionary<string, 767> 2)
	{
		if (1 == null)
		{
			return;
		}
		foreach (KeyValuePair<string, 529> keyValuePair in 1)
		{
			this.Method2541(2, keyValuePair.Key, keyValuePair.Value);
		}
	}

	// Token: 0x06000A5F RID: 2655 RVA: 0x00027C3C File Offset: 0x00025E3C
	public void Method2541(IDictionary<string, 767> 1, string 2, 529 3)
	{
		767 4;
		1.TryGetValue(2, out 4);
		1[2] = this.Method2539(4, 3);
	}

	// Token: 0x06000A60 RID: 2656 RVA: 0x00027C64 File Offset: 0x00025E64
	public void Method2542(767 1, int 2, 529 3)
	{
		767 4 = (1.GetList9660_12364().Count > 2) ? 1.GetList9660_12364()[2] : null;
		767 5 = this.Method2539(4, 3);
		if (1.GetList9660_12364().Count <= 2)
		{
			1.GetList9660_12364().Add(5);
			return;
		}
		1.GetList9660_12364()[2] = 5;
	}

	// Token: 0x06000A61 RID: 2657 RVA: 0x00027CC0 File Offset: 0x00025EC0
	public void Method2543(767 1, 529 2)
	{
		1.SetRecoveredType22679661_12366(this.Method2539(1.GetRecoveredType22679661_12365(), 2));
	}

	// Token: 0x06000A62 RID: 2658 RVA: 0x00027CD5 File Offset: 0x00025ED5
	public void Method2544(767 1, 529 2)
	{
		1.SetRecoveredType22679662_12368(this.Method2539(1.GetRecoveredType22679662_12367(), 2));
	}

	// Token: 0x06000A63 RID: 2659 RVA: 0x00027CEC File Offset: 0x00025EEC
	private 78 Method2545(767 1)
	{
		78 2;
		if (this.dictionary.TryGetValue(1, out 2))
		{
			return 2;
		}
		2 = 78.Create(1.GetReadOnlyCollection9657_12361());
		this.dictionary[1] = 2;
		foreach (KeyValuePair<string, 767> keyValuePair in 1.GetDictionary9658_12362())
		{
			if (2.GetProperties() == null)
			{
				2.SetProperties(new Dictionary<string, 78>());
			}
			2.GetProperties()[keyValuePair.Key] = this.Method2545(keyValuePair.Value);
		}
		foreach (KeyValuePair<string, 767> keyValuePair2 in 1.GetDictionary9659_12363())
		{
			if (2.GetPatternProperties() == null)
			{
				2.SetPatternProperties(new Dictionary<string, 78>());
			}
			2.GetPatternProperties()[keyValuePair2.Key] = this.Method2545(keyValuePair2.Value);
		}
		foreach (767 3 in 1.GetList9660_12364())
		{
			if (2.GetItems() == null)
			{
				2.SetItems(new List<78>());
			}
			2.GetItems().Add(this.Method2545(3));
		}
		if (1.GetRecoveredType22679661_12365() != null)
		{
			2.SetAdditionalProperties(this.Method2545(1.GetRecoveredType22679661_12365()));
		}
		if (1.GetRecoveredType22679662_12367() != null)
		{
			2.SetAdditionalItems(this.Method2545(1.GetRecoveredType22679662_12367()));
		}
		return 2;
	}

	// Token: 0x0400051E RID: 1310
	private 517 _recoveredType10661992 = new 517();

	// Token: 0x0400051F RID: 1311
	private Dictionary<767, 78> dictionary = new Dictionary<767, 78>();

	// Token: 0x04000520 RID: 1312
	private 767 _recoveredType22671994;
}
