//Tic Tac Toe Game
//Author:Matthew Wamboldt
//Date: September 22
//Last Modified: October 1st
#include <iostream>
#include <windows.h>
#include <cstdlib>
#include <ctime>
using namespace std;

void printBoard(char[]);
void swapPlayers(char&);
void setGrid(char, char[], char);
void displayMessage(char &, char[], char);
bool checkWinner(char[]);
void gotoxy(int x, int y);
void redraw(void);
bool playHuman(void);
bool playAI(void);
void moveAI(char[],int, char);
int checkAIWinnable(char[], char);
int checkHumanWinnable(char[], char);

int main()
{
	srand((unsigned int)time(0));
	
	cout<<"Welcome to Tic Tac Toe 5000.\n\n";

	bool playing = true;
	while(playing)
	{
		redraw();
		gotoxy(0,2);

		cout<<"How many players(1 or 2): ";
		
		char num = ' ';
		cin>>num;

		if(num == '1')
		{
			playing = playAI();
		}
		else if(num == '2')
		{
			playing = playHuman();
		}
	}
	return 0;
}

//outputs the board
void printBoard(char grid[])
{
	for(int i = 0; i < 9; i++)
	{
		if((i == 2)||(i == 5))
		{
			cout << grid[i] << endl;
			cout << "-+-+-\n";
		}
		else if(i != 8)
		{
			cout << grid[i] << "|";
		}
		else
		{
			cout << grid[i] << "\n";
		}
	}
}

//function to switch player char
void swapPlayers(char& current)
{
	if(current == 'X')
	{
		current = 'O';
	}
	else if(current == 'O')
	{
		current = 'X';
	}
}

//converts character to ascii and subtracts 49 to get array access
//function also contains some error checking
void setGrid(char move, char board[], char player)
{
	int temp = int(move) - 49;

	while ((board[temp] == 'X')||(board[temp] == 'O')||(temp < 0)||(temp > 8))
	{
		redraw();
		
		if ((temp > 8)||(temp < 0))
		{
			cout<<"Error: Entry not on board\n\n";
		}
		else
		{
			cout<<"Space already taken!!!\n\n";
		}
		
		displayMessage(move, board, player);
		temp = int(move) - 49;
	}

	board[temp] = player; 
}

//displays board and asks for input
//seperated to mimimize code
void displayMessage(char &input, char board[], char player)
{
	printBoard(board);
	cout << "Player " << player << " pick a location 1-9, Enter q to quit: ";
	cin >> input;
}

//tests all 8 win conditions
bool checkWinner(char board[])
{
	if((board[0] == board[1] && board[0] == board[2]) ||
	   (board[0] == board[4] && board[0] == board[8]) ||
	   (board[0] == board[3] && board[0] == board[6]) ||
	   (board[1] == board[4] && board[1] == board[7]) ||
	   (board[2] == board[5] && board[2] == board[8]) ||
	   (board[2] == board[4] && board[2] == board[6]) ||
	   (board[3] == board[4] && board[3] == board[5]) ||
	   (board[6] == board[7] && board[6] == board[8]))
	{
		return true;
	}

	return false;
}

//uses windows.h to get the console handle and
//change the cursor position to something we specify
void gotoxy(int x, int y)
{
	HANDLE outputHandle;

	COORD pos;

	pos.X = x;
	pos.Y = y;

	outputHandle = GetStdHandle(STD_OUTPUT_HANDLE);

	SetConsoleCursorPosition(outputHandle, pos);
}

//repositions cursor below welcome message and draws blanks
//over current board if there
void redraw()
{
	gotoxy(0,2);
	
	for(int i = 0; i < 10; i++)
	{
		cout<<"                                                             \n";
	}

	gotoxy(0,2);
}

//gameplay for a 2 player game
bool playHuman(void)
{
	char board[] = {'1','2','3','4','5','6','7','8','9'};
	char currentPlayer = 'X';
	char move;
	int count = 0;
	char replay = ' ';

	redraw();
	displayMessage(move, board, currentPlayer);

	//game loop, inserts character in grid, and asks for 
	//next character until winner found or q pressed
	while( (move != 'q') && (move != 'Q') )
	{
		setGrid(move, board, currentPlayer);
		count++;

		if (checkWinner(board))
		{
			cout << "Congrats the winner is " << currentPlayer << "!\n";
			cout << "Would you like to play again(y/n): ";
			cin >> replay;

			return replay == 'y';
		}
		else if(count == 9)
		{
			cout << "Nobody wins!\n";
			cout << "Would you like to play again(y/n): ";
			cin >> replay;

			return replay == 'y';
		}

		swapPlayers(currentPlayer);
		redraw();
		displayMessage(move, board, currentPlayer);
	}

	if((move == 'q')||(move == 'Q'))
	{
		return false;
	}
	else
	{
		return true;
	}
}

//gameplay for a 1 player game
bool playAI(void)
{
	char board[] = {'1','2','3','4','5','6','7','8','9'};
	char currentPlayer = 'X';
	char move = 0;
	int count = 0;
	char replay = ' ';
	
	redraw();
	gotoxy(0,2);
	cout<<"Would you like to go first(1) or second(2): ";
	
	char first = ' ';
	cin >> first;

	if(first == '1')
	{
		redraw();
		displayMessage(move, board, currentPlayer);
		setGrid(move, board, currentPlayer);
	}
	else
	{
		moveAI(board, count, move);
	}
	
	count++;

	//game loop, inserts character in grid, and asks for 
	//next character until winner found or q pressed
	while((move != 'q')&&(move != 'Q'))
	{
		swapPlayers(currentPlayer);

		if((first == '1') && (currentPlayer == 'X')
			|| (first == '2') && (currentPlayer == 'O'))
		{
			redraw();
			displayMessage(move,board,currentPlayer);
			
			if((move == 'q')||(move == 'Q'))
			{
				return false;
			}

			setGrid(move, board, currentPlayer);
		}
		else
		{
			moveAI(board, count, move);
		}

		count++;
		
		if (checkWinner(board))
		{
			redraw();
			printBoard(board);
			cout<<"Congrats the winner is "<<currentPlayer<<"!\n";
			cout<<"Would you like to play again(y/n): ";
			cin>>replay;
			return replay == 'y';
		}
		else if(count == 9)
		{
			redraw();
			printBoard(board);
			cout<<"Nobody wins!\n";
			cout<<"Would you like to play again(y/n): ";
			cin>>replay;
			return replay == 'y';
		}
	}

	if((move == 'q')||(move == 'Q'))
	{
		return false;
	}
	else
	{
		return true;
	}
}

//Is the main logical AI controller
void moveAI(char board[], int count, char lastMove)
{
	char AICharacter = ' ', humanCharacter = ' ';
	int AIMove = 4;
	int humanMove = int(lastMove) - 49;

	if((count%2) == 0)
	{
		AICharacter = 'X';
		humanCharacter = 'O';
	}
	else
	{
		AICharacter = 'O';
		humanCharacter = 'X';
	}

	switch(count)
	{
		case 0:
			board[AIMove] = 'X';
			break;

		case 1:
			if(board[AIMove] == 'X')
			{
				AIMove = rand()%4;
				
				if(AIMove >= 2)
				{
					AIMove++;
				}

				AIMove *= 2;
				board[AIMove] = 'O';
			}
			else
			{
				board[AIMove] = 'O';
			}
			break;

		case 2:
			AIMove = rand()%2;
			switch(humanMove)
			{
				case 0:
					AIMove = 8;
					break;

				case 2:
					AIMove = 6;
					break;

				case 6:
					AIMove = 2;
					break;

				case 8:
					AIMove = 0;
					break;

				case 1:
					if(AIMove)
					{
						AIMove = 6;
					}
					else
					{
						AIMove = 8;
					}
					break;

				case 3:
					if(AIMove)
					{
						AIMove = 2;
					}
					else
					{
						AIMove = 8;
					}
					break;

				case 5:
					if(AIMove)
					{
						AIMove = 0;
					}
					else
					{
						AIMove = 6;
					}
					break;

				case 7:
					if(AIMove)
					{
						AIMove = 0;
					}
					else
					{
						AIMove = 2;
					}
					break;
				
				default:
					AIMove = rand()%9;
					while((board[AIMove] =='X')||(board[AIMove] == 'O'))
					{
						AIMove = rand()%9;
					}
			}

			board[AIMove] = 'X';
			break;

		case 3:
			AIMove = checkAIWinnable(board,AICharacter);
			if (AIMove == 10)
			{
				AIMove = checkHumanWinnable(board,humanCharacter);
				if (AIMove == 10)
				{
					AIMove = rand()%2;

					//Prevents computer losing in this situation
					//           X| |
					//            |X|
					//            | |O
					if (((board[4] == 'X') && (board[0] == 'X'))
						|| ((board[4] == 'X') && (board[8] == 'X')))
					{
						if(AIMove)
						{
							AIMove = 2;
						}
						else
						{
							AIMove = 6;
						}
					}
					else if(((board[4] == 'X') && (board[2] == 'X'))
							 || ((board[4] == 'X') && (board[6] == 'X')))
					{
						if(AIMove)
						{
							AIMove = 0;
						}
						else
						{
							AIMove = 8;
						}
					
					}
					//Prevents computer losing in this situation
					//           X| |
					//            |O|
					//            | |X
					else if(((board[0] == 'X') && (board[8] == 'X'))
							 || ((board[2] == 'X') && (board[6] == 'X')))
					{
						AIMove = rand()%4;
						AIMove = (AIMove * 2) + 1;
					
					}
					//Prevents computer losing in this situation
					//            |X|
					//            |O|X
					//            | |
					else if((board[1] == 'X') && (board[3] == 'X'))
					{
						AIMove = rand()%9;
						while((board[AIMove] =='X')||(board[AIMove] == 'O')||(AIMove == 8))
						{
							AIMove = rand()%9;
						}
					}
					else if((board[1] == 'X')&&(board[5] == 'X'))
					{
						AIMove = rand()%9;
						while((board[AIMove] =='X')||(board[AIMove] == 'O')||(AIMove == 6))
						{
							AIMove = rand()%9;
						}
					}
					else if((board[3] == 'X')&&(board[7] == 'X'))
					{
						AIMove = rand()%9;
						while((board[AIMove] =='X')||(board[AIMove] == 'O')||(AIMove == 2))
						{
							AIMove = rand()%9;
						}
					}
					else if((board[5] == 'X')&&(board[7] == 'X'))
					{
						AIMove = rand()%9;
						while((board[AIMove] =='X')||(board[AIMove] == 'O')||(AIMove == 0))
						{
							AIMove = rand()%9;
						}
					
					}
					//Prevents computer losing in this situation
					//            |X|
					//            |O|
					//            | |X
					else if(((board[1] == 'X')&&(board[6] == 'X'))
							|| ((board[3] == 'X')&&(board[2] == 'X')))
					{
						AIMove = 0;
					}
					else if(((board[1] == 'X')&&(board[8] == 'X'))
							|| ((board[0] == 'X')&&(board[5] == 'X')))
					{
						AIMove = 2;						
					}
					else if(((board[3] == 'X')&&(board[8] == 'X'))
							|| ((board[0] == 'X')&&(board[7] == 'X')))
					{
						AIMove = 6;						
					}
					else if(((board[2] == 'X')&&(board[7] == 'X'))
							|| ((board[6] == 'X')&&(board[5] == 'X')))
					{
						AIMove = 8;
					}
					else
					{
						AIMove = rand()%9;
						while((board[AIMove] =='X')||(board[AIMove] == 'O'))
						{
							AIMove = rand()%9;
						}
					}
				}
			}
			board[AIMove] = AICharacter;
			break;

		default:
			AIMove = checkAIWinnable(board,AICharacter);
			if (AIMove == 10)
			{
				AIMove = checkHumanWinnable(board,humanCharacter);
				if (AIMove == 10)
				{
					AIMove = rand()%9;
					while((board[AIMove] =='X')||(board[AIMove] == 'O'))
					{
						AIMove = rand()%9;
					}
				}
			}

			board[AIMove] = AICharacter;
	}
}

//used by to check if the AI can win
int checkAIWinnable(char board[], char comp)
{
	char boardDouble[] = {board[0],board[1],board[2],board[3],board[4],board[5],board[6],board[7],board[8]};
	for(int i=0; i<9; i++)
	{
		if((boardDouble[i]!= 'X')&&(boardDouble[i] != 'O'))
		{
			boardDouble[i] = comp;
			if(checkWinner(boardDouble))
			{
				return i;
			}
			else
			{
				boardDouble[i] = char((i + 49));
			}
		}
	}

	return 10;
}

//used by AI to check if the Human can win 
int checkHumanWinnable(char board[], char human)
{
	char boardDouble[] = {board[0],board[1],board[2],board[3],board[4],board[5],board[6],board[7],board[8]};
	for(int i=0; i<9; i++)
	{
		if((boardDouble[i]!= 'X')&&(boardDouble[i] != 'O'))
		{
			boardDouble[i] = human;

			if(checkWinner(boardDouble))
			{
				return i;
			}
			else
			{
				boardDouble[i] = char((i + 49));
			}
		}
	}

	return 10;
}
