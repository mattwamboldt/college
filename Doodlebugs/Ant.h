//Title:			Ant.h
//Purpose:			Definition for the inherited class Ant
//Author:			Matthew Wamboldt
//Date: 			November 13th, 2007
//Last Modified:	November 26th, 2007
#ifndef ANT_H
#define ANT_H
#include "Organism.h"

class Ant : public Organism{
public:
	//constructor
	Ant(int x, int y, int last_x, int last_y, Simulation *simulation)
		:Organism(x, y, last_x, last_y, simulation)
	{
		my_type = 'O';
	}
	~Ant(){}

	void move();
	void breed();
};
#endif
