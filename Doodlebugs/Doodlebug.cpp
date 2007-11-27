//Title:			Doodlebug.cpp
//Purpose:			Functions for the class Doodlebug
//Author:			Matthew Wamboldt
//Date: 			November 13th, 2007
//Last Modified:	November 26th, 2007
#include "Doodlebug.h"
#include "Simulation.h"

//increments age, sets the previous position 
//then looks for ant, if none nearby then it finds a square
//and changes it's position in the world
void Doodlebug::move(){

	my_age++;
	my_last_x_position = my_x_position;
	my_last_y_position = my_y_position;

	//checking for an ant around the doodlebug
	if( my_simulation->check_occupant(my_x_position, my_y_position - 1, 'O')){
		my_y_position -= 1;
		my_starving_count = 0;

	}else if( my_simulation->check_occupant(my_x_position + 1, my_y_position, 'O') ){
		my_x_position += 1;
		my_starving_count = 0;

	}else if( my_simulation->check_occupant(my_x_position, my_y_position + 1, 'O') ){
		my_y_position += 1;
		my_starving_count = 0;

	}else if( my_simulation->check_occupant(my_x_position - 1, my_y_position, 'O') ){
		my_x_position -= 1;
		my_starving_count = 0;

	}else{
		my_starving_count++;
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
	}
	my_simulation->set_occupant(my_last_x_position, my_last_y_position, ' ');
	my_simulation->set_occupant(my_x_position, my_y_position, 'X');
}

//performs breeding by looking for an empty square
//and only moving when found
void Doodlebug::breed(){
	if(my_age == 8){
		my_age = 0;
		int new_doodlebug_x = my_x_position;
		int new_doodlebug_y = my_y_position;
		switch(find_empty_square()){
			case 1:
				new_doodlebug_y -= 1;
				break;

			case 2:
				new_doodlebug_x += 1;
				break;

			case 3:
				new_doodlebug_y += 1;
				break;

			case 4:
				new_doodlebug_x -= 1;
				break;
		}
		if( new_doodlebug_x != my_x_position || new_doodlebug_y != my_y_position ){
			my_simulation->add_new_doodlebug(
				Doodlebug(new_doodlebug_x, new_doodlebug_y, my_x_position,
				my_y_position, my_simulation));
		}
	}
}
