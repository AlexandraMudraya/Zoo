using Zoo;

Aviary bigAviary = new Aviary("для слонов", "тропики", 500);

List<AbstractAnimals> elephant = new List<AbstractAnimals>()
{
    new ElephantAnimals("слон", "тропики", 70, "сено", "травоядный", "ауф", "Мира", 300, 4, "трубить хоботом"),
    new ElephantAnimals("слон", "тропики", 70, "сено", "травоядный", "ауф", "Боря", 300, 5, "трубить хоботом")
};

ElephantAnimals elephantFaina = new ElephantAnimals("слон", "тропики", 70, "сено", "травоядный", "аууф", "Фаина", 300, 4, "трубить хоботом");
//ElephantAnimals elephantBorya = new ElephantAnimals("слон", "тропики", 70, "сено", "травоядный", "ауф", "Боря", 300, 5, "трубить хоботом");

//elephant.Add(elephantFaina);
//elephant.Add(elephantBorya);


bigAviary.PlusAnimal(elephant, elephantFaina);
bigAviary.ListAnimals(elephant);
//ElephantAnimals[] elephant =  new ElephantAnimals[2];

//elephant[0] = new ElephantAnimals("слон", "тропики", 70, "сено", "травоядный", "ауф", "Боря", 300, 5, "трубить хоботом");
//elephant[1] = new ElephantAnimals("слон", "тропики", 70, "сено", "травоядный", "ауф", "Мира", 300, 4, "трубить хоботом");


//AbstractAnimals[] newElephant;
//newElephant = bigAviary.PlusAnimal(elephant, elephantFaina);

//ElephantAnimals elephantDoby = new ElephantAnimals("слон", "тропики", 70, "сено", "травоядный", "ауууф", "Доби", 250, 1, "трубить хоботом");

//AbstractAnimals[] new2Elephant;
//new2Elephant = bigAviary.PlusAnimal(newElephant, elephantDoby);

//AbstractAnimals[] new3Elephant;
//new3Elephant = bigAviary.MinusAnimal(new2Elephant, elephantFaina);
//bigAviary.ListAnimals(new3Elephant);

//bigAviary.FeedAnimals(new3Elephant, 800, "сено");

//bigAviary.MakeASoundAllAnimals(new3Elephant);



//Aviary penguinAviary = new Aviary("для пингвинов", "тундра", 50);

//PenguinAnimals[] penguin = new PenguinAnimals[3];

//penguin[0] = new PenguinAnimals("пингвин", "тундра", 10, "рыба", "хищник", "гргргр", "Толик", 0.3, 1, "плавать");
//penguin[1] = new PenguinAnimals("пингвин", "тундра", 10, "рыба", "хищник", "гргр", "Симба", 0.35, 3, "плавать");
//penguin[2] = new PenguinAnimals("пингвин", "тундра", 10, "рыба", "хищник", "гргргр", "Руби", 0.4, 3, "плавать");

//penguinAviary.ListAnimals(penguin);

//PenguinAnimals penguinSonya = new PenguinAnimals("пингвин", "тундра", 10, "рыба", "хищник", "гр", "Соня", 0.3, 2, "плавать");

//AbstractAnimals[] newPenguin;
//newPenguin = penguinAviary.PlusAnimal(penguin, penguinSonya);


//AbstractAnimals[] new2Penguin;
//new2Penguin = penguinAviary.MinusAnimal(newPenguin, penguin[0]);

//penguinAviary.FeedAnimals(new2Penguin, 1.15, "рыба");

//penguinAviary.MakeASoundAllAnimals(new2Penguin);