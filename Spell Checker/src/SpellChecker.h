#ifndef SPELLCHECKER_H
#define SPELLCHECKER_H

#include "BinarySearchTree.h"
#include "Stack.h"
#include <string>
#include <fstream>
#include <cctype>
using namespace std;
using namespace BST;
using namespace MWStack;

/*! \brief Checks the spelling of words in a file
	\author Matthew Wamboldt
	\version 1.0
	\date February 21st, 2008

	Using a properly structured dictionary file This
	will check the spelling in the file and return a list of
	the errors. It also outputs the dictionary.
*/
class SpellChecker
{
	private:
		BinarySearchTree<string> myDictionary; /*!< The tree that holds the dictionary words*/
		Stack<string> myWords; /*!< The Stack that holds the words in the file to be corrected */

	public:
		/*! \brief Constructor(empty)
			\return A new SpellChecker object.
		*/
		SpellChecker()
		{}

		/*! \brief Loads the dictionary file
		    \param[in] fileName The location of the dictionary file
			\return Whether this succeeds.
		*/
		bool LoadDictionary( string fileName );

		/*! \brief Loads the file to spell check
		    \param[in] fileName The location of the file to be checked
			\return Whether this succeeds.
		*/
		bool LoadFileToCheck( string filename );

		/*! \brief Writes the incorrect words to the stream
		    \param[out] output The output stream to be written to.
		*/
		void DisplayErrors( ostream& output );

	private:
		/*! \brief Erases the punctuation from a string
		    \param[in] input The string to be cleared of punctuation
		*/
		string removePunctuation( string input );

		/*! \brief Converts a string to lower case
		    \param[in] input The string to be converted
		*/
		string toLower( string input );
};

#endif