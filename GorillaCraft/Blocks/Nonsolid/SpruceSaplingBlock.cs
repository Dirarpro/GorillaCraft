﻿using GorillaCraft.Interfaces;
using GorillaCraft.Models;
using GorillaCraft.Sounds;
using System;

namespace GorillaCraft.Blocks.Nonsolid
{
    public class SpruceSaplingBlock : IBlock
    {
        public BlockFaceInfo Front => new("SpurceSapling", typeof(Surface_Grass));
        public BlockFaceInfo Left => new("SpurceSapling", typeof(Surface_Grass));
        public BlockFaceInfo Back => new("SpurceSapling", typeof(Surface_Grass));
        public BlockFaceInfo Right => new("SpurceSapling", typeof(Surface_Grass));
        public BlockFaceInfo Up => new("SpurceSapling", typeof(Surface_Grass));
        public BlockFaceInfo Down => new("SpurceSapling", typeof(Surface_Grass));

        public Type PlaceSoundType => typeof(Interaction_Grass);
        public Type DestroySoundType => typeof(Interaction_Grass);

        public string BlockDefinition => "Spruce Sapling";
        public BlockForm BlockForm => BlockForm.Nonsolid;
        public BlockPlacement BlockPlacement => BlockPlacement.Default;
    }
}
