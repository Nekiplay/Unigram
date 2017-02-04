// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLInputBotInlineMessageText : TLInputBotInlineMessageBase 
	{
		[Flags]
		public enum Flag : Int32
		{
			NoWebpage = (1 << 0),
			Entities = (1 << 1),
			ReplyMarkup = (1 << 2),
		}

		public bool IsNoWebpage { get { return Flags.HasFlag(Flag.NoWebpage); } set { Flags = value ? (Flags | Flag.NoWebpage) : (Flags & ~Flag.NoWebpage); } }
		public bool HasEntities { get { return Flags.HasFlag(Flag.Entities); } set { Flags = value ? (Flags | Flag.Entities) : (Flags & ~Flag.Entities); } }
		public bool HasReplyMarkup { get { return Flags.HasFlag(Flag.ReplyMarkup); } set { Flags = value ? (Flags | Flag.ReplyMarkup) : (Flags & ~Flag.ReplyMarkup); } }

		public Flag Flags { get; set; }
		public String Message { get; set; }
		public TLVector<TLMessageEntityBase> Entities { get; set; }

		public TLInputBotInlineMessageText() { }
		public TLInputBotInlineMessageText(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.InputBotInlineMessageText; } }

		public override void Read(TLBinaryReader from)
		{
			Flags = (Flag)from.ReadInt32();
			Message = from.ReadString();
			if (HasEntities) Entities = TLFactory.Read<TLVector<TLMessageEntityBase>>(from);
			if (HasReplyMarkup) ReplyMarkup = TLFactory.Read<TLReplyMarkupBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			UpdateFlags();

			to.Write(0x3DCD7A87);
			to.Write((Int32)Flags);
			to.Write(Message);
			if (HasEntities) to.WriteObject(Entities);
			if (HasReplyMarkup) to.WriteObject(ReplyMarkup);
		}

		private void UpdateFlags()
		{
			HasEntities = Entities != null;
			HasReplyMarkup = ReplyMarkup != null;
		}
	}
}