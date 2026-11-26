using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

// Token: 0x0200015F RID: 351
[ComVisible(false)]
[241(0)]
[242(1)]
public sealed class 559 : SerializationBinder, 718
{
	// Token: 0x06000C07 RID: 3079 RVA: 0x0002B6BB File Offset: 0x000298BB
	public 559()
	{
		this._recoveredType08385829 = new 482<558<string, string>, Type>(new Func<558<string, string>, Type>(this.Method7514));
	}

	// Token: 0x06000C08 RID: 3080 RVA: 0x0002B6DC File Offset: 0x000298DC
	private Type Method7514([241(new byte[]
	{
		0,
		2,
		1
	})] 558<string, string> 1)
	{
		string item = 1._item5821;
		string item2 = 1._item5822;
		if (item == null)
		{
			return Type.GetType(item2);
		}
		Assembly assembly = Assembly.LoadWithPartialName(item);
		if (assembly == null)
		{
			foreach (Assembly assembly2 in AppDomain.CurrentDomain.GetAssemblies())
			{
				if (assembly2.FullName == item || assembly2.GetName().Name == item)
				{
					assembly = assembly2;
					break;
				}
			}
		}
		if (assembly == null)
		{
			throw new 364("Could not load assembly '{0}'.".Method6825(CultureInfo.InvariantCulture, item));
		}
		Type type = assembly.GetType(item2);
		if (type == null)
		{
			if (538.Method6841(item2, '`') >= 0)
			{
				try
				{
					type = this.Method7515(item2, assembly);
				}
				catch (Exception 2)
				{
					throw new 364("Could not find type '{0}' in assembly '{1}'.".Method6825(CultureInfo.InvariantCulture, item2, assembly.FullName), 2);
				}
			}
			if (type == null)
			{
				throw new 364("Could not find type '{0}' in assembly '{1}'.".Method6825(CultureInfo.InvariantCulture, item2, assembly.FullName));
			}
		}
		return type;
	}

	// Token: 0x06000C09 RID: 3081 RVA: 0x0002B800 File Offset: 0x00029A00
	[return: 241(2)]
	private Type Method7515(string 1, Assembly 2)
	{
		Type result = null;
		int num = 538.Method6841(1, '[');
		if (num >= 0)
		{
			string name = 1.Substring(0, num);
			Type type = 2.GetType(name);
			if (type != null)
			{
				List<Type> list = new List<Type>();
				int num2 = 0;
				int num3 = 0;
				int num4 = 1.Length - 1;
				for (int i = num + 1; i < num4; i++)
				{
					char c = 1[i];
					if (c != '[')
					{
						if (c == ']')
						{
							num2--;
							if (num2 == 0)
							{
								558<string, string> 3 = 143.SplitFullyQualifiedTypeName(1.Substring(num3, i - num3));
								list.Add(this.Method7516(3));
							}
						}
					}
					else
					{
						if (num2 == 0)
						{
							num3 = i + 1;
						}
						num2++;
					}
				}
				result = type.MakeGenericType(list.ToArray());
			}
		}
		return result;
	}

	// Token: 0x06000C0A RID: 3082 RVA: 0x0002B8CC File Offset: 0x00029ACC
	private Type Method7516([241(new byte[]
	{
		0,
		2,
		1
	})] 558<string, string> 1)
	{
		return this._recoveredType08385829.Method4701(1);
	}

	// Token: 0x06000C0B RID: 3083 RVA: 0x0002B8DA File Offset: 0x00029ADA
	public override Type BindToType([241(2)] string 1, string 2)
	{
		return this.Method7516(new 558<string, string>(1, 2));
	}

	// Token: 0x06000C0C RID: 3084 RVA: 0x0002B8E9 File Offset: 0x00029AE9
	[242(2)]
	public override void BindToName([241(1)] Type 1, out string 2, out string 3)
	{
		2 = 1.Assembly.FullName;
		3 = 1.FullName;
	}

	// Token: 0x040005EC RID: 1516
	internal static readonly 559 _recoveredType12935828 = new 559();

	// Token: 0x040005ED RID: 1517
	[241(new byte[]
	{
		1,
		0,
		2,
		1,
		1
	})]
	private readonly 482<558<string, string>, Type> _recoveredType08385829;
}
