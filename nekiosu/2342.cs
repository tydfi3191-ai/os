using System;
using System.Collections.Generic;

// Token: 0x020005AF RID: 1455
public sealed class 2342 : 2288
{
	// Token: 0x06002D25 RID: 11557 RVA: 0x000FC1BC File Offset: 0x000FA3BC
	protected override void _000E_2006_2002_2007_2005_2007_2005_2002_2006_2005_2006()
	{
		2342.2343 <<EMPTY_NAME>> = new 2342.2343();
		2039 2 = this.6 as 2039;
		List<2036> list = this.6.CloneHitObjectData();
		int num = (int)Math.Round((double)1272.5().2);
		List<Dictionary<int, int>> list2 = new List<Dictionary<int, int>>(num);
		int[] array = new int[num];
		<<EMPTY_NAME>>.1 = new int[num];
		for (int i = 0; i < num; i++)
		{
			list2.Add(new Dictionary<int, int>());
		}
		for (int j = 0; j < list.Count; j++)
		{
			2342.2344 noteSnapCheck = new 2342.2344();
			noteSnapCheck.3 = <<EMPTY_NAME>>;
			noteSnapCheck.1 = list[j];
			noteSnapCheck.2 = 2.41.49(noteSnapCheck.1.8, false);
			if (2280.7(noteSnapCheck.1.1, false, 1.0))
			{
				int num2;
				if (2280.8(noteSnapCheck.1.1, out num2, false))
				{
					2278 item = new 2338(noteSnapCheck.1, noteSnapCheck.1.1, new 2340(noteSnapCheck.1), (2341)0, string.Format("Rare snap divisor used (1/{0})", num2), 0);
					this.1.Add(item);
				}
				else
				{
					2278 item2 = new 2338(noteSnapCheck.1, noteSnapCheck.1.1, () => 2280.7(noteSnapCheck.1.1, false, 1.0), (2341)1, 1568.1(2679.AICompose_UnsnappedObject), 0);
					this.1.Add(item2);
				}
			}
			if (noteSnapCheck.1.HasObjectType(2047.Hold))
			{
				if (noteSnapCheck.1.2 - noteSnapCheck.1.1 < 10)
				{
					this.1.Add(new 2338(noteSnapCheck.1, noteSnapCheck.1.1, null, (2341)2, 1568.1(2679.AIComposeMania_HoldNoteTooShort), 0));
				}
				if (2280.7(noteSnapCheck.1.2, false, 1.0))
				{
					int num3;
					if (2280.8(noteSnapCheck.1.2, out num3, false))
					{
						2278 item3 = new 2338(noteSnapCheck.1, noteSnapCheck.1.2, new 2340(noteSnapCheck.2), (2341)0, string.Format("Rare snap divisor used (1/{0})", num3), 0);
						this.1.Add(item3);
					}
					else
					{
						2278 item4 = new 2338(noteSnapCheck.1, noteSnapCheck.1.2, new 2340(noteSnapCheck.3), (2341)1, 1568.1(2679.AICompose_UnsnappedObjectEnd), 0);
						this.1.Add(item4);
					}
				}
			}
			if (noteSnapCheck.1.1 != noteSnapCheck.3.1[noteSnapCheck.2] && noteSnapCheck.3.1[noteSnapCheck.2] != 0 && noteSnapCheck.1.1 < noteSnapCheck.3.1[noteSnapCheck.2] + 10)
			{
				this.1.Add(new 2338(noteSnapCheck.1, noteSnapCheck.1.1, new 2340(noteSnapCheck.4), (2341)2, 1568.1(2679.AICompose_ObjectsTooClose), -1));
			}
			int num4 = 1;
			for (int k = 0; k < num; k++)
			{
				if (array[k] >= noteSnapCheck.1.1)
				{
					num4++;
				}
			}
			if (noteSnapCheck.1.1 == noteSnapCheck.1.2)
			{
				array[noteSnapCheck.2] = noteSnapCheck.1.1;
			}
			else
			{
				array[noteSnapCheck.2] = noteSnapCheck.1.2 - 2;
			}
			if (num4 >= 7 && this.5 <= 2327.Insane)
			{
				2338 item5 = new 2338(noteSnapCheck.1, noteSnapCheck.1.1, null, (2341)2, 1568.1(2679.AIComposeMania_TooManyNotes), 0);
				this.1.Add(item5);
			}
			if (list2[noteSnapCheck.2].ContainsKey(noteSnapCheck.1.1) || list2[noteSnapCheck.2].ContainsKey(noteSnapCheck.1.2))
			{
				2338 item6 = new 2338(noteSnapCheck.1, noteSnapCheck.1.1, null, (2341)2, 1568.1(2679.AIComposeMania_StackedObjects), 0);
				this.1.Add(item6);
			}
			else
			{
				bool flag = false;
				foreach (KeyValuePair<int, int> keyValuePair in list2[noteSnapCheck.2])
				{
					if (keyValuePair.Key != keyValuePair.Value)
					{
						if (noteSnapCheck.1.1 <= keyValuePair.Key && noteSnapCheck.1.2 >= keyValuePair.Key)
						{
							flag = true;
							break;
						}
						if (noteSnapCheck.1.1 <= keyValuePair.Value && noteSnapCheck.1.2 >= keyValuePair.Value)
						{
							flag = true;
							break;
						}
						if (noteSnapCheck.1.1 >= keyValuePair.Key && noteSnapCheck.1.2 <= keyValuePair.Value)
						{
							flag = true;
							break;
						}
						if (noteSnapCheck.1.1 < keyValuePair.Key && noteSnapCheck.1.2 > keyValuePair.Value)
						{
							flag = true;
							break;
						}
					}
				}
				if (flag)
				{
					2338 item7 = new 2338(noteSnapCheck.1, noteSnapCheck.1.1, null, (2341)2, 1568.1(2679.AIComposeMania_OverlappingObject), 0);
					this.1.Add(item7);
				}
				else
				{
					list2[noteSnapCheck.2][noteSnapCheck.1.1] = noteSnapCheck.1.2;
					noteSnapCheck.3.1[noteSnapCheck.2] = noteSnapCheck.1.1;
				}
			}
		}
	}

	// Token: 0x020005B0 RID: 1456
	public sealed class 2344
	{
		// Token: 0x06002D27 RID: 11559 RVA: 0x000FC954 File Offset: 0x000FAB54
		internal bool 1()
		{
			int num;
			return !2280.8(this.1.1, out num, false);
		}

		// Token: 0x06002D28 RID: 11560 RVA: 0x000FC978 File Offset: 0x000FAB78
		internal bool 2()
		{
			int num;
			return !2280.8(this.1.2, out num, false);
		}

		// Token: 0x06002D29 RID: 11561 RVA: 0x000FC99B File Offset: 0x000FAB9B
		internal bool 3()
		{
			return 2280.7(this.1.2, false, 1.0);
		}

		// Token: 0x06002D2A RID: 11562 RVA: 0x000FC9B7 File Offset: 0x000FABB7
		internal bool 4()
		{
			return Math.Abs(this.3.1[this.2] - this.1.1) > 10;
		}

		// Token: 0x04002130 RID: 8496
		public 2036 1;

		// Token: 0x04002131 RID: 8497
		public int 2;

		// Token: 0x04002132 RID: 8498
		public 2342.2343 3;
	}

	// Token: 0x020005B1 RID: 1457
	public sealed class 2343
	{
		// Token: 0x04002133 RID: 8499
		public int[] 1;
	}
}
