﻿using GorillaCraft.Interfaces;
using GorillaCraft.Models;
using GorillaCraft.Sounds;
using System;

namespace GorillaCraft.Blocks.Solid
{
    public class DiamondOreBlock : IBlock
    {
        public BlockFaceInfo Front => new("DiamondOre", typeof(Surface_Default));
        public BlockFaceInfo Left => new("DiamondOre", typeof(Surface_Default));
        public BlockFaceInfo Back => new("DiamondOre", typeof(Surface_Default));
        public BlockFaceInfo Right => new("DiamondOre", typeof(Surface_Default));
        public BlockFaceInfo Top => new("DiamondOre", typeof(Surface_Default));
        public BlockFaceInfo Bottom => new("DiamondOre", typeof(Surface_Default));

        public Type PlaceSound => typeof(Interaction_Default);
        public Type BreakSound => typeof(Interaction_Default);

        public string Definition => "Diamond Ore";
        public BlockForm Form => BlockForm.Solid;
        public BlockPlacement Placement => BlockPlacement.Default;
    }
}
