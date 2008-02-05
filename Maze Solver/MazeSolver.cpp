#include <iostream>
#include <fstream>
#include "Maze.h"
using namespace std;

int main( int argumentCount, char** argumentValues )
{
	if( argumentCount < 2 )
	{
		cout << "Usage - MazeSolver filename\n";
	}
	else
	{
		char* filename = argumentValues[1];
		ifstream inStream( filename );

		if( inStream.is_open() )
		{
			//read the file into a 2d char array
			char mapInput[51][51];

			for( int i = 0; i < 51; i++ )
			{
				for( int j = 0; j < 51; j++ )
				{
					char temp = inStream.get();

					if( inStream.eof() )
					{
						cout << "Error loading file";
						inStream.clear();
						inStream.close();
						return 1;
					}

					if( temp == '\n' )
					{
						cout << "File must be 51 characters by 51 characters\n";
						inStream.close();
						return 1;
					}
					mapInput[j][i] = temp;
					
					//eliminates newline from the end of the line
					if( j == 50 )
					{
						inStream.ignore(256, '\n');
					}
				}
			}
			inStream.close();
			Maze maze;
			//parse the array into maze data
			maze.parse( mapInput );

			if( maze.solve() )
			{
				cout << "Can solve maze.\n";
				maze.presentSolution(mapInput);
				string sol = "solution.txt";
				ofstream outStream(sol.c_str());
				for( int i = 0; i < 51; i++ )
				{
					for( int j = 0; j < 51; j++ )
					{
						outStream << mapInput[j][i];
					}
					outStream << '\n';
				}
				outStream.close();
			}
			else
			{
				cout << "Could not solve maze\n";
			}

		}
		else
		{
			cout << "Error opening file\n";
		}
	}
}
