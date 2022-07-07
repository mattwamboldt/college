//Title:			Doodlebug.h
//Purpose:			Definition for the derived class Doodlebug
//Author:			Matthew Wamboldt
//Date: 			November 13th, 2007
//Last Modified:	November 26th, 2007
#ifndef DOODLEBUG_H
#define DOODLEBUG_H
#include "Organism.h"

class Doodlebug : public Organism{
private:
	int my_starving_count;
public:
	//constructor
	Doodlebug(int x, int y, int last_x, int last_y, Simulation *simulation)
		:Organism(x, y, last_x, last_y, simulation)
	{
		my_type = 'X';
		my_starving_count = 0;
	}
	~Doodlebug(){}

	void move();
	void breed();

	//determines if the doodlebug should die
	bool is_starving(){
		return my_starving_count == 3;
	}
};
#endif
