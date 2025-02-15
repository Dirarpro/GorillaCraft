﻿using GorillaCraft.Interfaces;
using GorillaCraft.Models;
using GorillaCraft.Sounds;
using System;

namespace GorillaCraft.Blocks.Solid
{
    public class PolishedGraniteBlock : IBlock
    {
        public BlockFaceInfo Front => new("Polished Granite", typeof(Surface_Default));
        public BlockFaceInfo Left => new("Polished Granite", typeof(Surface_Default));
        public BlockFaceInfo Back => new("Polished Granite", typeof(Surface_Default));
        public BlockFaceInfo Right => new("Polished Granite", typeof(Surface_Default));
        public BlockFaceInfo Top => new("Polished Granite", typeof(Surface_Default));
        public BlockFaceInfo Bottom => new("Polished Granite", typeof(Surface_Default));

        public Type PlaceSound => typeof(Interaction_Default);
        public Type BreakSound => typeof(Interaction_Default);

        public string Definition => "Polished Granite";
        public BlockForm Form => BlockForm.Solid;
        public BlockPlacement Placement => BlockPlacement.Default;
    }
}
