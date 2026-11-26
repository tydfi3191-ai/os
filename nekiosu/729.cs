using System;
using System.Collections.Generic;

// Token: 0x0200002A RID: 42
public sealed class 729<TItem, TItem2>
{
	// Token: 0x17000011 RID: 17
	public TItem2 this[TItem 1]
	{
		get
		{
			object value = this._value9006;
			TItem2 result;
			lock (value)
			{
				result = this._dictionary9005[1];
			}
			return result;
		}
		set
		{
			object value2 = this._value9006;
			lock (value2)
			{
				this._dictionary9005[1] = value;
			}
		}
	}

	// Token: 0x060000EF RID: 239 RVA: 0x00005F08 File Offset: 0x00004108
	public 729()
	{
		this._value9006 = new object();
		this._dictionary9005 = new Dictionary<TItem, TItem2>();
	}

	// Token: 0x060000F0 RID: 240 RVA: 0x00005F26 File Offset: 0x00004126
	public int Method11338()
	{
		return this._dictionary9005.Count;
	}

	// Token: 0x060000F1 RID: 241 RVA: 0x00005F34 File Offset: 0x00004134
	public bool Method11339(TItem 1)
	{
		object value = this._value9006;
		bool result;
		lock (value)
		{
			result = this._dictionary9005.ContainsKey(1);
		}
		return result;
	}

	// Token: 0x060000F2 RID: 242 RVA: 0x00005F7C File Offset: 0x0000417C
	public void Method11340(TItem 1)
	{
		object value = this._value9006;
		lock (value)
		{
			this._dictionary9005.Remove(1);
		}
	}

	// Token: 0x060000F3 RID: 243 RVA: 0x00005FC4 File Offset: 0x000041C4
	public object GetValue9006_11341()
	{
		return this._value9006;
	}

	// Token: 0x060000F4 RID: 244 RVA: 0x00005FCC File Offset: 0x000041CC
	public Dictionary<TItem, TItem2>.KeyCollection Method11342()
	{
		object value = this._value9006;
		Dictionary<TItem, TItem2>.KeyCollection keys;
		lock (value)
		{
			keys = this._dictionary9005.Keys;
		}
		return keys;
	}

	// Token: 0x060000F5 RID: 245 RVA: 0x00006014 File Offset: 0x00004214
	public Dictionary<TItem, TItem2>.ValueCollection Method11343()
	{
		object value = this._value9006;
		Dictionary<TItem, TItem2>.ValueCollection values;
		lock (value)
		{
			values = this._dictionary9005.Values;
		}
		return values;
	}

	// Token: 0x060000F6 RID: 246 RVA: 0x0000605C File Offset: 0x0000425C
	public void Method11344()
	{
		object value = this._value9006;
		lock (value)
		{
			this._dictionary9005.Clear();
		}
	}

	// Token: 0x04000068 RID: 104
	private readonly Dictionary<TItem, TItem2> _dictionary9005;

	// Token: 0x04000069 RID: 105
	private readonly object _value9006;
}
