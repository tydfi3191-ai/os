using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

// Token: 0x02000A06 RID: 2566
internal sealed class 1604
{
	// Token: 0x0600476F RID: 18287 RVA: 0x001C4610 File Offset: 0x001C2810
	internal static 1604 Default()
	{
		1604.<>c__DisplayClass12_0 CS$<>8__locals1;
		CS$<>8__locals1.settings = new 1604();
		1604.<Default>g__Add|12_0(1604.1606.Grade, 0, ref CS$<>8__locals1);
		1604.<Default>g__Add|12_0(1604.1606.Mods, 0, ref CS$<>8__locals1);
		1604.<Default>g__Add|12_0(1604.1606.Score, 0, ref CS$<>8__locals1);
		1604.<Default>g__Add|12_0(1604.1606.Accuracy, 0, ref CS$<>8__locals1);
		1604.<Default>g__Add|12_0(1604.1606.ScoreDate, 0, ref CS$<>8__locals1);
		1604.<Default>g__Add|12_0(1604.1606.Pp, 1, ref CS$<>8__locals1);
		1604.<Default>g__Add|12_0(1604.1606.Combo, 1, ref CS$<>8__locals1);
		1604.<Default>g__Add|12_0(1604.1606.Hitresults, 1, ref CS$<>8__locals1);
		1604.<Default>g__Add|12_0(1604.1606.Length, 2, ref CS$<>8__locals1);
		1604.<Default>g__Add|12_0(1604.1606.Cs, 2, ref CS$<>8__locals1);
		1604.<Default>g__Add|12_0(1604.1606.Ar, 2, ref CS$<>8__locals1);
		1604.<Default>g__Add|12_0(1604.1606.Od, 2, ref CS$<>8__locals1);
		1604.<Default>g__Add|12_0(1604.1606.Hp, 2, ref CS$<>8__locals1);
		1604.<Default>g__Add|12_0(1604.1606.Bpm, 2, ref CS$<>8__locals1);
		1604.<Default>g__Add|12_0(1604.1606.Mapper, byte.MaxValue, ref CS$<>8__locals1);
		1604.<Default>g__Add|12_0(1604.1606.MapRankedDate, byte.MaxValue, ref CS$<>8__locals1);
		return CS$<>8__locals1.settings;
	}

	// Token: 0x06004770 RID: 18288 RVA: 0x001C46D0 File Offset: 0x001C28D0
	internal 1604 Clone()
	{
		1604 <<EMPTY_NAME>> = (1604)base.MemberwiseClone();
		<<EMPTY_NAME>>.3 = (from 1 in this.3
		select 1.Clone()).ToList<1604.1607>();
		return <<EMPTY_NAME>>;
	}

	// Token: 0x17000301 RID: 769
	// (get) Token: 0x06004771 RID: 18289 RVA: 0x001C471D File Offset: 0x001C291D
	internal static 1604 Current
	{
		get
		{
			if (1604.9 == null)
			{
				1604.9 = (1604.1() ?? 1604.Default());
			}
			return 1604.9;
		}
	}

	// Token: 0x17000302 RID: 770
	// (get) Token: 0x06004772 RID: 18290 RVA: 0x001C473E File Offset: 0x001C293E
	private static string FilePath
	{
		get
		{
			return 268.2("nekiosu.scoreembed.json");
		}
	}

	// Token: 0x06004773 RID: 18291 RVA: 0x001C474C File Offset: 0x001C294C
	internal static void Save(1604 1)
	{
		1604.9 = 4.Clone();
		try
		{
			217 2 = new 217();
			2["values"] = new 109(4.3.Select(delegate(1604.1607 1)
			{
				217 5 = new 217();
				5["kind"] = 1.1.ToString();
				5["y"] = 1.2;
				5["max"] = 1.3;
				5["if_fc"] = 1.4;
				5["max_if_fc"] = 1.5;
				5["max_combo"] = 1.6;
				5["full_hits"] = 1.7;
				5["text"] = 1.8;
				5["with_status"] = 1.9;
				return 5;
			}));
			2["show_artist"] = 4.4;
			2["show_stars_in_title"] = 4.5;
			2["image"] = 4.6.ToString();
			2["pagination"] = 4.7;
			217 3 = 2;
			File.WriteAllText(1604.FilePath, 3.ToString(), new UTF8Encoding(false));
		}
		catch (Exception ex)
		{
			1338.4(ex, "saving the score embed format", 1341.Runtime);
		}
	}

	// Token: 0x06004774 RID: 18292 RVA: 0x001C483C File Offset: 0x001C2A3C
	private static 1604 1()
	{
		1604 result;
		try
		{
			if (!File.Exists(1604.FilePath))
			{
				result = null;
			}
			else
			{
				217 <<EMPTY_NAME>> = 217.Parse(File.ReadAllText(1604.FilePath));
				1604.1605 3;
				1604 2 = new 1604
				{
					4 = ((bool?)<<EMPTY_NAME>>["show_artist"]).GetValueOrDefault(true),
					5 = ((bool?)<<EMPTY_NAME>>["show_stars_in_title"]).GetValueOrDefault(true),
					6 = (Enum.TryParse<1604.1605>((string)<<EMPTY_NAME>>["image"], out 3) ? 3 : 1604.1605.Thumbnail),
					7 = ((bool?)<<EMPTY_NAME>>["pagination"]).GetValueOrDefault(true)
				};
				foreach (226 4 in ((<<EMPTY_NAME>>["values"] as 109) ?? new 109()))
				{
					1604.1606 kind;
					if (Enum.TryParse<1604.1606>((string)4["kind"], out kind) && !2.3.Any((1604.1607 1) => 1.1 == kind))
					{
						2.3.Add(new 1604.1607
						{
							1 = kind,
							2 = ((byte?)4["y"]).GetValueOrDefault(1),
							3 = ((bool?)4["max"]).GetValueOrDefault(true),
							4 = ((bool?)4["if_fc"]).GetValueOrDefault(true),
							5 = ((bool?)4["max_if_fc"]).GetValueOrDefault(true),
							6 = ((bool?)4["max_combo"]).GetValueOrDefault(true),
							7 = ((bool?)4["full_hits"]).GetValueOrDefault(),
							8 = ((bool?)4["text"]).GetValueOrDefault(),
							9 = ((bool?)4["with_status"]).GetValueOrDefault(true)
						});
					}
				}
				bool flag = 2.3.Count > 0 && 2.3[0].2 == 0;
				int num = 1;
				while (num < 2.3.Count && flag)
				{
					flag = (2.3[num - 1].2 <= 2.3[num].2);
					num++;
				}
				result = (flag ? 2 : null);
			}
		}
		catch (Exception ex)
		{
			1338.4(ex, "reading the score embed format", 1341.Runtime);
			result = null;
		}
		return result;
	}

	// Token: 0x06004776 RID: 18294 RVA: 0x001C4B90 File Offset: 0x001C2D90
	[CompilerGenerated]
	internal static void <Default>g__Add|12_0(1604.1606 1, byte 2, ref 1604.<>c__DisplayClass12_0 3)
	{
		3.settings.3.Add(new 1604.1607
		{
			1 = 1,
			2 = 2
		});
	}

	// Token: 0x04003450 RID: 13392
	internal const byte 1 = 0;

	// Token: 0x04003451 RID: 13393
	internal const byte 2 = 255;

	// Token: 0x04003452 RID: 13394
	public List<1604.1607> 3 = new List<1604.1607>();

	// Token: 0x04003453 RID: 13395
	public bool 4 = true;

	// Token: 0x04003454 RID: 13396
	public bool 5 = true;

	// Token: 0x04003455 RID: 13397
	public 1604.1605 6;

	// Token: 0x04003456 RID: 13398
	public bool 7 = true;

	// Token: 0x04003457 RID: 13399
	private const string 8 = "nekiosu.scoreembed.json";

	// Token: 0x04003458 RID: 13400
	private static 1604 9;

	// Token: 0x02000A07 RID: 2567
	internal enum 1606
	{
		// Token: 0x0400345A RID: 13402
		Grade,
		// Token: 0x0400345B RID: 13403
		Mods,
		// Token: 0x0400345C RID: 13404
		Score,
		// Token: 0x0400345D RID: 13405
		Accuracy,
		// Token: 0x0400345E RID: 13406
		ScoreDate,
		// Token: 0x0400345F RID: 13407
		Pp,
		// Token: 0x04003460 RID: 13408
		Combo,
		// Token: 0x04003461 RID: 13409
		Hitresults,
		// Token: 0x04003462 RID: 13410
		Ratio,
		// Token: 0x04003463 RID: 13411
		Stars,
		// Token: 0x04003464 RID: 13412
		Length,
		// Token: 0x04003465 RID: 13413
		Ar,
		// Token: 0x04003466 RID: 13414
		Cs,
		// Token: 0x04003467 RID: 13415
		Hp,
		// Token: 0x04003468 RID: 13416
		Od,
		// Token: 0x04003469 RID: 13417
		Bpm,
		// Token: 0x0400346A RID: 13418
		CountObjects,
		// Token: 0x0400346B RID: 13419
		CountSliders,
		// Token: 0x0400346C RID: 13420
		CountSpinners,
		// Token: 0x0400346D RID: 13421
		MapRankedDate,
		// Token: 0x0400346E RID: 13422
		Mapper
	}

	// Token: 0x02000A08 RID: 2568
	internal enum 1605
	{
		// Token: 0x04003470 RID: 13424
		Thumbnail,
		// Token: 0x04003471 RID: 13425
		Image,
		// Token: 0x04003472 RID: 13426
		Hide,
		// Token: 0x04003473 RID: 13427
		ImageWithStrains
	}

	// Token: 0x02000A09 RID: 2569
	internal sealed class 1607
	{
		// Token: 0x06004777 RID: 18295 RVA: 0x001C4BB5 File Offset: 0x001C2DB5
		public 1604.1607 Clone()
		{
			return (1604.1607)base.MemberwiseClone();
		}

		// Token: 0x04003474 RID: 13428
		public 1604.1606 1;

		// Token: 0x04003475 RID: 13429
		public byte 2;

		// Token: 0x04003476 RID: 13430
		public bool 3 = true;

		// Token: 0x04003477 RID: 13431
		public bool 4 = true;

		// Token: 0x04003478 RID: 13432
		public bool 5 = true;

		// Token: 0x04003479 RID: 13433
		public bool 6 = true;

		// Token: 0x0400347A RID: 13434
		public bool 7;

		// Token: 0x0400347B RID: 13435
		public bool 8;

		// Token: 0x0400347C RID: 13436
		public bool 9 = true;
	}
}
