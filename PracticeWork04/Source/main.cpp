#include "public/Animals.h"
#include "public/AnimalsFabric.h"
#include <random>
#include <iostream>

int main()
{
	AnimalsFabric::Instance();

	std::random_device rd;
	std::mt19937 gen(rd());
	std::uniform_int_distribution<> randCount(1, 100);
	std::uniform_int_distribution<> distr(0, 3);

	for (int i = 0; i < randCount(gen); i++)
	{
		AnimalsFabric::Instance()->CreateAnimal(distr(gen))->Speak();
	}
	AnimalsFabric::Instance()->CountAnimals();
	
	return 0;
}