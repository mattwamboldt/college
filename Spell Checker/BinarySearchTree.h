#ifndef BinarySearchTree_H
#define BinarySearchTree_H

#include "Node.h"
#include <iostream>
#include <iomanip>
using namespace std;

namespace BST
{
	/*! \brief An implementation of a Binary Search Tree
		\author Matthew Wamboldt
		\version 1.0
		\date February 21st, 2008

		Stores data in a tree structure with two branches per node.
		The greater values go on the right the smaller values go
		on the left.
	*/
	template<class Type>
	class BinarySearchTree
	{
		typedef Node<Type>* NodePtr; /*!< Node pointer typedef */

		private:
			NodePtr myRoot; /*!< The root node of the tree */

		public:
			/*! \brief Constructor.
				\param[in] root The node to use as the root.
				\return A new BinarySearchTree object.
			*/
			BinarySearchTree( NodePtr root = 0 )
				:myRoot( root )
			{}

		private:
			/*! \brief Copy Constructor(unusable)
				\param[in] original The list to be copied.
				\return A new BinarySearchTree object that is a copy of the original.
			*/
			BinarySearchTree( const BinarySearchTree<Type>& original )
			{}

			/*! \brief overloaded equals operator(unusable)
				\param[in] rightSide The tree used to create the new tree.
			*/
			BinarySearchTree<Type>& operator =( const BinarySearchTree<Type>& rightSide )
			{}

		public:
			/*! \brief Destructor */
			~BinarySearchTree()
			{
				ClearTree( myRoot );
			}

			/*! \brief Inserts data into the tree
				\param[in] data The Data to be inserted
			*/
			inline void Insert( Type* data )
			{
				Insert( data, myRoot );
			}

			/*! \brief Inserts data into the tree at the given node
				\param[in] data The Data to be inserted
				\param[in] node A Reference to the node where you want to insert
			*/
			inline void Insert( Type* data, NodePtr& node )
			{
				if( node == 0 )
				{
					node = new Node<Type>( data );
				}
				else if( *data > node->GetData() )
				{
					Insert( data, node->GetRightLeaf() );
				}
				else if( *data < node->GetData() )
				{
					Insert( data, node->GetLeftLeaf() );
				}
			}

			/*! \brief Removes a subtree
				\param[in] nodeToRemove The node/subtree to delete

				Removes the nodes recursively from the bottom up.
			*/
			inline void ClearTree( NodePtr& nodeToRemove )
			{
				if( nodeToRemove->GetRightLeaf() != 0 )
				{
					ClearTree( nodeToRemove->GetRightLeaf() );
				}

				if( nodeToRemove->GetLeftLeaf() != 0 )
				{
					ClearTree( nodeToRemove->GetLeftLeaf() );
				}

				if( nodeToRemove != 0 )
				{
					delete nodeToRemove;
				}
			}

			/*! \brief Finds out if data is in the tree
				\param[in] data The data to search for
				\return Whether the data is in the tree
			*/
			inline bool Find( const Type& data )
			{
				return Find( data, myRoot );
			}

			/*! \brief Finds out if data is in the given subtree
				\param[in] data The data to search for
				\param[in] node The node of the subtree to look in
				\return Whether the data is in the tree
			*/
			inline bool Find( const Type& data, NodePtr& node )
			{
				if( node == 0 )
				{
					return false;
				}

				if( node->GetData() == data )
				{
					return true;
				}

				return ( Find( data, node->GetRightLeaf() )
					|| Find( data, node->GetLeftLeaf() ) );
			}

			/*! \brief Prints the tree to an output stream
				\param[out] output The stream to write to
				\param[in] node The node of the subtree to be printed
				\param[in] indent The amount of spaces to indent the nodes contents by

				This requires an overloaded output operator for the data in the tree.
			*/
			inline void PrintTree( ostream& output, NodePtr node, int indent )
			{
				if( node != 0 )
				{
					PrintTree( output, node->GetRightLeaf(), indent + 8 );
					output << setw( indent ) << node->GetData() << endl;
					PrintTree( output, node->GetLeftLeaf(), indent + 8 );
				}
			}

			/*! \brief Overloaded output operator
				\param[out] output The stream to write to
				\param[in] bst The Tree to be output
				\return The passed in output stream to allow chaining

				This requires an overloaded output operator for the data in the tree.
			*/
			friend ostream& operator <<( ostream& output, BinarySearchTree<Type>& bst )
			{
				bst.PrintTree( output, bst.myRoot, 0 );
				return output;
			}
	};
}

#endif