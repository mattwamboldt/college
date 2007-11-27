//Title:			Organism.h
//Purpose:			Definition for the class Organism
//Author:			Matthew Wamboldt
//Date: 			November 13th, 2007
//Last Modified:	November 26th, 2007
#ifndef ORGANISM_H
#define ORGANISM_H

//forward declaration to give access to the grid
class Simulation;

class Organism{
protected:
	int my_x_position;
	int my_y_position;
	int my_last_x_position;
	int my_last_y_position;
	int my_age;
	char my_type;
	Simulation *my_simulation;

	int find_empty_square();

public:
	//constructor
	Organism(int x, int y, int last_x, int last_y, Simulation *simulation)
		:my_x_position(x), my_y_position(y), my_last_x_position(last_x), my_last_y_position(last_y),
		my_age(0), my_simulation(simulation)
	{}

	virtual ~Organism(){}

	//getters for class
	int get_x_position(){
		return my_x_position;
	}
	int get_y_position(){
		return my_y_position;
	}
	int get_age(){
		return my_age;
	}
	char get_type(){
		return my_type;
	}

	//virtual functions used to move and breed bugs in subclasses
	virtual void move(){}
	virtual void breed(){}

};
#endif
