#ifndef MAZE_H
#define MAZE_H

#include "Stack.h"

/*! \brief Struct to describe a tile in the Maze.

	This struct is used to hold the maze data to make the logic simpler.
	It stores where the walls are in boolean values to allow speedier solving.
*/
struct MazeTile
{
	bool hasTopWall; /*!< Tells the bot if there is a wall to the top side of the maze. */
	bool hasRightWall; /*!< Tells the bot if there is a wall to the right side of the maze. */
	bool hasBottomWall; /*!< Tells the bot if there is a wall to the bottom side of the maze. */
	bool hasLeftWall; /*!< Tells the bot if there is a wall to the left side of the maze. */
};

/*! \brief A simple struct to describe a point.

	This struct is used to store the correct spaces to solve the maze.
	Stored in x y co-ordinates.
*/
struct Point
{
	int x; /*!< The x co-ordinate. */
	int y; /*!< The y co-ordinate. */
};

/*! \brief An enum for the four directions of movement.

	This is used heavily in the solving logic to determine where the bot is facing
	and also where it should be going.
*/
enum Direction
{
	UP, /*!< Either the top of the maze, or forward to the bot. */
	RIGHT, /*!< Either the Right of the maze, or Right to the bot. */
	DOWN, /*!< Either the Bottom of the maze, or Behind to the bot. */
	LEFT /*!< Either the Left of the maze, or Left to the bot. */
};

/*! \brief Can solve, parse, and output mazes and maze data.
    \author Matthew Wamboldt
	\version 1.0
	\date February 1st, 2008

	This is a fully functional linked list implmentation of a stack.
	It uses templates to allow it to be used by any data.
*/
class Maze
{
	private:
		MazeTile myTileGrid[25][25]; /*!< Holds the maze data that is used to solve the maze. */
		Stack<Point> solutionStack; /*!< Holds the points that contain the solution to the maze. */
		Direction facing; /*!< The direction the bot is currently facing. */

		/*! \brief Looks for a wall.
		    \param[in] position The bot's current location.
			\param[in] heading The relative direction of the wall being checked.
			\return A boolean indicating whether a wall is there.
		*/
		bool checkForWall( Point& position, Direction heading );

		/*! \brief Turns the bot.
			\param[in] heading The relative direction the bot needs to turn.
		*/
		void turn( Direction heading );

		/*! \brief Moves the bot.
		    \param[in] position The bot's current location.
			\param[in] heading The relative direction to move in.
		*/
		void move( Point& position, Direction heading );

		/*! \brief Used to back out of a dead end.
		    \param[in] position The bot's current location.
		*/
		bool backOut( Point& position );
		
	public:
		/*! \brief Constructor, does nothing. */ 
		Maze(){}

		/*! \brief Destructor, does nothing. */
		~Maze(){}

		/*! \brief Parses maze data to be used by the class.
		    \param[in] incomingArray A 51 by 51 char aray to be parsed.
		*/
		void parse( char incomingArray[][51] );

		/*! \brief Attempts to solve the maze.
		    \return A boolean indicating if the maze was solvable.
		*/
		bool solve();

		/*! \brief Loads the solution into the array parameter.
		    \param[out] outgoingArray A 51 by 51 char array that will recieve the solution.
		*/
		void presentSolution( char outgoingArray[][51] );
};

#endif