using System;
using System.Collections.Generic;

// Token: 0x020002A5 RID: 677
public sealed class 325
{
	// Token: 0x06001482 RID: 5250 RVA: 0x000471A5 File Offset: 0x000453A5
	public 325(345 1)
	{
		this._recoveredType02000278 = 1;
	}

	// Token: 0x06001483 RID: 5251 RVA: 0x000471C0 File Offset: 0x000453C0
	private void Method0780()
	{
		if (this.flag2)
		{
			return;
		}
		object obj = this.value2;
		lock (obj)
		{
			if (!this.flag2)
			{
				this._recoveredType0155Array0275 = new 334[this._recoveredType02000278.GetNumber0631_1097()];
				for (int i = 0; i < this._recoveredType02000278.GetNumber0631_1097(); i++)
				{
					this._recoveredType0155Array0275[i] = new 334();
				}
				this.dictionary2 = new Dictionary<int, 334>();
				this.dictionary3 = new Dictionary<int, WeakReference>();
				this.value3 = new object();
				this.number5 = this._recoveredType02000278.GetNumber0632_1099();
				this.valueArray = new object[this._recoveredType02000278.GetNumber0633_1101()];
				this.flag2 = true;
			}
		}
	}

	// Token: 0x06001484 RID: 5252 RVA: 0x0004729C File Offset: 0x0004549C
	public void Method0781(334 1)
	{
		this.Method0780();
		object obj = this.value2;
		lock (obj)
		{
			334 2;
			if (this.dictionary2.TryGetValue(1.number, out 2) && 2 != null)
			{
				2.dateTime = 1.dateTime;
			}
			else
			{
				int num = 0;
				DateTime dateTime = this._recoveredType0155Array0275[0].dateTime;
				for (int i = 1; i < this._recoveredType02000278.GetNumber0631_1097(); i++)
				{
					if (this._recoveredType0155Array0275[i].dateTime < dateTime)
					{
						num = i;
					}
				}
				2 = this._recoveredType0155Array0275[num];
				if (2.byteArray == null)
				{
					2.byteArray = new byte[this._recoveredType02000278.GetNumber0629_1093()];
				}
				else
				{
					this.dictionary2[2.number] = null;
				}
				this.Method0784(1, 2);
				this.dictionary2[2.number] = 2;
				if (this.dictionary2.Count > this._recoveredType02000278.GetNumber0631_1097() * 2)
				{
					this.Method0782();
				}
			}
		}
	}

	// Token: 0x06001485 RID: 5253 RVA: 0x000473C0 File Offset: 0x000455C0
	private void Method0782()
	{
		Dictionary<int, 334> dictionary = this.dictionary2;
		List<int> list = new List<int>();
		foreach (KeyValuePair<int, 334> keyValuePair in dictionary)
		{
			if (keyValuePair.Value == null)
			{
				list.Add(keyValuePair.Key);
			}
		}
		foreach (int key in list)
		{
			dictionary.Remove(key);
		}
	}

	// Token: 0x06001486 RID: 5254 RVA: 0x0004746C File Offset: 0x0004566C
	public bool Method0783(int 1, ref 334 2)
	{
		if (!this.flag2)
		{
			return false;
		}
		object obj = this.value2;
		lock (obj)
		{
			334 3;
			if (this.dictionary2.TryGetValue(1, out 3) && 3 != null)
			{
				this.Method0784(3, 2);
				return true;
			}
		}
		return false;
	}

	// Token: 0x06001487 RID: 5255 RVA: 0x000474D8 File Offset: 0x000456D8
	private void Method0784(334 1, 334 2)
	{
		1.dateTime = DateTime.UtcNow;
		2.number = 1.number;
		2.number2 = 1.number2;
		2.dateTime = 1.dateTime;
		Buffer.BlockCopy(1.byteArray, 0, 2.byteArray, 0, this._recoveredType02000278.GetNumber0629_1093());
	}

	// Token: 0x06001488 RID: 5256 RVA: 0x00047534 File Offset: 0x00045734
	private void Method0785(object 1)
	{
		for (int i = 0; i < this.valueArray.Length; i++)
		{
			if (this.valueArray[i] == 1)
			{
				return;
			}
		}
		this.valueArray[this.number6] = 1;
		this.number6++;
		if (this.number6 == this.valueArray.Length)
		{
			this.number6 = 0;
		}
	}

	// Token: 0x06001489 RID: 5257 RVA: 0x00047594 File Offset: 0x00045794
	private void Method0786()
	{
		if (this.dictionary3.Count < this.number5)
		{
			return;
		}
		Dictionary<int, WeakReference> dictionary = new Dictionary<int, WeakReference>();
		foreach (KeyValuePair<int, WeakReference> keyValuePair in this.dictionary3)
		{
			if (keyValuePair.Value.IsAlive)
			{
				dictionary.Add(keyValuePair.Key, keyValuePair.Value);
			}
		}
		this.dictionary3 = dictionary;
		this.number5 = Math.Max(dictionary.Count * 2, 10);
	}

	// Token: 0x0600148A RID: 5258 RVA: 0x00047638 File Offset: 0x00045838
	public void Method0787(int 1, byte[] 2, int 3, int 4, bool 5)
	{
		this.Method0780();
		object obj = this.value3;
		lock (obj)
		{
			WeakReference weakReference;
			325.326 6;
			if (this.dictionary3.TryGetValue(1, out weakReference))
			{
				6 = (weakReference.Target as 325.326);
				if (6 != null)
				{
					if (6.byteArray2.Length < 4)
					{
						6.Method0779(2, 3, 4, 5);
						goto IL_74;
					}
					goto IL_74;
				}
			}
			this.Method0786();
			6 = new 325.326(2, 3, 4, 5);
			this.dictionary3[1] = new WeakReference(6);
			IL_74:
			this.Method0785(6);
		}
	}

	// Token: 0x0600148B RID: 5259 RVA: 0x000476DC File Offset: 0x000458DC
	public bool Method0788(int 1, byte[] 2, int 3, int 4, out int 5)
	{
		5 = 0;
		if (!this.flag2)
		{
			return false;
		}
		object obj = this.value3;
		bool result;
		lock (obj)
		{
			WeakReference weakReference;
			if (!this.dictionary3.TryGetValue(1, out weakReference))
			{
				result = false;
			}
			else
			{
				325.326 6 = weakReference.Target as 325.326;
				if (6 == null)
				{
					result = false;
				}
				else
				{
					int num = 6.byteArray2.Length;
					5 = 4;
					if (num < 4)
					{
						if (!6.flag2)
						{
							return false;
						}
						5 = num;
					}
					Buffer.BlockCopy(6.byteArray2, 0, 2, 3, 5);
					this.Method0785(6);
					result = true;
				}
			}
		}
		return result;
	}

	// Token: 0x040009A4 RID: 2468
	private readonly object value2 = new object();

	// Token: 0x040009A5 RID: 2469
	private 334[] _recoveredType0155Array0275;

	// Token: 0x040009A6 RID: 2470
	private Dictionary<int, 334> dictionary2;

	// Token: 0x040009A7 RID: 2471
	private volatile bool flag2;

	// Token: 0x040009A8 RID: 2472
	private 345 _recoveredType02000278;

	// Token: 0x040009A9 RID: 2473
	private Dictionary<int, WeakReference> dictionary3;

	// Token: 0x040009AA RID: 2474
	private object value3;

	// Token: 0x040009AB RID: 2475
	private int number5;

	// Token: 0x040009AC RID: 2476
	private object[] valueArray;

	// Token: 0x040009AD RID: 2477
	private int number6;

	// Token: 0x020002A6 RID: 678
	public sealed class 326
	{
		// Token: 0x0600148C RID: 5260 RVA: 0x000055AC File Offset: 0x000037AC
		public 326()
		{
		}

		// Token: 0x0600148D RID: 5261 RVA: 0x00047794 File Offset: 0x00045994
		public 326(byte[] 1, int 2, int 3, bool 4)
		{
			this.Method0779(1, 2, 3, 4);
		}

		// Token: 0x0600148E RID: 5262 RVA: 0x000477A7 File Offset: 0x000459A7
		public void Method0779(byte[] 1, int 2, int 3, bool 4)
		{
			this.byteArray2 = new byte[3];
			Buffer.BlockCopy(1, 2, this.byteArray2, 0, 3);
			this.flag2 = 4;
		}

		// Token: 0x040009AE RID: 2478
		public byte[] byteArray2;

		// Token: 0x040009AF RID: 2479
		public bool flag2;
	}
}
