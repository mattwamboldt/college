#include "Maze.h"

void Maze::parse(char incomingArray[][51])
{
	for( int i = 0; i < 51; i++ )
	{
		for( int j = 0; j < 51; j++ )
		{
			if( i % 2 == 1 && j % 2 == 1 )
			{
				myTileGrid[j/2][i/2].hasTopWall = (incomingArray[j][i - 1] == '-');
				myTileGrid[j/2][i/2].hasBottomWall = (incomingArray[j][i + 1] == '-');
				myTileGrid[j/2][i/2].hasLeftWall = (incomingArray[j - 1][i] == '|');
				myTileGrid[j/2][i/2].hasRightWall = (incomingArray[j + 1][i] == '|');
			}
		}
	}
}

bool Maze::solve()
{
	Point start;
	start.x = -1;
	start.y = -1;
	Point end = start;

	//check top for empty spots
	for( int i = 0; i < 25; i++ )
	{
		if( !myTileGrid[i][0].hasTopWall )
		{
			if(start.x == -1)
			{
				start.x = i;
				start.y = 0;
				facing = DOWN;
			}
			else if(end.x == -1)
			{
				end.x = i;
				end.y = 0;
			}
			else
			{
				return false;
			}
		}
	}

	//check right for empty spots
	for( int i = 0; i < 25; i++ )
	{
		if( !myTileGrid[24][i].hasRightWall )
		{
			if(start.x == -1)
			{
				start.x = 24;
				start.y = i;
				facing = LEFT;
			}
			else if( end.x == -1 )
			{
				end.x = 24;
				end.y = i;
			}
			else
			{
				return false;
			}
		}
	}

	//check bottom for empty spots
	for( int i = 24; i >= 0; i-- )
	{
		if( !myTileGrid[i][24].hasBottomWall )
		{
			if(start.x == -1)
			{
				start.x = i;
				start.y = 24;
				facing = UP;
			}
			else if(end.x == -1)
			{
				end.x = i;
				end.y = 24;
			}
			else
			{
				return false;
			}
		}
	}

	//check left for empty spots
	for( int i = 24; i >= 0; i-- )
	{
		if( !myTileGrid[0][i].hasLeftWall )
		{
			if(start.x == -1)
			{
				start.x = i;
				start.y = 0;
				facing = RIGHT;
			}
			else if( end.x == -1 )
			{
				end.x = i;
				end.y = 0;
			}
			else
			{
				return false;
			}
		}
	}

	//make sure entry and exit points were found
	if( start.x == -1 || end.x == -1 ) return false;

	while( start.x != end.x || start.y != end.y )
	{
		if( checkForWall( start, RIGHT ) )
		{
			if( checkForWall( start, UP ) )
			{
				if( checkForWall( start, LEFT ) )
				{
					if( !backOut( start ) ) return false;

					if( checkForWall( start, RIGHT ) )
					{
						if( checkForWall( start, DOWN ) )
						{
							turn( RIGHT );
						}
					}
					else
					{
						turn( LEFT );
					}
				}
				else
				{
					move( start, LEFT );
				}
			}
			else
			{
				move( start, UP );
			}
		}
		else
		{
			move( start, RIGHT );
		}
	}

	solutionStack.push( end );
	return true;
}

void Maze::presentSolution( char outgoingArray[][51] )
{
	while( !solutionStack.empty() )
	{
		Point temp = solutionStack.Top();
		outgoingArray[temp.x * 2 + 1][temp.y * 2 + 1] = '#';
		solutionStack.pop();
	}
}

void Maze::move( Point& position, Direction heading )
{
	solutionStack.push( position );
	Direction originalHeading = heading;

	heading = (Direction)( ( facing + heading ) % 4 );

	switch( heading )
	{
	case UP:
		--position.y;
		break;

	case RIGHT:
		++position.x;
		break;

	case DOWN:
		++position.y;
		break;

	case LEFT:
		--position.x;
		break;
	}
	turn( originalHeading );
}

bool Maze::checkForWall( Point& position, Direction heading )
{
	heading = (Direction)( ( facing + heading ) % 4 );
	switch( heading )
	{
	case UP:
		return myTileGrid[position.x][position.y].hasTopWall;
	case RIGHT:
		return myTileGrid[position.x][position.y].hasRightWall;
	case DOWN:
		return myTileGrid[position.x][position.y].hasBottomWall;
	case LEFT:
		return myTileGrid[position.x][position.y].hasLeftWall;
	}
}

bool Maze::backOut( Point& position )
{
	if( solutionStack.empty() ) return false;
	solutionStack.pop();

	switch( facing )
	{
	case UP:
		myTileGrid[position.x][position.y + 1].hasTopWall = true;
		++position.y;
		break;

	case RIGHT:
		myTileGrid[position.x - 1][position.y].hasRightWall = true;
		--position.x;
		break;

	case DOWN:
		myTileGrid[position.x][position.y - 1].hasBottomWall = true;
		--position.y;
		break;

	case LEFT:
		myTileGrid[position.x + 1][position.y].hasLeftWall = true;
		++position.x;
	}

	return true;
}

void Maze::turn( Direction heading )
{
	facing = (Direction)( ( facing + heading ) % 4 );
}
