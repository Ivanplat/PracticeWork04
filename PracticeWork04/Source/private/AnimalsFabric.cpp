#include "../public/AnimalsFabric.h"
#include "../public/Animals.h"
#include <iostream>

AnimalsFabric* AnimalsFabric::Instance()
{
	static AnimalsFabric af;
	return &af;
}

IAnimal* AnimalsFabric::CreateAnimal(unsigned int ID)
{
	IAnimal* lAnimal;
	switch (ID)
	{
	case 0: {lAnimal = new Cat(); Cats.push_back(dynamic_cast<Cat*>(lAnimal)); } break;
	case 1: {lAnimal = new Dog(); Dogs.push_back(dynamic_cast<Dog*>(lAnimal)); } break;
	case 2: {lAnimal = new Humster(); Humsters.push_back(dynamic_cast<Humster*>(lAnimal)); } break;
	case 3: {lAnimal = new Hippo(); Hippos.push_back(dynamic_cast<Hippo*>(lAnimal)); } break;
	default: lAnimal = nullptr; break;
	}
	return lAnimal;
}

void AnimalsFabric::CountAnimals()
{
	if (!Cats.empty())
	{
		std::cout<<"Cats: "<<Cats[0]->Count<<std::endl;
	}
	else
	{
		std::cout << "Cats: 0"  << std::endl;
	}
	if (!Dogs.empty())
	{
		std::cout << "Dogs: " << Dogs[0]->Count << std::endl;
	}
	else
	{
		std::cout << "Dogs: 0" << std::endl;
	}
	if (!Humsters.empty())
	{
		std::cout << "Humsters: " << Humsters[0]->Count << std::endl;
	}
	else
	{
		std::cout << "Humsters: 0" << std::endl;
	}
	if (!Hippos.empty())
	{
		std::cout << "Hippos: " << Hippos[0]->Count << std::endl;
	}
	else
	{
		std::cout << "Hippos: 0" << std::endl;
	}
}


AnimalsFabric::~AnimalsFabric() noexcept
{
	for (auto i : Cats)
	{
		if (i)
		{
			delete i;
			i = nullptr;
		}
	}
	for (auto i : Dogs)
	{
		if (i)
		{
			delete i;
			i = nullptr;
		}
	}
	for (auto i : Humsters)
	{
		if (i)
		{
			delete i;
			i = nullptr;
		}
	}
	for (auto i : Hippos)
	{
		if (i)
		{
			delete i;
			i = nullptr;
		}
	}
}
