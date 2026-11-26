using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using OpenTK.Graphics.OpenGL;

// Token: 0x020003E8 RID: 1000
internal static class 263
{
	// Token: 0x06001F8A RID: 8074 RVA: 0x0007D668 File Offset: 0x0007B868
	internal static void 1()
	{
		if (Environment.GetEnvironmentVariable("OSU_OFFLINE_SMOKE") != "1")
		{
			return;
		}
		263.16 = (Environment.GetEnvironmentVariable("OSU_OFFLINE_SMOKE_EXTENDED") == "1");
		263.17 = (Environment.GetEnvironmentVariable("OSU_OFFLINE_SMOKE_LOCAL") == "1");
		263.12 = Thread.CurrentThread.ManagedThreadId;
		263.8 = Path.Combine(Environment.CurrentDirectory, "offline-gameplay-smoke.json");
		263.9 = Path.Combine(Environment.CurrentDirectory, "Songs", "Offline Recovery Test", "Offline Recovery - Training (Offline) [Standard].osu");
		263.3["status"] = "running";
		263.3["suite"] = (263.17 ? "local-workflow-regression" : (263.16 ? "editor-roundtrip-regression" : "single-autoplay"));
		if (263.16 && (Environment.GetEnvironmentVariable("OSU_OFFLINE_SMOKE_CASE_LIMIT") != null || Environment.GetEnvironmentVariable("OSU_OFFLINE_SMOKE_CASE_START") != null))
		{
			263.3["suite"] = "editor-roundtrip-diagnostic";
		}
		263.3["expectedObjects"] = 30;
		263.3["fixture"] = 263.9;
		263.3["processId"] = Process.GetCurrentProcess().Id;
		263.3["mainThread"] = 263.12;
		263.18 = DateTime.UtcNow;
		263.3["startedUtc"] = 263.18.ToString("o");
		263.3["stages"] = 263.4;
		263.5.Start();
		263.3["initialLocalState"] = 263.6();
		263.14("armed", "Waiting for the recovered game's WinForms message pump.");
		if (Environment.GetEnvironmentVariable("OSU_OFFLINE_SMOKE_SLIDER_PATH") == "1")
		{
			try
			{
				263.13("sliderPathGeometry", 263.22());
			}
			catch (Exception ex)
			{
				bool flag = false;
				string str = "Slider path geometry failed: ";
				Exception ex2 = ex;
				263.Finish(flag, str + ((ex2 != null) ? ex2.ToString() : null), true);
			}
		}
		263.7 = new System.Threading.Timer(delegate(object 1)
		{
			263.Finish(false, "Gameplay watchdog expired before verified results.", true);
		}, null, (263.16 || 263.17) ? 180000 : 60000, -1);
		263.6 = new System.Windows.Forms.Timer
		{
			Interval = 200
		};
		System.Windows.Forms.Timer timer = 263.6;
		EventHandler value;
		if ((value = 263.<>O.<0>__Tick) == null)
		{
			value = (263.<>O.<0>__Tick = new EventHandler(263.3));
		}
		timer.Tick += value;
		EventHandler value2;
		if ((value2 = 263.<>O.<1>__ArmUiTimer) == null)
		{
			value2 = (263.<>O.<1>__ArmUiTimer = new EventHandler(263.2));
		}
		Application.Idle += value2;
	}

	// Token: 0x06001F8B RID: 8075 RVA: 0x0007D938 File Offset: 0x0007BB38
	private static void 2(object 1, EventArgs 2)
	{
		EventHandler value;
		if ((value = 263.<>O.<1>__ArmUiTimer) == null)
		{
			value = (263.<>O.<1>__ArmUiTimer = new EventHandler(263.2));
		}
		Application.Idle -= value;
		if (Volatile.Read(ref 263.11) == 0)
		{
			263.6.Start();
		}
	}

	// Token: 0x06001F8C RID: 8076 RVA: 0x0007D970 File Offset: 0x0007BB70
	private static void 3(object 1, EventArgs 2)
	{
		if (Volatile.Read(ref 263.11) != 0)
		{
			return;
		}
		try
		{
			if (Thread.CurrentThread.ManagedThreadId != 263.12)
			{
				throw new InvalidOperationException("Smoke callback ran outside the startup STA thread.");
			}
			263.8();
			if (263.17)
			{
				263.266.1();
			}
			else if (263.16)
			{
				263.264.5();
			}
			else
			{
				Type type = 263.11("1662");
				object obj = 263.Get(type, null, "currentMode");
				object obj2 = 263.Get(type, null, "currentScreen");
				int num = Convert.ToInt32(263.Get(type, null, "transitionState"));
				if (263.10 == 0)
				{
					if (263.5.Elapsed.TotalSeconds >= 3.0 && obj2 != null && !(obj.ToString() != "Menu") && num == 2)
					{
						if (!File.Exists(263.9))
						{
							throw new FileNotFoundException("Generated smoke fixture is absent from this isolated run's Songs folder.", 263.9);
						}
						if (Application.OpenForms.Count != 0)
						{
							263.14("menu-ready", "Recovered menu and window are running on the startup thread.");
							263.Invoke(type, null, "SetMode", new object[]
							{
								1677.SelectPlay,
								false
							});
							263.10 = 1;
						}
					}
				}
				else if (263.10 == 1)
				{
					if (!(obj.ToString() != "SelectPlay") && obj2 != null && !(obj2.GetType().Name != "SongSelectionScreen") && num == 2)
					{
						Type type2 = 263.11("1272");
						ICollection collection = 263.Get(type2, null, "beatmaps") as ICollection;
						if (collection != null && collection.Count != 0)
						{
							263.14("song-selection-ready", "Imported song database contains " + collection.Count.ToString() + " local difficulties.");
							263.14 = 263.5(263.9, 30);
							int num2 = Convert.ToInt32(263.Get(263.14.GetType(), 263.14, "hitObjectCount"));
							263.13("parsedObjects", num2);
							if (num2 != 30)
							{
								throw new InvalidOperationException("Recovered beatmap parser found " + num2.ToString() + " objects, expected 30.");
							}
							263.Invoke(type2, null, "SetCurrentBeatmap", new object[]
							{
								263.14
							});
							263.Invoke(type2, null, "LoadTrackFor", new object[]
							{
								263.14
							});
							263.Set(263.11("2019"), null, "enabledMods", 2023.Autoplay);
							263.14("fixture-selected", "Recovered parser read all 30 objects; local preview and Autoplay were enabled.");
							263.10 = 2;
						}
					}
				}
				else if (263.10 == 2)
				{
					if (!(obj.ToString() != "SelectPlay") && num == 2)
					{
						263.Invoke(obj2.GetType(), obj2, "StartPlay", Array.Empty<object>());
						263.14("play-requested", "Invoked the real song-selection start handler.");
						263.10 = 3;
					}
				}
				else if (263.10 == 3)
				{
					if (obj.ToString() == "Play")
					{
						263.9();
						if (!263.13)
						{
							object obj3 = 263.Get(263.11("2486"), obj2, "ObjectManager");
							if (obj3 != null)
							{
								int num3 = Convert.ToInt32(263.Get(obj3.GetType(), obj3, "HitObjectCount"));
								if (num3 != 0)
								{
									263.13("gameplayObjects", num3);
									if (num3 != 30)
									{
										throw new InvalidOperationException("Gameplay loaded " + num3.ToString() + " objects, expected 30.");
									}
									263.13 = true;
									263.14("gameplay-observed", "Recovered player loaded 30 hit objects and entered Play.");
								}
							}
						}
					}
					else if (obj.ToString() == "Rank" && 263.13 && num == 2)
					{
						263.9();
						if (263.15 == null)
						{
							throw new InvalidOperationException("Results appeared without a recovered score object.");
						}
						int num4 = 263.10("Count300");
						int num5 = 263.10("Count100");
						int num6 = 263.10("Count50");
						int num7 = 263.10("CountMiss");
						263.13("judgements", new Dictionary<string, object>
						{
							{
								"great300",
								num4
							},
							{
								"good100",
								num5
							},
							{
								"meh50",
								num6
							},
							{
								"miss",
								num7
							}
						});
						263.14("results-observed", "Recovered results screen reached after Autoplay.");
						263.Finish(num4 == 30 && num5 == 0 && num6 == 0 && num7 == 0, string.Concat(new string[]
						{
							"Results: ",
							num4.ToString(),
							" great, ",
							num5.ToString(),
							" good, ",
							num6.ToString(),
							" meh, ",
							num7.ToString(),
							" miss."
						}), false);
					}
				}
			}
		}
		catch (Exception innerException)
		{
			if (innerException is TargetInvocationException && innerException.InnerException != null)
			{
				innerException = innerException.InnerException;
			}
			263.13("exception", innerException.ToString());
			263.Finish(false, "Smoke stage failed: " + innerException.Message, false);
		}
	}

	// Token: 0x06001F8D RID: 8077 RVA: 0x0007DEEC File Offset: 0x0007C0EC
	internal static bool 4(out 1087 1)
	{
		1 = default(1087);
		return (263.16 || 263.17) && Volatile.Read(ref 263.11) == 0 && (263.17 || 263.264.4(out 1));
	}

	// Token: 0x06001F8E RID: 8078 RVA: 0x0007DF20 File Offset: 0x0007C120
	private static 1262 5(string 1, int 2)
	{
		if (!File.Exists(6))
		{
			throw new FileNotFoundException("Generated fixture is absent from the preserved game Songs folder.", 6);
		}
		1262 3 = new 1262(6);
		if (3.65 != 2)
		{
			string[] array = new string[5];
			array[0] = "Fixture parser count mismatch: ";
			int num = 1;
			int 4 = 3.65;
			array[num] = 4.ToString();
			array[2] = " versus ";
			array[3] = 2.ToString();
			array[4] = ".";
			throw new InvalidOperationException(string.Concat(array));
		}
		string fullPath = Path.GetFullPath(6);
		1262 5 = 1272.3.Find((1262 1) => !1.61 && string.Equals(Path.GetFullPath(1.68()), fullPath, StringComparison.OrdinalIgnoreCase));
		if (5 == null)
		{
			throw new InvalidOperationException("Generated fixture has not been imported into the live song database: " + fullPath);
		}
		if (5.65 != 2)
		{
			string[] array2 = new string[5];
			array2[0] = "Imported fixture count mismatch: ";
			int num2 = 1;
			int 4 = 5.65;
			array2[num2] = 4.ToString();
			array2[2] = " versus ";
			array2[3] = 2.ToString();
			array2[4] = ".";
			throw new InvalidOperationException(string.Concat(array2));
		}
		return 5;
	}

	// Token: 0x06001F8F RID: 8079 RVA: 0x0007E034 File Offset: 0x0007C234
	private static Dictionary<string, object> 6()
	{
		string currentDirectory = Environment.CurrentDirectory;
		SortedSet<string> sortedSet = new SortedSet<string>(StringComparer.OrdinalIgnoreCase)
		{
			"osu!.cfg",
			"osu!.db",
			"scores.db",
			"Data/compatibility-persistence-marker.txt"
		};
		foreach (string path in Directory.GetFiles(currentDirectory, "osu!*.cfg", SearchOption.TopDirectoryOnly))
		{
			sortedSet.Add(Path.GetFileName(path));
		}
		List<Dictionary<string, object>> list = new List<Dictionary<string, object>>();
		foreach (string text in sortedSet)
		{
			string fileName = Path.Combine(currentDirectory, text.Replace('/', Path.DirectorySeparatorChar));
			FileInfo fileInfo = new FileInfo(fileName);
			Dictionary<string, object> dictionary = new Dictionary<string, object>
			{
				{
					"name",
					text
				},
				{
					"exists",
					fileInfo.Exists
				}
			};
			if (fileInfo.Exists)
			{
				dictionary["sha256"] = 263.7(fileName);
				dictionary["bytes"] = fileInfo.Length;
				dictionary["lastWriteUtc"] = fileInfo.LastWriteTimeUtc.ToString("o");
			}
			list.Add(dictionary);
		}
		string location = typeof(263).Assembly.Location;
		return new Dictionary<string, object>
		{
			{
				"capturedBeforeBootstrap",
				true
			},
			{
				"files",
				list
			},
			{
				"mainArtifact",
				new Dictionary<string, object>
				{
					{
						"name",
						Path.GetFileName(location)
					},
					{
						"sha256",
						263.7(location)
					}
				}
			}
		};
	}

	// Token: 0x06001F90 RID: 8080 RVA: 0x0007E210 File Offset: 0x0007C410
	private static string 7(string 1)
	{
		string result;
		using (FileStream fileStream = File.OpenRead(1))
		{
			using (SHA256 sha = SHA256.Create())
			{
				result = BitConverter.ToString(sha.ComputeHash(fileStream)).Replace("-", string.Empty).ToLowerInvariant();
			}
		}
		return result;
	}

	// Token: 0x06001F91 RID: 8081 RVA: 0x0007E280 File Offset: 0x0007C480
	private static void 8()
	{
		if (263.5.Elapsed.TotalSeconds - 263.19 < 1.0)
		{
			return;
		}
		263.19 = 263.5.Elapsed.TotalSeconds;
		string path = Path.Combine(Environment.CurrentDirectory, "Logs", "runtime.log");
		if (!File.Exists(path))
		{
			return;
		}
		using (FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read | FileShare.Write | FileShare.Delete))
		{
			using (StreamReader streamReader = new StreamReader(fileStream))
			{
				DateTime t = new DateTime(263.18.Ticks - 263.18.Ticks % 10000000L, DateTimeKind.Utc);
				string text;
				while ((text = streamReader.ReadLine()) != null)
				{
					DateTime t2;
					if (text.Length >= 22 && DateTime.TryParseExact(text.Substring(0, 19), "yyyy-MM-dd'T'HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeUniversal, out t2) && !(t2 < t))
					{
						string text2 = text.Substring(21);
						if (text2.StartsWith("ERROR", StringComparison.Ordinal) || text2.Contains("Exception:"))
						{
							263.13("runtimeError", text);
							throw new InvalidOperationException("Current gameplay run logged an error: " + text2);
						}
					}
				}
			}
		}
	}

	// Token: 0x06001F92 RID: 8082 RVA: 0x0007E3D8 File Offset: 0x0007C5D8
	private static void 9()
	{
		object obj = 263.Get(263.11("2486"), null, "CurrentScore");
		if (obj != null)
		{
			263.15 = obj;
		}
		if (263.15 != null)
		{
			263.13("observedGreat300", 263.10("Count300"));
		}
	}

	// Token: 0x06001F93 RID: 8083 RVA: 0x0007E424 File Offset: 0x0007C624
	private static int 10(string 1)
	{
		return Convert.ToInt32(263.Get(263.15.GetType(), 263.15, 1));
	}

	// Token: 0x06001F94 RID: 8084 RVA: 0x0007E440 File Offset: 0x0007C640
	private static Type 11(string 1)
	{
		return typeof(263).Assembly.GetType(1, true);
	}

	// Token: 0x06001F95 RID: 8085 RVA: 0x0007E458 File Offset: 0x0007C658
	private static FieldInfo 12(Type 1, string 2)
	{
		Type type = 1;
		while (type != null)
		{
			FieldInfo field = type.GetField(2, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			if (field != null)
			{
				return field;
			}
			type = type.BaseType;
		}
		throw new MissingFieldException(1.FullName, 2);
	}

	// Token: 0x06001F96 RID: 8086 RVA: 0x0007E49A File Offset: 0x0007C69A
	private static object Get(Type 1, object 2, string 3)
	{
		return 263.12(1, 3).GetValue(2);
	}

	// Token: 0x06001F97 RID: 8087 RVA: 0x0007E4A9 File Offset: 0x0007C6A9
	private static void Set(Type 1, object 2, string 3, object 4)
	{
		263.12(1, 3).SetValue(2, 4);
	}

	// Token: 0x06001F98 RID: 8088 RVA: 0x0007E4BC File Offset: 0x0007C6BC
	private static object Invoke(Type 1, object 2, string 3, params object[] 4)
	{
		foreach (MethodInfo methodInfo in 1.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic))
		{
			if (methodInfo.Name == 3 && methodInfo.GetParameters().Length == 4.Length)
			{
				return methodInfo.Invoke(2, 4);
			}
		}
		throw new MissingMethodException(1.FullName, 3);
	}

	// Token: 0x06001F99 RID: 8089 RVA: 0x0007E514 File Offset: 0x0007C714
	private static void 13(string 1, object 2)
	{
		object obj = 263.2;
		lock (obj)
		{
			263.3[1] = 2;
			263.Save();
		}
	}

	// Token: 0x06001F9A RID: 8090 RVA: 0x0007E560 File Offset: 0x0007C760
	private static void 14(string 1, string 2)
	{
		object obj = 263.2;
		lock (obj)
		{
			263.4.Add(new Dictionary<string, object>
			{
				{
					"stage",
					1
				},
				{
					"elapsedSeconds",
					263.5.Elapsed.TotalSeconds
				},
				{
					"detail",
					2
				}
			});
			263.Save();
		}
	}

	// Token: 0x06001F9B RID: 8091 RVA: 0x0007E5E8 File Offset: 0x0007C7E8
	private static void Save()
	{
		File.WriteAllText(263.8, 263.15(263.3));
	}

	// Token: 0x06001F9C RID: 8092 RVA: 0x0007E600 File Offset: 0x0007C800
	private static string 15(object 1)
	{
		if (1 == null)
		{
			return "null";
		}
		if (1 is string)
		{
			StringBuilder stringBuilder = new StringBuilder("\"");
			foreach (char c in (string)1)
			{
				if (c == '\\' || c == '"')
				{
					stringBuilder.Append('\\').Append(c);
				}
				else if (c < ' ')
				{
					StringBuilder stringBuilder2 = stringBuilder.Append("\\u");
					int num = (int)c;
					stringBuilder2.Append(num.ToString("x4"));
				}
				else
				{
					stringBuilder.Append(c);
				}
			}
			return stringBuilder.Append('"').ToString();
		}
		if (1 is bool)
		{
			if (!(bool)1)
			{
				return "false";
			}
			return "true";
		}
		else
		{
			IDictionary dictionary = 1 as IDictionary;
			if (dictionary != null)
			{
				StringBuilder stringBuilder3 = new StringBuilder("{");
				foreach (object obj in dictionary)
				{
					DictionaryEntry dictionaryEntry = (DictionaryEntry)obj;
					if (stringBuilder3.Length > 1)
					{
						stringBuilder3.Append(',');
					}
					stringBuilder3.Append(263.15(dictionaryEntry.Key.ToString())).Append(':').Append(263.15(dictionaryEntry.Value));
				}
				return stringBuilder3.Append('}').ToString();
			}
			IEnumerable enumerable = 1 as IEnumerable;
			if (enumerable != null)
			{
				StringBuilder stringBuilder4 = new StringBuilder("[");
				foreach (object obj2 in enumerable)
				{
					if (stringBuilder4.Length > 1)
					{
						stringBuilder4.Append(',');
					}
					stringBuilder4.Append(263.15(obj2));
				}
				return stringBuilder4.Append(']').ToString();
			}
			return ((IFormattable)1).ToString(null, CultureInfo.InvariantCulture);
		}
	}

	// Token: 0x06001F9D RID: 8093 RVA: 0x0007E81C File Offset: 0x0007CA1C
	private static void Finish(bool 1, string 2, bool 3)
	{
		if (Interlocked.CompareExchange(ref 263.11, 1, 0) != 0)
		{
			return;
		}
		object obj = 263.2;
		lock (obj)
		{
			263.3["status"] = (1 ? "passed" : "failed");
			263.3["reason"] = 2;
			263.3["timedOut"] = 3;
			263.3["observedPlay"] = 263.13;
			263.3["elapsedSeconds"] = 263.5.Elapsed.TotalSeconds;
			try
			{
				263.Save();
			}
			catch
			{
			}
		}
		if (!3)
		{
			263.6.Stop();
			for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
			{
				try
				{
					Application.OpenForms[i].Close();
				}
				catch
				{
				}
			}
		}
		263.7.Dispose();
		Environment.Exit(1 ? 0 : 2);
	}

	// Token: 0x06001F9E RID: 8094 RVA: 0x0007E958 File Offset: 0x0007CB58
	private static void 16(Action<string, bool> 1)
	{
		2191 2 = new 2191();
		1("empty taiko accuracy", 2.CalculateAccuracy() == 0f);
		2.2 = 3;
		2.1 = 2;
		2.6 = 1;
		1("taiko judgement totals", 2.GetJudgementCount() == 6 && 2.GetSuccessfulJudgementCount() == 5);
		1("taiko half-weight good accuracy", Math.Abs(2.CalculateAccuracy() - 0.6666667f) < 1E-06f);
		1877 3 = new 1877();
		1("empty catch accuracy", 3.CalculateAccuracy() == 1f);
		3.2 = 2;
		3.1 = 3;
		3.3 = 4;
		3.5 = 2;
		3.6 = 1;
		1("catch accuracy counts fruit and droplets equally", 3.GetJudgementCount() == 12 && 3.GetSuccessfulJudgementCount() == 9 && 3.CalculateAccuracy() == 0.75f);
		1986 4 = new 1986();
		1("empty mania accuracy", 4.CalculateAccuracy() == 1f);
		4.2 = 1;
		4.4 = 1;
		4.5 = 1;
		4.1 = 1;
		4.3 = 1;
		4.6 = 1;
		1("mania legacy accuracy weights", Math.Abs(4.CalculateAccuracy() - 0.5277778f) < 1E-06f);
		4.8 = 2023.ScoreV2;
		1("mania ScoreV2 accuracy weights", Math.Abs(4.CalculateAccuracy() - 0.5218579f) < 1E-06f);
		foreach (bool flag in new bool[]
		{
			default(bool),
			true
		})
		{
			2247 5 = new 2247
			{
				13 = 1234,
				2 = 3,
				1 = 2,
				3 = 1,
				4 = 4,
				5 = 5,
				6 = 6,
				14 = 45678,
				7 = 7,
				10 = 8,
				12 = false,
				8 = 123,
				11 = true,
				16 = flag,
				17 = 321.5,
				18 = 987.25
			};
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (1648 6 = new 1648(memoryStream))
				{
					5.WriteTo(6);
					6.Flush();
					byte[] array2 = memoryStream.ToArray();
					1("snapshot serialized size V2=" + flag.ToString(), array2.Length == (flag ? 45 : 29));
					2247 7 = new 2247(new MemoryStream(array2));
					1("snapshot score and judgement roundtrip V2=" + flag.ToString(), 7.13 == 1234 && 7.14 == 45678 && 7.2 == 3 && 7.1 == 2 && 7.3 == 1 && 7.4 == 4 && 7.5 == 5 && 7.6 == 6);
					1("snapshot health and combo roundtrip V2=" + flag.ToString(), 7.8 == 123 && 7.11 && 7.7 == 7 && 7.10 == 8 && !7.12);
					1("snapshot optional ScoreV2 roundtrip V2=" + flag.ToString(), 7.16 == flag && 7.17 == (flag ? 321.5 : 0.0) && 7.18 == (flag ? 987.25 : 0.0));
				}
			}
		}
		2135 8 = new 2135(new 2241());
		1("ScoreV2 without captured baseline has zero score", 8.GetScore() == 0);
		2155 9 = new 2155((2149)1024, true, true);
		2155 10 = new 2155((2149)1024, true, true);
		2155 11 = new 2155((2149)8192, false, false);
		8.2(9);
		8.2(10);
		8.2(11);
		1("ScoreV2 combo advances only on combo events", 9.3 == 1 && 10.3 == 2 && 11.3 == 2);
		1("ScoreV2 separates combo and bonus score", 8.2 == 690.0 && 8.3 == 100.0);
		8.Reset(true);
		1("ScoreV2 baseline capture clears live accumulators", 8.2 == 0.0 && 8.3 == 0.0);
		1("ScoreV2 captures judgement and combo baselines", (int)typeof(2153).GetField("BaselineJudgementCount", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(8) == 2 && (int)typeof(2153).GetField("BaselineCombo", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(8) == 2 && (double)typeof(2153).GetField("BaselineComboScore", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(8) == 690.0);
		2155 12 = new 2155((2149)1024, true, true);
		8.2(12);
		1("ScoreV2 starts a fresh live combo after reset", 12.3 == 1 && 8.2 == 330.0);
		8.Reset(false);
		1("ScoreV2 retry reset preserves captured baseline", 8.2 == 0.0 && (double)typeof(2153).GetField("BaselineComboScore", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(8) == 690.0);
		1572[] array3 = new 1572[]
		{
			1572.Left1,
			1572.Left2,
			1572.Right1,
			1572.Right2,
			1572.Smoke
		};
		for (int j = 0; j < 32; j++)
		{
			1572 13 = 1572.None;
			for (int k = 0; k < array3.Length; k++)
			{
				if ((j & 1 << k) != 0)
				{
					13 |= array3[k];
				}
			}
			1("replay pointer flags mask " + j.ToString(), 1555.41((j & 1) != 0, (j & 2) != 0, (j & 4) != 0, (j & 8) != 0, (j & 16) != 0) == 13);
		}
		Dictionary<FieldInfo, object> dictionary = new Dictionary<FieldInfo, object>();
		foreach (string name in new string[]
		{
			"leftButton",
			"rightButton",
			"middleButton",
			"backButton",
			"forwardButton",
			"pendingLeftButton",
			"pendingRightButton",
			"pendingMiddleButton",
			"pendingBackButton",
			"pendingForwardButton"
		})
		{
			FieldInfo field = typeof(1555).GetField(name, BindingFlags.Static | BindingFlags.NonPublic);
			dictionary.Add(field, field.GetValue(null));
			field.SetValue(null, 199.Released);
		}
		try
		{
			1555.3(199.Pressed);
			1555.3(199.Released);
			1("pointer press remains latched until advance", 1555.2() == 199.Pressed);
			1("pending pointer release advances", 1555.46() && 1555.2() == 199.Released);
			1("unchanged pointer advance reports false", !1555.46());
		}
		finally
		{
			foreach (KeyValuePair<FieldInfo, object> keyValuePair in dictionary)
			{
				keyValuePair.Key.SetValue(null, keyValuePair.Value);
			}
		}
		1561 14 = (1561)FormatterServices.GetUninitializedObject(typeof(1561));
		1558 15 = (1558)FormatterServices.GetUninitializedObject(typeof(1558));
		try
		{
			208 position = new 208(123.25f, -45.5f);
			14.SetPosition(position);
			15.SetPosition(position);
			1("system mouse position setter stores coordinates", 14.GetPosition() == position);
			1("raw mouse position setter stores coordinates", 15.GetPosition() == position);
		}
		finally
		{
			GC.SuppressFinalize(14);
			GC.SuppressFinalize(15);
		}
	}

	// Token: 0x06001F9F RID: 8095 RVA: 0x0007F244 File Offset: 0x0007D444
	private static Dictionary<string, object> 17(2039 1)
	{
		List<string> checks = new List<string>();
		Action<string, bool> action = delegate(string 1, bool 2)
		{
			if (!2)
			{
				throw new InvalidOperationException("Gameplay scoring/locking: " + 1);
			}
			checks.Add(1);
		};
		int num = 1226.16;
		bool 12 = 2486.22;
		List<2034> 3 = 11.36;
		int count = 11.34.Count;
		2039 4 = (2039)typeof(object).GetMethod("MemberwiseClone", BindingFlags.Instance | BindingFlags.NonPublic).Invoke(11, null);
		4.39 = null;
		4.36 = new List<2034>();
		2033 5 = new 2033(4)
		{
			1 = 900,
			2 = 996
		};
		2033 6 = new 2033(4)
		{
			1 = 1000,
			2 = 1000
		};
		2141 7 = (2141)FormatterServices.GetUninitializedObject(typeof(2141));
		7.5 = 4;
		Dictionary<string, object> result;
		try
		{
			2241 8 = new 2241();
			action("empty standard accuracy is one", 8.CalculateAccuracy() == 1f);
			8.2 = 3;
			8.1 = 2;
			8.3 = 1;
			8.6 = 4;
			action("standard judgement counts include misses", 8.GetJudgementCount() == 10 && 8.GetSuccessfulJudgementCount() == 6);
			action("standard accuracy applies 300/100/50 weights", Math.Abs(8.CalculateAccuracy() - 0.38333333f) < 1E-06f);
			8.SetRawScore(12345);
			action("raw score roundtrip without ScoreV2", 8.GetScore() == 12345);
			8.2 = 100;
			8.1 = 0;
			8.3 = 0;
			8.6 = 0;
			8.18 = false;
			action("incomplete play grades F", 8.CalculateGrade() == 2236.F);
			8.18 = true;
			8.8 = 2023.None;
			action("all greats grade X", 8.CalculateGrade() == 2236.X);
			8.8 = 2023.Hidden;
			action("Hidden all greats grade XH", 8.CalculateGrade() == 2236.XH);
			8.8 = 2023.Flashlight;
			action("Flashlight all greats grade XH", 8.CalculateGrade() == 2236.XH);
			8.8 = 2023.None;
			8.2 = 95;
			8.1 = 5;
			action("high great ratio without misses grades S", 8.CalculateGrade() == 2236.S);
			8.8 = 2023.Hidden;
			action("Hidden S grade becomes SH", 8.CalculateGrade() == 2236.SH);
			8.8 = 2023.None;
			8.2 = 85;
			8.1 = 15;
			action("clean lower ratio grades A", 8.CalculateGrade() == 2236.A);
			8.2 = 75;
			8.1 = 25;
			action("clean mid ratio grades B", 8.CalculateGrade() == 2236.B);
			8.2 = 65;
			8.1 = 35;
			action("lower ratio grades C", 8.CalculateGrade() == 2236.C);
			8.2 = 50;
			8.1 = 50;
			action("low ratio grades D", 8.CalculateGrade() == 2236.D);
			2499 9 = (2499)FormatterServices.GetUninitializedObject(typeof(2499));
			9.SetCombo(25);
			action("combo getter preserves assigned combo", 9.GetCombo() == 25);
			9.2(50);
			action("combo display reconciliation preserves actual combo", 9.GetCombo() == 50);
			2486.22 = false;
			1226.16 = 1000;
			4.36.Add(6);
			action("single current circle permits judgement", 7.GetHitAttemptDisposition(6) == (2032)2);
			4.36.Insert(0, 5);
			action("earlier unresolved object locks a later circle", 7.GetHitAttemptDisposition(6) == (2032)1);
			5.2 = 997;
			action("exact three millisecond overlap permits judgement", 7.GetHitAttemptDisposition(6) == (2032)2);
			5.2 = 996;
			5.11 = true;
			action("judged previous object releases lock", 7.GetHitAttemptDisposition(6) == (2032)2);
			5.11 = false;
			5.9 = 1;
			action("stack probe previous circle is active", 5.IsActive());
			action("active unjudged stacked predecessor suppresses attempt", 7.GetHitAttemptDisposition(6) == (2032)0);
			5.11 = true;
			action("judged stacked predecessor releases lock", 7.GetHitAttemptDisposition(6) == (2032)2);
			2241 10 = 2486.88;
			try
			{
				2486.88 = new 2241(null, "smoke")
				{
					45 = true
				};
				5.11 = false;
				1226.16 = 899;
				action("lazer notelock locks a later circle before the earlier start time", 7.GetHitAttemptDisposition(6) == (2032)1);
				1226.16 = 900;
				action("lazer notelock releases at the earlier start time", 7.GetHitAttemptDisposition(6) == (2032)2);
				1226.16 = 899;
				5.11 = true;
				action("lazer notelock releases when the earlier object is judged", 7.GetHitAttemptDisposition(6) == (2032)2);
				5.11 = false;
				1226.16 = 950;
				action("lazer notelock ignores the classic end time and stack suppression", 7.GetHitAttemptDisposition(6) == (2032)2);
			}
			finally
			{
				2486.88 = 10;
				5.11 = true;
				1226.16 = 1000;
			}
			4.36.Remove(5);
			foreach (int num2 in new int[]
			{
				-400,
				-399,
				399,
				400
			})
			{
				1226.16 = 6.1 + num2;
				action("normal early-window boundary " + num2.ToString(), 7.GetHitAttemptDisposition(6) == ((Math.Abs(num2) >= 400) ? ((2032)1) : ((2032)2)));
			}
			2486.22 = true;
			foreach (int num3 in new int[]
			{
				-200,
				-199,
				199,
				200
			})
			{
				1226.16 = 6.1 + num3;
				action("Relax2 early-window boundary " + num3.ToString(), 7.GetHitAttemptDisposition(6) == ((Math.Abs(num3) >= 200) ? ((2032)1) : ((2032)2)));
			}
			263.16(action);
			action("source manager lists preserved", 11.36 == 3 && 11.34.Count == count);
			result = new Dictionary<string, object>
			{
				{
					"passed",
					true
				},
				{
					"checkCount",
					checks.Count
				},
				{
					"checks",
					checks
				}
			};
		}
		finally
		{
			1226.16 = num;
			2486.22 = 12;
			5.Dispose();
			6.Dispose();
			GC.SuppressFinalize(4);
			GC.SuppressFinalize(7);
		}
		return result;
	}

	// Token: 0x06001FA0 RID: 8096 RVA: 0x0007F974 File Offset: 0x0007DB74
	private static Dictionary<string, object> 18(2039 1)
	{
		List<string> checks = new List<string>();
		Action<string, bool> check = delegate(string 1, bool 2)
		{
			if (!2)
			{
				throw new InvalidOperationException("Slider path construction: " + 1);
			}
			checks.Add(1);
		};
		Func<208, 208, bool> func = (208 1, 208 2) => 208.DistanceSquared(1, 2) < 0.001f;
		int count = 15.34.Count;
		object 16 = 15.39;
		2039 manager = (2039)typeof(object).GetMethod("MemberwiseClone", BindingFlags.Instance | BindingFlags.NonPublic).Invoke(15, null);
		manager.39 = null;
		List<2123> owned = new List<2123>();
		Func<2064, double, int, 208[], 2123> func2 = delegate(2064 1, double 2, int 3, 208[] 4)
		{
			2123 19 = new 2123(manager, 4[0], 1000, false, 1245.None, 1, 3, 2, new List<208>(4), null, 0);
			owned.Add(19);
			19.87 = 100.0;
			19.62 = true;
			19.RebuildPathAndTiming(true);
			return 19;
		};
		Action<string, 2123, double> action = delegate(string 1, 2123 2, double 3)
		{
			check(1 + " populated segments", 2.55 != null && 2.55.Count > 0);
			check(1 + " matching cumulative lengths", 2.57.Count == 2.55.Count);
			double num = 0.0;
			bool flag = true;
			for (int i = 0; i < 2.55.Count; i++)
			{
				double num2 = 2.57[i];
				flag &= (!double.IsNaN(num2) && num2 >= num && Math.Abs(num2 - num - (double)2.55[i].1()) < 0.001);
				num = num2;
			}
			check(1 + " finite cumulative distances", flag);
			check(1 + " corrected beatmap length", Math.Abs(num - 3) < 0.01);
		};
		Dictionary<string, object> result;
		try
		{
			2123 17 = func2(2064.Linear, 200.0, 2, new 208[]
			{
				new 208(100f, 100f),
				new 208(300f, 100f)
			});
			action("linear", 17, 200.0);
			check("linear start", func(17.29(0f), new 208(100f, 100f)));
			check("linear midpoint", func(17.29(100f), new 208(200f, 100f)));
			check("linear beyond-end clamp", func(17.29(500f), new 208(300f, 100f)));
			check("progress lower clamp", func(17.27(-1.0), 208.Zero));
			check("progress upper clamp", func(17.27(2.0), new 208(200f, 0f)));
			check("distance to absolute time", 17.28(250f) == 3500);
			check("repeat duration", 17.2 == 5000);
			check("first-span midpoint", func(17.GetPositionAtTime(2000), new 208(200f, 100f)));
			check("repeat turnaround", func(17.GetPositionAtTime(3000), new 208(300f, 100f)));
			check("reverse-span midpoint", func(17.GetPositionAtTime(4000), new 208(200f, 100f)));
			check("repeat final endpoint", func(17.GetPositionAtTime(5000), new 208(100f, 100f)));
			check("before-start position", func(17.GetPositionAtTime(999), new 208(100f, 100f)));
			check("after-end position", func(17.GetPositionAtTime(5001), 17.GetEndPosition()));
			object 18 = 17.55;
			17.RebuildPathAndTiming(false);
			check("nonforced clean path preserved", 18 == 17.55);
			17.RebuildPathAndTiming(true);
			check("forced path rebuilt", 18 != 17.55);
			check("rebuild interpolation stable", func(17.29(100f), new 208(200f, 100f)));
			2123 5 = func2(2064.Linear, 150.0, 1, new 208[]
			{
				new 208(100f, 100f),
				new 208(300f, 100f)
			});
			action("trimmed", 5, 150.0);
			check("calculated length precedes correction", Math.Abs(5.56 - 200.0) < 0.001);
			check("trimmed endpoint", func(5.29(150f), new 208(250f, 100f)));
			2123 6 = func2(2064.Linear, 250.0, 1, new 208[]
			{
				new 208(100f, 100f),
				new 208(300f, 100f)
			});
			action("extended", 6, 250.0);
			check("extended endpoint", func(6.29(250f), new 208(350f, 100f)));
			2123 7 = func2(2064.Linear, 200.0, 1, new 208[]
			{
				new 208(100f, 100f),
				new 208(200f, 100f),
				new 208(200f, 200f)
			});
			action("corner", 7, 200.0);
			check("exact cumulative boundary", func(7.29(100f), new 208(200f, 100f)));
			check("second segment interpolation", func(7.29(150f), new 208(200f, 150f)));
			2123 8 = func2(2064.Bezier, 180.0, 1, new 208[]
			{
				new 208(100f, 200f),
				new 208(200f, 100f),
				new 208(300f, 200f)
			});
			action("bezier", 8, 180.0);
			check("bezier resolved type", 8.63 == 2064.Bezier);
			check("bezier curves away from chord", 8.29(90f).Y < 180f);
			2123 9 = func2(2064.Catmull, 180.0, 1, new 208[]
			{
				new 208(100f, 200f),
				new 208(200f, 100f),
				new 208(300f, 200f)
			});
			action("catmull", 9, 180.0);
			check("catmull resolved type", 9.63 == 2064.Catmull);
			check("catmull sampling", 9.55.Count > 2);
			2123 10 = func2(2064.PerfectCurve, 300.0, 1, new 208[]
			{
				new 208(100f, 200f),
				new 208(200f, 100f),
				new 208(300f, 200f)
			});
			action("arc", 10, 300.0);
			check("arc resolved type", 10.63 == 2064.PerfectCurve);
			check("arc passes near middle control point", 208.Distance(10.29(157f), new 208(200f, 100f)) < 1f);
			2123 11 = func2(2064.PerfectCurve, 180.0, 1, new 208[]
			{
				new 208(100f, 200f),
				new 208(150f, 100f),
				new 208(250f, 100f),
				new 208(300f, 200f)
			});
			action("perfect to bezier fallback", 11, 180.0);
			check("more-than-three-point fallback", 11.63 == 2064.Bezier);
			2123 12 = func2(2064.PerfectCurve, 180.0, 1, new 208[]
			{
				new 208(100f, 100f),
				new 208(200f, 100f),
				new 208(300f, 100f)
			});
			action("collinear perfect", 12, 180.0);
			check("collinear geometry fallback", func(12.29(90f), new 208(190f, 100f)));
			check("collinear resolved type preserved", 12.63 == 2064.PerfectCurve);
			2123 13 = func2(2064.Linear, 0.0, 1, new 208[]
			{
				new 208(100f, 100f),
				new 208(100f, 100f)
			});
			action("zero-length", 13, 0.0);
			check("zero-length distance sampling", func(13.29(30f), new 208(100f, 100f)));
			17.55 = null;
			17.57 = null;
			check("lazy rebuild from distance sampling", func(17.29(100f), new 208(200f, 100f)));
			check("source manager object count preserved", 15.34.Count == count);
			check("source renderer preserved", 15.39 == 16);
			result = new Dictionary<string, object>
			{
				{
					"passed",
					true
				},
				{
					"checkCount",
					checks.Count
				},
				{
					"checks",
					checks
				}
			};
		}
		finally
		{
			foreach (2123 14 in owned)
			{
				14.Dispose();
			}
			GC.SuppressFinalize(manager);
		}
		return result;
	}

	// Token: 0x06001FA1 RID: 8097 RVA: 0x000804D0 File Offset: 0x0007E6D0
	private static Dictionary<string, object> 19(2039 1)
	{
		List<string> checks = new List<string>();
		Action<string, bool> action = delegate(string 1, bool 2)
		{
			if (!2)
			{
				throw new InvalidOperationException("Slider edit/sample check: " + 1);
			}
			checks.Add(1);
		};
		Func<208, 208, bool> func = (208 1, 208 2) => 208.DistanceSquared(1, 2) < 0.001f;
		int count = 15.34.Count;
		object 16 = 15.39;
		2039 manager = (2039)typeof(object).GetMethod("MemberwiseClone", BindingFlags.Instance | BindingFlags.NonPublic).Invoke(15, null);
		manager.39 = null;
		List<2123> owned = new List<2123>();
		List<2033> ownedHeads = new List<2033>();
		Func<2123> func2 = delegate()
		{
			2123 17 = new 2123(manager, new 208(100f, 100f), 1000, false, 1245.Whistle, 2064.Linear, 2, 200.0, new List<208>
			{
				new 208(100f, 100f),
				new 208(300f, 100f)
			}, null, 0);
			owned.Add(17);
			17.87 = 100.0;
			17.62 = true;
			17.RebuildPathAndTiming(true);
			manager.39 = 15.39;
			try
			{
				17.58 = new 2033(manager, 17.8, 17.1, false, 17.4, 0);
			}
			finally
			{
				manager.39 = null;
			}
			ownedHeads.Add(17.58);
			return 17;
		};
		Dictionary<string, object> result;
		try
		{
			1244 3 = new 1244(1245.Clap, 1254.Soft, 1253.Default, 70, 1254.Drum);
			action("sample sound flags", 3.1 == 1245.Clap);
			action("sample normal bank", 3.2 == 1254.Soft);
			action("sample addition bank", 3.3 == 1254.Drum);
			action("sample index", 3.4 == 1253.Default);
			action("sample volume", 3.5 == 70);
			1244 4 = 1244.1(1245.None, 1254.Soft, 1253.Default, 65, 1254.Drum);
			action("silent flags receive normal fallback", (4.1 & 1245.Normal) > 1245.None);
			action("fallback preserves banks and volume", 4.2 == 1254.Soft && 4.3 == 1254.Drum && 4.5 == 65);
			2123 5 = func2();
			action("new slider uses default edge samples", 5.73 && 5.84.Count == 0);
			5.35 = 1254.Soft;
			5.36 = 1254.Drum;
			5.45();
			action("edge sample expansion includes head and two span ends", !5.73 && 5.84.Count == 3 && 5.85.Count == 3 && 5.86.Count == 3);
			Action<string, bool> action2 = action;
			string arg = "edge sample expansion preserves flags and banks";
			bool arg2;
			if (5.84.TrueForAll((1245 1) => 1 == 1245.Whistle))
			{
				if (5.85.TrueForAll((1254 1) => 1 == 1254.Soft))
				{
					arg2 = 5.86.TrueForAll((1254 1) => 1 == 1254.Drum);
					goto IL_2A0;
				}
			}
			arg2 = false;
			IL_2A0:
			action2(arg, arg2);
			5.45();
			action("explicit samples are not expanded twice", 5.84.Count == 3);
			5.84[1] = 1245.Clap;
			5.85[1] = 1254.Drum;
			5.86[1] = 1254.Soft;
			1244 6 = 5.43(0);
			1244 7 = 5.43(1);
			1244 8 = 5.43(2);
			action("head sample resolves explicit banks", 6.2 == 1254.Soft && 6.3 == 1254.Drum && (6.1 & 1245.Whistle) > 1245.None);
			action("repeat sample resolves its own banks", 7.2 == 1254.Drum && 7.3 == 1254.Soft && (7.1 & 1245.Clap) > 1245.None);
			action("tail sample retains last edge banks", 8.2 == 1254.Soft && 8.3 == 1254.Drum);
			manager.39 = 15.39;
			2123 9;
			try
			{
				9 = (2123)5.Clone();
			}
			finally
			{
				manager.39 = null;
			}
			owned.Add(9);
			ownedHeads.Add(9.58);
			action("copy preserves position and timing", func(9.8, 5.8) && 9.1 == 5.1 && 9.2 == 5.2);
			action("copy preserves slider path metadata", 9.5 == 5.5 && 9.6 == 5.6 && 9.51 == 5.51);
			action("copy owns control point list", 9.54 != 5.54 && 9.54.Count == 5.54.Count);
			action("copy owns edge sample lists", 9.84 != 5.84 && 9.85 != 5.85 && 9.86 != 5.86);
			9.54[1] = new 208(350f, 100f);
			9.84[0] = 1245.Finish;
			action("editing copy preserves source points and flags", func(5.54[1], new 208(300f, 100f)) && 5.84[0] == 1245.Whistle);
			5.46();
			action("edge reset restores implicit defaults", 5.73 && 5.35 == 1254.None && 5.36 == 1254.None);
			action("edge reset clears all lists", 5.84.Count == 0 && 5.85.Count == 0 && 5.86.Count == 0);
			1244 10 = 5.43(0);
			action("implicit sample resolves a normal bank", 10.2 != 1254.None && 10.3 == 10.2);
			208 currentPosition = 5.GetCurrentPosition();
			208 endPosition = 5.GetEndPosition();
			5.SetPosition(new 208(120f, 130f), false);
			action("translation updates head and unstacked position", func(5.58.8, 5.8) && func(5.18, 5.8));
			action("translation moves all control points", func(5.54[0], new 208(120f, 130f)) && func(5.54[1], new 208(320f, 130f)));
			action("translation moves sampled path", func(5.29(100f), new 208(220f, 130f)));
			action("translation moves cached current and end positions", func(5.GetCurrentPosition(), currentPosition + new 208(20f, 30f)) && func(5.GetEndPosition(), endPosition + new 208(20f, 30f)));
			5.13(2000, false);
			action("unrebuilt start time resets end and head time", 5.1 == 2000 && 5.2 == 2000 && 5.58.1 == 2000);
			5.SetStartTime(2000);
			action("rebuilt start time retains two-span duration", 5.2 == 6000 && 5.82.Count == 1);
			5.14(6001);
			action("creation extension uses enclosing span", 5.5 == 3 && 5.2 == 8000);
			5.15(4999);
			action("repeat drag rounds below half-span boundary", 5.5 == 1 && 5.2 == 4000);
			5.15(5001);
			action("repeat drag rounds above half-span boundary", 5.5 == 2 && 5.2 == 6000);
			2123 11 = func2();
			11.18(new 208(350f, 150f), 1);
			action("control point edit measures new geometry", func(11.54[1], new 208(350f, 150f)) && Math.Abs(11.56 - (double)208.Distance(new 208(100f, 100f), new 208(350f, 150f))) < 0.01 && 11.6 > 0.0);
			float num = (float)(11.6 / 2.0);
			action("control point edit rebuilds interpolation", func(11.29(num), new 208(100f, 100f) + 208.Normalize(new 208(250f, 50f)) * num));
			2123 12 = func2();
			12.SetCurrentPosition(new 208(300f, 100f));
			12.20();
			action("linear reversal swaps path endpoints", func(12.54[0], new 208(300f, 100f)) && func(12.54[1], new 208(100f, 100f)));
			action("linear reversal updates head and sampling", func(12.58.8, new 208(300f, 100f)) && func(12.29(100f), new 208(200f, 100f)));
			action("source object collection preserved", 15.34.Count == count);
			action("source renderer preserved", 15.39 == 16);
			result = new Dictionary<string, object>
			{
				{
					"passed",
					true
				},
				{
					"checkCount",
					checks.Count
				},
				{
					"checks",
					checks
				}
			};
		}
		finally
		{
			foreach (2033 13 in ownedHeads)
			{
				13.Dispose();
			}
			foreach (2123 14 in owned)
			{
				14.Dispose();
			}
			GC.SuppressFinalize(manager);
		}
		return result;
	}

	// Token: 0x06001FA2 RID: 8098 RVA: 0x00081034 File Offset: 0x0007F234
	private static Dictionary<string, object> 20(2039 1)
	{
		List<string> checks = new List<string>();
		Action<string, bool> action = delegate(string 1, bool 2)
		{
			if (!2)
			{
				throw new InvalidOperationException("Slider judgement: " + 1);
			}
			checks.Add(1);
		};
		2039 12 = (2039)typeof(object).GetMethod("MemberwiseClone", BindingFlags.Instance | BindingFlags.NonPublic).Invoke(11, null);
		12.39 = null;
		2241 3 = 2486.88;
		int num = 1226.16;
		bool flag = 1555.15;
		bool 4 = 2486.21;
		List<263.265> list = new List<263.265>();
		int[] array = new int[]
		{
			0,
			256,
			512,
			1024
		};
		int[,] array2 = new int[,]
		{
			{
				-131072,
				256,
				512,
				512
			},
			{
				256,
				512,
				512,
				1024
			},
			{
				256,
				512,
				512,
				1024
			},
			{
				256,
				512,
				512,
				1024
			}
		};
		int[,] array3 = new int[,]
		{
			{
				-131072,
				256,
				256,
				256
			},
			{
				256,
				256,
				256,
				256
			},
			{
				256,
				512,
				512,
				512
			},
			{
				256,
				512,
				512,
				1024
			}
		};
		Dictionary<string, object> result;
		try
		{
			for (int i = 0; i < 2; i++)
			{
				2241 5 = new 2241();
				if (i == 1)
				{
					5.39 = (2153)FormatterServices.GetUninitializedObject(typeof(1878));
				}
				2486.88 = 5;
				for (int j = 0; j < array.Length; j++)
				{
					for (int k = 0; k < 4; k++)
					{
						263.265 6 = new 263.265(12);
						list.Add(6);
						6.58.14 = (2149)array[j];
						6.76 = k;
						int num2 = (i == 0) ? array2[j, k] : array3[j, k];
						string str = string.Concat(new string[]
						{
							"mode ",
							i.ToString(),
							", head ",
							array[j].ToString(),
							", checkpoints ",
							k.ToString()
						});
						action(str + " final result", 6.GetOrCalculateJudgement() == (2149)num2);
						action(str + " head counted once", 6.76 == k + ((j != 0) ? 1 : 0));
						action(str + " finalised", 6.11);
						action(str + " sound stop", 6.94 == 1);
						action(str + " collected sound", 6.93 == ((num2 != -131072) ? 1 : 0));
					}
				}
			}
			1555.15 = false;
			2486.21 = false;
			263.265 7 = new 263.265(12);
			list.Add(7);
			1226.16 = 999;
			action("before-start guard", 7.JudgeAtPosition(208.Zero) == (2149)0 && 7.80 == 0);
			1226.16 = 1050;
			action("no checkpoint due", 7.JudgeAtPosition(208.Zero) == (2149)0 && 7.80 == 0);
			1226.16 = 1300;
			action("first overdue miss", 7.JudgeAtPosition(208.Zero) == (2149)(-262144) && 7.80 == 1);
			action("second overdue miss", 7.JudgeAtPosition(208.Zero) == (2149)(-262144) && 7.80 == 2);
			action("terminal overdue miss", 7.JudgeAtPosition(208.Zero) == (2149)(-524288) && 7.80 == 3);
			action("overdue processed once", 7.JudgeAtPosition(208.Zero) == (2149)0 && 7.80 == 3);
			action("misses not collected", 7.76 == 0 && !7.81[0] && !7.81[1] && !7.81[2]);
			7.11 = true;
			action("already-judged guard", 7.JudgeAtPosition(208.Zero) == (2149)0 && 7.80 == 3);
			2123.2128 8 = new 2123.2128();
			1445 9 = new 1445(new 208(100f, 100f), new 208(200f, 100f), 1000, 2000, (1046)0);
			foreach (int num3 in new int[]
			{
				999,
				1000,
				1500,
				2000,
				2001
			})
			{
				8.1 = num3;
				action("animation interval " + num3.ToString(), 8.1(9) == (num3 != 999 && num3 != 2001));
			}
			result = new Dictionary<string, object>
			{
				{
					"passed",
					true
				},
				{
					"checkCount",
					checks.Count
				},
				{
					"checks",
					checks
				}
			};
		}
		finally
		{
			2486.88 = 3;
			1226.16 = num;
			1555.15 = flag;
			2486.21 = 4;
			foreach (263.265 10 in list)
			{
				10.58.Dispose();
				10.Dispose();
			}
			GC.SuppressFinalize(12);
		}
		return result;
	}

	// Token: 0x06001FA3 RID: 8099 RVA: 0x000815A0 File Offset: 0x0007F7A0
	private static Dictionary<string, object> 21(2039 1)
	{
		List<string> checks = new List<string>();
		Action<string, bool> action = delegate(string 1, bool 2)
		{
			if (!2)
			{
				throw new InvalidOperationException("Slider lifecycle check: " + 1);
			}
			checks.Add(1);
		};
		Func<208, 208, bool> func = (208 1, 208 2) => 208.DistanceSquared(1, 2) < 0.001f;
		int count = 17.34.Count;
		1436 renderer = 17.39;
		2039 manager = (2039)typeof(object).GetMethod("MemberwiseClone", BindingFlags.Instance | BindingFlags.NonPublic).Invoke(17, null);
		manager.39 = null;
		manager.22 = 2023.None;
		List<2034> owned = new List<2034>();
		2263 editor = 2263.4;
		2458 18 = editor.8;
		bool 3 = editor.85;
		FieldInfo field = typeof(2263).GetField("isUndoCommitDeferred", BindingFlags.Instance | BindingFlags.NonPublic);
		object value = field.GetValue(editor);
		1677 4 = 1662.78;
		Func<2123> func2 = delegate()
		{
			2123 19 = new 2123(manager, new 208(100f, 100f), 1000, false, 1245.Whistle, 2064.Linear, 2, 200.0, new List<208>
			{
				new 208(100f, 100f),
				new 208(300f, 100f)
			}, null, 0);
			owned.Add(19);
			19.87 = 100.0;
			19.62 = true;
			19.RebuildPathAndTiming(true);
			manager.39 = renderer;
			try
			{
				19.58 = new 2061(manager, 19.8, 19.1, false, 19.4, 0);
			}
			finally
			{
				manager.39 = null;
			}
			owned.Add(19.58);
			return 19;
		};
		Func<2458> func3 = delegate()
		{
			2458 19 = new 2458(null);
			19.6 = manager;
			19.7 = editor.6;
			editor.8 = 19;
			return 19;
		};
		Func<2458, 2393> func4 = delegate(2458 1)
		{
			2453 19 = (2453)typeof(2458).GetField("currentHandler", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(1);
			if (19 != null)
			{
				return (2393)typeof(2453).GetField("currentAction", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(19);
			}
			return null;
		};
		Dictionary<string, object> result;
		try
		{
			2123 5 = func2();
			action("head uses sliderstartcircle texture vocabulary", 5.58.GetCircleTextureName() == "sliderstartcircle");
			action("body selection starts clear", !5.11());
			5.12(true);
			action("body selection toggles on", 5.11());
			5.12(false);
			action("body selection toggles off", !5.11());
			manager.39 = renderer;
			2066 6;
			try
			{
				6 = new 2066(manager, new 208(300f, 100f), 3000, 500, true, true, 0f, 5);
			}
			finally
			{
				manager.39 = null;
			}
			owned.Add(6);
			5.48.Add(6);
			action("endpoint uses sliderendcircle texture vocabulary", 6.GetCircleTextureName() == "sliderendcircle");
			action("edge list preserves head and endpoint order", 5.9().Count == 2 && 5.9()[0] == 5.58 && 5.9()[1] == 6);
			action("no edge initially selected", !5.10());
			6.4(true);
			action("endpoint selection is recognized", 5.10() && 2123.2127.Instance.2(6));
			2123.2127.Instance.5(6);
			action("endpoint callback clears selection", !6.3() && !5.10());
			2066.2067 instance = 2066.2067.Instance;
			1445 7 = new 1445(1456.Fade, 0f, 1f, 10, 20, (1046)0);
			1445 8 = new 1445(1456.Fade, 1f, 0f, 10, 20, (1046)0);
			action("circle and overlay predicates select fade-in", instance.1(7) && instance.2(7) && !instance.1(8));
			action("fade-out callback selects ending alpha zero", 2123.2127.Instance.3(8) && !2123.2127.Instance.3(7));
			8.16 = 148;
			action("judgement predicates use tag 148", instance.3(8) && instance.4(8) && !instance.3(7));
			6.ResetJudgementState();
			action("reset leaves one tagged circle fade", 6.46.3.Count((1445 1) => 1.16 == 148) == 1);
			int count2 = 6.46.3.Count;
			6.ApplyJudgementAnimation(false);
			action("miss leaves endpoint animation unchanged", 6.46.3.Count == count2);
			1662.78 = 1677.Play;
			try
			{
				2123.2127.Instance.7(6);
			}
			finally
			{
				1662.78 = 4;
			}
			action("collected endpoint adds fade and scale", 6.46.3.Count((1445 1) => 1.16 == 148) == 2);
			2123.2127.Instance.9(6);
			action("reset callback removes collected scale", 6.46.3.Count((1445 1) => 1.16 == 148) == 1);
			manager.22 = 2023.Hidden;
			6.ApplyJudgementAnimation(true);
			action("Hidden suppresses collected endpoint animation", 6.46.3.Count((1445 1) => 1.16 == 148) == 1);
			manager.22 = 2023.None;
			2123 eventSlider = func2();
			action("raw event span count initially matches constructor", eventSlider.21() == 2);
			eventSlider.22(3);
			action("raw event span setter preserves normalized span count", eventSlider.21() == 3 && eventSlider.5 == 2);
			eventSlider.22(2);
			List<2055> list = new List<2055>();
			eventSlider.24(list);
			action("event list setter retains supplied list", eventSlider.23() == list);
			eventSlider.GenerateSliderEvents();
			action("events include one head, one repeat and one tail", list.OfType<2062>().Count<2062>() == 1 && list.OfType<2065>().Count<2065>() == 1 && list.OfType<2068>().Count<2068>() == 1);
			action("every generated event owns the slider", list.Count > 0 && list.All((2055 1) => 1.2 == eventSlider));
			action("event head has start time and position", list.OfType<2062>().Single<2062>().GetTime() == (double)eventSlider.1 && func(list.OfType<2062>().Single<2062>().GetPosition(), eventSlider.8));
			action("event tail has end position and later time", list.OfType<2068>().Single<2068>().GetTime() > (double)eventSlider.1 && func(list.OfType<2068>().Single<2068>().GetPosition(), eventSlider.GetEndPosition()));
			int count3 = list.Count;
			eventSlider.GenerateSliderEvents();
			action("event generation preserves existing append behavior", list.Count == count3 * 2);
			2123 9 = func2();
			9.17(new 208(400f, 100f));
			action("pending point ignored outside creation", 9.54.Count == 2 && !9.70);
			9.67 = true;
			9.17(new 208(400f, 100f));
			action("creation queues preview until next rebuild", 9.54.Count == 2 && !9.70);
			9.RebuildPathAndTiming(true);
			action("creation retains trailing preview point", 9.70 && 9.54.Count == 3 && func(9.54.Last<208>(), new 208(400f, 100f)));
			9.17(new 208(500f, 100f));
			action("replacement removes previous preview before rebuild", 9.54.Count == 2 && !9.70);
			9.RebuildPathAndTiming(true);
			action("new pending point replaces old preview", 9.70 && 9.54.Count == 3 && func(9.54.Last<208>(), new 208(500f, 100f)));
			2458 arg = func3();
			9.16(false, false);
			action("advance commits preview and continues creation", !9.70 && 9.67 && 9.54.Count == 3);
			action("preview commit records insertion operation", func4(arg) != null);
			2123 10 = func2();
			2458 arg2 = func3();
			10.19(1, new 208(200f, 100f));
			action("insertion preserves requested index and geometry", 10.54.Count == 3 && func(10.54[1], new 208(200f, 100f)) && 10.56 > 0.0);
			2393 11 = func4(arg2);
			action("insertion creates control-point undo record", 11 != null);
			2440.2443 12 = (2440.2443)typeof(2393).GetField("sliderControlPointRef2", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(11);
			action("undo snapshot identifies owned slider, index and position", 12 != null && 12.1() == 10 && 12.3() == 1 && func(12.4, new 208(200f, 100f)));
			object value2 = typeof(2393).GetField("nullable2", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(11);
			action("undo captures prior linear path type", value2 != null && (2064)value2 == 2064.Linear);
			2123 13 = func2();
			13.67 = true;
			13.16(false, true);
			action("discard branch removes unretained trailing point", 13.54.Count == 1 && 13.67);
			2123 14 = func2();
			func3();
			14.16(true, false);
			action("finish transition exits creation", !14.67);
			2123.2125 15 = new 2123.2125
			{
				1 = eventSlider,
				3 = eventSlider.57.Count - 1,
				2 = 40f
			};
			double num = eventSlider.57.Last<double>() - 40.0;
			action("path lookback excludes exact boundary", 15.1(num - 0.01) && !15.1(num));
			eventSlider.55 = null;
			action("abnormal path diagnostic safely rejects absent geometry", !eventSlider.30());
			action("source objects and renderer preserved", 17.34.Count == count && 17.39 == renderer);
			result = new Dictionary<string, object>
			{
				{
					"passed",
					true
				},
				{
					"checkCount",
					checks.Count
				},
				{
					"checks",
					checks
				}
			};
		}
		finally
		{
			1662.78 = 4;
			editor.8 = 18;
			editor.85 = 3;
			field.SetValue(editor, value);
			foreach (2034 16 in owned)
			{
				16.Dispose();
			}
			GC.SuppressFinalize(manager);
		}
		return result;
	}

	// Token: 0x06001FA4 RID: 8100 RVA: 0x00082224 File Offset: 0x00080424
	private static Dictionary<string, object> 22()
	{
		List<string> checks = new List<string>();
		Action<string, bool> action = delegate(string 1, bool 2)
		{
			if (!2)
			{
				throw new InvalidOperationException(1);
			}
			checks.Add(1);
		};
		Func<float, float, bool> near = (float 1, float 2) => !float.IsNaN(1) && Math.Abs(1 - 2) < 0.0001f;
		Func<208, 208, bool> func = (208 1, 208 2) => near(1.X, 2.X) && near(1.Y, 2.Y);
		1051 <<EMPTY_NAME>> = new 1051(new 208(2f, 3f), new 208(5f, 7f));
		action("diagonal length", near(<<EMPTY_NAME>>.1(), 5f));
		action("diagonal angle in radians", near(<<EMPTY_NAME>>.2(), 0.9272952f));
		action("interior projection", func(<<EMPTY_NAME>>.5(new 208(9.5f, 0.5f)), new 208(3.5f, 5f)));
		action("start clamp", func(<<EMPTY_NAME>>.5(new 208(-1f, -1f)), <<EMPTY_NAME>>.1));
		action("end clamp", func(<<EMPTY_NAME>>.5(new 208(8f, 11f)), <<EMPTY_NAME>>.2));
		action("distance to interior", near(<<EMPTY_NAME>>.4(new 208(9.5f, 0.5f)), 7.5f));
		action("squared distance to interior", near(<<EMPTY_NAME>>.3(new 208(9.5f, 0.5f)), 56.25f));
		action("distance beyond endpoint", near(<<EMPTY_NAME>>.4(new 208(8f, 11f)), 5f));
		action("start transform origin", func(208.Transform(208.Zero, <<EMPTY_NAME>>.6()), <<EMPTY_NAME>>.1));
		action("end transform origin", func(208.Transform(208.Zero, <<EMPTY_NAME>>.7()), <<EMPTY_NAME>>.2));
		action("start transform rotation", func(208.Transform(new 208(1f, 0f), <<EMPTY_NAME>>.6()), new 208(2.6f, 3.8f)));
		action("end transform rotation", func(208.Transform(new 208(1f, 0f), <<EMPTY_NAME>>.7()), new 208(5.6f, 7.8f)));
		1051 10 = new 1051(new 208(0f, 4f), new 208(10f, 4f));
		action("horizontal projection", func(10.5(new 208(6f, 20f)), new 208(6f, 4f)));
		action("horizontal angle", near(10.2(), 0f));
		1051 3 = new 1051(new 208(3f, 0f), new 208(3f, 10f));
		action("vertical projection", func(3.5(new 208(20f, 6f)), new 208(3f, 6f)));
		action("vertical angle", near(3.2(), 1.5707963f));
		1051 4 = new 1051(<<EMPTY_NAME>>.2, <<EMPTY_NAME>>.1);
		action("reversed projection", func(4.5(new 208(9.5f, 0.5f)), new 208(3.5f, 5f)));
		action("reversed angle", near(4.2(), -2.2142973f));
		1051 5 = new 1051(new 208(2f, 3f), new 208(2f, 3f));
		action("zero length", near(5.1(), 0f));
		action("zero-length closest point", func(5.5(new 208(5f, 7f)), 5.1));
		action("zero-length distance", near(5.4(new 208(5f, 7f)), 5f));
		action("zero-length transform", func(208.Transform(208.Zero, 5.7()), 5.2));
		<<EMPTY_NAME>>.3 = true;
		<<EMPTY_NAME>>.4 = true;
		1051 6 = (1051)<<EMPTY_NAME>>.Clone();
		action("clone distinct instance", 6 != <<EMPTY_NAME>>);
		action("clone endpoints", 6.1 == <<EMPTY_NAME>>.1 && 6.2 == <<EMPTY_NAME>>.2);
		action("clone rendering hints", 6.3 && 6.4);
		6.1 = 208.Zero;
		action("clone endpoint independence", <<EMPTY_NAME>>.1 == new 208(2f, 3f));
		1050 7 = new 1050(<<EMPTY_NAME>>.1, <<EMPTY_NAME>>.2, 198.Red);
		action("coloured endpoints", 7.1 == <<EMPTY_NAME>>.1 && 7.2 == <<EMPTY_NAME>>.2);
		action("supplied colour", 7.5.Equals(198.Red));
		1050 8 = (1050)7.Clone();
		action("clone retains subtype and colour", 7 != 8 && 8.5.Equals(198.Red));
		string[] array = new string[]
		{
			"Catmull",
			"Bezier",
			"Linear",
			"PerfectCurve"
		};
		action("path enum member count", Enum.GetNames(typeof(2064)).Length == array.Length);
		for (int i = 0; i < array.Length; i++)
		{
			Action<string, bool> action2 = action;
			string arg = "path enum value/name " + array[i];
			2064 9 = (2064)i;
			action2(arg, 9.ToString() == array[i]);
		}
		action("slider base inheritance", typeof(2063).BaseType == typeof(2034) && typeof(2123).BaseType == typeof(2063));
		return new Dictionary<string, object>
		{
			{
				"passed",
				true
			},
			{
				"checkCount",
				checks.Count
			},
			{
				"checks",
				checks
			}
		};
	}

	// Token: 0x04001050 RID: 4176
	private const BindingFlags 1 = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;

	// Token: 0x04001051 RID: 4177
	private static readonly object 2 = new object();

	// Token: 0x04001052 RID: 4178
	private static readonly Dictionary<string, object> 3 = new Dictionary<string, object>();

	// Token: 0x04001053 RID: 4179
	private static readonly List<Dictionary<string, object>> 4 = new List<Dictionary<string, object>>();

	// Token: 0x04001054 RID: 4180
	private static readonly Stopwatch 5 = new Stopwatch();

	// Token: 0x04001055 RID: 4181
	private static System.Windows.Forms.Timer 6;

	// Token: 0x04001056 RID: 4182
	private static System.Threading.Timer 7;

	// Token: 0x04001057 RID: 4183
	private static string 8;

	// Token: 0x04001058 RID: 4184
	private static string 9;

	// Token: 0x04001059 RID: 4185
	private static int 10;

	// Token: 0x0400105A RID: 4186
	private static int 11;

	// Token: 0x0400105B RID: 4187
	private static int 12;

	// Token: 0x0400105C RID: 4188
	private static bool 13;

	// Token: 0x0400105D RID: 4189
	private static object 14;

	// Token: 0x0400105E RID: 4190
	private static object 15;

	// Token: 0x0400105F RID: 4191
	private static bool 16;

	// Token: 0x04001060 RID: 4192
	private static bool 17;

	// Token: 0x04001061 RID: 4193
	private static DateTime 18;

	// Token: 0x04001062 RID: 4194
	private static double 19;

	// Token: 0x020003E9 RID: 1001
	private static class 264
	{
		// Token: 0x06001FA6 RID: 8102 RVA: 0x0008298C File Offset: 0x00080B8C
		private static int 1()
		{
			string environmentVariable = Environment.GetEnvironmentVariable("OSU_OFFLINE_SMOKE_CASE_LIMIT");
			if (environmentVariable == null)
			{
				return 263.264.3.Length;
			}
			int num;
			if (!int.TryParse(environmentVariable, out num) || num < 1 || num > 263.264.3.Length)
			{
				throw new InvalidOperationException("Diagnostic case limit must be between one and five.");
			}
			return num;
		}

		// Token: 0x06001FA7 RID: 8103 RVA: 0x000829D4 File Offset: 0x00080BD4
		private static int 2()
		{
			string environmentVariable = Environment.GetEnvironmentVariable("OSU_OFFLINE_SMOKE_CASE_START");
			if (environmentVariable == null)
			{
				return 0;
			}
			int num;
			if (!int.TryParse(environmentVariable, out num) || num < 0 || num >= 263.264.6)
			{
				throw new InvalidOperationException("Diagnostic case start must be a zero-based index below the case limit.");
			}
			return num;
		}

		// Token: 0x06001FA8 RID: 8104 RVA: 0x00082A14 File Offset: 0x00080C14
		private static void 3(2149 1, string 2, 2034 3)
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>
			{
				{
					"scenario",
					263.264.5[263.264.12]
				},
				{
					"retry",
					263.264.17
				},
				{
					"clockMilliseconds",
					1226.16
				},
				{
					"resultCode",
					(int)1
				},
				{
					"comboCode",
					2
				},
				{
					"objectType",
					(3 == null) ? null : 3.GetType().Name
				}
			};
			if (3 != null)
			{
				dictionary["startMilliseconds"] = 3.1;
				dictionary["endMilliseconds"] = 3.2;
				dictionary["objectIndex"] = 263.264.10.34.IndexOf(3);
				dictionary["judged"] = 3.11;
				2123 4 = 3 as 2123;
				if (4 != null)
				{
					dictionary["sliderCollected"] = 4.76;
					dictionary["sliderRequired"] = 4.83.Count + 1;
					dictionary["sliderHeadResult"] = (int)4.58.14;
				}
				2129 5 = 3 as 2129;
				if (5 != null)
				{
					dictionary["spinnerRequiredHalfTurns"] = 5.49;
					dictionary["spinnerActualHalfTurns"] = 263.Get(typeof(2129), 5, "ScoredHalfTurns");
					dictionary["spinnerMinimumHalfTurns"] = 263.Invoke(typeof(2129), 5, "GetMinimumHalfTurns", Array.Empty<object>());
				}
			}
			263.264.9.Add(dictionary);
		}

		// Token: 0x06001FA9 RID: 8105 RVA: 0x00082BD0 File Offset: 0x00080DD0
		internal static bool 4(out 1087 1)
		{
			1 = default(1087);
			if ((263.264.12 != 3 && 263.264.12 != 4) || 263.264.13 < 20 || 263.264.13 > 25 || 1662.78 != 1677.Play)
			{
				return false;
			}
			if (263.264.12 == 3)
			{
				return true;
			}
			if (2486.13 || 2486.83)
			{
				return true;
			}
			int num = 1226.16;
			int i = 0;
			while (i < 12)
			{
				int num2 = 1000 + i * 750;
				if (num >= num2 - 15 && num <= num2 + 100)
				{
					200 2 = 1548.8((i % 2 == 0) ? 1532.OsuLeft : 1532.OsuRight);
					1.1((int)2);
					int[] array = new int[]
					{
						128,
						256,
						384,
						128,
						256,
						384
					};
					int[] array2 = new int[]
					{
						128,
						256,
						128,
						256,
						128,
						256
					};
					208 3 = new 208((float)array[i % 6], (float)array2[i % 6]);
					208 4 = 1662.69.17(3);
					1555.14(4);
					1535.6 = 4;
					1535.34 = 3;
					if (263.264.11[i])
					{
						break;
					}
					263.264.11[i] = true;
					if (i % 2 == 0)
					{
						263.264.22++;
						break;
					}
					263.264.23++;
					break;
				}
				else
				{
					i++;
				}
			}
			return true;
		}

		// Token: 0x06001FAA RID: 8106 RVA: 0x00082D08 File Offset: 0x00080F08
		internal static void 5()
		{
			1677 <<EMPTY_NAME>> = 1662.78;
			2462 2 = 1662.79;
			bool flag = Convert.ToInt32(1662.76) == 2;
			if (263.264.13 == 0)
			{
				if (263.5.Elapsed.TotalSeconds < 3.0 || <<EMPTY_NAME>> != 1677.Menu || 2 == null || !flag)
				{
					return;
				}
				263.13("scenarioResults", 263.264.1);
				263.13("scenarioLimit", 263.264.6);
				263.13("scenarioStart", 263.264.7);
				263.13("clockSamples", 263.264.2);
				263.13("frameSamples", 263.264.8);
				263.13("objectJudgements", 263.264.9);
				263.14("suite-menu-ready", "Beginning editor roundtrip, native audio and repeated-play regression suite.");
				1662.SetMode(1677.SelectPlay, false);
				263.264.13 = 1;
				return;
			}
			else if (263.264.13 == 1)
			{
				if (<<EMPTY_NAME>> != 1677.SelectPlay || !(2 is 2601) || !flag || 1272.3.Count == 0)
				{
					return;
				}
				string path = "Offline Recovery - Training (Offline) [" + 263.264.3[263.264.12] + "].osu";
				263.9 = Path.Combine(Environment.CurrentDirectory, "Songs", "Offline Recovery Test", path);
				1262 3 = 263.5(263.9, 263.264.4[263.264.12]);
				if (3.65 != 263.264.4[263.264.12])
				{
					throw new InvalidOperationException("Fixture parser count mismatch for " + 263.264.5[263.264.12]);
				}
				263.14 = 3;
				1272.SetCurrentBeatmap(3);
				1272.LoadTrackFor(3);
				263.13("currentScenario", 263.264.5[263.264.12]);
				263.14("suite-enter-editor", 263.264.5[263.264.12] + ": parsed " + 263.264.4[263.264.12].ToString() + " objects; opening the real editor.");
				1662.SetMode(1677.Edit, false);
				263.264.13 = 10;
				return;
			}
			else if (263.264.13 == 10)
			{
				if (<<EMPTY_NAME>> != 1677.Edit || 2 == null || 2.GetType().Name != "BeatmapEditorScreen" || !flag)
				{
					return;
				}
				object obj = 263.Get(2.GetType(), 2, "hitObjectManager");
				if (obj == null || Convert.ToInt32(263.Get(obj.GetType(), obj, "HitObjectCount")) == 0)
				{
					return;
				}
				if (263.264.12 == 263.264.7 && Environment.GetEnvironmentVariable("OSU_OFFLINE_SMOKE_SLIDER_BUILD") == "1")
				{
					263.13("sliderPathConstruction", 263.18((2039)obj));
				}
				if (263.264.12 == 263.264.7 && Environment.GetEnvironmentVariable("OSU_OFFLINE_SMOKE_SLIDER_JUDGEMENT") == "1")
				{
					263.13("sliderJudgementChecks", 263.20((2039)obj));
				}
				if (263.264.12 == 263.264.7 && Environment.GetEnvironmentVariable("OSU_OFFLINE_SMOKE_SLIDER_EDIT") == "1")
				{
					263.13("sliderEditingChecks", 263.19((2039)obj));
				}
				if (263.264.12 == 263.264.7 && Environment.GetEnvironmentVariable("OSU_OFFLINE_SMOKE_SLIDER_LIFECYCLE") == "1")
				{
					263.13("sliderLifecycleChecks", 263.21((2039)obj));
				}
				if (263.264.12 == 263.264.7 && Environment.GetEnvironmentVariable("OSU_OFFLINE_SMOKE_GAMEPLAY_CORE") == "1")
				{
					263.13("gameplayScoringAndLocking", 263.17((2039)obj));
				}
				263.264.20 = 2;
				int num = 263.264.8();
				263.13("editorHandlersWhileOpen", num);
				if (num != 1)
				{
					throw new InvalidOperationException("Editor has " + num.ToString() + " live keyboard handlers; expected exactly one.");
				}
				263.264.21 = 1548.8(1532.JumpToBegin);
				if (263.264.21 == 200.None)
				{
					throw new InvalidOperationException("JumpToBegin input binding is absent.");
				}
				1549.7(263.264.21);
				1549.8(263.264.21);
				263.14("suite-editor-key-routed", "Dispatched the bound editor JumpToBegin key through the real keyboard dispatcher.");
				if (!((2263)2).32())
				{
					throw new InvalidOperationException("Normal editor exit did not complete for an unedited fixture.");
				}
				263.14("suite-editor-normal-exit", "Used the editor's real TryLeaveEditor exit route.");
				263.264.13 = 13;
				return;
			}
			else if (263.264.13 == 13)
			{
				if (<<EMPTY_NAME>> != 1677.SelectEdit || !flag)
				{
					return;
				}
				263.264.9();
				if (!263.264.10("editor-return-selection"))
				{
					return;
				}
				1662.SetMode(1677.Menu, false);
				263.264.13 = 11;
				return;
			}
			else if (263.264.13 == 11)
			{
				if (<<EMPTY_NAME>> != 1677.Menu || !flag)
				{
					return;
				}
				263.264.9();
				1549.7(263.264.21);
				1549.8(263.264.21);
				1549.7(200.X);
				1549.8(200.X);
				if (!263.264.10("menu-after-editor"))
				{
					return;
				}
				263.14("suite-editor-closed", "Editor disposed, no editor keyboard target remains, and the same key routes safely on the menu.");
				1662.SetMode(1677.SelectPlay, false);
				263.264.13 = 12;
				return;
			}
			else if (263.264.13 == 12)
			{
				if (<<EMPTY_NAME>> != 1677.SelectPlay || !(2 is 2601) || !flag)
				{
					return;
				}
				1262 currentBeatmap = (1262)263.14;
				1272.SetCurrentBeatmap(currentBeatmap);
				1272.LoadTrackFor(currentBeatmap);
				2019.1 = ((263.264.12 >= 3) ? 2023.NoFail : 2023.Autoplay);
				if (263.264.12 == 4)
				{
					if (1548.8(1532.OsuLeft) == 200.None || 1548.8(1532.OsuRight) == 200.None)
					{
						throw new InvalidOperationException("Positive input fixture requires both configured osu keys.");
					}
					for (int i = 0; i < Application.OpenForms.Count; i++)
					{
						if (Application.OpenForms[i].Visible)
						{
							Application.OpenForms[i].Activate();
						}
					}
				}
				263.15 = null;
				263.264.18 = false;
				263.264.14 = int.MinValue;
				263.264.15 = 2500;
				263.264.16 = 0;
				263.264.17 = false;
				263.264.24 = false;
				263.264.27 = false;
				263.Invoke(2.GetType(), 2, "StartPlay", Array.Empty<object>());
				263.14("suite-play-requested", 263.264.5[263.264.12] + ": real song-selection start handler invoked.");
				263.264.13 = 20;
				return;
			}
			else if (263.264.13 == 21)
			{
				if (<<EMPTY_NAME>> != 1677.Play || !flag || 263.264.19 == 2)
				{
					return;
				}
				if (1226.16 > 1500)
				{
					throw new InvalidOperationException("Retry did not reset the gameplay clock.");
				}
				263.264.18 = false;
				263.264.14 = int.MinValue;
				263.15 = null;
				263.264.15 = 2500;
				263.14("suite-retry-reinitialized", "Retry created a fresh player and reset the audio/gameplay clock.");
				263.264.13 = 20;
				return;
			}
			else if (263.264.13 == 22)
			{
				if (!2486.13)
				{
					return;
				}
				263.264.25 = 1226.16;
				263.264.26 = 263.5.Elapsed.TotalSeconds;
				263.14("suite-paused", "Real player pause froze native audio at " + 263.264.25.ToString() + " ms.");
				263.264.13 = 23;
				return;
			}
			else if (263.264.13 == 23)
			{
				if (Math.Abs(1226.16 - 263.264.25) > 50)
				{
					throw new InvalidOperationException("Audio/gameplay clock advanced while paused.");
				}
				if (263.5.Elapsed.TotalSeconds - 263.264.26 < 1.5)
				{
					return;
				}
				((2486)2).RequestPauseToggle();
				263.264.26 = 263.5.Elapsed.TotalSeconds;
				263.264.13 = 24;
				return;
			}
			else if (263.264.13 == 24)
			{
				if (2486.13 || 263.5.Elapsed.TotalSeconds - 263.264.26 < 0.7)
				{
					return;
				}
				object obj2 = 263.Get(typeof(2486), 2, "_resumeCursor");
				263.Invoke(typeof(2486), 2, "HandleResumeCursorClicked", new object[]
				{
					obj2,
					EventArgs.Empty
				});
				263.264.13 = 25;
				return;
			}
			else if (263.264.13 == 25)
			{
				if (2486.83 || 1226.16 < 263.264.25 + 100)
				{
					return;
				}
				263.264.24 = true;
				263.14("suite-resumed", "Real click-to-resume callback released pause and native audio continued.");
				263.264.13 = 20;
				return;
			}
			else
			{
				if (263.264.13 != 20)
				{
					return;
				}
				if (<<EMPTY_NAME>> == 1677.Play)
				{
					2486 4 = 2 as 2486;
					if (4 == null || 4.39 == null || 4.39.35 == 0)
					{
						return;
					}
					if (!263.264.18)
					{
						if (4.39.35 != 263.264.4[263.264.12])
						{
							throw new InvalidOperationException("Player hit-object count mismatch.");
						}
						1240 5 = 1226.31;
						if (!(5 is 1241) || 5.2() == 0)
						{
							throw new InvalidOperationException("Fixture is not using a live native BASS audio stream; fallback clocks cannot validate playback.");
						}
						if (263.264.10 != null)
						{
							2039 6 = 263.264.10;
							2039.2041 7;
							if ((7 = 263.264.<>O.<0>__ObserveJudgement) == null)
							{
								7 = (263.264.<>O.<0>__ObserveJudgement = new 2039.2041(263.264.3));
							}
							6.31(7);
						}
						263.264.10 = 4.39;
						2039 8 = 263.264.10;
						2039.2041 9;
						if ((9 = 263.264.<>O.<0>__ObserveJudgement) == null)
						{
							9 = (263.264.<>O.<0>__ObserveJudgement = new 2039.2041(263.264.3));
						}
						8.30(9);
						263.264.9();
						263.264.18 = true;
						263.13 = true;
						263.14("suite-native-gameplay", 263.264.5[263.264.12] + ": actual player loaded " + 263.264.4[263.264.12].ToString() + " objects using native BASS.");
					}
					int num2 = 1226.16;
					if (!263.264.27 && num2 > 3500 && flag)
					{
						263.264.27 = 263.264.10("gameplay-" + 263.264.5[263.264.12]);
					}
					263.9();
					int num3 = 263.10("Count300") + 263.10("Count100") + 263.10("Count50") + 263.10("CountMiss");
					if (num3 > 263.264.4[263.264.12])
					{
						throw new InvalidOperationException("Repeated judgements exceed fixture object count.");
					}
					if (263.264.14 != -2147483648 && num2 < 263.264.14 - 100)
					{
						throw new InvalidOperationException(string.Concat(new string[]
						{
							"Gameplay clock jumped backwards: ",
							263.264.14.ToString(),
							" -> ",
							num2.ToString(),
							" ms."
						}));
					}
					263.264.2.Add(new Dictionary<string, object>
					{
						{
							"scenario",
							263.264.5[263.264.12]
						},
						{
							"retry",
							263.264.17
						},
						{
							"elapsedSeconds",
							263.5.Elapsed.TotalSeconds
						},
						{
							"clockMilliseconds",
							num2
						},
						{
							"judgements",
							num3
						}
					});
					263.264.14 = num2;
					if (263.264.12 == 4 && !263.264.24 && num2 >= 4250 && flag)
					{
						((2486)2).RequestPauseToggle();
						263.264.13 = 22;
						return;
					}
					if (263.264.12 == 2 && !263.264.17 && num2 >= 4000 && flag)
					{
						263.264.19 = 2;
						263.264.17 = true;
						263.14("suite-retry-requested", "Invoking the real retry route after 4 seconds of mixed-object gameplay.");
						2486.83(false);
						263.264.13 = 21;
						return;
					}
					if (num2 >= 263.264.15 && flag)
					{
						263.264.9();
						1549.7(263.264.21);
						1549.8(263.264.21);
						1549.7(200.X);
						1549.8(200.X);
						if (1226.16 < num2 - 100)
						{
							throw new InvalidOperationException("A retired editor input handler reset the gameplay clock.");
						}
						263.264.15 = num2 + 1000;
						263.264.16++;
						263.13("gameplayEditorKeyPresses", 263.264.16);
					}
					return;
				}
				else
				{
					if (<<EMPTY_NAME>> != 1677.Rank || !flag || !263.264.18)
					{
						return;
					}
					if (!263.264.10("results-" + 263.264.5[263.264.12]))
					{
						return;
					}
					263.9();
					int num4 = 263.10("Count300");
					int num5 = 263.10("Count100");
					int num6 = 263.10("Count50");
					int num7 = 263.10("CountMiss");
					bool flag2 = (263.264.12 == 3) ? (num4 == 0 && num5 == 0 && num6 == 0 && num7 == 263.264.4[263.264.12]) : (num4 == 263.264.4[263.264.12] && num5 == 0 && num6 == 0 && num7 == 0);
					263.264.1.Add(new Dictionary<string, object>
					{
						{
							"scenario",
							263.264.5[263.264.12]
						},
						{
							"passed",
							flag2
						},
						{
							"expectedObjects",
							263.264.4[263.264.12]
						},
						{
							"great300",
							num4
						},
						{
							"good100",
							num5
						},
						{
							"meh50",
							num6
						},
						{
							"miss",
							num7
						},
						{
							"editorKeyPresses",
							263.264.16
						},
						{
							"retry",
							263.264.17
						},
						{
							"nativeAudio",
							true
						}
					});
					if (263.264.12 == 4)
					{
						263.13("positiveInput", new Dictionary<string, object>
						{
							{
								"leftKeyNotes",
								263.264.22
							},
							{
								"rightKeyNotes",
								263.264.23
							},
							{
								"pauseResume",
								263.264.24
							},
							{
								"physicalKeyboardPollingBypassed",
								true
							}
						});
						if (263.264.22 != 6 || 263.264.23 != 6 || !263.264.24 || 1535.1() || (2019.1 & 2023.Autoplay) != 2023.None)
						{
							throw new InvalidOperationException("Positive input scenario did not exercise both keys and pause/resume without Autoplay or replay.");
						}
					}
					263.14("suite-results", string.Concat(new string[]
					{
						263.264.5[263.264.12],
						": ",
						num4.ToString(),
						" great, ",
						num5.ToString(),
						" good, ",
						num6.ToString(),
						" meh, ",
						num7.ToString(),
						" miss."
					}));
					if (!flag2)
					{
						throw new InvalidOperationException("Recovered result judgements differ from expected " + 263.264.5[263.264.12] + " outcome.");
					}
					if (263.264.16 < 1)
					{
						throw new InvalidOperationException("Gameplay completed without testing the retired editor key route.");
					}
					263.264.12++;
					if (263.264.12 == 263.264.6)
					{
						263.264.6();
						263.Finish(true, (263.264.7 == 0 && 263.264.6 == 263.264.3.Length) ? "Five editor/menu/play roundtrips completed; mixed objects, retry, native audio, NoFail misses, alternating input-snapshot hits and pause/resume verified without clock reset or duplicate judgements." : ((263.264.6 - 263.264.7).ToString() + " targeted editor/menu/play roundtrips completed; this is not the full regression suite."), false);
						return;
					}
					1662.SetMode(1677.SelectPlay, false);
					263.264.13 = 1;
					return;
				}
			}
		}

		// Token: 0x06001FAB RID: 8107 RVA: 0x00083B90 File Offset: 0x00081D90
		private static void 6()
		{
			if (!1662.11.17.1(false))
			{
				throw new InvalidOperationException("Recovered background save failed.");
			}
			2230.4();
			2230.17(true);
			263.19 = double.NegativeInfinity;
			263.8();
			string text = 1345.4();
			List<Dictionary<string, object>> value = new List<Dictionary<string, object>>();
			string[] files = Directory.GetFiles(text, "osu!*.cfg", SearchOption.TopDirectoryOnly);
			if (files.Length < 2)
			{
				throw new InvalidOperationException("Recovered save did not create both shared and user configuration files.");
			}
			string[] array = files;
			for (int i = 0; i < array.Length; i++)
			{
				263.264.7(array[i], 1L, value);
			}
			263.264.7(Path.Combine(text, "osu!.db"), 8L, value);
			string path = Path.Combine(text, "scores.db");
			263.264.7(path, 8L, value);
			int num = 0;
			foreach (KeyValuePair<string, List<2241>> keyValuePair in 2230.4)
			{
				num += keyValuePair.Value.Count;
			}
			if (num == 0)
			{
				throw new InvalidOperationException("Ordinary gameplay completed without a persistent local score entry.");
			}
			using (BinaryReader binaryReader = new BinaryReader(File.OpenRead(path)))
			{
				int num2 = binaryReader.ReadInt32();
				int num3 = binaryReader.ReadInt32();
				if (num2 != 1296.11 || num3 != 2230.4.Count)
				{
					throw new InvalidOperationException("Persisted score database header differs from the recovered in-memory database.");
				}
				263.13("persistentSave", new Dictionary<string, object>
				{
					{
						"files",
						value
					},
					{
						"scoreEntries",
						num
					},
					{
						"scoreGroups",
						num3
					},
					{
						"scoreDatabaseVersion",
						num2
					},
					{
						"ordinarySaverSucceeded",
						true
					}
				});
			}
			263.14("suite-persistent-save", "Ordinary recovered saver persisted configuration, beatmap database and " + num.ToString() + " local scores.");
		}

		// Token: 0x06001FAC RID: 8108 RVA: 0x00083D88 File Offset: 0x00081F88
		private static void 7(string 1, long 2, List<Dictionary<string, object>> 3)
		{
			FileInfo fileInfo = new FileInfo(1);
			if (!fileInfo.Exists || fileInfo.Length < 2 || fileInfo.LastWriteTimeUtc < 263.18)
			{
				throw new InvalidOperationException("Recovered saver did not write a current nonempty file: " + 1);
			}
			3.Add(new Dictionary<string, object>
			{
				{
					"name",
					fileInfo.Name
				},
				{
					"bytes",
					fileInfo.Length
				},
				{
					"lastWriteUtc",
					fileInfo.LastWriteTimeUtc.ToString("o")
				}
			});
		}

		// Token: 0x06001FAD RID: 8109 RVA: 0x00083E20 File Offset: 0x00082020
		private static int 8()
		{
			Delegate @delegate = 263.Get(typeof(1549), null, "_keyChangedHandlers") as Delegate;
			if (@delegate == null)
			{
				return 0;
			}
			int num = 0;
			foreach (Delegate delegate2 in @delegate.GetInvocationList())
			{
				if (delegate2.Target != null && delegate2.Target.GetType().Name == "BeatmapEditorScreen")
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x06001FAE RID: 8110 RVA: 0x00083E94 File Offset: 0x00082094
		private static void 9()
		{
			int num = 263.264.8();
			263.13("editorHandlersAfterClose", num);
			if (num != 0)
			{
				throw new InvalidOperationException("Disposed editor retained " + num.ToString() + " keyboard handlers.");
			}
			Delegate @delegate = 263.Get(typeof(1549), null, "_keyChangedHandlers") as Delegate;
			if (@delegate != null)
			{
				Delegate[] invocationList = @delegate.GetInvocationList();
				for (int i = 0; i < invocationList.Length; i++)
				{
					if (invocationList[i].Target == 263.264.20)
					{
						throw new InvalidOperationException("Disposed editor delegate target remains registered.");
					}
				}
			}
		}

		// Token: 0x06001FAF RID: 8111 RVA: 0x00083F24 File Offset: 0x00082124
		private static bool 10(string 1)
		{
			if (string.IsNullOrEmpty(GL.GetString(7938)))
			{
				263.264.8.Add(new Dictionary<string, object>
				{
					{
						"stage",
						1
					},
					{
						"available",
						false
					},
					{
						"reason",
						"No current GL context on timer thread."
					}
				});
				return 263.264.28 == null || 263.264.11(1);
			}
			int[] array = new int[4];
			GL.GetInteger(2978, array);
			int num = array[2];
			int num2 = array[3];
			if (num <= 0 || num2 <= 0 || (long)num * (long)num2 > 20000000L)
			{
				throw new InvalidOperationException("Invalid gameplay framebuffer dimensions.");
			}
			byte[] array2 = new byte[num * num2 * 4];
			int integer = GL.GetInteger(3074);
			string value = GL.GetError().ToString();
			string text;
			try
			{
				GL.ReadBuffer(1028);
				GL.ReadPixels<byte>(array[0], array[1], num, num2, 6408, 5121, array2);
				text = GL.GetError().ToString();
			}
			finally
			{
				GL.ReadBuffer(integer);
			}
			int num3 = 0;
			for (int i = 0; i < array2.Length; i += 16)
			{
				if (array2[i] > 8 || array2[i + 1] > 8 || array2[i + 2] > 8)
				{
					num3++;
				}
			}
			Form form = (Application.OpenForms.Count == 0) ? null : Application.OpenForms[0];
			263.264.8.Add(new Dictionary<string, object>
			{
				{
					"stage",
					1
				},
				{
					"available",
					true
				},
				{
					"width",
					num
				},
				{
					"height",
					num2
				},
				{
					"sampledNonblackPixels",
					num3
				},
				{
					"elapsedSeconds",
					263.5.Elapsed.TotalSeconds
				},
				{
					"blackDurationSeconds",
					(263.264.28 == null) ? 0.0 : (263.5.Elapsed.TotalSeconds - 263.264.29)
				},
				{
					"windowState",
					(form == null) ? null : form.WindowState.ToString()
				},
				{
					"windowVisible",
					form != null && form.Visible
				},
				{
					"windowFocused",
					form != null && form.ContainsFocus
				},
				{
					"priorGlError",
					value
				},
				{
					"readGlError",
					text
				}
			});
			if (text != "NoError")
			{
				throw new InvalidOperationException(string.Concat(new string[]
				{
					"Framebuffer capture failed with ",
					text,
					" at ",
					1,
					"."
				}));
			}
			if (num3 < 20 && form != null && (!form.Visible || form.WindowState == FormWindowState.Minimized || !form.ContainsFocus))
			{
				throw new InvalidOperationException("Cannot verify displayed frame at " + 1 + ": regression window is hidden, minimized or unfocused.");
			}
			if (num3 < 20)
			{
				return 263.264.11(1);
			}
			263.264.28 = null;
			return true;
		}

		// Token: 0x06001FB0 RID: 8112 RVA: 0x00084264 File Offset: 0x00082464
		private static bool 11(string 1)
		{
			if (263.264.28 == null)
			{
				263.264.28 = 1;
				263.264.29 = 263.5.Elapsed.TotalSeconds;
			}
			if (263.5.Elapsed.TotalSeconds - 263.264.29 >= 2.0)
			{
				throw new InvalidOperationException("Displayed framebuffer remained black for two seconds after " + 263.264.28 + ".");
			}
			return false;
		}

		// Token: 0x04001063 RID: 4195
		private static readonly List<Dictionary<string, object>> 1 = new List<Dictionary<string, object>>();

		// Token: 0x04001064 RID: 4196
		private static readonly List<Dictionary<string, object>> 2 = new List<Dictionary<string, object>>();

		// Token: 0x04001065 RID: 4197
		private static readonly string[] 3 = new string[]
		{
			"Standard",
			"Mixed",
			"Mixed",
			"Mixed",
			"Input"
		};

		// Token: 0x04001066 RID: 4198
		private static readonly int[] 4 = new int[]
		{
			30,
			12,
			12,
			12,
			12
		};

		// Token: 0x04001067 RID: 4199
		private static readonly string[] 5 = new string[]
		{
			"editor-menu-circles",
			"editor-menu-mixed",
			"mixed-retry",
			"nofail-misses",
			"input-snapshot-hits-pause"
		};

		// Token: 0x04001068 RID: 4200
		private static readonly int 6 = 263.264.1();

		// Token: 0x04001069 RID: 4201
		private static readonly int 7 = 263.264.2();

		// Token: 0x0400106A RID: 4202
		private static readonly List<Dictionary<string, object>> 8 = new List<Dictionary<string, object>>();

		// Token: 0x0400106B RID: 4203
		private static readonly List<Dictionary<string, object>> 9 = new List<Dictionary<string, object>>();

		// Token: 0x0400106C RID: 4204
		private static 2039 10;

		// Token: 0x0400106D RID: 4205
		private static readonly bool[] 11 = new bool[12];

		// Token: 0x0400106E RID: 4206
		private static int 12 = 263.264.7;

		// Token: 0x0400106F RID: 4207
		private static int 13;

		// Token: 0x04001070 RID: 4208
		private static int 14 = int.MinValue;

		// Token: 0x04001071 RID: 4209
		private static int 15;

		// Token: 0x04001072 RID: 4210
		private static int 16;

		// Token: 0x04001073 RID: 4211
		private static bool 17;

		// Token: 0x04001074 RID: 4212
		private static bool 18;

		// Token: 0x04001075 RID: 4213
		private static 2462 19;

		// Token: 0x04001076 RID: 4214
		private static object 20;

		// Token: 0x04001077 RID: 4215
		private static 200 21;

		// Token: 0x04001078 RID: 4216
		private static int 22;

		// Token: 0x04001079 RID: 4217
		private static int 23;

		// Token: 0x0400107A RID: 4218
		private static bool 24;

		// Token: 0x0400107B RID: 4219
		private static int 25;

		// Token: 0x0400107C RID: 4220
		private static double 26;

		// Token: 0x0400107D RID: 4221
		private static bool 27;

		// Token: 0x0400107E RID: 4222
		private static string 28;

		// Token: 0x0400107F RID: 4223
		private static double 29;

		// Token: 0x020003EA RID: 1002
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04001080 RID: 4224
			public static 2039.2041 <0>__ObserveJudgement;
		}
	}

	// Token: 0x020003EB RID: 1003
	private static class 266
	{
		// Token: 0x06001FB2 RID: 8114 RVA: 0x000843BC File Offset: 0x000825BC
		internal static void 1()
		{
			object <<EMPTY_NAME>> = 1662.79;
			bool flag = <<EMPTY_NAME>> != null && Convert.ToInt32(1662.76) == 2;
			if (263.266.9 == null)
			{
				263.266.9 = Environment.GetEnvironmentVariable("OSU_OFFLINE_LOCAL_TEST_ID");
				if (!string.IsNullOrEmpty(263.266.9))
				{
					if (263.266.9.All((char 1) => char.IsLetterOrDigit(1)))
					{
						263.13("fixtureId", 263.266.9);
						goto IL_86;
					}
				}
				throw new InvalidOperationException("Local workflow test requires an alphanumeric fixture ID.");
			}
			IL_86:
			if (263.266.1 == 0)
			{
				if (!flag || 1662.78 != 1677.Menu || 263.5.Elapsed.TotalSeconds < 3.0)
				{
					return;
				}
				1662.SetMode(1677.SelectPlay, false);
				263.266.Next("selection-requested");
				return;
			}
			else if (263.266.1 == 1)
			{
				if (!flag || 1662.78 != 1677.SelectPlay)
				{
					return;
				}
				263.266.3 = 263.266.3("Screenshots", "screenshot*.*").Length;
				1549.3 = (263.266.6 == 1);
				try
				{
					if (!1662.83(null, 1548.8(1532.Screenshot)))
					{
						throw new InvalidOperationException("Screenshot binding was not handled.");
					}
				}
				finally
				{
					1549.3 = false;
				}
				263.266.Next("screenshot-requested");
				return;
			}
			else if (263.266.1 == 2)
			{
				if (263.266.3("Screenshots", "screenshot*.*").Length <= 263.266.3)
				{
					return;
				}
				1489 2 = 263.266.5();
				if (2 == null || !2.1.StartsWith("Saved screenshot to ") || 2.5.Count == 0)
				{
					return;
				}
				string item = 2.1.Substring("Saved screenshot to ".Length);
				263.266.4(item, "Screenshots");
				263.266.14.Add(item);
				263.13("screenshotNotificationPaths", 263.266.14);
				263.266.7(2);
				263.266.Next("screenshot-popup-clicked");
				return;
			}
			else if (263.266.1 == 3)
			{
				if (263.5.Elapsed.TotalSeconds - 263.266.2 < 2.0 || !263.266.8("screenshot-popup"))
				{
					return;
				}
				if (++263.266.6 < 3)
				{
					263.266.1 = 1;
					return;
				}
				263.14("screenshot-popup-passed", "Three real F12 captures and notification click callbacks remained rendered.");
				263.Invoke(typeof(1784), 1662.104, "OpenGameFolder", new object[]
				{
					null,
					EventArgs.Empty
				});
				263.266.Next("game-folder-requested");
				return;
			}
			else if (263.266.1 == 4)
			{
				if (263.5.Elapsed.TotalSeconds - 263.266.2 < 2.0 || !263.266.8("game-folder-action"))
				{
					return;
				}
				263.14("waiting-visible-additions", "Parent must now add a new beatmap and skin to the visible game folder.");
				263.266.Next("awaiting-live-files");
				return;
			}
			else if (263.266.1 == 5)
			{
				if (!File.Exists(Path.Combine("Songs", "Live Workflow " + 263.266.9, "Live F5.osu")) || !File.Exists(Path.Combine("Skins", "Live Skin " + 263.266.9, "skin.ini")))
				{
					return;
				}
				if (!flag)
				{
					return;
				}
				if (!1549.7(200.F5))
				{
					throw new InvalidOperationException("F5 rescan was not handled.");
				}
				263.266.Next("f5-dispatched");
				return;
			}
			else if (263.266.1 == 6)
			{
				if (!flag || 1662.78 != 1677.SelectPlay || !263.266.6("Live F5.osu"))
				{
					return;
				}
				263.14("f5-import-passed", "New visible-folder beatmap reached the live imported database after real F5.");
				1549.1 = (1549.2 = (1549.3 = true));
				try
				{
					if (!1662.83(null, 200.S))
					{
						throw new InvalidOperationException("Skin reload chord was not handled.");
					}
				}
				finally
				{
					1549.1 = (1549.2 = (1549.3 = false));
				}
				263.266.Next("skin-reload-dispatched");
				return;
			}
			else if (263.266.1 == 7)
			{
				if (!flag || 2630.8 == null || !2630.8.Contains("Live Skin " + 263.266.9))
				{
					return;
				}
				if (!263.266.8("skin-reload"))
				{
					return;
				}
				263.14("skin-reload-passed", "New visible-folder skin appeared in the normal skin list after Ctrl+Alt+Shift+S.");
				1662.SetMode(1677.Menu, false);
				263.266.Next("menu-for-reentry");
				return;
			}
			else if (263.266.1 == 8)
			{
				if (!flag || 1662.78 != 1677.Menu)
				{
					return;
				}
				if (1272.15 == null)
				{
					throw new InvalidOperationException("Song watcher is absent.");
				}
				263.266.13 = 1272.15.EnableRaisingEvents;
				1272.15.EnableRaisingEvents = false;
				263.14("waiting-reentry-addition", "Parent must add a second beatmap while song selection is closed.");
				263.266.Next("awaiting-reentry-file");
				return;
			}
			else if (263.266.1 == 9)
			{
				if (!File.Exists(Path.Combine("Songs", "Live Workflow " + 263.266.9, "Live Reentry.osu")))
				{
					return;
				}
				2630.7();
				if (!2463.1())
				{
					throw new InvalidOperationException("Skin refresh consumed the map change without preserving a pending scan.");
				}
				263.14("skin-refresh-before-reentry", "Normal skin enumeration preserved map rescan while native song watcher delivery was suppressed for this test.");
				1662.SetMode(1677.SelectPlay, false);
				263.266.Next("selection-reentered");
				return;
			}
			else if (263.266.1 == 10)
			{
				if (!flag || 1662.78 != 1677.SelectPlay || !263.266.6("Live Reentry.osu"))
				{
					return;
				}
				1272.15.EnableRaisingEvents = 263.266.13;
				263.14("selection-reentry-passed", "Second live-added beatmap imported on song-selection reentry.");
				if (Environment.GetEnvironmentVariable("OSU_OFFLINE_DROP_TEST") == "1")
				{
					263.14("waiting-drop-imports", "Parent coordinator must submit .osz and .osk through the native COM drop target.");
					263.266.1 = 101;
					263.266.2 = 263.5.Elapsed.TotalSeconds;
					return;
				}
				263.266.2();
				return;
			}
			else if (263.266.1 == 101)
			{
				if (263.5.Elapsed.TotalSeconds - 263.266.2 > 40.0)
				{
					throw new InvalidOperationException("Native archive drop imports did not complete.");
				}
				if (!flag || !263.266.6("Drop Map.osu") || !2630.8.Contains("ArchiveSkin_" + 263.266.9))
				{
					return;
				}
				263.14("native-drop-imports-passed", "Registered native COM target delivered .osz/.osk; original game imported the beatmap and skin.");
				1662.104.16(false);
				1662.SetMode(1677.SelectPlay, false);
				263.266.1 = 102;
				return;
			}
			else if (263.266.1 == 102)
			{
				if (!flag || 1662.78 != 1677.SelectPlay)
				{
					return;
				}
				263.266.2();
				return;
			}
			else if (263.266.1 == 100)
			{
				if (!flag || 263.5.Elapsed.TotalSeconds - 263.266.2 < 0.8)
				{
					return;
				}
				1549.1 = (1549.2 = (1549.3 = false));
				if (Environment.GetEnvironmentVariable("OSU_OFFLINE_ACTIVATE_TEST") == "1")
				{
					File.WriteAllText(Path.Combine(Path.Combine(Environment.CurrentDirectory, ".offline-local"), "focus-test.request"), 1662.13().Handle.ToInt64().ToString());
				}
				263.Invoke(<<EMPTY_NAME>>.GetType(), <<EMPTY_NAME>>, "StartPlay", Array.Empty<object>());
				263.266.1 = 11;
				263.266.2 = 263.5.Elapsed.TotalSeconds;
				263.14("failure-play-requested", "Real start handler after normal preview/selection callbacks.");
				return;
			}
			else if (263.266.1 == 11)
			{
				if (263.5.Elapsed.TotalSeconds > 263.266.12)
				{
					263.266.12 = 263.5.Elapsed.TotalSeconds + 1.0;
					2241 3 = 2486.88;
					263.13("failureDiagnostics", new Dictionary<string, object>
					{
						{
							"mode",
							1662.78.ToString()
						},
						{
							"screen",
							<<EMPTY_NAME>>.GetType().Name
						},
						{
							"paused",
							2486.13
						},
						{
							"failed",
							2486.4
						},
						{
							"clock",
							1226.16
						},
						{
							"miss",
							(3 == null) ? -1 : ((int)3.6)
						},
						{
							"mods",
							(3 == null) ? "none" : 3.8.ToString()
						},
						{
							"windowActive",
							1662.11.2()
						}
					});
				}
				if (263.5.Elapsed.TotalSeconds - 263.266.2 > 40.0)
				{
					throw new InvalidOperationException("Failed-map test did not reach a genuine miss-driven failure in 40 seconds.");
				}
				2486 4 = <<EMPTY_NAME>> as 2486;
				if (4 != null && !2486.4 && 1662.11.2())
				{
					if (2486.13)
					{
						4.RequestPauseToggle();
						return;
					}
					if (2486.83)
					{
						263.Invoke(typeof(2486), 4, "HandleResumeCursorClicked", new object[]
						{
							263.Get(typeof(2486), 4, "_resumeCursor"),
							EventArgs.Empty
						});
						return;
					}
				}
				if (1662.78 != 1677.Play || !(<<EMPTY_NAME>> is 2486) || !2486.13)
				{
					return;
				}
				if (!Convert.ToBoolean(263.Get(typeof(2486), <<EMPTY_NAME>>, "HasFailed")))
				{
					return;
				}
				if (!1549.7(200.F2))
				{
					throw new InvalidOperationException("Failed-play F2 replay save was not handled.");
				}
				263.266.Next("failed-play-f2-dispatched");
				return;
			}
			else
			{
				if (263.266.1 != 12)
				{
					if (263.266.1 == 13)
					{
						if (263.5.Elapsed.TotalSeconds - 263.266.2 < 3.0 || !263.266.8("failed-replay-popup"))
						{
							return;
						}
						263.14("failed-replay-popup-passed", "Actual missed-note failure, F2 .osr serialization and notification click stayed rendered.");
						if (Environment.GetEnvironmentVariable("OSU_OFFLINE_GL_TEST") == "1")
						{
							263.13("graphicsContextLoss", 96.Run());
							263.14("graphics-context-loss-passed", "Retained quad/sequential buffers rendered after actual nonshared context loss.");
						}
						1662.11.17.1(false);
						263.Finish(true, "Screenshot popup clicks, local game folder action, live F5/reentry beatmap imports, skin reload and failed-play F2 replay popup passed.", false);
					}
					return;
				}
				if (263.266.3("Replays", "*.osr").Length <= 263.266.4)
				{
					return;
				}
				1489 5 = 263.266.5();
				if (5 == null || 5 == 263.266.5 || 5.11 == null || 5.5.Count == 0)
				{
					return;
				}
				IEnumerable<string> source = 263.266.3("Replays", "*.osr");
				Func<string, DateTime> keySelector;
				if ((keySelector = 263.266.<>O.<0>__GetLastWriteTimeUtc) == null)
				{
					keySelector = (263.266.<>O.<0>__GetLastWriteTimeUtc = new Func<string, DateTime>(File.GetLastWriteTimeUtc));
				}
				string value = 261.2(Path.GetFullPath(source.OrderByDescending(keySelector).First<string>()));
				263.266.4(value, "Replays");
				if (!5.1.Contains(value))
				{
					throw new InvalidOperationException("Replay notification does not show its persistent game path.");
				}
				263.13("replayNotificationPath", value);
				263.266.7(5);
				263.266.Next("failed-replay-popup-clicked");
				return;
			}
		}

		// Token: 0x06001FB3 RID: 8115 RVA: 0x00084E4C File Offset: 0x0008304C
		private static void 2()
		{
			263.14 = 263.5(Path.Combine(Environment.CurrentDirectory, "Songs", "Live Workflow " + 263.266.9, "Live Fail.osu"), 24);
			1272.SetCurrentBeatmap((1262)263.14);
			1272.LoadTrackFor((1262)263.14);
			2019.1 = 2023.None;
			1304.104.2(true);
			263.266.4 = 263.266.3("Replays", "*.osr").Length;
			263.266.2 = 263.5.Elapsed.TotalSeconds;
			263.14("failure-fixture-selected", "24 real circle misses with HP drain 10 and no assisting mods.");
			263.266.1 = 100;
		}

		// Token: 0x06001FB4 RID: 8116 RVA: 0x00084EFC File Offset: 0x000830FC
		private static void Next(string 1)
		{
			263.266.1++;
			263.266.2 = 263.5.Elapsed.TotalSeconds;
			263.14(1, "Local workflow step " + 263.266.1.ToString() + ".");
		}

		// Token: 0x06001FB5 RID: 8117 RVA: 0x00084F4B File Offset: 0x0008314B
		private static string[] 3(string 1, string 2)
		{
			if (!Directory.Exists(1))
			{
				return new string[0];
			}
			return Directory.GetFiles(1, 2);
		}

		// Token: 0x06001FB6 RID: 8118 RVA: 0x00084F64 File Offset: 0x00083164
		private static void 4(string 1, string 2)
		{
			string value = Path.Combine(261.VisibleGameRoot, 2) + Path.DirectorySeparatorChar.ToString();
			if (!1.StartsWith(value, StringComparison.OrdinalIgnoreCase) || 1.StartsWith(Environment.CurrentDirectory + Path.DirectorySeparatorChar.ToString(), StringComparison.OrdinalIgnoreCase))
			{
				throw new InvalidOperationException("Saved-file notification exposes a private run path: " + 1);
			}
		}

		// Token: 0x06001FB7 RID: 8119 RVA: 0x00084FCA File Offset: 0x000831CA
		private static 1489 5()
		{
			return 263.Get(typeof(1763), null, "lastNotification") as 1489;
		}

		// Token: 0x06001FB8 RID: 8120 RVA: 0x00084FE8 File Offset: 0x000831E8
		private static bool 6(string 1)
		{
			foreach (1262 2 in 1272.3)
			{
				if (2 != null && 2.68() != null && Path.GetFileName(2.68()) == 1 && 2.68().Contains(263.266.9))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001FB9 RID: 8121 RVA: 0x0008506C File Offset: 0x0008326C
		private static void 7(1489 1)
		{
			if (2486.14)
			{
				throw new InvalidOperationException("Popup action is still blocked by active gameplay.");
			}
			if (1.11 == null)
			{
				throw new InvalidOperationException("Notification has no file-reveal action.");
			}
			199 2 = 1535.14;
			try
			{
				1535.14 = 199.Pressed;
				263.Invoke(typeof(1489), 1, "OnClick", new object[]
				{
					1.5[0],
					EventArgs.Empty
				});
			}
			finally
			{
				1535.14 = 2;
			}
			263.266.5 = 1;
		}

		// Token: 0x06001FBA RID: 8122 RVA: 0x000850FC File Offset: 0x000832FC
		private static bool 8(string 1)
		{
			if (263.266.10 != 1 || (1 == "screenshot-popup" && 263.266.6 > 0 && 263.266.11 < 263.266.2))
			{
				263.266.10 = 1;
				263.266.11 = 263.5.Elapsed.TotalSeconds;
				Form form = 1662.13();
				if (form.WindowState == FormWindowState.Minimized)
				{
					form.WindowState = FormWindowState.Normal;
				}
				form.Show();
				form.Activate();
				1662.102();
				return false;
			}
			if (263.5.Elapsed.TotalSeconds - 263.266.11 < 0.8)
			{
				return false;
			}
			int[] array = new int[4];
			GL.GetInteger(2978, array);
			int num = array[2];
			int num2 = array[3];
			if (num <= 0 || num2 <= 0 || (long)num * (long)num2 > 20000000L)
			{
				throw new InvalidOperationException("Invalid GL viewport.");
			}
			byte[] array2 = new byte[num * num2 * 4];
			int integer = GL.GetInteger(3074);
			try
			{
				GL.ReadBuffer(1028);
				GL.ReadPixels<byte>(array[0], array[1], num, num2, 6408, 5121, array2);
			}
			finally
			{
				GL.ReadBuffer(integer);
			}
			int num3 = 0;
			for (int i = 0; i < array2.Length; i += 16)
			{
				if (array2[i] > 8 || array2[i + 1] > 8 || array2[i + 2] > 8)
				{
					num3++;
				}
			}
			if (num3 >= 20)
			{
				263.266.7 = false;
				263.13("lastRenderedAction", 1);
				263.13("lastNonblackSamples", num3);
				return true;
			}
			if (!263.266.7)
			{
				263.266.7 = true;
				263.266.8 = 263.5.Elapsed.TotalSeconds;
			}
			if (263.5.Elapsed.TotalSeconds - 263.266.8 > 3.0)
			{
				throw new InvalidOperationException("Persistent black framebuffer after " + 1);
			}
			return false;
		}

		// Token: 0x04001081 RID: 4225
		private static int 1;

		// Token: 0x04001082 RID: 4226
		private static double 2;

		// Token: 0x04001083 RID: 4227
		private static int 3;

		// Token: 0x04001084 RID: 4228
		private static int 4;

		// Token: 0x04001085 RID: 4229
		private static 1489 5;

		// Token: 0x04001086 RID: 4230
		private static int 6;

		// Token: 0x04001087 RID: 4231
		private static bool 7;

		// Token: 0x04001088 RID: 4232
		private static double 8;

		// Token: 0x04001089 RID: 4233
		private static string 9;

		// Token: 0x0400108A RID: 4234
		private static string 10;

		// Token: 0x0400108B RID: 4235
		private static double 11;

		// Token: 0x0400108C RID: 4236
		private static double 12;

		// Token: 0x0400108D RID: 4237
		private static bool 13;

		// Token: 0x0400108E RID: 4238
		private static readonly List<string> 14 = new List<string>();

		// Token: 0x020003EC RID: 1004
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400108F RID: 4239
			public static Func<string, DateTime> <0>__GetLastWriteTimeUtc;
		}
	}

	// Token: 0x020003EE RID: 1006
	private sealed class 265 : 2123
	{
		// Token: 0x06001FBF RID: 8127 RVA: 0x00085310 File Offset: 0x00083510
		internal 265(2039 1) : base(1, new 208(100f, 100f), 1000, false, 1245.None, 2064.Linear, 1, 100.0, new List<208>
		{
			new 208(100f, 100f),
			new 208(200f, 100f)
		}, null, 0)
		{
			this.58 = new 2033(1);
			this.83 = new List<int>
			{
				1100,
				1200,
				1300
			};
			this.81 = new bool[3];
		}

		// Token: 0x06001FC0 RID: 8128 RVA: 0x000853BA File Offset: 0x000835BA
		internal override void PlayHitSound()
		{
			this.93++;
		}

		// Token: 0x06001FC1 RID: 8129 RVA: 0x000853CA File Offset: 0x000835CA
		internal override void StopHitSounds()
		{
			this.94++;
		}

		// Token: 0x04001092 RID: 4242
		internal int 93;

		// Token: 0x04001093 RID: 4243
		internal int 94;
	}

	// Token: 0x020003EF RID: 1007
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04001094 RID: 4244
		public static EventHandler <0>__Tick;

		// Token: 0x04001095 RID: 4245
		public static EventHandler <1>__ArmUiTimer;
	}
}
