pushloc.v local._is_enemy
conv.v.b
not.b
bf [802]

:[801]
pushglb.v global.tiles_by_turn
push.e 1
sub.i.v
push.v self.step
add.v.v
pop.v.v self.step

:[802]