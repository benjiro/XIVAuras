﻿using System.Numerics;
using ImGuiNET;

namespace XIVAuras.Config
{
    public class BarStyleConfig : IConfigPage
    {
        public string Name => "Style";

        public void DrawConfig(Vector2 size)
        {
            if (ImGui.BeginChild("##BarStyleConfig", new Vector2(size.X - 16, size.Y - 67), true))
            {
                ImGui.Text("TODO");

                ImGui.EndChild();
            }
        }
    }
}