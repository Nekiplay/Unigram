// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLChatParticipantCreator : TLChatParticipantBase 
	{
		public TLChatParticipantCreator() { }
		public TLChatParticipantCreator(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.ChatParticipantCreator; } }

		public override void Read(TLBinaryReader from)
		{
			UserId = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xDA13538A);
			to.Write(UserId);
		}
	}
}