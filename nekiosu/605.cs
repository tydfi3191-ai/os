using System;
using System.Data;
using System.Runtime.InteropServices;

// Token: 0x020000F6 RID: 246
[241(0)]
[ComVisible(false)]
[242(1)]
public sealed class 605 : 214
{
	// Token: 0x06000876 RID: 2166 RVA: 0x0001CCE4 File Offset: 0x0001AEE4
	public override void WriteJson(173 1, [241(2)] object 2, 158 3)
	{
		if (2 == null)
		{
			1.WriteNull();
			return;
		}
		DataSet dataSet = (DataSet)2;
		65 4 = 3.Method1759() as 65;
		396 5 = new 396();
		1.WriteStartObject();
		foreach (object obj in dataSet.Tables)
		{
			DataTable dataTable = (DataTable)obj;
			1.WritePropertyName((4 != null) ? 4.GetResolvedPropertyName(dataTable.TableName) : dataTable.TableName);
			5.WriteJson(1, dataTable, 3);
		}
		1.WriteEndObject();
	}

	// Token: 0x06000877 RID: 2167 RVA: 0x0001CD8C File Offset: 0x0001AF8C
	[return: 241(2)]
	public override object ReadJson(139 1, Type 2, [241(2)] object 3, 158 4)
	{
		if (1.GetTokenType() == 216.Null)
		{
			return null;
		}
		DataSet dataSet = (2 == typeof(DataSet)) ? new DataSet() : ((DataSet)Activator.CreateInstance(2));
		396 5 = new 396();
		1.Method2843();
		while (1.GetTokenType() == 216.PropertyName)
		{
			DataTable dataTable = dataSet.Tables[(string)1.GetValue()];
			bool flag = dataTable != null;
			dataTable = (DataTable)5.ReadJson(1, typeof(DataTable), dataTable, 4);
			if (!flag)
			{
				dataSet.Tables.Add(dataTable);
			}
			1.Method2843();
		}
		return dataSet;
	}

	// Token: 0x06000878 RID: 2168 RVA: 0x0001CE2B File Offset: 0x0001B02B
	public override bool CanConvert(Type 1)
	{
		return typeof(DataSet).IsAssignableFrom(1);
	}
}
