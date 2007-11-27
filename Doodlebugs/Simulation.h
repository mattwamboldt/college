//Title:			Simulation.h
//Purpose:			Definition for the class Simulation
//Author:			Matthew Wamboldt
//Date: 			November 13th, 2007
//Last Modified:	November 25th, 2007
#ifndef SIMULATION_H
#define SIMULATION_H
#include "Ant.h"
#include "Doodlebug.h"
#include "DoubleLinkList.h"

class Simulation{
private:
	char world[20][20];
	DoubleLinkList<Ant> ants;
	DoubleLinkList<Doodlebug> doodlebugs;
	void draw();
	void move_cursor(int x_position, int y_position);

public:
	Simulation();
	~Simulation();

	void add_new_ant(Ant& new_ant);
	void add_new_doodlebug(Doodlebug& new_doodlebug);
	void initialize();
	void perform_time_step();
	bool check_occupant(int x_position, int y_position, char type);
	void set_occupant(int x_position, int y_position, char type);
};
#endif
