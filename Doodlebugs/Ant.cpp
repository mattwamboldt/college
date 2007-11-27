//Title:			Ant.cpp
//Purpose:			Code to perform functions of the Ant class
//Author:			Matthew Wamboldt
//Date: 			November 13th, 2007
//Last Modified:	November 26th, 2007
#include "Ant.h"
#include "Simulation.h"

//increments age, sets the previous position, finds a square
//then changes it's position in the world
void Ant::move(){
	my_age++;
	my_last_x_position = my_x_position;
	my_last_y_position = my_y_position;
	switch(find_empty_square()){
		case 1:
			my_y_position -= 1;
			break;

		case 2:
			my_x_position += 1;
			break;

		case 3:
			my_y_position += 1;
			break;

		case 4:
			my_x_position -= 1;
			break;
	}
	my_simulation->set_occupant(my_last_x_position, my_last_y_position, ' ');
	my_simulation->set_occupant(my_x_position, my_y_position, 'O');
}

//performs breeding by looking for an empty square
//and only moving when found
void Ant::breed(){
	if(my_age == 3){
		my_age = 0;
		int new_ant_x = my_x_position;
		int new_ant_y = my_y_position;
		switch(find_empty_square()){
			case 1:
				new_ant_y -= 1;
				break;

			case 2:
				new_ant_x += 1;
				break;

			case 3:
				new_ant_y += 1;
				break;

			case 4:
				new_ant_x -= 1;
				break;
		}
		if( new_ant_x != my_x_position || new_ant_y != my_y_position )
		{
			Ant new_ant = Ant(new_ant_x, new_ant_y,
							my_x_position, my_y_position, my_simulation);
			my_simulation->add_new_ant(new_ant);
		}
	}
}
