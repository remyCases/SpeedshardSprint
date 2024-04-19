// Copyright (C) 2024 Rémy Cases
// See LICENSE file for extended copyright information.
// This file is part of the Speedshard repository from https://github.com/remyCases/SpeedshardSprint.

using ModShardLauncher;
using ModShardLauncher.Mods;

namespace Speedshard_Sprint;
public class SpeedshardSprint : Mod
{
    public override string Author => "zizani";
    public override string Name => "Speedshard - Sprint";
    public override string Description => "Walking more tiles by turn";
    public override string Version => "1.0.0.0";
    public override string TargetVersion => "0.8.2.10";

    public override void PatchMod()
    {
        Msl.AddMenu("Sprint", 
            new UIComponent(name:"Tiles walked by turn", associatedGlobal:"tiles_by_turn", UIComponentType.Slider, (2, 5), 4)
        );

        Msl.LoadGML("gml_GlobalScript_scr_turn")
            .MatchFrom("var _x = path_get_point_x(path, step)\nvar _y = path_get_point_y(path, step)")
            .ReplaceBy(ModFiles, "turn.gml")
            .Save();
            
        Msl.LoadAssemblyAsString("gml_Object_o_player_Step_0")
            .MatchBelow(":[35]", 4)
            .ReplaceBy(ModFiles, "step_turn.asm")
            .Save();
    }
}
