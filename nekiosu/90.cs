using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

// Token: 0x02000039 RID: 57
[ComVisible(false)]
public sealed class 90 : IDisposable
{
	// Token: 0x06000184 RID: 388 RVA: 0x000085C6 File Offset: 0x000067C6
	public 90(int 1)
	{
		this.frameCount = 1;
		this.frameTimesMs = new double[this.frameCount];
		this.frameBuffers = new byte[this.frameCount][];
		817.av_register_all();
		this.isOpen = false;
	}

	// Token: 0x06000185 RID: 389 RVA: 0x00008603 File Offset: 0x00006803
	public bool Method9948()
	{
		return (this.readIndex > 0 && this.hasNewFrame) || this.endOfStream;
	}

	// Token: 0x06000186 RID: 390 RVA: 0x00008620 File Offset: 0x00006820
	public double GetDuration()
	{
		long duration = this.videoStream.duration;
		if (duration < 0L)
		{
			return 36000000.0;
		}
		return (double)duration * this.timeBaseSeconds * 1000.0;
	}

	// Token: 0x06000187 RID: 391 RVA: 0x0000865B File Offset: 0x0000685B
	public int GetWidth()
	{
		return this.codecContext.width;
	}

	// Token: 0x06000188 RID: 392 RVA: 0x00008668 File Offset: 0x00006868
	public int GetHeight()
	{
		return this.codecContext.height;
	}

	// Token: 0x06000189 RID: 393 RVA: 0x00008675 File Offset: 0x00006875
	public double GetCurrentFrameTime()
	{
		return this.currentFrameTime;
	}

	// Token: 0x0600018A RID: 394 RVA: 0x0000867D File Offset: 0x0000687D
	private double GetStartTime()
	{
		return (double)(1000L * this.videoStream.start_time) * this.timeBaseSeconds;
	}

	// Token: 0x0600018B RID: 395 RVA: 0x00008699 File Offset: 0x00006899
	public void Dispose()
	{
		this.ReleaseResources(true);
	}

	// Token: 0x0600018C RID: 396 RVA: 0x000086A4 File Offset: 0x000068A4
	~90()
	{
		this.ReleaseResources(false);
	}

	// Token: 0x0600018D RID: 397 RVA: 0x000086D4 File Offset: 0x000068D4
	public void ReleaseResources(bool 1)
	{
		if (this.disposed)
		{
			return;
		}
		this.disposed = true;
		if (!this.isOpen)
		{
			return;
		}
		if (this.thread != null)
		{
			this.thread.Abort();
			while (this.thread.IsAlive)
			{
				Thread.Sleep(10);
			}
		}
		try
		{
			Marshal.FreeHGlobal(this.packet);
			Marshal.FreeHGlobal(this.rgbBuffer);
		}
		catch
		{
		}
		try
		{
			817.av_free(this.rgbFrame);
			817.av_free(this.decodedFrame);
		}
		catch
		{
		}
		try
		{
			this.pinnedBytes.Free();
		}
		catch
		{
		}
		this.gotPicture = 0;
		try
		{
			817.avcodec_close(this.codecContextPtr);
			817.av_close_input_file(this.formatContextPtr);
		}
		catch
		{
		}
	}

	// Token: 0x0600018E RID: 398 RVA: 0x000087C4 File Offset: 0x000069C4
	public bool Method9955(string 1)
	{
		FileStream 2 = File.OpenRead(1);
		this.OpenStream(2);
		return true;
	}

	// Token: 0x0600018F RID: 399 RVA: 0x000087E4 File Offset: 0x000069E4
	public bool Method9955(byte[] 1)
	{
		if (1 == null || 1.Length == 0)
		{
			return false;
		}
		this.pinnedBytes = GCHandle.Alloc(1, GCHandleType.Pinned);
		IntPtr intPtr = this.pinnedBytes.AddrOfPinnedObject();
		if (this.isOpen)
		{
			return false;
		}
		this.isOpen = true;
		string text = "memory:" + intPtr.ToString() + "|" + 1.Length.ToString();
		if (817.av_open_input_file(out this.formatContextPtr, text, IntPtr.Zero, 1.Length, IntPtr.Zero) != 0)
		{
			throw new Exception("Couldn't open input file");
		}
		if (817.av_find_stream_info(this.formatContextPtr) < 0)
		{
			throw new Exception("Couldn't find stream info");
		}
		817.dump_format(this.formatContextPtr, 0, text, 0);
		this.formatContext = (817.820)Marshal.PtrToStructure(this.formatContextPtr, typeof(817.820));
		this.videoStreamIndex = -1;
		int nb_streams = this.formatContext.nb_streams;
		for (int i = 0; i < nb_streams; i++)
		{
			817.824 2 = (817.824)Marshal.PtrToStructure(this.formatContext.streams[i], typeof(817.824));
			817.818 3 = (817.818)Marshal.PtrToStructure(2.codec, typeof(817.818));
			if (3.codec_type == 817.826.CODEC_TYPE_VIDEO)
			{
				this.videoStreamIndex = i;
				this.videoStream = 2;
				this.codecContext = 3;
				this.codecContextPtr = this.videoStream.codec;
				break;
			}
		}
		if (this.videoStreamIndex == -1)
		{
			throw new Exception("couldn't find video stream");
		}
		this.timeBaseSeconds = 817.Method14387(this.videoStream.time_base);
		this.decoder = 817.avcodec_find_decoder(this.codecContext.codec_id);
		if (this.decoder == IntPtr.Zero)
		{
			throw new Exception("couldn't find decoder");
		}
		if (817.avcodec_open(this.codecContextPtr, this.decoder) < 0)
		{
			throw new Exception("couldn't open codec");
		}
		this.decodedFrame = 817.avcodec_alloc_frame();
		this.rgbFrame = 817.avcodec_alloc_frame();
		if (this.rgbFrame == IntPtr.Zero)
		{
			throw new Exception("couldn't allocate RGB frame");
		}
		int cb = 817.avpicture_get_size(6, this.codecContext.width, this.codecContext.height);
		this.rgbBuffer = Marshal.AllocHGlobal(cb);
		817.avpicture_fill(this.rgbFrame, this.rgbBuffer, 6, this.codecContext.width, this.codecContext.height);
		this.packet = Marshal.AllocHGlobal(57);
		for (int j = 0; j < this.frameCount; j++)
		{
			this.frameBuffers[j] = new byte[this.GetWidth() * this.GetHeight() * 4];
		}
		this.thread = new Thread(new ThreadStart(this.DecodeFrames));
		this.thread.IsBackground = true;
		this.thread.Start();
		return true;
	}

	// Token: 0x06000190 RID: 400 RVA: 0x00008ABC File Offset: 0x00006CBC
	private unsafe static void SwapRedAndBlue(byte[] 1, int 2)
	{
		fixed (byte* ptr = &1[0])
		{
			byte* ptr3;
			byte* ptr2 = (ptr3 = ptr) + 2;
			while (ptr3 < ptr2)
			{
				*(int*)ptr3 = ((int)ptr3[2] | (int)ptr3[1] << 8 | (int)(*ptr3) << 16 | (int)ptr3[3] << 24);
				ptr3 += 4;
			}
		}
	}

	// Token: 0x06000191 RID: 401 RVA: 0x00008B00 File Offset: 0x00006D00
	private void DecodeFrames()
	{
		try
		{
			for (;;)
			{
				this.hasNewFrame = false;
				lock (this)
				{
					while (this.writeIndex - this.readIndex < this.frameCount && !(this.endOfStream = (817.av_read_frame(this.formatContextPtr, this.packet) < 0)))
					{
						if (Marshal.ReadInt32(this.packet, 24) == this.videoStreamIndex)
						{
							double num = (double)Marshal.ReadInt64(this.packet, 8);
							IntPtr <<EMPTY_NAME>> = Marshal.ReadIntPtr(this.packet, 16);
							int 2 = Marshal.ReadInt32(this.packet, 20);
							817.avcodec_decode_video(this.codecContextPtr, this.decodedFrame, ref this.gotPicture, <<EMPTY_NAME>>, 2);
							if (this.gotPicture != 0 && Marshal.ReadIntPtr(this.packet, 16) != IntPtr.Zero && 817.img_convert(this.rgbFrame, 6, this.decodedFrame, (int)this.codecContext.pix_fmt, this.codecContext.width, this.codecContext.height) == 0)
							{
								byte[] array = this.frameBuffers[this.writeIndex % this.frameCount];
								Marshal.Copy(Marshal.ReadIntPtr(this.rgbFrame), array, 0, array.Length);
								this.frameTimesMs[this.writeIndex % this.frameCount] = (num - (double)this.videoStream.start_time) * this.timeBaseSeconds * 1000.0;
								90.SwapRedAndBlue(array, array.Length);
								this.writeIndex++;
								this.lastDecodedTimestamp = num;
								this.hasNewFrame = true;
							}
						}
					}
				}
				if (!this.hasNewFrame)
				{
					Thread.Sleep(15);
				}
			}
		}
		catch (ThreadAbortException)
		{
		}
		catch (Exception ex)
		{
			using (StreamWriter streamWriter = File.CreateText("video-debug.txt"))
			{
				streamWriter.WriteLine(ex.ToString());
			}
		}
	}

	// Token: 0x06000192 RID: 402 RVA: 0x00008D58 File Offset: 0x00006F58
	public bool OpenStream(Stream 1)
	{
		byte[] array = new byte[1.Length];
		1.Read(array, 0, (int)1.Length);
		return this.Method9955(array);
	}

	// Token: 0x06000193 RID: 403 RVA: 0x00008D8C File Offset: 0x00006F8C
	public byte[] GetFrame(int 1)
	{
		while (this.readIndex < this.writeIndex - 1 && this.frameTimesMs[(this.readIndex + 1) % this.frameCount] <= (double)1)
		{
			this.readIndex++;
		}
		if (this.readIndex < this.writeIndex && !this.endOfStream)
		{
			this.currentFrameTime = this.frameTimesMs[this.readIndex % this.frameCount];
			return this.frameBuffers[this.readIndex % this.frameCount];
		}
		return null;
	}

	// Token: 0x06000194 RID: 404 RVA: 0x00008E1C File Offset: 0x0000701C
	public void SeekTo(int 1)
	{
		lock (this)
		{
			int 2 = 0;
			double num = (double)1 / 1000.0 / this.timeBaseSeconds + (double)this.videoStream.start_time;
			if (num < this.lastDecodedTimestamp)
			{
				2 = 1;
			}
			817.av_seek_frame(this.formatContextPtr, this.videoStreamIndex, (long)num, 2);
			this.readIndex = 0;
			this.writeIndex = 0;
		}
	}

	// Token: 0x0400008F RID: 143
	private IntPtr rgbBuffer;

	// Token: 0x04000090 RID: 144
	public int frameCount;

	// Token: 0x04000091 RID: 145
	private 817.818 codecContext;

	// Token: 0x04000092 RID: 146
	private double currentFrameTime;

	// Token: 0x04000093 RID: 147
	private Thread thread;

	// Token: 0x04000094 RID: 148
	private 817.820 formatContext;

	// Token: 0x04000095 RID: 149
	public double timeBaseSeconds;

	// Token: 0x04000096 RID: 150
	private int gotPicture;

	// Token: 0x04000097 RID: 151
	private bool disposed;

	// Token: 0x04000098 RID: 152
	private double lastDecodedTimestamp;

	// Token: 0x04000099 RID: 153
	private IntPtr packet;

	// Token: 0x0400009A RID: 154
	private IntPtr decoder;

	// Token: 0x0400009B RID: 155
	private IntPtr codecContextPtr;

	// Token: 0x0400009C RID: 156
	private IntPtr formatContextPtr;

	// Token: 0x0400009D RID: 157
	private IntPtr decodedFrame;

	// Token: 0x0400009E RID: 158
	private IntPtr rgbFrame;

	// Token: 0x0400009F RID: 159
	private 817.824 videoStream;

	// Token: 0x040000A0 RID: 160
	private GCHandle pinnedBytes;

	// Token: 0x040000A1 RID: 161
	private bool isOpen;

	// Token: 0x040000A2 RID: 162
	private int videoStreamIndex;

	// Token: 0x040000A3 RID: 163
	private double[] frameTimesMs;

	// Token: 0x040000A4 RID: 164
	private byte[][] frameBuffers;

	// Token: 0x040000A5 RID: 165
	private bool endOfStream;

	// Token: 0x040000A6 RID: 166
	private int writeIndex;

	// Token: 0x040000A7 RID: 167
	private int readIndex;

	// Token: 0x040000A8 RID: 168
	private bool hasNewFrame;

	// Token: 0x0200003A RID: 58
	// (Invoke) Token: 0x06000196 RID: 406
	public delegate void 91();
}
