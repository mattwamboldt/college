//Title:			Simulation.cpp
//Purpose:			Functions to control the Simulation
//Author:			Matthew Wamboldt
//Date: 			November 13th, 2007
//Last Modified:	November 26th, 2007
#include "Simulation.h"
#include <iostream>
#include <cstdlib>
#include <ctime>
#include <windows.h>
using namespace std;

//constructor sets world to be spaces
Simulation::Simulation(){
	for( int i = 0; i < 20; i++ ){
		for( int j = 0; j < 20; j++ ){
			world[i][j] = ' ';
		}
	}
}

//destructor empties the lists
Simulation::~Simulation(){
	ants.empty_list();
	doodlebugs.empty_list();
}

//populates the grid with 100 ants and 8 doodlebugs
void Simulation::initialize(){
	srand(unsigned(time(0)));

	//populate ants to grid
	for( int i = 0; i < 100; i++ ){
		int x = (rand() % 20);
		int y = (rand() % 20);
		while( world[x][y] != ' ' ){
			x = (rand() % 20);
			y = (rand() % 20);
		}
		ants.add_to_top(Ant(x, y, x, y, this));
		world[x][y] = 'O';
	}

	//populate doodlebugs to grid
	for(int i = 0; i < 5; i++){
		int x = (rand() % 20);
		int y = (rand() % 20);
		while( world[x][y] != ' ' ){
			x = (rand() % 20);
			y = (rand() % 20);
		}
		doodlebugs.add_to_top(Doodlebug(x, y, x, y, this));
		world[x][y] = 'X';
	}
	draw();
}

//Displays the board
void Simulation::draw(){
	move_cursor(0,3);

	//draw first row
	cout << char(201);
	for( int t = 0; t < 19; t++ ){
		cout << char(205) << char(203);
	}
	cout << char(205) << char(187) << '\n';

	//draw meat of grid
	for( int i = 0; i < 20; i++ ){

		//draw data rows
		cout << char(186);
		for( int j = 0; j < 20; j++ ){
			cout << world[i][j] << char(186);
		}
		cout << '\n';

		//draw seperator rows
		if( i != 19 ){
			cout << char(204);
			for( int t = 0; t < 19; t++ ){
				cout << char(205) << char(206);
			}
			cout << char(205) << char(185)<< '\n';
		}
	}

	//draw last row
	cout << char(200);
	for( int t = 0; t < 19; t++ ){
		cout << char(205) << char(202);
	}
	cout << char(205) << char(188) << '\n';
}

//performs the actions needed for the simulation
void Simulation::perform_time_step(){

	DoubleLinkIterator<Ant> current_ant;
	DoubleLinkIterator<Doodlebug> current_doodlebug;

	current_doodlebug = doodlebugs.get_start_of_list();
	current_ant = ants.get_start_of_list();

	//move the doodlebugs
	while( current_doodlebug != doodlebugs.get_end_of_list() ){
		(*current_doodlebug).move();
		current_doodlebug++;
	}

	//move the ants
	while( current_ant != ants.get_end_of_list() ){
		if( world[(*current_ant).get_x_position()][(*current_ant).get_y_position()] == 'X' ){
			DoubleLinkNode<Ant> *temp = current_ant.get_current_node()->get_next_link();
			ants.remove_node(current_ant.get_current_node());
			current_ant.set_current_node(temp);
		}else{
			(*current_ant).move();
			current_ant++;
		}
		
	}

	current_doodlebug = doodlebugs.get_start_of_list();
	current_ant = ants.get_start_of_list();

	//breed the doodlebugs
	while( current_doodlebug != doodlebugs.get_end_of_list() ){
		(*current_doodlebug).breed();
		if( (*current_doodlebug).is_starving() ){
			world[(*current_doodlebug).get_x_position()][(*current_doodlebug).get_y_position()] = ' ';
			DoubleLinkNode<Doodlebug> *temp = current_doodlebug.get_current_node()->get_next_link();
			doodlebugs.remove_node(current_doodlebug.get_current_node());
			current_doodlebug.set_current_node(temp);
		}else{
			current_doodlebug++;
		}

	}

	//breed the ants
	while( current_ant != ants.get_end_of_list() ){
		(*current_ant).breed();
		current_ant++;
	}

	//redraw the board
	draw();
}

//returns whether a position is free, or meets the type provided
bool Simulation::check_occupant(int x_position, int y_position, char type){
	if( x_position < 20 && y_position < 20
		&& x_position >= 0 && y_position >= 0 )
	{
		return type == world[x_position][y_position];
	}else{
		return false;
	}
}

// moves cursor in console window to position x,y
void Simulation::move_cursor(int x_position, int y_position){
	HANDLE console;

	COORD cursor_position;

	cursor_position.X = x_position;
	cursor_position.Y = y_position;

	console = GetStdHandle(STD_OUTPUT_HANDLE);

	SetConsoleCursorPosition(console, cursor_position);
}

//adds an ant to the list
void Simulation::add_new_ant(Ant& new_ant){
	ants.add_to_top(new_ant);
	world[new_ant.get_x_position()][new_ant.get_y_position()] = 'O';
}

//adds a doodlebug to the list
void Simulation::add_new_doodlebug(Doodlebug& new_doodlebug){
	doodlebugs.add_to_top(new_doodlebug);
	world[new_doodlebug.get_x_position()][new_doodlebug.get_y_position()] = 'X';
}

//allows update of whats where in the world
void Simulation::set_occupant(int x_position, int y_position, char type){
	world[x_position][y_position] = type;
}