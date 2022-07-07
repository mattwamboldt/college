#ifndef NODE_H
#define NODE_H

namespace BST
{
	/*! \brief Used to build Binary tree nodes
		\author Matthew Wamboldt
		\version 1.0
		\date February 21st, 2008

		A Node class that can be used to build binary tree based
		data structures. Is template based for use with any data.
	*/
	template<class Type>
	class Node
	{
		typedef Node<Type>* NodePtr; /*!< Node pointer typedef */

		private:
			Type* myData; /*!< The data in the Node. */
			NodePtr myRightLeaf; /*!< A pointer to the right subtree. */
			NodePtr myLeftLeaf; /*!< A pointer to the left subtree. */

			/*! \brief Copy Constructor[unusable]
				\param[in] original The Node to be copied
				\return A new Node that is a copy of the given node.
			*/
			Node( const Node<Type>& original )
			{}

			Node<Type> operator =( const Node<Type>& rightHandSide )
			{}

		public:
			/*! \brief Constructor
				\param[in] data A pointer to the data to be stored
				\param[in] rightLeaf A pointer to an existing right subtree
				\param[in] leftLeaf A pointer to an existing left subtree
				\return A new Node object.
			*/
			Node( Type* data = 0, NodePtr rightLeaf = 0, NodePtr leftLeaf = 0 )
				:myData( data ), myRightLeaf( rightLeaf ), myLeftLeaf( leftLeaf )
			{}

			/*! \brief Destructor */
			~Node()
			{
				if( myData != 0 )
				{
					delete myData;
				}
			}

			/*! \brief Sets the data in the node
				\param[in] data A pointer to the data to be stored
			*/
			inline void SetData( Type* data )
			{
				myData = data;
			}

			/*! \brief Sets the right subtree of the node
				\param[in] data A pointer to the new right node
			*/
			inline void SetRightLeaf( NodePtr rightLeaf )
			{
				myRightLeaf = rightLeaf;
			}

			/*! \brief Sets the left subtree of the node
				\param[in] data A pointer to the new left node
			*/
			inline void SetLeftLeaf( NodePtr leftLeaf )
			{
				myLeftLeaf = leftLeaf;
			}

			/*! \brief Gets the data in the node
				\return The data in the node
			*/
			inline Type GetData()
			{
				return *myData;
			}

			/*! \brief Gets a pointer to the data in the node
				\return A pointer to the data in the node
			*/
			inline Type* GetDataPtr()
			{
				return myData;
			}

			/*! \brief Gets the right node
				\return The right node
			*/
			inline NodePtr& GetRightLeaf()
			{
				return myRightLeaf;
			}

			/*! \brief Gets the left node
				\return The left node
			*/
			inline NodePtr& GetLeftLeaf()
			{
				return myLeftLeaf;
			}
	};
}

#endif