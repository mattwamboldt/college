#include "SpellChecker.h"
bool SpellChecker::LoadDictionary(string fileName)
{
	ifstream input;
	input.open( fileName.c_str() );

	//file not found
	if(input.fail())
	{
		return false;
	}

	//reads each string from the file and inserts it into
	//the dictionary tree
	string temp = "";
	while( !input.eof() )
	{
		input >> temp;
		myDictionary.Insert( new string( temp ) );
	}
	input.close();

	//writes the tree to disk for test purposes
	ofstream treeOut( "data/dictTree.txt" );
	treeOut << myDictionary;
	treeOut.close();

	return true;
}

bool SpellChecker::LoadFileToCheck( string filename )
{
	ifstream input;
	input.open( filename.c_str() );

	//file not found
	if( input.fail() )
	{
		return false;
	}

	//reads each string from the file and pushes it onto
	//a stack after converting it to lower case and remove punctuation
	string temp = "";
	while( !input.eof() )
	{
		input >> temp;
		myWords.Push( toLower( removePunctuation( temp ) ) );
	}
	input.close();
	return true;
}

void SpellChecker::DisplayErrors( ostream& output )
{
	//copies the stack to allow multiple displays
	Stack<string> wordCopy = myWords;

	//looks for each element of the copied stack in the bst
	while( !wordCopy.Empty() )
	{
		string temp = wordCopy.Pop();

		//outputs the error
		if( !myDictionary.Find( temp ) )
		{
			output << temp << " was not found in dictionary.\n";
		}
	}
}

string SpellChecker::removePunctuation( string input )
{
	//searches for punctuation characters until they are all gone
	size_t i = 0;
	while( i < input.size() )
	{
		if( isdigit(input[i]) || ispunct(input[i]) )
		{
			//delete the character and continue searching
			input.erase( i, 1 );
		}
		else
		{
			++i;
		}
	}
	return input;
}

string SpellChecker::toLower( string input )
{
	//converts the characters one at a time
	//regardless of whether they are lower case
	for( size_t i = 0; i < input.size(); i++ )
	{
		input[i] = char( tolower( input[i] ) );
	}
	return input;
}