// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLPageBlockAuthorDate : TLPageBlockBase 
	{
		public TLRichTextBase Author { get; set; }
		public Int32 PublishedDate { get; set; }

		public TLPageBlockAuthorDate() { }
		public TLPageBlockAuthorDate(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.PageBlockAuthorDate; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			Author = TLFactory.Read<TLRichTextBase>(from, cache);
			PublishedDate = from.ReadInt32();
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0xBAAFE5E0);
			to.WriteObject(Author, cache);
			to.Write(PublishedDate);
			if (cache) WriteToCache(to);
		}
	}
}