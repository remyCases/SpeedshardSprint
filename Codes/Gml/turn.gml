var i = step
var _x = path_get_point_x(path, step)
var _y = path_get_point_y(path, step)
while (i > 0)
{
	_x = path_get_point_x(path, i)
	_y = path_get_point_y(path, i)
	if (mp_grid_get_cell(o_controller.grid, (_x / 26), (_y / 26)) == 0)
		break
	else
	{
		i -= 1
		continue
	}
}