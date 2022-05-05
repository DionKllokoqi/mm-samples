IGenericList listOfElements = new GenericList();

listOfElements.DoSomething<Animal>(new Animal());
listOfElements.DoSomething<double>(2.5);

Console.ReadLine();
