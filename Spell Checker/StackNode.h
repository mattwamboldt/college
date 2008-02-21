#include <cstddef>
#ifndef STACKNODE_H
#define STACKNODE_H

namespace MWStack
{
	/*! \brief Used to build linked data structures
		\author Matthew Wamboldt
		\version 1.0
		\date February 1st, 2008

		A Single Link Node class that can be used to build simple
		data structures. Is template based for use with any data.
	*/
	template<class Type>
	class Node
	{
		private:
			Type myData; /*!< The data in the Node. */
			Node<Type> *myNextLink; /*!< A pointer to the next Node in the  containing data structure. */

		public:
			/*! \brief Default Constructor.
				\return A new empty Node object.
			*/
			Node()
				:myNextLink( NULL )
			{}

			/*! \brief Constructor.
				\param[in] incomingData The data for the new Node.
				\param[in] incomingNextLink A pointer to a Node.
				\return A new Node object.
			*/
			Node( Type incomingData, Node<Type>* incomingNextLink = NULL )
				:myData( incomingData ), myNextLink( incomingNextLink )
			{}

			/*! \brief Copy Constructor
				\param[in] incomingNode The Node to be copied
				\return A new Node that is a copy of the given node.
			*/
			Node( const Node<Type>& incomingNode )
				:myData( incomingNode.myData ), myNextLink( incomingNode.myNextLink )
			{}

			/*! \brief Get the node's next link.
				\return A Node pointer.
			*/
			inline Node<Type>* GetNextLink()
			{
				return myNextLink;
			}

			/*! \brief Allows for editing of the data in the Node.
				\return A reference to the Node's data.
			*/
			inline Type& GetDataForManipulation()
			{
				return myData;
			}

			/*! \brief Gets the data in the Node.
				\return An uneditable reference to the Node's data.
			*/
			inline const Type& GetData()
			{
				return myData;
			}

			/*! \brief Changes the Node's next link.
				\param[in] incomingNextLink The new link for the Node.
			*/
			inline void SetNextLink( Node<Type>* incomingNextLink )
			{
				myNextLink = incomingNextLink;
			}

			/*! \brief Replaces the data in the Node.
				\param[in] incomingData The new data for the Node.
			*/
			inline void SetData( const Type& incomingData )
			{
				myData = incomingData;
			}
	};

}

#endif