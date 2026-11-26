using System;
using System.Runtime.InteropServices;
using System.Security;

// Token: 0x0200003B RID: 59
[ComVisible(false)]
public static class 817
{
	// Token: 0x06000199 RID: 409
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr audio_resample_init(int 1, int 2, int 3, int 4);

	// Token: 0x0600019A RID: 410
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int audio_resample(IntPtr 1, IntPtr 2, IntPtr 3, int 4);

	// Token: 0x0600019B RID: 411
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void audio_resample_close(IntPtr 1);

	// Token: 0x0600019C RID: 412
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr av_resample_init(int 1, int 2, int 3, int 4, int 5, double 6);

	// Token: 0x0600019D RID: 413
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int av_resample(IntPtr 1, IntPtr 2, IntPtr 3, IntPtr 4, int 5, int 6);

	// Token: 0x0600019E RID: 414
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void av_resample_compensate(IntPtr 1, int 2, int 3);

	// Token: 0x0600019F RID: 415
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void av_resample_close(IntPtr 1);

	// Token: 0x060001A0 RID: 416
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr img_resample_init(int 1, int 2, int 3, int 4);

	// Token: 0x060001A1 RID: 417
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr img_resample_full_init(int 1, int 2, int 3, int 4, int 5, int 6, int 7, int 8, int 9, int 10, int 11, int 12);

	// Token: 0x060001A2 RID: 418
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void img_resample(IntPtr 1, IntPtr 2, IntPtr 3);

	// Token: 0x060001A3 RID: 419
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ImgReSampleContext(IntPtr 1);

	// Token: 0x060001A4 RID: 420
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int avpicture_alloc(IntPtr 1, int 2, int 3, int 4);

	// Token: 0x060001A5 RID: 421
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void avpicture_free(IntPtr 1);

	// Token: 0x060001A6 RID: 422
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int avpicture_fill(IntPtr 1, IntPtr 2, int 3, int 4, int 5);

	// Token: 0x060001A7 RID: 423
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int avpicture_layout(IntPtr 1, int 2, int 3, int 4, IntPtr 5, int 6);

	// Token: 0x060001A8 RID: 424
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int avpicture_get_size(int 1, int 2, int 3);

	// Token: 0x060001A9 RID: 425
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void avcodec_get_chroma_sub_sample(int 1, IntPtr 2, IntPtr 3);

	// Token: 0x060001AA RID: 426
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern string avcodec_get_pix_fmt_name(int 1);

	// Token: 0x060001AB RID: 427
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void avcodec_set_dimensions(IntPtr 1, int 2, int 3);

	// Token: 0x060001AC RID: 428
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern 817.832 avcodec_get_pix_fmt([MarshalAs(UnmanagedType.LPStr)] string 1);

	// Token: 0x060001AD RID: 429
	[SuppressUnmanagedCodeSecurity]
	[CLSCompliant(false)]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern uint avcodec_pix_fmt_to_codec_tag(817.832 1);

	// Token: 0x060001AE RID: 430
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int avcodec_get_pix_fmt_loss(int 1, int 2, int 3);

	// Token: 0x060001AF RID: 431
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int avcodec_find_best_pix_fmt(int 1, int 2, int 3, IntPtr 4);

	// Token: 0x060001B0 RID: 432
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int img_get_alpha_info(IntPtr 1, int 2, int 3, int 4);

	// Token: 0x060001B1 RID: 433
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int img_convert(IntPtr 1, int 2, IntPtr 3, int 4, int 5, int 6);

	// Token: 0x060001B2 RID: 434
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int avpicture_deinterlace(IntPtr 1, IntPtr 2, int 3, int 4, int 5);

	// Token: 0x060001B3 RID: 435
	[CLSCompliant(false)]
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern uint avcodec_version();

	// Token: 0x060001B4 RID: 436
	[CLSCompliant(false)]
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern uint avcodec_build();

	// Token: 0x060001B5 RID: 437
	[CLSCompliant(false)]
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern uint avcodec_init();

	// Token: 0x060001B6 RID: 438
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void register_avcodec(IntPtr 1);

	// Token: 0x060001B7 RID: 439
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr avcodec_find_encoder(817.825 1);

	// Token: 0x060001B8 RID: 440
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr avcodec_find_encoder_by_name([MarshalAs(UnmanagedType.LPStr)] string 1);

	// Token: 0x060001B9 RID: 441
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr avcodec_find_decoder(817.825 1);

	// Token: 0x060001BA RID: 442
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr avcodec_find_decoder_by_name([MarshalAs(UnmanagedType.LPStr)] string 1);

	// Token: 0x060001BB RID: 443
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void avcodec_string([MarshalAs(UnmanagedType.LPStr)] string 1, int 2, IntPtr 3, int 4);

	// Token: 0x060001BC RID: 444
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void avcodec_get_context_defaults(IntPtr 1);

	// Token: 0x060001BD RID: 445
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr avcodec_alloc_context();

	// Token: 0x060001BE RID: 446
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void avcodec_get_frame_defaults(IntPtr 1);

	// Token: 0x060001BF RID: 447
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr avcodec_alloc_frame();

	// Token: 0x060001C0 RID: 448
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int avcodec_default_get_buffer(IntPtr 1, IntPtr 2);

	// Token: 0x060001C1 RID: 449
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void avcodec_default_release_buffer(IntPtr 1, IntPtr 2);

	// Token: 0x060001C2 RID: 450
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void avcodec_default_reget_buffer(IntPtr 1, IntPtr 2);

	// Token: 0x060001C3 RID: 451
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void avcodec_align_dimensions(IntPtr 1, ref int 2, ref int 3);

	// Token: 0x060001C4 RID: 452
	[SuppressUnmanagedCodeSecurity]
	[CLSCompliant(false)]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int avcodec_check_dimensions(IntPtr 1, ref uint 2, ref uint 3);

	// Token: 0x060001C5 RID: 453
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern 817.832 avcodec_default_get_format(IntPtr 1, ref 817.832 2);

	// Token: 0x060001C6 RID: 454
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int avcodec_thread_init(IntPtr 1, int 2);

	// Token: 0x060001C7 RID: 455
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void avcodec_thread_free(IntPtr 1);

	// Token: 0x060001C8 RID: 456
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int avcodec_thread_execute(IntPtr 1, [MarshalAs(UnmanagedType.FunctionPtr)] 817.871 2, [MarshalAs(UnmanagedType.LPArray)] IntPtr[] 3, ref int 4, int 5);

	// Token: 0x060001C9 RID: 457
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int avcodec_default_execute(IntPtr 1, [MarshalAs(UnmanagedType.FunctionPtr)] 817.871 2, [MarshalAs(UnmanagedType.LPArray)] IntPtr[] 3, ref int 4, int 5);

	// Token: 0x060001CA RID: 458
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int avcodec_open(IntPtr 1, IntPtr 2);

	// Token: 0x060001CB RID: 459
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int avcodec_decode_audio(IntPtr 1, IntPtr 2, [In] [Out] ref int 3, IntPtr 4, int 5);

	// Token: 0x060001CC RID: 460
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int avcodec_decode_video(IntPtr 1, IntPtr 2, ref int 3, IntPtr 4, int 5);

	// Token: 0x060001CD RID: 461
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int avcodec_decode_subtitle(IntPtr 1, IntPtr 2, ref int 3, IntPtr 4, int 5);

	// Token: 0x060001CE RID: 462
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int avcodec_parse_frame(IntPtr 1, [MarshalAs(UnmanagedType.LPArray)] IntPtr[] 2, IntPtr 3, IntPtr 4, int 5);

	// Token: 0x060001CF RID: 463
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int avcodec_encode_audio(IntPtr 1, IntPtr 2, int 3, IntPtr 4);

	// Token: 0x060001D0 RID: 464
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int avcodec_encode_video(IntPtr 1, IntPtr 2, int 3, IntPtr 4);

	// Token: 0x060001D1 RID: 465
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int avcodec_encode_subtitle(IntPtr 1, IntPtr 2, int 3, IntPtr 4);

	// Token: 0x060001D2 RID: 466
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int avcodec_close(IntPtr 1);

	// Token: 0x060001D3 RID: 467
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void avcodec_register_all();

	// Token: 0x060001D4 RID: 468
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void avcodec_flush_buffers(IntPtr 1);

	// Token: 0x060001D5 RID: 469
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void avcodec_default_free_buffers(IntPtr 1);

	// Token: 0x060001D6 RID: 470
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern byte av_get_pict_type_char(int 1);

	// Token: 0x060001D7 RID: 471
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int av_get_bits_per_sample(817.825 1);

	// Token: 0x060001D8 RID: 472
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void av_register_codec_parser(IntPtr 1);

	// Token: 0x060001D9 RID: 473
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr av_parser_init(int 1);

	// Token: 0x060001DA RID: 474
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int av_parser_parse(IntPtr 1, IntPtr 2, [MarshalAs(UnmanagedType.LPArray)] IntPtr[] 3, ref int 4, IntPtr 5, int 6, long 7, long 8);

	// Token: 0x060001DB RID: 475
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int av_parser_change(IntPtr 1, IntPtr 2, [MarshalAs(UnmanagedType.LPArray)] IntPtr[] 3, ref int 4, IntPtr 5, int 6, int 7);

	// Token: 0x060001DC RID: 476
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void av_parser_close(IntPtr 1);

	// Token: 0x060001DD RID: 477
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void av_register_bitstream_filter(IntPtr 1);

	// Token: 0x060001DE RID: 478
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr av_bitstream_filter_init([MarshalAs(UnmanagedType.LPStr)] string 1);

	// Token: 0x060001DF RID: 479
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int av_bitstream_filter_filter(IntPtr 1, IntPtr 2, [MarshalAs(UnmanagedType.LPStr)] string 3, [MarshalAs(UnmanagedType.LPArray)] IntPtr[] 4, ref int 5, IntPtr 6, int 7, int 8);

	// Token: 0x060001E0 RID: 480
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void av_bitstream_filter_close(IntPtr 1);

	// Token: 0x060001E1 RID: 481
	[CLSCompliant(false)]
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void av_mallocz(uint 1);

	// Token: 0x060001E2 RID: 482
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr av_strdup([MarshalAs(UnmanagedType.LPStr)] string 1);

	// Token: 0x060001E3 RID: 483
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void av_freep(IntPtr 1);

	// Token: 0x060001E4 RID: 484
	[CLSCompliant(false)]
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void av_fast_realloc(IntPtr 1, ref uint 2, ref uint 3);

	// Token: 0x060001E5 RID: 485
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void av_free_static();

	// Token: 0x060001E6 RID: 486
	[CLSCompliant(false)]
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void av_mallocz_static(uint 1);

	// Token: 0x060001E7 RID: 487
	[SuppressUnmanagedCodeSecurity]
	[CLSCompliant(false)]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void av_realloc_static(IntPtr 1, uint 2);

	// Token: 0x060001E8 RID: 488
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void img_copy(IntPtr 1, IntPtr 2, int 3, int 4, int 5);

	// Token: 0x060001E9 RID: 489
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int img_crop(IntPtr 1, IntPtr 2, int 3, int 4, int 5);

	// Token: 0x060001EA RID: 490
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avcodec-51.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int img_pad(IntPtr 1, IntPtr 2, int 3, int 4, int 5, int 6, int 7, int 8, int 9, ref int 10);

	// Token: 0x060001EB RID: 491
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avformat-52.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int register_protocol(IntPtr 1);

	// Token: 0x060001EC RID: 492
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avformat-52.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void av_destruct_packet_nofree(IntPtr 1);

	// Token: 0x060001ED RID: 493
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avformat-52.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void av_destruct_packet(IntPtr 1);

	// Token: 0x060001EE RID: 494
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avformat-52.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void av_init_packet(IntPtr 1);

	// Token: 0x060001EF RID: 495
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avformat-52.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int av_new_packet(IntPtr 1, int 2);

	// Token: 0x060001F0 RID: 496
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avformat-52.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int av_get_packet(IntPtr 1, IntPtr 2, int 3);

	// Token: 0x060001F1 RID: 497
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avformat-52.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int av_dup_packet(IntPtr 1);

	// Token: 0x060001F2 RID: 498 RVA: 0x00008EA4 File Offset: 0x000070A4
	public static void Method14386(IntPtr 1)
	{
		if (!(1 == IntPtr.Zero))
		{
			817.822 2 = (817.822)Marshal.PtrToStructure(1, typeof(817.822));
			if (2.destruct != null)
			{
				2.destruct(1);
			}
		}
	}

	// Token: 0x060001F3 RID: 499
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avformat-52.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void av_register_image_format(IntPtr 1);

	// Token: 0x060001F4 RID: 500
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avformat-52.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr av_probe_image_format(IntPtr 1);

	// Token: 0x060001F5 RID: 501
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avformat-52.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr guess_image_format([MarshalAs(UnmanagedType.LPTStr)] string 1);

	// Token: 0x060001F6 RID: 502
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avformat-52.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern 817.825 av_guess_image2_codec([MarshalAs(UnmanagedType.LPTStr)] string 1);

	// Token: 0x060001F7 RID: 503
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avformat-52.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int av_read_image(IntPtr 1, [MarshalAs(UnmanagedType.LPTStr)] string 2, IntPtr 3, [MarshalAs(UnmanagedType.FunctionPtr)] 817.874 4, IntPtr 5);

	// Token: 0x060001F8 RID: 504
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avformat-52.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int av_write_image(IntPtr 1, IntPtr 2, IntPtr 3);

	// Token: 0x060001F9 RID: 505
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avformat-52.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void av_register_input_format(IntPtr 1);

	// Token: 0x060001FA RID: 506
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avformat-52.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void av_register_output_format(IntPtr 1);

	// Token: 0x060001FB RID: 507
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avformat-52.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr guess_stream_format([MarshalAs(UnmanagedType.LPTStr)] string 1, [MarshalAs(UnmanagedType.LPTStr)] string 2, [MarshalAs(UnmanagedType.LPTStr)] string 3);

	// Token: 0x060001FC RID: 508
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avformat-52.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr guess_format([MarshalAs(UnmanagedType.LPTStr)] string 1, [MarshalAs(UnmanagedType.LPTStr)] string 2, [MarshalAs(UnmanagedType.LPTStr)] string 3);

	// Token: 0x060001FD RID: 509
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avformat-52.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern 817.825 av_guess_codec(IntPtr 1, [MarshalAs(UnmanagedType.LPTStr)] string 2, [MarshalAs(UnmanagedType.LPTStr)] string 3, [MarshalAs(UnmanagedType.LPTStr)] string 4, 817.826 5);

	// Token: 0x060001FE RID: 510
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avformat-52.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void av_hex_dump(IntPtr 1, IntPtr 2, int 3);

	// Token: 0x060001FF RID: 511
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avformat-52.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void av_pkt_dump(IntPtr 1, IntPtr 2, int 3);

	// Token: 0x06000200 RID: 512
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avformat-52.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void av_register_all();

	// Token: 0x06000201 RID: 513
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avformat-52.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr av_find_input_format([MarshalAs(UnmanagedType.LPTStr)] string 1);

	// Token: 0x06000202 RID: 514
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avformat-52.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr av_probe_input_format(IntPtr 1, int 2);

	// Token: 0x06000203 RID: 515
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avformat-52.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int av_open_input_file(out IntPtr 1, [MarshalAs(UnmanagedType.LPStr)] string 2, IntPtr 3, int 4, IntPtr 5);

	// Token: 0x06000204 RID: 516
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avformat-52.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int av_open_input_file_hax(out IntPtr 1, [MarshalAs(UnmanagedType.LPStr)] string 2, IntPtr 3, IntPtr 4, int 5, IntPtr 6);

	// Token: 0x06000205 RID: 517
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avformat-52.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr av_alloc_format_context();

	// Token: 0x06000206 RID: 518
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avformat-52.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int av_find_stream_info(IntPtr 1);

	// Token: 0x06000207 RID: 519
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avformat-52.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int av_read_packet(IntPtr 1, IntPtr 2);

	// Token: 0x06000208 RID: 520
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avformat-52.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int av_read_frame(IntPtr 1, IntPtr 2);

	// Token: 0x06000209 RID: 521
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avformat-52.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int av_seek_frame(IntPtr 1, int 2, long 3, int 4);

	// Token: 0x0600020A RID: 522
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avformat-52.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int av_read_play(IntPtr 1);

	// Token: 0x0600020B RID: 523
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avformat-52.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int av_read_pause(IntPtr 1);

	// Token: 0x0600020C RID: 524
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avformat-52.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void av_close_input_stream(IntPtr 1);

	// Token: 0x0600020D RID: 525
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avformat-52.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void av_close_input_file(IntPtr 1);

	// Token: 0x0600020E RID: 526
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avformat-52.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr av_new_stream(IntPtr 1, int 2);

	// Token: 0x0600020F RID: 527
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avformat-52.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern IntPtr av_new_program(IntPtr 1, int 2);

	// Token: 0x06000210 RID: 528
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avformat-52.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void av_set_pts_info(IntPtr 1, int 2, int 3, int 4);

	// Token: 0x06000211 RID: 529
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avformat-52.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int av_find_default_stream_index(IntPtr 1);

	// Token: 0x06000212 RID: 530
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avformat-52.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int av_index_search_timestamp(IntPtr 1, long 2, int 3);

	// Token: 0x06000213 RID: 531
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avformat-52.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int av_add_index_entry(IntPtr 1, long 2, long 3, int 4, int 5, int 6);

	// Token: 0x06000214 RID: 532
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avformat-52.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int av_seek_frame_binary(IntPtr 1, int 2, long 3, int 4);

	// Token: 0x06000215 RID: 533
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avformat-52.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void av_update_cur_dts(IntPtr 1, IntPtr 2, long 3);

	// Token: 0x06000216 RID: 534
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avformat-52.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int av_set_parameters(IntPtr 1, IntPtr 2);

	// Token: 0x06000217 RID: 535
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avformat-52.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int av_write_header(IntPtr 1);

	// Token: 0x06000218 RID: 536
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avformat-52.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int av_write_frame(IntPtr 1, IntPtr 2);

	// Token: 0x06000219 RID: 537
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avformat-52.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int av_interleaved_write_frame(IntPtr 1, IntPtr 2);

	// Token: 0x0600021A RID: 538
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avformat-52.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int av_interleave_packet_per_dts(IntPtr 1, out IntPtr 2, IntPtr 3, int 4);

	// Token: 0x0600021B RID: 539
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avformat-52.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int av_write_trailer(IntPtr 1);

	// Token: 0x0600021C RID: 540
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avformat-52.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void dump_format(IntPtr 1, int 2, [MarshalAs(UnmanagedType.LPTStr)] string 3, int 4);

	// Token: 0x0600021D RID: 541
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avformat-52.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int parse_image_size(IntPtr 1, IntPtr 2, [MarshalAs(UnmanagedType.LPTStr)] string 3);

	// Token: 0x0600021E RID: 542
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avformat-52.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int parse_frame_rate(IntPtr 1, IntPtr 2, [MarshalAs(UnmanagedType.LPTStr)] string 3);

	// Token: 0x0600021F RID: 543
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avformat-52.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern long parse_date([MarshalAs(UnmanagedType.LPTStr)] string 1, int 2);

	// Token: 0x06000220 RID: 544
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avformat-52.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern long av_gettime();

	// Token: 0x06000221 RID: 545
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avformat-52.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern long ffm_read_write_index(int 1);

	// Token: 0x06000222 RID: 546
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avformat-52.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ffm_write_write_index(int 1, long 2);

	// Token: 0x06000223 RID: 547
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avformat-52.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void ffm_set_write_index(IntPtr 1, long 2, long 3);

	// Token: 0x06000224 RID: 548
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avformat-52.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int find_info_tag([MarshalAs(UnmanagedType.LPTStr)] string 1, int 2, [MarshalAs(UnmanagedType.LPTStr)] string 3, [MarshalAs(UnmanagedType.LPTStr)] string 4);

	// Token: 0x06000225 RID: 549
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avformat-52.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int av_get_frame_filename(IntPtr 1, int 2, [MarshalAs(UnmanagedType.LPTStr)] string 3, int 4);

	// Token: 0x06000226 RID: 550
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avformat-52.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int av_filename_number_test([MarshalAs(UnmanagedType.LPTStr)] string 1);

	// Token: 0x06000227 RID: 551
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avformat-52.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int video_grab_init();

	// Token: 0x06000228 RID: 552
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avformat-52.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int audio_init();

	// Token: 0x06000229 RID: 553
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avformat-52.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int dv1394_init();

	// Token: 0x0600022A RID: 554
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avformat-52.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int dc1394_init();

	// Token: 0x0600022B RID: 555
	[SuppressUnmanagedCodeSecurity]
	[DllImport("avutil-49.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void av_free(IntPtr 1);

	// Token: 0x0600022C RID: 556 RVA: 0x00008EE8 File Offset: 0x000070E8
	public static double Method14387(817.823 1)
	{
		return (double)1.num / (double)1.den;
	}

	// Token: 0x0200003C RID: 60
	public enum 833
	{

	}

	// Token: 0x0200003D RID: 61
	public struct 834
	{
		// Token: 0x040000AA RID: 170
		[CLSCompliant(false)]
		[MarshalAs(UnmanagedType.U2)]
		public ushort uInt;

		// Token: 0x040000AB RID: 171
		[CLSCompliant(false)]
		[MarshalAs(UnmanagedType.U2)]
		public ushort uInt2;

		// Token: 0x040000AC RID: 172
		[CLSCompliant(false)]
		[MarshalAs(UnmanagedType.U2)]
		public ushort uInt3;

		// Token: 0x040000AD RID: 173
		[CLSCompliant(false)]
		[MarshalAs(UnmanagedType.U2)]
		public ushort uInt4;

		// Token: 0x040000AE RID: 174
		[CLSCompliant(false)]
		[MarshalAs(UnmanagedType.U2)]
		public ushort uInt5;

		// Token: 0x040000AF RID: 175
		[MarshalAs(UnmanagedType.I4)]
		public int number;

		// Token: 0x040000B0 RID: 176
		public IntPtr intPtr;
	}

	// Token: 0x0200003E RID: 62
	public struct 835
	{
		// Token: 0x040000B1 RID: 177
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
		private IntPtr[] intPtrArray;

		// Token: 0x040000B2 RID: 178
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
		private int[] numberArray;
	}

	// Token: 0x0200003F RID: 63
	public struct 836
	{
		// Token: 0x040000B3 RID: 179
		public 817.822 aVPacket;

		// Token: 0x040000B4 RID: 180
		public IntPtr intPtr;
	}

	// Token: 0x02000040 RID: 64
	// (Invoke) Token: 0x0600022E RID: 558
	public delegate string 837();

	// Token: 0x02000041 RID: 65
	public struct 838
	{
		// Token: 0x040000B5 RID: 181
		public 817.823 aVRational;

		// Token: 0x040000B6 RID: 182
		public int number;

		// Token: 0x040000B7 RID: 183
		public int number2;

		// Token: 0x040000B8 RID: 184
		public int number3;

		// Token: 0x040000B9 RID: 185
		public int number4;

		// Token: 0x040000BA RID: 186
		public 817.832 pixelFormat;

		// Token: 0x040000BB RID: 187
		public IntPtr intPtr;

		// Token: 0x040000BC RID: 188
		public int number5;

		// Token: 0x040000BD RID: 189
		[MarshalAs(UnmanagedType.LPStr)]
		public string text;

		// Token: 0x040000BE RID: 190
		public int number6;

		// Token: 0x040000BF RID: 191
		public int number7;

		// Token: 0x040000C0 RID: 192
		public int number8;

		// Token: 0x040000C1 RID: 193
		public int number9;
	}

	// Token: 0x02000042 RID: 66
	// (Invoke) Token: 0x06000232 RID: 562
	public delegate int 839(IntPtr 1, IntPtr 2, int 3, IntPtr 4);

	// Token: 0x02000043 RID: 67
	public struct 840
	{
	}

	// Token: 0x02000044 RID: 68
	// (Invoke) Token: 0x06000236 RID: 566
	public delegate int 841(IntPtr 1);

	// Token: 0x02000045 RID: 69
	// (Invoke) Token: 0x0600023A RID: 570
	public delegate int 842(IntPtr 1);

	// Token: 0x02000046 RID: 70
	// (Invoke) Token: 0x0600023E RID: 574
	public delegate long 843(IntPtr 1, long 2, int 3);

	// Token: 0x02000047 RID: 71
	public struct 844
	{
		// Token: 0x040000C2 RID: 194
		[MarshalAs(UnmanagedType.LPTStr)]
		public string text;

		// Token: 0x040000C3 RID: 195
		[MarshalAs(UnmanagedType.LPTStr)]
		public string text2;

		// Token: 0x040000C4 RID: 196
		[MarshalAs(UnmanagedType.FunctionPtr)]
		public 817.842 _recoveredType255710941;

		// Token: 0x040000C5 RID: 197
		[MarshalAs(UnmanagedType.FunctionPtr)]
		public 817.886 _recoveredType260110942;

		// Token: 0x040000C6 RID: 198
		public int number;

		// Token: 0x040000C7 RID: 199
		[MarshalAs(UnmanagedType.FunctionPtr)]
		public 817.852 _recoveredType256710944;

		// Token: 0x040000C8 RID: 200
		public int number2;

		// Token: 0x040000C9 RID: 201
		public IntPtr intPtr;
	}

	// Token: 0x02000048 RID: 72
	public struct 845
	{
		// Token: 0x040000CA RID: 202
		[MarshalAs(UnmanagedType.LPStr)]
		private string text;

		// Token: 0x040000CB RID: 203
		[MarshalAs(UnmanagedType.I4)]
		private int number;

		// Token: 0x040000CC RID: 204
		[MarshalAs(UnmanagedType.FunctionPtr)]
		private 817.877 _recoveredType259210949;

		// Token: 0x040000CD RID: 205
		private IntPtr intPtr;
	}

	// Token: 0x02000049 RID: 73
	public struct 846
	{
		// Token: 0x040000CE RID: 206
		[MarshalAs(UnmanagedType.LPStr)]
		public string text;

		// Token: 0x040000CF RID: 207
		[MarshalAs(UnmanagedType.LPStr)]
		public string text2;

		// Token: 0x040000D0 RID: 208
		public int number;

		// Token: 0x040000D1 RID: 209
		[MarshalAs(UnmanagedType.FunctionPtr)]
		public 817.866 _recoveredType258110954;

		// Token: 0x040000D2 RID: 210
		[MarshalAs(UnmanagedType.FunctionPtr)]
		public 817.868 _recoveredType258310955;

		// Token: 0x040000D3 RID: 211
		[MarshalAs(UnmanagedType.FunctionPtr)]
		public 817.888 _recoveredType260310956;

		// Token: 0x040000D4 RID: 212
		[MarshalAs(UnmanagedType.FunctionPtr)]
		public 817.856 _recoveredType257110957;

		// Token: 0x040000D5 RID: 213
		[MarshalAs(UnmanagedType.FunctionPtr)]
		public 817.875 _recoveredType259010958;

		// Token: 0x040000D6 RID: 214
		[MarshalAs(UnmanagedType.FunctionPtr)]
		public 817.857 _recoveredType257210959;

		// Token: 0x040000D7 RID: 215
		public int number2;

		// Token: 0x040000D8 RID: 216
		[MarshalAs(UnmanagedType.LPStr)]
		public string text3;

		// Token: 0x040000D9 RID: 217
		public int number3;

		// Token: 0x040000DA RID: 218
		[MarshalAs(UnmanagedType.FunctionPtr)]
		public 817.863 _recoveredType257810963;

		// Token: 0x040000DB RID: 219
		[MarshalAs(UnmanagedType.FunctionPtr)]
		public 817.860 _recoveredType257510964;

		// Token: 0x040000DC RID: 220
		public IntPtr intPtr;
	}

	// Token: 0x0200004A RID: 74
	public struct 847
	{
		// Token: 0x040000DD RID: 221
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
		public int[] numberArray;

		// Token: 0x040000DE RID: 222
		[MarshalAs(UnmanagedType.I4)]
		public int number;

		// Token: 0x040000DF RID: 223
		[MarshalAs(UnmanagedType.FunctionPtr)]
		public 817.841 _recoveredType255610968;

		// Token: 0x040000E0 RID: 224
		[MarshalAs(UnmanagedType.FunctionPtr)]
		public 817.855 _recoveredType257010969;

		// Token: 0x040000E1 RID: 225
		[MarshalAs(UnmanagedType.FunctionPtr)]
		public 817.848 _recoveredType256310970;

		// Token: 0x040000E2 RID: 226
		[MarshalAs(UnmanagedType.FunctionPtr)]
		public 817.849 _recoveredType256410971;

		// Token: 0x040000E3 RID: 227
		public IntPtr intPtr;
	}

	// Token: 0x0200004B RID: 75
	// (Invoke) Token: 0x06000242 RID: 578
	public delegate void 848(IntPtr 1);

	// Token: 0x0200004C RID: 76
	// (Invoke) Token: 0x06000246 RID: 582
	public delegate int 849(IntPtr 1, IntPtr 2, int 3);

	// Token: 0x0200004D RID: 77
	// (Invoke) Token: 0x0600024A RID: 586
	public delegate int 850(IntPtr 1);

	// Token: 0x0200004E RID: 78
	public struct 851
	{
		// Token: 0x040000E4 RID: 228
		[MarshalAs(UnmanagedType.LPStr)]
		public string text;

		// Token: 0x040000E5 RID: 229
		[MarshalAs(UnmanagedType.LPStr)]
		public string text2;

		// Token: 0x040000E6 RID: 230
		[MarshalAs(UnmanagedType.LPStr)]
		public string text3;

		// Token: 0x040000E7 RID: 231
		[MarshalAs(UnmanagedType.LPStr)]
		public string text4;

		// Token: 0x040000E8 RID: 232
		public int number;

		// Token: 0x040000E9 RID: 233
		public 817.825 codecID;

		// Token: 0x040000EA RID: 234
		public 817.825 codecID2;

		// Token: 0x040000EB RID: 235
		[MarshalAs(UnmanagedType.FunctionPtr)]
		public 817.889 _recoveredType260410980;

		// Token: 0x040000EC RID: 236
		[MarshalAs(UnmanagedType.FunctionPtr)]
		public 817.861 _recoveredType257610981;

		// Token: 0x040000ED RID: 237
		[MarshalAs(UnmanagedType.FunctionPtr)]
		public 817.850 _recoveredType256510982;

		// Token: 0x040000EE RID: 238
		public int number2;

		// Token: 0x040000EF RID: 239
		[MarshalAs(UnmanagedType.FunctionPtr)]
		public 817.885 _recoveredType260010984;

		// Token: 0x040000F0 RID: 240
		[MarshalAs(UnmanagedType.FunctionPtr)]
		public 817.873 _recoveredType258810985;

		// Token: 0x040000F1 RID: 241
		public IntPtr intPtr;
	}

	// Token: 0x0200004F RID: 79
	// (Invoke) Token: 0x0600024E RID: 590
	public delegate int 852(IntPtr 1, IntPtr 2);

	// Token: 0x02000050 RID: 80
	public struct 853
	{
		// Token: 0x040000F2 RID: 242
		[MarshalAs(UnmanagedType.LPStr)]
		public string text;

		// Token: 0x040000F3 RID: 243
		public 817.837 _recoveredType255210988;

		// Token: 0x040000F4 RID: 244
		public IntPtr intPtr;
	}

	// Token: 0x02000051 RID: 81
	// (Invoke) Token: 0x06000252 RID: 594
	public delegate int 854(IntPtr 1, IntPtr 2, int 3);

	// Token: 0x02000052 RID: 82
	// (Invoke) Token: 0x06000256 RID: 598
	public delegate int 855(IntPtr 1, IntPtr 2, [MarshalAs(UnmanagedType.LPArray)] IntPtr[] 3, ref int 4, IntPtr 5, int 6);

	// Token: 0x02000053 RID: 83
	// (Invoke) Token: 0x0600025A RID: 602
	public delegate int 856(IntPtr 1);

	// Token: 0x02000054 RID: 84
	// (Invoke) Token: 0x0600025E RID: 606
	public delegate int 857(IntPtr 1, int 2, IntPtr 3, long 4);

	// Token: 0x02000055 RID: 85
	public struct 858
	{
		// Token: 0x040000F5 RID: 245
		[CLSCompliant(false)]
		[MarshalAs(UnmanagedType.U2)]
		public ushort uInt;

		// Token: 0x040000F6 RID: 246
		[CLSCompliant(false)]
		[MarshalAs(UnmanagedType.U4)]
		public uint number;

		// Token: 0x040000F7 RID: 247
		[CLSCompliant(false)]
		[MarshalAs(UnmanagedType.U4)]
		public uint number2;

		// Token: 0x040000F8 RID: 248
		[CLSCompliant(false)]
		[MarshalAs(UnmanagedType.U4)]
		public uint number3;

		// Token: 0x040000F9 RID: 249
		public IntPtr intPtr;
	}

	// Token: 0x02000056 RID: 86
	// (Invoke) Token: 0x06000262 RID: 610
	public delegate int 859(IntPtr 1);

	// Token: 0x02000057 RID: 87
	// (Invoke) Token: 0x06000266 RID: 614
	public delegate int 860(IntPtr 1);

	// Token: 0x02000058 RID: 88
	// (Invoke) Token: 0x0600026A RID: 618
	public delegate int 861(IntPtr 1, IntPtr 2);

	// Token: 0x02000059 RID: 89
	public struct 862
	{
		// Token: 0x040000FA RID: 250
		public int number;

		// Token: 0x040000FB RID: 251
		public int number2;

		// Token: 0x040000FC RID: 252
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
		public short[] int16Array;

		// Token: 0x040000FD RID: 253
		public int number3;
	}

	// Token: 0x0200005A RID: 90
	// (Invoke) Token: 0x0600026E RID: 622
	public delegate int 863(IntPtr 1);

	// Token: 0x0200005B RID: 91
	public struct 864
	{
		// Token: 0x040000FE RID: 254
		[MarshalAs(UnmanagedType.I4)]
		public int number;

		// Token: 0x040000FF RID: 255
		[MarshalAs(UnmanagedType.I4)]
		public int number2;

		// Token: 0x04000100 RID: 256
		[MarshalAs(UnmanagedType.I4)]
		public int number3;

		// Token: 0x04000101 RID: 257
		[MarshalAs(UnmanagedType.R4)]
		public float amount;
	}

	// Token: 0x0200005C RID: 92
	// (Invoke) Token: 0x06000272 RID: 626
	public delegate int 865(IntPtr 1);

	// Token: 0x0200005D RID: 93
	// (Invoke) Token: 0x06000276 RID: 630
	public delegate int 866(IntPtr 1);

	// Token: 0x0200005E RID: 94
	[StructLayout(LayoutKind.Sequential)]
	public sealed class 867
	{
		// Token: 0x04000102 RID: 258
		public IntPtr intPtr;

		// Token: 0x04000103 RID: 259
		[MarshalAs(UnmanagedType.I4)]
		public int number;

		// Token: 0x04000104 RID: 260
		public IntPtr intPtr2;

		// Token: 0x04000105 RID: 261
		public IntPtr intPtr3;

		// Token: 0x04000106 RID: 262
		public IntPtr intPtr4;

		// Token: 0x04000107 RID: 263
		[MarshalAs(UnmanagedType.FunctionPtr)]
		public 817.854 _recoveredType256911008;

		// Token: 0x04000108 RID: 264
		[MarshalAs(UnmanagedType.FunctionPtr)]
		public 817.882 _recoveredType259711009;

		// Token: 0x04000109 RID: 265
		[MarshalAs(UnmanagedType.FunctionPtr)]
		public 817.843 _recoveredType255811010;

		// Token: 0x0400010A RID: 266
		[MarshalAs(UnmanagedType.I8)]
		public long number2;

		// Token: 0x0400010B RID: 267
		[MarshalAs(UnmanagedType.I4)]
		public int number3;

		// Token: 0x0400010C RID: 268
		[MarshalAs(UnmanagedType.I4)]
		public int number4;

		// Token: 0x0400010D RID: 269
		[MarshalAs(UnmanagedType.I4)]
		public int number5;

		// Token: 0x0400010E RID: 270
		[MarshalAs(UnmanagedType.I4)]
		public int number6;

		// Token: 0x0400010F RID: 271
		[MarshalAs(UnmanagedType.I4)]
		public int number7;

		// Token: 0x04000110 RID: 272
		[CLSCompliant(false)]
		[MarshalAs(UnmanagedType.U4)]
		public uint number8;

		// Token: 0x04000111 RID: 273
		public IntPtr intPtr5;

		// Token: 0x04000112 RID: 274
		[CLSCompliant(false)]
		[MarshalAs(UnmanagedType.FunctionPtr)]
		public 817.876 _recoveredType259111019;

		// Token: 0x04000113 RID: 275
		[MarshalAs(UnmanagedType.I4)]
		public int number9;
	}

	// Token: 0x0200005F RID: 95
	// (Invoke) Token: 0x0600027B RID: 635
	public delegate int 868(IntPtr 1, IntPtr 2);

	// Token: 0x02000060 RID: 96
	// (Invoke) Token: 0x0600027F RID: 639
	public delegate int 869(IntPtr 1);

	// Token: 0x02000061 RID: 97
	// (Invoke) Token: 0x06000283 RID: 643
	public delegate int 870(IntPtr 1, IntPtr 2, ref int 3, IntPtr 4, int 5);

	// Token: 0x02000062 RID: 98
	// (Invoke) Token: 0x06000287 RID: 647
	public delegate int 871(IntPtr 1, IntPtr 2);

	// Token: 0x02000063 RID: 99
	public struct 872
	{
		// Token: 0x04000114 RID: 276
		public IntPtr intPtr;

		// Token: 0x04000115 RID: 277
		public IntPtr intPtr2;

		// Token: 0x04000116 RID: 278
		public IntPtr intPtr3;

		// Token: 0x04000117 RID: 279
		public IntPtr intPtr4;
	}

	// Token: 0x02000064 RID: 100
	// (Invoke) Token: 0x0600028B RID: 651
	public delegate int 873(IntPtr 1, IntPtr 2, IntPtr 3, int 4);

	// Token: 0x02000065 RID: 101
	// (Invoke) Token: 0x0600028F RID: 655
	public delegate int 874(IntPtr 1, IntPtr 2);

	// Token: 0x02000066 RID: 102
	// (Invoke) Token: 0x06000293 RID: 659
	public delegate int 875(IntPtr 1, int 2, long 3, int 4);

	// Token: 0x02000067 RID: 103
	// (Invoke) Token: 0x06000297 RID: 663
	[CLSCompliant(false)]
	public delegate uint 876(uint 1, IntPtr 2, uint 3);

	// Token: 0x02000068 RID: 104
	// (Invoke) Token: 0x0600029B RID: 667
	public delegate int 877(IntPtr 1, IntPtr 2, [MarshalAs(UnmanagedType.LPStr)] string 3, [MarshalAs(UnmanagedType.LPArray)] IntPtr[] 4, ref int 5, IntPtr 6, int 7, int 8);

	// Token: 0x02000069 RID: 105
	public struct 878
	{
		// Token: 0x04000118 RID: 280
		[MarshalAs(UnmanagedType.LPStr)]
		public string text;

		// Token: 0x04000119 RID: 281
		public IntPtr intPtr;

		// Token: 0x0400011A RID: 282
		public int number;
	}

	// Token: 0x0200006A RID: 106
	public struct 879
	{
		// Token: 0x0400011B RID: 283
		public long number;

		// Token: 0x0400011C RID: 284
		public long number2;

		// Token: 0x0400011D RID: 285
		public int number3;

		// Token: 0x0400011E RID: 286
		public int number4;

		// Token: 0x0400011F RID: 287
		public int number5;
	}

	// Token: 0x0200006B RID: 107
	public struct 880
	{
		// Token: 0x04000120 RID: 288
		[MarshalAs(UnmanagedType.LPStr)]
		public string text;

		// Token: 0x04000121 RID: 289
		public 817.826 codecType;

		// Token: 0x04000122 RID: 290
		public 817.825 codecID;

		// Token: 0x04000123 RID: 291
		[MarshalAs(UnmanagedType.I4)]
		public int number;

		// Token: 0x04000124 RID: 292
		[MarshalAs(UnmanagedType.FunctionPtr)]
		public 817.869 _recoveredType258411037;

		// Token: 0x04000125 RID: 293
		[MarshalAs(UnmanagedType.FunctionPtr)]
		public 817.839 _recoveredType255411038;

		// Token: 0x04000126 RID: 294
		[MarshalAs(UnmanagedType.FunctionPtr)]
		public 817.865 _recoveredType258011039;

		// Token: 0x04000127 RID: 295
		[MarshalAs(UnmanagedType.FunctionPtr)]
		public 817.870 _recoveredType258511040;

		// Token: 0x04000128 RID: 296
		[MarshalAs(UnmanagedType.I4)]
		public int number2;

		// Token: 0x04000129 RID: 297
		public IntPtr intPtr;

		// Token: 0x0400012A RID: 298
		[MarshalAs(UnmanagedType.FunctionPtr)]
		public 817.859 _recoveredType257411043;

		// Token: 0x0400012B RID: 299
		public IntPtr intPtr2;

		// Token: 0x0400012C RID: 300
		public IntPtr intPtr3;
	}

	// Token: 0x0200006C RID: 108
	public struct 881
	{
		// Token: 0x0400012D RID: 301
		[MarshalAs(UnmanagedType.I4)]
		public int number;

		// Token: 0x0400012E RID: 302
		[CLSCompliant(false)]
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
		public uint[] numberArray;
	}

	// Token: 0x0200006D RID: 109
	// (Invoke) Token: 0x0600029F RID: 671
	public delegate int 882(IntPtr 1, IntPtr 2, int 3);

	// Token: 0x0200006E RID: 110
	public struct 883
	{
	}

	// Token: 0x0200006F RID: 111
	public struct 884
	{
		// Token: 0x0400012F RID: 303
		public 817.832 pixelFormat;

		// Token: 0x04000130 RID: 304
		[MarshalAs(UnmanagedType.I4)]
		public int number;

		// Token: 0x04000131 RID: 305
		[MarshalAs(UnmanagedType.I4)]
		public int number2;

		// Token: 0x04000132 RID: 306
		[MarshalAs(UnmanagedType.I4)]
		public int number3;

		// Token: 0x04000133 RID: 307
		public 817.835 _recoveredType255011052;
	}

	// Token: 0x02000070 RID: 112
	// (Invoke) Token: 0x060002A3 RID: 675
	public delegate int 885(IntPtr 1, IntPtr 2);

	// Token: 0x02000071 RID: 113
	// (Invoke) Token: 0x060002A7 RID: 679
	public delegate int 886(IntPtr 1, [MarshalAs(UnmanagedType.FunctionPtr)] 817.874 2, IntPtr 3);

	// Token: 0x02000072 RID: 114
	public struct 887
	{
		// Token: 0x04000134 RID: 308
		public IntPtr intPtr;

		// Token: 0x04000135 RID: 309
		public IntPtr intPtr2;

		// Token: 0x04000136 RID: 310
		[MarshalAs(UnmanagedType.I8)]
		public long number;

		// Token: 0x04000137 RID: 311
		[MarshalAs(UnmanagedType.I8)]
		public long number2;

		// Token: 0x04000138 RID: 312
		[MarshalAs(UnmanagedType.I8)]
		public long number3;

		// Token: 0x04000139 RID: 313
		[MarshalAs(UnmanagedType.I4)]
		public int number4;

		// Token: 0x0400013A RID: 314
		[MarshalAs(UnmanagedType.I4)]
		public int number5;

		// Token: 0x0400013B RID: 315
		[MarshalAs(UnmanagedType.I8)]
		public long number6;

		// Token: 0x0400013C RID: 316
		[MarshalAs(UnmanagedType.I8)]
		public long number7;

		// Token: 0x0400013D RID: 317
		[MarshalAs(UnmanagedType.I8)]
		public long number8;

		// Token: 0x0400013E RID: 318
		[MarshalAs(UnmanagedType.I8)]
		public long number9;

		// Token: 0x0400013F RID: 319
		[MarshalAs(UnmanagedType.I4)]
		public int number10;

		// Token: 0x04000140 RID: 320
		[MarshalAs(UnmanagedType.I4)]
		public int number11;

		// Token: 0x04000141 RID: 321
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
		public long[] numberArray;

		// Token: 0x04000142 RID: 322
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
		public long[] numberArray2;

		// Token: 0x04000143 RID: 323
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
		public long[] numberArray3;

		// Token: 0x04000144 RID: 324
		[MarshalAs(UnmanagedType.I4)]
		public int number12;
	}

	// Token: 0x02000073 RID: 115
	// (Invoke) Token: 0x060002AB RID: 683
	public delegate int 888(IntPtr 1, IntPtr 2);

	// Token: 0x02000074 RID: 116
	// (Invoke) Token: 0x060002AF RID: 687
	public delegate int 889(IntPtr 1);

	// Token: 0x02000075 RID: 117
	public struct 818
	{
		// Token: 0x04000145 RID: 325
		public IntPtr av_class;

		// Token: 0x04000146 RID: 326
		[MarshalAs(UnmanagedType.I4)]
		public int bit_rate;

		// Token: 0x04000147 RID: 327
		[MarshalAs(UnmanagedType.I4)]
		public int bit_rate_tolerance;

		// Token: 0x04000148 RID: 328
		[MarshalAs(UnmanagedType.I4)]
		public int flags;

		// Token: 0x04000149 RID: 329
		[MarshalAs(UnmanagedType.I4)]
		public int sub_id;

		// Token: 0x0400014A RID: 330
		[MarshalAs(UnmanagedType.I4)]
		public int me_method;

		// Token: 0x0400014B RID: 331
		public IntPtr extradata;

		// Token: 0x0400014C RID: 332
		[MarshalAs(UnmanagedType.I4)]
		public int extradata_size;

		// Token: 0x0400014D RID: 333
		public 817.823 time_base;

		// Token: 0x0400014E RID: 334
		[MarshalAs(UnmanagedType.I4)]
		public int width;

		// Token: 0x0400014F RID: 335
		[MarshalAs(UnmanagedType.I4)]
		public int height;

		// Token: 0x04000150 RID: 336
		[MarshalAs(UnmanagedType.I4)]
		public int gop_size;

		// Token: 0x04000151 RID: 337
		public 817.832 pix_fmt;

		// Token: 0x04000152 RID: 338
		[MarshalAs(UnmanagedType.I4)]
		public int rate_emu;

		// Token: 0x04000153 RID: 339
		[MarshalAs(UnmanagedType.FunctionPtr)]
		public 817.828 draw_horiz_band;

		// Token: 0x04000154 RID: 340
		[MarshalAs(UnmanagedType.I4)]
		public int sample_rate;

		// Token: 0x04000155 RID: 341
		[MarshalAs(UnmanagedType.I4)]
		public int channels;

		// Token: 0x04000156 RID: 342
		public 817.893 sample_fmt;

		// Token: 0x04000157 RID: 343
		[MarshalAs(UnmanagedType.I4)]
		public int frame_size;

		// Token: 0x04000158 RID: 344
		[MarshalAs(UnmanagedType.I4)]
		public int frame_number;

		// Token: 0x04000159 RID: 345
		[MarshalAs(UnmanagedType.I4)]
		public int real_pict_num;

		// Token: 0x0400015A RID: 346
		[MarshalAs(UnmanagedType.I4)]
		public int delay;

		// Token: 0x0400015B RID: 347
		[MarshalAs(UnmanagedType.R4)]
		public float qcompress;

		// Token: 0x0400015C RID: 348
		[MarshalAs(UnmanagedType.R4)]
		public float qblur;

		// Token: 0x0400015D RID: 349
		[MarshalAs(UnmanagedType.I4)]
		public int qmin;

		// Token: 0x0400015E RID: 350
		[MarshalAs(UnmanagedType.I4)]
		public int qmax;

		// Token: 0x0400015F RID: 351
		[MarshalAs(UnmanagedType.I4)]
		public int max_qdiff;

		// Token: 0x04000160 RID: 352
		[MarshalAs(UnmanagedType.I4)]
		public int max_b_frames;

		// Token: 0x04000161 RID: 353
		[MarshalAs(UnmanagedType.R4)]
		public float b_quant_factor;

		// Token: 0x04000162 RID: 354
		[MarshalAs(UnmanagedType.I4)]
		public int rc_strategy;

		// Token: 0x04000163 RID: 355
		[MarshalAs(UnmanagedType.I4)]
		public int b_frame_strategy;

		// Token: 0x04000164 RID: 356
		[MarshalAs(UnmanagedType.I4)]
		public int hurry_up;

		// Token: 0x04000165 RID: 357
		public IntPtr codec;

		// Token: 0x04000166 RID: 358
		public IntPtr priv_data;

		// Token: 0x04000167 RID: 359
		[MarshalAs(UnmanagedType.I4)]
		public int rtp_mode;

		// Token: 0x04000168 RID: 360
		[MarshalAs(UnmanagedType.I4)]
		public int rtp_payload_size;

		// Token: 0x04000169 RID: 361
		[MarshalAs(UnmanagedType.FunctionPtr)]
		public 817.892 rtp_callback;

		// Token: 0x0400016A RID: 362
		[MarshalAs(UnmanagedType.I4)]
		public int mv_bits;

		// Token: 0x0400016B RID: 363
		[MarshalAs(UnmanagedType.I4)]
		public int header_bits;

		// Token: 0x0400016C RID: 364
		[MarshalAs(UnmanagedType.I4)]
		public int i_tex_bits;

		// Token: 0x0400016D RID: 365
		[MarshalAs(UnmanagedType.I4)]
		public int p_tex_bits;

		// Token: 0x0400016E RID: 366
		[MarshalAs(UnmanagedType.I4)]
		public int i_count;

		// Token: 0x0400016F RID: 367
		[MarshalAs(UnmanagedType.I4)]
		public int p_count;

		// Token: 0x04000170 RID: 368
		[MarshalAs(UnmanagedType.I4)]
		public int skip_count;

		// Token: 0x04000171 RID: 369
		[MarshalAs(UnmanagedType.I4)]
		public int misc_bits;

		// Token: 0x04000172 RID: 370
		[MarshalAs(UnmanagedType.I4)]
		public int frame_bits;

		// Token: 0x04000173 RID: 371
		public IntPtr opaque;

		// Token: 0x04000174 RID: 372
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
		public byte[] codec_name;

		// Token: 0x04000175 RID: 373
		public 817.826 codec_type;

		// Token: 0x04000176 RID: 374
		public 817.825 codec_id;

		// Token: 0x04000177 RID: 375
		[CLSCompliant(false)]
		[MarshalAs(UnmanagedType.U4)]
		public uint codec_tag;

		// Token: 0x04000178 RID: 376
		[MarshalAs(UnmanagedType.I4)]
		public int workaround_bugs;

		// Token: 0x04000179 RID: 377
		[MarshalAs(UnmanagedType.I4)]
		public int luma_elim_threshold;

		// Token: 0x0400017A RID: 378
		[MarshalAs(UnmanagedType.I4)]
		public int chroma_elim_threshold;

		// Token: 0x0400017B RID: 379
		[MarshalAs(UnmanagedType.I4)]
		public int strict_std_compliance;

		// Token: 0x0400017C RID: 380
		[MarshalAs(UnmanagedType.R4)]
		public float b_quant_offset;

		// Token: 0x0400017D RID: 381
		[MarshalAs(UnmanagedType.I4)]
		public int error_resilience;

		// Token: 0x0400017E RID: 382
		[MarshalAs(UnmanagedType.FunctionPtr)]
		public 817.830 get_buffer;

		// Token: 0x0400017F RID: 383
		[MarshalAs(UnmanagedType.FunctionPtr)]
		public 817.891 release_buffer;

		// Token: 0x04000180 RID: 384
		[MarshalAs(UnmanagedType.I4)]
		public int has_b_frames;

		// Token: 0x04000181 RID: 385
		[MarshalAs(UnmanagedType.I4)]
		public int block_align;

		// Token: 0x04000182 RID: 386
		[MarshalAs(UnmanagedType.I4)]
		public int parse_only;

		// Token: 0x04000183 RID: 387
		[MarshalAs(UnmanagedType.I4)]
		public int mpeg_quant;

		// Token: 0x04000184 RID: 388
		[MarshalAs(UnmanagedType.LPStr)]
		public string stats_out;

		// Token: 0x04000185 RID: 389
		public string stats_in;

		// Token: 0x04000186 RID: 390
		[MarshalAs(UnmanagedType.R4)]
		public float rc_qsquish;

		// Token: 0x04000187 RID: 391
		[MarshalAs(UnmanagedType.R4)]
		public float rc_qmod_amp;

		// Token: 0x04000188 RID: 392
		[MarshalAs(UnmanagedType.I4)]
		public int rc_qmod_freq;

		// Token: 0x04000189 RID: 393
		public IntPtr rc_override;

		// Token: 0x0400018A RID: 394
		[MarshalAs(UnmanagedType.I4)]
		public int rc_override_count;

		// Token: 0x0400018B RID: 395
		[MarshalAs(UnmanagedType.LPStr)]
		public string rc_eq;

		// Token: 0x0400018C RID: 396
		[MarshalAs(UnmanagedType.I4)]
		public int rc_max_rate;

		// Token: 0x0400018D RID: 397
		[MarshalAs(UnmanagedType.I4)]
		public int rc_min_rate;

		// Token: 0x0400018E RID: 398
		[MarshalAs(UnmanagedType.I4)]
		public int rc_buffer_size;

		// Token: 0x0400018F RID: 399
		[MarshalAs(UnmanagedType.R4)]
		public float rc_buffer_aggressivity;

		// Token: 0x04000190 RID: 400
		[MarshalAs(UnmanagedType.R4)]
		public float i_quant_factor;

		// Token: 0x04000191 RID: 401
		[MarshalAs(UnmanagedType.R4)]
		public float i_quant_offset;

		// Token: 0x04000192 RID: 402
		[MarshalAs(UnmanagedType.R4)]
		public float rc_initial_cplx;

		// Token: 0x04000193 RID: 403
		[MarshalAs(UnmanagedType.I4)]
		public int dct_algo;

		// Token: 0x04000194 RID: 404
		[MarshalAs(UnmanagedType.R4)]
		public float lumi_masking;

		// Token: 0x04000195 RID: 405
		[MarshalAs(UnmanagedType.R4)]
		public float temporal_cplx_masking;

		// Token: 0x04000196 RID: 406
		[MarshalAs(UnmanagedType.R4)]
		public float spatial_cplx_masking;

		// Token: 0x04000197 RID: 407
		[MarshalAs(UnmanagedType.R4)]
		public float p_masking;

		// Token: 0x04000198 RID: 408
		[MarshalAs(UnmanagedType.R4)]
		public float dark_masking;

		// Token: 0x04000199 RID: 409
		[MarshalAs(UnmanagedType.I4)]
		public int unused;

		// Token: 0x0400019A RID: 410
		[MarshalAs(UnmanagedType.I4)]
		public int idct_algo;

		// Token: 0x0400019B RID: 411
		[MarshalAs(UnmanagedType.I4)]
		public int slice_count;

		// Token: 0x0400019C RID: 412
		public IntPtr slice_offset;

		// Token: 0x0400019D RID: 413
		[MarshalAs(UnmanagedType.I4)]
		public int error_concealment;

		// Token: 0x0400019E RID: 414
		[CLSCompliant(false)]
		[MarshalAs(UnmanagedType.U4)]
		public uint dsp_mask;

		// Token: 0x0400019F RID: 415
		[MarshalAs(UnmanagedType.I4)]
		public int bits_per_sample;

		// Token: 0x040001A0 RID: 416
		[MarshalAs(UnmanagedType.I4)]
		public int prediction_method;

		// Token: 0x040001A1 RID: 417
		public 817.823 sample_aspect_ratio;

		// Token: 0x040001A2 RID: 418
		public IntPtr coded_frame;

		// Token: 0x040001A3 RID: 419
		[MarshalAs(UnmanagedType.I4)]
		public int debug;

		// Token: 0x040001A4 RID: 420
		[MarshalAs(UnmanagedType.I4)]
		public int debug_mv;

		// Token: 0x040001A5 RID: 421
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
		public long[] error;

		// Token: 0x040001A6 RID: 422
		[MarshalAs(UnmanagedType.I4)]
		public int mb_qmin;

		// Token: 0x040001A7 RID: 423
		[MarshalAs(UnmanagedType.I4)]
		public int mb_qmax;

		// Token: 0x040001A8 RID: 424
		[MarshalAs(UnmanagedType.I4)]
		public int me_cmp;

		// Token: 0x040001A9 RID: 425
		[MarshalAs(UnmanagedType.I4)]
		public int me_sub_cmp;

		// Token: 0x040001AA RID: 426
		[MarshalAs(UnmanagedType.I4)]
		public int mb_cmp;

		// Token: 0x040001AB RID: 427
		[MarshalAs(UnmanagedType.I4)]
		public int ildct_cmp;

		// Token: 0x040001AC RID: 428
		[MarshalAs(UnmanagedType.I4)]
		public int dia_size;

		// Token: 0x040001AD RID: 429
		[MarshalAs(UnmanagedType.I4)]
		public int last_predictor_count;

		// Token: 0x040001AE RID: 430
		[MarshalAs(UnmanagedType.I4)]
		public int pre_me;

		// Token: 0x040001AF RID: 431
		[MarshalAs(UnmanagedType.I4)]
		public int me_pre_cmp;

		// Token: 0x040001B0 RID: 432
		[MarshalAs(UnmanagedType.I4)]
		public int pre_dia_size;

		// Token: 0x040001B1 RID: 433
		[MarshalAs(UnmanagedType.I4)]
		public int me_subpel_quality;

		// Token: 0x040001B2 RID: 434
		[MarshalAs(UnmanagedType.FunctionPtr)]
		public 817.831 get_format;

		// Token: 0x040001B3 RID: 435
		[MarshalAs(UnmanagedType.I4)]
		public int dtg_active_format;

		// Token: 0x040001B4 RID: 436
		[MarshalAs(UnmanagedType.I4)]
		public int me_range;

		// Token: 0x040001B5 RID: 437
		[MarshalAs(UnmanagedType.I4)]
		public int intra_quant_bias;

		// Token: 0x040001B6 RID: 438
		[MarshalAs(UnmanagedType.I4)]
		public int inter_quant_bias;

		// Token: 0x040001B7 RID: 439
		[MarshalAs(UnmanagedType.I4)]
		public int color_table_id;

		// Token: 0x040001B8 RID: 440
		[MarshalAs(UnmanagedType.I4)]
		public int internal_buffer_count;

		// Token: 0x040001B9 RID: 441
		public IntPtr internal_buffer;

		// Token: 0x040001BA RID: 442
		[MarshalAs(UnmanagedType.I4)]
		public int global_quality;

		// Token: 0x040001BB RID: 443
		[MarshalAs(UnmanagedType.I4)]
		public int coder_type;

		// Token: 0x040001BC RID: 444
		[MarshalAs(UnmanagedType.I4)]
		public int context_model;

		// Token: 0x040001BD RID: 445
		[MarshalAs(UnmanagedType.I4)]
		public int slice_flags;

		// Token: 0x040001BE RID: 446
		[MarshalAs(UnmanagedType.I4)]
		public int xvmc_acceleration;

		// Token: 0x040001BF RID: 447
		[MarshalAs(UnmanagedType.I4)]
		public int mb_decision;

		// Token: 0x040001C0 RID: 448
		public IntPtr intra_matrix;

		// Token: 0x040001C1 RID: 449
		public IntPtr inter_matrix;

		// Token: 0x040001C2 RID: 450
		[CLSCompliant(false)]
		[MarshalAs(UnmanagedType.U4)]
		public uint stream_codec_tag;

		// Token: 0x040001C3 RID: 451
		[MarshalAs(UnmanagedType.I4)]
		public int scenechange_threshold;

		// Token: 0x040001C4 RID: 452
		[MarshalAs(UnmanagedType.I4)]
		public int lmin;

		// Token: 0x040001C5 RID: 453
		[MarshalAs(UnmanagedType.I4)]
		public int lmax;

		// Token: 0x040001C6 RID: 454
		public IntPtr palctrl;

		// Token: 0x040001C7 RID: 455
		[MarshalAs(UnmanagedType.I4)]
		public int noise_reduction;

		// Token: 0x040001C8 RID: 456
		[MarshalAs(UnmanagedType.FunctionPtr)]
		public 817.890 reget_buffer;

		// Token: 0x040001C9 RID: 457
		[MarshalAs(UnmanagedType.I4)]
		public int rc_initial_buffer_occupancy;

		// Token: 0x040001CA RID: 458
		[MarshalAs(UnmanagedType.I4)]
		public int inter_threshold;

		// Token: 0x040001CB RID: 459
		[MarshalAs(UnmanagedType.I4)]
		public int flags2;

		// Token: 0x040001CC RID: 460
		[MarshalAs(UnmanagedType.I4)]
		public int error_rate;

		// Token: 0x040001CD RID: 461
		[MarshalAs(UnmanagedType.I4)]
		public int antialias_algo;

		// Token: 0x040001CE RID: 462
		[MarshalAs(UnmanagedType.I4)]
		public int quantizer_noise_shaping;

		// Token: 0x040001CF RID: 463
		[MarshalAs(UnmanagedType.I4)]
		public int thread_count;

		// Token: 0x040001D0 RID: 464
		[MarshalAs(UnmanagedType.FunctionPtr)]
		public 817.829 execute;

		// Token: 0x040001D1 RID: 465
		public IntPtr thread_opaque;

		// Token: 0x040001D2 RID: 466
		[MarshalAs(UnmanagedType.I4)]
		public int me_threshold;

		// Token: 0x040001D3 RID: 467
		[MarshalAs(UnmanagedType.I4)]
		public int mb_threshold;

		// Token: 0x040001D4 RID: 468
		[MarshalAs(UnmanagedType.I4)]
		public int intra_dc_precision;

		// Token: 0x040001D5 RID: 469
		[MarshalAs(UnmanagedType.I4)]
		public int nsse_weight;

		// Token: 0x040001D6 RID: 470
		[MarshalAs(UnmanagedType.I4)]
		public int skip_top;

		// Token: 0x040001D7 RID: 471
		[MarshalAs(UnmanagedType.I4)]
		public int skip_bottom;

		// Token: 0x040001D8 RID: 472
		[MarshalAs(UnmanagedType.I4)]
		public int profile;

		// Token: 0x040001D9 RID: 473
		[MarshalAs(UnmanagedType.I4)]
		public int level;

		// Token: 0x040001DA RID: 474
		[MarshalAs(UnmanagedType.I4)]
		public int lowres;

		// Token: 0x040001DB RID: 475
		[MarshalAs(UnmanagedType.I4)]
		public int coded_width;

		// Token: 0x040001DC RID: 476
		[MarshalAs(UnmanagedType.I4)]
		public int coded_height;

		// Token: 0x040001DD RID: 477
		[MarshalAs(UnmanagedType.I4)]
		public int frame_skip_threshold;

		// Token: 0x040001DE RID: 478
		[MarshalAs(UnmanagedType.I4)]
		public int frame_skip_factor;

		// Token: 0x040001DF RID: 479
		[MarshalAs(UnmanagedType.I4)]
		public int frame_skip_exp;

		// Token: 0x040001E0 RID: 480
		[MarshalAs(UnmanagedType.I4)]
		public int frame_skip_cmp;

		// Token: 0x040001E1 RID: 481
		[MarshalAs(UnmanagedType.R4)]
		public float border_masking;

		// Token: 0x040001E2 RID: 482
		[MarshalAs(UnmanagedType.I4)]
		public int mb_lmin;

		// Token: 0x040001E3 RID: 483
		[MarshalAs(UnmanagedType.I4)]
		public int mb_lmax;

		// Token: 0x040001E4 RID: 484
		[MarshalAs(UnmanagedType.I4)]
		public int me_penalty_compensation;

		// Token: 0x040001E5 RID: 485
		public 817.819 skip_loop_filter;

		// Token: 0x040001E6 RID: 486
		public 817.819 skip_frame;

		// Token: 0x040001E7 RID: 487
		[MarshalAs(UnmanagedType.I4)]
		public int bidir_refine;

		// Token: 0x040001E8 RID: 488
		[MarshalAs(UnmanagedType.I4)]
		public int brd_scale;

		// Token: 0x040001E9 RID: 489
		[MarshalAs(UnmanagedType.I4)]
		public int crf;

		// Token: 0x040001EA RID: 490
		[MarshalAs(UnmanagedType.I4)]
		public int cqp;

		// Token: 0x040001EB RID: 491
		[MarshalAs(UnmanagedType.I4)]
		public int keyint_min;

		// Token: 0x040001EC RID: 492
		[MarshalAs(UnmanagedType.I4)]
		public int refs;

		// Token: 0x040001ED RID: 493
		[MarshalAs(UnmanagedType.I4)]
		public int chromaoffset;

		// Token: 0x040001EE RID: 494
		[MarshalAs(UnmanagedType.I4)]
		public int bframebias;

		// Token: 0x040001EF RID: 495
		[MarshalAs(UnmanagedType.I4)]
		public int trellis;

		// Token: 0x040001F0 RID: 496
		[MarshalAs(UnmanagedType.R4)]
		public float complexityblur;

		// Token: 0x040001F1 RID: 497
		[MarshalAs(UnmanagedType.I4)]
		public int deblockalpha;

		// Token: 0x040001F2 RID: 498
		[MarshalAs(UnmanagedType.I4)]
		public int deblockbeta;

		// Token: 0x040001F3 RID: 499
		[MarshalAs(UnmanagedType.I4)]
		public int partitions;

		// Token: 0x040001F4 RID: 500
		[MarshalAs(UnmanagedType.I4)]
		public int directpred;

		// Token: 0x040001F5 RID: 501
		[MarshalAs(UnmanagedType.I4)]
		public int cutoff;

		// Token: 0x040001F6 RID: 502
		[MarshalAs(UnmanagedType.I4)]
		public int scenechange_factor;

		// Token: 0x040001F7 RID: 503
		[MarshalAs(UnmanagedType.I4)]
		public int mv0_threshold;

		// Token: 0x040001F8 RID: 504
		[MarshalAs(UnmanagedType.I4)]
		public int b_sensitivity;

		// Token: 0x040001F9 RID: 505
		[MarshalAs(UnmanagedType.I4)]
		public int compression_level;

		// Token: 0x040001FA RID: 506
		[MarshalAs(UnmanagedType.I4)]
		public int use_lpc;

		// Token: 0x040001FB RID: 507
		[MarshalAs(UnmanagedType.I4)]
		public int lpc_coeff_precision;

		// Token: 0x040001FC RID: 508
		[MarshalAs(UnmanagedType.I4)]
		public int min_prediction_order;

		// Token: 0x040001FD RID: 509
		[MarshalAs(UnmanagedType.I4)]
		public int max_prediction_order;

		// Token: 0x040001FE RID: 510
		[MarshalAs(UnmanagedType.I4)]
		public int prediction_order_method;

		// Token: 0x040001FF RID: 511
		[MarshalAs(UnmanagedType.I4)]
		public int min_partition_order;

		// Token: 0x04000200 RID: 512
		[MarshalAs(UnmanagedType.I4)]
		public int max_partition_order;
	}

	// Token: 0x02000076 RID: 118
	public enum 819
	{
		// Token: 0x04000202 RID: 514
		AVDISCARD_NONE = -16,
		// Token: 0x04000203 RID: 515
		AVDISCARD_DEFAULT = 0,
		// Token: 0x04000204 RID: 516
		AVDISCARD_NONREF = 8,
		// Token: 0x04000205 RID: 517
		AVDISCARD_BIDIR = 16,
		// Token: 0x04000206 RID: 518
		AVDISCARD_NONKEY = 32,
		// Token: 0x04000207 RID: 519
		AVDISCARD_ALL = 48
	}

	// Token: 0x02000077 RID: 119
	public struct 820
	{
		// Token: 0x04000208 RID: 520
		public IntPtr pAVClass;

		// Token: 0x04000209 RID: 521
		public IntPtr pAVInputFormat;

		// Token: 0x0400020A RID: 522
		public IntPtr pAVOutputFormat;

		// Token: 0x0400020B RID: 523
		public IntPtr priv_data;

		// Token: 0x0400020C RID: 524
		public IntPtr pb;

		// Token: 0x0400020D RID: 525
		[MarshalAs(UnmanagedType.I4)]
		public int nb_streams;

		// Token: 0x0400020E RID: 526
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
		public IntPtr[] streams;

		// Token: 0x0400020F RID: 527
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)]
		public byte[] filename;

		// Token: 0x04000210 RID: 528
		[MarshalAs(UnmanagedType.I8)]
		public long timestamp;

		// Token: 0x04000211 RID: 529
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
		public byte[] title;

		// Token: 0x04000212 RID: 530
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
		public byte[] author;

		// Token: 0x04000213 RID: 531
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
		public byte[] copyright;

		// Token: 0x04000214 RID: 532
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
		public byte[] comment;

		// Token: 0x04000215 RID: 533
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
		public byte[] album;

		// Token: 0x04000216 RID: 534
		[MarshalAs(UnmanagedType.I4)]
		public int year;

		// Token: 0x04000217 RID: 535
		[MarshalAs(UnmanagedType.I4)]
		public int tract;

		// Token: 0x04000218 RID: 536
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
		public byte[] genre;

		// Token: 0x04000219 RID: 537
		[MarshalAs(UnmanagedType.I4)]
		public int ctx_flags;

		// Token: 0x0400021A RID: 538
		public IntPtr packet_buffer;

		// Token: 0x0400021B RID: 539
		[MarshalAs(UnmanagedType.I8)]
		public long start_time;

		// Token: 0x0400021C RID: 540
		[MarshalAs(UnmanagedType.I8)]
		public long duration;

		// Token: 0x0400021D RID: 541
		[MarshalAs(UnmanagedType.I8)]
		public long file_size;

		// Token: 0x0400021E RID: 542
		[MarshalAs(UnmanagedType.I4)]
		public int bit_rate;

		// Token: 0x0400021F RID: 543
		public IntPtr cur_st;

		// Token: 0x04000220 RID: 544
		public IntPtr cur_ptr;

		// Token: 0x04000221 RID: 545
		[MarshalAs(UnmanagedType.I4)]
		public int cur_len;

		// Token: 0x04000222 RID: 546
		public 817.822 cur_pkt;

		// Token: 0x04000223 RID: 547
		[MarshalAs(UnmanagedType.I8)]
		public long data_offset;

		// Token: 0x04000224 RID: 548
		[MarshalAs(UnmanagedType.I4)]
		public int index_built;

		// Token: 0x04000225 RID: 549
		[MarshalAs(UnmanagedType.I4)]
		public int mux_rate;

		// Token: 0x04000226 RID: 550
		[MarshalAs(UnmanagedType.I4)]
		public int packet_size;

		// Token: 0x04000227 RID: 551
		[MarshalAs(UnmanagedType.I4)]
		public int preload;

		// Token: 0x04000228 RID: 552
		[MarshalAs(UnmanagedType.I4)]
		public int max_delay;

		// Token: 0x04000229 RID: 553
		[MarshalAs(UnmanagedType.I4)]
		public int loop_output;

		// Token: 0x0400022A RID: 554
		[MarshalAs(UnmanagedType.I4)]
		public int flags;

		// Token: 0x0400022B RID: 555
		[MarshalAs(UnmanagedType.I4)]
		public int loop_input;

		// Token: 0x0400022C RID: 556
		[CLSCompliant(false)]
		[MarshalAs(UnmanagedType.U4)]
		public uint probesize;

		// Token: 0x0400022D RID: 557
		[MarshalAs(UnmanagedType.I4)]
		public int max_analyze_duration;

		// Token: 0x0400022E RID: 558
		public IntPtr key;

		// Token: 0x0400022F RID: 559
		[MarshalAs(UnmanagedType.I4)]
		public int keylen;

		// Token: 0x04000230 RID: 560
		[CLSCompliant(false)]
		[MarshalAs(UnmanagedType.U4)]
		public uint nb_programs;

		// Token: 0x04000231 RID: 561
		public IntPtr programs;

		// Token: 0x04000232 RID: 562
		public 817.825 video_codec_id;

		// Token: 0x04000233 RID: 563
		public 817.825 audio_codec_id;

		// Token: 0x04000234 RID: 564
		public 817.825 subtitle_codec_id;
	}

	// Token: 0x02000078 RID: 120
	public struct 821
	{
		// Token: 0x04000235 RID: 565
		[MarshalAs(UnmanagedType.I8)]
		public long val;

		// Token: 0x04000236 RID: 566
		[MarshalAs(UnmanagedType.I8)]
		public long num;

		// Token: 0x04000237 RID: 567
		[MarshalAs(UnmanagedType.I8)]
		public long den;
	}

	// Token: 0x02000079 RID: 121
	public struct 822
	{
		// Token: 0x04000238 RID: 568
		[MarshalAs(UnmanagedType.I8)]
		public long pts;

		// Token: 0x04000239 RID: 569
		[MarshalAs(UnmanagedType.I8)]
		public long dts;

		// Token: 0x0400023A RID: 570
		public IntPtr data;

		// Token: 0x0400023B RID: 571
		[MarshalAs(UnmanagedType.I4)]
		public int size;

		// Token: 0x0400023C RID: 572
		[MarshalAs(UnmanagedType.I4)]
		public int stream_index;

		// Token: 0x0400023D RID: 573
		[MarshalAs(UnmanagedType.I4)]
		public int flags;

		// Token: 0x0400023E RID: 574
		[MarshalAs(UnmanagedType.I4)]
		public int duration;

		// Token: 0x0400023F RID: 575
		[MarshalAs(UnmanagedType.FunctionPtr)]
		public 817.827 destruct;

		// Token: 0x04000240 RID: 576
		public IntPtr priv;

		// Token: 0x04000241 RID: 577
		[MarshalAs(UnmanagedType.I8)]
		public long pos;
	}

	// Token: 0x0200007A RID: 122
	public struct 823
	{
		// Token: 0x04000242 RID: 578
		[MarshalAs(UnmanagedType.I4)]
		public int num;

		// Token: 0x04000243 RID: 579
		[MarshalAs(UnmanagedType.I4)]
		public int den;
	}

	// Token: 0x0200007B RID: 123
	public struct 824
	{
		// Token: 0x04000244 RID: 580
		[MarshalAs(UnmanagedType.I4)]
		public int index;

		// Token: 0x04000245 RID: 581
		[MarshalAs(UnmanagedType.I4)]
		public int id;

		// Token: 0x04000246 RID: 582
		public IntPtr codec;

		// Token: 0x04000247 RID: 583
		public 817.823 r_frame_rate;

		// Token: 0x04000248 RID: 584
		public IntPtr priv_data;

		// Token: 0x04000249 RID: 585
		[MarshalAs(UnmanagedType.I8)]
		public long codec_info_duration;

		// Token: 0x0400024A RID: 586
		public 817.821 pts;

		// Token: 0x0400024B RID: 587
		public 817.823 time_base;

		// Token: 0x0400024C RID: 588
		[MarshalAs(UnmanagedType.I4)]
		public int pts_wrap_bits;

		// Token: 0x0400024D RID: 589
		[MarshalAs(UnmanagedType.I4)]
		public int stream_copy;

		// Token: 0x0400024E RID: 590
		public 817.819 discard;

		// Token: 0x0400024F RID: 591
		[MarshalAs(UnmanagedType.R4)]
		public float quality;

		// Token: 0x04000250 RID: 592
		[MarshalAs(UnmanagedType.I8)]
		public long start_time;

		// Token: 0x04000251 RID: 593
		[MarshalAs(UnmanagedType.I8)]
		public long duration;

		// Token: 0x04000252 RID: 594
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
		public byte[] language;

		// Token: 0x04000253 RID: 595
		[MarshalAs(UnmanagedType.I4)]
		public int need_parsing;

		// Token: 0x04000254 RID: 596
		public IntPtr pAVCodecParserContext;

		// Token: 0x04000255 RID: 597
		[MarshalAs(UnmanagedType.I8)]
		public long cur_dts;

		// Token: 0x04000256 RID: 598
		[MarshalAs(UnmanagedType.I4)]
		public int last_IP_duration;

		// Token: 0x04000257 RID: 599
		[MarshalAs(UnmanagedType.I8)]
		public long last_IP_pts;

		// Token: 0x04000258 RID: 600
		public IntPtr pAVIndexEntry;

		// Token: 0x04000259 RID: 601
		[MarshalAs(UnmanagedType.I4)]
		public int nb_index_entries;

		// Token: 0x0400025A RID: 602
		[MarshalAs(UnmanagedType.I4)]
		public int index_entries_allocated_size;

		// Token: 0x0400025B RID: 603
		[MarshalAs(UnmanagedType.I8)]
		public long nb_frames;

		// Token: 0x0400025C RID: 604
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
		public long[] pts_buffer;
	}

	// Token: 0x0200007C RID: 124
	public enum 825
	{
		// Token: 0x0400025E RID: 606
		CODEC_ID_NONE,
		// Token: 0x0400025F RID: 607
		CODEC_ID_MPEG1VIDEO,
		// Token: 0x04000260 RID: 608
		CODEC_ID_MPEG2VIDEO,
		// Token: 0x04000261 RID: 609
		CODEC_ID_MPEG2VIDEO_XVMC,
		// Token: 0x04000262 RID: 610
		CODEC_ID_H261,
		// Token: 0x04000263 RID: 611
		CODEC_ID_H263,
		// Token: 0x04000264 RID: 612
		CODEC_ID_RV10,
		// Token: 0x04000265 RID: 613
		CODEC_ID_RV20,
		// Token: 0x04000266 RID: 614
		CODEC_ID_MJPEG,
		// Token: 0x04000267 RID: 615
		CODEC_ID_MJPEGB,
		// Token: 0x04000268 RID: 616
		CODEC_ID_LJPEG,
		// Token: 0x04000269 RID: 617
		CODEC_ID_SP5X,
		// Token: 0x0400026A RID: 618
		CODEC_ID_JPEGLS,
		// Token: 0x0400026B RID: 619
		CODEC_ID_MPEG4,
		// Token: 0x0400026C RID: 620
		CODEC_ID_RAWVIDEO,
		// Token: 0x0400026D RID: 621
		CODEC_ID_MSMPEG4V1,
		// Token: 0x0400026E RID: 622
		CODEC_ID_MSMPEG4V2,
		// Token: 0x0400026F RID: 623
		CODEC_ID_MSMPEG4V3,
		// Token: 0x04000270 RID: 624
		CODEC_ID_WMV1,
		// Token: 0x04000271 RID: 625
		CODEC_ID_WMV2,
		// Token: 0x04000272 RID: 626
		CODEC_ID_H263P,
		// Token: 0x04000273 RID: 627
		CODEC_ID_H263I,
		// Token: 0x04000274 RID: 628
		CODEC_ID_FLV1,
		// Token: 0x04000275 RID: 629
		CODEC_ID_SVQ1,
		// Token: 0x04000276 RID: 630
		CODEC_ID_SVQ3,
		// Token: 0x04000277 RID: 631
		CODEC_ID_DVVIDEO,
		// Token: 0x04000278 RID: 632
		CODEC_ID_HUFFYUV,
		// Token: 0x04000279 RID: 633
		CODEC_ID_CYUV,
		// Token: 0x0400027A RID: 634
		CODEC_ID_H264,
		// Token: 0x0400027B RID: 635
		CODEC_ID_INDEO3,
		// Token: 0x0400027C RID: 636
		CODEC_ID_VP3,
		// Token: 0x0400027D RID: 637
		CODEC_ID_THEORA,
		// Token: 0x0400027E RID: 638
		CODEC_ID_ASV1,
		// Token: 0x0400027F RID: 639
		CODEC_ID_ASV2,
		// Token: 0x04000280 RID: 640
		CODEC_ID_FFV1,
		// Token: 0x04000281 RID: 641
		CODEC_ID_4XM,
		// Token: 0x04000282 RID: 642
		CODEC_ID_VCR1,
		// Token: 0x04000283 RID: 643
		CODEC_ID_CLJR,
		// Token: 0x04000284 RID: 644
		CODEC_ID_MDEC,
		// Token: 0x04000285 RID: 645
		CODEC_ID_ROQ,
		// Token: 0x04000286 RID: 646
		CODEC_ID_INTERPLAY_VIDEO,
		// Token: 0x04000287 RID: 647
		CODEC_ID_XAN_WC3,
		// Token: 0x04000288 RID: 648
		CODEC_ID_XAN_WC4,
		// Token: 0x04000289 RID: 649
		CODEC_ID_RPZA,
		// Token: 0x0400028A RID: 650
		CODEC_ID_CINEPAK,
		// Token: 0x0400028B RID: 651
		CODEC_ID_WS_VQA,
		// Token: 0x0400028C RID: 652
		CODEC_ID_MSRLE,
		// Token: 0x0400028D RID: 653
		CODEC_ID_MSVIDEO1,
		// Token: 0x0400028E RID: 654
		CODEC_ID_IDCIN,
		// Token: 0x0400028F RID: 655
		CODEC_ID_8BPS,
		// Token: 0x04000290 RID: 656
		CODEC_ID_SMC,
		// Token: 0x04000291 RID: 657
		CODEC_ID_FLIC,
		// Token: 0x04000292 RID: 658
		CODEC_ID_TRUEMOTION1,
		// Token: 0x04000293 RID: 659
		CODEC_ID_VMDVIDEO,
		// Token: 0x04000294 RID: 660
		CODEC_ID_MSZH,
		// Token: 0x04000295 RID: 661
		CODEC_ID_ZLIB,
		// Token: 0x04000296 RID: 662
		CODEC_ID_QTRLE,
		// Token: 0x04000297 RID: 663
		CODEC_ID_SNOW,
		// Token: 0x04000298 RID: 664
		CODEC_ID_TSCC,
		// Token: 0x04000299 RID: 665
		CODEC_ID_ULTI,
		// Token: 0x0400029A RID: 666
		CODEC_ID_QDRAW,
		// Token: 0x0400029B RID: 667
		CODEC_ID_VIXL,
		// Token: 0x0400029C RID: 668
		CODEC_ID_QPEG,
		// Token: 0x0400029D RID: 669
		CODEC_ID_XVID,
		// Token: 0x0400029E RID: 670
		CODEC_ID_PNG,
		// Token: 0x0400029F RID: 671
		CODEC_ID_PPM,
		// Token: 0x040002A0 RID: 672
		CODEC_ID_PBM,
		// Token: 0x040002A1 RID: 673
		CODEC_ID_PGM,
		// Token: 0x040002A2 RID: 674
		CODEC_ID_PGMYUV,
		// Token: 0x040002A3 RID: 675
		CODEC_ID_PAM,
		// Token: 0x040002A4 RID: 676
		CODEC_ID_FFVHUFF,
		// Token: 0x040002A5 RID: 677
		CODEC_ID_RV30,
		// Token: 0x040002A6 RID: 678
		CODEC_ID_RV40,
		// Token: 0x040002A7 RID: 679
		CODEC_ID_VC1,
		// Token: 0x040002A8 RID: 680
		CODEC_ID_WMV3,
		// Token: 0x040002A9 RID: 681
		CODEC_ID_LOCO,
		// Token: 0x040002AA RID: 682
		CODEC_ID_WNV1,
		// Token: 0x040002AB RID: 683
		CODEC_ID_AASC,
		// Token: 0x040002AC RID: 684
		CODEC_ID_INDEO2,
		// Token: 0x040002AD RID: 685
		CODEC_ID_FRAPS,
		// Token: 0x040002AE RID: 686
		CODEC_ID_TRUEMOTION2,
		// Token: 0x040002AF RID: 687
		CODEC_ID_BMP,
		// Token: 0x040002B0 RID: 688
		CODEC_ID_CSCD,
		// Token: 0x040002B1 RID: 689
		CODEC_ID_MMVIDEO,
		// Token: 0x040002B2 RID: 690
		CODEC_ID_ZMBV,
		// Token: 0x040002B3 RID: 691
		CODEC_ID_AVS,
		// Token: 0x040002B4 RID: 692
		CODEC_ID_SMACKVIDEO,
		// Token: 0x040002B5 RID: 693
		CODEC_ID_NUV,
		// Token: 0x040002B6 RID: 694
		CODEC_ID_KMVC,
		// Token: 0x040002B7 RID: 695
		CODEC_ID_FLASHSV,
		// Token: 0x040002B8 RID: 696
		CODEC_ID_CAVS,
		// Token: 0x040002B9 RID: 697
		CODEC_ID_JPEG2000,
		// Token: 0x040002BA RID: 698
		CODEC_ID_VMNC,
		// Token: 0x040002BB RID: 699
		CODEC_ID_VP5,
		// Token: 0x040002BC RID: 700
		CODEC_ID_VP6,
		// Token: 0x040002BD RID: 701
		CODEC_ID_VP6F,
		// Token: 0x040002BE RID: 702
		CODEC_ID_PCM_S16LE = 65536,
		// Token: 0x040002BF RID: 703
		CODEC_ID_PCM_S16BE,
		// Token: 0x040002C0 RID: 704
		CODEC_ID_PCM_U16LE,
		// Token: 0x040002C1 RID: 705
		CODEC_ID_PCM_U16BE,
		// Token: 0x040002C2 RID: 706
		CODEC_ID_PCM_S8,
		// Token: 0x040002C3 RID: 707
		CODEC_ID_PCM_U8,
		// Token: 0x040002C4 RID: 708
		CODEC_ID_PCM_MULAW,
		// Token: 0x040002C5 RID: 709
		CODEC_ID_PCM_ALAW,
		// Token: 0x040002C6 RID: 710
		CODEC_ID_PCM_S32LE,
		// Token: 0x040002C7 RID: 711
		CODEC_ID_PCM_S32BE,
		// Token: 0x040002C8 RID: 712
		CODEC_ID_PCM_U32LE,
		// Token: 0x040002C9 RID: 713
		CODEC_ID_PCM_U32BE,
		// Token: 0x040002CA RID: 714
		CODEC_ID_PCM_S24LE,
		// Token: 0x040002CB RID: 715
		CODEC_ID_PCM_S24BE,
		// Token: 0x040002CC RID: 716
		CODEC_ID_PCM_U24LE,
		// Token: 0x040002CD RID: 717
		CODEC_ID_PCM_U24BE,
		// Token: 0x040002CE RID: 718
		CODEC_ID_PCM_S24DAUD,
		// Token: 0x040002CF RID: 719
		CODEC_ID_ADPCM_IMA_QT = 69632,
		// Token: 0x040002D0 RID: 720
		CODEC_ID_ADPCM_IMA_WAV,
		// Token: 0x040002D1 RID: 721
		CODEC_ID_ADPCM_IMA_DK3,
		// Token: 0x040002D2 RID: 722
		CODEC_ID_ADPCM_IMA_DK4,
		// Token: 0x040002D3 RID: 723
		CODEC_ID_ADPCM_IMA_WS,
		// Token: 0x040002D4 RID: 724
		CODEC_ID_ADPCM_IMA_SMJPEG,
		// Token: 0x040002D5 RID: 725
		CODEC_ID_ADPCM_MS,
		// Token: 0x040002D6 RID: 726
		CODEC_ID_ADPCM_4XM,
		// Token: 0x040002D7 RID: 727
		CODEC_ID_ADPCM_XA,
		// Token: 0x040002D8 RID: 728
		CODEC_ID_ADPCM_ADX,
		// Token: 0x040002D9 RID: 729
		CODEC_ID_ADPCM_EA,
		// Token: 0x040002DA RID: 730
		CODEC_ID_ADPCM_G726,
		// Token: 0x040002DB RID: 731
		CODEC_ID_ADPCM_CT,
		// Token: 0x040002DC RID: 732
		CODEC_ID_ADPCM_SWF,
		// Token: 0x040002DD RID: 733
		CODEC_ID_ADPCM_YAMAHA,
		// Token: 0x040002DE RID: 734
		CODEC_ID_ADPCM_SBPRO_4,
		// Token: 0x040002DF RID: 735
		CODEC_ID_ADPCM_SBPRO_3,
		// Token: 0x040002E0 RID: 736
		CODEC_ID_ADPCM_SBPRO_2,
		// Token: 0x040002E1 RID: 737
		CODEC_ID_AMR_NB = 73728,
		// Token: 0x040002E2 RID: 738
		CODEC_ID_AMR_WB,
		// Token: 0x040002E3 RID: 739
		CODEC_ID_RA_144 = 77824,
		// Token: 0x040002E4 RID: 740
		CODEC_ID_RA_288,
		// Token: 0x040002E5 RID: 741
		CODEC_ID_ROQ_DPCM = 81920,
		// Token: 0x040002E6 RID: 742
		CODEC_ID_INTERPLAY_DPCM,
		// Token: 0x040002E7 RID: 743
		CODEC_ID_XAN_DPCM,
		// Token: 0x040002E8 RID: 744
		CODEC_ID_SOL_DPCM,
		// Token: 0x040002E9 RID: 745
		CODEC_ID_MP2 = 86016,
		// Token: 0x040002EA RID: 746
		CODEC_ID_MP3,
		// Token: 0x040002EB RID: 747
		CODEC_ID_AAC,
		// Token: 0x040002EC RID: 748
		CODEC_ID_MPEG4AAC,
		// Token: 0x040002ED RID: 749
		CODEC_ID_AC3,
		// Token: 0x040002EE RID: 750
		CODEC_ID_DTS,
		// Token: 0x040002EF RID: 751
		CODEC_ID_VORBIS,
		// Token: 0x040002F0 RID: 752
		CODEC_ID_DVAUDIO,
		// Token: 0x040002F1 RID: 753
		CODEC_ID_WMAV1,
		// Token: 0x040002F2 RID: 754
		CODEC_ID_WMAV2,
		// Token: 0x040002F3 RID: 755
		CODEC_ID_MACE3,
		// Token: 0x040002F4 RID: 756
		CODEC_ID_MACE6,
		// Token: 0x040002F5 RID: 757
		CODEC_ID_VMDAUDIO,
		// Token: 0x040002F6 RID: 758
		CODEC_ID_SONIC,
		// Token: 0x040002F7 RID: 759
		CODEC_ID_SONIC_LS,
		// Token: 0x040002F8 RID: 760
		CODEC_ID_FLAC,
		// Token: 0x040002F9 RID: 761
		CODEC_ID_MP3ADU,
		// Token: 0x040002FA RID: 762
		CODEC_ID_MP3ON4,
		// Token: 0x040002FB RID: 763
		CODEC_ID_SHORTEN,
		// Token: 0x040002FC RID: 764
		CODEC_ID_ALAC,
		// Token: 0x040002FD RID: 765
		CODEC_ID_WESTWOOD_SND1,
		// Token: 0x040002FE RID: 766
		CODEC_ID_GSM,
		// Token: 0x040002FF RID: 767
		CODEC_ID_QDM2,
		// Token: 0x04000300 RID: 768
		CODEC_ID_COOK,
		// Token: 0x04000301 RID: 769
		CODEC_ID_TRUESPEECH,
		// Token: 0x04000302 RID: 770
		CODEC_ID_TTA,
		// Token: 0x04000303 RID: 771
		CODEC_ID_SMACKAUDIO,
		// Token: 0x04000304 RID: 772
		CODEC_ID_QCELP,
		// Token: 0x04000305 RID: 773
		CODEC_ID_DVD_SUBTITLE = 94208,
		// Token: 0x04000306 RID: 774
		CODEC_ID_DVB_SUBTITLE,
		// Token: 0x04000307 RID: 775
		CODEC_ID_MPEG2TS = 131072
	}

	// Token: 0x0200007D RID: 125
	public enum 826
	{
		// Token: 0x04000309 RID: 777
		CODEC_TYPE_UNKNOWN = -1,
		// Token: 0x0400030A RID: 778
		CODEC_TYPE_VIDEO,
		// Token: 0x0400030B RID: 779
		CODEC_TYPE_AUDIO,
		// Token: 0x0400030C RID: 780
		CODEC_TYPE_DATA,
		// Token: 0x0400030D RID: 781
		CODEC_TYPE_SUBTITLE
	}

	// Token: 0x0200007E RID: 126
	// (Invoke) Token: 0x060002B3 RID: 691
	public delegate void 827(IntPtr 1);

	// Token: 0x0200007F RID: 127
	// (Invoke) Token: 0x060002B7 RID: 695
	public delegate void 828(IntPtr 1, IntPtr 2, [MarshalAs(UnmanagedType.LPArray, SizeConst = 4, SizeParamIndex = 0)] int[] 3, int 4, int 5, int 6);

	// Token: 0x02000080 RID: 128
	// (Invoke) Token: 0x060002BB RID: 699
	public delegate int 829(IntPtr 1, [MarshalAs(UnmanagedType.FunctionPtr)] 817.871 2, [MarshalAs(UnmanagedType.LPArray)] IntPtr[] 3, ref int 4, int 5);

	// Token: 0x02000081 RID: 129
	// (Invoke) Token: 0x060002BF RID: 703
	public delegate int 830(IntPtr 1, IntPtr 2);

	// Token: 0x02000082 RID: 130
	// (Invoke) Token: 0x060002C3 RID: 707
	public delegate 817.832 831(IntPtr 1, IntPtr 2);

	// Token: 0x02000083 RID: 131
	public enum 832
	{
		// Token: 0x0400030F RID: 783
		PIX_FMT_NONE = -1,
		// Token: 0x04000310 RID: 784
		PIX_FMT_YUV420P,
		// Token: 0x04000311 RID: 785
		PIX_FMT_YUYV422,
		// Token: 0x04000312 RID: 786
		PIX_FMT_RGB24,
		// Token: 0x04000313 RID: 787
		PIX_FMT_BGR24,
		// Token: 0x04000314 RID: 788
		PIX_FMT_YUV422P,
		// Token: 0x04000315 RID: 789
		PIX_FMT_YUV444P,
		// Token: 0x04000316 RID: 790
		PIX_FMT_RGB32,
		// Token: 0x04000317 RID: 791
		PIX_FMT_YUV410P,
		// Token: 0x04000318 RID: 792
		PIX_FMT_YUV411P,
		// Token: 0x04000319 RID: 793
		PIX_FMT_RGB565,
		// Token: 0x0400031A RID: 794
		PIX_FMT_RGB555,
		// Token: 0x0400031B RID: 795
		PIX_FMT_GRAY8,
		// Token: 0x0400031C RID: 796
		PIX_FMT_MONOWHITE,
		// Token: 0x0400031D RID: 797
		PIX_FMT_MONOBLACK,
		// Token: 0x0400031E RID: 798
		PIX_FMT_PAL8,
		// Token: 0x0400031F RID: 799
		PIX_FMT_YUVJ420P,
		// Token: 0x04000320 RID: 800
		PIX_FMT_YUVJ422P,
		// Token: 0x04000321 RID: 801
		PIX_FMT_YUVJ444P,
		// Token: 0x04000322 RID: 802
		PIX_FMT_XVMC_MPEG2_MC,
		// Token: 0x04000323 RID: 803
		PIX_FMT_XVMC_MPEG2_IDCT,
		// Token: 0x04000324 RID: 804
		PIX_FMT_UYVY422,
		// Token: 0x04000325 RID: 805
		PIX_FMT_UYYVYY411,
		// Token: 0x04000326 RID: 806
		PIX_FMT_BGR32,
		// Token: 0x04000327 RID: 807
		PIX_FMT_BGR565,
		// Token: 0x04000328 RID: 808
		PIX_FMT_BGR555,
		// Token: 0x04000329 RID: 809
		PIX_FMT_BGR8,
		// Token: 0x0400032A RID: 810
		PIX_FMT_BGR4,
		// Token: 0x0400032B RID: 811
		PIX_FMT_BGR4_BYTE,
		// Token: 0x0400032C RID: 812
		PIX_FMT_RGB8,
		// Token: 0x0400032D RID: 813
		PIX_FMT_RGB4,
		// Token: 0x0400032E RID: 814
		PIX_FMT_RGB4_BYTE,
		// Token: 0x0400032F RID: 815
		PIX_FMT_NV12,
		// Token: 0x04000330 RID: 816
		PIX_FMT_NV21,
		// Token: 0x04000331 RID: 817
		PIX_FMT_RGB32_1,
		// Token: 0x04000332 RID: 818
		PIX_FMT_BGR32_1,
		// Token: 0x04000333 RID: 819
		PIX_FMT_NB
	}

	// Token: 0x02000084 RID: 132
	// (Invoke) Token: 0x060002C7 RID: 711
	public delegate int 890(IntPtr 1, IntPtr 2);

	// Token: 0x02000085 RID: 133
	// (Invoke) Token: 0x060002CB RID: 715
	public delegate void 891(IntPtr 1, IntPtr 2);

	// Token: 0x02000086 RID: 134
	// (Invoke) Token: 0x060002CF RID: 719
	public delegate void 892(IntPtr 1, IntPtr 2, int 3, int 4);

	// Token: 0x02000087 RID: 135
	public enum 893
	{
		// Token: 0x04000335 RID: 821
		SAMPLE_FMT_NONE = -1,
		// Token: 0x04000336 RID: 822
		SAMPLE_FMT_U8,
		// Token: 0x04000337 RID: 823
		SAMPLE_FMT_S16,
		// Token: 0x04000338 RID: 824
		SAMPLE_FMT_S24,
		// Token: 0x04000339 RID: 825
		SAMPLE_FMT_S32,
		// Token: 0x0400033A RID: 826
		SAMPLE_FMT_FLT
	}
}
