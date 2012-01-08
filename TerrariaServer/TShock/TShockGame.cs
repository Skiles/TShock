﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Terraria;

namespace TShock
{
	internal class TShockGame : IGame
	{
		protected TShockPlayerList playerslist = new TShockPlayerList();
		public IList<IPlayer> Players
		{
			get
			{
				return playerslist;
			}
		}

		public void SendMessage(IPlayer ply, string msg)
		{
			NetMessage.SendData((int)PacketTypes.ChatText, ply.Id, -1, msg);
		}
	}
}
