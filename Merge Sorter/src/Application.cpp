//Title:	Employee file sort application
//Author:	Matthew Wamboldt
//Date:		February 24th, 2008
//Version:	1.0

#include <iostream>
#include <fstream>
#include <string>
#include <cstring>
#include <cstdlib>
#include "Employee.h"
using namespace std;

//splits the file. Type requires definitions of >>, <<, =, >
//returns false if the file is already sorted and was not split.
template<class Type>
bool Split( char *, char *, char * );

//merges files in a sorted way. Type requires definitions of <<, >>, =, <=, >
template<class Type>
void Merge( char *, char *, char * );

//performs splits and merges until file is sorted Type requires same definitions as merge and split
template<class Type>
void MergeSort( char * );

int main( int argumentCount, char* argumentValues[] )
{
	//test proper command line structure
	if( argumentCount != 4 || strcmp( argumentValues[2], "-field" ) )
	{
		cout << argumentCount << argumentValues[2] << endl;
		cout << "Error, Usage:\n\t MergeSort filename -field fieldnumber" << endl;
		return -1;
	}

	//test input file
	ifstream test( argumentValues[1] );
	if( !test.is_open() )
	{
		cout << "Error opening file." << endl;
		return -2;
	}
	test.close();

	//test field number
	int field = atoi( argumentValues[3] );
	if( field < 1 || field > 15 )
	{
		cout << "Error, fieldnumber must be between 1 and 15 inclusive." << endl;
		return -3;
	}
	
	//perform mergesort
	Employee::SetCompareField( field );
	MergeSort<Employee>( argumentValues[1] );
	return 0;
}

template<class Type>
bool Split( char *infile, const char *outfile1, const char *outfile2 )
{
	ifstream input( infile );
	ofstream output1( outfile1 );
	ofstream output2( outfile2 );

	//used to change streams
	ofstream* currentOutput = &output1;
	bool changedStreams = false;
	Type currentItem;
	Type nextItem;

	input >> nextItem;

	while( !input.eof() )
	{
		currentItem = nextItem;

		input >> nextItem;

		//output to the current stream
		*currentOutput << currentItem;

		if( currentItem > nextItem )
		{
			//change output streams
			changedStreams = true;
			if( currentOutput == &output1 )
			{
				currentOutput = &output2;
			}
			else
			{
				currentOutput = &output1;
			}
		}
	}

	input.close();
	output1.close();
	output2.close();

	//tells us if the file is already sorted
	return changedStreams;
}

template<class Type>
void Merge( char *outfile, const char *infile1, const char *infile2 )
{
	//create streams
	ofstream output( outfile );
	ifstream rightInput( infile1 );
	ifstream leftInput( infile2 );

	Type rightItem;
	Type leftItem;
	Type lastEntered;
	bool firstWasEntered = false;

	//get the first value from both files
	rightInput >> rightItem;
	leftInput >> leftItem;

	// loop until the end of one of the split files
	while( !rightInput.eof() && !leftInput.eof() )
	{
		if( firstWasEntered )
		{
			if( (rightItem <= leftItem && rightItem >= lastEntered)
				|| (leftItem < rightItem && leftItem < lastEntered) )
			{
				//insert right
				lastEntered = rightItem;
				output << rightItem;
				rightInput >> rightItem;
			}
			else
			{
				//insert left
				lastEntered = leftItem;
				output << leftItem;
				leftInput >> leftItem;
			}
		}
		else
		{
			//place the first item in the list
			if( rightItem <= leftItem )
			{
				lastEntered = rightItem;
				output << rightItem;
				rightInput >> rightItem;
			}
			else
			{
				lastEntered = leftItem;
				output << leftItem;
				leftInput >> leftItem;
			}
			firstWasEntered = true;
		}
	}

	// write rest of the file
	while( !leftInput.eof() )
	{
	output << leftItem;
	leftInput >> leftItem;
	}

	while( !rightInput.eof() )
	{
	output << rightItem;
	rightInput >> rightItem;
	}

	output.close();
	rightInput.close();
	leftInput.close();
}

template<class Type>
void MergeSort( char *filename )
{
	//temp files use for the sort
	const char *temp1 = "tempfile1.txt";
	const char *temp2 = "tempfile2.txt";

	//performs the split and merge functions as necessary
	while( Split<Type>( filename, temp1, temp2 ) )
	{
		Merge<Type>( filename, temp1, temp2 );
	}

	//removes the temp files
	system( "del tempfile1.txt, tempfile2.txt" );
}
