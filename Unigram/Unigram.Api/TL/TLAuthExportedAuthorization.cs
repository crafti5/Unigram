// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLAuthExportedAuthorization : TLObject 
	{
		public Int32 Id { get; set; }
		public Byte[] Bytes { get; set; }

		public TLAuthExportedAuthorization() { }
		public TLAuthExportedAuthorization(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.AuthExportedAuthorization; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			Id = from.ReadInt32();
			Bytes = from.ReadByteArray();
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0xDF969C2D);
			to.Write(Id);
			to.WriteByteArray(Bytes);
			if (cache) WriteToCache(to);
		}
	}
}