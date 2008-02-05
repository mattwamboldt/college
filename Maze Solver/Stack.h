#ifndef STACK_H
#define STACK_H
#include "Node.h"

template<class Type>

/*! \brief A template version of a Stack Class.
    \author Matthew Wamboldt
	\version 1.0
	\date January 22nd, 2008

	This is a fully functional linked list implmentation of a stack.
	It uses templates to allow it to be used by any data.
*/
class Stack
{
	protected:
		Node<Type> *myHead; /*!< A pointer the the top of the Stack. */
		int myCount; /*!< The number of elements in the Stack. */

	public:	
		/*! \brief Default Constructor. 
			\return A new empty Stack object.
			
			This constructor takes no arguments, and creates an empty
			Stack.
		*/
		Stack()
			:myHead( NULL ), myCount( 0 )
		{}

		/*! \brief Constructor.
		    \param[in] incomingData The data to be added to the Stack.
			\return A new Stack object.
			
			This constructor creates a new stack object with a single node
			containing the given data.
		*/
		Stack( Type incomingData )
			:myHead( new Node<Type>( incomingData, NULL ) ), myCount( 1 )
		{ }

		/*! \brief Copy Constructor. 
		    \param[in] originalStack The stack to be copied.
			\return A new copy of originalStack.
			
			This copy constructor exists for completeness, and is not used
			often in code. It creates a new stack based on the values of the
			originalStack.
		*/
		Stack( Stack<Type>& originalStack )
		{
			if( originalStack.myHead != NULL )
			{
				myHead = new Node<Type>( originalStack.Top() );
				
				Node<Type>* bottomPtr = myHead;
				Node<Type>* originalStackPtr = originalStack.myHead->GetNextLink();
				
				while( originalStackPtr != NULL )
				{
					bottomPtr->SetNextLink( new Node<Type>( *originalStackPtr ) );
					bottomPtr = bottomPtr->GetNextLink();
					originalStackPtr = originalStackPtr->GetNextLink();
				}
			}
			else
			{
				myHead = NULL;
			}
		}

		/*! \brief Overloaded equals. 
		    \param[in] rightSide The right side of the equals operation.
			\return A reference to the stack to allow chaining of equals.
			
			This equals operator exists for completeness, and is not used
			often in code. It removes the orginal stack and does a deep copy of the
			right side, and returns a reference to itself for chaining equals operations
			together.
		*/
		Stack<Type>& operator =( Stack<Type>& rightSide )
		{
			if( myHead != rightSide.myHead )
			{
				ClearStack();
				if( rightSide.myHead != NULL )
				{
					myHead = new Node<Type>( rightSide.Top() );
					
					Node<Type>* bottomPtr = myHead;
					Node<Type>* rightSidePtr = rightSide.myHead->GetNextLink();
					
					while( rightSidePtr != NULL )
					{
						bottomPtr->SetNextLink( new Node<Type>( *rightSidePtr ) );
						bottomPtr = bottomPtr->GetNextLink();
						rightSidePtr = rightSidePtr->GetNextLink();
					}
				}
			}
			return *this;
		}

		/*! \brief Removes a node from the top of the stack. */
		void pop()
		{
			Node<Type>* temp = myHead;
			myHead = myHead->GetNextLink();
			delete temp;
			--myCount;
		}

		/*! \brief Adds a new piece of data to the top of the stack.
		    \param[in] incomingData The data to be added.
		*/
		void push( Type incomingData )
		{
			myHead = new Node<Type>( incomingData, myHead );
			++myCount;
		}

		/*! \brief Returns whether the Stack is empty or not
		    \return  A boolean.
		*/
		bool empty()
		{
			return myHead == NULL;
		}

		/*! \brief Destructor, Clears the stack. */
		~Stack()
		{
			ClearStack();
		}

		/*! \brief Removes all the elements in the Stack. */
		void ClearStack()
		{
			while( myHead != NULL )
			{
				pop();
			}
		}

		/*! \brief Gets the top element of the Stack.
		    \return The top Node's data.
			\warning Make sure to use the empty function first.
		*/
		Type Top()
		{
			return myHead->GetData();
		}

		/*! \brief Gets the number of elements in the Stack.
		    \return An int.
		*/
		int Size()
		{
			return myCount;
		}
};
#endif
