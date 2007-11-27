//Title:			Application.cpp
//Purpose:			Interface for the Simulation
//Author:			Matthew Wamboldt
//Date: 			November 13th, 2007
//Last Modified:	November 26th, 2007

#include "Simulation.h"
#include <iostream>
#include <windows.h>
#include <conio.h>
using namespace std;
int main(){
	//used to slow down simulation and lower cpu usage
	const int APPSPEED = 10;

	//sets the variabes to manipulate the console
	HANDLE handle = GetStdHandle(STD_OUTPUT_HANDLE);
	SMALL_RECT screen_area = {0, 0, 41, 44};
	COORD new_size = {42, 45};
	CONSOLE_CURSOR_INFO console_info;
	console_info.dwSize = 10;
	console_info.bVisible = false;

	//alters console window to fit perfectly
	//and hides the cursor
	SetConsoleCursorInfo(handle, &console_info);
	SetConsoleTitle("Doodlebugs Vs. Ants");
	SetConsoleWindowInfo(handle, true, &screen_area);
	SetConsoleScreenBufferSize(handle, new_size);

	//begins and runs simulation
	cout << "Welcome to Doodlebugs vs. Ants.\n"
		<< "Press q to quit. Press enter to see\nthe next loop.";
	Simulation simulation;
	simulation.initialize();
	char quit = ' ';
	while( quit != 'q' ){
		if( _kbhit() ){
			quit = char(_getch());
			if( quit == '\r' ){
				simulation.perform_time_step();
				Sleep(1000 / APPSPEED);
			}
		}else{
			Sleep(1000 / APPSPEED);
		}
	}
	return 0;
}
