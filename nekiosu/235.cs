using System;
using System.Runtime.InteropServices;

// Token: 0x020003B0 RID: 944
[ComVisible(false)]
[Flags]
[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
public enum 235
{
	// Token: 0x04000E8F RID: 3727
	None = 0,
	// Token: 0x04000E90 RID: 3728
	String = 1,
	// Token: 0x04000E91 RID: 3729
	Float = 2,
	// Token: 0x04000E92 RID: 3730
	Integer = 4,
	// Token: 0x04000E93 RID: 3731
	Boolean = 8,
	// Token: 0x04000E94 RID: 3732
	Object = 16,
	// Token: 0x04000E95 RID: 3733
	Array = 32,
	// Token: 0x04000E96 RID: 3734
	Null = 64,
	// Token: 0x04000E97 RID: 3735
	Any = 127
}
