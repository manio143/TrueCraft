﻿using System;
using TrueCraft.API.World;
using TrueCraft.API.Entities;
using TrueCraft.API.Windows;
using TrueCraft.API.Server;

namespace TrueCraft.API.Networking
{
    public interface IRemoteClient
    {
        IMinecraftStream MinecraftStream { get; }
        bool DataAvailable { get; }
        IWorld World { get; }
        IEntity Entity { get; }
        IWindow Inventory { get; }
        string Username { get; }
        short SelectedSlot { get; }
        ItemStack SelectedItem { get; }
        IMultiplayerServer Server { get; }
        bool EnableLogging { get; set; }

        bool Disconnected { get; }

        bool Load();
        void Save();
        void QueuePacket(IPacket packet);

        void Disconnect();

        void SendMessage(string message);
        void Log(string message, params object[] parameters);
        void OpenWindow(IWindow window);
    }
}