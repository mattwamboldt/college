//Title:			Double Link Iterator Class definition
//Purpose:			Defines the methods used for a doubly linked list
//Author:			Matthew Wamboldt
//Date: 			November 13th, 2007
//Last Modified:	January 6th, 2007
#ifndef DOUBLELINKLIST_H
#define DOUBLELINKLIST_H
#include "DoubleLinkIterator.h"

template<class Type>
class DoubleLinkList{
private:
	DoubleLinkNode<Type> *my_head;
	DoubleLinkNode<Type> *my_end;
public:
	//constructors
	DoubleLinkList()
		:my_head(NULL), my_end(NULL)
	{}

	DoubleLinkList(Type incoming_data)
		:my_head(new DoubleLinkNode<Type>(incoming_data, NULL, NULL))
	{my_end = my_head;}

	//copy constructor
	DoubleLinkList(const DoubleLinkList<Type>& original_list){
		if( original_list.my_head != my_head ){
			empty_list();
			my_end = my_head = NULL;
			for( DoubleLinkIterator<Type> it = original_list.get_start_of_list();
				it != original_list.get_end_of_list(); it++){
					add_to_bottom(it.get_current_node()->get_data());
			}
		}
	}

	//destructor
	~DoubleLinkList(){
		empty_list();
	}

	//overloaded =
	DoubleLinkList<Type>& operator =(const DoubleLinkList<Type>& right_side){
		if( my_head != right_side.my_head ){
			empty_list();
			my_end = my_head = NULL;
			for( DoubleLinkIterator<Type> it = right_side.get_start_of_list();
				it != right_side.get_end_of_list(); it++){
					add_to_bottom(it.get_current_node()->get_data());
			}
		}
		return this;
	}

	//adds a new head node
	void add_to_top(Type incoming_data){
		DoubleLinkNode<Type> *temp = my_head;
		my_head = new DoubleLinkNode<Type>(incoming_data, NULL, temp);

		if( temp != NULL )
			temp->set_previous_link(my_head);
		if( my_end == NULL )
			my_end = my_head;
	}

	//adds a new end node
	void add_to_bottom(Type incoming_data){
		DoubleLinkNode<Type> *temp = my_end;
		my_end = new DoubleLinkNode<Type>(incoming_data, temp, NULL);

		if( temp != NULL )
			temp->set_next_link(my_end);

		if( my_head == NULL )
			my_head = my_end;
	}

	//add a new node after the node_before
	void add_after(DoubleLinkNode<Type>* node_before, Type incoming_data){

		DoubleLinkNode<Type> *temp;
		temp = new DoubleLinkNode<Type>(incoming_data, node_before, node_before->get_next_link());

		if( temp->get_next_link() != NULL )
			temp->get_next_link()->set_previous_link(temp);

		node_before->set_next_link(temp);

		if( node_before == my_end )
			my_end = temp;
	}

	//add a new node before the node_after
	void add_before(DoubleLinkNode<Type>* node_after, Type incoming_data){

		DoubleLinkNode<Type> *temp;
		temp = new DoubleLinkNode<Type>(incoming_data, node_after->get_previous_link(), node_after);

		if( temp->get_previous_link() != NULL )
			temp->get_previous_link()->set_next_link(temp);

		node_after->set_previous_link(temp);

		if( node_after == my_head )
			my_head = temp;
	}

	//removes a node from the list given it's not null
	void remove_node(DoubleLinkNode<Type>* node_to_remove){
		if( node_to_remove != NULL ){
			if( my_head == node_to_remove ){
				my_head = my_head->get_next_link();
				if( my_head != NULL ){
					my_head->set_previous_link(NULL);
				}
			}else if( my_end == node_to_remove ){
				my_end = my_end->get_previous_link();
				if( my_end != NULL ){
					my_end->set_next_link(NULL);
				}
			}else{
				DoubleLinkNode<Type>* previous_node = node_to_remove->get_previous_link();
				DoubleLinkNode<Type>* next_node = node_to_remove->get_next_link();
				previous_node->set_next_link(next_node);
				next_node->set_previous_link(previous_node);
			}
			delete node_to_remove;
		}
	}

	//delete the contents of the list
	void empty_list(){
		while(my_head != NULL){
			DoubleLinkNode<Type> *temp = my_head;
			my_head = my_head->get_next_link();
			delete temp;
		}
		my_end = my_head;
	}

	//return iterators for for looping
	DoubleLinkIterator<Type> get_start_of_list(){
		return DoubleLinkIterator<Type>(my_head);
	}
	DoubleLinkIterator<Type> get_end_of_list(){
		return DoubleLinkIterator<Type>();
	}

};
#endif
