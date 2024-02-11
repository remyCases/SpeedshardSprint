call.i gml_Script_scr_getAgredMobsCount(argc=0)
conv.v.b
bf [802]

:[801]
push.v self.step
push.e 1
add.i.v
pop.v.v self.step
b [803]

:[802]
push.v self.step
pushglb.v global.tiles_by_turn
add.v.v
pop.v.v self.step

:[803]