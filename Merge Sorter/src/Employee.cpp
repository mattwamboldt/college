//Title:	Employee implementation
//Author:	Matthew Wamboldt
//Date:		February 24th, 2008
//Version:	1.0

#include "Employee.h"
#include <iostream>
int Employee::ourCompareField = 1;

bool Employee::operator ==(const Employee& emp2)
{
	switch(ourCompareField)
	{
		case 1:
			return myId == emp2.myId;

		case 2:
			return myLastName == emp2.myLastName;

		case 3:
			return myFirstName == emp2.myFirstName;

		case 4:
			return myMiddleInitial == emp2.myMiddleInitial;

		case 5:
			return myStreetAddress == emp2.myStreetAddress;

		case 6:
			return myCity == emp2.myCity;

		case 7:
			return myProvince == emp2.myProvince;

		case 8:
			return myPostalCode == emp2.myPostalCode;

		case 9:
			return myPhoneNumber == emp2.myPhoneNumber;

		case 10:
			return myGender == emp2.myGender;

		case 11:
			return myAge == emp2.myAge;

		case 12:
			return myNumDependents == emp2.myNumDependents;

		case 13:
			return myDeptCategory == emp2.myDeptCategory;

		case 14:
			return amInUnion == emp2.amInUnion;

		case 15:
			return myHourlyRate == emp2.myHourlyRate;
	}
	return false;
}

bool Employee::operator <(const Employee& emp2)
{
	switch(ourCompareField)
	{
		case 1:
			return myId < emp2.myId;

		case 2:
			return myLastName < emp2.myLastName;

		case 3:
			return myFirstName < emp2.myFirstName;

		case 4:
			return myMiddleInitial < emp2.myMiddleInitial;

		case 5:
			return myStreetAddress < emp2.myStreetAddress;

		case 6:
			return myCity < emp2.myCity;

		case 7:
			return myProvince < emp2.myProvince;

		case 8:
			return myPostalCode < emp2.myPostalCode;

		case 9:
			return myPhoneNumber < emp2.myPhoneNumber;

		case 10:
			return myGender < emp2.myGender;

		case 11:
			return myAge < emp2.myAge;

		case 12:
			return myNumDependents < emp2.myNumDependents;

		case 13:
			return myDeptCategory < emp2.myDeptCategory;

		case 14:
			return amInUnion < emp2.amInUnion;

		case 15:
			return myHourlyRate < emp2.myHourlyRate;
	}
	return false;
}

bool Employee::operator <=(const Employee& emp2)
{
	switch(ourCompareField)
	{
		case 1:
			return myId <= emp2.myId;

		case 2:
			return myLastName <= emp2.myLastName;

		case 3:
			return myFirstName <= emp2.myFirstName;

		case 4:
			return myMiddleInitial <= emp2.myMiddleInitial;

		case 5:
			return myStreetAddress <= emp2.myStreetAddress;

		case 6:
			return myCity <= emp2.myCity;

		case 7:
			return myProvince <= emp2.myProvince;

		case 8:
			return myPostalCode <= emp2.myPostalCode;

		case 9:
			return myPhoneNumber <= emp2.myPhoneNumber;

		case 10:
			return myGender <= emp2.myGender;

		case 11:
			return myAge <= emp2.myAge;

		case 12:
			return myNumDependents <= emp2.myNumDependents;

		case 13:
			return myDeptCategory <= emp2.myDeptCategory;

		case 14:
			return amInUnion <= emp2.amInUnion;

		case 15:
			return myHourlyRate <= emp2.myHourlyRate;
	}
	return false;
}

bool Employee::operator >(const Employee& emp2)
{
	switch(ourCompareField)
	{
		case 1:
			return myId > emp2.myId;

		case 2:
			return myLastName > emp2.myLastName;

		case 3:
			return myFirstName > emp2.myFirstName;

		case 4:
			return myMiddleInitial > emp2.myMiddleInitial;

		case 5:
			return myStreetAddress > emp2.myStreetAddress;

		case 6:
			return myCity > emp2.myCity;

		case 7:
			return myProvince > emp2.myProvince;

		case 8:
			return myPostalCode > emp2.myPostalCode;

		case 9:
			return myPhoneNumber > emp2.myPhoneNumber;

		case 10:
			return myGender > emp2.myGender;

		case 11:
			return myAge > emp2.myAge;

		case 12:
			return myNumDependents > emp2.myNumDependents;

		case 13:
			return myDeptCategory > emp2.myDeptCategory;

		case 14:
			return amInUnion > emp2.amInUnion;

		case 15:
			return myHourlyRate > emp2.myHourlyRate;
	}
	return false;
}

bool Employee::operator >=(const Employee& emp2)
{
	switch(ourCompareField)
	{
		case 1:
			return myId >= emp2.myId;

		case 2:
			return myLastName >= emp2.myLastName;

		case 3:
			return myFirstName >= emp2.myFirstName;

		case 4:
			return myMiddleInitial >= emp2.myMiddleInitial;

		case 5:
			return myStreetAddress >= emp2.myStreetAddress;

		case 6:
			return myCity >= emp2.myCity;

		case 7:
			return myProvince >= emp2.myProvince;

		case 8:
			return myPostalCode >= emp2.myPostalCode;

		case 9:
			return myPhoneNumber >= emp2.myPhoneNumber;

		case 10:
			return myGender >= emp2.myGender;

		case 11:
			return myAge >= emp2.myAge;

		case 12:
			return myNumDependents >= emp2.myNumDependents;

		case 13:
			return myDeptCategory >= emp2.myDeptCategory;

		case 14:
			return amInUnion >= emp2.amInUnion;

		case 15:
			return myHourlyRate >= emp2.myHourlyRate;
	}
	return false;
}

ostream& operator <<(ostream& output, const Employee& emp)
{
	output << emp.myId << "\t"
		<< emp.myLastName << "\t"
		<< emp.myFirstName << "\t"
		<< emp.myMiddleInitial << "\t"
		<< emp.myStreetAddress << "\t"
		<< emp.myCity << "\t"
		<< emp.myProvince << "\t"
		<< emp.myPostalCode << "\t"
		<< emp.myPhoneNumber << "\t"
		<< emp.myGender << "\t"
		<< emp.myAge << "\t"
		<< emp.myNumDependents << "\t"
		<< emp.myDeptCategory << "\t"
		<< emp.amInUnion << "\t"
		<< emp.myHourlyRate << "\n";
	return output;
}

istream& operator >>(istream& input, Employee& emp)
{
	input >> emp.myId
		>> emp.myLastName
		>> emp.myFirstName
		>> emp.myMiddleInitial;

	//clear out tab before getline then retrieve the value including spaces
	//up to the next tab
	input.get();
	getline( input, emp.myStreetAddress, '\t' );

	input >> emp.myCity
		>> emp.myProvince;

	input.get();
	getline( input, emp.myPostalCode, '\t' );

	input >> emp.myPhoneNumber
		>> emp.myGender
		>> emp.myAge
		>> emp.myNumDependents
		>> emp.myDeptCategory
		>> emp.amInUnion
		>> emp.myHourlyRate;

	return input;
}
