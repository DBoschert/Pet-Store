﻿using Pet_Store;

var dog1 = new Dog { Breed = "Golden Retriever", Color = "Yellow", Speak = "Woof" };
var dog2 = new Dog { Breed = "English Mastiff", Color = "Brindle", Speak = "A Very Deep Bark!" };

var cat1 = new Cat { Breed = "American Short Hair", Age = 5, Speak = "Purrrrrrrr" };
var cat2 = new Cat { Breed = "Hairless", Age = 3, Speak = "CLicking and Chirping" };

var hamster1 = new Hamster { Breed = "Fancy", Color = "Gold", Speak = "Squeak" };
var hamster2 = new Hamster { Breed = "Teddy Bear", Color = "Black & White", Speak = "Roar" };


IBreedSpeak[] pets = { dog1, dog2, cat1, cat2, hamster1, hamster2 };

foreach(var pet in pets)
{
    Console.WriteLine($"We have a {pet.Breed} which makes a sound of {pet.Speak} ");
}

interface IBreedSpeak
{
    string Breed { get; set; }
    string Speak { get; set; }
}