//Title:			Node class definition
//Purpose:			Difining a class for a doubly linked list 
//Author:			Matthew Wamboldt
//Date: 			November 13th, 2007
//Last Modified:	November 26th, 2007
#include <cstddef>
#ifndef DOUBLELINKNODE_H
#define DOUBLELINKNODE_H

template<class Type>
class DoubleLinkNode{
public:
	//constructor
	DoubleLinkNode(Type incoming_data,
		DoubleLinkNode<Type> *incoming_previous_link, DoubleLinkNode<Type> *incoming_next_link)
		:my_data(incoming_data), my_previous_link(incoming_previous_link), my_next_link(incoming_next_link)
	{}

	//getter functions for links and data
	DoubleLinkNode<Type>* get_next_link(){
		return my_next_link;
	}
	DoubleLinkNode<Type>* get_previous_link(){
		return my_previous_link;
	}

	Type& get_data_for_manipulation(){
		return my_data;
	}
	const Type get_data(){
		return my_data;
	}

	//setter functions for links and data
	void set_next_link(DoubleLinkNode<Type>* incoming_next_link){
		my_next_link = incoming_next_link;
	}
	void set_previous_link(DoubleLinkNode<Type>* incoming_previous_link){
		my_previous_link = incoming_previous_link;
	}
	void set_data(const Type& incoming_data){
		my_data = incoming_data;
	}

private:
	Type my_data;
	DoubleLinkNode<Type> *my_previous_link;
	DoubleLinkNode<Type> *my_next_link;
};

#endif