//Title:			Organism.cpp
//Purpose:			Functions for the class Organism
//Author:			Matthew Wamboldt
//Date: 			November 14th, 2007
//Last Modified:	November 26th, 2007
#include "Organism.h"
#include "Simulation.h"
#include <cstdlib>
using std::rand;

//loops through a random choice of position to check
//until either all sides checked, or an empty space is found
//if none found it returns a -1
int Organism::find_empty_square(){
	bool tried_north = false;
	bool tried_east = false;
	bool tried_south = false;
	bool tried_west = false;
	int move;

	do{
		move = ((rand() % 4) + 1);
		switch(move){
			case 1:
				if( !tried_north && my_simulation->check_occupant(my_x_position, (my_y_position - 1), ' ') ){
					return move;
				}else{
					tried_north = true;
				}
				break;

			case 2:
				if( !tried_east && my_simulation->check_occupant((my_x_position + 1), my_y_position, ' ') ){
					return move;
				}else{
					tried_east = true;
				}
				break;

			case 3:
				if( !tried_south && my_simulation->check_occupant(my_x_position, (my_y_position + 1), ' ') ){
					return move;
				}else{
					tried_south = true;
				}
				break;

			case 4:
				if( !tried_west && my_simulation->check_occupant((my_x_position - 1), my_y_position, ' ') ){
					return move;
				}else{
					tried_west = true;
				}
		}
	}while(!tried_north || !tried_east || !tried_south || !tried_west);
	return -1;
}