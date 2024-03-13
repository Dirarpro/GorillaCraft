﻿using GorillaCraft.Interfaces;
using GorillaCraft.Models;
using GorillaCraft.Sounds;
using System;

namespace GorillaCraft.Blocks.Solid
{
    public class DarkOakPlanksBlock : IBlock
    {
        public BlockFaceInfo Front => new("DarkOakPlanks", typeof(Surface_Wood));
        public BlockFaceInfo Left => new("DarkOakPlanks", typeof(Surface_Wood));
        public BlockFaceInfo Back => new("DarkOakPlanks", typeof(Surface_Wood));
        public BlockFaceInfo Right => new("DarkOakPlanks", typeof(Surface_Wood));
        public BlockFaceInfo Top => new("DarkOakPlanks", typeof(Surface_Wood));
        public BlockFaceInfo Bottom => new("DarkOakPlanks", typeof(Surface_Wood));

        public Type PlaceSoundType => typeof(Interaction_Wood);
        public Type DestroySoundType => typeof(Interaction_Wood);

        public string BlockDefinition => "Dark Oak Planks";
        public BlockForm BlockForm => BlockForm.Solid;
        public BlockPlacement BlockPlacement => BlockPlacement.Default;
    }
}
