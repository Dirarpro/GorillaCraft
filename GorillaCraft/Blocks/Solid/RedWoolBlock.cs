﻿using GorillaCraft.Interfaces;
using GorillaCraft.Models;
using GorillaCraft.Sounds;
using System;

namespace GorillaCraft.Blocks.Solid
{
    public class RedWoolBlock : IBlock
    {
        public BlockFaceInfo Front => new("RedWool", typeof(Surface_Cloth));
        public BlockFaceInfo Left => new("RedWool", typeof(Surface_Cloth));
        public BlockFaceInfo Back => new("RedWool", typeof(Surface_Cloth));
        public BlockFaceInfo Right => new("RedWool", typeof(Surface_Cloth));
        public BlockFaceInfo Top => new("RedWool", typeof(Surface_Cloth));
        public BlockFaceInfo Bottom => new("RedWool", typeof(Surface_Cloth));

        public Type PlaceSound => typeof(Interaction_Cloth);
        public Type BreakSound => typeof(Interaction_Cloth);

        public string Definition => "Red Wool";
        public BlockForm Form => BlockForm.Solid;
        public BlockPlacement Placement => BlockPlacement.Default;
    }
}
