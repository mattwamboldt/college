/*
Title:		Spell checker test app
Author:		Matthew Wamboldt
Date:		February 21st, 2008
Version:	1.0
*/

#include <iostream>
using namespace std;
#include "SpellChecker.h"

int main()
{
	SpellChecker check;

	if( check.LoadDictionary( "data/dictionary.txt" ) )
	{
		if( check.LoadFileToCheck( "data/incorrectText.txt" ) )
		{
			//displays both to screen and a file
			check.DisplayErrors( cout );

			ofstream errorOutput( "errorLog.txt" );
			check.DisplayErrors( errorOutput );
			errorOutput.close();
		}
		else
		{
			cout << "Error loading file to be spell checked" << endl;
		}
	}
	else
	{
		cout << "Error loading dictionary file" << endl;
	}
	
	return 0;
}