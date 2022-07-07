//Title:			Double Linked List Iterator definition
//Purpose:			Defines a class for a doubly linked iterator
//Author:			Matthew Wamboldt
//Date: 			November 13th, 2007
//Last Modified:	November 26th, 2007
#include "DoubleLinkNode.h"
#ifndef DOUBLELINKITERATOR_H
#define DOUBLELINKITERATOR_H

template<class Type>
class DoubleLinkIterator{
public:
	//Constructors
	DoubleLinkIterator()
		:my_current_node(NULL)
	{}
	DoubleLinkIterator(DoubleLinkNode<Type>* starting_node)
		:my_current_node(starting_node)
	{}

	//manipulate the address the iterator points to
	DoubleLinkNode<Type>* get_current_node(){ 
		return my_current_node;
	}
	void set_current_node(DoubleLinkNode<Type>* incoming_node){
		my_current_node = incoming_node;
	}

	//allows manipulation of the data in the node
	Type& operator *(){
		return my_current_node->get_data_for_manipulation();
	}

	//increment and decrement operators to navigate the list
	DoubleLinkIterator operator ++(){
		my_current_node = my_current_node->get_next_link();
		return *this;
	}

	DoubleLinkIterator operator ++(int){
		DoubleLinkIterator original_iterator(my_current_node);
		my_current_node = my_current_node->get_next_link();
		return original_iterator;
	}

	DoubleLinkIterator operator --(){
		my_current_node = my_current_node->get_previous_link();
		return *this;
	}

	DoubleLinkIterator operator --(int){
		DoubleLinkIterator original_iterator(my_current_node);
		my_current_node = my_current_node->get_previous_link();
		return original_iterator;
	}

	//comparison operators
	bool operator ==(const DoubleLinkIterator& right_side) const{
		return my_current_node == right_side.my_current_node;
	}

	bool operator !=(const DoubleLinkIterator& right_side) const{
		return my_current_node != right_side.my_current_node;
	}

private:
	DoubleLinkNode<Type> *my_current_node;

};

#endif
