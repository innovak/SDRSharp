using System;

namespace SDRSharp.FrontEnds.SpyServer
{
	[Flags]
	public enum MessageType : uint
	{
		MSG_TYPE_DEVICE_INFO = 0u,
		MSG_TYPE_CLIENT_SYNC = 1u,
		MSG_TYPE_PONG = 2u,
		MSG_TYPE_READ_SETTING = 3u,
		MSG_TYPE_UINT8_IQ = 0x64,
		MSG_TYPE_INT16_IQ = 0x65,
		MSG_TYPE_INT24_IQ = 0x66,
		MSG_TYPE_FLOAT_IQ = 0x67,
		MSG_TYPE_UINT8_AF = 0xC8,
		MSG_TYPE_INT16_AF = 0xC9,
		MSG_TYPE_INT24_AF = 0xCA,
		MSG_TYPE_FLOAT_AF = 0xCB,
		MSG_TYPE_DINT4_FFT = 0x12C,
		MSG_TYPE_UINT8_FFT = 0x12D
	}
}
