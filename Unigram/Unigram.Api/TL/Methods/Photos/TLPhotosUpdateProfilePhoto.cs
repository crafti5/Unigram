// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Photos
{
	/// <summary>
	/// RCP method photos.updateProfilePhoto
	/// </summary>
	public partial class TLPhotosUpdateProfilePhoto : TLObject
	{
		public TLInputPhotoBase Id { get; set; }

		public TLPhotosUpdateProfilePhoto() { }
		public TLPhotosUpdateProfilePhoto(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.PhotosUpdateProfilePhoto; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			Id = TLFactory.Read<TLInputPhotoBase>(from, cache);
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0xF0BB5152);
			to.WriteObject(Id, cache);
			if (cache) WriteToCache(to);
		}
	}
}