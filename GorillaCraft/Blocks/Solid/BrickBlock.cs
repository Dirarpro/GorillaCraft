﻿using GorillaCraft.Interfaces;
using GorillaCraft.Models;
using GorillaCraft.Sounds;
using System;

namespace GorillaCraft.Blocks.Solid
{
    public class BrickBlock : IBlock
    {
        public BlockFaceInfo Front => new("Brick", typeof(Surface_Default));
        public BlockFaceInfo Left => new("Brick", typeof(Surface_Default));
        public BlockFaceInfo Back => new("Brick", typeof(Surface_Default));
        public BlockFaceInfo Right => new("Brick", typeof(Surface_Default));
        public BlockFaceInfo Top => new("Brick", typeof(Surface_Default));
        public BlockFaceInfo Bottom => new("Brick", typeof(Surface_Default));

        public Type PlaceSound => typeof(Interaction_Default);
        public Type BreakSound => typeof(Interaction_Default);

        public string Definition => "Bricks";
        public BlockForm Form => BlockForm.Solid;
        public BlockPlacement Placement => BlockPlacement.Default;
    }
}
